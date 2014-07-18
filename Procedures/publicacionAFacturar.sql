create procedure publicacionAFacturar
@Codigo numeric (18,0)
as
begin
if(exists (select Codigo_Pub from Compra where Codigo_Pub = @Codigo))
begin
select Compra.Codigo_Pub,compra.Cantidad,tabla.Porcentaje,precioPub, precioVis from 
(select Publicacion.Codigo,Visibilidad.Porcentaje,Visibilidad.Precio as 'precioVis',
 Publicacion.Precio as 'precioPub' from Visibilidad,Publicacion
 where Visibilidad.Codigo= Publicacion.Visibilidad_Cod and Publicacion.Codigo = @Codigo)as tabla,Compra where compra.Codigo_Pub = tabla.Codigo 
end
else
begin
  declare @Cantidad numeric(18,0)
  set @Cantidad = 0
  declare @Visib numeric(18,2)
  set @Visib = 0
  declare @PrecioPub numeric(18,2)
  set @PrecioPub = 0
 (select @Codigo as 'Codigo_Pub',@Cantidad as 'Cantidad', @Visib as 'Porcentaje', @PrecioPub as 'precioPub',
  Visibilidad.Precio as 'precioVis' from Visibilidad,Publicacion
 where Visibilidad.Codigo= Publicacion.Visibilidad_Cod and Publicacion.Codigo = @Codigo)

end
end