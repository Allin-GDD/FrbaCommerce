create procedure listaDePublicacionesSinFacturar
@id numeric(18,0)
as
begin
if(exists (select Codigo_Pub from Compra C join Publicacion P on P.Codigo= C.Codigo_Pub where P.Usuario = @id))
 	begin
 	 select Codigo,Descripcion,Tipo_Publicacion.Nombre Tipo,Estado.Nombre Estado from Publicacion 
 	join Tipo_Publicacion on Tipo=Tipo_Publicacion.Cod_Tipo
 	join Estado on Estado.Cod_Estado = publicacion.Estado
 	join Compra on compra.Codigo_Pub=Publicacion.Codigo
 	where Compra.facturada = 0
 	and estado.Nombre='Finalizada'
 	and Publicacion.Usuario = @id
 end
else
 begin
 	 select Codigo,Descripcion,Tipo_Publicacion.Nombre Tipo,Estado.Nombre Estado from Publicacion 
 	join Tipo_Publicacion on Tipo=Tipo_Publicacion.Cod_Tipo
 	join Estado on Estado.Cod_Estado = publicacion.Estado
 	where estado.Nombre='Finalizada'
 	and Publicacion.Usuario =@id and Publicacion.Codigo not in (select Pub_Cod from Factura)
 end
 

end

