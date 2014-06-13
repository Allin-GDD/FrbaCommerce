CREATE PROCEDURE buscarPublicadorCod
@Codigo numeric(18,0)
AS
BEGIN
	SELECT Id,Publicador FROM Publicacion 
		WHERE 
		Codigo = @Codigo;
END