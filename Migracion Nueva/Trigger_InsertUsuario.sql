CREATE trigger Trig_Insert_Usuario ON Usuario
AFTER INSERT
AS
BEGIN
DECLARE @Id_Usuario numeric(18,0), @Id_Rol numeric(18,0)
SET @Id_Usuario = (Select Id_Usuario From inserted)

INSERT INTO Usuario_Rol
END