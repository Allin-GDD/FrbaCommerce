CREATE PROCEDURE agregarNuevoRol
@Rol_Nombre nvarchar(max)
AS
BEGIN
INSERT Rol(Nombre)
VALUES(@Rol_Nombre)
END