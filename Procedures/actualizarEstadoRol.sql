CREATE PROCEDURE actualizarEstadoRol
@Id_Rol numeric(18,0),
@Estado smallint
AS
BEGIN
UPDATE Rol
SET Estado = @Estado
WHERE Id = @Id_Rol

UPDATE Usuario_Rol
SET Estado = @Estado 
WHERE Id_Rol = @Id_Rol
END