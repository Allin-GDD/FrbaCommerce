create PROCEDURE buscarIdUsuario
@Cod_Pub numeric(18,0)
AS
BEGIN
SELECT id,Publicador from Publicacion
WHERE Codigo= @Cod_Pub
END