CREATE PROCEDURE actualizarIntentos
@Usuario nvarchar(50),
@Intentos int
AS
BEGIN
UPDATE Usuario
SET Intentos = @Intentos
WHERE
@Usuario = Usuario
END
