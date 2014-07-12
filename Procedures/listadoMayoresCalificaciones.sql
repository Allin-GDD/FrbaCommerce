CREATE PROCEDURE listadoMayoresCalificaciones
	@Año smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
	SELECT TOP 5 U.Usuario AS 'Usuario', AVG(Ca.Cant_Estrellas) as 'Promedio calificación'
	FROM  Compra C 
		INNER JOIN Usuario U ON C.Id_Cliente = u.Id_Usuario
		INNER JOIN Calificacion Ca ON C.Calificacion_Codigo = Ca.Cod_Calificacion
	WHERE YEAR(C.Fecha) = @Año 
		AND(MONTH(C.Fecha) = 1 + 3*(@Trimestre-1) 
		OR MONTH(C.Fecha) = 2 + 3*(@Trimestre-1) 
		OR MONTH(C.Fecha) = 3 + 3*(@Trimestre-1))
		AND Ca.Cant_Estrellas IS NOT NULL
		AND U.Baja <> 0
		AND U.Estado <> 0

GROUP BY u.Usuario  
ORDER BY [Promedio calificación] DESC
    END