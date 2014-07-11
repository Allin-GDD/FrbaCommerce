CREATE PROCEDURE listadoDePreguntasAResponder
@Usuario numeric(18,0)
AS
BEGIN
SELECT Id, Id_Publicacion, UsuarioPregunta, Pregunta FROM PreguntasYRespuestas
WHERE Respuesta IS NULL 
AND UsuarioPregunta = @Usuario
END