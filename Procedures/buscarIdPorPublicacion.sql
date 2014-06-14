CREATE PROCEDURE buscarIdPorPublicacion
@Codigo numeric(18,0)
AS
BEGIN

select Publicacion.Id from Publicacion where Codigo = @Codigo
end