CREATE PROCEDURE buscarCamposDeUsuario
@Usuario nvarchar(50)
AS
BEGIN
SELECT Password,Id_Usuario,Rol_Usuario,Intentos, Estado FROM Usuario
WHERE Usuario = @Usuario
END
