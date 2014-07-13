create PROCEDURE buscarIdMaximaOferta
@Cod_Pub numeric(18,0)
AS
BEGIN
select o.Id_Cliente from Oferta o

where o.Monto=(select MAX(monto) montomax from Oferta where  Codigo_Pub = @Cod_Pub)


END