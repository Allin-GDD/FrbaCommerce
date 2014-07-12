CREATE PROCEDURE agregarPublicacionRubro
@codigo Decimal,
@rubro Decimal
AS
BEGIN
INSERT INTO Publicacion_Rubro
VALUES(@codigo,@rubro)
END