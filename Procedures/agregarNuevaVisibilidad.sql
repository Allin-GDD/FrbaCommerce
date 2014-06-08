CREATE PROCEDURE agregarNuevaVisibilidad
		@Codigo numeric(18,0),
		@Descripcion nvarchar(255),
		@Precio numeric(18,2),
		@Porcentaje numeric(18,2),
		@Estado smallint,
		@Vencimiento smallint

AS
BEGIN
	INSERT INTO Visibilidad(
	Codigo,
	Descripcion,
	Precio,
	Porcentaje,
	Estado,
	Vencimiento)
	VALUES(
	@Codigo,
	@Descripcion,
	@Precio,
	@Porcentaje,
	@Estado,
	@Vencimiento
	)	

END