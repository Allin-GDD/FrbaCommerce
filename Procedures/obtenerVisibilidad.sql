CREATE PROCEDURE obtenerVisibilidad
@Cod_visib numeric(18,0)
AS
BEGIN
SELECT Descripcion from Visibilidad
WHERE Codigo = @Cod_visib
END
