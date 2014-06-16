CREATE PROCEDURE listaDeMisPublicaciones
		@Descripcion nvarchar(255),
		@Estado nvarchar(255),
		@Tipo nvarchar(255),
		@Visibilidad nvarchar(30),
		@Rol nvarchar(10),
		@Rubro nvarchar(30),
		@Id nvarchar(30)
	AS
	BEGIN
		SELECT * FROM Publicacion
			WHERE
				Descripcion like '%'+@Descripcion+'%'
				AND Rubro_Cod like '%'+@Rubro+'%'
				AND Tipo like '%'+@Tipo+'%'
				AND Visibilidad_Cod like '%'+@Visibilidad+'%'
				and stock > 0
				and Estado like '%'+@Estado+'%'
				and (Id = @Id and Publicador = @Rol)
				
			order by Visibilidad_Cod
	END