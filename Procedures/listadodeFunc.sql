CREATE PROCEDURE listadodeFunc
@Id_Rol numeric(18,0)
AS
BEGIN
IF(@Id_Rol = 0)
BEGIN
SELECT f.id_funcionabilidad as 'ID', f.nom_funcionalidad as 'Nombre' FROM Funcionalidades f 
END
ELSE
BEGIN
SELECT f.id_funcionabilidad as 'ID', f.nom_funcionalidad as 'Nombre' FROM Funcionalidades f 
INNER JOIN Func_Rol fr ON f.id_funcionabilidad = fr.id_Func
WHERE fr.id_Rol = @Id_Rol
END
END

select * from Rol
exec listadodeFunc 12