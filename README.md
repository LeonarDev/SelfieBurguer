# SelfieBurguer

### Instancia do banco:
```shel
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_AGENT_ENABLED=Y" -e "MSSQL_TLS_CERTIFICATE=0" -e "MSSQL_SA_PASSWORD=YourStrong@Passw0rd" -p 1433:1433 --name sql1 --hostname sql1 -d mcr.microsoft.com/mssql/server:2022-latest
```

<br>

### Tabelas

```SQL
-- CRIA E UTILIZA O BANCO DE DADOS
CREATE DATABASE selfie_burguer;
USE selfie_burguer;

-- CRIA TABELAS
CREATE TABLE Usuario (
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	Email varchar(255) NOT NULL,
	Senha varchar(255) NOT NULL,
	Ativo BIT DEFAULT 1,
	TipoUsuario INT,
);

CREATE TABLE Categoria (
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	Nome varchar(255) NOT NULL,
);

CREATE TABLE Cliente (
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	Nome varchar(255) NOT NULL,
	Sobrenome varchar(255) NOT NULL,
	Email varchar(255) NOT NULL,
	Cpf varchar(255) NOT NULL,
	Ativo BIT DEFAULT 1,
	DataCadastro DateTime NOT NULL,
);

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
);

CREATE TABLE Pedido (
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	DataCriacao DateTime NOT NULL,
	DataFinalizacao DateTime NULL,
	Status INT NOT NULL,
	ClienteId INT NOT NULL,
	ValorTotal float,
	FOREIGN KEY (ClienteId) REFERENCES Cliente (Id)
);

CREATE TABLE PedidoProduto (
    Id INT NOT NULL IDENTITY PRIMARY KEY,
    PedidoId INT NOT NULL,
    ProdutoId INT NOT NULL,
    CONSTRAINT FK_PedidoProduto_Pedido FOREIGN KEY (PedidoId) REFERENCES Pedido (Id),
    CONSTRAINT FK_PedidoProduto_Produto FOREIGN KEY (ProdutoId) REFERENCES Produto (Id)
);

-- CARGA INICIAL
INSERT INTO Cliente(Nome, Sobrenome, Email, Ativo, DataCadastro) VALUES('Leonardo', 'Majevski', 'majevski@mail.com', 1, '20120618 10:34:19 AM');
INSERT INTO Cliente(Nome, Sobrenome, Email, Ativo, DataCadastro) VALUES('Laísa', 'Motta', 'laisa@mail.com', 1, '20120618 10:34:19 AM');
INSERT INTO Categoria(Nome) VALUES('Lanche');
INSERT INTO Categoria(Nome) VALUES('Bebida');
INSERT INTO Categoria(Nome) VALUES('Sobremesa');
INSERT INTO Categoria(Nome) VALUES('Combo');
INSERT INTO Produto(Nome, Descricao, Valor, Disponivel, CategoriaId) VALUES('Cheese-Burguer', 'Pão, carne de hamburguer, queijo prato', 20.0, 1, 1);
INSERT INTO Produto(Nome, Descricao, Valor, Disponivel, CategoriaId) VALUES('Total-Cola', 'Bebida gaseificada sabor Cola', 5.0, 1, 2);
INSERT INTO Produto(Nome, Descricao, Valor, Disponivel, CategoriaId) VALUES('Brownie', 'Bolo de chocolate solado', 10.0, 1, 3);
INSERT INTO Pedido(DataCriacao, Status, ClienteId,  ValorTotal) VALUES ('20120618 10:34:19 AM', 1, 1, 20);
INSERT INTO PedidoProduto(PedidoId, ProdutoId) VALUES (1, 1);

-- EVITAR A FADIGA
SELECT * FROM Cliente;
SELECT * FROM Categoria;
SELECT * FROM Produto P inner join Categoria C on P.CategoriaId = C.Id;
SELECT * FROM Pedido PE inner join Cliente CL on CL.Id = PE.ClienteId inner join PedidoProduto PP on PE.Id = PP.PedidoId inner join Produto PR on PR.Id = PP.ProdutoId;

```
