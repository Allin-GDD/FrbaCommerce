CREATE PROCEDURE obtenerTodosLosRoles
@Id_Usuario numeric(18,0)
AS
BEGIN
SELECT UR.Id_Rol, r.Nombre From Usuario_Rol UR 
INNER JOIN Rol R ON R.Id = UR.Id_Rol 

WHERE UR.Id_Usuario = @Id_Usuario
AND r.Estado <> 0
AND r.Baja <> 0
END

