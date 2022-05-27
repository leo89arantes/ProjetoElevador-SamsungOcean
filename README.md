# PROJETO FINAL - JORNADA MS

**VISAO GERAL DO PROJETO**

Neste projeto, você irá aplicar o conhecimento adquirido nesta jornada, este será um momento para exercitar a lógica de programação e praticar os tipos de dados, controle de fluxo, laços de repetição utilizando funções.  O projeto será publicado no seu github utilizando os comandos vistos durante a jornada.

O projeto será um software que tem como função o gerenciamento de um elevador, ele terá as funções de inicializar, entrar, sair, subir e descer.  

**INSTRUÇÕES**

Utilize o Visual Studio Community, crie um projeto **Aplicativo de Console** (**console app) como nome ProjetoElevador, utilize a estrutura .NET 5 ou inferior.**

Todas as classes deverão ficar em uma pasta chamada Model, a estrutura com as pastas de Controller e View são opcionais.

Crie uma classe denominada Elevador para armazenar as informações de um elevador
dentro de um prédio, a classe deve armazenar o andar atual (térreo = 0), total de andares
no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
presentes nele. A classe deve também disponibilizar os seguintes métodos:

**Métodos:**

***Inicializar*** : deve receber como parâmetros a capacidade do elevador e o total de
andares no prédio (os elevadores sempre começam no térreo e vazio);

***Entrar*** : deve acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
espaço);

***Sair*** : deve remover uma pessoa do elevador (só deve remover se houver alguém
dentro dele);

***Subir*** : deve subir um andar (não deve subir se já estiver no último andar);

***Descer*** : deve descer um andar (não deve descer se já estiver no térreo);
