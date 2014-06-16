CREATE PROCEDURE listadoDePreguntasAResponder
@Usuario nvarchar(100)
AS
BEGIN
SELECT Id, Id_Publicacion, UsuarioPregunta, Pregunta FROM PreguntasYRespuestas
WHERE Respuesta IS NULL 
AND UsuarioPublicador = @Usuario
END