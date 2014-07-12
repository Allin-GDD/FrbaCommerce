CREATE PROCEDURE buscarIdMaximaOferta
@Cod_Pub numeric(18,0)
AS
BEGIN
select tabla.cliente from
(select MAX(monto) montomax,o.Id_Cliente as cliente from Oferta o
where Codigo_Pub = @Cod_Pub
group by o.Id_Cliente) as tabla
END