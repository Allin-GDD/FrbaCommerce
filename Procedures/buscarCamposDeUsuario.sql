CREATE PROCEDURE buscarCamposDeUsuario
@Usuario nvarchar(50)
AS
BEGIN
SELECT Password,Id_Usuario, Id_Rol FROM Usuario
WHERE Usuario = @Usuario
END

Select *from Usuario