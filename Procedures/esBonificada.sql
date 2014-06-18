create procedure esBonificada
@Id numeric (18,0),
@Rol nvarchar(30),
@Visibilidad numeric (18,0)
as
begin
select Codigo,Publicador,Visibilidad_Cod,Fecha, RowNumber  
from (select Codigo, Id, Publicador, Visibilidad_Cod, Fecha,row_number() over(order by Id,Publicador,Visibilidad_Cod,Fecha)as RowNumber
  from Publicacion) as Pub 
where RowNumber % 10 = 0 AND Id = @Id AND Publicador = @Rol AND Visibilidad_Cod = @Visibilidad AND Codigo > 68380
order by Id, Publicador, Visibilidad_Cod, Fecha
end