create procedure publicacionAFacturar
@Codigo numeric (18,0)
as
begin
if(exists (select Codigo_Pub from Compra
 	 where Codigo_Pub = @Codigo))
begin
select Compra.Codigo_Pub,compra.Cantidad,tabla.Porcentaje,precioPub, precioVis from 

(select Publicacion.Codigo,Visibilidad.Porcentaje,Visibilidad.Precio as 'precioVis', Publicacion.Precio as 'precioPub' from Visibilidad,Publicacion

where Visibilidad.Codigo= Publicacion.Visibilidad_Cod and Publicacion.Codigo = @Codigo
)as tabla,Compra where compra.Codigo_Pub = tabla.Codigo 
end
else
begin
 (select @Codigo as 'Codigo_Pub',0 as 'Cantidad', 0 as 'Porcentaje', 0 as 'precioPub', Visibilidad.Precio as 'precioVis' from Visibilidad,Publicacion
 where Visibilidad.Codigo= Publicacion.Visibilidad_Cod and Publicacion.Codigo = @Codigo)
end
end