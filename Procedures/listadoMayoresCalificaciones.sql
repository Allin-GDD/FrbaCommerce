CREATE PROCEDURE listadoMayoresCalificaciones
	@A�o smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
	SELECT TOP 5 U.Usuario AS 'Usuario', AVG(Ca.Cant_Estrellas) as 'Promedio calificaci�n'
	FROM  Compra C 
		INNER JOIN Usuario U ON C.Id_Cliente = u.Id_Usuario
		INNER JOIN Calificacion Ca ON C.Calificacion_Codigo = Ca.Cod_Calificacion
	WHERE YEAR(C.Fecha) = @A�o 
		AND(MONTH(C.Fecha) = 1 + 3*(@Trimestre-1) 
		OR MONTH(C.Fecha) = 2 + 3*(@Trimestre-1) 
		OR MONTH(C.Fecha) = 3 + 3*(@Trimestre-1))
		AND Ca.Cant_Estrellas IS NOT NULL
		AND U.Baja <> 0
		AND U.Estado <> 0

GROUP BY u.Usuario  
ORDER BY [Promedio calificaci�n] DESC
    END