CREATE PROCEDURE agregarCompra
		@Codigo numeric(18,0),
		@Id numeric(18,0),
		@Stock numeric(18,0)

AS
BEGIN
	INSERT INTO Compra(
	Codigo_Pub,
	Id_Cliente,
	Fecha,
	Cantidad,
	Calificacion_Codigo)
	VALUES(
	@Codigo,
	@Id,
	GETDATE(),
	@Stock,
	0)	

END