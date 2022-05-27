using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador3.Model
{
    internal class Elevador
    {
       
        //variável responsável pela capacidade total do elevador.
        public int TotalPessoas { get; set; } //atalho: prop + TAB + TAB

        //variável responsável por informar o andar atual.
        public int AndarAtual { get; set; }

        //variável responsável por informar quantas pessoas presentes no elevador.
        public int PessoasNoElevador { get; set; }

        //variável responsável por informar a quantidade de andares.
        public int TotalAndares { get; set; }


        //Método para inicializar o elevador.
        public void Inicializar(int capacidade, int andares)
        {
            TotalPessoas = capacidade;
            TotalAndares = andares;
            AndarAtual = 0;
            PessoasNoElevador = 0;

        }


        //Métado para entrar no elevador
        public bool Entrar()
        {
            if (PessoasNoElevador < TotalPessoas)
            {
                PessoasNoElevador++;
                return true;
            }
            else
                return false;
        }

        //Método para sair do elevador.
        public bool Sair()
        {
            if (PessoasNoElevador > 0)
            {
                PessoasNoElevador--;
                return true;
            }
            else
                return false;
        }

        //Métado para o elevador subir.
        public bool Subir()
        {
            if (AndarAtual < TotalAndares)
            {
                AndarAtual++;
                return true;
            }
            else
                return false;
        }


        //Método para o elevador descer.
        public bool Descer()
        {
            if (AndarAtual > 0)
            {
                AndarAtual--;
                return true;
            }
            else
                return false;
        }




        //Pessoasno elevador.
        public int Pessoas()
        {
            return PessoasNoElevador;
        }

        //Andar em que o elevador está parado.
        public int Andar()
        {
            return AndarAtual;
        }

    }
}
