CREATE PROCEDURE buscarUnaVisibilidad
@Codigo numeric(18,0)
AS
BEGIN
	SELECT * FROM Visibilidad
		WHERE 
		Codigo = @Codigo;
END