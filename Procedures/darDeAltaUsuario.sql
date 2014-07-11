CREATE PROCEDURE darDeAltaUsuario
@UsuarioName nvarchar(50),
@Password nvarchar(64),
@Rol numeric(18,0),
@Estado int,
@Intentos int
AS
BEGIN
DECLARE @Tipo_User char(1)

SET @Tipo_User = (CASE @Rol 
				WHEN 1 THEN 'C'
				WHEN 2 THEN 'E'
				ELSE 'A' 
				END)


INSERT INTO Usuario(Usuario,Tipo_Usuario,Password,Estado,Intentos,Baja)
VALUES(@UsuarioName,@Tipo_User,@Password,@Estado,@Intentos,1)
END

