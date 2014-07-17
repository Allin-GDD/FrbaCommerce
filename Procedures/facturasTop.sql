create procedure facturasTop

@Id numeric (18,0),
@Cant int 
as
begin
select top (@Cant) 
 Codigo,Visibilidad_Cod,Usuario.Usuario from 
 Publicacion
 join Compra on compra.Codigo_Pub = publicacion.Codigo
 join Usuario on Usuario.Id_Usuario=Publicacion.Usuario
where Facturada = 0
and Id_Usuario = @Id
and ( publicacion.Estado ='Finalizada')
order by publicacion.Fecha desc

end
