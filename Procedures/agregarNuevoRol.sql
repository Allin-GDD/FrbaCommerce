CREATE PROCEDURE agregarNuevoRol
@Rol_Nombre nvarchar(30)
AS
DECLARE @Id_Rol numeric(18,0)
BEGIN
INSERT Rol(Nombre, Estado, Baja)
VALUES(@Rol_Nombre, 1,1)
END