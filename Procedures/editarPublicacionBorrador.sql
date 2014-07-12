CREATE PROCEDURE editarPublicacionBorrador
		
		@Visibilidad numeric(18,0),
		@Tipo nvarchar(255),
		@Stock numeric(18,0),
		@Precio numeric(18,2),
		@Descripcion nvarchar(255),
		@Estado nvarchar(255),
		@Permitir_Preguntas bit,
		@Fecha_Venc datetime,
		@Codigo numeric(18,0)

 
AS
BEGIN

	UPDATE Publicacion
SET Visibilidad_Cod = @Visibilidad, Tipo = @Tipo , Stock = @Stock, Precio = @Precio, Descripcion = @Descripcion,
Estado = @Estado, Preguntas_permitidas = @Permitir_Preguntas, Fecha_Venc = @Fecha_Venc
WHERE Codigo = @Codigo
	
	

END