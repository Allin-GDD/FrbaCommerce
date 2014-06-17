create procedure listaDePublicacionesSinFacturar

@id numeric (18,0)
as
begin
select Codigo,Descripcion,Tipo,Estado from Publicacion 
where Codigo not in(select Pub_Cod from Factura)
and id = @id
end



