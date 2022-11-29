USE master;
GO

DROP DATABASE IF EXISTS BookStore;
GO

CREATE DATABASE BookStore;
GO

USE BookStore;

CREATE TABLE Authors
(
    AuthorId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);
GO

CREATE TABLE Books
(
    BookId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Title VARCHAR(200) NOT NULL,
    ReleaseYear INT NOT NULL,
    AuthorId INT NOT NULL,
    FOREIGN KEY (AuthorId) REFERENCES Authors(AuthorId)
); 
GO

INSERT INTO Authors(Name) VALUES('Jorge Amado');
INSERT INTO Authors(Name) VALUES('Rachel de Queiroz');
INSERT INTO Authors(Name) VALUES('Machado de Assis');
INSERT INTO Authors(Name) VALUES('Clarice Lispector');
INSERT INTO Authors(Name) VALUES('José de Alencar');
INSERT INTO Authors(Name) VALUES('Guimarães Rosa');
INSERT INTO Authors(Name) VALUES('Graciliano Ramos');
INSERT INTO Authors(Name) VALUES('Monteiro Lobato');
GO

INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('Capitães da Areia',1937,1);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('O Quinze',1930,2);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('Dom Casmurro',1899,3);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('Tieta do agreste',1977,1);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('As três marias',1939,2);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('Memórias Póstumas de Brás Cubas',1881,3);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('Água Viva',1973,4);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('A hora da estrela',1977,4);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('A legião estrangeira',1964,4);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('Iracema',1865,5);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('Senhora',1875,5);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('O Guarani',1857,5);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('Sagarana',1946,6);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('Grande Sertão: Veredas',1956,6);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('Campo Geral',1964,6);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('Vidas Secas',1938,7);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('Caetés',1947,7);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('Insônia',1947,7);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('O Saci',1921,8);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('Urupês',1918,8);
INSERT INTO Books(Title, ReleaseYear, AuthorId) VALUES('Viagem ao Céu',1932,8);