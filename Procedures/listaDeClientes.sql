CREATE PROCEDURE listaDeCliente
		@Nombre nvarchar(255),
		@Apellido nvarchar(255),
		@Dni nvarchar(50),
		@Mail nvarchar(255),
		@Tipo_dni nvarchar(2)
	AS
	BEGIN
		SELECT * FROM Clientes
			WHERE
				Nombre like '%'+@Nombre+'%'
				AND Apellido like '%'+@Apellido+'%'
				AND Dni like '%'+@Dni+'%'
				AND Mail like '%'+@Mail+'%'
				AND Tipo_dni like '%'+@Tipo_dni+'%'
	END