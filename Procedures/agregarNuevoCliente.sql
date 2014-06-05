CREATE PROCEDURE agregarNuevoCliente
		@Dni numeric(18,0),
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
		@Telefono nvarchar(255)

AS
BEGIN
	INSERT INTO Clientes(
	Dni,
	Nombre,
	Apellido,
	Fecha_Nac,
	Mail,
	Dom_Calle,
	Nro_Calle,
	Piso,
	Depto,
	Cod_Postal,
	Localidad,
	Tipo_dni,
	Telefono)
	VALUES(
	@Dni,
	@Nombre,
	@Apellido,
	@Fecha_Nac,
	@Mail,
	@Dom_Calle,
	@Nro_Calle,
	@Piso,
	@Depto,
	@Cod_Postal,
	@Localidad,
	@Tipo_dni,
	@Telefono 
	)	

END