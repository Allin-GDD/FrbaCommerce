CREATE PROCEDURE historialOfertas
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
		SELECT O.Fecha, P.Descripcion, O.Monto, U.Usuario AS 'Vendedor'
		
    FROM Publicacion P 
	JOIN Oferta O ON
    P.Codigo = O.Codigo_Pub
    JOIN Usuario U ON
    P.Publicador = (CASE WHEN U.Id_Rol = 1 THEN 
        'C'
    WHEN U.Estado = 2 THEN
        'E'
    END) AND P.Id = U.Id_Usuario
	
    WHERE O.Id = @Id
    order by O.Fecha
  
    END