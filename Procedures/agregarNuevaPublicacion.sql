CREATE PROCEDURE agregarNuevaPublicacion
		
		@Visibilidad numeric(18,0),
		@Tipo nvarchar(255),
		@Rubro numeric(18,0),
		@Stock numeric(18,0),
		@Precio numeric(18,2),
		@Descripcion nvarchar(255),
		@Permitir_Preguntas bit,
		@Fecha_Venc datetime,
		@Publicador nvarchar(1),
		@Id numeric(18,0)
 
AS
BEGIN
	INSERT INTO Publicacion(
	Visibilidad_Cod,
	Tipo,
	Rubro_Cod,
	Stock,
	Precio,
	Descripcion,
	Preguntas_permitidas,
	Fecha,
	Estado,
	Fecha_Venc,
	Publicador,
	Id)
	
	VALUES(
	@Visibilidad,
	@Tipo,
	@Rubro,
	@Stock,
	@Precio,
	@Descripcion,
	@Permitir_Preguntas,
	GETDATE(),
	'Borrador',
	@Fecha_Venc,
	@Publicador,
	@Id)

END