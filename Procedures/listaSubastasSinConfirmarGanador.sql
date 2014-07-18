alter PROCEDURE listaSubastasSinConfirmarGanador
@id_Cliente numeric(18,0),
@Fecha datetime
AS
BEGIN

  if exists (select O.Codigo_Pub from Oferta O
			join Publicacion P on O.Codigo_Pub = P.Codigo
			where @id_Cliente = P.Usuario)
  begin
	SELECT Oferta.Codigo_Pub,Oferta.Monto,Oferta.Id_Cliente
	FROM 
	(SELECT Ofer.Codigo_Pub,MAX(Ofer.Monto) as Monto 
	from Oferta as Ofer
	inner join Publicacion
	on Ofer.Codigo_Pub = publicacion.Codigo
	where Publicacion.Usuario = @id_Cliente
	and @Fecha>Publicacion.Fecha_Venc
	and Ofer.Con_Ganador = 0
	group by Ofer.Codigo_Pub) AS Tabla
	,Oferta
	WHERE Tabla.Codigo_Pub = Oferta.Codigo_Pub
	AND   Tabla.Monto = Oferta.Monto
  end
  else
  begin
	select Codigo as 'Codigo_Pub', 0 as 'Monto', 0 as 'Id_Cliente'
	from Publicacion
	where @Fecha>Fecha_Venc and Estado <> 4 and @id_Cliente = Usuario
  end
end