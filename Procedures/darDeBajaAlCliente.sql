CREATE PROCEDURE darDeBajaAlCliente
@Id numeric(18,0),
@Rol numeric(18,0)
AS
BEGIN
UPDATE Usuario
SET Baja = 0
WHERE Id_Usuario = @Id
AND Id_Rol = @Rol

UPDATE Clientes 
SET  Dni = 0, Telefono = null
where Id = @Id
END
