CREATE PROCEDURE buscarIdUsuario
@Codigo numeric(18,0)
AS
BEGIN
SELECT id from Publicacion
WHERE Codigo= @Codigo
END