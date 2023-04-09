# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Os requisitos para realização dos testes de software são:

● Site publicado na Internet.<br>
● Navegador da Internet - Chrome, Firefox ou Edge.<br>
● Conectividade de Internet para acesso às plataformas (APISs).<br>

Os testes funcionais a serem realizados no aplicativo são descritos a seguir:
 
| **Caso de Teste** 	| **CT-01 - Realizar Login** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve possibilitar ao usuário realizar login mediante a validação de usuário e senha. |
| Objetivo do Teste 	| Verificar se é possível realizar login na aplicação. |
| Passos 	|  1. Acessar o Navegador. <br> 2. Informar o endereço da aplicação.<br> 3. Informar um usuário válido e senha válida. <br> 4. Clicar no botão “Entrar”. |
|Critério de Êxito | - Deve ser possível realizar o login na aplicação.<br>  Deve ser possível acessar as funcionalidades da aplicação de acordo com o perfil atribuído ao usuário. |
|  	|  	|
| **Caso de Teste** 	| **CT-02 - Visualizar comissões** 	|
|	Requisito Associado 	| RF-002 - A aplicação deve mostrar para o vendedor o valor das comissões recebidas e a receber.<br> RF-004 - A aplicação deve realizar a soma das comissões de cada vendedor separadamente. |
| Objetivo do Teste 	| Verificar se o valor das comissões é exibido corretamente para o vendedor. |
| Passos 	|  1. Realizar o login na aplicação como vendedor. <br> 2. Acessar a tela de comissões.<br> |
|Critério de Êxito | - Deve ser possível visualizar o valor das comissões recebidas e a receber para o vendedor logado.<br>  Deve ser possível visualizar a soma das comissões de cada vendedor separadamente. |
|  	|  	|
| **Caso de Teste** 	| **CT-03 – Cadastrar entregas realizadas** 	|
|	Requisito Associado 	| RF-003 - A aplicação deve permitir que o expedidor cadastre as entregas realizadas. |
| Objetivo do Teste 	| Verificar se é possível cadastrar entregas realizadas na aplicação. |
| Passos 	|  1.   	Realizar o login na aplicação como expedidor.<br> 2. Acessar a tela de cadastro de entregas. <br> 3. Modificar status da entrega (entregue, pendente).<br> 4. Clicar no botão “Salvar”. |
|Critério de Êxito | Deve ser possível modificar status da entrega na aplicação.<br>  As informações da entrega devem ser exibidas corretamente na tela. |
|  	|  	|
| **Caso de Teste** 	| **CT-04 – Cadastrar vendas realizadas** 	|
|	Requisito Associado 	| RF-005 - A aplicação deve permitir ao vendedor realizar o cadastro das vendas realizadas junto ao comprovante de venda. |
| Objetivo do Teste 	| Verificar se é possível cadastrar vendas realizadas na aplicação. |
| Passos 	|  1. Realizar o login na aplicação como vendedor. <br> 2. Acessar a tela de cadastro de vendas. <br> 3. Preencher os dados da venda (produto, quantidade, valor, comprovante, etc...)<br> 4. Clicar no botão “Salvar”. |
|Critério de Êxito | Deve ser possível cadastrar vendas realizadas na aplicação. <br>As informações da venda cadastrada devem ser exibidas corretamente na tela. |
|  	|  	|
| **Caso de Teste** 	| **CT-05 – Cadastrar usuário** 	|
|	Requisito Associado 	| RF-006 - A aplicação deve permitir ao setor financeiro cadastrar usuário. |
| Objetivo do Teste 	| Verificar se o cadastro de usuário é realizado corretamente pelo setor financeiro. |
| Passos 	|  1. Acessar o Navegador. <br> 2. Informar o endereço da aplicação. <br> 3. Acessar a área de cadastro dos usuários. <br> 4. Preencher o formulário com os dados necessários (nome, CPF, senha, cargo). <br> 5. Clicar no botão “Salvar”.|
|Critério de Êxito | Após o cadastro, o usuário deve ser direcionado para a página inicial do site. |
|  	|  	|
| **Caso de Teste** 	| **CT-06 – Acessível publicamente na internet** 	|
|	Requisito Associado 	| RNF-001 - A aplicação deve ser publicada em um ambiente acessível na Internet (Repl.it, GitHub Pages, Heroku). |
| Objetivo do Teste 	| Verificar se a aplicação está acessível publicamente na internet. |
| Passos 	|  1. Acessar o navegador.<br> 2. Informar o endereço da aplicação. <br> 3. Verificar se a página carrega de forma integral. |
|Critério de Êxito |  A página deve ser carregada sem erros.<br> A página deve ser acessível de qualquer lugar através da internet. |
|  	|  	|
| **Caso de Teste** 	| **CT-07 – Verificar se é responsiva** 	|
|	Requisito Associado 	| RNF-002- A aplicação deverá ser responsiva permitindo a visualização em um dispositivo móvel de forma adequada. |
| Objetivo do Teste 	| Verificar se a aplicação é responsiva e adequada para visualização em um dispositivo móvel. |
| Passos 	|  1. Acessar o Navegador em um celular. <br> 2. Informar o endereço da aplicação. <br> 3. Verificar se a página é visualizada corretamente. |
| Critério de Êxito | - A página deve ser visualizada de forma integral em um dispositivo móvel. |
|  	|  	|
| Caso de Teste   | CT-11 – Interação com banco de dados   |
|  Requisito Associado   | RNF-007- O sistema deverá se comunicar com o banco MySQL |
| Objetivo do Teste   | Verificar se a aplicação consegue se comunicar com o banco de dados MySQL |
| Passos   | - Acessar o navegador <br> - Informar o endereço da aplicação |
|Critério de Êxito | - A conexão com o banco de dados deve ser estabelecida com sucesso <br> - Os dados devem ser recuperados e exibidos corretamente na aplicação <br>
|  	|  	|
| Caso de Teste   | CT-12– Acesso ao sistema   |
|  Requisito Associado   | RNF-008- O sistema só pode ser acessado por: Auxiliar Financeiro, Expedidor e Vendedor(a). |
| Objetivo do Teste   | Verificar se o acesso à aplicação está restrito apenas aos usuários autorizados. |
| Passos   | - Acessar o navegador <br> - Informar o endereço da aplicação<br> - Tentar acessar a aplicação com um usuário não autorizado <br> |
|Critério de Êxito | - Os usuários autorizados devem conseguir acessar a aplicação normalmente <br> - O acesso deve ser negado para usuários não autorizados |
|  	|  	|
| Caso de Teste   | CT-13 – Curva de aprendizado   |
|  Requisito Associado   | RNF-009 – A solução deve ser intuitiva e fácil de usar, garantindo uma curva de aprendizado rápida. |
| Objetivo do Teste   | Verificar se a solução é intuitiva e fácil de usar, garantindo uma curva de aprendizado rápida. |
| Passos   | - Acessar o navegador <br> - Informar o endereço da aplicação<br> |
|Critério de Êxito | - Os usuários devem conseguir utilizar a aplicação sem dificuldades.  <br> - Os usuários devem conseguir entender as funcionalidades da aplicação sem dificuldades. |
