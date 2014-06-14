create PROCEDURE buscarUsuarioEmpresa
@Id numeric(18,0)
AS
BEGIN
	SELECT usuario FROM Usuario
		WHERE 
		@Id =Id_Usuario
		and Id_Rol = 2
END