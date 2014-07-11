CREATE PROCEDURE obtenerCodEstadoPublicacion
@estado nvarchar(255)
AS
BEGIN
SELECT Cod_Estado from Estado
WHERE Nombre = @estado
END
