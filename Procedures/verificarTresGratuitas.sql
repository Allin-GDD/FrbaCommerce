CREATE PROCEDURE verificarTresGratuitas
@Id numeric(18,0),
@Publicador nvarchar(1)
AS
BEGIN
SELECT COUNT(Visibilidad_Cod) from Publicacion
WHERE Id = @Id AND Publicador = @Publicador AND Visibilidad_Cod = 10006 AND Codigo > 68380 AND Estado = 'Publicada'
END