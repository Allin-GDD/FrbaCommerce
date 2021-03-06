create PROCEDURE historialCalificacionesOtorgadas
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
		SELECT C.Fecha, P.Descripcion, U.Usuario AS 'Vendedor', cal.Cant_Estrellas AS 'Estrellas', cal.Descripcion AS 'Opinion'
		
    FROM Publicacion P 
	JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN Usuario U ON
  -- P.Publicador = (CASE WHEN U.Id_Rol = 1 THEn    'C' WHEN U.Id_Rol = 2 THen    'E'END) 
    P.Usuario = U.Id_Usuario
	join Calificacion cal on Calificacion_Codigo=Cod_Calificacion
    WHERE C.Id_Cliente = @Id
    and Cant_Estrellas <>0
    order by C.Fecha
  
    END
