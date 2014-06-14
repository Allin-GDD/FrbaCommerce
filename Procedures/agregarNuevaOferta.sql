CREATE PROCEDURE agregarNuevaOferta
		@Cod_Pub numeric(18,0),
		@Monto numeric(18,2),
		@Id_Cli numeric(18,0)

AS
BEGIN
	INSERT INTO Oferta(
	Codigo_Pub,
	Fecha,
	Id,
	Monto)
	VALUES(
	@Cod_Pub,
	GETDATE(),
	@Id_Cli,
	@Monto)	

END