CREATE PROCEDURE verificarTresGratuitas
@Usuario numeric(18,0)
AS
BEGIN
SELECT COUNT(Visibilidad_Cod) from Publicacion
WHERE Usuario = @Usuario AND Visibilidad_Cod = 10006 AND Codigo > 68380 AND Estado = 'Publicada'
END