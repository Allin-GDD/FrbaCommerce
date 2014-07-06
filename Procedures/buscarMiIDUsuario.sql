CREATE PROCEDURE buscarMiIDUsuario
@UserName nvarchar(50)
AS
BEGIN
SELECT Id_Usuario From Usuario 
WHERE Usuario = @UserName
END