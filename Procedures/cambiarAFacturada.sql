create procedure cambiarAFacturada
@codcompra numeric (18,0)
as
begin
update compra
set Facturada = 1
where Codigo_Pub = @codcompra
end
