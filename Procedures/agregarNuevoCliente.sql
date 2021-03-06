CREATE PROCEDURE agregarNuevoCliente
		@Dni nvarchar(64),
		@Nombre nvarchar(255),
		@Apellido nvarchar(255),
		@Fecha_Nac Datetime,
		@Mail nvarchar(255),
		@Dom_Calle nvarchar(255),
		@Nro_Calle numeric(18,0),
		@Piso numeric(18,0),
		@Depto nvarchar(50),
		@Cod_Postal nvarchar(50),
		@Localidad nvarchar(255),
		@Tipo_dni smallint,
		@Telefono nvarchar(255),
		
		@IdUsuario numeric(18,0)
		AS
		BEGIN
	INSERT INTO Clientes(
	Id_Usuario,	Nro_Documento,Nombre,Apellido,Fecha_Nac,Mail,Dom_Calle,Nro_Calle,Piso,Depto,
	Cod_Postal,	Localidad,Tipo_Doc,	Telefono)
	VALUES(@IdUsuario, @Dni, @Nombre,@Apellido,@Fecha_Nac,@Mail,@Dom_Calle,@Nro_Calle,@Piso,
	@Depto,	@Cod_Postal,@Localidad,	@Tipo_dni,@Telefono )	
	END