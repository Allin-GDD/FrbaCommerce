CREATE PROCEDURE darDeAltaUsuario
@UsuarioName nvarchar(50),
@Password nvarchar(64),
@IdRol numeric(18,0),
@Estado int,
@Intentos int
AS
BEGIN
INSERT INTO Usuario(Usuario,Rol_Usuario,Password,Estado,Intentos,Baja)
VALUES(@UsuarioName,@IdRol,@Password,@Estado,@Intentos,1)
END
