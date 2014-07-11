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
	Id_Cliente,
	Monto)
	VALUES(
	@Cod_Pub,
	@Fecha,
	@Id_Cli,
	@Monto)	

END