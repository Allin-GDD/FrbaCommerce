CREATE PROCEDURE buscarNombreUsuario
@IdUsuario numeric(18,0),
@IdRol numeric(18,0)
AS
BEGIN
SELECT Usuario FROM Usuario
WHERE @IdRol = Id_Rol AND
@IdUsuario = Id_Usuario
END