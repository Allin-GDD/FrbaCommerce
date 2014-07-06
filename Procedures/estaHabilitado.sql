CREATE PROCEDURE estaHabilitado
@Id numeric (18,0)
AS
BEGIN
SELECT estado from Usuario 
where Id_Usuario = @Id
END