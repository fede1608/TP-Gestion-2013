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
--	usr_id_rol bigint REFERENCES SIGKILL.Rol(id_rol),
	usr_direccion nvarchar(255) NOT NULL,
	usr_telefono nvarchar(25) NOT NULL,
	usr_mail nvarchar(255),
	usr_nacimiento nvarchar(255),
	usr_sexo nvarchar(255),
	usr_cant_login_fail int DEFAULT 0 NOT NULL)
--	id_tipo_usuario bigint REFERENCES RANDOM.Tipo_Usuario(id_tipo_usuario),
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
	rusr_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	rusr_usuario bigint REFERENCES SIGKILL.usuario(usr_id),
	rusr_rol bigint REFERENCES SIGKILL.rol(rol_id)
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
	frol_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	frol_rol bigint REFERENCES SIGKILL.rol(rol_id),
	frol_funcionalidad bigint REFERENCES SIGKILL.funcionalidad(func_id)
	)
GO

-- Tabla Profesional
CREATE TABLE SIGKILL.profesional(
	pro_matricula bigint PRIMARY KEY NOT NULL,
	pro_usuario bigint REFERENCES SIGKILL.usuario(usr_id), 
	pro_cant_hs_acum int DEFAULT 0 NOT NULL
	)
GO

-- Tabla Especialidad
CREATE TABLE SIGKILL.especialidad(
	esp_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	esp_nombre_especialidad nvarchar(255) NOT NULL
	)
GO

-- Tabla Especialidad de un Profesional
CREATE TABLE SIGKILL.esp_prof(
	espprof_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	espprof_matricula bigint REFERENCES SIGKILL.profesional(pro_matricula),
	espprof_especialidad bigint REFERENCES SIGKILL.especialidad(esp_id)
	)
GO

-- Tabla Dias por Profesional
CREATE TABLE SIGKILL.dias_por_profesional(
	dpp_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	dpp_fecha_dia date NOT NULL,
	dpp_dia date NOT NULL, --TODO REVISAR
	dpp_matricula_prof bigint REFERENCES SIGKILL.profesional(pro_matricula),
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
	pmed_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
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
	cam_matricula bigint REFERENCES SIGKILL.profesional(pro_matricula),
	cam_nro_afiliado bigint REFERENCES SIGKILL.afiliado(afil_numero),
	cam_tipo_cancelacion bigint REFERENCES SIGKILL.tipo_cancelacion(tic_id),
	cam_fecha datetime NOT NULL
	)
GO

-- Tabla Turno
CREATE TABLE SIGKILL.turno(
	trn_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	trn_matricula bigint REFERENCES SIGKILL.profesional(pro_matricula),
	trn_afiliado bigint REFERENCES SIGKILL.afiliado(afil_numero),
	trn_fecha_hora datetime NOT NULL
	)
GO

-- Tabla Registro Resultado
CREATE TABLE SIGKILL.registro_resultado(
	regr_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	regr_matricula bigint REFERENCES SIGKILL.profesional(pro_matricula),
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
	rec_nro_receta bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
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
	recmed_nro_receta bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	recmed_medicamento bigint REFERENCES SIGKILL.medicamento(medic_id),
	recmed_cantidad int DEFAULT 1 NOT NULL,
	recmed_aclaracion nvarchar(255) NULL
	)
GO

