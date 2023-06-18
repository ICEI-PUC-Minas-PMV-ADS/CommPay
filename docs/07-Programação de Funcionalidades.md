# Programação de Funcionalidades

Nesta seção são apresentadas as telas desenvolvidas para cada uma das funcionalidades do sistema. O respectivo endereço (URL) e outras orientações de acesso são apresentadas na sequência.

## 1. Login (RF-01)

Apresenta os campos para que o usuário possa inserir os dados de CPF e SENHA e realizar o acesso.

*Caso os dados não sejam preenchidos, será exibido uma mensagem.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve possibilitar ao usuário realizar login mediante a validação de usuário e senha. | Login\Login.cshtml| 

![erro login](https://github.com/ICEI-PUC-Minas-PMV-ADS/CommPay/assets/111931438/ee3fdfc8-26cd-4ddb-a46e-eed582eb7769)

## 2. Comissões vendedores (RF-02)

O usuário Vendedor poderá visualizar suas comissões.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-002|A aplicação deve mostrar para o vendedor o valor das comissões recebidas e a receber. | Vendas\index.cshtml  | 

![Comissões vendedor](https://github.com/ICEI-PUC-Minas-PMV-ADS/CommPay/assets/111931438/0b8f3430-a6f4-43cf-9af7-a30f91ceb53a)

## 3. Atualização de status da entrega da venda pelo Expedidor (RF-03)

O usuário Expedidor poderá atualizar os status das entregas após as vendas serem cadastradas no sistema.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-003|A aplicação deve permitir ao expedidor alterar o status da entrega. |Expedidores\Entregas.cshtml| 

![Att entrega expedidor(1)](https://github.com/ICEI-PUC-Minas-PMV-ADS/CommPay/assets/111931438/f536bb8e-4dd1-44dd-84d1-eb8e73dbca2b)

![Att entrega expedidor(2)](https://github.com/ICEI-PUC-Minas-PMV-ADS/CommPay/assets/111931438/cd9c3340-e431-4db3-90d4-4f05ef721a82)

## 4. Somatorio automático de comissões (RF-04)

O usuário Financeiro conseguirá visualizar as comissões somadas automaticamente através do menu Comissões .

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-004|A aplicação deve realizar a soma das comissões de cada vendedor separadamente. |Vendas\index.cshtml | 

![pagamento de comissões](https://github.com/ICEI-PUC-Minas-PMV-ADS/CommPay/assets/111931438/62d23d75-03bd-4d29-b384-721739f39549)

## 5. Cadastro de vendas (RF-05)

O usuário Vendedor conseguirá cadastrar suas vendas atráveés do menu vendas.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-005|A aplicação deve permitir ao vendedor realizar o cadastro das vendas realizadas. |Vendas\index.cshtml| 

![cadastro de vendas(1)](https://github.com/ICEI-PUC-Minas-PMV-ADS/CommPay/assets/111931438/91815f7d-e36c-435c-9356-c78b9f84abbe)

![cadastro de vendas(2)](https://github.com/ICEI-PUC-Minas-PMV-ADS/CommPay/assets/111931438/5095d4b5-e2e6-43f1-806e-b8d1cee82985)

## 6. Cadastro usuários (RF-06)

O usuário Financeira conseguirá cadastra novos usuários através do menu Usuários.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-006|A aplicação deve permitir ao setor financeiro cadastrar novo usuário. |Usuarios\Index.cshtml | 

![cadastra novo usuario(1)](https://github.com/ICEI-PUC-Minas-PMV-ADS/CommPay/assets/111931438/e73899f1-7e4c-4003-b421-b609562a99e3)

![cadastra novo usuario(2)](https://github.com/ICEI-PUC-Minas-PMV-ADS/CommPay/assets/111931438/4388560d-7730-4036-abcf-9b2c3ac42f18)

## 7. Cadastro de produtos (RF-07)

O usuário Financeira conseguirá cadastra novos produtos através do menu Produtos.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-007|A aplicação deve permitir ao setor financeiro cadastrar produtos. |Produtos\Index.cshtml, Produtos\Create.cshtml| 

![cadsatro de produtos(1)](https://github.com/ICEI-PUC-Minas-PMV-ADS/CommPay/assets/111931438/ad25d621-0ff7-4ea5-aa0b-0d0ac8e95898)

![cadsatro de produtos(2)](https://github.com/ICEI-PUC-Minas-PMV-ADS/CommPay/assets/111931438/c32476c2-16ec-4efd-948c-3ba8653178ae)

## 8. Cadastro de produtos (RF-08)

O usuário Financeira conseguirá visualizar o relatório geral que consta as seguintes informações: Total em vendas, Data da ultima venda, Vendedores Ativo(s) na plataforma, Total de comissões á serem pagas e da Data de pagamento das comissões.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-008|A aplicação deve permitir ao setor financeiro acessar o relatório geral. |Vendas\Index.cshtml | 

![relatorio geral](https://github.com/ICEI-PUC-Minas-PMV-ADS/CommPay/assets/111931438/99ec51f4-001f-4416-9755-f9fddd0ac60a)


## Instruções de acesso

Para acessa a aplicação basta acessar o link  https://commpay.azurewebsites.net/Usuarios/Login e usar um dos usuarios abaixo para teste

## Usuários para teste de acesso

|USUÁRIOS  |    LOGIN    | SENHA |
|----------|-------------|-------|
|Financeiro| 11111111111 | 123   |
|Vendedor  | 12312312312 | 123   |
|Expedidor | 12312312332 | 123   |
