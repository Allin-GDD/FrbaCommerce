CREATE PROCEDURE actualizarContraseña
@Usuario nvarchar(50),
@Contraseña nvarchar(64)
AS
BEGIN
UPDATE Usuario
SET Password = @Contraseña
WHERE Usuario = @Usuario
END