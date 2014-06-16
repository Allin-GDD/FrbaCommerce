CREATE PROCEDURE listadoDeRespYProducto
@Id nvarchar(100)
AS
BEGIN
  SELECT PyR.Pregunta, PyR.Respuesta, PyR.FechaRespuesta, PyR.UsuarioPregunta AS 'Usuario Pregunta',
   P.Descripcion as 'Descripción del Producto', P.Precio, P.Tipo as 'Tipo de Publicación',
    V.Descripcion as 'Visibilidad', R.Descripcion as 'Rubro' 
    FROM Publicacion P 
	JOIN Visibilidad V ON
P.Visibilidad_Cod = V.Codigo 
	JOIN Rubro R ON
R.Codigo = P.Rubro_Cod 
	JOIN PreguntasYRespuestas PyR ON
P.Codigo = PyR.Id_Publicacion
  WHERE PyR.UsuarioPregunta = @Id AND
  PyR.Respuesta IS NOT NULL
  
  END
