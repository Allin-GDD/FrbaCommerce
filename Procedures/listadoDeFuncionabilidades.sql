CREATE PROCEDURE listadoDeFuncionabilidades
@Rol numeric(18,0)
AS
BEGIN
SELECT Id_Funcionalidad FROM Funcionalidades
WHERE Id_Rol = @Rol
END