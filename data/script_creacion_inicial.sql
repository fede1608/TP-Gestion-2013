USE [GD2C2013]
GO






/***** CREAR ESQUEMA *****/
CREATE SCHEMA SIGKILL AUTHORIZATION gd
GO





/***** CREAR TABLAS *****/
-- Tabla Usuario
CREATE TABLE SIGKILL.usuario(
	usr_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	usr_usuario nvarchar(255) UNIQUE NOT NULL,
	usr_password nvarchar(255) NOT NULL,
	usr_nombre nvarchar(200) NOT NULL,
	usr_apellido nvarchar(100) NOT NULL,
	usr_dni numeric(18, 0) NOT NULL,
	usr_id_rol bigint REFERENCES SIGKILL.Rol(id_rol),
	usr_direccion nvarchar(255) NOT NULL,
	usr_telefono nvarchar(25) NOT NULL,
	usr_mail nvarchar(255),
	usr_nacimiento nvarchar(255),
	usr_sexo nvarchar(255),
	usr_cant_login_fail int DEFAULT 0 NOT NULL)
--	id_tipo_usuario bigint REFERENCES RANDOM.Tipo_Usuario(id_tipo_usuario),
--	estado numeric(1, 0) NOT NULL,
GO
