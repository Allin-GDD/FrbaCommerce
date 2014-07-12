CREATE PROCEDURE darDeBajaAUsuario
@Id_Usuario numeric(18,0),
@Id_Rol numeric(18,0)
AS
BEGIN
UPDATE Usuario
SET Baja = 0, Estado = 0
WHERE Id_Usuario = @Id_Usuario

UPDATE Publicacion
SET Estado = 4
WHERE Publicacion.Usuario = @Id_Usuario

IF(@Id_Rol = 1)
BEGIN
UPDATE Clientes
SET  Nro_Documento = 0, Telefono = null
where Id_Usuario = @Id_Usuario
END
ELSE IF(@Id_Rol = 2)
BEGIN
UPDATE Empresa 
SET  Nro_Documento = 0, Telefono = null
where Id_Usuario = @Id_Usuario
END

END