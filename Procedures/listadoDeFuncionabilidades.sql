CREATE PROCEDURE listadoDeFuncionabilidades
@Rol numeric(18,0)
AS
BEGIN
SELECT Id_Funcionabilidad FROM Funcionabilidades
WHERE Id_Rol = @Rol
END