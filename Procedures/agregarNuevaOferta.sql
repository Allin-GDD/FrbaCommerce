create PROCEDURE agregarNuevaOferta
		@Cod_Pub numeric(18,0),
		@Monto numeric(18,2),
		@Id_Cli numeric(18,0),
		@Fecha datetime

AS
BEGIN
	INSERT INTO Oferta(
	Codigo_Pub,
	Fecha,
	Monto,
	Id_Cliente,
	Con_Ganador)
	VALUES(
	@Cod_Pub,
	@Fecha,
	@Monto,
	@Id_Cli,
	0)	

END