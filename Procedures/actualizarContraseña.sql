CREATE PROCEDURE actualizarContrase�a
@Usuario nvarchar(50),
@Contrase�a nvarchar(64)
AS
BEGIN
UPDATE Usuario
SET Password = @Contrase�a
WHERE Usuario = @Usuario
END