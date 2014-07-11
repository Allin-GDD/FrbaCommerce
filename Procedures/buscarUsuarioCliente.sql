create PROCEDURE buscarUsuarioCliente
@Id numeric(18,0)
AS
BEGIN
	SELECT usuario FROM Usuario
		WHERE 
		@Id =Id_Usuario
		and Tipo_usuario = 'C'
END