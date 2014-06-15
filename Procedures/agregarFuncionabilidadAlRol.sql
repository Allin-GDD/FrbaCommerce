CREATE PROCEDURE agregarFuncionabilidadAlRol
@Id_Rol numeric(18,0),
@Id_Funcionabilidad int
AS
BEGIN
INSERT INTO Funcionalidades(Id_Rol,
Id_Funcionalidad)
VALUES(@Id_Rol, @Id_Funcionabilidad)
END 
