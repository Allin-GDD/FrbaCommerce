create procedure agregarCalificacion

@Id numeric (18,0),
@Cal_Cod numeric (18,0),
@Cant_Est numeric (18,0),
@Desc nvarchar(255)
AS 
BEGIN
UPDATE Compra
SET Calificacion_Codigo = @Cal_Cod,Calificacion_Cant_Estrellas = @Cant_Est,
Calificaciones_Descripcion = @Desc
WHERE Id = @Id 
END