CREATE PROCEDURE listaDeEmpresas
@Razon_Social nvarchar(255),
@CUIT nvarchar(50),
@Mail nvarchar(50)
AS
BEGIN
SELECT * FROM Empresa 
WHERE
Razon_Social LIKE '%'+@Razon_Social+'%' AND
Mail LIKE '%'+@Mail+'%' AND
(@CUIT = [Cuit] or @CUIT = '')
END