# Especificações do Projeto

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários em um trabalho de imersão feito por um membro da equipe a partir da observação do usuário em seu local natural e por meio de entrevista direta. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas abaixo.

Manoela Silva, 23 anos trabalha como auxiliar financeiro em uma empresa de vendas. Tem como hobbie a meditação, a leitura e estar em contato com a natureza. Busca atráves da aplicação maior agilidade e precisão na somatória das comissões, otimização do tempo de trabalho e tornar o processo mais transparente e eficiente, visto que atualmente todo o processo de soma dessas comissões é realizada de forma manual.

Gabriela Andrade, 35 anos vendedora do setor moveleiro. Gosta de viajar e participar de trilhas. Possui frustrações que afetam seu desempenho no trabalho como o atraso no pagamento e erros nos valores de suas comissões por se tratar de um trabalho manual e demorado. Deseja uma aplicação que reduza o tempo e os erros que possam ser cometidos no processo de soma de suas comissões. 

Rafael Cardoso, 27 anos expedidor de mercadorias. Seus hobbies englobam ler, jogar e treinar. Como parte de sua função na empresa ele necessita enviar ao setor fianceiro um relatório de entregas concluídas para que as comissões sejam pagas ao seu respectivo vendedor, atualmente esse processo é feito de forma manual sendo necessário passar todos os romaneios de entrega para o setor financeiro, busca por meio de uma aplicação uma forma de registrar as entregas concluídas e gerar um relatório de forma rápida para que possa otimizar seu tempo de trabalho. 

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Manoela Silva, auxiliar financeiro.  | Uma ferramenta automatizada que seja capaz de realizar o cálculo das comissões.           | Para ter acesso e controle de todos os dados em uma única plataforma e evitar o trabalho manual.               |
|Manoela Silva, auxiliar financeiro.       | Otimizar o tempo gasto na  tarefa.                 | Para poder focar em outras atividades inerentes ao meu setor. |
|Manoela Silva, auxiliar financeiro.  | Garantir a somatória das comissões de uma maneira mais eficaz.           | Para diminuir a probabilidade de erros e de retrabalho na tarefa tornando-a mais transparente e eficiente               |
|Rafael Cardoso, expedidor.  | Quero uma automatização no relatório de entregas concluídas repassado ao setor financeiro.           | Não precisar repassar manualmente as informações.              |
|Rafael Cardoso, expedidor.  | Cadastrar no sistema as entregas realizadas.           | Evitar o acúmulo desnecessário de papéis.               |
|Rafael Cardoso, expedidor.  | Otimizar o tempo gasto na  tarefa.           | Para poder focar em outras atividades inerentes ao meu setor.               |
|Gabriela Andrade, vendedora. | Quero agilidade no pagamento das comissões e receber os valores corretos.           | Para garantir a motivação no meu trabalho e não ter frustrações com atrasos ou erros nos valores recebidos.               |
|Gabriela Andrade,vendedora.  | Quero consultar os valores que tenho a receber das minhas vendas.           | Para poder realizar meu controle financeiro prévio de vendas realizadas.              |
|Gabriela Andrade, vendedora.  | Quero cadastrar as vendas e o recibo da venda.          | Para informar de forma rápida a venda realizada.               |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir.

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues.

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve possibilitar ao usuário realizar login mediante a validação de usuário e senha. | ALTA | 
|RF-002| A aplicação deve mostrar para o vendedor o valor das comissões recebidas e a receber.  | MÉDIA |
|RF-003| A aplicação deve permitir  que o expedidor cadastre  as entregas realizadas . | ALTA |
|RF-004| A aplicação deve realizar a soma das comissões de cada vendedor separadamente.  | ALTA |
|RF-005| A aplicação deve permitir ao vendedor realizar o cadastro das vendas realizadas junto ao comprovante de venda. | ALTA |
|RF-006| A aplicação deve permitir ao setor financeiro cadastrar usuário. | ALTA |

### Requisitos não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID          | Descrição do Requisito  |Prioridade |
|------------|-------------------------|----|
|RNF-001| A aplicação deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku);  | ALTA | 
|RNF-002| A aplicação deverá ser responsiva permitindo a visualização em um celular de forma adequada. |  ALTA | 
|RNF-003| A aplicação deve gerar o relatório de comissões de forma rápida, não demorando mais que 5s. | MÉDIA | 
|RNF-004| A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge). | ALTA | 
|RNF-005| A aplicação deve proporcionar uma alta disponibilidade.  | ALTA | 
|RNF-006| A aplicação  deve ter bom nível de contraste entre os elementos da tela em conformidade. | MÉDIA | 
|RNF-007| O sistema deverá se comunicar com o banco SQL Server. | ALTA | 
|RNF-008| O sistema só pode ser acessado por: Auxiliar Financeiro, Expedidor e Vendedora. | ALTA | 
|RNF-009| A solução deve ser intuitiva e fácil de usar, garantindo uma curva de aprendizado rápida. | MÉDIA | 

## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 26/06/2023. |
|02| A equipe não pode subcontratar o desenvolvimento do trabalho.       |
|03| O projeto não poderá ser entregue sem que as funcionalidades essenciais estejam prontas. |
|04| O projeto deve ser desenvolvido utilizando a linguagem de programação C#. |

## Diagrama de Casos de Uso

A imagem a seguir representa o diagrama de casos de uso do projeto em desenvolvimento:

![WhatsApp Image 2023-03-16 at 21 37 55](https://user-images.githubusercontent.com/89876269/226137909-dfc7fd49-3947-48ad-b20e-bf3dd4b44483.jpeg)
