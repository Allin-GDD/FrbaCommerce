CREATE PROCEDURE obtenerNombreIdRol
@Id_Rol numeric(18,0)
AS
BEGIN
SELECT nombre FROM Rol 
WHERE Id = @Id_Rol
END