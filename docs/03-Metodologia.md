
# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

A metodologia contempla as definições de ferramental utilizado pela equipe tanto para a manutenção dos códigos e demais artefatos quanto para a organização do time na execução das tarefas do projeto.

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

Discuta como a configuração do projeto foi feita na ferramenta de versionamento escolhida. Exponha como a gerência de tags, merges, commits e branchs é realizada. Discuta como a gerência de issues foi realizada.

> **Links Úteis**:
> - [Tutorial GitHub](https://guides.github.com/activities/hello-world/)
> - [Git e Github](https://www.youtube.com/playlist?list=PLHz_AreHm4dm7ZULPAmadvNhH6vk9oNZA)
>  - [Comparando fluxos de trabalho](https://www.atlassian.com/br/git/tutorials/comparing-workflows)
> - [Understanding the GitHub flow](https://guides.github.com/introduction/flow/)
> - [The gitflow workflow - in less than 5 mins](https://www.youtube.com/watch?v=1SXpE08hvGs)

## Gerenciamento de Projeto

### Divisão de Papéis


A equipe utiliza metodologias ágeis, tendo escolhido o Scrum como base para definição do processo de desenvolvimento.

A equipe está organizada da seguinte maneira:

  - Scrum Master: Marllon Santos.
  - Product Owner: Pablo Alves.

  - Equipe de Desenvolvimento:
    - Geison Amorim. 
    - Lucas Reis.

  - Equipe de Design:
    - Amanda Brito. 
    - Victor Kingma.

### Processo

Coloque  informações sobre detalhes da implementação do Scrum seguido pelo grupo. O grupo poderá fazer uso de ferramentas on-line para acompanhar o andamento do projeto, a execução das tarefas e o status de desenvolvimento da solução.
 
> **Links Úteis**:
> - [Project management, made simple](https://github.com/features/project-management/)
> - [Sobre quadros de projeto](https://docs.github.com/pt/github/managing-your-work-on-github/about-project-boards)
> - [Como criar Backlogs no Github](https://www.youtube.com/watch?v=RXEy6CFu9Hk)
> - [Tutorial Slack](https://slack.com/intl/en-br/)

### Ferramentas

As ferramentas empregadas no projeto são:

|**FUNÇÃO**| **PLATAFORMA** |**LINK DE ACESSO**|
|--------------------|------------------------------------|----------------------------------------|
|**Repositório de Código Fonte**|**GitHub**|https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t1-pmv-ads-2023-1-e2-proj-int-t1-time5-log|
|**Projeto de Interface - Wireframe**|**Canva**|https://www.canva.com/design/DAFdNLd2Ry0/ft0i99YFpUBafAde4vbYwA/edit?utm_source=shareButton&utm_medium=email&utm_campaign=designshare)|
|**Editor de Código**|**Visual Studio 2022**|https://visualstudio.microsoft.com/pt-br/downloads/|
|**Documentação de projeto**|**GitHub**|https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t1-pmv-ads-2023-1-e2-proj-int-t1-time5-log|
|**Ferramentas de Comunição**|**Microsoft Teams**|https://teams.microsoft.com/l/channel/19%3a69d69ba1437549ca8a01dbf9c3247eef%40thread.tacv2/Grupo%25205%2520-%2520Quinta%252020h30%2520Log%25C3%25ADstica%2520entrega%2520de%2520m%25C3%25B3veis?groupId=278e57a8-42bb-4c89-b8a7-519c37a19531&tenantId=14cbd5a7-ec94-46ba-b314-cc0fc972a161|
|**Acompanhamentos semanal do andamento de atividades**|**WhatsApp**|https://chat.whatsapp.com/BUJQ5WOkPyVBpQvPSpn8Y6|
|**Banco de Dados Relacional**|**SQL Server**|

Para o repositório de código fonte, gerenciamento do projeto, bem como para armazenamento e alteração dos documentos do projeto será utilizado o GitHub, instrumento robusto e amplamente usado no mercado. Para o projeto de interface e Wireframes, será utilizado o Figma, um editor online de gráficos com ênfase em prototipagem. Além disso, a comunicação ágil do grupo para acompanhamento diário das atividades se dará pelo uso da rede WhatsApp, enquanto as reuniões de discussão serão pelo Microsoft Teams.

O projeto será codificado utilizando a IDE Visual Studio Comunity 2022 com o SDK do .NET6 fazendo uso do ASP.NET Core MVC que nos possibilita criar um site dinâmico com acesso a dados de forma simples e intuitiva e com reaproveitamento de código. O Entity Framework Core será usado como ORM de acesso ao banco de dados e para o mapeamento e geração do banco de dados usaremos a técnica 'Code First', que consiste em escrever os Modelos de Entidades que representam tabelas do banco de dados e partir dos modelos gerar o banco de dados com seus respectivos relacionamentos entre entidades. Essa abordagem também nos permite manter um controle de versão sobre a evolução do banco de dados, novas tabelas e propriedades criadas utilizando o 'Migration'.
