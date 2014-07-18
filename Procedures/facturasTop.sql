create procedure facturasTop

@Id numeric (18,0),
@Cant int 
as
begin
select top (@Cant) 
 Codigo,Visibilidad_Cod,Usuario.Usuario from 
 Publicacion
 join Usuario on Usuario.Id_Usuario=Publicacion.Usuario
where Publicacion.Codigo not in (select Pub_Cod from Factura) and Id_Usuario = @Id
and  publicacion.Estado =4
order by publicacion.Fecha desc
end
