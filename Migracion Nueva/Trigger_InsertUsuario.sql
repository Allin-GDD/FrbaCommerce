Create trigger Trig_Insert_Usuario ON Usuario
AFTER INSERT
AS
BEGIN
INSERT INTO Roles
Select Id_Usuario, Rol_Usuario From inserted
END