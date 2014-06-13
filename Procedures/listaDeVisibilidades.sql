CREATE PROCEDURE listaDeVisibilidades
		@Codigo numeric(18,0),
		@Descripcion nvarchar(255),
		@Precio numeric(18,2),
		@Porcentaje numeric(18,2)
		
	AS
	BEGIN
		SELECT * FROM Visibilidad
			WHERE
				(@Codigo = [codigo] or @Codigo = '')
				AND Descripcion like '%'+@Descripcion+'%'
				AND Precio like '%'+@Precio+'%'
				AND Porcentaje like '%'+@Porcentaje+'%'
				AND Estado = 1
				
	END