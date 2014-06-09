CREATE PROCEDURE buscarDuracionVisibilidad
@Visibilidad nvarchar(50)
AS
BEGIN
	SELECT * FROM Visibilidad 
		WHERE 
		Codigo = @Visibilidad;
END