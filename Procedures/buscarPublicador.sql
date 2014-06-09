CREATE PROCEDURE buscarPublicador
@Usuario nvarchar(50)
AS
BEGIN
	SELECT * FROM Usuario 
		WHERE 
		Usuario = @Usuario;
END