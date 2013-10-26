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
	usr_cant_login_fail int DEFAULT 0 NOT NULL)
--	estado numeric(1, 0) NOT NULL,
GO

-- Tabla Rol
CREATE TABLE SIGKILL.rol(
	rol_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	rol_nombre nvarchar(255) NOT NULL,
	rol_habilitado int DEFAULT 1 NOT NULL
	)
GO

-- Tabla Rol Usuario
CREATE TABLE SIGKILL.rol_usuario(
	rusr_usuario bigint REFERENCES SIGKILL.usuario(usr_id),
	rusr_rol bigint REFERENCES SIGKILL.rol(rol_id)
	CONSTRAINT PK_rol_usuario PRIMARY KEY CLUSTERED(rusr_usuario , rusr_rol)
	)
GO

-- Tabla Funcionalidad
CREATE TABLE SIGKILL.funcionalidad(
	func_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	func_descripcion nvarchar(255) NOT NULL
	)
GO

-- Tabla Funcionalidades por Rol
CREATE TABLE SIGKILL.func_rol(
	frol_rol bigint REFERENCES SIGKILL.rol(rol_id),
	frol_funcionalidad bigint REFERENCES SIGKILL.funcionalidad(func_id),
	CONSTRAINT PK_func_rol PRIMARY KEY CLUSTERED(frol_rol , frol_funcionalidad)
	)
GO

-- Tabla Profesional
CREATE TABLE SIGKILL.profesional(
	pro_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	pro_matricula bigint,
	pro_usuario bigint REFERENCES SIGKILL.usuario(usr_id), 
	pro_nombre nvarchar(200) NOT NULL,
	pro_apellido nvarchar(100) NOT NULL,
	pro_dni numeric(18, 0) NOT NULL,
--	pro_id_rol bigint REFERENCES SIGKILL.Rol(id_rol),
	pro_direccion nvarchar(255) NOT NULL,
	pro_telefono nvarchar(25) NOT NULL,
	pro_mail nvarchar(255),
	pro_nacimiento datetime,
	pro_sexo nvarchar(1),
	pro_cant_hs_acum int DEFAULT 0 NOT NULL
	)
GO

-- Tabla Tipo especialidad
CREATE TABLE SIGKILL.tipo_especialidad(
	tesp_id bigint PRIMARY KEY  NOT NULL,
	tesp_tipo_nombre nvarchar(255) NOT NULL
	)
GO

-- Tabla Especialidad
CREATE TABLE SIGKILL.especialidad(
	esp_id bigint PRIMARY KEY NOT NULL,
	esp_nombre_especialidad nvarchar(255) NOT NULL,
	esp_tipo bigint REFERENCES SIGKILL.tipo_especialidad(tesp_id)
	)
GO

-- Tabla Especialidad de un Profesional
CREATE TABLE SIGKILL.esp_prof(
	espprof_profesional bigint REFERENCES SIGKILL.profesional(pro_id),
	espprof_especialidad bigint REFERENCES SIGKILL.especialidad(esp_id),
	CONSTRAINT PK_esp_prof PRIMARY KEY CLUSTERED(espprof_profesional, espprof_especialidad)
	)
GO

-- Tabla Dias por Profesional
CREATE TABLE SIGKILL.dias_por_profesional(
	dpp_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	dpp_fecha_dia date NOT NULL,
	dpp_dia date NOT NULL, --TODO REVISAR
	dpp_profesional bigint REFERENCES SIGKILL.profesional(pro_id),
	dpp_disponible int DEFAULT 1 NOT NULL
	)
GO

-- Tabla Horarios por dia
CREATE TABLE SIGKILL.horarios_por_dia(
	hpd_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	hpd_horario time NOT NULL,--TODO:revisar
	hpd_id_dia bigint REFERENCES SIGKILL.dias_por_profesional(dpp_id),
	hpd_disponible int DEFAULT 1 NOT NULL
	)
GO



-- Tabla Estado Civil
CREATE TABLE SIGKILL.estado_civil(
	estciv_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	estciv_descripcion nvarchar(255) NOT NULL
	)
GO

-- Tabla Plan Medico
CREATE TABLE SIGKILL.plan_medico(
	pmed_id bigint PRIMARY KEY NOT NULL,
	pmed_nombre nvarchar(255) NOT NULL,
	pmed_precio decimal(6,2) NOT NULL,
	pmed_precio_bono_consulta decimal(6,2) NOT NULL,
	pmed_precio_bono_farmacia decimal(6,2) NOT NULL,
	)
GO
-- Tabla Afiliado
CREATE TABLE SIGKILL.afiliado(
	afil_numero bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	afil_usuario bigint REFERENCES SIGKILL.usuario(usr_id), 
	afil_nombre nvarchar(200) NOT NULL,
	afil_apellido nvarchar(100) NOT NULL,
	afil_dni numeric(18, 0) NOT NULL,
--	afil_id_rol bigint REFERENCES SIGKILL.Rol(id_rol),
	afil_direccion nvarchar(255) NOT NULL,
	afil_telefono nvarchar(25) NOT NULL,
	afil_mail nvarchar(255),
	afil_nacimiento datetime,
	afil_sexo nvarchar(1),
	afil_estado_civil bigint REFERENCES SIGKILL.estado_civil(estciv_id), 
	afil_cant_hijos int DEFAULT 0 NOT NULL,
	afil_cant_fam_a_cargo int DEFAULT 0 NOT NULL,
	afil_id_plan_medico bigint REFERENCES SIGKILL.plan_medico(pmed_id),
	afil_activo int DEFAULT 1 NOT NULL
	)
GO

-- Tabla Tipo Cancelacion
CREATE TABLE SIGKILL.tipo_cancelacion(
	tic_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	tic_nombre_tipo nvarchar(255) NOT NULL,
	tic_motivo nvarchar(255) NOT NULL
	)
GO

-- Tabla Cancelacion Atencion Medica
CREATE TABLE SIGKILL.cancelacion_atencion_medica(
	cam_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	cam_profesional bigint REFERENCES SIGKILL.profesional(pro_id),
	cam_nro_afiliado bigint REFERENCES SIGKILL.afiliado(afil_numero),
	cam_tipo_cancelacion bigint REFERENCES SIGKILL.tipo_cancelacion(tic_id),
	cam_fecha datetime NOT NULL
	)
GO

-- Tabla Turno
CREATE TABLE SIGKILL.turno(
	trn_id bigint PRIMARY KEY NOT NULL,
	trn_profesional bigint REFERENCES SIGKILL.profesional(pro_id),
	trn_afiliado bigint REFERENCES SIGKILL.afiliado(afil_numero),
	trn_fecha_hora datetime NOT NULL
	)
GO

-- Tabla Registro Resultado
CREATE TABLE SIGKILL.registro_resultado(
	regr_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	regr_profesional bigint REFERENCES SIGKILL.profesional(pro_id),
	regr_afiliado bigint REFERENCES SIGKILL.afiliado(afil_numero),
	regr_fecha_hora datetime NOT NULL,
	regr_sintomas nvarchar(255) NOT NULL,
	regr_diagnostico nvarchar(255) NOT NULL
	)
GO

-- Tabla Registro Llegada
CREATE TABLE SIGKILL.registro_llegada(
	rll_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	rll_afiliado bigint REFERENCES SIGKILL.afiliado(afil_numero),
	rll_asistioparcialmente int DEFAULT 0 NOT NULL,
	rll_fecha_hora datetime NOT NULL
	)
GO

-- Tabla Baja Afiliado
CREATE TABLE SIGKILL.baja_afiliado(
	bafil_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	bafil_afiliado bigint REFERENCES SIGKILL.afiliado(afil_numero),
	bafil_motivo nvarchar(255) NOT NULL,
	bafil_fecha datetime NOT NULL
	)
GO

-- Tabla Cambio Plan
CREATE TABLE SIGKILL.cambio_plan(
	capla_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	capla_afiliado bigint REFERENCES SIGKILL.afiliado(afil_numero),
	capla_plan_viejo bigint REFERENCES SIGKILL.plan_medico(pmed_id),
	capla_plan_nuevo bigint REFERENCES SIGKILL.plan_medico(pmed_id),
	capla_fecha datetime NOT NULL,
	)
GO


-- Tabla tipo Bono
CREATE TABLE SIGKILL.tipo_bono(
	tbono_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	tbono_descripcion nvarchar(255) NULL
	)
GO
	
-- Tabla Bono
CREATE TABLE SIGKILL.bono(
	bono_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	bono_afiliado bigint REFERENCES SIGKILL.afiliado(afil_numero),
	bono_fecha_compra datetime NOT NULL,
	bono_plan_medico bigint REFERENCES SIGKILL.plan_medico(pmed_id),
	bono_nro_consulta bigint NOT NULL,--TODO:revisar completar
	bono_consumido int DEFAULT 0 NOT NULL,
	bono_tipo bigint REFERENCES SIGKILL.tipo_bono(tbono_id),
	bono_precio decimal(6,2) NOT NULL
	)
GO

-- Tabla Receta
CREATE TABLE SIGKILL.receta(
	rec_nro_receta bigint PRIMARY KEY NOT NULL,
	rec_bono_farmacia bigint REFERENCES SIGKILL.bono(bono_id)	
	)
GO

-- Tabla Medicamento
CREATE TABLE SIGKILL.medicamento(
	medic_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	medic_nombre nvarchar(255) NOT NULL
	)
GO

-- Tabla Receta Medicamento
CREATE TABLE SIGKILL.receta_medicamento(
	recmed_nro_receta bigint REFERENCES SIGKILL.receta(rec_nro_receta),
	recmed_medicamento bigint REFERENCES SIGKILL.medicamento(medic_id),
	recmed_cantidad int DEFAULT 1 NOT NULL,
	recmed_aclaracion nvarchar(255) NULL
	)
GO

/***** MIGRACION *****/
--insert de roles
INSERT INTO SIGKILL.rol (rol_nombre,rol_habilitado) 
VALUES ('Administrador',1),('Profesional',1),('Afiliado',1);

INSERT INTO SIGKILL.tipo_bono (tbono_descripcion) 
VALUES ('Farmacia'),('Consulta');

INSERT INTO SIGKILL.usuario(usr_usuario,usr_password) 
VALUES ('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7');

INSERT INTO SIGKILL.usuario(usr_usuario,usr_password)
(SELECT DISTINCT ('u'+CONVERT(nvarchar,Paciente_Dni)), '37a8eec1ce19687d132fe29051dca629d164e2c4958ba141d5f4133a33f0688f' FROM gd_esquema.Maestra);

INSERT INTO SIGKILL.plan_medico(pmed_id,pmed_nombre,pmed_precio,pmed_precio_bono_consulta,pmed_precio_bono_farmacia)
VALUES (555555,'Plan Medico 110',110,96,92),(555556,'Plan Medico 120',120,66,74),(555557,'Plan Medico 130',130,42,45),(555558,'Plan Medico 140',140,28,39),(555559,'Plan Medico 150',150,0,0);


INSERT INTO SIGKILL.afiliado (afil_usuario,afil_nombre,afil_apellido,afil_dni,afil_direccion,afil_telefono,afil_mail,afil_id_plan_medico)
(SELECT DISTINCT usr_id,Paciente_Nombre,Paciente_Apellido,Paciente_Dni,Paciente_Direccion,Paciente_Telefono,Paciente_Mail,Plan_Med_Codigo
FROM gd_esquema.Maestra INNER JOIN SIGKILL.usuario 
ON (usr_usuario=('u'+CONVERT(nvarchar,Paciente_Dni)))
)

INSERT INTO SIGKILL.usuario(usr_usuario,usr_password)
(SELECT DISTINCT ('u'+CONVERT(nvarchar,Medico_Dni)), '37a8eec1ce19687d132fe29051dca629d164e2c4958ba141d5f4133a33f0688f' FROM gd_esquema.Maestra WHERE Medico_Dni is not NULL);

INSERT INTO SIGKILL.profesional (pro_usuario,pro_nombre,pro_apellido,pro_dni,pro_direccion,pro_telefono,pro_mail,pro_nacimiento)
(SELECT DISTINCT usr_id,Medico_Nombre,Medico_Apellido,Medico_Dni,Medico_Direccion,Medico_Telefono,Medico_Mail,Medico_Fecha_nac
 FROM gd_esquema.Maestra INNER JOIN SIGKILL.usuario 
 ON (usr_usuario=('u'+CONVERT(nvarchar,Medico_Dni))))

INSERT INTO SIGKILL.turno(trn_id,trn_profesional,trn_afiliado,trn_fecha_hora)
(SELECT DISTINCT Turno_Numero,pro_id,afil_numero,Turno_Fecha
 FROM gd_esquema.Maestra,SIGKILL.afiliado,SIGKILL.profesional 
 WHERE Turno_Numero is not null AND afil_dni=Paciente_Dni AND pro_dni=Medico_Dni)
 
INSERT INTO SIGKILL.tipo_especialidad(tesp_id,tesp_tipo_nombre)
(SELECT DISTINCT Tipo_Especialidad_Codigo,Tipo_Especialidad_Descripcion 
 FROM gd_esquema.Maestra 
 WHERE Tipo_Especialidad_Codigo is not null)
 
 INSERT INTO SIGKILL.especialidad(esp_id,esp_nombre_especialidad,esp_tipo)
 (SELECT DISTINCT Especialidad_Codigo,Especialidad_Descripcion,Tipo_Especialidad_Codigo 
  FROM gd_esquema.Maestra 
  WHERE Especialidad_Codigo is not null)

 


