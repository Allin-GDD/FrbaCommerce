USE [GD1C2014]
GO

/****** Object:  Table [dbo].[Estado]    Script Date: 07/09/2014 12:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[Cod_Estado] [numeric](18, 0)identity (1,1) NOT NULL,
	[Nombre] [nvarchar](255) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[Cod_Estado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 07/09/2014 01:30:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Rol](
	[Id_Usuario] [numeric](18, 0) NOT NULL,
	[Id_Rol] [numeric](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Calificacion]    Script Date: 07/09/2014 12:46:33 ******/
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
/****** Object:  Table [dbo].[Tipo_Publicacion]    Script Date: 07/09/2014 12:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Publicacion](
	[Cod_Tipo] [numeric](18, 0) identity(1,1) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Tipo_Publicacion] PRIMARY KEY CLUSTERED 
(
	[Cod_Tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Pago]    Script Date: 07/09/2014 12:46:33 ******/
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
/****** Object:  Table [dbo].[Tipo_Doc]    Script Date: 07/09/2014 12:46:33 ******/
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
/****** Object:  Table [dbo].[Rubro]    Script Date: 07/09/2014 12:46:33 ******/
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
/****** Object:  Table [dbo].[Rol]    Script Date: 07/09/2014 12:46:33 ******/
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
/****** Object:  Table [dbo].[Funcionalidades]    Script Date: 07/09/2014 12:46:33 ******/
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
/****** Object:  Table [dbo].[Visibilidad]    Script Date: 07/09/2014 12:46:33 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 07/09/2014 12:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id_Usuario] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](50) NOT NULL,
	[Tipo_Usuario] [char](1) NOT NULL,
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
/****** Object:  Table [dbo].[Func_Rol]    Script Date: 07/09/2014 12:46:33 ******/
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
/****** Object:  Table [dbo].[Publicacion]    Script Date: 07/09/2014 12:46:33 ******/
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
/****** Object:  Table [dbo].[Clientes]    Script Date: 07/09/2014 12:46:33 ******/
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
/****** Object:  Table [dbo].[Empresa]    Script Date: 07/09/2014 12:46:33 ******/
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
/****** Object:  Table [dbo].[Factura]    Script Date: 07/09/2014 12:46:33 ******/
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
/****** Object:  Table [dbo].[Publicacion_Rubro]    Script Date: 07/09/2014 12:46:33 ******/
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
/****** Object:  Table [dbo].[Compra]    Script Date: 07/09/2014 12:46:33 ******/
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
/****** Object:  Table [dbo].[PreguntasYRespuestas]    Script Date: 07/09/2014 12:46:33 ******/
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
/****** Object:  Table [dbo].[Oferta]    Script Date: 07/09/2014 12:46:33 ******/
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
/****** Object:  Table [dbo].[Item_Factura]    Script Date: 07/09/2014 12:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item_FacturaPublicacion](
	[Codigo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Pub_Cod] [numeric](18, 0) NOT NULL,
	[Nro_Fact] [numeric](18, 0) NOT NULL,
	[Monto] [numeric](18, 2) NULL,
	[Cantidad] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Item_FacturaPublicacion] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item_Factura]    Script Date: 07/09/2014 12:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item_FacturaComision](
	[Codigo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Pub_Cod] [numeric](18, 0) NOT NULL,
	[Nro_Fact] [numeric](18, 0) NOT NULL,
	[Monto] [numeric](18, 2) NULL,
	
 CONSTRAINT [PK_Item_FacturaComision] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Clientes_Tipo_Doc]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Tipo_Doc] FOREIGN KEY([Tipo_Doc])
REFERENCES [dbo].[Tipo_Doc] ([Codigo])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Tipo_Doc]
GO
/****** Object:  ForeignKey [FK_Clientes_Usuario]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Usuario]
GO
/****** Object:  ForeignKey [FK_Compra_Calificacion]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Calificacion] FOREIGN KEY([Calificacion_Codigo])
REFERENCES [dbo].[Calificacion] ([Cod_Calificacion])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Calificacion]
GO
/****** Object:  ForeignKey [FK_Compra_Clientes]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Clientes] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Clientes] ([Id_Cliente])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Clientes]
GO
/****** Object:  ForeignKey [FK_Compra_Publicacion]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Publicacion] FOREIGN KEY([Codigo_Pub])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Publicacion]
GO
/****** Object:  ForeignKey [FK_Empresa_Usuario]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Empresa]  WITH CHECK ADD  CONSTRAINT [FK_Empresa_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[Empresa] CHECK CONSTRAINT [FK_Empresa_Usuario]
GO
/****** Object:  ForeignKey [FK_Factura_Publicacion]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Publicacion] FOREIGN KEY([Pub_Cod])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Publicacion]
GO
/****** Object:  ForeignKey [FK_Factura_Tipo_Pago]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Tipo_Pago] FOREIGN KEY([Forma_Pago_Desc])
REFERENCES [dbo].[Tipo_Pago] ([Codigo])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Tipo_Pago]
GO
/****** Object:  ForeignKey [FK__Func_Rol__id_Fun__2858E14B]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Func_Rol]  WITH CHECK ADD FOREIGN KEY([id_Func])
REFERENCES [dbo].[Funcionalidades] ([id_funcionabilidad])
GO
/****** Object:  ForeignKey [FK__Func_Rol__id_Rol__294D0584]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Func_Rol]  WITH CHECK ADD FOREIGN KEY([id_Rol])
REFERENCES [dbo].[Rol] ([Id])
GO
/****** Object:  ForeignKey [FK_Item_FacturaPublicacion_Factura]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Item_FacturaPublicacion]  WITH CHECK ADD  CONSTRAINT [FK_Item_FacturaPublicacion_Factura] FOREIGN KEY([Nro_Fact], [Pub_Cod])
REFERENCES [dbo].[Factura] ([Numero], [Pub_Cod])
GO
ALTER TABLE [dbo].[Item_FacturaPublicacion] CHECK CONSTRAINT [FK_Item_FacturaPublicacion_Factura]
GO
/****** Object:  ForeignKey [FK_Item_FacturaComision_Factura]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Item_FacturaComision]  WITH CHECK ADD  CONSTRAINT [FK_Item_FacturaComision_Factura] FOREIGN KEY([Nro_Fact], [Pub_Cod])
REFERENCES [dbo].[Factura] ([Numero], [Pub_Cod])
GO
ALTER TABLE [dbo].[Item_FacturaComision] CHECK CONSTRAINT [FK_Item_FacturaComision_Factura]
GO
/****** Object:  ForeignKey [FK_Oferta_Clientes]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Oferta]  WITH CHECK ADD  CONSTRAINT [FK_Oferta_Clientes] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Clientes] ([Id_Cliente])
GO
ALTER TABLE [dbo].[Oferta] CHECK CONSTRAINT [FK_Oferta_Clientes]
GO
/****** Object:  ForeignKey [FK_Oferta_Publicacion]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Oferta]  WITH CHECK ADD  CONSTRAINT [FK_Oferta_Publicacion] FOREIGN KEY([Codigo_Pub])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[Oferta] CHECK CONSTRAINT [FK_Oferta_Publicacion]
GO
/****** Object:  ForeignKey [FK_PreguntasYRespuestas_Publicacion]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[PreguntasYRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_PreguntasYRespuestas_Publicacion] FOREIGN KEY([Id_Publicacion])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[PreguntasYRespuestas] CHECK CONSTRAINT [FK_PreguntasYRespuestas_Publicacion]
GO
/****** Object:  ForeignKey [FK_PreguntasYRespuestas_Usuario]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[PreguntasYRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_PreguntasYRespuestas_Usuario] FOREIGN KEY([UsuarioPregunta])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[PreguntasYRespuestas] CHECK CONSTRAINT [FK_PreguntasYRespuestas_Usuario]
GO
/****** Object:  ForeignKey [FK_Publicacion_Estado]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Estado] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([Cod_Estado])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Estado]
GO
/****** Object:  ForeignKey [FK_Publicacion_Tipo_Publicacion]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Tipo_Publicacion] FOREIGN KEY([Tipo])
REFERENCES [dbo].[Tipo_Publicacion] ([Cod_Tipo])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Tipo_Publicacion]
GO
/****** Object:  ForeignKey [FK_Publicacion_Usuario]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Usuario] FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Usuario]
GO
/****** Object:  ForeignKey [FK_Publicacion_Visibilidad]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Visibilidad] FOREIGN KEY([Visibilidad_Cod])
REFERENCES [dbo].[Visibilidad] ([Codigo])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Visibilidad]
GO
/****** Object:  ForeignKey [FK_Publicacion_Rubro_Publicacion]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Publicacion_Rubro]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Rubro_Publicacion] FOREIGN KEY([id_Publicacion])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[Publicacion_Rubro] CHECK CONSTRAINT [FK_Publicacion_Rubro_Publicacion]
GO
/****** Object:  ForeignKey [FK_Publicacion_Rubro_Rubro]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Publicacion_Rubro]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Rubro_Rubro] FOREIGN KEY([id_Rubro])
REFERENCES [dbo].[Rubro] ([Codigo])
GO
ALTER TABLE [dbo].[Publicacion_Rubro] CHECK CONSTRAINT [FK_Publicacion_Rubro_Rubro]
GO
/****** Object:  ForeignKey [FK_Usuario_Rol]    Script Date: 07/09/2014 12:46:33 ******/
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([Rol_Usuario])
REFERENCES [dbo].[Rol] ([Id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO

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
select distinct m.Cli_Mail,'C',Convert(nvarchar,m.Cli_Dni),10,0,1
 from gd_esquema.Maestra M
 where  m.Cli_Dni IS NOT NULL
 
union all
 select distinct m.Publ_Empresa_Mail,'E',m.Publ_Empresa_Cuit,10,0,1
 from gd_esquema.Maestra m
 where Publ_Empresa_Cuit is not null

 
-- Migracion tabla cliente

insert into Clientes 
select distinct u.Id_Usuario ,CONVERT(nvarchar,M.Cli_Dni) as dni,1,cli_nombre, cli_apeliido , Cli_Fecha_Nac,
Cli_Mail,cli_dom_calle,cli_nro_calle,Cli_Piso,Cli_Depto,Cli_Cod_Postal,'',''
FROM gd_esquema.Maestra M INNER JOIN Usuario U ON CONVERT(nvarchar,M.Cli_Dni) = u.password
WHERE Cli_Dni IS NOT NULL

-- Migracion tabla empresa

insert into Empresa

select distinct u.Id_Usuario,'',Publ_Empresa_Razon_Social,Publ_Empresa_Cuit,Publ_Empresa_Fecha_Creacion,
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

--Migracion tabla estado publicacion
insert into estado
select distinct  Publicacion_Estado
from gd_esquema.Maestra

--Migracion tabla Tipo_Pub
insert into Tipo_Publicacion
select distinct  Publicacion_Tipo
from gd_esquema.Maestra


-- Migracion tabla publicacion

insert into Publicacion
select distinct Publicacion_Cod,Publicacion_Descripcion,Publicacion_Stock,
Publicacion_Fecha,Publicacion_Fecha_Venc,Publicacion_Precio,Tipo_Publicacion.cod_tipo,
Publicacion_Visibilidad_Cod,Estado.cod_estado,0,usuario.Id_Usuario
from gd_esquema.Maestra,Rubro, Clientes,Tipo_Publicacion,estado,Usuario
where Publicacion_Cod is not null
and Publicacion_Tipo = tipo_publicacion.nombre
and Publicacion_Estado = estado.nombre
and Usuario.Usuario = Clientes.Mail
and Publ_Cli_Dni is not null
and CONVERT(nvarchar,Publ_Cli_Dni) = Clientes.Nro_Documento
and Publicacion_Rubro_Descripcion = Rubro.Descripcion
UNION ALL
select distinct Publicacion_Cod,Publicacion_Descripcion,Publicacion_Stock,
Publicacion_Fecha,Publicacion_Fecha_Venc,Publicacion_Precio,Tipo_Publicacion.cod_tipo,
Publicacion_Visibilidad_Cod,Estado.cod_estado,0,usuario.Id_Usuario
from gd_esquema.Maestra,Rubro, Empresa,Tipo_Publicacion,Usuario,estado
where Publicacion_Cod is not null
and Publ_Empresa_Cuit  is not null
and Usuario.Usuario = Empresa.Mail
and Publicacion_Estado = Estado.nombre
and Publicacion_Tipo = tipo_publicacion.nombre
and Publ_empresa_cuit = empresa.Nro_Documento
and Publicacion_Rubro_Descripcion = Rubro.Descripcion

--Migracion Publicacion_Rubro
insert into Publicacion_Rubro

select distinct Publicacion_Cod,Rubro.codigo
from gd_esquema.Maestra,Rubro
where Rubro.Descripcion = Publicacion_Rubro_Descripcion


-- migracion tabla factura

insert into Factura

select distinct Factura_Nro,factura_Fecha,Factura_Total,1,publicacion_cod from gd_esquema.Maestra

where Factura_Nro is not null
-- and publicacion_cod is not null

-- migracion tabla item_facturaPublicacion

insert into Item_FacturaPublicacion

select  Publicacion_Cod,Factura_Nro,Item_Factura_Monto,Item_Factura_Cantidad

from gd_esquema.Maestra

where Factura_Nro is not null
and Item_Factura_Monto <> Publicacion_Visibilidad_Precio

-- migracion tabla item_facturaComision

insert into Item_FacturaComision

select  distinct Publicacion_Cod,Factura_Nro,Item_Factura_Monto

from gd_esquema.Maestra

where Factura_Nro is not null
and Item_Factura_Monto = Publicacion_Visibilidad_Precio

-- migracion tabla calificacion
insert into calificacion
 select distinct Calificacion_Codigo,Calificacion_Cant_Estrellas/2,Calificacion_Descripcion
 from gd_esquema.Maestra
 where Calificacion_Codigo is not null
 and Calificacion_Cant_Estrellas is not null

-- migracion tabla compra
insert into Compra

select distinct Publicacion_Cod,Clientes.Id_Cliente,Compra_Fecha,Compra_Cantidad,Calificacion_Codigo


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
