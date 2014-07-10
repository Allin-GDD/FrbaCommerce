create procedure facturasTop

@Id numeric (18,0),
@Cant int 
as
begin
select top (@Cant) 
 Codigo,Visibilidad_Cod,Usuario.Usuario from Publicacion 
 join Usuario on Usuario.Id_Usuario=Publicacion.Usuario
where Codigo not in(select Pub_Cod from Factura)
and Id_Usuario = @Id
order by Fecha desc

end
