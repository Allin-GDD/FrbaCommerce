CREATE PROCEDURE darDeAltaUsuario
@Usuario nvarchar(50),
@Password nvarchar(64),
@IdUsuario numeric(18,0),
@IdRol numeric(18,0),
@Estado int,
@Intentos int
AS
BEGIN
INSERT INTO Usuario(Usuario,Password,Id_Usuario,Id_Rol,Estado,Intentos)
VALUES(@Usuario,@Password,@IdUsuario,@IdRol,@Estado,@Intentos)
END
