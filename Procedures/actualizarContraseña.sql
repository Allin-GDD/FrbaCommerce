CREATE PROCEDURE actualizarContrase�a
@Usuario numeric(18,0),
@Contrase�a nvarchar(64)
AS
BEGIN
UPDATE Usuario
SET Password = @Contrase�a
WHERE Id_Usuario = @Usuario
END