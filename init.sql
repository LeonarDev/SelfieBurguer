CREATE DATABASE selfie_burguer
GO

USE selfie_burguer
GO

-- CRIA TABELAS
CREATE TABLE Usuario (
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	Email varchar(255) NOT NULL,
	Senha varchar(255) NOT NULL,
	Ativo BIT DEFAULT 1,
	TipoUsuario INT,
)
GO

CREATE TABLE Categoria (
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	Nome varchar(255) NOT NULL,
)
GO

CREATE TABLE Cliente (
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	Nome varchar(255) NOT NULL,
	Sobrenome varchar(255) NOT NULL,
	Email varchar(255) NOT NULL,
	Cpf varchar(255) NOT NULL,
	Ativo BIT DEFAULT 1,
	DataCadastro DateTime NOT NULL,
)
GO

CREATE TABLE Produto (
    Id INT NOT NULL IDENTITY PRIMARY KEY,
    Nome varchar(255) NOT NULL,
    Descricao varchar(255),
    Observacao varchar(255) NULL,
    Valor float NOT NULL,
    Disponivel BIT DEFAULT 1,
    Imagem varbinary(max),
    CategoriaId INT NOT NULL,
    FOREIGN KEY (CategoriaId) REFERENCES Categoria(Id)
)
GO

CREATE TABLE Pedido (
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	DataCriacao DateTime NOT NULL,
	DataFinalizacao DateTime NULL,
	Status INT NOT NULL,
	ClienteId INT NOT NULL,
	ValorTotal float,
	FOREIGN KEY (ClienteId) REFERENCES Cliente (Id)
)
GO

CREATE TABLE PedidoProduto (
    Id INT NOT NULL IDENTITY PRIMARY KEY,
    PedidoId INT NOT NULL,
    ProdutoId INT NOT NULL,
    CONSTRAINT FK_PedidoProduto_Pedido FOREIGN KEY (PedidoId) REFERENCES Pedido (Id),
    CONSTRAINT FK_PedidoProduto_Produto FOREIGN KEY (ProdutoId) REFERENCES Produto (Id)
)
GO

INSERT INTO Cliente(Nome, Sobrenome, Email, Cpf, Ativo, DataCadastro) VALUES('Gian Claudio', 'Danvame', 'rocky@balboa.com', '12345678900', 1, '20120618 10:34:19 AM')
INSERT INTO Cliente(Nome, Sobrenome, Email, Cpf, Ativo, DataCadastro) VALUES('Arnold', 'Scharzenegger', 'louferrigno@mail.com','11223344556', 1, '20120618 10:34:19 AM')
INSERT INTO Categoria(Nome) VALUES('Lanche')
INSERT INTO Categoria(Nome) VALUES('Bebida')
INSERT INTO Categoria(Nome) VALUES('Sobremesa')
INSERT INTO Categoria(Nome) VALUES('Adicional')
INSERT INTO Produto(Nome, Descricao, Valor, Disponivel, CategoriaId) VALUES('Big-Burguer', 'Dois hambúrgueres, alface, queijo, molho especial, cebola, picles, num pão com gergelim', 20.0, 1, 1)
INSERT INTO Produto(Nome, Descricao, Valor, Disponivel, CategoriaId) VALUES('Total-Cola', 'Bebida gaseificada sabor Cola', 5.0, 1, 2)
INSERT INTO Produto(Nome, Descricao, Valor, Disponivel, CategoriaId) VALUES('Brownie', 'Bolo de chocolate solado', 10.0, 1, 3)
INSERT INTO Pedido(DataCriacao, Status, ClienteId,  ValorTotal) VALUES ('20120618 10:34:19 AM', 1, 1, 20)
INSERT INTO PedidoProduto(PedidoId, ProdutoId) VALUES (1, 1)
GO