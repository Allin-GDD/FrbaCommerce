CREATE PROCEDURE agregarUnaPregunta
@UsuarioPreg numeric(18,0),
@Id_Publicacion numeric(18,0),
@Pregunta nvarchar(255)
AS
BEGIN
INSERT INTO PreguntasYRespuestas(UsuarioPregunta,
Pregunta,
Id_Publicacion)
VALUES(@UsuarioPreg,
@Pregunta,
@Id_Publicacion)
END