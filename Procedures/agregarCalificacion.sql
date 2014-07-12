create procedure agregarCalificacion

@Id numeric (18,0),
@Cant_Est numeric (18,0),
@Desc nvarchar(255)
AS 
BEGIN
declare @codcal numeric(18,0)
 (select @codcal=Calificacion_Codigo from Compra where @Id=compra.Id)  

UPDATE Calificacion
SET Cant_Estrellas= @Cant_Est,
Descripcion= @Desc

WHERE @codcal=Cod_Calificacion
END