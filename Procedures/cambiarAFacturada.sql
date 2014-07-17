create procedure cambiarAFacturada
@codcompra numeric (18,0)
as
begin
update compra
set Facturada = 1
where ID=@codcompra
end
