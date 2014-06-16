CREATE PROCEDURE agregarUnaPregunta
@UsuarioPreg nvarchar(100),
@Id_Publicacion numeric(18,0),
@Pregunta nvarchar(255),
@Publicador nvarchar(100)
AS
BEGIN
INSERT INTO PreguntasYRespuestas(UsuarioPublicador,
UsuarioPregunta,
Pregunta,
Id_Publicacion)
VALUES(@Publicador,
@UsuarioPreg,
@Pregunta,
@Id_Publicacion)
END