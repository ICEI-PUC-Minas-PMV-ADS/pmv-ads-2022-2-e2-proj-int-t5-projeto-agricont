# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.


## Personas

|    Susy Thiemy Takamura   | Informações:                       |                                        |
|--------------------|------------------------------------|----------------------------------------|
|<img src="img/Susy.jpg" width = 250 >| **Idade:** 35 anos <br> **Ocupação:** Engenheira Agrônoma, Gerente na propriedade da família.|**Aplicativos:**<br><ul>● Instagram <br>● WhatsApp <br>● Facebook <br>● NFS-e App <br>● Aplicativo de Banco</ul>|
|**Motivações:**<br><ul>● Apaixonada pela profissão decidiu cursar agronomia, pois desde pequena sempre teve contato com a rotina de trabalho no sítio da família, que planta hortaliças;  <br><br>● Após sair do seu último emprego em corporação, decidiu assumir os negócios da família, pois quer transformar suas experiências acadêmicas e profissionais em crescimento dos negócios da família. </ul>|**Frustrações:**<br><ul>● Precisa solicitar um financiamento no Banco para adquirir uma nova máquina, porém como sua família não tem um controle patrimonial ela não consegue saber o que exatamente pode dar de garantia para a instituição;  <br><br>● No passado ela participou de um grande prejuízo financeiro, pois sua família perdeu um trator por manutenção incorreta.|**Hobbies/Histórias:**<br><ul>● Andar a cavalo; <br>● Tocar violão;  <br>● Participar de Feiras Agropecuárias.</ul>|

|    Luiz Machado  | Informações:                       |                                        |
|--------------------|------------------------------------|----------------------------------------|
|<img src="img/LuizMachado.png" width = 200 >| **Idade:** 20 anos <br> **Ocupação:** Estagiário de agronomia|**Aplicativos:**<br><ul>● Skype <br>● WhatsApp <br>● Messenger <br>● Youtube <br>● Facebook</ul>|
|**Motivações:**<br><ul>● Busca por reconhecimento na empresa e crescimento na carreira;  <br><br>● Deseja ter a possibilidade de pesquisar informações sobre determinada máquina, para implementar possíveis melhorias em seu hardware.  </ul>|**Frustrações:**<br><ul>● Seu chefe solicitou uma parafusadeira para realizar um conserto, porém um outro funcionário informou que aquela ferramenta havia sido vendida a meses atrás e não havia nenhum registro dessa transação;  <br><br>● Não ter um sistema que cadastre o valor de depreciação do bem.|**Hobbies/Histórias:**<br><ul>● Gosta de participar de feiras e eventos, pois assim conhece as novas tendências que podem otimizar as operações do campo. Em seu tempo livre gosta de jogar com amigos no computador. </ul>|



|    Carlos Gomes  | Informações:                       |                                        |
|--------------------|------------------------------------|----------------------------------------|
|<img src="img/carlos.png" width = 200 >| **Idade:** 40 anos <br> **Ocupação:** Pequeno empresário agrícola|**Aplicativos:**<br><ul>● Instagram <br>● Facebook <br>● Aplicativos de Banco</ul>|
|**Motivações:**<br><ul>● Ele é um amante da natureza e deseja que sua empresa seja pioneira na produção de vegetais e frutas de alta qualidade e sem utilização de agrotóxicos. <br><br>● Reduzir gastos com equipamentos para poder investir em novas tecnologias. </ul>|**Frustrações:**<br><ul>● Recentemente teve um sinistro na empresa, e decidiu fazer um seguro, porém não tinha a relação do patrimônio. <br><br>● Dificuldade de manter um controle das notas fiscais dos equipamentos da empresa.|**Hobbies/Histórias:**<br><ul>● Estudar meios de plantação mais sustentáveis. </ul>|
 
 
 |    Stephanie Oliveira  | Informações:                       |                                        |
|--------------------|------------------------------------|----------------------------------------|
|<img src="img/Stephanie.jpg" >| **Idade:** 25 anos <br> **Ocupação:** Tecnóloga em Silvicultura, trabalha em uma empresa de reflorestamento sustentável|**Aplicativos:**<br><ul>● Instagram <br>● Facebook <br>● Google Maps<br>● Be My Eyes <br>● Eye-D <br></ul>|
|**Motivações:**<br><ul>● Continuar atuando na Silvicultura clássica, pois acredita na produção que preserve o meio ambiente. <br><br>● Estará à frente do projeto para plantar uma espécie de árvore chamada Taxi-Branco. </ul>|**Frustrações:**<br><ul>● Ela será responsável pelo controle dos equipamentos que serão utilizados neste novo projetos, porém possui deficiência visual com perda parcial e tem dificuldade de encontrar programas que tenham Interação por voz e som para deficientes visuais. <br><br>● Como faz trabalhos externos precisa de um programa que possa ser visualizado em telas menores.|**Hobbies/Histórias:**<br><ul>● Gosta de aprender sobre árvores nativas do Brasil. <br>● Gosta de assistir documentários relacionados à preservação do meio ambiente.  <br>● Gosta de jogar jogos de tabuleiro. <br>● Quando criança teve toxoplasmose e a doença se alojou em seus dois olhos, por isso do lado direito possui 90% da visão e no esquerdo apenas 50%. <br></ul>|


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Susy Thiemy |Quer um sistema, no qual possa se cadastrar e ter login         | Para acessar informações e dados da sua empresa.                |
|Susy Thiemy |Quer um sistema que possa verificar o patrimônio por categoria como: maquinário, veículos, ferramentas e informática      | Para poder fazer a gestão patrimonial da propriedade.    |
|Susy Thiemy |Poder verificar quando foi a última data de manutenção do equipamento | Para não ter prejuízos financeiros.  |
|Susy Thiemy |Poder conseguir entrar em contato com a equipe de atendimento    |  Para sanar dúvidas  |
|Luiz Machado  | Quer que o sistema cadastre e pesquise se o equipamento está em operação ou não    | Para evitar gastos com compras desnecessárias     |
|Luiz Machado  | Quer que o sistema cadastre o valor da depreciação do bem   | Para saber quando será a melhor época para vender e comprar outro  |
| Carlos Gomes | Manter uma lista com a relação de todo patrimônio da empresa | Para contratar um seguro.   |
| Carlos Gomes | Poder cadastrar dados da apólice de seguro  |  Para saber quais equipamentos estão ou não no seguro.   |
| Carlos Gomes | Manter um cadastro dos equipamentos da empresa com os dados da nota fiscal  |  Para facilitar o controle patrimonial.  |
|Stephanie Oliveira  | Conseguir acessar o site pelo celular  |  Para facilitar seu trabalho, quando estiver em serviços externos.  |
|Stephanie Oliveira  | Conseguir ter acesso no site a Interação por voz e som    | Pois possui deficiência visual.    |



## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001|  O sistema deve permitir que o usuário se cadastre na aplicação.   |  ALTA  | 
|RF-002|  O sistema deve permitir que o usuário faça o login.   |  ALTA   |
|RF-003|  O sistema deve permitir que o usuário altere a senha do seu login.    |  MÉDIA    |
|RF-004|  O sistema deve permitir que o usuário cadastre o patrimônio por categoria como: maquinário, veículos, ferramentas e informática       |  ALTA  |
|RF-005|  O sistema deve permitir que o usuário insira a última data de manutenção.   |  ALTA  |
|RF-006|  O site deve permitir que o usuário entre em contato com a AgriCont através da página fale conosco.   |  BAIXA  |
|RF-007|  O site deve permitir que o usuário informe se o equipamento está ativo ou inativo.   |  ALTA   |
|RF-008|  O site deve permitir que o usuário pesquise as informações cadastradas de cada patrimônio   |  ALTA   |
|RF-009|  O site deve permitir que o usuário cadastre o valor da depreciação do patrimônio.   |  ALTA   |
|RF-010|  O site deve informar sobre a importância de um controle patrimonial.   |  ALTA   |
|RF-011|  O sistema deve permitir que o usuário cadastre os equipamentos da empresa com os dados da nota fiscal. |  ALTA  |
|RF-012|  O sistema deve permitir que o usuário cadastre os dados da apólice de seguro. |  ALTA  |
|RF-013|  O sistema deve gerar um relatório com todo patrimônio da empresa. |  ALTA  | 
|RF-014|  O sistema deve permitir que o usuário edite todas as informações do cadastro do patrimônio. | MÉDIA |
|RF-015| O sistema deve permitir que o usuário cadastre os dados da empresa| ALTA|
 
### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| As informações declaradas devem ser exibidas de forma privada ao usuário que declarou.  |  ALTA  | 
|RNF-002| O sistema deverá funcionar 24 horas por dia.  |    ALTA     | 
|RNF-003| O sistema deverá ser capaz através de um banco de dados guardar todas as informações do usuário.  |  ALTA  | 
|RNF-004| O site deverá conter paleta de cores de diferentes tipos para leitura noturna e daltonismo.  |  MÉDIA  | 
|RNF-005| O site deverá ser responsivo para permitir a visualização em um celular de forma adequada.  |  ALTA  | 
|RNF-006| O site deverá conter Interação por voz e som para deficientes visuais.  |  ALTA  | 
|RNF-007| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge)  |  ALTA  | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| A equipe não pode subcontratar o desenvolvimento do trabalho.|       |


 
## Diagrama de Casos de Uso

<img src="img/DiagramaCasosdeUso.png">




