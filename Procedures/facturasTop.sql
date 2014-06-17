create procedure facturasTop

@Id numeric (18,0),
@Cant int 
as
begin
select top (@Cant) 
 Codigo from Publicacion 
where Codigo not in(select Pub_Cod from Factura)
and id = @Id
order by Fecha desc

end
