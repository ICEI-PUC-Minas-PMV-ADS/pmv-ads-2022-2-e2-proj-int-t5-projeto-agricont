# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

| **Caso de Teste**	| **CT-01 – Página Inicial**	|
|:---:	|:---:	|
|Requisito Associado |  RF-010 - O site deve informar sobre a importância de um controle patrimonial. |
| Objetivo do Teste 	| Verificar se a página possui informações sobre a importância do controle patrimonial|
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> - Realizar leitura das informações disponibilizadas na página <br> 
|Critério de Êxito | - A página deve apresentar informações que indiquem a importância do controle patrimonial.|
|   |    | 
| **Caso de Teste**	| **CT-02 – Link "Fale Conosco" na Página Inicial**	|
|Requisito Associado |  -|
| Objetivo do Teste 	| Verificar se o link Fale Conosco está com direcionamento adequado|
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> - Clicar em "Fale Conosco" no cabeçalho <br> 
|Critério de Êxito | - A página "Fale Conosco" deve ser exibida com sucesso.|
|   |    | 
| **Caso de Teste**	| **CT-03 – Links "Cadastre-se" na Página Inicial**	|
|Requisito Associado |  -|
| Objetivo do Teste 	| Verificar se o link Cadastre-se está com direcionamento adequado|
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> - Clicar em "Cadastre-se" <br> 
|Critério de Êxito | - A página de cadastro do usuário deve ser exibida com sucesso.|
|   |    | 
| **Caso de Teste**	| **CT-04 – Ícone de Login na Página Inicial**	|
|Requisito Associado |  -|
| Objetivo do Teste 	| Verificar se o ícone de login está com direcionamento adequado|
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> - Clicar no ícone de login no cabeçalho <br> 
|Critério de Êxito | - A página de login deve ser exibida com sucesso.|
|   |    | 
| **Caso de Teste**	| **CT-05 – Efetuar Login**	|
|Requisito Associado |  RF-002 - O sistema deve permitir que o usuário faça o login. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> - Clicar no ícone de login no cabeçalho <br> - Preencher o campo de e-mail <br> - Preencher o campo ID empresa <br> - Preencher o campo da senha <br> - Clicar em "Entrar" |
|Critério de Êxito | - Permitir o preenchimento de todos os campos do login. Ao clicar em "Entrar" deverá ser liberado acesso à conta do usuário. |
|   |    | 
| **Caso de Teste** 	| **CT-06 – Pesquisa de Patrimônio**	|
|Requisito Associado |  RF-008 - O site deve permitir que o usuário pesquise as informações cadastradas de cada patrimônio    |
| Objetivo do Teste 	| Verificar se o item é exibido quando o usuário digita , por exemplo, o nome do produto na barra de pesquisa. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> - Fazer login <br> - selecionar a categoria que deseja pesquisar (Ferramenta, Informática , Maquinário ou Veículos) no sub-menu de Produtos digitar o nome do produto na barra de pesquisa e verificar se o sistema aparece com o produto desejado. <br> - Clicar no item para visualizar as informações  |
|Critério de Êxito | - O item selecionado deve ser exibido com sucesso. |
|   |    | 
| **Caso de Teste** 	| **CT-07 – Tela Fale Conosco**|
|Requisito Associado |  RF-006 - O site deve permitir que o usuário entre em contato com a AgriCont através da página fale conosco.|
| Objetivo do Teste 	| Verificar se a mensagem está sendo enviada corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont)  <br> - Clicar em fale conosco <br>- Digitar informações como: nome, e-mail, telefone e mensagem de texto. <br> - Clicar em enviar.  |
|Critério de Êxito | - Verificar se a mensagem foi enviada com sucesso. |
|   |    | 
| **Caso de Teste** 	| **CT-08 – Tela Alterar Senha** |
|Requisito Associado |  RF-03 - O sistema deve permitir que o usuário altere a senha do seu login.|
| Objetivo do Teste 	| Verificar se o usuário consegue alterar sua senha. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> - Clicar na página de login <br> - Clicar em "Esqueceu sua senha"  <br> - digitar seu e-email e o código da empresa. <br> - Clicar em alterar. |
|Critério de Êxito | - Verificar se após digitar as informações solicitadas e depois de clicar em alterar é possível realizar a alteração da sua senha.|
|   |    | 
| **Caso de Teste** 	| **CT-09– Tela Cadastro de Produto** |
|Requisito Associado |  RF-04 - O sistema deve permitir que o usuário cadastre o patrimônio por categoria como: maquinário, veículos, ferramentas e informática. <br>RF-05 - O sistema deve permitir que o usuário insira a última data de manutenção. <br>RF-07 - O site deve permitir que o usuário informe se o equipamento está ativo ou inativo.<br>RF09 - O site deve permitir que o usuário cadastre o valor da depreciação do patrimônio. <br>RF-11 - O sistema deve permitir que o usuário cadastre os equipamentos da empresa com os dados da nota fiscal.  <br>RF-12-O sistema deve permitir que o usuário cadastre os dados da apólice de seguro. |
| Objetivo do Teste 	| Verificar se o cadastro está sendo realizado. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> - Clicar na página de login <br> - Clicar no ícone de adição "+" e cadastrar o produto <br> -Clicar no botão salvar. |
|Critério de Êxito | - Verificar se após digitar as informações solicitadas e depois de clicar em alterar o sistema realizar a alteração da sua senha.|
|   |    | 
| **Caso de Teste** 	| **CT-10– Tela Relatório Itens Cadastrados** |
|Requisito Associado |  RF13 - O sistema deve gerar um relatório com todo patrimônio da empresa. <br>RF-14 - O sistema deve permitir que o usuário edite todas as informações do cadastro do patrimônio.|
| Objetivo do Teste 	| Verificar se as tabelas estão interligadas e se o sistema está carregando todos os cadastros do banco. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> - Fazer login <br> - Clicar em control+P no próprio navegador de documento e gerar um relatório <br>  - Clicar em um item para que seja mostrado seus dados <br> - Clicar no botão de "Detalhes" e depois no botão "Editar" para editar um patrimônio. |
|Critério de Êxito | - Verificar se o sistema está carregando os dados do banco, atualizando os mesmos em tempo real e cumprindo suas devidas funcionalidades.|
|  |  |
| **Caso de teste**   | **CT-11-Tela Cadastro de Empresa**|
|Requisito Associado |  RF-015  - O sistema deve permitir que o usuário cadastre os dados da empresa |
| Objetivo do Teste 	| Verificar se o cadastro será realizado |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> -Clicar em cadastre-se <br> - Clicar em cadastre sua empresa <br> - Inserir as informações <br> - Clicar no botão salvar|  
|Critério de Êxito | - Verificar se após inserir as informações e clicar no botão salvar o cadastro foi realizado.|
|  |  |
| **Caso de teste**   | **CT-12-Tela Cadastro do Usuário**|
|Requisito Associado |  RF-001  - O O sistema deve permitir que o usuário se cadastre na aplicação.|
| Objetivo do Teste 	| Verificar se o cadastro será realizado |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> -Clicar em cadastre-se ou "comece agora"<br> - Inserir as informações <br> - Clicar no botão cadastrar  
|Critério de Êxito | - Verificar se após inserir as informações e clicar no botão "Cadastrar" o cadastro foi realizado.|
