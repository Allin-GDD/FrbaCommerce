create procedure facturasTop

@Id numeric (18,0),
@Cant int 
as
begin
select top (5) 
 Codigo,Visibilidad_Cod,Publicador from Publicacion 
where Codigo not in(select Pub_Cod from Factura)
and id = @Id
order by Fecha desc

end
