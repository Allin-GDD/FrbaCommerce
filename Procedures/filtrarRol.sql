CREATE PROCEDURE filtrarRol
@Rol nvarchar(50)
AS
BEGIN
SELECT Id, Nombre FROM Rol
WHERE Nombre like '%'+@Rol+'%'
END