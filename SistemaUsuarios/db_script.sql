CREATE DATABASE SistemaUsuarios
GO
USE SistemaUsuarios

CREATE TABLE Usuarios(
	Id INT PRIMARY KEY IDENTITY(1,1), --Opcional 
	Email VARCHAR(256) NOT NULL,
	EmailNormalizado VARCHAR(256) NOT NULL,
	PasswordHash NVARCHAR(MAX) NOT NULL
)