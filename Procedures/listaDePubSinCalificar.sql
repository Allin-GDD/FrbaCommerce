create PROCEDURE  listaDePubSinCalificar

@id_Cliente numeric (18,0)

AS
	BEGIN
		SELECT * FROM Compra join Calificacion on Cod_Calificacion=Calificacion_Codigo
		
		
		WHERE Id_Cliente = @id_Cliente
		and Cant_Estrellas = 0
		
				order by Fecha
	END