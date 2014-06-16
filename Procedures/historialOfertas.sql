CREATE PROCEDURE historialOfertas
		@Id nvarchar(30)
	AS
	BEGIN
		SELECT * FROM Oferta
			WHERE
				Id = @Id
			order by Fecha
	END