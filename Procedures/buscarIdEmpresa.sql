CREATE PROCEDURE buscarIdEmpresa
@Cuit nvarchar(255)
AS
BEGIN
SELECT id from Empresa
WHERE Cuit = @Cuit
END