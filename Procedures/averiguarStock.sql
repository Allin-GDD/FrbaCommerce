CREATE PROCEDURE averiguarStock
@Codigo numeric(18,0)
AS
BEGIN

select Stock from Publicacion where Codigo = @Codigo
end