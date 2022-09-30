# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-00X - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-00Y	- A aplicação deve possuir opção de fazer login, sendo o login o endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://adota-pet.herokuapp.com/src/index.html<br> - Clicar no botão "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  |  |
| Caso de Teste 	| CT-01 – Efetuar login	|
|Requisito Associado |  RF-002 - O sistema deve permitir que o usuário faça o login. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont <br> - Clicar no ícone de login no cabeçalho <br> - Preencher o campo de e-mail <br> - Preencher o campo ID empresa <br> - Preencher o campo da senha <br> - Clicar em "Entrar" |
|Critério de Êxito | - Permitir o preenchimento de todos os campos do login. Ao clicar em "Entrar" deverá ser liberado acesso à conta do usuário. |
|   |    | 
| Caso de Teste 	| CT-02 – Tela modal com as informações cadastradas do item selecionado	|
|Requisito Associado |  RF-008 - O site deve permitir que o usuário pesquise as informações cadastradas de cada patrimônio    |
| Objetivo do Teste 	| Verificar se a tela modal é exibida com todas as informações cadastradas do item selecionado. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont <br> - Fazer login <br> - visualizar a primeira página após o login com lista dos itens cadastrados <br> - Clicar no item para visualizar as informações  |
|Critério de Êxito | - A tela modal com as informações do item selecionado deve ser exibida com sucesso. |
|   |    | 
| Caso de Teste 	| CT-03 – Tela Fale Conosco|
|Requisito Associado |  RF-006 - O site deve permitir que o usuário entre em contato com a AgriCont através da página fale conosco.|
| Objetivo do Teste 	| Verificar se a mensagem está sendo enviada corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont <br> -  <br> - visualizar a  página inicial, clicar em fale conosco escrever informações como: nome, e-mail, telefone e mensagem de texto. <br> - Clicar em enviar.  |
|Critério de Êxito | - Verificar se a mensagem foi enviada com sucesso. |
|   |    | 
| Caso de Teste 	| CT-04 – Tela Filtro|
|Requisito Associado |  RF-013 - O sistema deve gerar um relatório com todo patrimônio da empresa.|
| Objetivo do Teste 	| Verificar se os filtros estão funcionando corretamente. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t5-projeto-agricont <br> - Fazer login <br> - visualizar a  página de listas de produtos, clicar em ícone filtro, selecionar as informações desejadas e clicar em filtrar. <br> - Clicar em enviar.  |
|Critério de Êxito | - Verificar se o filtro foi realizado. |





> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
