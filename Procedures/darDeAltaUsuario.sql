CREATE PROCEDURE darDeAltaUsuario
@Usuario nvarchar(50),
@Password nvarchar(50),
@IdUsuario numeric(18,0),
@IdRol numeric(18,0),
@Estado smallint
AS
BEGIN
INSERT INTO Usuario(Usuario,Password,Id_Usuario,Id_Rol,Estado)
VALUES(@Usuario,@Password,@IdUsuario,@IdRol,@Estado)
END
