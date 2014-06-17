CREATE PROCEDURE historialOfertas
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
	SELECT O.Fecha, P.Descripcion, O.Monto, U.Usuario AS 'Vendedor', (CASE WHEN C.Id_Cliente = O.Id AND C.Codigo_Pub = O.Codigo_Pub THEN 'Ganó subasta' WHEN O.Con_ganador = 0 THEN 'No finalizada' ELSE 'No ganó' END) AS 'Resultado'
		
    FROM Publicacion P 
	JOIN Oferta O ON
    P.Codigo = O.Codigo_Pub
    JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN Usuario U ON
    P.Publicador = (CASE WHEN U.Id_Rol = 1 THEN 
        'C'
    WHEN U.Id_Rol = 2 THEN
        'E'
    END) AND P.Id = U.Id_Usuario
	
    WHERE O.Id = @Id
    order by O.Fecha
  
    END