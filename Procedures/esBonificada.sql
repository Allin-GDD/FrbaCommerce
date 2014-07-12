create procedure esBonificada
@Id numeric (18,0),

@Visibilidad numeric (18,0)
as
begin
select Codigo,Usuario,Visibilidad_Cod,Fecha, RowNumber  
from (select Codigo, Usuario, Visibilidad_Cod, Fecha,row_number() over(order by Codigo,usuario,Visibilidad_Cod,Fecha)as RowNumber
  from Publicacion
  where Usuario = @Id AND Visibilidad_Cod = @Visibilidad) as Pub 
where RowNumber % 10 = 0
end