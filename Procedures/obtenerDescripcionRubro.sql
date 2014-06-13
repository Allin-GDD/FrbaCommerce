CREATE PROCEDURE obtenerDescripcionRubro
@IdRubro numeric(18,0)
AS
BEGIN
SELECT Descripcion from Rubro
WHERE Codigo = @IdRubro
END
