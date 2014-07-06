CREATE PROCEDURE actualizarNombreRol
@Id_Rol numeric(18,0),
@Nombre_New nvarchar(30)
AS
BEGIN
UPDATE Rol 
SET Nombre = @Nombre_New
WHERE Id = @Id_Rol
END 
