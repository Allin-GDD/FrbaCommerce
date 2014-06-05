CREATE PROCEDURE ActualizarVisibilidad
@Codigo numeric(18,0),
@Descripcion nvarchar(255),
@Precio numeric(18,2),
@Porcentaje numeric(18,2)
AS 
BEGIN
UPDATE Visibilidad
SET Descripcion = @Descripcion, Precio = @Precio , Porcentaje = @Porcentaje
WHERE Codigo = @Codigo
End