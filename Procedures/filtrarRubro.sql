CREATE PROCEDURE filtrarRubro
@Descripcion nvarchar(255),
@codigo numeric(18,0),
@flag nvarchar(255)
AS
BEGIN
IF(@codigo = 0)
begin
	SELECT Codigo, Descripcion FROM Rubro
	WHERE Descripcion like '%'+@Descripcion+'%'
end
if(@flag = 'quitar')
begin
	SELECT Codigo, Descripcion FROM Rubro
	where Descripcion like '%'+@Descripcion+'%' AND codigo IN(select r.codigo from Publicacion p 
																   Inner join Publicacion_Rubro pr ON pr.id_Publicacion = p.Codigo
															       INNER JOIN Rubro r on pr.id_Rubro = r.codigo
																   where p.codigo = @codigo)
end
if(@flag = 'agregar')
begin
	select Codigo, Descripcion from Rubro 
	Where Descripcion like '%'+@Descripcion+'%' AND codigo NOT IN( select r.codigo from Publicacion p 
																   Inner join Publicacion_Rubro pr ON pr.id_Publicacion = p.Codigo
															       INNER JOIN Rubro r on pr.id_Rubro = r.codigo
																   where p.codigo = @codigo)
end
END
