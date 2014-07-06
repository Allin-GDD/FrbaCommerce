CREATE PROCEDURE agregarFuncionabilidadAlRol
@Id_Rol numeric(18,0),
@Id_Funcionabilidad int
AS
BEGIN
INSERT INTO Func_Rol(Id_Rol,
Id_Func)
VALUES(@Id_Rol, @Id_Funcionabilidad)
END 
