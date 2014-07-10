CREATE procedure agregarItemFacturaPublicacion
@Codigo numeric (18,0),
@Precio numeric (18,2),
@Nro_Fact numeric (18,2),
@Cant numeric (18,0)

AS 
BEGIN
insert into Item_FacturaPublicacion
(Pub_Cod,
Nro_Fact,
Monto,
Cantidad
)
VALUES
( @Codigo,
@Nro_Fact,
@Precio,
@Cant)
eND