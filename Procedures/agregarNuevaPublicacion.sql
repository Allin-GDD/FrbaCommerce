CREATE PROCEDURE agregarNuevaPublicacion
		
		@Visibilidad numeric(18,0),
		@Tipo numeric(18,0),
		@Stock numeric(18,0),
		@Precio numeric(18,2),
		@Estado numeric(18,0),
		@Rubro numeric(18,0),
		@Descripcion nvarchar(255),
		@Permitir_Preguntas bit,
		@Fecha_Venc datetime,
		@Usuario numeric(18,0)
 
AS
BEGIN
	
	DECLARE @idPub numeric(18,0)
	
	SET @idPub = (SELECT MAX(Codigo)+1 from Publicacion)
	
	INSERT INTO Publicacion(
	Codigo,
	Visibilidad_Cod,
	Tipo,
	Stock,
	Precio,
	Estado,
	Descripcion,
	Preguntas_permitidas,
	Fecha,
	Fecha_Venc,
	Usuario)
	
	VALUES(
	@idPub,
	@Visibilidad,
	@Tipo,
	@Stock,
	@Precio,
	@Estado,
	@Descripcion,
	@Permitir_Preguntas,
	GETDATE(),
	@Fecha_Venc,
	@Usuario)
	
	INSERT INTO Publicacion_Rubro(id_Publicacion, id_Rubro)
	VALUES(@idPub,@Rubro)

END