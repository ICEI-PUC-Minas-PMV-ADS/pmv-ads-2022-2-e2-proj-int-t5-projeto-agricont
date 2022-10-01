# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.


| **Caso de Teste**	| **CT-01 – Efetuar login**	|
|:---:	|:---:	|
|Requisito Associado |  RF-002 - O sistema deve permitir que o usuário faça o login. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> - Clicar no ícone de login no cabeçalho <br> - Preencher o campo de e-mail <br> - Preencher o campo ID empresa <br> - Preencher o campo da senha <br> - Clicar em "Entrar" |
|Critério de Êxito | - Permitir o preenchimento de todos os campos do login. Ao clicar em "Entrar" deverá ser liberado acesso à conta do usuário. |
|   |    | 
| **Caso de Teste** 	| **CT-02 – Tela modal com as informações cadastradas do item selecionado**	|
|Requisito Associado |  RF-008 - O site deve permitir que o usuário pesquise as informações cadastradas de cada patrimônio    |
| Objetivo do Teste 	| Verificar se a tela modal é exibida com todas as informações cadastradas do item selecionado. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> - Fazer login <br> - visualizar a primeira página após o login com lista dos itens cadastrados <br> - Clicar no item para visualizar as informações  |
|Critério de Êxito | - A tela modal com as informações do item selecionado deve ser exibida com sucesso. |
|   |    | 
| **Caso de Teste** 	| **CT-03 – Tela Fale Conosco**|
|Requisito Associado |  RF-006 - O site deve permitir que o usuário entre em contato com a AgriCont através da página fale conosco.|
| Objetivo do Teste 	| Verificar se a mensagem está sendo enviada corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont)  <br> - Clicar em fale conosco <br>- Digitar informações como: nome, e-mail, telefone e mensagem de texto. <br> - Clicar em enviar.  |
|Critério de Êxito | - Verificar se a mensagem foi enviada com sucesso. |
|   |    | 
| **Caso de Teste** 	| **CT-04 – Tela Filtro**|
|Requisito Associado |  RF-013 - O sistema deve gerar um relatório com todo patrimônio da empresa.|
| Objetivo do Teste 	| Verificar se os filtros estão funcionando corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> - Fazer login <br> - visualizar a  página de listas de produtos<br>- clicar em ícone filtro<br> -Selecionar as informações desejadas<br> - Clicar em filtrar. <br> - Clicar em enviar.  |
|Critério de Êxito | - Verificar se o filtro foi realizado. |
|   |    | 
| **Caso de Teste** 	| **CT-05 – Tela Alterar Senha** |
|Requisito Associado |  RF-03 - O sistema deve permitir que o usuário altere a senha do seu login.|
| Objetivo do Teste 	| Verificar se o usuário consegue alterar sua senha. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> - Clicar na página de login <br> - Clicar em "Esqueceu sua senha"  <br> - digitar seu e-email, nova senha e conformação de senha. <br> - Clicar em alterar. |
|Critério de Êxito | - Verificar se após digitar as informações solicitadas e depois de clicar em alterar é possível realizar a alteração da sua senha.|
|   |    | 
| **Caso de Teste** 	| **CT-06– Tela Cadastro de Produto** |
|Requisito Associado |  RF-04 - O sistema deve permitir que o usuário cadastre o patrimônio por categoria como: maquinário, veículos, ferramentas e informática. <br>RF-05 - O sistema deve permitir que o usuário insira a última data de manutenção. <br>RF-07 - O site deve permitir que o usuário informe se o equipamento está ativo ou inativo.<br>RF09 - O site deve permitir que o usuário cadastre o valor da depreciação do patrimônio. <br>RF-11 - O sistema deve permitir que o usuário cadastre os equipamentos da empresa com os dados da nota fiscal.  <br>RF-12-O sistema deve permitir que o usuário cadastre os dados da apólice de seguro. |
| Objetivo do Teste 	| Verificar se o casdastro está sendo realizado. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> - Clicar na página de login <br> - Clicar no ícone de adição "+" e cadastrar o produto <br> -Clicar no botão salvar. |
|Critério de Êxito | - Verificar se após digitar as informações solicitadas e depois de clicar em alterar o sistema realizar a alteração da sua senha.|
|   |    | 
| **Caso de Teste** 	| **CT-07– Tela Itens Cadastrados** |
|Requisito Associado |  RF-04 - O sistema deve permitir que o usuário cadastre o patrimônio por categoria como: maquinário, veículos, ferramentas e informática. <br>RF-07 - O site deve permitir que o usuário informe se o equipamento está ativo ou inativo. <br>RF-08 - O site deve permitir que o usuário pesquise as informações cadastradas de cada patrimônio.<br>RF13 - O sistema deve gerar um relatório com todo patrimônio da empresa. <br>RF-14 - O sistema deve permitir que o usuário edite todas as informações do cadastro do patrimônio.|
| Objetivo do Teste 	| Verificar se as telas estão interligadas e se o sistema está carregando todos os cadastros do banco. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site [AgriCont](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont) <br> - Fazer login <br> - Clicar no ícone de adição "+" e cadastrar o produto <br> - Clicar no ícone de lupa e pesquisar um patrimônio <br> - Clicar no ícone de documento e gerar um relatório <br> - Clicar no botão de filtro e escolher um tipo de item específico <br> - Clicar em um item para que seja mostrado seus dados <br> - Clicar duas vezes em cima do sinal de status para troca o mesmo <br> - Clicar no botão de lápis para editar um patrimônio. |
|Critério de Êxito | - Verificar se o sistema está carregando os dados do banco, atualizando os mesmos em tempo real e cumprindo suas devidas funcionalidades.|


