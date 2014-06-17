create procedure agregarFactura

@Codigo numeric (18,0),
@Precio numeric (18,2),
@Tipo_Pago smallint,
@Nro_Fac numeric (18,0)
AS 
BEGIN
insert into Factura
(
Numero,
Fecha,
Total,
Forma_Pago_Desc,
Pub_Cod
)
VALUES
( @Nro_Fac,
GETDATE(),
@Precio,
@Tipo_Pago,
@Codigo)
eND