CREATE PROCEDURE actualizarCliente
		@Id numeric(18,0),
		@Dni nvarchar(255),
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
UPDATE Clientes
SET Apellido = @Apellido, Nombre = @Nombre , Nro_Documento = @Dni, Fecha_Nac = @Fecha_Nac, Mail = @Mail, Dom_Calle = @Dom_Calle,
Nro_Calle = @Nro_Calle, Piso = @Piso, Depto = @Piso, Cod_Postal = @Cod_Postal, Localidad = @Localidad,
Tipo_Doc = @Tipo_dni, Telefono = @Telefono
WHERE Id_Usuario = @Id
End