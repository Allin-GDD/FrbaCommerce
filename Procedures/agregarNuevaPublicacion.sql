CREATE PROCEDURE agregarNuevaPublicacion
		
		@Visibilidad numeric(18,0),
		@Tipo nvarchar(255),
		@Stock numeric(18,0),
		@Precio numeric(18,2),
		@Descripcion nvarchar(255),
		@Permitir_Preguntas bit,
		@Fecha_Venc datetime,
		@Usuario numeric(18,0)
 
AS
BEGIN
	INSERT INTO Publicacion(
	Visibilidad_Cod,
	Tipo,
	Stock,
	Precio,
	Descripcion,
	Preguntas_permitidas,
	Fecha,
	Estado,
	Fecha_Venc,
	Usuario)
	
	VALUES(
	@Visibilidad,
	@Tipo,
	@Stock,
	@Precio,
	@Descripcion,
	@Permitir_Preguntas,
	GETDATE(),
	'Borrador',
	@Fecha_Venc,
	@Usuario)

END