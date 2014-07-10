create procedure listaDePublicacionesSinFacturar

@id numeric (18,0)
as
begin
select Codigo,Descripcion,Tipo_Publicacion.Nombre,Estado.Nombre from Publicacion 
join Tipo_Publicacion on Tipo=Tipo_Publicacion.Cod_Tipo
join Estado on Estado.Cod_Estado = publicacion.Estado
where Codigo not in(select Pub_Cod from Factura)
and id = @id
end



