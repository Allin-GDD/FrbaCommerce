CREATE PROCEDURE verificarEstado
@Codigo numeric(18,0)
AS
BEGIN
	SELECT Estado FROM Publicacion 
		WHERE 
		Codigo = @Codigo;
END