CREATE PROCEDURE obtenerNombreTipoPublicacion
@tipo numeric(18,0)
AS
BEGIN
SELECT Nombre from Tipo_Publicacion
WHERE Cod_Tipo = @tipo
END
