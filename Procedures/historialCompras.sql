CREATE PROCEDURE historialCompras
		@Id nvarchar(30)
	AS
	BEGIN
		SELECT * FROM Compra
			WHERE
				Id_Cliente = @Id
			order by Fecha
	END