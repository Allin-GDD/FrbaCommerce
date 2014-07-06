CREATE PROCEDURE listaDeCliente
		@Nombre nvarchar(255),
		@Apellido nvarchar(255),
		@Dni nvarchar(50),
		@Mail nvarchar(255),
		@Tipo_dni nvarchar(1)
	AS
	BEGIN
		SELECT c.Id_Usuario, c.Nombre, c.Apellido, td.Nombre as 'Tipo de documento', c.Nro_Documento as 'Nro documento', c.Fecha_Nac as 'Fecha de Nacimiento', c.Mail, c.Dom_Calle as 'Domicilio',
		c.Nro_Calle as 'Nro domicilio', c.Piso, c.Depto, c.Localidad, c.Telefono FROM Clientes c 
		INNER JOIN Tipo_Doc TD ON c.Tipo_Doc = TD.Codigo
			WHERE
				c.Nombre like '%'+@Nombre+'%'
				AND Apellido like '%'+@Apellido+'%'
				AND Nro_Documento like '%'+@Dni+'%'
				AND Nro_Documento <> 0
				AND Mail like '%'+@Mail+'%'
				AND ((c.Tipo_Doc = @Tipo_dni AND @Tipo_dni <>0) OR @Tipo_dni = 0)
				
	END
