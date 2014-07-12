CREATE PROCEDURE agregarNuevoRol
@Rol_Nombre nvarchar(30),
@Id_Func int
AS
DECLARE @Id_Rol numeric(18,0)
BEGIN
INSERT Rol(Nombre, Estado, Baja)
VALUES(@Rol_Nombre, 1,1)

SELECT @Id_Rol = Id FROM Rol WHERE @Rol_Nombre = Nombre
INSERT Func_Rol(id_Func,id_Rol)
VALUES (@Id_Func, @Id_Rol)
END