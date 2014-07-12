CREATE PROCEDURE listadoVendedoresQueVendenMenos
@Año smallint,
@Visibilidad numeric(18,0),
@Mes int
AS
BEGIN
IF(@Visibilidad <> 0)
BEGIN
SELECT TOP 5 u.Usuario, SUM(Stock) as 'Stock Total', v.Descripcion as 'Visibilidad' from publicacion P
INNER JOIN Usuario U ON p.Usuario = U.Id_Usuario
INNER JOIN Visibilidad V on v.Codigo = p.Visibilidad_Cod
WHERE p.Estado <> 4 AND p.Estado <> 2
AND p.Visibilidad_Cod = @Visibilidad
AND YEAR(p.Fecha) = @Año 
AND MONTH(p.Fecha) = @Mes
AND U.Baja <> 0
AND U.Estado <> 0
group by u.Usuario, v.Descripcion
order by [Stock Total] DESC
END

ELSE 
SELECT TOP 5 u.Usuario, SUM(Stock) as 'Stock Total', v.Descripcion as 'Visibilidad' from publicacion P
INNER JOIN Usuario U ON p.Usuario = U.Id_Usuario
INNER JOIN Visibilidad V on v.Codigo = p.Visibilidad_Cod
WHERE p.Estado <> 4 AND p.Estado <> 2
AND YEAR(p.Fecha) = @Año 
AND MONTH(p.Fecha) = @Mes
AND U.Baja <> 0
AND U.Estado <> 0
group by u.Usuario, v.Descripcion
order by [Stock Total] DESC, v.Descripcion
END
