CREATE PROCEDURE listadoMayoresFacturacion
	@Año smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
		SELECT TOP 5 U.Usuario AS 'Usuario', SUM(Total) as 'Cantidad sin calificar'
		
    FROM Publicacion P 
	JOIN Factura F ON
    P.Codigo = F.Pub_Cod
    JOIN Usuario U ON
    (P.Id = U.Id_Usuario AND U.Id_Rol = P.Publicador)
	
    WHERE YEAR(F.Fecha) = @Año AND (MONTH(F.Fecha) = 1 + 3*(@Trimestre-1) OR MONTH(F.Fecha) = 2 + 3*(@Trimestre-1) OR MONTH(F.Fecha) = 3 + 3*(@Trimestre-1))

    GROUP BY U.Usuario
  
    END