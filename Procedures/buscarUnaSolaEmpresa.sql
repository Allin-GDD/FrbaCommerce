CREATE PROCEDURE buscarUnaSolaEmpresa
@Id numeric (18,0)
AS 
BEGIN
SELECT e.Razon_Social, e.Nro_Documento, e.Fecha_Creacion, e.Mail, e.Dom_Calle,
 e.Nro_Calle, e.Piso, e.Depto, e.Cod_Postal, e.Localidad, e.Telefono, e.Ciudad, e.Nombre_Contacto, t.Nombre FROM Empresa e
 INNER JOIN Tipo_Doc t ON e.Tipo_Doc = t.Codigo 
WHERE Id_Usuario = @Id
END