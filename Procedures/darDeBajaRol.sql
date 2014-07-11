CREATE PROCEDURE darDeBajaRol
@Rol numeric(18,0)
AS
BEGIN
UPDATE Rol
SET Baja = 0, Estado = 0
WHERE Id = @Rol
END