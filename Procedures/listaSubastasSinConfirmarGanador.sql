create PROCEDURE listaSubastasSinConfirmarGanador

@id_Cliente numeric(18,0)
AS
BEGIN

SELECT Oferta.Codigo_Pub,Oferta.Monto,Oferta.Id 
FROM 
(SELECT Ofer.Codigo_Pub,MAX(Ofer.Monto) as Monto 
from Oferta as Ofer
inner join Publicacion
on Ofer.Codigo_Pub = publicacion.Codigo
where Publicacion.Id = @id_Cliente
and GETDATE()>Ofer.Fecha
and Ofer.Con_Ganador = 0
group by Ofer.Codigo_Pub) AS Tabla
,Oferta
WHERE Tabla.Codigo_Pub = Oferta.Codigo_Pub
AND   Tabla.Monto = Oferta.Monto
END