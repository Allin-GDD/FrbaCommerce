CREATE PROCEDURE seleccionVisibilidadNotNull
AS
BEGIN 
SELECT Codigo, Descripcion FROM Visibilidad
WHERE Estado <> 0
END
