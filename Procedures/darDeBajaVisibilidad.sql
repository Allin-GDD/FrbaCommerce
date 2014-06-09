CREATE PROCEDURE darDeBajavISIBILIDAD
@Codigo numeric(18,0)
AS
BEGIN
UPDATE Visibilidad
SET Estado = 0
WHERE Codigo = @Codigo
END
