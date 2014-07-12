create PROCEDURE listaDeMisPublicaciones
		@Descripcion nvarchar(255),
		@Estado nvarchar(255),
		@Tipo nvarchar(255),
		@Visibilidad nvarchar(30),
		
		@Rubro nvarchar(30),
		@Id nvarchar(30)
	AS
	BEGIN
		SELECT P.Codigo, p.Descripcion, p.Stock, p.Fecha, p.Fecha_Venc, p.Precio, tp.Nombre as 'Tipo' , v.Descripcion AS 'Visibilidad', p.Visibilidad_Cod, e.Nombre 'Estado', r.Descripcion as 'Rubro', p.Preguntas_permitidas,p.Usuario,Usuario.Tipo_Usuario FROM Publicacion as P
	join Publicacion_Rubro pr on pr.id_Publicacion = p.Codigo
	JOIN Rubro r ON r.Codigo = pr.id_Rubro
	JOIN Visibilidad V ON p.Visibilidad_Cod = v.Codigo
	join Estado e on e.Cod_Estado=p.Estado
	join Tipo_Publicacion tp on tp.Cod_Tipo = p.Tipo
	join Usuario on Usuario.Id_Usuario = p.Usuario
			WHERE
				p.Descripcion like '%'+@Descripcion+'%'
				AND (R.Codigo = @Rubro or @Rubro=0)
				AND TP.Nombre like '%'+@Tipo+'%'
				AND p.Visibilidad_Cod like '%'+@Visibilidad+'%'
				and p.stock > 0
 				and E.Nombre like '%'+@Estado+'%'
				and (p.Usuario = @Id )
				
			order by Visibilidad_Cod
	END