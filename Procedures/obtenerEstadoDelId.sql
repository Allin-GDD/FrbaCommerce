CREATE PROCEDURE obtenerEstadoDelId
@Id numeric (18,0),
@Rol numeric (18,0)
AS
BEGIN
SELECT estado from Usuario 
where Id_Usuario = @Id
AND Id_Rol = @Rol
END