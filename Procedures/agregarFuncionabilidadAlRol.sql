CREATE PROCEDURE agregarFuncionabilidadAlRol
@Id_Rol numeric(18,0),
@Id_Funcionabilidad int
AS
BEGIN
INSERT INTO Funcionabilidades(Id_Rol,
Id_Funcionabilidad)
VALUES(@Id_Rol, @Id_Funcionabilidad)
END 
