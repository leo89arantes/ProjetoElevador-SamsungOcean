# PROJETO FINAL

**VISAO GERAL DO PROJETO**

Neste projeto, aplicamos o conhecimento adquirido na jornada MS-DEV OCEAN, este será um momento para exercitar a lógica de programação e praticar os tipos de dados, controle de fluxo, laços de repetição utilizando funções. 

Este projeto é um software que tem como função o gerenciamento de um elevador, ele terá as funções de inicializar, entrar, sair, subir e descer.  

**INSTRUÇÕES**

Utilizando o Visual Studio Community, criamos um projeto **Aplicativo de Console** (**console app) como nome ProjetoElevador, utilize a estrutura .NET 5.**

Todas as classes estão em uma pasta chamada Model.

Foi criada uma classe denominada Elevador para armazenar as informações de um elevador
dentro de um prédio, a classe armazena o andar atual (térreo = 0), total de andares
no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
presentes nele. A classe também disponibiliza os seguintes métodos:

***Inicializar*** : que recebe como parâmetros a capacidade do elevador e o total de andares no prédio (os elevadores sempre começam no térreo e vazio);

***Entrar*** : que acrescenta uma pessoa no elevador (só acrescenta se ainda houver espaço);

***Sair*** : que remove uma pessoa do elevador (só remove se houver alguém dentro dele);

***Subir*** : que sobe um andar (não sobe se já estiver no último andar);

***Descer*** : que desce um andar (não desce se já estiver no térreo);
