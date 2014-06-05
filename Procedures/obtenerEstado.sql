CREATE PROCEDURE obtenerEstado
@Id_Rol numeric(18,0)
AS
BEGIN
SELECT Estado FROM Rol
WHERE Id = @Id_Rol
END






