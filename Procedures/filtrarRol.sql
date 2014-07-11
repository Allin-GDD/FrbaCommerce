CREATE PROCEDURE filtrarRol
@Rol nvarchar(50),
@Filtrado int
AS
BEGIN
IF(@Filtrado = 1)
BEGIN
SELECT Id, Nombre FROM Rol
WHERE Nombre like '%'+@Rol+'%'
AND Baja = 1
END
ELSE
BEGIN
SELECT Id, Nombre FROM Rol
WHERE Nombre like '%'+@Rol+'%'
AND Estado <> 0
AND Baja = 1
END
end