CREATE PROCEDURE buscarIdCliente
@Dni nvarchar(255)
AS
BEGIN
SELECT id from Clientes
WHERE Dni = '@Dni'
END