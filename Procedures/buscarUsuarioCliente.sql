CREATE PROCEDURE buscarUsuarioCliente
@Codigo numeric(18,0)
AS
BEGIN
	SELECT usuario FROM Usuario
		WHERE 
		Id_Usuario = @Codigo
		and Id_Rol = 1
END