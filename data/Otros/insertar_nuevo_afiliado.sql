Begin
	declare @afil_usuario nvarchar(255)
	declare @afil_numero bigint
	declare @afil_nombre nvarchar(200)
	declare @afil_apellido nvarchar(100)
	declare @afil_dni numeric(18, 0)
	declare @afil_direccion nvarchar(255)
	declare @afil_telefono nvarchar(25)
	declare @afil_mail nvarchar(255)
	declare @afil_nacimiento datetime
	declare @afil_sexo nvarchar(1)
	declare @afil_estadocivil bigint
	declare @afil_id_plan_medico bigint
	
	set @afil_dni = 36050855
	set @afil_numero = SIGKILL.getNextNumeroAfiliado()*100+1
	set @afil_nombre = 'LUCAS'
	set @afil_apellido = 'Wolf'
	set @afil_direccion = 'CalleFalsa 1234'
	set @afil_telefono = '46382097'
	set @afil_mail = 'luksdlt92@gmail.com'
	set @afil_nacimiento = '10/10/92'
	set @afil_sexo = 'M'
	select @afil_estadocivil = estciv_id from GD2C2013.SIGKILL.estado_civil where estciv_descripcion = 'Soltero/a'
	set @afil_id_plan_medico = 555558
	
	IF (select COUNT(*) from GD2C2013.SIGKILL.usuario where usr_usuario = 'u'+'36050855') < 1
		Begin
			INSERT INTO GD2C2013.SIGKILL.usuario (usr_usuario, usr_password)
			VALUES ('u'+'36050855', '37a8eec1ce19687d132fe29051dca629d164e2c4958ba141d5f4133a33f0688f')
		End
		
	SELECT @afil_usuario = usr_id FROM GD2C2013.SIGKILL.usuario WHERE usr_usuario = 'u' + '37040585'

	INSERT into GD2C2013.SIGKILL.afiliado (afil_numero, afil_usuario, afil_nombre, afil_apellido, afil_dni,
	afil_direccion, afil_telefono, afil_mail, afil_nacimiento, afil_sexo, afil_estado_civil,
	afil_id_plan_medico)
	values (@afil_numero,@afil_usuario, @afil_nombre, @afil_apellido, @afil_dni, @afil_direccion, @afil_telefono,
	@afil_mail, @afil_nacimiento, @afil_sexo, @afil_estadocivil, @afil_id_plan_medico)
End