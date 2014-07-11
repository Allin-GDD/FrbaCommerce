create PROCEDURE buscarIdEmpresa
@Cuit nvarchar(255)
AS
BEGIN
SELECT Id_Usuario from Empresa
WHERE Nro_Documento = @Cuit
END