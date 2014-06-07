CREATE PROCEDURE buscarIdCliente
@Dni numeric(18,0)
AS
BEGIN
SELECT id from Clientes
WHERE Dni = @Dni
END