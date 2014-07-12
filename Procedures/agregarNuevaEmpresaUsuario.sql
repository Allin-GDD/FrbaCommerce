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
		@IdUsuario numeric(18,0)
AS
BEGIN
IF(@IdUsuario = 0)
BEGIN
EXEC darDeAltaUsuario @Mail, @Cuit, 2 , 10, 0
SET @IdUsuario = (SELECT Id_Usuario FROM Usuario WHERE 
Usuario = @Mail AND Password = @Cuit)
END

EXEC agregarNuevaEmpresa @RazonSocial ,@Cuit,@Fecha_Creacion ,@Mail ,@Dom_Calle,@Nro_Calle,@Piso,@Depto,@Cod_Postal ,@Localidad,	
		@Telefono,@Ciudad,@Nombre_Contacto,@IdUsuario
END