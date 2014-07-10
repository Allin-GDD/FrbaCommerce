CREATE procedure agregarItemFacturaComision

@Codigo numeric (18,0),
@Precio numeric (18,2),
@Nro_Fact numeric (18,2)

AS 
BEGIN
insert into Item_FacturaComision
(Pub_Cod,
Nro_Fact,
Monto
)
VALUES
( @Codigo,
@Nro_Fact,
@Precio)
eND