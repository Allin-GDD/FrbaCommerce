CREATE PROCEDURE actualizarEmpresa
@Id numeric(18,0),
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
UPDATE Empresa 
SET Razon_Social = @RazonSocial, Tipo = @Tipo_doc, Nombre_Contacto = @Nombre_Contacto, Ciudad = @Ciudad, Piso = @Piso, 
Localidad = @Localidad, Cod_Postal = @Cod_Postal, Depto = @Depto, Nro_Calle = @Nro_Calle, Dom_Calle = @Dom_Calle, 
Mail = @Mail, Fecha_Creacion = @Fecha_Creacion, Cuit = @Cuit
WHERE Id = @Id
END