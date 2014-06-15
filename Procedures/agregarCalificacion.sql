create procedure agregarCalificacion

@Codigo numeric (18,0),
@Cal_Cod numeric (18,0),
@Cant_Est numeric (18,0),
@Desc nvarchar(255)
AS 
BEGIN
UPDATE Compra
SET Calificacion_Codigo = @Codigo,Calificacion_Cant_Estrellas = @Cant_Est,
Calificaciones_Descripcion = @Desc
WHERE Codigo_Pub = @Codigo 
END