CREATE PROCEDURE allin.actualizarBajaDelUsuario
@Baja smallint,
@Id numeric(18,0)
AS
BEGIN
UPDATE allin.Usuario
SET Baja = @Baja
WHERE Id_Usuario = @Id
END 