create database teste;
use teste;
create table pessoas
(
codigo int auto_increment,
nome varchar(50),
primary key(codigo)
);

insert into pessoas (nome) values ("Dan Sallesse");

select * from pessoas;