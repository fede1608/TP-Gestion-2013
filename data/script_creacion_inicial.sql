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
	usr_cant_login_fail int DEFAULT 0 NOT NULL,
	usr_estado numeric(1, 0) DEFAULT 1 NULL)
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

-- Tabla tipo Documento
CREATE TABLE SIGKILL.tipo_doc(
	tdoc_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	tdoc_descripcion nvarchar(30) NOT NULL
	)
GO

-- Tabla Profesional
CREATE TABLE SIGKILL.profesional(
	pro_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	pro_matricula bigint,
	pro_usuario bigint REFERENCES SIGKILL.usuario(usr_id), 
	pro_nombre nvarchar(200) NOT NULL,
	pro_apellido nvarchar(100) NOT NULL,
	pro_tipo_doc bigint REFERENCES SIGKILL.tipo_doc(tdoc_id),
	pro_dni numeric(18, 0) NOT NULL,
--	pro_id_rol bigint REFERENCES SIGKILL.Rol(id_rol),
	pro_direccion nvarchar(255) NOT NULL,
	pro_telefono decimal(18,0) NOT NULL,
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
CREATE TABLE SIGKILL.agenda_profesional(
	agp_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	agp_fecha_inicio date NOT NULL,
	agp_fecha_fin date NOT NULL,
	agp_profesional bigint REFERENCES SIGKILL.profesional(pro_id),
	agp_disponible int DEFAULT 1 NOT NULL
	)
GO

-- Tabla Horarios por dia
CREATE TABLE SIGKILL.horario_agenda(
	hag_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	hag_horario_inicio time NOT NULL,
	hag_horario_fin time NOT NULL,
	hag_id_agenda bigint REFERENCES SIGKILL.agenda_profesional(agp_id),
	hag_dia_semana int NOT NULL,
	hag_disponible int DEFAULT 1 NOT NULL
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
	afil_numero bigint PRIMARY KEY NOT NULL,
	afil_usuario bigint REFERENCES SIGKILL.usuario(usr_id), 
	afil_nombre nvarchar(200) NOT NULL,
	afil_apellido nvarchar(100) NOT NULL,
	afil_tipo_doc bigint REFERENCES SIGKILL.tipo_doc(tdoc_id),
	afil_dni numeric(18, 0) NOT NULL,
	afil_direccion nvarchar(255) NOT NULL,
	afil_telefono decimal(18,0) NOT NULL,
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

-- Tabla Compra Bono
CREATE TABLE SIGKILL.compra_bono(
	compra_id bigint PRIMARY KEY identity(1,1) NOT NULL,
	compra_afiliado bigint REFERENCES SIGKILL.afiliado(afil_numero),
	compra_fecha_de_compra datetime NOT NULL,
	compra_cant_bono_consulta int DEFAULT 0 NOT NULL,
	compra_cant_bono_farmacia int DEFAULT 0 NOT NULL,
	compra_total_abonado decimal(7,2) NOT NULL)
GO
	
-- Tabla Bono consulta
CREATE TABLE SIGKILL.bono_consulta(
	bonoc_id bigint PRIMARY KEY NOT NULL,
	bonoc_afiliado bigint REFERENCES SIGKILL.afiliado(afil_numero),
	bonoc_fecha_compra datetime NOT NULL,
	bonoc_plan_medico bigint REFERENCES SIGKILL.plan_medico(pmed_id),
	bonoc_nro_consulta_individual bigint NULL,
	bonoc_consumido int DEFAULT 0 NOT NULL,
	bonoc_precio decimal(6,2) NOT NULL
	)
GO

-- Tabla Bono farmacia
CREATE TABLE SIGKILL.bono_farmacia(
	bonof_id bigint PRIMARY KEY NOT NULL,
	bonof_afiliado bigint REFERENCES SIGKILL.afiliado(afil_numero),
	bonof_fecha_compra datetime NOT NULL,
	bonof_plan_medico bigint REFERENCES SIGKILL.plan_medico(pmed_id),
	bonof_consumido int DEFAULT 0 NOT NULL,
	bonof_precio decimal(6,2) NOT NULL
	)
GO

-- Tabla Consulta
CREATE TABLE SIGKILL.consulta(
	cons_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	cons_turno bigint REFERENCES SIGKILL.turno(trn_id),
	cons_bono_consulta bigint REFERENCES SIGKILL.bono_consulta(bonoc_id),
	cons_fecha_hora_llegada time NOT NULL,
	cons_fecha_hora_atencion time NULL,
	cons_sintomas nvarchar(255) NULL,
	cons_diagnostico nvarchar(255) NULL
	)
GO

-- Tabla Medicamento
CREATE TABLE SIGKILL.medicamento(
	medic_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	medic_nombre nvarchar(255) NOT NULL
	)
GO

-- Tabla Receta Medicamento
CREATE TABLE SIGKILL.medicamento_bono_farmacia(
	recmed_id bigint PRIMARY KEY IDENTITY(1,1) NOT NULL,
	recmed_bono_farmacia bigint REFERENCES SIGKILL.bono_farmacia(bonof_id),
	recmed_medicamento bigint REFERENCES SIGKILL.medicamento(medic_id),
	recmed_cantidad int DEFAULT 1 NOT NULL,
	recmed_aclaracion nvarchar(255) NULL
	)
GO


/***** MIGRACION *****/
INSERT INTO SIGKILL.funcionalidad(func_descripcion)
VALUES ('ABM de afiliados'),('ABM de profesional'),('ABM de especialidades médicas'),
('ABM de plan'),('Compra de bonos'),('Venta de bonos en ventanilla'),('Pedir un turno'),
('Registrar llegada para atención médica'),('Registrar resultado de atención médica'),
('Cancelar una atención médica'),('Generar una receta médica'),
('Generar un listado estadístico'),('Registrar agenda de profesional'),('Ver Agenda');
GO



--insert de roles
INSERT INTO SIGKILL.rol (rol_nombre,rol_habilitado) 
VALUES ('Administrador',1),('Profesional',1),('Afiliado',1);
GO

INSERT INTO SIGKILL.func_rol(frol_rol,frol_funcionalidad)
VALUES (1,1),(1,2),(1,3),(1,4),(1,6),(1,8),(1,10),(1,12),(1,13),(2,9),(2,14),(3,5),(3,7)
GO

INSERT INTO SIGKILL.tipo_doc(tdoc_descripcion)
VALUES ('DU'),('Libreta Civica'),('Libreta de Enrolamiento')
GO

INSERT INTO SIGKILL.estado_civil(estciv_descripcion)
VALUES ('Soltero/a'),('Casado/a'),('Viudo/a'),('Divorciado/a'),('Concubinato');
GO

INSERT INTO SIGKILL.usuario(usr_usuario,usr_password) 
VALUES ('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7');
GO

INSERT INTO SIGKILL.rol_usuario(rusr_usuario,rusr_rol)
VALUES (1,1)
GO

INSERT INTO SIGKILL.usuario(usr_usuario,usr_password)
(SELECT DISTINCT ('u'+CONVERT(nvarchar,Paciente_Dni)), '37a8eec1ce19687d132fe29051dca629d164e2c4958ba141d5f4133a33f0688f' FROM gd_esquema.Maestra);
GO

INSERT INTO SIGKILL.rol_usuario(rusr_usuario,rusr_rol)
(SELECT usr_id,3 FROM SIGKILL.usuario WHERE usr_id>1)
GO

INSERT INTO SIGKILL.plan_medico(pmed_id,pmed_nombre,pmed_precio,pmed_precio_bono_consulta,pmed_precio_bono_farmacia)
VALUES (555555,'Plan Medico 110',110,96,92),(555556,'Plan Medico 120',120,66,74),(555557,'Plan Medico 130',130,42,45),(555558,'Plan Medico 140',140,28,39),(555559,'Plan Medico 150',150,0,0);
GO

INSERT INTO SIGKILL.afiliado (afil_usuario,afil_numero,afil_nombre,afil_apellido,afil_dni,afil_direccion,afil_telefono,afil_mail,afil_id_plan_medico)
(SELECT DISTINCT usr_id,((usr_id-1)*100+1) as numero_afil,Paciente_Nombre,Paciente_Apellido,Paciente_Dni,Paciente_Direccion,Paciente_Telefono,Paciente_Mail,Plan_Med_Codigo
FROM gd_esquema.Maestra INNER JOIN SIGKILL.usuario 
ON (usr_usuario=('u'+CONVERT(nvarchar,Paciente_Dni)))
);
GO

INSERT INTO SIGKILL.usuario(usr_usuario,usr_password)
(SELECT DISTINCT ('u'+CONVERT(nvarchar,Medico_Dni)), '37a8eec1ce19687d132fe29051dca629d164e2c4958ba141d5f4133a33f0688f' FROM gd_esquema.Maestra WHERE Medico_Dni is not NULL);
GO

INSERT INTO SIGKILL.rol_usuario(rusr_usuario,rusr_rol)
(SELECT usr_id,2 FROM SIGKILL.usuario WHERE usr_id>7428)
GO

INSERT INTO SIGKILL.profesional (pro_usuario,pro_nombre,pro_apellido,pro_dni,pro_direccion,pro_telefono,pro_mail,pro_nacimiento)
(SELECT DISTINCT usr_id,Medico_Nombre,Medico_Apellido,Medico_Dni,Medico_Direccion,Medico_Telefono,Medico_Mail,Medico_Fecha_nac
 FROM gd_esquema.Maestra INNER JOIN SIGKILL.usuario 
 ON (usr_usuario=('u'+CONVERT(nvarchar,Medico_Dni))))
GO

INSERT INTO SIGKILL.agenda_profesional(agp_fecha_inicio,agp_fecha_fin,agp_profesional)
(SELECT GETDATE(),'2014-01-04',pro_id FROM SIGKILL.profesional)
GO

INSERT INTO SIGKILL.horario_agenda(hag_id_agenda,hag_horario_inicio,hag_horario_fin,hag_dia_semana)
(select agp_id,'7:00','17:30',2 from SIGKILL.agenda_profesional)
INSERT INTO SIGKILL.horario_agenda(hag_id_agenda,hag_horario_inicio,hag_horario_fin,hag_dia_semana)
(select agp_id,'7:00','17:30',3 from SIGKILL.agenda_profesional)
INSERT INTO SIGKILL.horario_agenda(hag_id_agenda,hag_horario_inicio,hag_horario_fin,hag_dia_semana)
(select agp_id,'7:00','17:30',4 from SIGKILL.agenda_profesional)
INSERT INTO SIGKILL.horario_agenda(hag_id_agenda,hag_horario_inicio,hag_horario_fin,hag_dia_semana)
(select agp_id,'7:00','17:30',5 from SIGKILL.agenda_profesional)
INSERT INTO SIGKILL.horario_agenda(hag_id_agenda,hag_horario_inicio,hag_horario_fin,hag_dia_semana)
(select agp_id,'7:00','17:30',6 from SIGKILL.agenda_profesional)
GO

INSERT INTO SIGKILL.turno(trn_id,trn_profesional,trn_afiliado,trn_fecha_hora)
(SELECT DISTINCT Turno_Numero,pro_id,afil_numero,Turno_Fecha
 FROM gd_esquema.Maestra,SIGKILL.afiliado,SIGKILL.profesional 
 WHERE Turno_Numero is not null AND afil_dni=Paciente_Dni AND pro_dni=Medico_Dni)
GO

UPDATE SIGKILL.turno 
SET trn_fecha_hora=DATEADD(day,5,trn_fecha_hora) 
WHERE DATEPART(dw, trn_fecha_hora) = 1 AND DATEDIFF(day,trn_fecha_hora,GETDATE()) < 0

INSERT INTO SIGKILL.bono_consulta(bonoc_id,bonoc_afiliado,bonoc_fecha_compra,bonoc_plan_medico,bonoc_precio)
(SELECT Bono_Consulta_Numero,afil_numero,GETDATE(),Plan_Med_Codigo,Plan_Med_Precio_Bono_Consulta 
FROM gd_esquema.Maestra,SIGKILL.afiliado 
WHERE afil_dni=Paciente_Dni AND Bono_Consulta_Numero is not null and  Consulta_Sintomas is null)

INSERT INTO SIGKILL.bono_farmacia(bonof_id,bonof_afiliado,bonof_fecha_compra,bonof_plan_medico,bonof_precio)
(SELECT Bono_Farmacia_Numero,afil_numero,GETDATE(),Plan_Med_Codigo,Plan_Med_Precio_Bono_Farmacia 
FROM gd_esquema.Maestra,SIGKILL.afiliado 
WHERE afil_dni=Paciente_Dni AND Bono_Farmacia_Numero is not null and  Consulta_Sintomas is null)

INSERT INTO SIGKILL.consulta(cons_turno,cons_bono_consulta,cons_fecha_hora_llegada,cons_fecha_hora_atencion,cons_sintomas,cons_diagnostico)
(SELECT Turno_Numero,Bono_Consulta_Numero,Turno_Fecha,Turno_Fecha,Consulta_Sintomas,Consulta_Enfermedades
FROM gd_esquema.Maestra 
WHERE Consulta_Sintomas is not null)

UPDATE SIGKILL.bono_consulta 
SET bonoc_consumido=1,bonoc_fecha_compra=Turno_Fecha
FROM SIGKILL.bono_consulta,gd_esquema.Maestra 
WHERE Consulta_Sintomas is not null AND bonoc_id=Bono_Consulta_Numero
	
UPDATE SIGKILL.bono_farmacia 
SET bonof_consumido=1,bonof_fecha_compra=Turno_Fecha
FROM SIGKILL.bono_farmacia,gd_esquema.Maestra 
WHERE Consulta_Sintomas is not null AND bonof_id=Bono_Farmacia_Numero

UPDATE SIGKILL.bono_consulta
SET bonoc_nro_consulta_individual=(SELECT COUNT(*) FROM SIGKILL.bono_consulta as bc2 WHERE bc2.bonoc_afiliado=bc1.bonoc_afiliado AND bc2.bonoc_fecha_compra<=bc1.bonoc_fecha_compra AND bc2.bonoc_consumido=1 )
from SIGKILL.bono_consulta as bc1
WHERE bc1.bonoc_consumido=1

INSERT INTO SIGKILL.tipo_especialidad(tesp_id,tesp_tipo_nombre)
(SELECT DISTINCT Tipo_Especialidad_Codigo,Tipo_Especialidad_Descripcion 
 FROM gd_esquema.Maestra 
 WHERE Tipo_Especialidad_Codigo is not null)
GO
 
 INSERT INTO SIGKILL.especialidad(esp_id,esp_nombre_especialidad,esp_tipo)
 (SELECT DISTINCT Especialidad_Codigo,Especialidad_Descripcion,Tipo_Especialidad_Codigo 
  FROM gd_esquema.Maestra 
  WHERE Especialidad_Codigo is not null)
go

INSERT INTO SIGKILL.esp_prof(espprof_especialidad,espprof_profesional)
(SELECT DISTINCT Especialidad_Codigo,pro_id FROM gd_esquema.Maestra,SIGKILL.profesional WHERE Medico_Dni=pro_dni)

INSERT INTO SIGKILL.medicamento (medic_nombre)
(SELECT DISTINCT Bono_Farmacia_Medicamento from gd_esquema.Maestra WHERE Bono_Farmacia_Medicamento is not null )
GO

INSERT INTO SIGKILL.medicamento_bono_farmacia(recmed_bono_farmacia,recmed_medicamento)
(SELECT Bono_Farmacia_Numero,medic_id from gd_esquema.Maestra,SIGKILL.medicamento WHERE Consulta_Sintomas is not null AND Bono_Farmacia_Medicamento=medic_nombre )
GO

/***** FUNCIONES ****/
create function SIGKILL.getNextNumeroAfiliado
(
)
returns int
as
begin
	DECLARE @numero int
	SELECT @numero=COUNT(DISTINCT ROUND(afil_numero/100,0)) FROM SIGKILL.afiliado
	RETURN @numero+1
end
go

create function SIGKILL.getMedicamentoId
(
    @med nvarchar(200)
)
returns int
as
begin
	DECLARE @numero int
	SELECT @numero=medic_id FROM SIGKILL.medicamento WHERE medic_nombre=@med
	RETURN @numero
end
go
 
create function SIGKILL.SplitString 
(
    @str nvarchar(max), 
    @separator char(1)
)
returns table
AS
return (
with tokens(p, a, b) AS (
    select 
        cast(1 as bigint), 
        cast(1 as bigint), 
        charindex(@separator, @str)
    union all
    select
        p + 1, 
        b + 1, 
        charindex(@separator, @str, b + 1)
    from tokens
    where b > 0
)
select
    p-1 ItemIndex,
    substring(
        @str, 
        a, 
        case when b > 0 then b-a ELSE LEN(@str) end) 
    AS Item
from tokens
);

GO

/****CURSORES****/
--declare @med_string nvarchar(300)
--declare c1 cursor for (SELECT DISTINCT Bono_Farmacia_Medicamento from gd_esquema.Maestra WHERE Bono_Farmacia_Medicamento is not null )
--open c1
--fetch c1 into @med_string
--while @@FETCH_STATUS = 0
--begin
--	INSERT INTO SIGKILL.medicamento (medic_nombre)
--	(select Item from SIGKILL.SplitString(@med_string, '+'))
--	fetch c1 into @med_string
--end

--close c1
--deallocate c1
--GO

--declare @med_string nvarchar(300)
--declare @bono_num bigint
--create table #Cursor (
--bononum bigint NOT NULL,
--medname varchar(255)
--)
--declare c1 cursor for (SELECT Bono_Farmacia_Medicamento,Bono_Farmacia_Numero from gd_esquema.Maestra WHERE Consulta_Sintomas is not null )--WHERE Bono_Farmacia_Medicamento is not null )
--open c1
--fetch c1 into @med_string,@bono_num
--while @@FETCH_STATUS = 0
--begin
--	--UPDATE SIGKILL.bono_consulta SET bonoc_consumido=1,bonoc_fecha_compra=@fecha WHERE bonoc_id=@bonoc_num
--	--UPDATE SIGKILL.bono_farmacia SET bonof_consumido=1,bonof_fecha_compra=@fecha WHERE bonof_id=@bono_num 
--	--INSERT INTO SIGKILL.medicamento_bono_farmacia(recmed_bono_farmacia,recmed_medicamento)
--	INSERT INTO #Cursor(bononum,medname)
--	(select @bono_num,SIGKILL.getMedicamentoId(Item) from SIGKILL.SplitString(@med_string, '+'))
--	fetch c1 into @med_string,@bono_num
--end
--INSERT INTO SIGKILL.medicamento_bono_farmacia(recmed_bono_farmacia,recmed_medicamento)
--(SELECT * FROM #Cursor)
--close c1
--deallocate c1
--drop table #Cursor
--GO



