CREATE PROCEDURE buscarIdRol
@Rol_Nombre nvarchar(50)
AS
BEGIN
SELECT Id FROM Rol 
WHERE Nombre = @Rol_Nombre
END