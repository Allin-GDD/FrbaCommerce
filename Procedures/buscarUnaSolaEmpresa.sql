 CREATE PROCEDURE buscarUnaSolaEmpresa
@Id numeric (18,0)
AS 
BEGIN
SELECT e.Razon_Social, e.Nro_Documento, e.Fecha_Creacion, e.Mail, e.Dom_Calle,
 e.Nro_Calle, e.Piso, e.Depto, e.Cod_Postal, e.Localidad, e.Telefono, e.Ciudad, e.Nombre_Contacto FROM Empresa e
 join Usuario u on u.Id_Usuario = e.Id_Usuario
WHERE e.Id_Usuario = @Id
END