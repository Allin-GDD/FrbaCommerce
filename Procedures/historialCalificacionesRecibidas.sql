create PROCEDURE historialCalificacionesRecibidas
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
		SELECT C.Fecha, P.Descripcion, U.Usuario AS 'Comprador',cal.Cant_Estrellas AS 'Estrellas', cal.Descripcion AS 'Opinion'
		
    FROM Publicacion P 
	JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN Usuario U ON
    u.Id_Usuario = p.Usuario
   -- (C.Id_Cliente = U.Id_Usuario AND U.Id_Rol = 1)
   join Calificacion cal on cal.Cod_Calificacion=c.Calificacion_Codigo
	
    WHERE P.Usuario = @Id
    order by C.Fecha
  
    END
    