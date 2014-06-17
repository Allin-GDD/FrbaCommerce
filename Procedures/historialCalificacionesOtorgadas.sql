CREATE PROCEDURE historialCalificacionesOtorgadas
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
		SELECT C.Fecha, P.Descripcion, U.Usuario AS 'Vendedor', C.Calificacion_Cant_Estrellas AS 'Estrellas', C.Calificaciones_Descripcion AS 'Opinion'
		
    FROM Publicacion P 
	JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN Usuario U ON
    P.Publicador = (CASE WHEN U.Id_Rol = 1 THEN 
        'C'
    WHEN U.Id_Rol = 2 THEN
        'E'
    END) AND P.Id = U.Id_Usuario
	
    WHERE C.Id_Cliente = @Id
    order by C.Fecha
  
    END