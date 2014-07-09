USE [GD1C2014]
GO
/****** Object:  User [gd]    Script Date: 07/09/2014 12:44:52 ******/
CREATE USER [gd] FOR LOGIN [gd] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Schema [gd_esquema]    Script Date: 07/09/2014 12:44:52 ******/
CREATE SCHEMA [gd_esquema] AUTHORIZATION [gd]
GO
/****** Object:  Table [gd_esquema].[Maestra]    Script Date: 07/09/2014 12:44:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [gd_esquema].[Maestra](
	[Publ_Cli_Dni] [numeric](18, 0) NULL,
	[Publ_Cli_Apeliido] [nvarchar](255) NULL,
	[Publ_Cli_Nombre] [nvarchar](255) NULL,
	[Publ_Cli_Fecha_Nac] [datetime] NULL,
	[Publ_Cli_Mail] [nvarchar](255) NULL,
	[Publ_Cli_Dom_Calle] [nvarchar](255) NULL,
	[Publ_Cli_Nro_Calle] [numeric](18, 0) NULL,
	[Publ_Cli_Piso] [numeric](18, 0) NULL,
	[Publ_Cli_Depto] [nvarchar](50) NULL,
	[Publ_Cli_Cod_Postal] [nvarchar](50) NULL,
	[Publ_Empresa_Razon_Social] [nvarchar](255) NULL,
	[Publ_Empresa_Cuit] [nvarchar](50) NULL,
	[Publ_Empresa_Fecha_Creacion] [datetime] NULL,
	[Publ_Empresa_Mail] [nvarchar](50) NULL,
	[Publ_Empresa_Dom_Calle] [nvarchar](100) NULL,
	[Publ_Empresa_Nro_Calle] [numeric](18, 0) NULL,
	[Publ_Empresa_Piso] [numeric](18, 0) NULL,
	[Publ_Empresa_Depto] [nvarchar](50) NULL,
	[Publ_Empresa_Cod_Postal] [nvarchar](50) NULL,
	[Publicacion_Cod] [numeric](18, 0) NULL,
	[Publicacion_Descripcion] [nvarchar](255) NULL,
	[Publicacion_Stock] [numeric](18, 0) NULL,
	[Publicacion_Fecha] [datetime] NULL,
	[Publicacion_Fecha_Venc] [datetime] NULL,
	[Publicacion_Precio] [numeric](18, 2) NULL,
	[Publicacion_Tipo] [nvarchar](255) NULL,
	[Publicacion_Visibilidad_Cod] [numeric](18, 0) NULL,
	[Publicacion_Visibilidad_Desc] [nvarchar](255) NULL,
	[Publicacion_Visibilidad_Precio] [numeric](18, 2) NULL,
	[Publicacion_Visibilidad_Porcentaje] [numeric](18, 2) NULL,
	[Publicacion_Estado] [nvarchar](255) NULL,
	[Publicacion_Rubro_Descripcion] [nvarchar](255) NULL,
	[Cli_Dni] [numeric](18, 0) NULL,
	[Cli_Apeliido] [nvarchar](255) NULL,
	[Cli_Nombre] [nvarchar](255) NULL,
	[Cli_Fecha_Nac] [datetime] NULL,
	[Cli_Mail] [nvarchar](255) NULL,
	[Cli_Dom_Calle] [nvarchar](255) NULL,
	[Cli_Nro_Calle] [numeric](18, 0) NULL,
	[Cli_Piso] [numeric](18, 0) NULL,
	[Cli_Depto] [nvarchar](50) NULL,
	[Cli_Cod_Postal] [nvarchar](50) NULL,
	[Compra_Fecha] [datetime] NULL,
	[Compra_Cantidad] [numeric](18, 0) NULL,
	[Oferta_Fecha] [datetime] NULL,
	[Oferta_Monto] [numeric](18, 2) NULL,
	[Calificacion_Codigo] [numeric](18, 0) NULL,
	[Calificacion_Cant_Estrellas] [numeric](18, 0) NULL,
	[Calificacion_Descripcion] [nvarchar](255) NULL,
	[Item_Factura_Monto] [numeric](18, 2) NULL,
	[Item_Factura_Cantidad] [numeric](18, 0) NULL,
	[Factura_Nro] [numeric](18, 0) NULL,
	[Factura_Fecha] [datetime] NULL,
	[Factura_Total] [numeric](18, 2) NULL,
	[Forma_Pago_Desc] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 07/09/2014 12:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[Cod_Estado] [numeric](18, 0) NOT NULL,
	[Nombre] [nvarchar](255) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[Cod_Estado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Calificacion]    Script Date: 07/09/2014 12:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calificacion](
	[Cod_Calificacion] [numeric](18, 0) NOT NULL,
	[Cant_Estrellas] [numeric](18, 0) NOT NULL,
	[Descripcion] [nvarchar](255) NULL,
 CONSTRAINT [PK_Calificacion] PRIMARY KEY CLUSTERED 
(
	[Cod_Calificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Publicacion]    Script Date: 07/09/2014 12:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Publicacion](
	[Cod_Tipo] [numeric](18, 0) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Tipo_Publicacion] PRIMARY KEY CLUSTERED 
(
	[Cod_Tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Pago]    Script Date: 07/09/2014 12:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Pago](
	[Codigo] [numeric](18, 0) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Tipo_Pago] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Doc]    Script Date: 07/09/2014 12:44:51 ******/
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
/****** Object:  Table [dbo].[Rubro]    Script Date: 07/09/2014 12:44:51 ******/
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
/****** Object:  Table [dbo].[Rol]    Script Date: 07/09/2014 12:44:51 ******/
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
/****** Object:  Table [dbo].[Funcionalidades]    Script Date: 07/09/2014 12:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionalidades](
	[id_funcionabilidad] [int] NOT NULL,
	[nom_funcionalidad] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_funcionabilidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visibilidad]    Script Date: 07/09/2014 12:44:51 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 07/09/2014 12:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id_Usuario] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[Rol_Usuario] [numeric](18, 0) NOT NULL,
	[Password] [nvarchar](64) NOT NULL,
	[Estado] [smallint] NOT NULL,
	[Intentos] [smallint] NOT NULL,
	[Baja] [smallint] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Func_Rol]    Script Date: 07/09/2014 12:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Func_Rol](
	[id_Rol] [numeric](18, 0) NOT NULL,
	[id_Func] [int] NOT NULL,
 CONSTRAINT [PK_Func_Rol] PRIMARY KEY CLUSTERED 
(
	[id_Rol] ASC,
	[id_Func] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 07/09/2014 12:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id_Cliente] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Id_Usuario] [numeric](18, 0) NULL,
	[Nro_Documento] [nvarchar](255) NOT NULL,
	[Tipo_Doc] [smallint] NOT NULL,
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
	[Telefono] [nvarchar](255) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 07/09/2014 12:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[Id_Empresa] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Id_Usuario] [numeric](18, 0) NULL,
	[Nombre_Contacto] [nvarchar](255) NULL,
	[Razon_Social] [nvarchar](255) NOT NULL,
	[Nro_Documento] [nvarchar](255) NOT NULL,
	[Fecha_Creacion] [datetime] NULL,
	[Mail] [nvarchar](50) NULL,
	[Dom_Calle] [nvarchar](100) NULL,
	[Nro_Calle] [numeric](18, 0) NULL,
	[Piso] [numeric](18, 0) NULL,
	[Depto] [nvarchar](50) NULL,
	[Cod_Postal] [nvarchar](50) NULL,
	[Localidad] [nvarchar](255) NULL,
	[Ciudad] [nvarchar](255) NULL,
	[Telefono] [nvarchar](255) NULL,
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[Id_Empresa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publicacion]    Script Date: 07/09/2014 12:44:51 ******/
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
	[Tipo] [numeric](18, 0) NOT NULL,
	[Visibilidad_Cod] [numeric](18, 0) NULL,
	[Estado] [numeric](18, 0) NOT NULL,
	[Preguntas_permitidas] [bit] NULL,
	[Usuario] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Publicacion_1] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 07/09/2014 12:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[Numero] [numeric](18, 0) NOT NULL,
	[Fecha] [datetime] NULL,
	[Total] [numeric](18, 2) NULL,
	[Forma_Pago_Desc] [numeric](18, 0) NOT NULL,
	[Pub_Cod] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[Numero] ASC,
	[Pub_Cod] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publicacion_Rubro]    Script Date: 07/09/2014 12:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publicacion_Rubro](
	[id_Publicacion] [numeric](18, 0) NOT NULL,
	[id_Rubro] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Publicacion_Rubro] PRIMARY KEY CLUSTERED 
(
	[id_Publicacion] ASC,
	[id_Rubro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PreguntasYRespuestas]    Script Date: 07/09/2014 12:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreguntasYRespuestas](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[UsuarioPregunta] [numeric](18, 0) NOT NULL,
	[Id_Publicacion] [numeric](18, 0) NOT NULL,
	[Pregunta] [nvarchar](255) NULL,
	[Respuesta] [nvarchar](255) NULL,
	[FechaRespuesta] [datetime] NULL,
 CONSTRAINT [PK_PreguntasYRespuestas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oferta]    Script Date: 07/09/2014 12:44:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oferta](
	[Codigo_Pub] [numeric](18, 0) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Monto] [numeric](18, 2) NOT NULL,
	[Id_Cliente] [numeric](18, 0) NOT NULL,
	[Con_Ganador] [numeric](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 07/09/2014 12:44:51 ******/
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
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item_Factura]    Script Date: 07/09/2014 12:44:51 ******/
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
/****** Object:  ForeignKey [FK_Clientes_Tipo_Doc]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Tipo_Doc] FOREIGN KEY([Tipo_Doc])
REFERENCES [dbo].[Tipo_Doc] ([Codigo])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Tipo_Doc]
GO
/****** Object:  ForeignKey [FK_Clientes_Usuario]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Usuario]
GO
/****** Object:  ForeignKey [FK_Compra_Calificacion]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Calificacion] FOREIGN KEY([Calificacion_Codigo])
REFERENCES [dbo].[Calificacion] ([Cod_Calificacion])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Calificacion]
GO
/****** Object:  ForeignKey [FK_Compra_Clientes]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Clientes] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Clientes] ([Id_Cliente])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Clientes]
GO
/****** Object:  ForeignKey [FK_Compra_Publicacion]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Publicacion] FOREIGN KEY([Codigo_Pub])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Publicacion]
GO
/****** Object:  ForeignKey [FK_Empresa_Usuario]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Empresa]  WITH CHECK ADD  CONSTRAINT [FK_Empresa_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[Empresa] CHECK CONSTRAINT [FK_Empresa_Usuario]
GO
/****** Object:  ForeignKey [FK_Factura_Publicacion]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Publicacion] FOREIGN KEY([Pub_Cod])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Publicacion]
GO
/****** Object:  ForeignKey [FK_Factura_Tipo_Pago]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Tipo_Pago] FOREIGN KEY([Forma_Pago_Desc])
REFERENCES [dbo].[Tipo_Pago] ([Codigo])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Tipo_Pago]
GO
/****** Object:  ForeignKey [FK__Func_Rol__id_Fun__2858E14B]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Func_Rol]  WITH CHECK ADD FOREIGN KEY([id_Func])
REFERENCES [dbo].[Funcionalidades] ([id_funcionabilidad])
GO
/****** Object:  ForeignKey [FK__Func_Rol__id_Rol__294D0584]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Func_Rol]  WITH CHECK ADD FOREIGN KEY([id_Rol])
REFERENCES [dbo].[Rol] ([Id])
GO
/****** Object:  ForeignKey [FK_Item_Factura_Factura]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Item_Factura]  WITH CHECK ADD  CONSTRAINT [FK_Item_Factura_Factura] FOREIGN KEY([Nro_Fact], [Pub_Cod])
REFERENCES [dbo].[Factura] ([Numero], [Pub_Cod])
GO
ALTER TABLE [dbo].[Item_Factura] CHECK CONSTRAINT [FK_Item_Factura_Factura]
GO
/****** Object:  ForeignKey [FK_Oferta_Clientes]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Oferta]  WITH CHECK ADD  CONSTRAINT [FK_Oferta_Clientes] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Clientes] ([Id_Cliente])
GO
ALTER TABLE [dbo].[Oferta] CHECK CONSTRAINT [FK_Oferta_Clientes]
GO
/****** Object:  ForeignKey [FK_Oferta_Publicacion]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Oferta]  WITH CHECK ADD  CONSTRAINT [FK_Oferta_Publicacion] FOREIGN KEY([Codigo_Pub])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[Oferta] CHECK CONSTRAINT [FK_Oferta_Publicacion]
GO
/****** Object:  ForeignKey [FK_PreguntasYRespuestas_Publicacion]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[PreguntasYRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_PreguntasYRespuestas_Publicacion] FOREIGN KEY([Id_Publicacion])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[PreguntasYRespuestas] CHECK CONSTRAINT [FK_PreguntasYRespuestas_Publicacion]
GO
/****** Object:  ForeignKey [FK_PreguntasYRespuestas_Usuario]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[PreguntasYRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_PreguntasYRespuestas_Usuario] FOREIGN KEY([UsuarioPregunta])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[PreguntasYRespuestas] CHECK CONSTRAINT [FK_PreguntasYRespuestas_Usuario]
GO
/****** Object:  ForeignKey [FK_Publicacion_Estado]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Estado] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([Cod_Estado])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Estado]
GO
/****** Object:  ForeignKey [FK_Publicacion_Tipo_Publicacion]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Tipo_Publicacion] FOREIGN KEY([Tipo])
REFERENCES [dbo].[Tipo_Publicacion] ([Cod_Tipo])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Tipo_Publicacion]
GO
/****** Object:  ForeignKey [FK_Publicacion_Usuario]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Usuario] FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Usuario]
GO
/****** Object:  ForeignKey [FK_Publicacion_Visibilidad]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Visibilidad] FOREIGN KEY([Visibilidad_Cod])
REFERENCES [dbo].[Visibilidad] ([Codigo])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Visibilidad]
GO
/****** Object:  ForeignKey [FK_Publicacion_Rubro_Publicacion]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Publicacion_Rubro]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Rubro_Publicacion] FOREIGN KEY([id_Publicacion])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[Publicacion_Rubro] CHECK CONSTRAINT [FK_Publicacion_Rubro_Publicacion]
GO
/****** Object:  ForeignKey [FK_Publicacion_Rubro_Rubro]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Publicacion_Rubro]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Rubro_Rubro] FOREIGN KEY([id_Rubro])
REFERENCES [dbo].[Rubro] ([Codigo])
GO
ALTER TABLE [dbo].[Publicacion_Rubro] CHECK CONSTRAINT [FK_Publicacion_Rubro_Rubro]
GO
/****** Object:  ForeignKey [FK_Usuario_Rol]    Script Date: 07/09/2014 12:44:51 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([Rol_Usuario])
REFERENCES [dbo].[Rol] ([Id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
