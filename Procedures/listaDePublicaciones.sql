CREATE PROCEDURE listaDePublicaciones
		@Descipcion nvarchar(255),
		@Rubro nvarchar(255)
	AS
	BEGIN
		SELECT * FROM Publicacion
			WHERE
				Descripcion like '%'+@Descipcion+'%'
				AND Rubro_Cod like '%'+@Rubro+'%'
				and stock > 0
				and Estado = 'publicada'
				
			order by Visibilidad_Cod
	END