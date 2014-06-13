CREATE PROCEDURE buscarMaximaOferta
@Cod_Pub numeric(18,0)
AS
BEGIN
select MAX(monto) from Oferta
where Codigo_Pub = @Cod_Pub
END