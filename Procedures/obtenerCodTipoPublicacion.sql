CREATE PROCEDURE obtenerCodTipoPublicacion
@tipo nvarchar(255)
AS
BEGIN
SELECT Cod_Tipo from Tipo_Publicacion
WHERE Nombre = @tipo
END
