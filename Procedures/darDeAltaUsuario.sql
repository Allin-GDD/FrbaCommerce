CREATE PROCEDURE darDeAltaUsuario
@UsuarioName nvarchar(50),
@Password nvarchar(64),
@IdRol numeric(18,0),
@Estado int,
@Intentos int
AS
BEGIN
INSERT INTO Usuario(Usuario,Password,Rol_Usuario,Estado,Intentos,Baja)
VALUES(@UsuarioName,@Password,@IdRol,@Estado,@Intentos,1)
END
