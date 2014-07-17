create procedure cambiarConGanador
@Codigo numeric (18,0)
as
begin
update Oferta SET Con_Ganador = 1 WHERE Codigo_Pub = @Codigo
update Publicacion set Estado = 4 where Codigo = @Codigo
end