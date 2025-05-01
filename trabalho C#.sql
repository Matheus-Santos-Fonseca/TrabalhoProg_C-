create database Banco_cadastro;

use Banco_cadastro;

create table Tbl_Funcionario
(
	codigo int primary key auto_increment not null,
	nome varchar(100),
	endereço varchar(100),
	email varchar(100),
	celular varchar(20),
	funcao varchar(50)
);
                            
create table Tbl_Funcao
(
	idfuncao int primary key auto_increment not null,
    funcao varchar(50)
);
INSERT INTO Tbl_Funcao (funcao) VALUES ('Vendedor');
INSERT INTO Tbl_Funcao (funcao) VALUES ('Gerente');
INSERT INTO Tbl_Funcao (funcao) VALUES ('Caixa');
create table Tbl_Vendas
(
	codigo_venda int primary key auto_increment not null,
    data_venda date,
    nome_produto varchar(100),
    quantidade_produto int,
    preço_unitario float,
    preço_total float,
    forma_de_pagamento varchar(50)
);

create table Tbl_FormadePagamento 
(
	idformadepagamento int primary key auto_increment not null,
    forma_de_pagamento varchar(50)
);
INSERT INTO Tbl_FormadePagamento (forma_de_pagamento) VALUES ('Dinheiro');
INSERT INTO Tbl_FormadePagamento (forma_de_pagamento) VALUES ('Cartão de Crédito');
INSERT INTO Tbl_FormadePagamento (forma_de_pagamento) VALUES ('PIX');
create table Usuarios 
(
    Id int primary key auto_increment not null,
    NomeUsuario VARCHAR(50),
    Senha VARCHAR(100)
);

select * from Tbl_Funcao;
select * from Tbl_Funcionario;
select * from Usuarios;
insert into Usuarios(NomeUsuario, Senha) Values ("admin","000");
select * from Tbl_Vendas;
select * from Tbl_FormadePagamento;

drop table Usuarios;
ALTER TABLE Tbl_FormadePagamento CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;


