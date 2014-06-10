CREATE PROCEDURE filtrarRubro
@Descripcion nvarchar(255)
AS
BEGIN
SELECT Codigo, Descripcion FROM Rubro
WHERE Descripcion like '%'+@Descripcion+'%'
END