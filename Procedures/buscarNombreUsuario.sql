CREATE PROCEDURE buscarNombreUsuario
@IdUsuario numeric(18,0),
@TipoUsuario char(1)
AS
BEGIN
SELECT Usuario FROM Usuario
WHERE @TipoUsuario = Tipo_Usuario AND
@IdUsuario = Id_Usuario
END