USE [GD1C2014]
GO
/****** Object:  Table [dbo].[Visibilidad]    Script Date: 06/15/2014 17:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visibilidad](
	[Codigo] [numeric](18, 0) NOT NULL,
	[Descripcion] [nvarchar](255) NULL,
	[Precio] [numeric](18, 2) NULL,
	[Porcentaje] [numeric](18, 2) NULL,
	[Estado] [smallint] NOT NULL,
	[Vencimiento] [smallint] NOT NULL,
 CONSTRAINT [PK_Visibilidad] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 06/15/2014 17:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Usuario] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](64) NOT NULL,
	[Id_Usuario] [numeric](18, 0) NOT NULL,
	[Id_Rol] [numeric](18, 0) NOT NULL,
	[Estado] [smallint] NOT NULL,
	[Intentos] [smallint] NOT NULL,
	[Baja] [smallint] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Doc]    Script Date: 06/15/2014 17:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Doc](
	[Codigo] [smallint] NOT NULL,
	[Nombre] [nvarchar](255) NULL,
 CONSTRAINT [PK_Tipo_Doc] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rubro]    Script Date: 06/15/2014 17:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rubro](
	[Codigo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](255) NULL,
 CONSTRAINT [PK_Rubro] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 06/15/2014 17:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Estado] [smallint] NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 06/15/2014 17:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Codigo_Pub] [numeric](18, 0) NOT NULL,
	[Id_Cliente] [numeric](18, 0) NOT NULL,
	[Fecha] [datetime] NULL,
	[Cantidad] [numeric](18, 0) NULL,
	[Calificacion_Codigo] [numeric](18, 0) NOT NULL,
	[Calificacion_Cant_Estrellas] [numeric](18, 0) NULL,
	[Calificaciones_Descripcion] [nvarchar](255) NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 06/15/2014 17:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Razon_Social] [nvarchar](255) NOT NULL,
	[Cuit] [nvarchar](50) NOT NULL,
	[Fecha_Creacion] [datetime] NULL,
	[Mail] [nvarchar](50) NULL,
	[Dom_Calle] [nvarchar](100) NULL,
	[Nro_Calle] [numeric](18, 0) NULL,
	[Piso] [numeric](18, 0) NULL,
	[Depto] [nvarchar](50) NULL,
	[Cod_Postal] [nvarchar](50) NULL,
	[Localidad] [nvarchar](255) NULL,
	[Telefono] [nvarchar](255) NULL,
	[Ciudad] [nvarchar](255) NULL,
	[Nombre_Contacto] [nvarchar](255) NULL,
	[Tipo] [smallint] NOT NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 06/15/2014 17:15:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Dni] [numeric](18, 0) NOT NULL,
	[Nombre] [nvarchar](255) NULL,
	[Apellido] [nvarchar](255) NULL,
	[Fecha_Nac] [datetime] NULL,
	[Mail] [nvarchar](255) NULL,
	[Dom_Calle] [nvarchar](255) NULL,
	[Nro_Calle] [numeric](18, 0) NULL,
	[Piso] [numeric](18, 0) NULL,
	[Depto] [nvarchar](50) NULL,
	[Cod_Postal] [nvarchar](50) NULL,
	[Localidad] [nvarchar](255) NULL,
	[Tipo_dni] [smallint] NOT NULL,
	[Telefono] [nvarchar](255) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcionalidades]    Script Date: 06/15/2014 17:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionalidades](
	[Id_Rol] [numeric](18, 0) NOT NULL,
	[Id_Funcionalidad] [smallint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publicacion]    Script Date: 06/15/2014 17:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publicacion](
	[Codigo] [numeric](18, 0) NOT NULL,
	[Descripcion] [nvarchar](255) NULL,
	[Stock] [numeric](18, 0) NULL,
	[Fecha] [datetime] NULL,
	[Fecha_Venc] [datetime] NULL,
	[Precio] [numeric](18, 2) NULL,
	[Tipo] [nvarchar](255) NULL,
	[Visibilidad_Cod] [numeric](18, 0) NULL,
	[Estado] [nvarchar](255) NULL,
	[Rubro_Cod] [numeric](18, 0) NULL,
	[Publicador] [nvarchar](1) NOT NULL,
	[Preguntas_permitidas] [bit] NULL,
	[Id] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Publicacion_1] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oferta]    Script Date: 06/15/2014 17:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oferta](
	[Codigo_Pub] [numeric](18, 0) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Monto] [numeric](18, 2) NOT NULL,
	[Id] [numeric](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 06/15/2014 17:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[Numero] [numeric](18, 0) NOT NULL,
	[Fecha] [datetime] NULL,
	[Total] [numeric](18, 2) NULL,
	[Forma_Pago_Desc] [nvarchar](255) NULL,
	[Pub_Cod] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[Numero] ASC,
	[Pub_Cod] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item_Factura]    Script Date: 06/15/2014 17:15:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item_Factura](
	[Codigo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Pub_Cod] [numeric](18, 0) NOT NULL,
	[Nro_Fact] [numeric](18, 0) NOT NULL,
	[Monto] [numeric](18, 2) NULL,
	[Cantidad] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Item_Factura_1] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF__Clientes__Tipo_d__40E497F3]    Script Date: 06/15/2014 17:15:47 ******/
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT ((1)) FOR [Tipo_dni]
GO
/****** Object:  Default [DF__Clientes__Telefo__41D8BC2C]    Script Date: 06/15/2014 17:15:47 ******/
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT ('') FOR [Telefono]
GO
/****** Object:  Default [DF__Empresa__Telefon__42CCE065]    Script Date: 06/15/2014 17:15:47 ******/
ALTER TABLE [dbo].[Empresa] ADD  DEFAULT ('') FOR [Telefono]
GO
/****** Object:  Default [DF__Empresa__Ciudad__43C1049E]    Script Date: 06/15/2014 17:15:47 ******/
ALTER TABLE [dbo].[Empresa] ADD  DEFAULT ('') FOR [Ciudad]
GO
/****** Object:  Default [DF__Empresa__Nombre___44B528D7]    Script Date: 06/15/2014 17:15:47 ******/
ALTER TABLE [dbo].[Empresa] ADD  DEFAULT ('') FOR [Nombre_Contacto]
GO
/****** Object:  Default [DF__Empresa__Tipo__45A94D10]    Script Date: 06/15/2014 17:15:47 ******/
ALTER TABLE [dbo].[Empresa] ADD  DEFAULT ((2)) FOR [Tipo]
GO
/****** Object:  Default [DF__Publicaci__Pregu__469D7149]    Script Date: 06/15/2014 17:15:47 ******/
ALTER TABLE [dbo].[Publicacion] ADD  DEFAULT ((0)) FOR [Preguntas_permitidas]
GO
/****** Object:  ForeignKey [FK_Clientes_Tipo_Doc]    Script Date: 06/15/2014 17:15:47 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Tipo_Doc] FOREIGN KEY([Tipo_dni])
REFERENCES [dbo].[Tipo_Doc] ([Codigo])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Tipo_Doc]
GO
/****** Object:  ForeignKey [FK_Empresa_Tipo_Doc]    Script Date: 06/15/2014 17:15:47 ******/
ALTER TABLE [dbo].[Empresa]  WITH CHECK ADD  CONSTRAINT [FK_Empresa_Tipo_Doc] FOREIGN KEY([Tipo])
REFERENCES [dbo].[Tipo_Doc] ([Codigo])
GO
ALTER TABLE [dbo].[Empresa] CHECK CONSTRAINT [FK_Empresa_Tipo_Doc]
GO
/****** Object:  ForeignKey [FK_Factura_Publicacion]    Script Date: 06/15/2014 17:15:47 ******/
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Publicacion] FOREIGN KEY([Pub_Cod])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Publicacion]
GO
/****** Object:  ForeignKey [FK_Funcionalidades_Rol]    Script Date: 06/15/2014 17:15:47 ******/
ALTER TABLE [dbo].[Funcionalidades]  WITH CHECK ADD  CONSTRAINT [FK_Funcionalidades_Rol] FOREIGN KEY([Id_Rol])
REFERENCES [dbo].[Rol] ([Id])
GO
ALTER TABLE [dbo].[Funcionalidades] CHECK CONSTRAINT [FK_Funcionalidades_Rol]
GO
/****** Object:  ForeignKey [FK_Item_Factura_Factura]    Script Date: 06/15/2014 17:15:47 ******/
ALTER TABLE [dbo].[Item_Factura]  WITH CHECK ADD  CONSTRAINT [FK_Item_Factura_Factura] FOREIGN KEY([Nro_Fact], [Pub_Cod])
REFERENCES [dbo].[Factura] ([Numero], [Pub_Cod])
GO
ALTER TABLE [dbo].[Item_Factura] CHECK CONSTRAINT [FK_Item_Factura_Factura]
GO
/****** Object:  ForeignKey [FK_Oferta_Clientes]    Script Date: 06/15/2014 17:15:47 ******/
ALTER TABLE [dbo].[Oferta]  WITH CHECK ADD  CONSTRAINT [FK_Oferta_Clientes] FOREIGN KEY([Id])
REFERENCES [dbo].[Clientes] ([Id])
GO
ALTER TABLE [dbo].[Oferta] CHECK CONSTRAINT [FK_Oferta_Clientes]
GO
/****** Object:  ForeignKey [FK_Oferta_Publicacion]    Script Date: 06/15/2014 17:15:47 ******/
ALTER TABLE [dbo].[Oferta]  WITH CHECK ADD  CONSTRAINT [FK_Oferta_Publicacion] FOREIGN KEY([Codigo_Pub])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[Oferta] CHECK CONSTRAINT [FK_Oferta_Publicacion]
GO
/****** Object:  ForeignKey [FK_Publicacion_Rubro]    Script Date: 06/15/2014 17:15:47 ******/
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Rubro] FOREIGN KEY([Rubro_Cod])
REFERENCES [dbo].[Rubro] ([Codigo])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Rubro]
GO
/****** Object:  ForeignKey [FK_Publicacion_Visibilidad]    Script Date: 06/15/2014 17:15:47 ******/
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Visibilidad] FOREIGN KEY([Visibilidad_Cod])
REFERENCES [dbo].[Visibilidad] ([Codigo])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Visibilidad]
GO




--Carga Tabla Tipos de Documentos
INSERT INTO Tipo_DOC VALUES (1,'DNI')
INSERT INTO Tipo_Doc VALUES (2,'CUIT')

-- Migracion tabla cliente

insert into Clientes 

Select distinct Dni,Nombre,Apellido,Nacimiento,Mail,Calle,Numero,Piso,Depto,Postal,'',1,''
From
(select cli_dni as Dni,cli_nombre as Nombre,cli_apeliido as Apellido,
		Cli_Fecha_Nac as Nacimiento,Cli_Mail as Mail,
		cli_dom_calle as Calle,cli_nro_calle as Numero,
		Cli_Piso as Piso,Cli_Depto as Depto,Cli_Cod_Postal as Postal
from gd_esquema.Maestra
where Cli_Dni is not null
union all
select publ_cli_dni as Dni,publ_cli_nombre as Nombre,publ_cli_apeliido as Apellido,
		publ_Cli_Fecha_Nac as Nacimiento,Publ_Cli_Mail as Mail,
		publ_cli_dom_calle as Calle,Publ_Cli_Nro_Calle as Numero,
		pubL_Cli_Piso as Piso,publ_Cli_Depto as Depto,publ_Cli_Cod_Postal as Postal
from gd_esquema.Maestra
where Publ_Cli_Dni is not null) as tabla


-- Migracion tabla empresa

insert into Empresa

select distinct Publ_Empresa_Razon_Social,Publ_Empresa_Cuit,Publ_Empresa_Fecha_Creacion,
		Publ_Empresa_Mail,Publ_Empresa_Dom_Calle,Publ_Empresa_Nro_Calle,
		Publ_Empresa_Piso,Publ_Empresa_Depto,Publ_Empresa_Cod_Postal,'','','','',2 
		
from gd_esquema.Maestra

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
Publicacion_Visibilidad_Cod,Publicacion_Estado,Codigo,'C',0,Clientes.Id
from gd_esquema.Maestra,Rubro, Clientes
where Publicacion_Cod is not null
and Publ_Cli_Dni is not null
and Publ_Cli_Dni = Clientes.Dni
and Publicacion_Rubro_Descripcion = Rubro.Descripcion
UNION ALL
select distinct Publicacion_Cod,Publicacion_Descripcion,Publicacion_Stock,
Publicacion_Fecha,Publicacion_Fecha_Venc,Publicacion_Precio,Publicacion_Tipo,
Publicacion_Visibilidad_Cod,Publicacion_Estado,Codigo,'E',0,Empresa.Id
from gd_esquema.Maestra,Rubro, Empresa
where Publicacion_Cod is not null
and Publ_Empresa_Cuit  is not null
and Publ_empresa_cuit = empresa.Cuit 
and Publicacion_Rubro_Descripcion = Rubro.Descripcion


-- migracion tabla factura

insert into Factura

select distinct Factura_Nro,factura_Fecha,Factura_Total,Forma_Pago_Desc,publicacion_cod from gd_esquema.Maestra

where Factura_Nro is not null
-- and publicacion_cod is not null





-- migracion tabla item_factura

insert into Item_Factura

select  Publicacion_Cod,Factura_Nro,Item_Factura_Monto,Item_Factura_Cantidad

from gd_esquema.Maestra

where Factura_Nro is not null



-- migracion tabla compra
insert into Compra

select distinct Publicacion_Cod,Clientes.id,Compra_Fecha,Compra_Cantidad,Calificacion_Codigo,
 Calificacion_Cant_Estrellas,Calificacion_Descripcion

from gd_esquema.Maestra, Clientes

where Cli_Dni= Clientes.dni
and Publicacion_Cod is not null
and Calificacion_Codigo is not null
and Compra_Fecha is not null
and Compra_Cantidad is not null

-- migracion tabla oferta

insert into Oferta

select distinct Publicacion_Cod,Oferta_Fecha,Oferta_Monto,Clientes.id

from gd_esquema.Maestra, Clientes


where cli_dni = clientes.dni
and Publicacion_Cod is not null
and Clientes.Id is not null
and oferta_fecha is not null

-- no va mas
		
-- migracion tabla calificacion

--insert into Calificacion
--select Calificacion_Codigo,clientes.id,Calificacion_Cant_Estrellas,Calificacion_Descripcion,Publicacion_Cod
--from gd_esquema.Maestra, clientes
--where cli_dni= clientes.dni
--and Calificacion_Codigo is not null
--and publicacion_cod is not null

--migracion tabla usuario

insert into Usuario
select distinct clientes.Mail,convert(nvarchar,Clientes.Dni),clientes.Id,rol.id,1,0,1
 from Clientes,rol
 where rol.nombre = 'Cliente'
 

union all
 select distinct Empresa.Mail,Empresa.Cuit,Empresa.Id,rol.id,1,0,1
 from Empresa,rol
 where rol.nombre = 'Empresa'

 --carga tabla rol
INSERT INTO rol VALUES ('Cliente',1)
INSERT INTO rol VALUES ('Empresa',1)
INSERT INTO rol VALUES ('Admin',1)


--cargar tabla funcionabilidades
INSERT INTO Funcionalidades VALUES(1,1)
INSERT INTO Funcionalidades VALUES(1,2)
INSERT INTO Funcionalidades VALUES(2,1)

-- no va mas
		
-- migracion tabla calificacion

--insert into Calificacion
--select Calificacion_Codigo,clientes.id,Calificacion_Cant_Estrellas,Calificacion_Descripcion,Publicacion_Cod
--from gd_esquema.Maestra, clientes
--where cli_dni= clientes.dni
--and Calificacion_Codigo is not null
--and publicacion_cod is not null


