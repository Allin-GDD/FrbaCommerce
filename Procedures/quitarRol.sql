CREATE PROCEDURE quitarRol
@Id_Rol int,
@funcionalidad int
AS
BEGIN
DELETE Funcionabilidades
WHERE Id_Rol = @Id_Rol AND
Id_Funcionabilidad = @funcionalidad
END

exec quitarRol 1,1
Select *from Funcionabilidades