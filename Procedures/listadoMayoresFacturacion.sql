CREATE PROCEDURE listadoMayoresFacturacion
	@A�o smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
		SELECT TOP 5 U.Usuario AS 'Usuario', SUM(Total) as 'Facturaci�n'
		
    FROM Publicacion P 
	INNER JOIN Factura F ON P.Codigo = F.Pub_Cod
     INNER JOIN Usuario U ON p.Usuario = u.Id_Usuario
    WHERE YEAR(F.Fecha) = @A�o AND (MONTH(F.Fecha) = 1 + 3*(@Trimestre-1) OR MONTH(F.Fecha) = 2 + 3*(@Trimestre-1) OR MONTH(F.Fecha) = 3 + 3*(@Trimestre-1))
		AND U.Baja <> 0
		AND U.Estado <> 0
    GROUP BY U.Id_Usuario, u.Usuario
    ORDER BY Facturaci�n DESC
  
    END
    
