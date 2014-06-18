CREATE PROCEDURE listaDePublicaciones
		@Descripcion nvarchar(255),
		@Estado nvarchar(255),
		@Tipo nvarchar(255),
		@Visibilidad nvarchar(30),
		@Rol nvarchar(10),
		@Rubro nvarchar(30),
		@Id nvarchar(30)
	AS
	BEGIN
		SELECT P.Codigo, p.Descripcion, p.Stock, p.Fecha, p.Fecha_Venc, p.Precio, p.Tipo, v.Descripcion AS 'Visibilidad', p.Estado, r.Descripcion as 'Rubro', p.Publicador, p.Preguntas_permitidas,p.Id FROM Publicacion as P
	JOIN Rubro r ON r.Codigo = p.Rubro_Cod
	JOIN Visibilidad V ON p.Visibilidad_Cod = v.Codigo
			WHERE
				p.Descripcion like '%'+@Descripcion+'%'
				AND p.Rubro_Cod like '%'+@Rubro+'%'
				AND p.Tipo like '%'+@Tipo+'%'
				AND p.Visibilidad_Cod like '%'+@Visibilidad+'%'
				and p.stock > 0
 				and p.Estado like '%'+@Estado+'%'
 				and (p.Id <> @Id and p.Publicador <> @Rol)
				
			order by Visibilidad_Cod

	END

select * from Visibilidad