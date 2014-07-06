CREATE PROCEDURE actualizarEstadoDelUsuario
@Estado smallint,
@Id numeric(18,0)
AS
BEGIN
UPDATE Usuario
SET Estado = @Estado
WHERE Id_Usuario = @Id
END 
