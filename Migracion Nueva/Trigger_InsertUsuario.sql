CREATE trigger Trig_Insert_Usuario ON Usuario
AFTER INSERT
AS
BEGIN
DECLARE @Id_Usuario numeric(18,0), @Id_Rol numeric(18,0), @Rol char(1)
SET @Id_Usuario = (Select Id_Usuario From inserted)
SET @Rol = (Select Tipo_Usuario from inserted)

SET @Id_Rol = (CASE @Rol 
				WHEN 'C'THEN 1
				WHEN 'E' THEN 2
				ELSE 3 
				END)
				
INSERT INTO Usuario_Rol VALUES(@Id_Usuario, @Id_Rol)
END
