CREATE PROCEDURE obtenerPregunta
@Id numeric(18,0)
AS
BEGIN
SELECT Pregunta FROM PreguntasYRespuestas
WHERE Id = @Id
END