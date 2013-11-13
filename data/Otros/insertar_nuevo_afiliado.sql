create procedure nuevoAfiliado(@afil_nombre nvarchar(200), @afil_apellido nvarchar(100),
							  @afil_tipo_doc bigint, @afil_nrodoc numeric(18, 0),
							  @afil_direccion nvarchar(255), @afil_telefono decimal(18,0), @afil_mail nvarchar(255),
							  @afil_nacimiento nvarchar(100), @afil_sexo nvarchar(1), @afil_estadocivil varchar(20),
							  @afil_plan_medico varchar(20), @miembro_familia bigint)
as

Begin
	
	declare @afil_usuario bigint
	declare @afil_numero bigint
	declare @nombre_usuario_mapeado nvarchar(19)
	declare @afil_estadocivil_id bigint
	declare @afil_plan_medico_id bigint
	
	IF @miembro_familia = 1
	Begin
		set @afil_numero = SIGKILL.getNextNumeroAfiliado()*100+1
	End
	--ELSE
	--Begin
	--	SELECT usr_id FROM GD2C2013.SIGKILL.usuario WHERE usr_usuario = @nombre_usuario_mapeado
	--End
	
	SELECT @afil_estadocivil_id = estciv_id from GD2C2013.SIGKILL.estado_civil where estciv_descripcion = @afil_estadocivil
	
	set @nombre_usuario_mapeado = 'u' + CONVERT(nvarchar(18),@afil_nrodoc)
	
	IF (select COUNT(*) from GD2C2013.SIGKILL.usuario where usr_usuario = @nombre_usuario_mapeado) < 1
		Begin
			INSERT INTO GD2C2013.SIGKILL.usuario (usr_usuario, usr_password)
			VALUES (@nombre_usuario_mapeado, '37a8eec1ce19687d132fe29051dca629d164e2c4958ba141d5f4133a33f0688f')
		End
		

	SELECT @afil_usuario = usr_id FROM GD2C2013.SIGKILL.usuario WHERE usr_usuario = @nombre_usuario_mapeado
	
	SELECT @afil_plan_medico_id = pmed_id FROM GD2C2013.SIGKILL.plan_medico WHERE pmed_nombre = @afil_plan_medico

	INSERT INTO GD2C2013.SIGKILL.afiliado
	(afil_numero,afil_usuario, afil_nombre,	afil_apellido, afil_tipo_doc, afil_dni,	afil_direccion, afil_telefono, afil_mail, afil_nacimiento, afil_sexo, afil_estado_civil,afil_id_plan_medico)
	VALUES (@afil_numero,@afil_usuario, @afil_nombre, @afil_apellido, @afil_tipo_doc ,@afil_nrodoc, @afil_direccion, @afil_telefono,
	@afil_mail, @afil_nacimiento, @afil_sexo, @afil_estadocivil_id, @afil_plan_medico_id)
END