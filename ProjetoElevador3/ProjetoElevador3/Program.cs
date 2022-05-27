using ProjetoElevador3.Model;
using System;

namespace ProjetoElevador3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //O usuário informa a capacidade máxima do elevador.
            Console.WriteLine("Digite a capcaidade máxima de pessoas que o elevador suporta...: ");
            var capacidade = int.Parse(Console.ReadLine());

            //O usuário informa a quantidade de andares do prédio.
            Console.WriteLine("Digite o número máximo de andares do prédio....................: ");
            var andares = int.Parse(Console.ReadLine());


            //traz a capcaidade máxima e o número de andares informados pelo usuário.
            Elevador elevador = new Elevador();
            elevador.Inicializar(capacidade, andares);

            //Variáveis para exibir aas mensagens
            string mensagem = null;
            string mensagem1 = null;


            //Variável para controlar o while
            int continuar;


            do
            {
                //Limpa as perguntas inicíais.
                Console.Clear();

                //Painel de controle.
                Console.WriteLine($"Capacidade total de pessoas no elevador...: {capacidade}");
                Console.WriteLine($"Total de andares do prédio................: {andares}");
                Console.WriteLine($"Pessoas no elevador.......................: {elevador.Pessoas()}");
                Console.WriteLine($"Andar atual...............................: {elevador.Andar()}\n");

                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::");
                Console.WriteLine(":::::::::::::::::::PAINEL DE OPÇÕES:::::::::::::::::::");
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::");

                Console.WriteLine("");

                //Opções apresentadas oa usuário.
                Console.WriteLine("1 - Entrar");
                Console.WriteLine("2 - Sair");
                Console.WriteLine("3 - Subir");
                Console.WriteLine("4 - Descer");
                Console.WriteLine("5 - Fechar o simulador\n");

                Console.WriteLine("::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");

                //Para informar as mensagens que serão exibidas (switch > case > if / else).
                if (mensagem != null)
                {
                    Console.WriteLine($"{mensagem}\n");
                    mensagem = null;
                }
                else
                    Console.WriteLine($"{mensagem1}\n");
                mensagem1 = null;
                
                Console.Write("Selecione uma opção: ");

                //Verifica se o usuário informou um número inteiro.
                if (!int.TryParse(Console.ReadLine(), out continuar))
                    continuar = 0;

                //Início do painel de opção.
                switch (continuar)
                {
                    case 1:
                        if (!elevador.Entrar())
                        {
                            mensagem = "O elevador atingiu a capcaidade total.";
                        }
                        else
                            mensagem1 = "Uma pessoa entrou no elevador.";
                        break;
                    case 2:
                        if (!elevador.Sair())
                        {
                            mensagem = "O elevador está vazio.";
                        }
                        else
                            mensagem1 = "Uma pessoa saiu do elevador.";
                        break;
                    case 3:
                        if (!elevador.Subir())
                        {
                            mensagem = "Chegamos ao último andar.";
                        }
                        else
                            mensagem1 = "Subindo.";
                        break;
                    case 4:
                        if (!elevador.Descer())
                        {
                            mensagem = "Chegamos no Térreo.";
                        }
                        else
                            mensagem1 = "Descendo.";
                        break;
                    case 5:
                        Console.WriteLine("Fechando o simulador");
                        break;

                    //Mensagem exibida qundo o usuário digitar um número inválido.
                    default:
                        mensagem = "Opção inválida!";
                        break;
                }
            }
            while (continuar != 5);
        }


    }
    
}

