CREATE PROCEDURE darDeBajaAEmpresa
@Id_Empresa numeric(18,0),
@Rol numeric(18,0)
AS
BEGIN
UPDATE Usuario
SET Baja = 0
WHERE Id_Usuario = @Id_Empresa
AND Id_Rol = @Rol

UPDATE Empresa 
SET  Cuit = 0, Telefono = null
where Id = @Id_Empresa

UPDATE Publicacion
SET Estado = 'Finalizada'
WHERE Id = @Id_Empresa
AND Publicador = 'E'

END
