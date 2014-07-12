CREATE PROCEDURE listadoMayoresSinCalificaciones
	@Año smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
		SELECT TOP 5 U.Usuario AS 'Usuario', COUNT(CA.Cant_Estrellas) as 'Cantidad sin calificar'
	FROM Compra C 
	INNER JOIN Usuario U ON c.Id_Cliente = u.Id_Usuario
	INNER JOIN Calificacion CA ON CA.Cod_Calificacion = C.Calificacion_Codigo
	WHERE YEAR(C.Fecha) = @Año AND
	 (MONTH(C.Fecha) = 1 + 3*(@Trimestre-1)OR 
	 MONTH(C.Fecha) = 2 + 3*(@Trimestre-1) OR
	  MONTH(C.Fecha) = 3 + 3*(@Trimestre-1)) AND 
	  CA.Cant_Estrellas IS NULL
	  AND U.Baja <> 0
		AND U.Estado <> 0
    GROUP BY U.Usuario
    ORDER BY [Cantidad sin calificar] DESC
  
    END