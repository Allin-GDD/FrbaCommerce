CREATE PROCEDURE buscarDatosPublicacion

@Codigo numeric(18,0)
AS
BEGIN
SELECT * from Publicacion P
JOIN Publicacion_Rubro PR on P.Codigo = PR.id_Publicacion 
WHERE Codigo = @Codigo
END

