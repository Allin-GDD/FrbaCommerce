CREATE PROCEDURE listadoVendedoresQueVendenMenos
@Año smallint,
@Visibilidad numeric(18,0),
@Mes int
AS
BEGIN

SELECT TOP 5 u.Usuario ,SUM(Stock) as 'Stock Total' from (publicacion P
INNER JOIN Usuario U ON ((p.Id = u.Id_Usuario) AND (P.Publicador = (CASE WHEN U.Id_Rol = 1 THEN 
        'C'
    WHEN U.Id_Rol = 2 THEN
        'E'
    END))
    ) 
    )
WHERE p.Estado <> 'Finalizado' AND p.Estado <> 'Borrador'
AND p.Visibilidad_Cod = @Visibilidad AND 
YEAR(p.Fecha) = @Año AND
MONTH(p.Fecha) = @Mes
group by u.Usuario
order by [Stock Total] DESC
END