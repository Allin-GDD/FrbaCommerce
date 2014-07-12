create PROCEDURE buscarUnSoloCliente
@Id numeric(18,0)
AS
BEGIN
	SELECT  u.Usuario,c.Nro_Documento, c.Nombre, c.Apellido, c.Fecha_Nac, c.Mail, c.Dom_Calle,
	c.Nro_Calle, c.Piso, c.Depto, c.Cod_Postal, c.Localidad,t.Nombre,c.Telefono FROM Clientes c 
	INNER JOIN Tipo_Doc t ON t.Codigo = c.Tipo_Doc
	join Usuario u on c.Id_Usuario = u.Id_Usuario
		WHERE 
		c.Id_Usuario = @Id;
END