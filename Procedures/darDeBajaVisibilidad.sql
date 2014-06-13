CREATE PROCEDURE darDeBajaVisibilidad
@Codigo numeric(18,0)
AS
BEGIN
UPDATE Visibilidad
SET Estado = 0, Descripcion = null
WHERE Codigo = @Codigo
END
