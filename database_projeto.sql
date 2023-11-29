DROP DATABASE teste_sql;
CREATE DATABASE IF NOT EXISTS teste_sql;

USE teste_sql;
CREATE TABLE IF NOT EXISTS americanas (
    id_americanas INT AUTO_INCREMENT NOT NULL,
    cep_americanas VARCHAR(10) NOT NULL,
    rua_americanas VARCHAR(75) NOT NULL,
    bairro_americanas VARCHAR(75) NOT NULL,
    numero_americanas VARCHAR(15) NOT NULL DEFAULT '0',
    senha_americanas VARCHAR(16) NOT NULL,
    telefone_americanas VARCHAR(15) NOT NULL,
    PRIMARY KEY (id_americanas)
);

CREATE TABLE IF NOT EXISTS entregador (
    cpf_entregador VARCHAR(15) NOT NULL,
    nome_entregador VARCHAR(75) NULL DEFAULT NULL,
    PRIMARY KEY (cpf_entregador)
);

CREATE TABLE IF NOT EXISTS funcionario (
    email_americanas_funcionario VARCHAR(75) NOT NULL,
    cpf_funcionario VARCHAR(15) NOT NULL,
    nome_funcionario VARCHAR(75) NOT NULL,
    telefone_funcionario VARCHAR(15) NOT NULL,
    senha_funcionario VARCHAR(20) NOT NULL,
    id_americanas INT NULL DEFAULT NULL,
    UNIQUE INDEX (cpf_funcionario),
    PRIMARY KEY (email_americanas_funcionario),
    FOREIGN KEY (id_americanas) REFERENCES americanas (id_americanas)
);


CREATE TABLE IF NOT EXISTS titular (
  cpf_titular VARCHAR(15) NOT NULL,
  nome VARCHAR(75) NOT NULL,
  email VARCHAR(30) NOT NULL,
  telefone VARCHAR(15) NOT NULL,
  PRIMARY KEY (cpf_titular));


CREATE TABLE IF NOT EXISTS tbl_data (
  id_data INT AUTO_INCREMENT NOT NULL,
  chegada_data DATE NOT NULL,
  retirada_data DATE NULL DEFAULT NULL,
  PRIMARY KEY (id_data));
  

  CREATE TABLE IF NOT EXISTS hora (
	id_hora INT AUTO_INCREMENT NOT NULL,
    chegada_hora TIME NOT NULL,
	retirada_hora TIME NULL DEFAULT NULL,
    primary key (id_hora));


CREATE TABLE IF NOT EXISTS pacote (
  nota_fiscal_pacote varchar(45) NOT NULL,
  situacao_pacote VARCHAR(20) NOT NULL,
  email_americanas_funcionario VARCHAR(30) NULL DEFAULT NULL,
  cpf_titular VARCHAR(15) NULL DEFAULT NULL,
  cpf_entregador VARCHAR(15) NULL DEFAULT NULL,
  id_data INT NULL DEFAULT NULL,
  id_hora INT NULL DEFAULT NULL,
  PRIMARY KEY (nota_fiscal_pacote),
  FOREIGN KEY (cpf_entregador) REFERENCES entregador (cpf_entregador),
  FOREIGN KEY (cpf_titular) REFERENCES titular (cpf_titular),
  FOREIGN KEY (email_americanas_funcionario) REFERENCES funcionario (email_americanas_funcionario),
  FOREIGN KEY (id_data) REFERENCES tbl_data (id_data),
  FOREIGN KEY (id_hora) REFERENCES hora (id_hora));


CREATE TABLE IF NOT EXISTS observacao (
  id_relatorio INT AUTO_INCREMENT NOT NULL,
  campo_relatorio VARCHAR(1000) NULL DEFAULT NULL,
  nota_fiscal_pacote VARCHAR(45) NOT NULL,
  UNIQUE INDEX (nota_fiscal_pacote),
  PRIMARY KEY (id_relatorio),
  FOREIGN KEY (nota_fiscal_pacote) REFERENCES pacote (nota_fiscal_pacote));
  
INSERT INTO americanas VALUES ("1", "13059-592", "Av. Dra. Zilda Arns Neumann", "Cidade Satélite Íris", "2760", "123456", "(11) 4812-7639");
INSERT INTO funcionario VALUES ("administrador@americanas.com.br", "111.111.111-11", "Administrador", "(11) 11111-1111", "admin123", "1");
