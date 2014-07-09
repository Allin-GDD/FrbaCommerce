--Carga Tabla Tipos de Documentos
INSERT INTO Tipo_DOC VALUES (1,'DNI')
INSERT INTO Tipo_Doc VALUES (2,'CUIT')
INSERT INTO Tipo_Doc VALUES (3,'LE')
INSERT INTO Tipo_Doc VALUES (4,'LC')
INSERT INTO Tipo_Doc VALUES (5,'PAS')

 --carga tabla rol
INSERT INTO rol VALUES ('Cliente',1)
INSERT INTO rol VALUES ('Empresa',1)
INSERT INTO rol VALUES ('Admin',1)

--Carga Tabla Tipos de Pago
INSERT INTO Tipo_Pago VALUES (1,'Efectivo')
INSERT INTO Tipo_Pago VALUES (2,'Tarjeta de crédito')
INSERT INTO Tipo_Pago VALUES (3,'Tarjeta de débito')
INSERT INTO Tipo_Pago VALUES (4,'Transferencia')
INSERT INTO Tipo_Pago VALUES (5,'Depósito bancario')

--migracion tabla usuario
insert into Usuario
select distinct m.Cli_Mail,r.Id,Convert(nvarchar,m.Cli_Dni),10,0,1
from gd_esquema.Maestra M, Rol r
where m.Cli_Dni IS NOT NULL
AND r.Nombre = 'Cliente'
 union all
select distinct m.Publ_Empresa_Mail,rol.id,m.Publ_Empresa_Cuit,10,0,1
from gd_esquema.Maestra m,rol
where rol.nombre = 'Empresa' AND
Publ_Empresa_Cuit is not null
 
-- Migracion tabla cliente

insert into Clientes 
select distinct u.Id_Usuario ,CONVERT(nvarchar,M.Cli_Dni) as dni,1,cli_nombre, cli_apeliido , Cli_Fecha_Nac,
Cli_Mail,cli_dom_calle,cli_nro_calle,Cli_Piso,Cli_Depto,Cli_Cod_Postal,'',''
FROM gd_esquema.Maestra M INNER JOIN Usuario U ON CONVERT(nvarchar,M.Cli_Dni) = u.password
WHERE Cli_Dni IS NOT NULL

-- Migracion tabla empresa

insert into Empresa

select distinct u.Id_Usuario,'',Publ_Empresa_Razon_Social,Publ_Empresa_Cuit,2,Publ_Empresa_Fecha_Creacion,
		Publ_Empresa_Mail,Publ_Empresa_Dom_Calle,Publ_Empresa_Nro_Calle,
		Publ_Empresa_Piso,Publ_Empresa_Depto,Publ_Empresa_Cod_Postal,'','',''
		
from gd_esquema.Maestra INNER JOIN Usuario U ON Publ_Empresa_Cuit = u.password

where Publ_Empresa_Cuit is not null



-- Migracion tabla rubro

insert into Rubro

select distinct Publicacion_Rubro_Descripcion
from gd_esquema.Maestra

where Publicacion_Rubro_Descripcion is not null


-- Migracion tabla visibilidad

insert into Visibilidad

select distinct Publicacion_Visibilidad_Cod,Publicacion_Visibilidad_Desc,Publicacion_Visibilidad_Precio,Publicacion_Visibilidad_Porcentaje,1,7
from gd_esquema.Maestra

where Publicacion_Visibilidad_Cod is not null

-- Migracion tabla publicacion

insert into Publicacion
select distinct Publicacion_Cod,Publicacion_Descripcion,Publicacion_Stock,
Publicacion_Fecha,Publicacion_Fecha_Venc,Publicacion_Precio,Publicacion_Tipo,
Publicacion_Visibilidad_Cod,Publicacion_Estado,Codigo,'C',0,Clientes.Id_Cliente
from gd_esquema.Maestra,Rubro, Clientes
where Publicacion_Cod is not null
and Publ_Cli_Dni is not null
and CONVERT(nvarchar,Publ_Cli_Dni) = Clientes.Nro_Documento
and Publicacion_Rubro_Descripcion = Rubro.Descripcion
UNION ALL
select distinct Publicacion_Cod,Publicacion_Descripcion,Publicacion_Stock,
Publicacion_Fecha,Publicacion_Fecha_Venc,Publicacion_Precio,Publicacion_Tipo,
Publicacion_Visibilidad_Cod,Publicacion_Estado,Codigo,'E',0,Empresa.Id_Empresa
from gd_esquema.Maestra,Rubro, Empresa
where Publicacion_Cod is not null
and Publ_Empresa_Cuit  is not null
and Publ_empresa_cuit = empresa.Nro_Documento
and Publicacion_Rubro_Descripcion = Rubro.Descripcion


-- migracion tabla factura

insert into Factura

select distinct Factura_Nro,factura_Fecha,Factura_Total,1,publicacion_cod from gd_esquema.Maestra

where Factura_Nro is not null
-- and publicacion_cod is not null





-- migracion tabla item_factura

insert into Item_Factura

select  Publicacion_Cod,Factura_Nro,Item_Factura_Monto,Item_Factura_Cantidad

from gd_esquema.Maestra

where Factura_Nro is not null



-- migracion tabla compra
insert into Compra

select distinct Publicacion_Cod,Clientes.Id_Cliente,Compra_Fecha,Compra_Cantidad,Calificacion_Codigo,
 Calificacion_Cant_Estrellas/2,Calificacion_Descripcion

from gd_esquema.Maestra, Clientes

where CONVERT(nvarchar,Publ_Cli_Dni) = Clientes.Nro_Documento
and Publicacion_Cod is not null
and Calificacion_Codigo is not null
and Compra_Fecha is not null
and Compra_Cantidad is not null

-- migracion tabla oferta

insert into Oferta

select distinct Publicacion_Cod,Oferta_Fecha,Oferta_Monto,Clientes.Id_Cliente,1

from gd_esquema.Maestra, Clientes


where CONVERT(nvarchar,Publ_Cli_Dni) = Clientes.Nro_Documento
and Publicacion_Cod is not null
and Clientes.Id_Cliente is not null
and oferta_fecha is not null

--cargar tabla funcionabilidades
insert into Funcionalidades values(1,'Ejecutar ABM Cliente');
insert into Funcionalidades values(2,'Ejecutar ABM Empresa');
insert into Funcionalidades values(3,'Ejecutar ABM Rol');
insert into Funcionalidades values(4,'Ejecutar ABM Visibilidad');
insert into Funcionalidades values(5,'Cambiar contraseña a los usuarios');
insert into Funcionalidades values(6,'Mostrar listado estadístico');

insert into Funcionalidades values(10,'Publicar subasta');
insert into Funcionalidades values(11,'Publicar compra inmediata');
insert into Funcionalidades values(12,'Facturar publicaciones');
insert into Funcionalidades values(13,'Mostrar historial');
insert into Funcionalidades values(14,'Calificar Vendedor');
insert into Funcionalidades values(15,'Ejecutar gestor de preguntas');
insert into Funcionalidades values(16,'Cambiar contraseña');
insert into Funcionalidades values(17,'Comprar');
insert into Funcionalidades values(18,'Subasta');
--cargar tabla funcionabilidades
--Lo que hace el admin
INSERT INTO Func_Rol VALUES(3,1)
INSERT INTO Func_Rol VALUES(3,2)
INSERT INTO Func_Rol VALUES(3,3)
INSERT INTO Func_Rol VALUES(3,4)
INSERT INTO Func_Rol VALUES(3,5)
INSERT INTO Func_Rol VALUES(3,6)
--Lo que hace el cliente
INSERT INTO Func_Rol VALUES(1,10)
INSERT INTO Func_Rol VALUES(1,11)
INSERT INTO Func_Rol VALUES(1,12)
INSERT INTO Func_Rol VALUES(1,14)
INSERT INTO Func_Rol VALUES(1,15)
INSERT INTO Func_Rol VALUES(1,16)
INSERT INTO Func_Rol VALUES(1,17)
INSERT INTO Func_Rol VALUES(1,18)
--Lo que hace una empresa
INSERT INTO Func_Rol VALUES(2,10)
INSERT INTO Func_Rol VALUES(2,11)
INSERT INTO Func_Rol VALUES(2,12)
INSERT INTO Func_Rol VALUES(2,15)
INSERT INTO Func_Rol VALUES(2,16)

--Administrador
INSERT INTO Usuario VALUES(
'admin',3,'781b2694e28e47c7664253f49183aed409c96bd439600f113befdaeede93eae6',1,0,1)
