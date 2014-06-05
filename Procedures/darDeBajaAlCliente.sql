CREATE PROCEDURE darDeBajaAlCliente
@Id numeric(18,0)
AS
BEGIN
UPDATE Usuario
SET Estado = 0
WHERE Id_Usuario = @Id
END
