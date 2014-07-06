CREATE PROCEDURE quitarRol
@Id_Rol int,
@funcionalidad int
AS
BEGIN
DELETE Func_Rol
WHERE Id_Rol = @Id_Rol AND
Id_Func = @funcionalidad
END
