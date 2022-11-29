# Books API - C#

Desenvolvimento de uma API de controle de autores e livros usando C# Web com Asp.NET e um banco de dados SQL Server

---------------------------------------
### Autor
Danilo Oliveira Silva

---------------------------------------

### 🛠 Tecnologias utilizadas
- C#
- Asp.NET
- SQL Server
- Entity Framwork
- Fluent Assertions

---------------------------------------

## Comandos utilizados


1. Inicializa uma nova api web no dotnet

````
dotnet new api
````
2. Iniciar um container do SQL Server ou Azure data para máquinas com processadores M1

````
docker run -e 'ACCEPT_EULA=1' -e 'MSSQL_SA_PASSWORD=SuaSenha' -p 1433:1433 -v /seu-diretorio:/var/opt/mssql/data -d mcr.microsoft.com/azure-sql-edge:latest
````

3. Instala os certificados para aceitar a api a funcionar com HTTPS

````
dotnet dev-certs https --trust
````

4. Instala e adiciona ao projeto as dependência do EntityFramework para o mesmo conectar com um banco SQL Server

````
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
````

5. Adição do Fluent Assertions ao projeto

`````
dotnet add package FluentAssertions.AspNetCore.Mvc --version 4.2.0
`````


6. Build da aplicação

`````
dotnet build
`````


7. Run da aplicação

`````
dotnet run
`````
---------------------------------------

## Banco de Dados

O banco de dados seguindo o diagrama de entidade relacional abaixo, pode ser criado através do scripts-db.sql

![0](/images/der.png)
<br />

---------------------------------------

## Documentação da API


![GET](https://placehold.co/70x30/3d76bf/white/?text=GET&font=Montserrat) `/authors`

Retorna a lista de todos os Autores

***Request***
    http://localhost:5088/authors

***Response***  `200`

    [
	    {
    		"authorId": 1,
		    "name": "Jorge Amado",
		    "books": [
    			{
				    "title": "Capitães da Areia",
				    "releaseYear": 1937
			    } ...
		    ]
	    } ...
    ]

---------------------------------------

![GET](https://placehold.co/70x30/3d76bf/white/?text=GET&font=Montserrat) `/authors/{id}`

Retorna os dados de um autor

***Request***
    http://localhost:5088/authors/1

***Response***  `200`

	{
        "authorId": 1,
		"name": "Jorge Amado",
		"books": [
    		{
			    "title": "Capitães da Areia",
			    "releaseYear": 1937
		    } ...
		]
    } ...

---------------------------------------    

![POST](https://placehold.co/70x30/3dbf94/white/?text=POST&font=Montserrat) `/authors`

Insere um novo autor

***Request***
    http://localhost:5088/authors

	{
		"name": "José de Alencars"
	}

***Response***  `201`

	{
		"authorId": 7,
		"name": "José de Alencars"
	}
 
--------------------------------------- 

![PUT](https://placehold.co/70x30/7e3dbf/white/?text=PUT&font=Montserrat) `/authors/{id}`

Edita as informações de um autor

***Request***
    http://localhost:5088/authors/7

	{
		"name": "José de Alencar"
	}

***Response***  `200`

	{
		"authorId": 7,
		"name": "José de Alencar"
	}
 
--------------------------------------- 

![DELETE](https://placehold.co/70x30/bf3d3d/white/?text=DELETE&font=Montserrat) `/authors/{id}`

Deleta um autor

***Request***
    http://localhost:5088/authors/7

***Response***  `200`

	{
		"message": "Removido com sucesso"
	}
 
--------------------------------------- 


![GET](https://placehold.co/70x30/3d76bf/white/?text=GET&font=Montserrat) `/books`

Retorna a lista de todos os livros

***Request***
    http://localhost:5088/books

***Response***  `200`

    [
	    {
			"bookId": 1,
			"title": "Capitães da Areia",
			"releaseYear": 1937,
			"authorName": "Jorge Amado"
		}, ...
    ]

---------------------------------------

![GET](https://placehold.co/70x30/3d76bf/white/?text=GET&font=Montserrat) `/books/{id}`

Retorna os dados de um livro

***Request***
    http://localhost:5088/books/2

***Response***  `200`

    {
		"bookId": 2,
		"title": "O Quinze",
		"releaseYear": 1930,
		"authorName": "Rachel de Queiroz"
	}

---------------------------------------

![POST](https://placehold.co/70x30/3dbf94/white/?text=POST&font=Montserrat) `/books`

Insere um novo livro

***Request***
    http://localhost:5088/books

	{
		"title": "Cacaus",
		"releaseYear": 1933,
		"authorId": 7
	}

***Response***  `201`

	{
		"bookId": 10,
		"title": "Cacaus",
		"releaseYear": 1933,
		"authorName": "José de Alencar"
	}
  

---------------------------------------

![PUT](https://placehold.co/70x30/7e3dbf/white/?text=PUT&font=Montserrat) `/books/{id}`

Edita as informações de um livro

***Request***
    http://localhost:5088/books/10

	{
		"title": "Cacau",
		"releaseYear": 1933,
		"authorId": 1
	}

***Response***  `200`

	{
		"bookId": 10,
		"title": "Cacau",
		"releaseYear": 1933,
		"authorName": "Jorge Amado"
	}

---------------------------------------

![DELETE](https://placehold.co/70x30/bf3d3d/white/?text=DELETE&font=Montserrat) `/books/{id}`

Deleta um livro

***Request***
    http://localhost:5088/books/10

***Response***  `200`

	{
		"message": "Removido com sucesso"
	}
  
---------------------------------------