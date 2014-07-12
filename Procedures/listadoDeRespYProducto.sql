CREATE PROCEDURE listadoDeRespYProducto
@Id numeric(18,0)
AS
BEGIN
  SELECT PyR.Pregunta, PyR.Respuesta, PyR.FechaRespuesta,
   P.Descripcion as 'Descripción del Producto', P.Precio, TP.Nombre as 'Tipo de Publicación',
    V.Descripcion as 'Visibilidad', R.Descripcion as 'Rubro' 
    FROM Publicacion P 
JOIN Tipo_Publicacion TP ON p.Tipo = TP.Cod_Tipo 
JOIN Visibilidad V ON P.Visibilidad_Cod = V.Codigo 
JOIN Publicacion_Rubro PR ON Pr.id_Publicacion = p.Codigo
JOIN Rubro R ON R.Codigo = pr.id_Rubro
JOIN PreguntasYRespuestas PyR ON P.Codigo = PyR.Id_Publicacion
  WHERE PyR.UsuarioPregunta = @Id AND
  PyR.Respuesta IS NOT NULL
  
  END
