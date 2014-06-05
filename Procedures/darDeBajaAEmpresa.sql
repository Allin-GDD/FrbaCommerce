CREATE PROCEDURE darDeBajaAEmpresa
@Id_Empresa numeric(18,0)
AS
BEGIN
UPDATE Usuario
SET Estado = 0
WHERE 
Id_Usuario = @Id_Empresa
END