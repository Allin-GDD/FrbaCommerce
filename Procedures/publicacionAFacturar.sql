create procedure publicacionAFacturar
@Codigo numeric (18,0)
as
begin

select Compra.Codigo_Pub,compra.Cantidad,tabla.Porcentaje,tabla.Precio from 

(select Publicacion.Codigo,Visibilidad.Porcentaje,Visibilidad.Precio from Visibilidad,Publicacion

where  Visibilidad.Codigo= Publicacion.Visibilidad_Cod and Publicacion.Codigo = @Codigo
)as tabla,Compra where compra.Codigo_Pub = tabla.Codigo 

end