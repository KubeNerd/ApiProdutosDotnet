# API Csharp cadastro de produtos

Esta é uma API simples para gerenciar produtos, desenvolvida com ASP.NET Core. A API simula um banco de dados em memória utilizando uma lista estática, permitindo o cadastro, atualização, remoção e listagem de produtos.<br/>


## 🛠 Funcionalidades
Cadastrar Produtos (POST /api/product) <br/>
Listar Todos os Produtos (GET /api/product) <br/>
Atualizar um Produto (PUT /api/product/{id}) <br/>
Remover um Produto (DELETE /api/product/{id}) <br/>

## 🚀 Tecnologias Utilizadas
.NET 6+ <br/>
ASP.NET Core <br/>
C# <br/>


## 📦 Endpoints

Cadastrar Produto
Descrição: Adiciona um novo produto à lista.<br/>
Método: POST <br/>
URL: /api/product <br/>
Body (JSON): <br/>



## 📌 Notas Importantes
A API utiliza um banco de dados em memória, ou seja, os dados serão perdidos ao reiniciar o servidor.
Esta aplicação é voltada para propósitos educativos ou demonstração.