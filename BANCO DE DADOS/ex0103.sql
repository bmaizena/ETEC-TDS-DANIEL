USE biblioteca;
CREATE TABLE emprestimo
(
id_emprestimo INT PRIMARY KEY NOT NULL,
livro_empr INT,
cliente_empr INT,
dt_empr DATE,
dt_dev_prevista DATE,
stats VARCHAR(100),
FOREIGN KEY(livro_empr) REFERENCES livro(id_livro),
FOREIGN KEY(cliente_empr) REFERENCES cliente(id_cliente)	
);



