create PROCEDURE listaSubastasSinConfirmarGanador
@id_Cliente numeric(18,0),
@Fecha datetime
AS
BEGIN

SELECT Oferta.Codigo_Pub,Oferta.Monto,Oferta.Id_Cliente
FROM 
(SELECT Ofer.Codigo_Pub,MAX(Ofer.Monto) as Monto 
from Oferta as Ofer
inner join Publicacion
on Ofer.Codigo_Pub = publicacion.Codigo
where Publicacion.Usuario = @id_Cliente
and @Fecha>Ofer.Fecha
and Ofer.Con_Ganador = 0
group by Ofer.Codigo_Pub) AS Tabla
,Oferta
WHERE Tabla.Codigo_Pub = Oferta.Codigo_Pub
AND   Tabla.Monto = Oferta.Monto
END