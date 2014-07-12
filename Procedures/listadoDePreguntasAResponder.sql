CREATE PROCEDURE listadoDePreguntasAResponder
@Usuario numeric(18,0)
AS
BEGIN
SELECT Id, Id_Publicacion, u.Usuario, PR.Pregunta FROM PreguntasYRespuestas PR
INNER JOIN Publicacion P ON p.Codigo = PR.Id_Publicacion
INNER JOIN Usuario U ON u.Id_Usuario = PR.UsuarioPregunta
WHERE Respuesta IS NULL 
AND P.Usuario = @Usuario
END


select *from Publicacion