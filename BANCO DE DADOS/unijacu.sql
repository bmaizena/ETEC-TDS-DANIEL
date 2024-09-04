#Criar banco de dados
create database unijacupiranga;

#Apontar o banco que iremos usar
use unijacupiranga;

#Criar tabela alunos
create table alunos
(
id int auto_increment,
nome varchar(50),
dt_nasc date,
rua varchar(50),
bairro varchar(30),
cidade varchar(30),
estado varchar(2),
dt_matricula date,
primary key(id)
);

create table professores
(
id int auto_increment,
nome varchar(50),
dt_nasc date,
genero varchar(50),
rua varchar(50),
bairro varchar(30),
cidade varchar(30),
estado varchar(2),
dt_contratacao date,
primary key(id)
);

create table disciplinas
(
id int auto_increment,
nome varchar(50),
cargaHoraria varchar(8),
primary key(id)
);

create table cursos
(
id int auto_increment,
nome varchar(30),
duracao varchar (10),
dt_inicio date,
dt_fim date,
primary key (id)
);

create table alunoXtelefone 
(
id int auto_increment,
idAluno int,
numTelefone varchar(17),
primary key(id),
constraint fk_alunoXtelefone foreign key(idAluno) references alunos(id)
);

create table alunoXemail
(
id int auto_increment,
idAluno int,
email varchar(100),
primary key(id),
constraint fk_alunoXemail foreign key(idAluno) references alunos(id)
);

create table professorXtelefone 
(
id int auto_increment,
idProfessor int,
numTelefone varchar(17),
primary key(id),
constraint fk_professoresXtelefone foreign key(idprofessor) references professores(id)
);

create table professorXemail
(
id int auto_increment,
idprofessor int,
email varchar(100),
primary key(id),
constraint fk_professoresXemail foreign key(idprofessor) references professores(id)
);

create table alunosXcursos
(
id int auto_increment,
idAluno int,
idCurso int,
primary key(id),
constraint fk_alunosXcursos foreign key(idAluno) references alunos(id),
constraint fk_cursosXalunos foreign key(idCurso) references cursos(id)
);

create table cursosXdisciplinas
(
id int auto_increment,
idDisciplina int,
idCurso int,
primary key(id),
constraint fk_disciplinasXcursos foreign key(idDisciplina) references disciplinas(id),
constraint fk_cursosXdisciplinas foreign key(idCurso) references cursos(id)
);

create table professoresXdisciplinas
(
id int auto_increment,
idProfessor int,
idDisciplina int,
primary key(id),
constraint fk_professoresXdisciplinas foreign key(idProfessor) references professores(id),
constraint fk_disciplinasXprofessores foreign key(idDisciplina) references disciplinas(id)
);





