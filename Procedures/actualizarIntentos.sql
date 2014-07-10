CREATE PROCEDURE actualizarIntentos
@Usuario numeric(18,0),
@Intentos int
AS
BEGIN
UPDATE Usuario
SET Intentos = @Intentos
WHERE
@Usuario = Id_Usuario
END