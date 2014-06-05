CREATE PROCEDURE darDeBajaRol
@Rol numeric(18,0)
AS
BEGIN
UPDATE Rol
SET Estado = 0
WHERE Id = @Rol
END