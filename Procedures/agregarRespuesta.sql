CREATE PROCEDURE agregarRespuesta
@Id numeric(18,0),
@Respuesta nvarchar(255)
AS
BEGIN
UPDATE PreguntasYRespuestas
SET Respuesta = @Respuesta, FechaRespuesta = GETDATE()
WHERE Id = @Id
END