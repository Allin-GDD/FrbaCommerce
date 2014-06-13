CREATE PROCEDURE listaDeVisibilidades
		@Codigo nvarchar(18),
		@Descripcion nvarchar(255),
		@Precio nvarchar(18),
		@Porcentaje nvarchar(18)
		
	AS
	BEGIN
		SELECT Codigo, Descripcion,Precio, Porcentaje,Vencimiento FROM Visibilidad
			WHERE
				Codigo like '%'+@Codigo+'%'
				AND Descripcion like '%'+@Descripcion+'%'
				AND	Precio like '%'+@Precio+'%'
				AND Porcentaje like '%'+@Porcentaje+'%'
				AND Estado = 1
				
	END