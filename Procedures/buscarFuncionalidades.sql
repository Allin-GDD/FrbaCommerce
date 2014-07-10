CREATE PROCEDURE buscarFuncionalidades
@rol nvarchar(50)
AS
BEGIN
SELECT FR.id_Func from Func_Rol FR 
INNER JOIN Rol R ON FR.id_Rol = R.Id 
WHERE 
R.Nombre = @rol
END

select *from Func_Rol

select *from Funcionalidades