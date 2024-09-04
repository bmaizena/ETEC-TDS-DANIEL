create database empresa;

create table departamento
(
id int auto_increment primary key,
descricao varchar(100) not null
);

create table funcionario 
(
id int auto_increment primary key,
nome varchar(250) not null,
dt_nasc date not null,
departamento_id int not null,
constraint funcXdep foreign key(departamento_id) references departamento(id)
);

insert into departamento (descricao) values('recursos humanos'), ('contabilidade'), ('administração'), ('diretoria'), ('design');
insert into funcionario (nome, dt_nasc, departamento_id) values('Daniel','1998-04-04',1);


delete from departamento where id=2;
select * from funcionario;

