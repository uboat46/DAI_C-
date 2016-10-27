CREATE TABLE usuarios
(
	usuario varchar(50) NOT NULL,
	passwd varchar(20) NOT NULL,
	idUser int IDENTITY(1,1) NOT NULL PRIMARY KEY 
);
