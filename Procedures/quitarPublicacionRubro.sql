CREATE PROCEDURE quitarPublicacionRubro
@codigo Decimal,
@rubro Decimal
AS
BEGIN
DELETE FROM Publicacion_Rubro
WHERE @codigo = id_Publicacion AND @rubro = id_Rubro
END