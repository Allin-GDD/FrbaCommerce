CREATE PROCEDURE listaDeEmpresas
@Razon_Social nvarchar(255),
@CUIT nvarchar(50),
@Mail nvarchar(50),
@TipoDoc nvarchar(1)
AS
BEGIN
SELECT e.Id_Usuario, e.Nombre_Contacto, e.Razon_Social as 'Razón Social', e.Nro_Documento as 'Nro de Documento', TD.Nombre as 'Tipo de documento', e.Fecha_Creacion as 'Fecha de Creación',e.Mail,
e.Dom_Calle as 'Domicilio', e.Nro_Calle as 'Nro domicilio',e.Piso,e.Depto, e.Cod_Postal,e.Localidad, e.Ciudad, e.Telefono FROM Empresa e
INNER JOIN Tipo_Doc TD ON e.Tipo_Doc = TD.Codigo
WHERE
Razon_Social LIKE '%'+@Razon_Social+'%' AND
Mail LIKE '%'+@Mail+'%' AND
(@CUIT = [Nro_Documento] or @CUIT = '' or @CUIT = '  -        -')
AND Nro_Documento <> '0'
AND ((E.Tipo_Doc = @TipoDoc AND @TipoDoc <> 0)OR @TipoDoc = 0)
END
