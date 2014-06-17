create procedure nroFactura
as
begin 

 SELECT MAX(numero) from Factura 
end 