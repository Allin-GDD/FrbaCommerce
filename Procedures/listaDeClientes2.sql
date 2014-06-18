CREATE PROCEDURE listaDeCliente2
		@Nombre nvarchar(255),
		@Apellido nvarchar(255),
		@Dni nvarchar(50),
		@Mail nvarchar(255)
	AS
	BEGIN
		SELECT * FROM Clientes
			WHERE
				Nombre like '%'+@Nombre+'%'
				AND Apellido like '%'+@Apellido+'%'
				AND Dni like '%'+@Dni+'%'
				AND Dni <> 0
				AND Mail like '%'+@Mail+'%'
				
	END
