CREATE PROCEDURE filtrarRol
@Rol nvarchar(50),
@Habilitado int
AS
BEGIN
IF(@Habilitado = 1)
BEGIN
SELECT Id, Nombre FROM Rol
WHERE Nombre like '%'+@Rol+'%'
END
ELSE
BEGIN
SELECT Id, Nombre FROM Rol
WHERE Nombre like '%'+@Rol+'%'
AND Estado <> 0
END
end