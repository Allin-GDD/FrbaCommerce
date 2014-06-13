CREATE PROCEDURE obtenerCodRubro
@Descripcion nvarchar(255)
AS
BEGIN
SELECT Codigo from Rubro
WHERE Descripcion = @Descripcion
END