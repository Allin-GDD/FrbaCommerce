CREATE PROCEDURE agregarNuevaEmpresaUsuario
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
		@Tipo_doc smallint,
		@IdUsuario numeric(18,0)
AS
BEGIN

IF(@IdUsuario = 0)
BEGIN
EXEC darDeAltaUsuario @Mail, @Cuit, 1 , 10, 0, 0

SELECT Id_Usuario = @IdUsuario FROM Usuario WHERE 
Usuario = @Mail AND Password = @Cuit

EXEC agregarNuevaEmpresa @RazonSocial ,@Cuit,@Fecha_Creacion ,@Mail ,@Dom_Calle,@Nro_Calle,@Piso,@Depto,@Cod_Postal ,@Localidad,	
		@Telefono,@Ciudad,@Nombre_Contacto,	@Tipo_doc,@IdUsuario
		
END
else
EXEC agregarNuevaEmpresa @RazonSocial ,@Cuit,@Fecha_Creacion ,@Mail ,@Dom_Calle,@Nro_Calle,@Piso,@Depto,@Cod_Postal ,@Localidad,	
		@Telefono,@Ciudad,@Nombre_Contacto,	@Tipo_doc,@IdUsuario
END