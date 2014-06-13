CREATE PROCEDURE buscarDatosPublicacion

@Codigo numeric(18,0)
AS
BEGIN
SELECT * from Publicacion
WHERE Codigo = @Codigo
END