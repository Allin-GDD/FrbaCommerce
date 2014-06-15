CREATE PROCEDURE listadoDePreguntasAResponder
@Usuario nvarchar(100)
AS
BEGIN
SELECT Id, Id_Publicacion, UsuarioPregunta, Pregunta FROM PreguntasYRespuestas
WHERE Respuesta != null 
AND UsuarioPublicador = @Usuario
END
