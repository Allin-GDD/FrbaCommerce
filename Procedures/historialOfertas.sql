create PROCEDURE historialOfertas
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
	SELECT O.Fecha, P.Descripcion, O.Monto, U.Usuario AS 'Vendedor', (CASE WHEN C.Id_Cliente = O.Id_Cliente AND C.Codigo_Pub = O.Codigo_Pub THEN 'Ganó subasta' WHEN O.Con_ganador = 0 THEN 'No finalizada' ELSE 'No ganó' END) AS 'Resultado'
		
    FROM Publicacion P 
	JOIN Oferta O ON
    P.Codigo = O.Codigo_Pub
    JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN Usuario U ON
    P.Usuario = U.Id_Usuario
	
    WHERE O.Id_Cliente= @Id
    order by O.Fecha
  
    END