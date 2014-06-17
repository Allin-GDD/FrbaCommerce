CREATE PROCEDURE historialCalificacionesRecibidas
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
		SELECT C.Fecha, P.Descripcion, U.Usuario AS 'Comprador', C.Calificacion_Cant_Estrellas AS 'Estrellas', C.Calificaciones_Descripcion AS 'Opinion'
		
    FROM Publicacion P 
	JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN Usuario U ON
    (C.Id_Cliente = U.Id_Usuario AND U.Id_Rol = 1)
	
    WHERE P.Id = @Id
    order by C.Fecha
  
    END
    