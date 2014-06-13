CREATE PROCEDURE buscarPrecio
@Cod_Pub numeric(18,0)
AS
BEGIN
SELECT Precio FROM Publicacion
WHERE Codigo = @Cod_Pub
END