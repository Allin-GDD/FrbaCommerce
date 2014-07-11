create PROCEDURE agregarCompra
		@Codigo numeric(18,0),
		@Id numeric(18,0),
		@Stock numeric(18,0),
		@Fecha datetime

AS
BEGIN

	insert into Calificacion
	(Cod_Calificacion,Cant_Estrellas) values ((select MAX(Cod_Calificacion)+1 from Calificacion),0)


	INSERT INTO Compra(
	Codigo_Pub,
	Id_Cliente,
	Fecha,
	Cantidad,
	Calificacion_Codigo)
	VALUES(
	@Codigo,
	@Id,
	@Fecha,
	@Stock,
	(select MAX(Cod_Calificacion) from Calificacion)	)
	

END