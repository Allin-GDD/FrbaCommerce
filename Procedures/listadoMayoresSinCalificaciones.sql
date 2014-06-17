CREATE PROCEDURE listadoMayoresSinCalificaciones
	@Año smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
		SELECT TOP 5 U.Usuario AS 'Usuario', COUNT(Calificacion_Cant_Estrellas) as 'Cantidad sin calificar'
		
    FROM Publicacion P 
	JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN Usuario U ON
    (P.Id = U.Id_Usuario AND U.Id_Rol = P.Publicador)
	
    WHERE YEAR(C.Fecha) = @Año AND (MONTH(C.Fecha) = 1 + 3*(@Trimestre-1) OR MONTH(C.Fecha) = 2 + 3*(@Trimestre-1) OR MONTH(C.Fecha) = 3 + 3*(@Trimestre-1)) AND Calificacion_Cant_Estrellas = NULL

    GROUP BY U.Usuario
  
    END