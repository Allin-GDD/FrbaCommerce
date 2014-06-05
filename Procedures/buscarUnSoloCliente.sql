CREATE PROCEDURE buscarUnSoloCliente
@Id numeric(18,0)
AS
BEGIN
	SELECT * FROM Clientes 
		WHERE 
		Id = @Id;
END