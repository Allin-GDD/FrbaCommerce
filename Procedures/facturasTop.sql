create procedure facturasTop

@Id numeric (18,0),
@Cant int ,
@fecha datetime
as
begin
select top (@Cant) 
 Codigo,Visibilidad_Cod,Usuario.Usuario,c.Id from Compra c
 join Publicacion on Publicacion.Codigo = c.Codigo_Pub
 join Usuario on Usuario.Id_Usuario=Publicacion.Usuario
where Facturada = 0
and Id_Usuario = @Id
and (Stock = 0 or Fecha_Venc<@fecha)
order by c.Fecha desc

end
