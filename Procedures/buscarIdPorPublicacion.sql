create PROCEDURE buscarIdPorPublicacion
@Codigo numeric(18,0)
AS
BEGIN

select Usuario from Publicacion where Codigo = @Codigo
end