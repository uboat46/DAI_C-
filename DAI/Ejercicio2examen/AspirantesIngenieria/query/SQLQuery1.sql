CREATE TABLE aspirante
(
	nombre varchar(50) NOT NULL,
	sexo varchar(50) NOT NULL,
	fechaNac date NOT NULL,
	correo varchar(50) NOT NULL,
	grado int NOT NULL,
	idIngenieria int NOT NULL
);

CREATE TABLE programa
(
	idPrograma int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	nombrePrograma varchar(50) NOT NULL
);
