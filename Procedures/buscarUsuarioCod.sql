CREATE PROCEDURE buscarUsuarioCod
@Codigo numeric(18,0)
AS
BEGIN
	SELECT Usuario FROM Publicacion 
		WHERE 
		Codigo = @Codigo;
END