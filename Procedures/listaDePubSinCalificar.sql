CREATE PROCEDURE  listaDePubSinCalificar

@id_Cliente numeric (18,0)

AS
	BEGIN
		SELECT * FROM Compra
		
		WHERE Id_Cliente = @id_Cliente
		and Calificacion_Codigo = 0
		
				order by Fecha
	END