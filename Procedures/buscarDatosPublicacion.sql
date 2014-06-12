CREATE PROCEDURE buscarDatosPublicacion

@Codigo numeric(18,0)
AS
BEGIN
SELECT Tipo, Stock, Descripcion from Publicacion
WHERE Codigo = @Codigo
END