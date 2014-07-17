create procedure facturasTop

@Id numeric (18,0),
@Cant int 
as
begin
select top (@Cant) 
 Codigo,Visibilidad_Cod,Usuario.Usuario,c.Id from Compra c
 join Publicacion on Publicacion.Codigo = c.Codigo_Pub
 join Usuario on Usuario.Id_Usuario=Publicacion.Usuario
where Facturada = 0
and Id_Usuario = @Id
order by c.Fecha desc

end
