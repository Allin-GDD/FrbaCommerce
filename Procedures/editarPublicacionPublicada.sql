CREATE PROCEDURE editarPublicacionPublicada
		
		
		@Stock numeric(18,0),
		@Descripcion nvarchar(255),
		@Estado nvarchar(255),
		@Codigo numeric(18,0)

 
AS
BEGIN
	UPDATE Publicacion
SET  Stock = @Stock, Descripcion = @Descripcion,
Estado = @Estado
WHERE Codigo = @Codigo

END