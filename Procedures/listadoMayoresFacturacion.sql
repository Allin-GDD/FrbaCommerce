CREATE PROCEDURE listadoMayoresFacturacion
	@Año smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
		SELECT TOP 5 U.Usuario AS 'Usuario', SUM(Total) as 'Facturación'
		
    FROM (Publicacion P 
	INNER JOIN Factura F ON
    P.Codigo = F.Pub_Cod
     INNER JOIN Usuario U ON ((p.Id = u.Id_Usuario) AND (P.Publicador = (CASE WHEN U.Id_Rol = 1 THEN 
        'C'
    WHEN U.Id_Rol = 2 THEN
        'E'
    END))))
	
    WHERE YEAR(F.Fecha) = @Año AND (MONTH(F.Fecha) = 1 + 3*(@Trimestre-1) OR MONTH(F.Fecha) = 2 + 3*(@Trimestre-1) OR MONTH(F.Fecha) = 3 + 3*(@Trimestre-1))

    GROUP BY U.Usuario
    ORDER BY Facturación DESC
  
    END