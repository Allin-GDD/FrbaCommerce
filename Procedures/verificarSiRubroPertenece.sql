CREATE PROCEDURE verificarSiRubroPertenece
@codRubro numeric(18,0),
@codigo numeric(18,0)
AS
BEGIN
SELECT COUNT(id_Rubro) from Publicacion_Rubro
WHERE @codigo = id_Publicacion AND @codRubro = id_Rubro
END