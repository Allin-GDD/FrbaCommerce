create PROCEDURE buscarIdPorPublicacion
@Codigo numeric(18,0)
AS
BEGIN

select Id from Publicacion where Codigo = @Codigo
end