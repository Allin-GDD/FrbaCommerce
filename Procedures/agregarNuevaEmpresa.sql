CREATE PROCEDURE agregarNuevaEmpresa
		@RazonSocial nvarchar(255),
		@Cuit nvarchar(255),
		@Fecha_Creacion Datetime,
		@Mail nvarchar(255),
		@Dom_Calle nvarchar(255),
		@Nro_Calle numeric(18,0),
		@Piso numeric(18,0),
		@Depto nvarchar(50),
		@Cod_Postal nvarchar(50),
		@Localidad nvarchar(255),	
		@Telefono nvarchar(255),
		@Ciudad nvarchar(255),
		@Nombre_Contacto nvarchar(255),
		@Tipo_doc smallint

AS
BEGIN
	INSERT INTO Empresa(
	Razon_Social,
	Cuit,
	Fecha_Creacion,
	Mail,
	Dom_Calle,
	Nro_Calle,
	Piso,
	Depto,
	Cod_Postal,
	Localidad,
	Telefono,
	Ciudad,
	Nombre_Contacto,
	Tipo)
	VALUES(
		@RazonSocial ,
		@Cuit,
		@Fecha_Creacion ,
		@Mail ,
		@Dom_Calle,
		@Nro_Calle,
		@Piso,
		@Depto,
		@Cod_Postal ,
		@Localidad,	
		@Telefono,
		@Ciudad,
		@Nombre_Contacto,
		@Tipo_doc
	)	

END