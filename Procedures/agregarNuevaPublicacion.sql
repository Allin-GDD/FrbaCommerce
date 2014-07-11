CREATE PROCEDURE agregarNuevaPublicacion
		
		@Visibilidad numeric(18,0),
		@Tipo nvarchar(255),
		@Stock numeric(18,0),
		@Precio numeric(18,2),
		@Rubro numeric(18,0),
		@Descripcion nvarchar(255),
		@Permitir_Preguntas bit,
		@Fecha_Venc datetime,
		@Usuario numeric(18,0)
 
AS
BEGIN
	
	DECLARE @idPub numeric(18,0)
	
	SET @idPub = (SELECT MAX(Codigo) from Publicacion) + 1
	
	INSERT INTO Publicacion(
	Codigo,
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
	@idPub,
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
	
	INSERT INTO Publicacion_Rubro(id_Publicacion, id_Rubro)
	VALUES(@idPub,@Rubro)

END