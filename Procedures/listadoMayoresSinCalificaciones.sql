CREATE PROCEDURE listadoMayoresSinCalificaciones
	@Año smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
		SELECT TOP 5 U.Usuario AS 'Usuario', COUNT(Calificacion_Cant_Estrellas) as 'Cantidad sin calificar'
	FROM (Compra C 
	INNER JOIN Usuario U ON (c.Id_Cliente = u.Id_Usuario AND U.Id_Rol = 1))
	WHERE YEAR(C.Fecha) = @Año AND
	 (MONTH(C.Fecha) = 1 + 3*(@Trimestre-1)OR 
	 MONTH(C.Fecha) = 2 + 3*(@Trimestre-1) OR
	  MONTH(C.Fecha) = 3 + 3*(@Trimestre-1)) AND 
	  Calificacion_Cant_Estrellas IS NULL
    GROUP BY U.Usuario
    ORDER BY [Cantidad sin calificar] DESC
  
    END