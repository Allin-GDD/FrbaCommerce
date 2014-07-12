create PROCEDURE historialCompras
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
		SELECT C.Fecha, P.Descripcion, C.Cantidad, U.Usuario AS 'Vendedor'
		
    FROM Publicacion P
	JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN Usuario U ON
    P.Usuario = U.Id_Usuario
	
    WHERE C.Id_Cliente = @Id
    order by C.Fecha
  
    END