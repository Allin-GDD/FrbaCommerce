CREATE PROCEDURE obtenerIdRol
@NombreRol nvarchar(30)
AS
BEGIN
SELECT Id From Rol
WHERE Nombre = @NombreRol
END