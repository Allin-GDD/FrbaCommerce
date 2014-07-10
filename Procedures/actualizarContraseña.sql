CREATE PROCEDURE actualizarContraseña
@Usuario numeric(18,0),
@Contraseña nvarchar(64)
AS
BEGIN
UPDATE Usuario
SET Password = @Contraseña
WHERE Id_Usuario = @Usuario
END