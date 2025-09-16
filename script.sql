create database EcomLoja;
use Ecomloja;

create table produtos(
 Id int primary key auto_increment,
 Nome varchar(40),
Descricao varchar(40),
Preco decimal(10,2),
ImageUrl varchar(255),
Estoque int
);

create table pedido(
Id int primary key auto_increment ,
DataPedido datetime,
Total decimal(10,2),
Status varchar(50),
Endereco varchar(100),
FormaPagamento varchar(100),
Frete decimal (10,2)
);


create table itemPedido(
Id int primary key auto_increment ,
PedidoId int,
ProdutoId int,
Quantidade int,
PrecoUnitario decimal(10,2)
);

INSERT INTO produtos (Nome, Descricao, Preco, ImageUrl, Estoque)
VALUES ('Carrinhos', 'Pacote com 5 Carros', 67.90, '/img/01.jpg', 5),
('Guincho Tubarão', 'Conjunto de Guincho Tubarão', 172.90, '/img/02.jpg', 5),
('Pista de Percurso T-Rex X', 'Quartel de Bombeiros', 286.90, '/img/03.jpg', 10),
('Pista de Percurso e Mini Veículo', 'City - Lava-Rápido', 109.90, '/img/04.jpg', 15),
('City Nemesis - Gorila', 'Pista de Percurso e Mini Veículo', 161.90, '/img/05.jpg', 20),
('Reboque e Mini Veículo', 'City - Reboque de Dragão', 127.90, '/img/06.jpg', 25);

select * from produtos;
select * from pedido;
select * from itemPedido;