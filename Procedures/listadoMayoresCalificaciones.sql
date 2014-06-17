CREATE PROCEDURE listadoMayoresCalificaciones
	@Año smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
		SELECT TOP 5 U.Usuario AS 'Usuario', AVG(C.Calificacion_Cant_Estrellas) as 'Promedio calificacion'
		
    FROM (Publicacion P 
	INNER JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
   INNER JOIN Usuario U ON ((p.Id = u.Id_Usuario) AND (P.Publicador = (CASE WHEN U.Id_Rol = 1 THEN 
        'C'
    WHEN U.Id_Rol = 2 THEN
        'E'
    END))))
 WHERE YEAR(C.Fecha) = @Año 
 AND(MONTH(C.Fecha) = 1 + 3*(@Trimestre-1) 
 OR MONTH(C.Fecha) = 2 + 3*(@Trimestre-1) 
 OR MONTH(C.Fecha) = 3 + 3*(@Trimestre-1))
 AND C.Calificacion_Cant_Estrellas IS NOT NULL

GROUP BY u.Usuario  
ORDER BY [Promedio calificacion] DESC
    END
