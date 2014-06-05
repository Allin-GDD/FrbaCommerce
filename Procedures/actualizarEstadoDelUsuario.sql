CREATE PROCEDURE actualizarEstadoDelUsuario
@Estado nvarchar(max),
@Rol numeric(18,0),
@Id numeric(18,0)
AS
BEGIN
UPDATE Usuario
SET Estado = @Estado
WHERE Id_Rol = @Rol AND
Id_Usuario = @Id
END 