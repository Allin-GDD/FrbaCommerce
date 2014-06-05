CREATE PROCEDURE buscarUnaSolaEmpresa
@Id numeric (18,0)
AS 
BEGIN
SELECT *FROM Empresa 
WHERE Id = @Id
END