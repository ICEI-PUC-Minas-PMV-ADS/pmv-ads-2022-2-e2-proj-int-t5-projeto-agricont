# Programação de Funcionalidades


A tabela a seguir apresenta os artefatos desenvolvidos de acordo com os requisitos funcionais.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir que o usuário se cadastre na aplicação. |  UsuariosController.cs/Usuario.cs/ 20221018193126_Ag01.cs/ Usuario (Create.cshtml) |
|RF-002|  O sistema deve permitir que o usuário faça o login.   |  UsuariosController.cs/ Login.cs/ Usuario (Login.cshtml)  |
|RF-003|  O sistema deve permitir que o usuário altere a senha do seu login. |  UsuariosController.cs/Usuario.cs/ 20221018193126_Ag01.cs/ Usuario (Edit.cshtml)/ EditPasswordModel.cs/ Usuario (EditPassword.cshtml)   |
|RF-004|  O sistema deve permitir que o usuário cadastre o patrimônio por categoria como: maquinário, veículos, ferramentas e informática  |  FerramentasController.cs/Ferramenta.cs/ 20221023092107_Ag03.cs / Ferramentas (Create.cshtml) - InformaticasController.cs/ Informatica.cs/ 20221023054053_Agri02.cs / Informaticas (Create.cshtml) - MaquinariosController.cs/ Maquinario.cs/ 20221106053021_Ag04.cs / Maquinario (Create.cshtml) - VeiculosController.cs/ Veiculo.cs/ 20221107033719_Ag05.cs / Veiculos (Create.cshtml) |
|RF-005|  O sistema deve permitir que o usuário insira a última data de manutenção.  | FerramentasController.cs/Ferramenta.cs/ Ferramentas (Create.cshtml) - InformaticasController.cs/ Informatica.cs/ Informaticas (Create.cshtml) - MaquinariosController.cs/ Maquinario.cs/ Maquinario (Create.cshtml) - VeiculosController.cs/ Veiculo.cs/ Veiculos (Create.cshtml) |
|RF-006|  O site deve permitir que o usuário entre em contato com a AgriCont através da página fale conosco.  | EnviaFaleConosco.cs / FormFaleConosco.cs / Email.cs/ IEmail.cs / EnviaFaleConosco (FaleConosco.cshtml)      |
|RF-007| O site deve permitir que o usuário informe se o equipamento está ativo ou inativo. |  FerramentasController.cs/Ferramenta.cs/ Ferramentas (Create.cshtml) - InformaticasController.cs/ Informatica.cs/ Informaticas (Create.cshtml) / MaquinariosController.cs/ Maquinario.cs/ Maquinario (Create.cshtml) / VeiculosController.cs/ Veiculo.cs/ Veiculos (Create.cshtml)  |
|RF-008| O site deve permitir que o usuário pesquise as informações cadastradas de cada patrimônio  |  Ferramentas (Index.cshtml) -  Informaticas (Index.cshtml) -  Maquinario (Index.cshtml) - Veiculos (Index.cshtml)  |
|RF-009|  O site deve permitir que o usuário cadastre o valor da depreciação do patrimônio. |FerramentasController.cs/Ferramenta.cs/ Ferramentas (Create.cshtml) - InformaticasController.cs/ Informatica.cs/ Informaticas (Create.cshtml) - MaquinariosController.cs/ Maquinario.cs/ Maquinario (Create.cshtml) - VeiculosController.cs/ Veiculo.cs/ Veiculos (Create.cshtml) |
|RF-010|  O site deve informar sobre a importância de um controle patrimonial.  |  Home (Index.cshtml) |
|RF-011|  O sistema deve permitir que o usuário cadastre os equipamentos da empresa com os dados da nota fiscal.  | FerramentasController.cs/Ferramenta.cs/ Ferramentas (Create.cshtml) - InformaticasController.cs/ Informatica.cs/ Informaticas (Create.cshtml) - MaquinariosController.cs/ Maquinario.cs/ Maquinario (Create.cshtml) - VeiculosController.cs/ Veiculo.cs/ Veiculos (Create.cshtml) |
|RF-012|  O sistema deve permitir que o usuário cadastre os dados da apólice de seguro.| FerramentasController.cs/Ferramenta.cs/ Ferramentas (Create.cshtml) - InformaticasController.cs/ Informatica.cs/ Informaticas (Create.cshtml) - MaquinariosController.cs/ Maquinario.cs/ Maquinario (Create.cshtml) - VeiculosController.cs/ Veiculo.cs/ Veiculos (Create.cshtml) |
|RF-013|  O sistema deve gerar um relatório com todo patrimônio da empresa. | RelatoriosController.cs / Relatorios (Index.cshtml) |
|RF-014|  O sistema deve permitir que o usuário edite todas as informações do cadastro do patrimônio. |  FerramentasController.cs/Ferramenta.cs/ Ferramentas (Edit.cshtml) - InformaticasController.cs/ Informatica.cs/ Informaticas (Edit.cshtml) - MaquinariosController.cs/ Maquinario.cs/ Maquinario (Edit.cshtml) - VeiculosController.cs/ Veiculo.cs/ Veiculos (Edit.cshtml) |
|RF-015| O sistema deve permitir que o usuário cadastre os dados da empresa.|EmpresasController.cs/ Empresa.cs / Migration-20221018064053_Ag00.cs/Empresa(Index.cshtm.)| 



# Instruções de acesso

- Acesse a página inicial pelo link: [AgriCont](https://agricont.azurewebsites.net/).

- Clique no ícone de Login no canto direito do cabeçalho.

- Informe as credenciais de login de usuário teste (Login: emauelythiemy@gmail.com   / Senha: 12345).

- As credenciais serão validadas, a sessão será iniciada e o usuário será redirecionado para a página inicial do usuário.

- Caso prefira, pode fazer seu própio cadastro clicando no link Cadastre-se no cabeçalho. 

- Ao clicar no link Cadastre-se, você será redirecionado para a página de Cadastro de Usuário. Para realizar o cadastro de usuário é necessário que sua empresa também esteja cadastrada. 

- Caso sua empresa ainda não esteja cadastrada, clique no link embaixo do Cadastro de Usuário para ser redirecionado para o Cadastro de Empresa.  

- Após realizar Cadastro de Usuário, você será redirecionado para a página de Login. 

- Informe as credenciais cadastradas. Elas serão validadas e a sessão será iniciada.

