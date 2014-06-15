CREATE PROCEDURE listaDePublicaciones
		@Descripcion nvarchar(255),
		@Rubro nvarchar(30)
	AS
	BEGIN
		SELECT * FROM Publicacion
			WHERE
				Descripcion like '%'+@Descripcion+'%'
				AND  (@Rubro = [Rubro_Cod] or @Rubro = '')
				and stock > 0
				and Estado = 'publicada'
				
			order by Visibilidad_Cod
	END