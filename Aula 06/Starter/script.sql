--drop table Cidade
CREATE TABLE Cidade (
  Id int IDENTITY (1, 1) NOT NULL,
  Nome varchar(255) NOT NULL,
  
  CONSTRAINT PK_Cidade PRIMARY KEY (Id)
);

--drop table Especialidade
CREATE TABLE Especialidade (
  Id int IDENTITY (1, 1) NOT NULL,
  Nome varchar(255) NOT NULL,
  
  CONSTRAINT PK_Especialidade PRIMARY KEY (Id)
);

--drop table medico
CREATE TABLE Medico (
  Id int IDENTITY (1, 1) NOT NULL,
  Nome varchar(255) NOT NULL,
  Crm varchar(30) NOT NULL,
  Endereco varchar(100) NULL,
  Bairro varchar(100) NULL,
  Email varchar(100) NULL,
  AtendePorConvenio int NULL,
  TemClinica int NULL,
  WebsiteBlog varchar(100) NULL,
  CidadeId int NOT NULL,
  EspecialidadeId int NOT NULL,

  CONSTRAINT PK_Medico PRIMARY KEY (Id, Nome),
  CONSTRAINT FK_MedicoCidade FOREIGN KEY (CidadeId) REFERENCES Cidade (Id),
  CONSTRAINT FK_MedicoEspecialidade FOREIGN KEY (EspecialidadeId) REFERENCES Especialidade (Id)
);

--drop table Usuario
CREATE TABLE Usuario (
  Id int IDENTITY (1, 1) NOT NULL,
  Nome varchar(255) NOT NULL,
  [Login]   varchar (50) NULL,
  Senha   varchar (50) NULL,
  Email   varchar (100) NULL,
  
  CONSTRAINT PK_Usuario PRIMARY KEY (Id)
);