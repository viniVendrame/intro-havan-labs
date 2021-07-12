/****** Script do comando SelectTopNRows de SSMS  ******/

-- CREATE --
CREATE TABLE Categorias(
	Id int identity(1, 1) NOT NULL,
	Nome varchar(50) NOT NULL
);

-- DELETE --
DROP TABLE Categorias;