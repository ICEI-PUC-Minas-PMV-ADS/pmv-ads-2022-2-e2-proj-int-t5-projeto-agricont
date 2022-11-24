# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

Por exemplo: a tabela a seguir deverá ser preenchida considerando os artefatos desenvolvidos.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir que o usuário se cadastre na aplicação. |  UsuariosController.cs/Usuario.cs/ 20221018193126_Ag01.cs/ Usuario (Create.cshtml) |
|RF-002|  O sistema deve permitir que o usuário faça o login.   |  UsuariosController.cs/ Login.cs/ Usuario (Login.cshtml)  |
|RF-003|  O sistema deve permitir que o usuário altere a senha do seu login. |  UsuariosController.cs/Usuario.cs/ 20221018193126_Ag01.cs/ Usuario (Edit.cshtml)/ EditPasswordModel.cs/ Usuario (EditPassword.cshtml)   |
|RF-004|  O sistema deve permitir que o usuário cadastre o patrimônio por categoria como: maquinário, veículos, ferramentas e informática  |  FerramentasController.cs/Ferramenta.cs/ 20221023092107_Ag03.cs / Ferramentas (Create.cshtml) - InformaticasController.cs/ Informatica.cs/ 20221023054053_Agri02.cs/ Informaticas (Create.cshtml) - MaquinariosController.cs/ Maquinario.cs/ 20221106053021_Ag04.cs/ Maquinario (Create.cshtml) - VeiculosController.cs/ Veiculo.cs/20221107033719_Ag05.cs/ Veiculos (Create.cshtml) |
|RF-005|  O sistema deve permitir que o usuário insira a última data de manutenção.  | FerramentasController.cs/Ferramenta.cs/ Ferramentas (Create.cshtml) - InformaticasController.cs/ Informatica.cs/ Informaticas (Create.cshtml) - MaquinariosController.cs/ Maquinario.cs/ Maquinario (Create.cshtml) - VeiculosController.cs/ Veiculo.cs/ Veiculos (Create.cshtml) |
|RF-006|  O site deve permitir que o usuário entre em contato com a AgriCont através da página fale conosco.  | EnviaFaleConosco.cs / FormFaleConosco.cs / Email.cs/ IEmail.cs / EnviaFaleConosco (FaleConosco.cshtml)      |
|RF-007| O site deve permitir que o usuário informe se o equipamento está ativo ou inativo. |  FerramentasController.cs/Ferramenta.cs/ Ferramentas (Create.cshtml) - InformaticasController.cs/ Informatica.cs/ Informaticas (Create.cshtml) / MaquinariosController.cs/ Maquinario.cs/ Maquinario (Create.cshtml) / VeiculosController.cs/ Veiculo.cs/ Veiculos (Create.cshtml)  |
|RF-008| O site deve permitir que o usuário pesquise as informações cadastradas de cada patrimônio  |  Ferramentas (Index.cshtml) -  Informaticas (Index.cshtml) -  Maquinario (Index.cshtml) - Veiculos (Index.cshtml)  |
|RF-009|  O site deve permitir que o usuário cadastre o valor da depreciação do patrimônio. |FerramentasController.cs/Ferramenta.cs/ Ferramentas (Create.cshtml) - InformaticasController.cs/ Informatica.cs/ Informaticas (Create.cshtml) / MaquinariosController.cs/ Maquinario.cs/ Maquinario (Create.cshtml) / VeiculosController.cs/ Veiculo.cs/ Veiculos (Create.cshtml) |
|RF-010|  O site deve informar sobre a importância de um controle patrimonial.  |  Home (Index.cshtml) |
|RF-011|  O sistema deve permitir que o usuário cadastre os equipamentos da empresa com os dados da nota fiscal.  | FerramentasController.cs/Ferramenta.cs/ Ferramentas (Create.cshtml) - InformaticasController.cs/ Informatica.cs/ Informaticas (Create.cshtml) / MaquinariosController.cs/ Maquinario.cs/ Maquinario (Create.cshtml) / VeiculosController.cs/ Veiculo.cs/ Veiculos (Create.cshtml) |
|RF-012|  O sistema deve permitir que o usuário cadastre os dados da apólice de seguro.| FerramentasController.cs/Ferramenta.cs/ Ferramentas (Create.cshtml) - InformaticasController.cs/ Informatica.cs/ Informaticas (Create.cshtml) / MaquinariosController.cs/ Maquinario.cs/ Maquinario (Create.cshtml) / VeiculosController.cs/ Veiculo.cs/ Veiculos (Create.cshtml) |
|RF-013|  O sistema deve gerar um relatório com todo patrimônio da empresa. | RelatoriosController.cs / Relatorios (Index.cshtml) |
|RF-014|  O sistema deve permitir que o usuário edite todas as informações do cadastro do patrimônio. |  FerramentasController.cs/Ferramenta.cs/ Ferramentas (Edit.cshtml) - InformaticasController.cs/ Informatica.cs/ Informaticas (Edit.cshtml) - MaquinariosController.cs/ Maquinario.cs/ Maquinario (Edit.cshtml) - 
VeiculosController.cs/ Veiculo.cs/ Veiculos (Edit.cshtml) |
|RF-015| O sistema deve permitir que o usuário cadastre os dados da empresa.|EmpresasController.cs/ Empresa.cs / Migration-20221018064053_Ag00.cs/Empresa(Index.cshtm.)| 



# Instruções de acesso

Não deixe de informar o link onde a aplicação estiver disponível para acesso (por exemplo: https://adota-pet.herokuapp.com/src/index.html).

Se houver usuário de teste, o login e a senha também deverão ser informados aqui (por exemplo: usuário - admin / senha - admin).

O link e o usuário/senha descritos acima são apenas exemplos de como tais informações deverão ser apresentadas.

> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)
