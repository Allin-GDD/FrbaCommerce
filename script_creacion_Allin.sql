USE [GD1C2014]
GO
/****** Object:  Schema [allin]    Script Date: 07/17/2014 19:17:20 ******/
CREATE SCHEMA [allin] AUTHORIZATION [gd]
GO
/****** Object:  Table [allin].[Calificacion]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Calificacion](
	[Cod_Calificacion] [numeric](18, 0) NOT NULL,
	[Cant_Estrellas] [numeric](18, 0) NOT NULL,
	[Descripcion] [nvarchar](255) NULL,
 CONSTRAINT [PK_Calificacion] PRIMARY KEY CLUSTERED 
(
	[Cod_Calificacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [allin].[Estado]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Estado](
	[Cod_Estado] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](255) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[Cod_Estado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [allin].[Funcionalidades]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Funcionalidades](
	[id_funcionabilidad] [int] NOT NULL,
	[nom_funcionalidad] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_funcionabilidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [allin].[Rubro]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Rubro](
	[Codigo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](255) NULL,
 CONSTRAINT [PK_Rubro] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [allin].[Rol]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Rol](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Estado] [smallint] NULL,
	[Baja] [smallint] NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [allin].[Usuario]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [allin].[Usuario](
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [allin].[Tipo_Publicacion]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Tipo_Publicacion](
	[Cod_Tipo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Tipo_Publicacion] PRIMARY KEY CLUSTERED 
(
	[Cod_Tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [allin].[Tipo_Pago]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Tipo_Pago](
	[Codigo] [numeric](18, 0) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Tipo_Pago] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [allin].[Tipo_Doc]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Tipo_Doc](
	[Codigo] [smallint] NOT NULL,
	[Nombre] [nvarchar](255) NULL,
 CONSTRAINT [PK_Tipo_Doc] PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [allin].[Visibilidad]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Visibilidad](
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
/****** Object:  Table [allin].[Usuario_Rol]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Usuario_Rol](
	[Id_Usuario] [numeric](18, 0) NOT NULL,
	[Id_Rol] [numeric](18, 0) NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Usuario_Rol] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC,
	[Id_Rol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [allin].[actualizarBajaDelUsuario]    Script Date: 07/18/2014 16:35:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[actualizarBajaDelUsuario]
@Baja smallint,
@Id numeric(18,0)
AS
BEGIN
UPDATE allin.Usuario
SET Baja = @Baja
WHERE Id_Usuario = @Id
END
GO
/****** Object:  StoredProcedure [allin].[obtenerVisibilidad]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[obtenerVisibilidad]
@Cod_visib numeric(18,0)
AS
BEGIN
SELECT Descripcion from [allin].Visibilidad
WHERE Codigo = @Cod_visib
END
GO
/****** Object:  StoredProcedure [allin].[seleccionVisibilidadNotNull]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[seleccionVisibilidadNotNull]
AS
BEGIN 
SELECT Codigo, Descripcion FROM [allin].Visibilidad
WHERE Estado <> 0
END
GO
/****** Object:  StoredProcedure [allin].[obtenerNombreTipoPublicacion]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[obtenerNombreTipoPublicacion]
@tipo numeric(18,0)
AS
BEGIN
SELECT Nombre from [allin].Tipo_Publicacion
WHERE Cod_Tipo = @tipo
END
GO
/****** Object:  StoredProcedure [allin].[obtenerNombreIdRol]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[obtenerNombreIdRol]
@Id_Rol numeric(18,0)
AS
BEGIN
SELECT nombre FROM [allin].Rol 
WHERE Id = @Id_Rol
END
GO
/****** Object:  StoredProcedure [allin].[obtenerEstado]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[obtenerEstado]
@Id_Rol numeric(18,0)
AS
BEGIN
SELECT Estado FROM [allin].Rol
WHERE Id = @Id_Rol
END
GO
/****** Object:  StoredProcedure [allin].[obtenerDescripcionRubro]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[obtenerDescripcionRubro]
@IdRubro numeric(18,0)
AS
BEGIN
SELECT Descripcion from [allin].Rubro
WHERE Codigo = @IdRubro
END
GO
/****** Object:  StoredProcedure [allin].[obtenerCodTipoPublicacion]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[obtenerCodTipoPublicacion]
@tipo nvarchar(255)
AS
BEGIN
SELECT Cod_Tipo from [allin].Tipo_Publicacion
WHERE Nombre = @tipo
END
GO
/****** Object:  StoredProcedure [allin].[obtenerCodRubro]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[obtenerCodRubro]
@Descripcion nvarchar(255)
AS
BEGIN
SELECT Codigo from [allin].Rubro
WHERE Descripcion = @Descripcion
END
GO
/****** Object:  StoredProcedure [allin].[obtenerCodEstadoPublicacion]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[obtenerCodEstadoPublicacion]
@estado nvarchar(255)
AS
BEGIN
SELECT Cod_Estado from [allin].Estado
WHERE Nombre = @estado
END
GO
/****** Object:  StoredProcedure [allin].[listaDeVisibilidades]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[listaDeVisibilidades]
		@Codigo nvarchar(18),
		@Descripcion nvarchar(255),
		@Precio nvarchar(18),
		@Porcentaje nvarchar(18)
		
	AS
	BEGIN
		SELECT Codigo, Descripcion,Precio, Porcentaje,Vencimiento FROM [allin].Visibilidad
			WHERE
				Codigo like '%'+@Codigo+'%'
				AND Descripcion like '%'+@Descripcion+'%'
				AND	Precio like '%'+@Precio+'%'
				AND Porcentaje like '%'+@Porcentaje+'%'
				AND Estado = 1
				
	END
GO
/****** Object:  StoredProcedure [allin].[filtrarRol]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[filtrarRol]
@Rol nvarchar(50),
@Filtrado int
AS
BEGIN
IF(@Filtrado = 1)
BEGIN
SELECT Id, Nombre FROM [allin].Rol
WHERE Nombre like '%'+@Rol+'%'
AND Baja = 1
END
ELSE
BEGIN
SELECT Id, Nombre FROM [allin].Rol
WHERE Nombre like '%'+@Rol+'%'
AND Estado <> 0
AND Baja = 1
END
end
GO
/****** Object:  StoredProcedure [allin].[estaHabilitado]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[estaHabilitado]
@Id numeric (18,0)
AS
BEGIN
SELECT estado from [allin].Usuario 
where Id_Usuario = @Id
END
GO
/****** Object:  Table [allin].[Func_Rol]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Func_Rol](
	[id_Rol] [numeric](18, 0) NOT NULL,
	[id_Func] [int] NOT NULL,
 CONSTRAINT [PK_Func_Rol] PRIMARY KEY CLUSTERED 
(
	[id_Rol] ASC,
	[id_Func] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [allin].[Empresa]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Empresa](
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
/****** Object:  Table [allin].[Publicacion]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Publicacion](
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
/****** Object:  Table [allin].[Clientes]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Clientes](
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
/****** Object:  StoredProcedure [allin].[buscarUsuarioCliente]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [allin].[buscarUsuarioCliente]
@Id numeric(18,0)
AS
BEGIN
	SELECT usuario FROM [allin].Usuario
		WHERE 
		@Id =Id_Usuario
		and Tipo_usuario = 'C'
END
GO
/****** Object:  StoredProcedure [allin].[darDeBajaVisibilidad]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[darDeBajaVisibilidad]
@Codigo numeric(18,0)
AS
BEGIN
UPDATE [allin].Visibilidad
SET Estado = 0, Descripcion = null
WHERE Codigo = @Codigo
END
GO
/****** Object:  StoredProcedure [allin].[darDeBajaRol]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[darDeBajaRol]
@Rol numeric(18,0)
AS
BEGIN
UPDATE [allin].Rol
SET Baja = 0, Estado = 0
WHERE Id = @Rol
END
GO
/****** Object:  StoredProcedure [allin].[darDeAltaUsuario]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[darDeAltaUsuario]
@UsuarioName nvarchar(50),
@Password nvarchar(64),
@Rol numeric(18,0),
@Estado int,
@Intentos int
AS
BEGIN
DECLARE @Tipo_User char(1)

SET @Tipo_User = (CASE @Rol 
				WHEN 1 THEN 'C'
				WHEN 2 THEN 'E'
				ELSE 'A' 
				END)


INSERT INTO [allin].Usuario(Usuario,Tipo_Usuario,Password,Estado,Intentos,Baja)
VALUES(@UsuarioName,@Tipo_User,@Password,@Estado,@Intentos,1)
END
GO
/****** Object:  StoredProcedure [allin].[buscarNombreUsuario]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[buscarNombreUsuario]
@IdUsuario numeric(18,0),
@TipoUsuario char(1)
AS
BEGIN
SELECT Usuario FROM [allin].Usuario
WHERE @TipoUsuario = Tipo_Usuario AND
@IdUsuario = Id_Usuario
END
GO
/****** Object:  StoredProcedure [allin].[buscarMiIDUsuario]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[buscarMiIDUsuario]
@UserName nvarchar(50)
AS
BEGIN
SELECT Id_Usuario From [allin].Usuario 
WHERE Usuario = @UserName
END
GO
/****** Object:  StoredProcedure [allin].[buscarIdRol]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[buscarIdRol]
@Rol_Nombre nvarchar(50)
AS
BEGIN
SELECT Id FROM [allin].Rol 
WHERE Nombre = @Rol_Nombre
END
GO
/****** Object:  StoredProcedure [allin].[buscarPublicador]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[buscarPublicador]
@Usuario nvarchar(50)
AS
BEGIN
	SELECT * FROM [allin].Usuario 
		WHERE 
		Usuario = @Usuario;
END
GO
/****** Object:  StoredProcedure [allin].[buscarUnaVisibilidad]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[buscarUnaVisibilidad]
@Codigo numeric(18,0)
AS
BEGIN
	SELECT * FROM [allin].Visibilidad
		WHERE 
		Codigo = @Codigo;
END
GO
/****** Object:  StoredProcedure [allin].[buscarDuracionVisibilidad]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[buscarDuracionVisibilidad]
@Visibilidad nvarchar(50)
AS
BEGIN
	SELECT * FROM [allin].Visibilidad 
		WHERE 
		Codigo = @Visibilidad;
END
GO
/****** Object:  StoredProcedure [allin].[buscarCamposDeUsuario]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[buscarCamposDeUsuario]
@Usuario nvarchar(50)
AS
BEGIN
SELECT Password,Id_Usuario,Intentos, Estado FROM [allin].Usuario
WHERE Usuario = @Usuario
END
GO
/****** Object:  StoredProcedure [allin].[agregarNuevaVisibilidad]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[agregarNuevaVisibilidad]
		@Codigo numeric(18,0),
		@Descripcion nvarchar(255),
		@Precio numeric(18,2),
		@Porcentaje numeric(18,2),
		@Estado smallint,
		@Vencimiento smallint

AS
BEGIN
	INSERT INTO [allin].Visibilidad(
	Codigo,
	Descripcion,
	Precio,
	Porcentaje,
	Estado,
	Vencimiento)
	VALUES(
	@Codigo,
	@Descripcion,
	@Precio,
	@Porcentaje,
	@Estado,
	@Vencimiento
	)	

END
GO
/****** Object:  StoredProcedure [allin].[actualizarContraseña]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[actualizarContraseña]
@Usuario numeric(18,0),
@Contraseña nvarchar(64)
AS
BEGIN
UPDATE [allin].Usuario
SET Password = @Contraseña
WHERE Id_Usuario = @Usuario
END
GO
/****** Object:  StoredProcedure [allin].[actualizarEstadoDelUsuario]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[actualizarEstadoDelUsuario]
@Estado smallint,
@Id numeric(18,0)
AS
BEGIN
UPDATE [allin].Usuario
SET Estado = @Estado
WHERE Id_Usuario = @Id
END
GO
/****** Object:  StoredProcedure [allin].[actualizarNombreRol]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[actualizarNombreRol]
@Id_Rol numeric(18,0),
@Nombre_New nvarchar(30)
AS
BEGIN
UPDATE [allin].Rol 
SET Nombre = @Nombre_New
WHERE Id = @Id_Rol
END
GO
/****** Object:  StoredProcedure [allin].[actualizarIntentos]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[actualizarIntentos]
@Usuario numeric(18,0),
@Intentos int
AS
BEGIN
UPDATE [allin].Usuario
SET Intentos = @Intentos
WHERE
@Usuario = Id_Usuario
END
GO
/****** Object:  StoredProcedure [allin].[ActualizarVisibilidad]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[ActualizarVisibilidad]
@Codigo numeric(18,0),
@Descripcion nvarchar(255),
@Precio numeric(18,2),
@Porcentaje numeric(18,2),
@Vencimiento smallint
AS 
BEGIN
UPDATE [allin].Visibilidad
SET Descripcion = @Descripcion, Precio = @Precio , Porcentaje = @Porcentaje,Vencimiento = @Vencimiento
WHERE Codigo = @Codigo
End
GO
/****** Object:  StoredProcedure [allin].[actualizarStock]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [allin].[actualizarStock]

@Codigo numeric (18,0),
@Stock numeric (18,0)
AS 
BEGIN
UPDATE [allin].Publicacion
SET Stock = (Stock - @Stock)
WHERE Codigo = @Codigo 
END
GO
/****** Object:  StoredProcedure [allin].[actualizarEstadoRol]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[actualizarEstadoRol]
@Id_Rol numeric(18,0),
@Estado smallint
AS
BEGIN
UPDATE [allin].Rol
SET Estado = @Estado
WHERE Id = @Id_Rol

UPDATE [allin].Usuario_Rol
SET Estado = @Estado 
WHERE Id_Rol = @Id_Rol
END
GO
/****** Object:  StoredProcedure [allin].[actualizarEmpresa]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[actualizarEmpresa]
@Id numeric(18,0),
	@RazonSocial nvarchar(255),
		@Cuit nvarchar(255),
		@Fecha_Creacion Datetime,
		@Mail nvarchar(255),
		@Dom_Calle nvarchar(255),
		@Nro_Calle numeric(18,0),
		@Piso numeric(18,0),
		@Depto nvarchar(50),
		@Cod_Postal nvarchar(50),
		@Localidad nvarchar(255),	
		@Telefono nvarchar(255),
		@Ciudad nvarchar(255),
		@Nombre_Contacto nvarchar(255)
AS
BEGIN
UPDATE [allin].Empresa 
SET Razon_Social = @RazonSocial, Nombre_Contacto = @Nombre_Contacto, Ciudad = @Ciudad, Piso = @Piso, 
Localidad = @Localidad, Cod_Postal = @Cod_Postal, Depto = @Depto, Nro_Calle = @Nro_Calle, Dom_Calle = @Dom_Calle, 
Mail = @Mail, Fecha_Creacion = @Fecha_Creacion, Nro_Documento = @Cuit , Telefono = @Telefono
WHERE Id_Usuario = @Id
END
GO
/****** Object:  StoredProcedure [allin].[actualizarCliente]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[actualizarCliente]
		@Id numeric(18,0),
		@Dni nvarchar(255),
		@Nombre nvarchar(255),
		@Apellido nvarchar(255),
		@Fecha_Nac Datetime,
		@Mail nvarchar(255),
		@Dom_Calle nvarchar(255),
		@Nro_Calle numeric(18,0),
		@Piso numeric(18,0),
		@Depto nvarchar(50),
		@Cod_Postal nvarchar(50),
		@Localidad nvarchar(255),
		@Tipo_dni smallint,
		@Telefono nvarchar(255)
		AS 
		BEGIN
UPDATE [allin].Clientes
SET Apellido = @Apellido, Nombre = @Nombre , Nro_Documento = @Dni, Fecha_Nac = @Fecha_Nac, Mail = @Mail, Dom_Calle = @Dom_Calle,
Nro_Calle = @Nro_Calle, Piso = @Piso, Depto = @Piso, Cod_Postal = @Cod_Postal, Localidad = @Localidad,
Tipo_Doc = @Tipo_dni, Telefono = @Telefono
WHERE Id_Usuario = @Id
End
GO
/****** Object:  StoredProcedure [allin].[agregarNuevaEmpresa]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[agregarNuevaEmpresa]
		@RazonSocial nvarchar(255),
		@Cuit nvarchar(255),
		@Fecha_Creacion Datetime,
		@Mail nvarchar(255),
		@Dom_Calle nvarchar(255),
		@Nro_Calle numeric(18,0),
		@Piso numeric(18,0),
		@Depto nvarchar(50),
		@Cod_Postal nvarchar(50),
		@Localidad nvarchar(255),	
		@Telefono nvarchar(255),
		@Ciudad nvarchar(255),
		@Nombre_Contacto nvarchar(255),
		@IdUsuario numeric(18,0)

AS
BEGIN
	INSERT INTO [allin].Empresa(
	Razon_Social,
	Nro_Documento,
	Fecha_Creacion,
	Mail,
	Dom_Calle,
	Nro_Calle,
	Piso,
	Depto,
	Cod_Postal,
	Localidad,
	Telefono,
	Ciudad,
	Nombre_Contacto,
	Id_Usuario)
	VALUES(
		@RazonSocial ,
		@Cuit,
		@Fecha_Creacion ,
		@Mail ,
		@Dom_Calle,
		@Nro_Calle,
		@Piso,
		@Depto,
		@Cod_Postal ,
		@Localidad,	
		@Telefono,
		@Ciudad,
		@Nombre_Contacto,
		@IdUsuario
	)	

END
GO
/****** Object:  StoredProcedure [allin].[agregarFuncionabilidadAlRol]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[agregarFuncionabilidadAlRol]
@Id_Rol numeric(18,0),
@Id_Funcionabilidad int
AS
BEGIN
INSERT INTO [allin].Func_Rol(Id_Rol,
Id_Func)
VALUES(@Id_Rol, @Id_Funcionabilidad)
END
GO
/****** Object:  StoredProcedure [allin].[agregarNuevoCliente]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[agregarNuevoCliente]
		@Dni nvarchar(64),
		@Nombre nvarchar(255),
		@Apellido nvarchar(255),
		@Fecha_Nac Datetime,
		@Mail nvarchar(255),
		@Dom_Calle nvarchar(255),
		@Nro_Calle numeric(18,0),
		@Piso numeric(18,0),
		@Depto nvarchar(50),
		@Cod_Postal nvarchar(50),
		@Localidad nvarchar(255),
		@Tipo_dni smallint,
		@Telefono nvarchar(255),
		
		@IdUsuario numeric(18,0)
		AS
		BEGIN
	INSERT INTO [allin].Clientes(
	Id_Usuario,	Nro_Documento,Nombre,Apellido,Fecha_Nac,Mail,Dom_Calle,Nro_Calle,Piso,Depto,
	Cod_Postal,	Localidad,Tipo_Doc,	Telefono)
	VALUES(@IdUsuario, @Dni, @Nombre,@Apellido,@Fecha_Nac,@Mail,@Dom_Calle,@Nro_Calle,@Piso,
	@Depto,	@Cod_Postal,@Localidad,	@Tipo_dni,@Telefono )	
	END
GO
/****** Object:  StoredProcedure [allin].[agregarNuevoRol]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[agregarNuevoRol]
@Rol_Nombre nvarchar(30)
AS
DECLARE @Id_Rol numeric(18,0)
BEGIN
INSERT [allin].Rol(Nombre, Estado, Baja)
VALUES(@Rol_Nombre, 1,1)
END
GO
/****** Object:  StoredProcedure [allin].[averiguarStock]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[averiguarStock]
@Codigo numeric(18,0)
AS
BEGIN

select Stock from [allin].Publicacion where Codigo = @Codigo
end
GO
/****** Object:  StoredProcedure [allin].[buscarIdEmpresa]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [allin].[buscarIdEmpresa]
@Cuit nvarchar(255)
AS
BEGIN
SELECT Id_Usuario from [allin].Empresa
WHERE Nro_Documento = @Cuit
END
GO
/****** Object:  StoredProcedure [allin].[buscarFuncionalidades]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[buscarFuncionalidades]
@rol nvarchar(50)
AS
BEGIN
SELECT FR.id_Func from [allin].Func_Rol FR 
INNER JOIN [allin].Rol R ON FR.id_Rol = R.Id 
WHERE 
R.Nombre = @rol
END
GO
/****** Object:  StoredProcedure [allin].[buscarUsuarioCod]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[buscarUsuarioCod]
@Codigo numeric(18,0)
AS
BEGIN
	SELECT Usuario FROM [allin].Publicacion 
		WHERE 
		Codigo = @Codigo;
END
GO
/****** Object:  StoredProcedure [allin].[buscarUnaSolaEmpresa]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[buscarUnaSolaEmpresa]
@Id numeric (18,0)
AS 
BEGIN
SELECT u.Usuario,e.Razon_Social, e.Nro_Documento, e.Fecha_Creacion, e.Mail, e.Dom_Calle,
 e.Nro_Calle, e.Piso, e.Depto, e.Cod_Postal, e.Localidad, e.Telefono, e.Ciudad, e.Nombre_Contacto FROM [allin].Empresa e
 join allin.Usuario U on e.Id_Usuario = u.Id_Usuario

WHERE e.Id_Usuario = @Id
END
GO
/****** Object:  StoredProcedure [allin].[buscarPrecio]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[buscarPrecio]
@Cod_Pub numeric(18,0)
AS
BEGIN
SELECT Precio FROM [allin].Publicacion
WHERE Codigo = @Cod_Pub
END
GO
/****** Object:  StoredProcedure [allin].[buscarIdPorPublicacion]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [allin].[buscarIdPorPublicacion]
@Codigo numeric(18,0)
AS
BEGIN

select Usuario from [allin].Publicacion where Codigo = @Codigo
end
GO
/****** Object:  Table [allin].[Compra]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Compra](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Codigo_Pub] [numeric](18, 0) NOT NULL,
	[Id_Cliente] [numeric](18, 0) NOT NULL,
	[Fecha] [datetime] NULL,
	[Cantidad] [numeric](18, 0) NULL,
	[Calificacion_Codigo] [numeric](18, 0) NOT NULL,
	[Facturada] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [allin].[darDeBajaAUsuario]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[darDeBajaAUsuario]
@Id_Usuario numeric(18,0),
@Id_Rol numeric(18,0)
AS
BEGIN
UPDATE [allin].Usuario
SET Baja = 0, Estado = 0
WHERE Id_Usuario = @Id_Usuario

UPDATE [allin].Publicacion
SET Estado = 4
WHERE Publicacion.Usuario = @Id_Usuario

IF(@Id_Rol = 1)
BEGIN
UPDATE [allin].Clientes
SET  Nro_Documento = 0, Telefono = null
where Id_Usuario = @Id_Usuario
END
ELSE IF(@Id_Rol = 2)
BEGIN
UPDATE [allin].Empresa 
SET  Nro_Documento = 0, Telefono = null
where Id_Usuario = @Id_Usuario
END

END
GO
/****** Object:  StoredProcedure [allin].[buscarUnSoloCliente]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[buscarUnSoloCliente]
@Id numeric(18,0)
AS
BEGIN
	SELECT  u.Usuario,c.Nro_Documento, c.Nombre, c.Apellido, c.Fecha_Nac, c.Mail, c.Dom_Calle,
	c.Nro_Calle, c.Piso, c.Depto, c.Cod_Postal, c.Localidad,t.Nombre,c.Telefono FROM [allin].Clientes c 
	INNER JOIN [allin].Tipo_Doc t ON t.Codigo = c.Tipo_Doc
	join [allin].Usuario u on c.Id_Usuario = u.Id_Usuario
		WHERE 
		c.Id_Usuario = @Id;
END
GO
/****** Object:  Table [allin].[PreguntasYRespuestas]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[PreguntasYRespuestas](
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
/****** Object:  Table [allin].[Oferta]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Oferta](
	[Codigo_Pub] [numeric](18, 0) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Monto] [numeric](18, 2) NOT NULL,
	[Id_Cliente] [numeric](18, 0) NOT NULL,
	[Con_Ganador] [numeric](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [allin].[Factura]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Factura](
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
/****** Object:  StoredProcedure [allin].[esBonificada]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [allin].[esBonificada]
@Id numeric (18,0),

@Visibilidad numeric (18,0)
as
begin
select Codigo,Usuario,Visibilidad_Cod,Fecha, RowNumber  
from (select Codigo, Usuario, Visibilidad_Cod, Fecha,row_number() over(order by Codigo,usuario,Visibilidad_Cod,Fecha)as RowNumber
  from [allin].Publicacion
  where Usuario = @Id AND Visibilidad_Cod = @Visibilidad) as Pub 
where RowNumber % 10 = 0
end
GO
/****** Object:  StoredProcedure [allin].[editarPublicacionPublicada]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[editarPublicacionPublicada]
		
		
		@Stock numeric(18,0),
		@Descripcion nvarchar(255),
		@Estado Decimal,
		@Codigo numeric(18,0)

 
AS
BEGIN
	UPDATE [allin].Publicacion
SET  Stock = @Stock, Descripcion = @Descripcion,
Estado = @Estado
WHERE Codigo = @Codigo

END
GO
/****** Object:  StoredProcedure [allin].[editarPublicacionBorradorAPublicada]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[editarPublicacionBorradorAPublicada]
		
		@Visibilidad numeric(18,0),
		@Tipo nvarchar(255),
		@Stock numeric(18,0),
		@Precio numeric(18,2),
		@Fecha datetime,
		@Descripcion nvarchar(255),
		@Estado nvarchar(255),
		@Permitir_Preguntas bit,
		@Fecha_Venc datetime,
		@Codigo numeric(18,0)

 
AS
BEGIN

	UPDATE [allin].Publicacion
SET Visibilidad_Cod = @Visibilidad, Tipo = @Tipo , Stock = @Stock, Precio = @Precio, Descripcion = @Descripcion,
Estado = @Estado, Preguntas_permitidas = @Permitir_Preguntas, Fecha_Venc = @Fecha_Venc, Fecha = @Fecha
WHERE Codigo = @Codigo
	
	

END
GO
/****** Object:  StoredProcedure [allin].[editarPublicacionBorrador]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[editarPublicacionBorrador]
		
		@Visibilidad numeric(18,0),
		@Tipo nvarchar(255),
		@Stock numeric(18,0),
		@Precio numeric(18,2),
		@Descripcion nvarchar(255),
		@Estado nvarchar(255),
		@Permitir_Preguntas bit,
		@Fecha_Venc datetime,
		@Codigo numeric(18,0)

 
AS
BEGIN

	UPDATE [allin].Publicacion
SET Visibilidad_Cod = @Visibilidad, Tipo = @Tipo , Stock = @Stock, Precio = @Precio, Descripcion = @Descripcion,
Estado = @Estado, Preguntas_permitidas = @Permitir_Preguntas
WHERE Codigo = @Codigo
	
	

END
GO
/****** Object:  StoredProcedure [allin].[listaDeEmpresas]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[listaDeEmpresas]
@Razon_Social nvarchar(255),
@CUIT nvarchar(50),
@Mail nvarchar(50)
AS
BEGIN
SELECT e.Id_Usuario, e.Nombre_Contacto, e.Razon_Social as 'Razón Social', e.Nro_Documento as 'Nro de Documento', e.Fecha_Creacion as 'Fecha de Creación',e.Mail,
e.Dom_Calle as 'Domicilio', e.Nro_Calle as 'Nro domicilio',e.Piso,e.Depto, e.Cod_Postal,e.Localidad, e.Ciudad, e.Telefono FROM [allin].Empresa e

WHERE
Razon_Social LIKE '%'+@Razon_Social+'%' AND
Mail LIKE '%'+@Mail+'%' AND
(@CUIT = [Nro_Documento] or @CUIT = '' or @CUIT = '  -        -')
AND Nro_Documento <> '0'
END
GO
/****** Object:  StoredProcedure [allin].[listaDeCliente]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[listaDeCliente]
		@Nombre nvarchar(255),
		@Apellido nvarchar(255),
		@Dni nvarchar(50),
		@Mail nvarchar(255),
		@Tipo_dni nvarchar(1)
	AS
	BEGIN
		SELECT c.Id_Usuario, c.Nombre, c.Apellido, td.Nombre as 'Tipo de documento', c.Nro_Documento as 'Nro documento', c.Fecha_Nac as 'Fecha de Nacimiento', c.Mail, c.Dom_Calle as 'Domicilio',
		c.Nro_Calle as 'Nro domicilio', c.Piso, c.Depto, c.Localidad, c.Telefono FROM [allin].Clientes c 
		INNER JOIN [allin].Tipo_Doc TD ON c.Tipo_Doc = TD.Codigo
			WHERE
				c.Nombre like '%'+@Nombre+'%'
				AND Apellido like '%'+@Apellido+'%'
				AND Nro_Documento like '%'+@Dni+'%'
				AND Nro_Documento <> '0'
				AND Mail like '%'+@Mail+'%'
				AND ((c.Tipo_Doc = @Tipo_dni AND @Tipo_dni <>0) OR @Tipo_dni = 0)
				
	END
GO
/****** Object:  StoredProcedure [allin].[listadodeFunc]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[listadodeFunc]
@Id_Rol numeric(18,0)
AS
BEGIN
IF(@Id_Rol = 0)
BEGIN
SELECT f.id_funcionabilidad as 'ID', f.nom_funcionalidad as 'Nombre' FROM [allin].Funcionalidades f 
END
ELSE
BEGIN
SELECT f.id_funcionabilidad as 'ID', f.nom_funcionalidad as 'Nombre' FROM [allin].Funcionalidades f 
INNER JOIN [allin].Func_Rol fr ON f.id_funcionabilidad = fr.id_Func
WHERE fr.id_Rol = @Id_Rol
END
END
GO
/****** Object:  StoredProcedure [allin].[quitarRol]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[quitarRol]
@Id_Rol int,
@funcionalidad int
AS
BEGIN
DELETE [allin].Func_Rol
WHERE Id_Rol = @Id_Rol AND
Id_Func = @funcionalidad
END
GO
/****** Object:  StoredProcedure [allin].[verificarTresGratuitas]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[verificarTresGratuitas]
@Usuario numeric(18,0)
AS
BEGIN
SELECT COUNT(Visibilidad_Cod) from [allin].Publicacion
WHERE Usuario = @Usuario AND Visibilidad_Cod = 10006 AND Codigo > 68380 AND Estado = 1
END
GO
/****** Object:  StoredProcedure [allin].[verificarEstado]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[verificarEstado]
@Codigo numeric(18,0)
AS
BEGIN
	SELECT Estado FROM [allin].Publicacion 
		WHERE 
		Codigo = @Codigo;
END
GO
/****** Object:  Table [allin].[Publicacion_Rubro]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Publicacion_Rubro](
	[id_Publicacion] [numeric](18, 0) NOT NULL,
	[id_Rubro] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Publicacion_Rubro] PRIMARY KEY CLUSTERED 
(
	[id_Publicacion] ASC,
	[id_Rubro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [allin].[listadoVendedoresQueVendenMenos]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[listadoVendedoresQueVendenMenos]
@Año smallint,
@Visibilidad numeric(18,0),
@Mes int
AS
BEGIN
IF(@Visibilidad <> 0)
BEGIN
SELECT TOP 5 u.Usuario, SUM(Stock) as 'Stock Total', v.Descripcion as 'Visibilidad' from [allin].publicacion P
INNER JOIN [allin].Usuario U ON p.Usuario = U.Id_Usuario
INNER JOIN [allin].Visibilidad V on v.Codigo = p.Visibilidad_Cod
WHERE p.Estado <> 4 AND p.Estado <> 2
AND p.Visibilidad_Cod = @Visibilidad
AND YEAR(p.Fecha) = @Año 
AND MONTH(p.Fecha) = @Mes
AND U.Baja <> 0
AND U.Estado <> 0
group by u.Usuario, v.Descripcion
order by [Stock Total] DESC
END

ELSE 
SELECT TOP 5 u.Usuario, SUM(Stock) as 'Stock Total', v.Descripcion as 'Visibilidad' from [allin].publicacion P
INNER JOIN [allin].Usuario U ON p.Usuario = U.Id_Usuario
INNER JOIN [allin].Visibilidad V on v.Codigo = p.Visibilidad_Cod
WHERE p.Estado <> 4 AND p.Estado <> 2
AND YEAR(p.Fecha) = @Año 
AND MONTH(p.Fecha) = @Mes
AND U.Baja <> 0
AND U.Estado <> 0
group by u.Usuario, v.Descripcion
order by [Stock Total] DESC, v.Descripcion
END
GO
/****** Object:  StoredProcedure [allin].[obtenerTodosLosRoles]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[obtenerTodosLosRoles]
@Id_Usuario numeric(18,0)
AS
BEGIN
SELECT UR.Id_Rol, r.Nombre From [allin].Usuario_Rol UR 
INNER JOIN [allin].Rol R ON R.Id = UR.Id_Rol 

WHERE UR.Id_Usuario = @Id_Usuario
AND r.Estado <> 0
AND r.Baja <> 0
END
GO
/****** Object:  StoredProcedure [allin].[obtenerPregunta]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[obtenerPregunta]
@Id numeric(18,0)
AS
BEGIN
SELECT Pregunta FROM [allin].PreguntasYRespuestas
WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [allin].[listadoMayoresSinCalificaciones]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[listadoMayoresSinCalificaciones]
	@Año smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
		SELECT TOP 5 U.Usuario AS 'Usuario', COUNT(CA.Cant_Estrellas) as 'Cantidad sin calificar'
	FROM [allin].Compra C 
	INNER JOIN [allin].Usuario U ON c.Id_Cliente = u.Id_Usuario
	INNER JOIN [allin].Calificacion CA ON CA.Cod_Calificacion = C.Calificacion_Codigo
	WHERE YEAR(C.Fecha) = @Año AND
	 (MONTH(C.Fecha) = 1 + 3*(@Trimestre-1)OR 
	 MONTH(C.Fecha) = 2 + 3*(@Trimestre-1) OR
	  MONTH(C.Fecha) = 3 + 3*(@Trimestre-1)) AND 
	  CA.Cant_Estrellas = 0
	  AND U.Baja <> 0
		AND U.Estado <> 0
    GROUP BY U.Usuario
    ORDER BY [Cantidad sin calificar] DESC
  
    END
GO
/****** Object:  StoredProcedure [allin].[listadoMayoresFacturacion]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[listadoMayoresFacturacion]
	@Año smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
		SELECT TOP 5 U.Usuario AS 'Usuario', SUM(Total) as 'Facturación'
		
    FROM [allin].Publicacion P 
	INNER JOIN [allin].Factura F ON P.Codigo = F.Pub_Cod
     INNER JOIN [allin].Usuario U ON p.Usuario = u.Id_Usuario
    WHERE YEAR(F.Fecha) = @Año AND (MONTH(F.Fecha) = 1 + 3*(@Trimestre-1) OR MONTH(F.Fecha) = 2 + 3*(@Trimestre-1) OR MONTH(F.Fecha) = 3 + 3*(@Trimestre-1))
		AND U.Baja <> 0
		AND U.Estado <> 0
    GROUP BY U.Id_Usuario, u.Usuario
    ORDER BY Facturación DESC
  
    END
GO
/****** Object:  StoredProcedure [allin].[listadoMayoresCalificaciones]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[listadoMayoresCalificaciones]
	@Año smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
	SELECT TOP 5 U.Usuario AS 'Usuario', AVG(Ca.Cant_Estrellas) as 'Promedio calificación'
	FROM  [allin].Compra C 
		INNER JOIN [allin].Usuario U ON C.Id_Cliente = u.Id_Usuario
		INNER JOIN [allin].Calificacion Ca ON C.Calificacion_Codigo = Ca.Cod_Calificacion
	WHERE YEAR(C.Fecha) = @Año 
		AND(MONTH(C.Fecha) = 1 + 3*(@Trimestre-1) 
		OR MONTH(C.Fecha) = 2 + 3*(@Trimestre-1) 
		OR MONTH(C.Fecha) = 3 + 3*(@Trimestre-1))
		AND Ca.Cant_Estrellas IS NOT NULL AND Ca.Cant_Estrellas <> 0
		AND U.Baja <> 0
		AND U.Estado <> 0

GROUP BY u.Usuario  
ORDER BY [Promedio calificación] DESC
    END
GO
/****** Object:  StoredProcedure [allin].[listadoDeRespYProducto]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[listadoDeRespYProducto]
@Id numeric(18,0)
AS
BEGIN
  SELECT PyR.Pregunta, PyR.Respuesta, PyR.FechaRespuesta,
   P.Descripcion as 'Descripción del Producto', P.Precio, TP.Nombre as 'Tipo de Publicación',
    V.Descripcion as 'Visibilidad', R.Descripcion as 'Rubro' 
    FROM [allin].Publicacion P 
JOIN [allin].Tipo_Publicacion TP ON p.Tipo = TP.Cod_Tipo 
JOIN [allin].Visibilidad V ON P.Visibilidad_Cod = V.Codigo 
JOIN [allin].Publicacion_Rubro PR ON Pr.id_Publicacion = p.Codigo
JOIN [allin].Rubro R ON R.Codigo = pr.id_Rubro
JOIN [allin].PreguntasYRespuestas PyR ON P.Codigo = PyR.Id_Publicacion
  WHERE PyR.UsuarioPregunta = @Id AND
  PyR.Respuesta IS NOT NULL
  
  END
GO
/****** Object:  StoredProcedure [allin].[listadoDePreguntasAResponder]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[listadoDePreguntasAResponder]
@Usuario numeric(18,0)
AS
BEGIN
SELECT Id, Id_Publicacion, u.Usuario, PR.Pregunta FROM [allin].PreguntasYRespuestas PR
INNER JOIN [allin].Publicacion P ON p.Codigo = PR.Id_Publicacion
INNER JOIN [allin].Usuario U ON u.Id_Usuario = PR.UsuarioPregunta
WHERE Respuesta IS NULL 
AND P.Usuario = @Usuario
END
GO
/****** Object:  StoredProcedure [allin].[quitarPublicacionRubro]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[quitarPublicacionRubro]
@codigo Decimal,
@rubro Decimal
AS
BEGIN
DELETE FROM [allin].Publicacion_Rubro
WHERE @codigo = id_Publicacion AND @rubro = id_Rubro
END
GO
/****** Object:  StoredProcedure [allin].[publicacionAFacturar]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [allin].[publicacionAFacturar]
@Codigo numeric (18,0)
as
begin
if(exists (select Codigo_Pub from Compra where Codigo_Pub = @Codigo))
begin
select Compra.Codigo_Pub,compra.Cantidad,tabla.Porcentaje,precioPub, precioVis from 
(select Publicacion.Codigo,Visibilidad.Porcentaje,Visibilidad.Precio as 'precioVis',
 Publicacion.Precio as 'precioPub' from Visibilidad,Publicacion
 where Visibilidad.Codigo= Publicacion.Visibilidad_Cod and Publicacion.Codigo = @Codigo)as tabla,Compra where compra.Codigo_Pub = tabla.Codigo 
end
else
begin
  declare @Cantidad numeric(18,0)
  set @Cantidad = 0
  declare @Visib numeric(18,2)
  set @Visib = 0
  declare @PrecioPub numeric(18,2)
  set @PrecioPub = 0
 (select @Codigo as 'Codigo_Pub',@Cantidad as 'Cantidad', @Visib as 'Porcentaje', @PrecioPub as 'precioPub',
  Visibilidad.Precio as 'precioVis' from Visibilidad,Publicacion
 where Visibilidad.Codigo= Publicacion.Visibilidad_Cod and Publicacion.Codigo = @Codigo)

end
end

GO
/****** Object:  StoredProcedure [allin].[nroFactura]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [allin].[nroFactura]
as
begin 

 SELECT MAX(numero) from [allin].Factura 
end
GO
/****** Object:  StoredProcedure [allin].[cambiarAFacturada]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [allin].[cambiarAFacturada] 
@codcompra numeric (18,0)
as
begin
update compra
set Facturada = 1
where Codigo_Pub = @codcompra
end
GO
/****** Object:  StoredProcedure [allin].[listaSubastasSinConfirmarGanador]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[listaSubastasSinConfirmarGanador]
@id_Cliente numeric(18,0),
@Fecha datetime
AS
BEGIN
SELECT Tabla.Codigo_Pub,SUM(Tabla.Monto) as 'Monto',SUM(Tabla.Id_Cliente) as 'Id_Cliente'
 from
	(SELECT Oferta.Codigo_Pub,Oferta.Monto,Oferta.Id_Cliente
 	FROM 
 	(SELECT Ofer.Codigo_Pub,MAX(Ofer.Monto) as Monto 
	from allin.Oferta as Ofer
	inner join allin.Publicacion
	on Ofer.Codigo_Pub = publicacion.Codigo
	where Publicacion.Usuario = @id_cliente
	and @fecha>Publicacion.Fecha_Venc
	and Ofer.Con_Ganador = 0 and Tipo = 2
	group by Ofer.Codigo_Pub) AS Tabla
	,allin.Oferta
	WHERE Tabla.Codigo_Pub = allin.Oferta.Codigo_Pub
	AND Tabla.Monto = Oferta.Monto
	union all
	select Codigo as 'Codigo_Pub', 0 as 'Monto', 0 as 'Id_Cliente'
	from allin.Publicacion
	where @fecha>Fecha_Venc and Estado <> 4 and @id_cliente = Usuario and Tipo = 2)
	as tabla
	group by tabla.Codigo_Pub
end
GO
/****** Object:  StoredProcedure [allin].[facturasTop]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [allin].[facturasTop] 

@Id numeric (18,0),
@Cant int 
as
begin
select top (@Cant) 
 Codigo,Visibilidad_Cod,Usuario.Usuario from 
 Publicacion
 join Usuario on Usuario.Id_Usuario=Publicacion.Usuario
where Publicacion.Codigo not in (select Pub_Cod from Factura) and Id_Usuario = @Id
and  publicacion.Estado =4
order by publicacion.Fecha desc
end

GO
/****** Object:  StoredProcedure [allin].[listaDePubSinCalificar]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE  [allin].[listaDePubSinCalificar]

@id_Cliente numeric (18,0)

AS
	BEGIN
		SELECT * FROM [allin].Compra join [allin].Calificacion on Cod_Calificacion=Calificacion_Codigo
		
		
		WHERE Id_Cliente = @id_Cliente
		and Cant_Estrellas = 0
		
				order by Fecha
	END
GO
/****** Object:  StoredProcedure [allin].[listaDePublicacionesSinFacturar]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [allin].[listaDePublicacionesSinFacturar]
@id numeric(18,0)
as
begin

		select Codigo,Descripcion,Tipo_Publicacion.Nombre Tipo,Estado.Nombre Estado from Publicacion 
		join Tipo_Publicacion on Tipo=Tipo_Publicacion.Cod_Tipo
		join Estado on Estado.Cod_Estado = publicacion.Estado
		where estado.Nombre='Finalizada'
		and Publicacion.Usuario = @id and Publicacion.Codigo not in (select Pub_Cod from Factura)

end
GO
/****** Object:  StoredProcedure [allin].[listaDePublicaciones]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [allin].[listaDePublicaciones]
		@Descripcion nvarchar(255),
		@Estado nvarchar(255),
		@Tipo nvarchar(255),
		@Visibilidad nvarchar(30),
		@Rubro numeric (18,0),
		@Id numeric (18,0),
		@FechaActual datetime
	AS
	BEGIN
		SELECT P.Codigo, p.Descripcion, p.Stock, p.Fecha, p.Fecha_Venc, p.Precio, tp.Nombre as 'Tipo', v.Descripcion AS 'Visibilidad', e.Nombre as 'Estado', r.Descripcion as 'Rubro', p.Preguntas_permitidas,p.Usuario,Usuario.tipo_Usuario FROM [allin].Publicacion as P
	join [allin].Publicacion_Rubro pr on pr.id_Publicacion = p.Codigo
	JOIN [allin].Rubro r ON r.Codigo = pr.id_Rubro
	JOIN [allin].Visibilidad V ON p.Visibilidad_Cod = v.Codigo
	join [allin].Estado e on e.Cod_Estado=p.Estado
	join [allin].Tipo_Publicacion tp on tp.Cod_Tipo = p.Tipo
	join [allin].Usuario on Usuario.Id_Usuario = p.Usuario
			WHERE
				p.Descripcion like '%'+@Descripcion+'%'
				AND (r.Codigo= @Rubro or @Rubro=0)
				AND tp.Nombre like '%'+@Tipo+'%'
				AND p.Visibilidad_Cod like '%'+@Visibilidad+'%'
				and p.stock > 0
 				and e.Nombre like '%'+@Estado+'%'
 				and p.Fecha_Venc > @FechaActual
 				and (p.Usuario <> @Id )
 				and (e.Nombre = 'Publicada'or e.Nombre = 'Pausada')
 				
				
			order by Visibilidad_Cod

	END
GO
/****** Object:  StoredProcedure [allin].[listaDeMisPublicaciones]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [allin].[listaDeMisPublicaciones]
		@Descripcion nvarchar(255),
		@Estado nvarchar(255),
		@Tipo nvarchar(255),
		@Visibilidad nvarchar(30),
		
		@Rubro nvarchar(30),
		@Id nvarchar(30)
	AS
	BEGIN
		SELECT P.Codigo, p.Descripcion, p.Stock, p.Fecha, p.Fecha_Venc, p.Precio, tp.Nombre as 'Tipo' , v.Descripcion AS 'Visibilidad', p.Visibilidad_Cod, e.Nombre 'Estado', r.Descripcion as 'Rubro', p.Preguntas_permitidas,p.Usuario,Usuario.Tipo_Usuario FROM Publicacion as P
	join Publicacion_Rubro pr on pr.id_Publicacion = p.Codigo
	JOIN Rubro r ON r.Codigo = pr.id_Rubro
	JOIN Visibilidad V ON p.Visibilidad_Cod = v.Codigo
	join Estado e on e.Cod_Estado=p.Estado
	join Tipo_Publicacion tp on tp.Cod_Tipo = p.Tipo
	join Usuario on Usuario.Id_Usuario = p.Usuario
			WHERE
				p.Descripcion like '%'+@Descripcion+'%'
				AND (R.Codigo = @Rubro or @Rubro=0)
				AND TP.Nombre like '%'+@Tipo+'%'
				AND p.Visibilidad_Cod like '%'+@Visibilidad+'%'
				--and p.stock > 0
 				and E.Nombre like '%'+@Estado+'%'
				and (p.Usuario = @Id )
				
			order by Visibilidad_Cod
	END
GO
/****** Object:  Table [allin].[Item_FacturaPublicacion]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Item_FacturaPublicacion](
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
/****** Object:  Table [allin].[Item_FacturaComision]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [allin].[Item_FacturaComision](
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
/****** Object:  StoredProcedure [allin].[historialOfertas]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [allin].[historialOfertas]
		@Id numeric (18,0)
    
   	AS
	BEGIN
		
	SELECT O.Fecha, P.Descripcion, O.Monto, U.Usuario AS 'Vendedor',
	 ( case when  O.Con_ganador = 0 THEN 'No finalizada' ELSE 'Finalizada' END) AS 'Resultado'
    FROM [allin].Publicacion P 
	JOIN [allin].Oferta O ON
    P.Codigo = O.Codigo_Pub
    JOIN [allin].Usuario U ON
    P.Usuario = U.Id_Usuario
	
    WHERE O.Id_Cliente= @Id
    order by O.Fecha
  
    END
GO
/****** Object:  StoredProcedure [allin].[historialCompras]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [allin].[historialCompras]
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
		SELECT C.Fecha, P.Descripcion, C.Cantidad, U.Usuario AS 'Vendedor'
		
    FROM [allin].Publicacion P
	JOIN [allin].Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN [allin].Usuario U ON
    P.Usuario = U.Id_Usuario
	
    WHERE C.Id_Cliente = @Id
    order by C.Fecha
  
    END
GO
/****** Object:  StoredProcedure [allin].[historialCalificacionesRecibidas]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [allin].[historialCalificacionesRecibidas]
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
		SELECT C.Fecha, P.Descripcion, U.Usuario AS 'Comprador',cal.Cant_Estrellas AS 'Estrellas', cal.Descripcion AS 'Opinion'
		
    FROM [allin].Publicacion P 
	JOIN [allin].Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN [allin].Usuario U ON
    u.Id_Usuario = c.Id_Cliente
   join [allin].Calificacion cal on cal.Cod_Calificacion=c.Calificacion_Codigo
	
    WHERE P.Usuario = @Id
    order by C.Fecha
  
    END
GO
/****** Object:  StoredProcedure [allin].[historialCalificacionesOtorgadas]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [allin].[historialCalificacionesOtorgadas]
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
		SELECT C.Fecha, P.Descripcion, U.Usuario AS 'Vendedor', cal.Cant_Estrellas AS 'Estrellas', cal.Descripcion AS 'Opinion'
		
    FROM [allin].Publicacion P 
	JOIN [allin].Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN [allin].Usuario U ON
    P.Usuario = U.Id_Usuario
	join [allin].Calificacion cal on Calificacion_Codigo=Cod_Calificacion
    WHERE C.Id_Cliente = @Id
    and Cant_Estrellas <>0
    order by C.Fecha
  
    END
GO
/****** Object:  StoredProcedure [allin].[filtrarRubro]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[filtrarRubro]
@Descripcion nvarchar(255),
@codigo numeric(18,0),
@flag nvarchar(255)
AS
BEGIN
IF(@codigo = 0)
begin
	SELECT Codigo, Descripcion FROM [allin].Rubro
	WHERE Descripcion like '%'+@Descripcion+'%'
end
if(@flag = 'quitar')
begin
	SELECT Codigo, Descripcion FROM [allin].Rubro
	where Descripcion like '%'+@Descripcion+'%' AND codigo IN(select r.codigo from [allin].Publicacion p 
																   Inner join [allin].Publicacion_Rubro pr ON pr.id_Publicacion = p.Codigo
															       INNER JOIN [allin].Rubro r on pr.id_Rubro = r.codigo
																   where p.codigo = @codigo)
end
if(@flag = 'agregar')
begin
	select Codigo, Descripcion from [allin].Rubro 
	Where Descripcion like '%'+@Descripcion+'%' AND codigo NOT IN( select r.codigo from [allin].Publicacion p 
																   Inner join [allin].Publicacion_Rubro pr ON pr.id_Publicacion = p.Codigo
															       INNER JOIN [allin].Rubro r on pr.id_Rubro = r.codigo
																   where p.codigo = @codigo)
end
END
GO
/****** Object:  StoredProcedure [allin].[cambiarConGanador]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [allin].[cambiarConGanador]
@Codigo numeric (18,0)
as
begin
update Oferta SET Con_Ganador = 1 WHERE Codigo_Pub = @Codigo
update Publicacion set Estado = 4 where Codigo = @Codigo
end
/****** Object:  StoredProcedure [allin].[buscarMaximaOferta]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[buscarMaximaOferta]
@Cod_Pub numeric(18,0)
AS
BEGIN
select MAX(monto) from [allin].Oferta
where Codigo_Pub = @Cod_Pub
END
GO
/****** Object:  StoredProcedure [allin].[buscarIdMaximaOferta]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [allin].[buscarIdMaximaOferta]
@Cod_Pub numeric(18,0)
AS
BEGIN
select o.Id_Cliente from [allin].Oferta o

where o.Monto=(select MAX(monto) montomax from [allin].Oferta where  Codigo_Pub = @Cod_Pub)


END
GO
/****** Object:  StoredProcedure [allin].[buscarDatosPublicacion]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[buscarDatosPublicacion]

@Codigo numeric(18,0)
AS
BEGIN
SELECT * from [allin].Publicacion P
JOIN [allin].Publicacion_Rubro PR on P.Codigo = PR.id_Publicacion 
WHERE Codigo = @Codigo
END
GO
/****** Object:  StoredProcedure [allin].[agregarUnaPregunta]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[agregarUnaPregunta]
@UsuarioPreg numeric(18,0),
@Id_Publicacion numeric(18,0),
@Pregunta nvarchar(255)
AS
BEGIN
INSERT INTO [allin].PreguntasYRespuestas(UsuarioPregunta,
Pregunta,
Id_Publicacion)
VALUES(@UsuarioPreg,
@Pregunta,
@Id_Publicacion)
END
GO
/****** Object:  StoredProcedure [allin].[agregarRespuesta]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[agregarRespuesta]
@Id numeric(18,0),
@Respuesta nvarchar(255),
@Fecha datetime
AS
BEGIN
UPDATE [allin].PreguntasYRespuestas
SET Respuesta = @Respuesta, FechaRespuesta = @Fecha
WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [allin].[agregarPublicacionRubro]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[agregarPublicacionRubro]
@codigo Decimal,
@rubro Decimal
AS
BEGIN
INSERT INTO [allin].Publicacion_Rubro
VALUES(@codigo,@rubro)
END
GO
/****** Object:  StoredProcedure [allin].[agregarNuevoClienteUsuario]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[agregarNuevoClienteUsuario]
		@Dni nvarchar(64),
		@Nombre nvarchar(255),
		@Apellido nvarchar(255),
		@Fecha_Nac Datetime,
		@Mail nvarchar(255),
		@Dom_Calle nvarchar(255),
		@Nro_Calle numeric(18,0),
		@Piso numeric(18,0),
		@Depto nvarchar(50),
		@Cod_Postal nvarchar(50),
		@Localidad nvarchar(255),
		@Tipo_dni smallint,
		@Telefono nvarchar(255),
		@IdUsuario numeric(18,0)
		
AS
BEGIN
DECLARE @IdUsuario2 numeric(18,0)
IF(@IdUsuario = 0)
BEGIN
EXEC [allin].darDeAltaUsuario @Mail, @Dni, 1 , 10, 0

SET @IdUsuario2 = (SELECT Id_Usuario FROM [allin].Usuario WHERE 
Usuario = @Mail AND Password = @Dni)

exec [allin].agregarNuevoCliente @Dni, @Nombre , @Apellido,@Fecha_Nac,@Mail,@Dom_Calle,@Nro_Calle,@Piso,
	@Depto,	@Cod_Postal,@Localidad,	@Tipo_dni,@Telefono, @IdUsuario2
END
else
exec [allin].agregarNuevoCliente @Dni, @Nombre , @Apellido,@Fecha_Nac,@Mail,@Dom_Calle,@Nro_Calle,@Piso,
	@Depto,	@Cod_Postal,@Localidad,	@Tipo_dni,@Telefono, @IdUsuario 
END
GO
/****** Object:  StoredProcedure [allin].[agregarNuevaPublicacion]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[agregarNuevaPublicacion]
		
		@Visibilidad numeric(18,0),
		@Tipo numeric(18,0),
		@Stock numeric(18,0),
		@Precio numeric(18,2),
		@Fecha datetime,
		@Estado numeric(18,0),
		@Rubro numeric(18,0),
		@Descripcion nvarchar(255),
		@Permitir_Preguntas bit,
		@Fecha_Venc datetime,
		@Usuario numeric(18,0)
 
AS
BEGIN
	
	DECLARE @idPub numeric(18,0)
	
	SET @idPub = (SELECT MAX(Codigo)+1 from [allin].Publicacion)
	
	INSERT INTO [allin].Publicacion(
	Codigo,
	Visibilidad_Cod,
	Tipo,
	Stock,
	Precio,
	Estado,
	Descripcion,
	Preguntas_permitidas,
	Fecha,
	Fecha_Venc,
	Usuario)
	
	VALUES(
	@idPub,
	@Visibilidad,
	@Tipo,
	@Stock,
	@Precio,
	@Estado,
	@Descripcion,
	@Permitir_Preguntas,
	@Fecha,
	@Fecha_Venc,
	@Usuario)
	
	INSERT INTO [allin].Publicacion_Rubro(id_Publicacion, id_Rubro)
	VALUES(@idPub,@Rubro)

END
GO
/****** Object:  StoredProcedure [allin].[agregarNuevaOferta]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [allin].[agregarNuevaOferta]
		@Cod_Pub numeric(18,0),
		@Monto numeric(18,2),
		@Id_Cli numeric(18,0),
		@Fecha datetime

AS
BEGIN
	INSERT INTO [allin].Oferta(
	Codigo_Pub,
	Fecha,
	Monto,
	Id_Cliente,
	Con_Ganador)
	VALUES(
	@Cod_Pub,
	@Fecha,
	@Monto,
	@Id_Cli,
	0)	

END
GO
/****** Object:  StoredProcedure [allin].[agregarNuevaEmpresaUsuario]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[agregarNuevaEmpresaUsuario]
		@RazonSocial nvarchar(255),
		@Cuit nvarchar(255),
		@Fecha_Creacion Datetime,
		@Mail nvarchar(255),
		@Dom_Calle nvarchar(255),
		@Nro_Calle numeric(18,0),
		@Piso numeric(18,0),
		@Depto nvarchar(50),
		@Cod_Postal nvarchar(50),
		@Localidad nvarchar(255),	
		@Telefono nvarchar(255),
		@Ciudad nvarchar(255),
		@Nombre_Contacto nvarchar(255),
		@IdUsuario numeric(18,0)
AS
BEGIN
IF(@IdUsuario = 0)
		BEGIN
			DECLARE @IdUsuario2 numeric(18,0)
			EXEC [allin].darDeAltaUsuario @Mail, @Cuit, 2 , 10, 0
			
			SET @IdUsuario2 = (SELECT Id_Usuario FROM [allin].Usuario WHERE 
			Usuario = @Mail AND Password = @Cuit)
			
			EXEC [allin].agregarNuevaEmpresa @RazonSocial ,@Cuit,@Fecha_Creacion ,@Mail ,@Dom_Calle,@Nro_Calle,@Piso,@Depto,@Cod_Postal ,@Localidad,	
					@Telefono,@Ciudad,@Nombre_Contacto,@IdUsuario2
		END
ELSE

		EXEC [allin].agregarNuevaEmpresa @RazonSocial ,@Cuit,@Fecha_Creacion ,@Mail ,@Dom_Calle,@Nro_Calle,@Piso,@Depto,@Cod_Postal ,@Localidad,	
				@Telefono,@Ciudad,@Nombre_Contacto,@IdUsuario
END
GO
/****** Object:  StoredProcedure [allin].[agregarFactura]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [allin].[agregarFactura]

@Codigo numeric (18,0),
@Precio numeric (18,2),
@Tipo_Pago smallint,
@Nro_Fac numeric (18,0),
@Fecha datetime
AS 
BEGIN
insert into [allin].Factura
(
Numero,
Fecha,
Total,
Forma_Pago_Desc,
Pub_Cod
)
VALUES
( @Nro_Fac,
@Fecha,
@Precio,
@Tipo_Pago,
@Codigo)
eND
GO
/****** Object:  StoredProcedure [allin].[agregarCompra]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [allin].[agregarCompra]
		@Codigo numeric(18,0),
		@Id numeric(18,0),
		@Stock numeric(18,0),
		@Fecha datetime

AS
BEGIN
	insert into [allin].Calificacion(Cod_Calificacion,Cant_Estrellas) 
	values ((select MAX(Cod_Calificacion)+1 from [allin].Calificacion),0)
	
DECLARE @Cod_Calif numeric(18,0)
SET @Cod_Calif = (select MAX(Cod_Calificacion) from [allin].Calificacion)

	INSERT INTO [allin].Compra(
	Codigo_Pub,
	Id_Cliente,
	Fecha,
	Cantidad,
	Calificacion_Codigo,
	facturada)
	VALUES(
	@Codigo,
	@Id,
	@Fecha,
	@Stock,
	@Cod_Calif,
	0)
END
GO
/****** Object:  StoredProcedure [allin].[agregarCalificacion]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [allin].[agregarCalificacion]

@Id numeric (18,0),
@Cant_Est numeric (18,0),
@Desc nvarchar(255)
AS 
BEGIN
declare @codcal numeric(18,0)
 (select @codcal=Calificacion_Codigo from [allin].Compra where @Id=compra.Id)  

UPDATE [allin].Calificacion
SET Cant_Estrellas= @Cant_Est,
Descripcion= @Desc

WHERE @codcal=Cod_Calificacion
END
GO
/****** Object:  StoredProcedure [allin].[agregarItemFacturaPublicacion]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [allin].[agregarItemFacturaPublicacion]
@Codigo numeric (18,0),
@Precio numeric (18,2),
@Nro_Fact numeric (18,2),
@Cant numeric (18,0)

AS 
BEGIN
insert into [allin].Item_FacturaPublicacion
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
GO
/****** Object:  StoredProcedure [allin].[agregarItemFacturaComision]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [allin].[agregarItemFacturaComision]

@Codigo numeric (18,0),
@Precio numeric (18,2),
@Nro_Fact numeric (18,2)

AS 
BEGIN
insert into [allin].Item_FacturaComision
(Pub_Cod,
Nro_Fact,
Monto
)
VALUES
( @Codigo,
@Nro_Fact,
@Precio)
END
GO
/****** Object:  StoredProcedure [allin].[obtenerIdRol]    Script Date: 07/17/2014 18:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [allin].[obtenerIdRol]
@NombreRol nvarchar(30)
AS
BEGIN
SELECT Id From [allin].Rol
WHERE Nombre = @NombreRol
END
GO
/****** Object:  ForeignKey [FK_Clientes_Tipo_Doc]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Tipo_Doc] FOREIGN KEY([Tipo_Doc])
REFERENCES [allin].[Tipo_Doc] ([Codigo])
GO
ALTER TABLE [allin].[Clientes] CHECK CONSTRAINT [FK_Clientes_Tipo_Doc]
GO
/****** Object:  ForeignKey [FK_Clientes_Usuario]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [allin].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [allin].[Clientes] CHECK CONSTRAINT [FK_Clientes_Usuario]
GO
/****** Object:  ForeignKey [FK_Compra_Calificacion]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Calificacion] FOREIGN KEY([Calificacion_Codigo])
REFERENCES [allin].[Calificacion] ([Cod_Calificacion])
GO
ALTER TABLE [allin].[Compra] CHECK CONSTRAINT [FK_Compra_Calificacion]
GO
/****** Object:  ForeignKey [FK_Compra_Publicacion]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Publicacion] FOREIGN KEY([Codigo_Pub])
REFERENCES [allin].[Publicacion] ([Codigo])
GO
ALTER TABLE [allin].[Compra] CHECK CONSTRAINT [FK_Compra_Publicacion]
GO
/****** Object:  ForeignKey [FK_Compra_Usuario]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Usuario] FOREIGN KEY([Id_Cliente])
REFERENCES [allin].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [allin].[Compra] CHECK CONSTRAINT [FK_Compra_Usuario]
GO
/****** Object:  ForeignKey [FK_Empresa_Usuario]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Empresa]  WITH CHECK ADD  CONSTRAINT [FK_Empresa_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [allin].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [allin].[Empresa] CHECK CONSTRAINT [FK_Empresa_Usuario]
GO
/****** Object:  ForeignKey [FK_Factura_Publicacion]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Publicacion] FOREIGN KEY([Pub_Cod])
REFERENCES [allin].[Publicacion] ([Codigo])
GO
ALTER TABLE [allin].[Factura] CHECK CONSTRAINT [FK_Factura_Publicacion]
GO
/****** Object:  ForeignKey [FK_Factura_Tipo_Pago]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Tipo_Pago] FOREIGN KEY([Forma_Pago_Desc])
REFERENCES [allin].[Tipo_Pago] ([Codigo])
GO
ALTER TABLE [allin].[Factura] CHECK CONSTRAINT [FK_Factura_Tipo_Pago]
GO
/****** Object:  ForeignKey [FK__Func_Rol__id_Fun__766D4B53]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Func_Rol]  WITH CHECK ADD FOREIGN KEY([id_Func])
REFERENCES [allin].[Funcionalidades] ([id_funcionabilidad])
GO
/****** Object:  ForeignKey [FK__Func_Rol__id_Rol__77616F8C]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Func_Rol]  WITH CHECK ADD FOREIGN KEY([id_Rol])
REFERENCES [allin].[Rol] ([Id])
GO
/****** Object:  ForeignKey [FK_Item_FacturaComision_Factura]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Item_FacturaComision]  WITH CHECK ADD  CONSTRAINT [FK_Item_FacturaComision_Factura] FOREIGN KEY([Nro_Fact], [Pub_Cod])
REFERENCES [allin].[Factura] ([Numero], [Pub_Cod])
GO
ALTER TABLE [allin].[Item_FacturaComision] CHECK CONSTRAINT [FK_Item_FacturaComision_Factura]
GO
/****** Object:  ForeignKey [FK_Item_FacturaPublicacion_Factura]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Item_FacturaPublicacion]  WITH CHECK ADD  CONSTRAINT [FK_Item_FacturaPublicacion_Factura] FOREIGN KEY([Nro_Fact], [Pub_Cod])
REFERENCES [allin].[Factura] ([Numero], [Pub_Cod])
GO
ALTER TABLE [allin].[Item_FacturaPublicacion] CHECK CONSTRAINT [FK_Item_FacturaPublicacion_Factura]
GO
/****** Object:  ForeignKey [FK_Oferta_Publicacion]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Oferta]  WITH CHECK ADD  CONSTRAINT [FK_Oferta_Publicacion] FOREIGN KEY([Codigo_Pub])
REFERENCES [allin].[Publicacion] ([Codigo])
GO
ALTER TABLE [allin].[Oferta] CHECK CONSTRAINT [FK_Oferta_Publicacion]
GO
/****** Object:  ForeignKey [FK_Oferta_Usuario]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Oferta]  WITH CHECK ADD  CONSTRAINT [FK_Oferta_Usuario] FOREIGN KEY([Id_Cliente])
REFERENCES [allin].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [allin].[Oferta] CHECK CONSTRAINT [FK_Oferta_Usuario]
GO
/****** Object:  ForeignKey [FK_PreguntasYRespuestas_Publicacion]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[PreguntasYRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_PreguntasYRespuestas_Publicacion] FOREIGN KEY([Id_Publicacion])
REFERENCES [allin].[Publicacion] ([Codigo])
GO
ALTER TABLE [allin].[PreguntasYRespuestas] CHECK CONSTRAINT [FK_PreguntasYRespuestas_Publicacion]
GO
/****** Object:  ForeignKey [FK_PreguntasYRespuestas_Usuario]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[PreguntasYRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_PreguntasYRespuestas_Usuario] FOREIGN KEY([UsuarioPregunta])
REFERENCES [allin].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [allin].[PreguntasYRespuestas] CHECK CONSTRAINT [FK_PreguntasYRespuestas_Usuario]
GO
/****** Object:  ForeignKey [FK_Publicacion_Estado]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Estado] FOREIGN KEY([Estado])
REFERENCES [allin].[Estado] ([Cod_Estado])
GO
ALTER TABLE [allin].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Estado]
GO
/****** Object:  ForeignKey [FK_Publicacion_Tipo_Publicacion]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Tipo_Publicacion] FOREIGN KEY([Tipo])
REFERENCES [allin].[Tipo_Publicacion] ([Cod_Tipo])
GO
ALTER TABLE [allin].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Tipo_Publicacion]
GO
/****** Object:  ForeignKey [FK_Publicacion_Usuario]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Usuario] FOREIGN KEY([Usuario])
REFERENCES [allin].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [allin].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Usuario]
GO
/****** Object:  ForeignKey [FK_Publicacion_Visibilidad]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Visibilidad] FOREIGN KEY([Visibilidad_Cod])
REFERENCES [allin].[Visibilidad] ([Codigo])
GO
ALTER TABLE [allin].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Visibilidad]
GO
/****** Object:  ForeignKey [FK_Publicacion_Rubro_Publicacion]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Publicacion_Rubro]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Rubro_Publicacion] FOREIGN KEY([id_Publicacion])
REFERENCES [allin].[Publicacion] ([Codigo])
GO
ALTER TABLE [allin].[Publicacion_Rubro] CHECK CONSTRAINT [FK_Publicacion_Rubro_Publicacion]
GO
/****** Object:  ForeignKey [FK_Publicacion_Rubro_Rubro]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Publicacion_Rubro]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Rubro_Rubro] FOREIGN KEY([id_Rubro])
REFERENCES [allin].[Rubro] ([Codigo])
GO
ALTER TABLE [allin].[Publicacion_Rubro] CHECK CONSTRAINT [FK_Publicacion_Rubro_Rubro]
GO
/****** Object:  ForeignKey [FK_Usuario_Rol_Rol]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Usuario_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol_Rol] FOREIGN KEY([Id_Rol])
REFERENCES [allin].[Rol] ([Id])
GO
ALTER TABLE [allin].[Usuario_Rol] CHECK CONSTRAINT [FK_Usuario_Rol_Rol]
GO
/****** Object:  ForeignKey [FK_Usuario_Rol_Usuario]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [allin].[Usuario_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [allin].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [allin].[Usuario_Rol] CHECK CONSTRAINT [FK_Usuario_Rol_Usuario]
GO

--Carga Tabla Tipos de Documentos
INSERT INTO [allin].Tipo_DOC VALUES (1,'DNI')
INSERT INTO [allin].Tipo_Doc VALUES (2,'CUIT')
INSERT INTO [allin].Tipo_Doc VALUES (3,'LE')
INSERT INTO [allin].Tipo_Doc VALUES (4,'LC')


 --carga tabla rol
 
INSERT INTO [allin].Rol VALUES ('Cliente',1,1)
INSERT INTO [allin].rol VALUES ('Empresa',1,1)
INSERT INTO [allin].rol VALUES ('Admin',1,1)

--Carga Tabla Tipos de Pago
INSERT INTO [allin].Tipo_Pago VALUES (1,'Efectivo')
INSERT INTO [allin].Tipo_Pago VALUES (2,'Tarjeta de crédito')
INSERT INTO [allin].Tipo_Pago VALUES (3,'Tarjeta de débito')
INSERT INTO [allin].Tipo_Pago VALUES (4,'Transferencia')
INSERT INTO [allin].Tipo_Pago VALUES (5,'Depósito bancario')

--migracion tabla usuario

insert into [allin].Usuario
select distinct m.Cli_Mail,'C',Convert(nvarchar,m.Cli_Dni),10,0,1
 from gd_esquema.Maestra M
 where  m.Cli_Dni IS NOT NULL
 
union all
 select distinct m.Publ_Empresa_Mail,'E',m.Publ_Empresa_Cuit,10,0,1
 from gd_esquema.Maestra m
 where Publ_Empresa_Cuit is not null


insert into [allin].Usuario_Rol
select u.Id_Usuario, r.Id ,1 From [allin].Usuario u, [allin].Rol r
WHERE u.Tipo_Usuario = 'C'
AND r.Nombre = 'Cliente'

union all 
select u2.Id_Usuario, r2.Id, 1 From [allin].Usuario u2, [allin].Rol r2
WHERE u2.Tipo_Usuario = 'E'
AND r2.Nombre = 'Empresa'

-- Migracion tabla cliente

insert into [allin].Clientes 
select distinct u.Id_Usuario ,CONVERT(nvarchar,M.Cli_Dni) as dni,1,cli_nombre, cli_apeliido , Cli_Fecha_Nac,
Cli_Mail,cli_dom_calle,cli_nro_calle,Cli_Piso,Cli_Depto,Cli_Cod_Postal,'',''
FROM gd_esquema.Maestra M INNER JOIN [allin].Usuario U ON CONVERT(nvarchar,M.Cli_Dni) = u.password
WHERE Cli_Dni IS NOT NULL

-- Migracion tabla empresa

insert into [allin].Empresa

select distinct u.Id_Usuario,'',Publ_Empresa_Razon_Social,Publ_Empresa_Cuit,Publ_Empresa_Fecha_Creacion,
		Publ_Empresa_Mail,Publ_Empresa_Dom_Calle,Publ_Empresa_Nro_Calle,
		Publ_Empresa_Piso,Publ_Empresa_Depto,Publ_Empresa_Cod_Postal,'','',''
		
from gd_esquema.Maestra INNER JOIN [allin].Usuario U ON Publ_Empresa_Cuit = u.password

where Publ_Empresa_Cuit is not null

-- Migracion tabla rubro

insert into [allin].Rubro

select distinct Publicacion_Rubro_Descripcion
from gd_esquema.Maestra

where Publicacion_Rubro_Descripcion is not null

-- Migracion tabla visibilidad

insert into [allin].Visibilidad

select distinct Publicacion_Visibilidad_Cod,Publicacion_Visibilidad_Desc,Publicacion_Visibilidad_Precio,Publicacion_Visibilidad_Porcentaje,1,7
from gd_esquema.Maestra

where Publicacion_Visibilidad_Cod is not null

--Migracion tabla estado publicacion
insert into [allin].estado
select distinct  Publicacion_Estado
from gd_esquema.Maestra

Insert into [allin].Estado Values('Borrador')
Insert into [allin].Estado Values('Pausada')
Insert into [allin].Estado Values('Finalizada')

--Migracion tabla Tipo_Pub
insert into [allin].Tipo_Publicacion
select distinct  Publicacion_Tipo
from gd_esquema.Maestra


-- Migracion tabla publicacion

insert into [allin].Publicacion
select distinct Publicacion_Cod,Publicacion_Descripcion,0,
Publicacion_Fecha,Publicacion_Fecha_Venc,Publicacion_Precio,[allin].Tipo_Publicacion.cod_tipo,
Publicacion_Visibilidad_Cod,[allin].Estado.cod_estado,0,[allin].usuario.Id_Usuario
from gd_esquema.Maestra,[allin].Rubro,[allin].Clientes,[allin].Tipo_Publicacion,[allin].estado,[allin].Usuario
where Publicacion_Cod is not null
and Publicacion_Tipo = [allin].tipo_publicacion.nombre
and Publicacion_Estado = [allin].estado.nombre
and Usuario.Usuario = [allin].Clientes.Mail
and Publ_Cli_Dni is not null
and CONVERT(nvarchar,Publ_Cli_Dni) = [allin].Clientes.Nro_Documento
and Publicacion_Rubro_Descripcion = [allin].Rubro.Descripcion
UNION ALL
select distinct Publicacion_Cod,Publicacion_Descripcion,0,
Publicacion_Fecha,Publicacion_Fecha_Venc,Publicacion_Precio,[allin].Tipo_Publicacion.cod_tipo,
Publicacion_Visibilidad_Cod,[allin].Estado.cod_estado,0,[allin].usuario.Id_Usuario
from gd_esquema.Maestra,[allin].Rubro, [allin].Empresa,[allin].Tipo_Publicacion,[allin].Usuario,[allin].estado
where Publicacion_Cod is not null
and Publ_Empresa_Cuit  is not null
and [allin].Usuario.Usuario = [allin].Empresa.Mail
and Publicacion_Estado = [allin].Estado.nombre
and Publicacion_Tipo = [allin].tipo_publicacion.nombre
and Publ_empresa_cuit = [allin].empresa.Nro_Documento
and Publicacion_Rubro_Descripcion = [allin].Rubro.Descripcion

--Migracion Publicacion_Rubro
insert into [allin].Publicacion_Rubro

select distinct Publicacion_Cod,[allin].Rubro.codigo
from gd_esquema.Maestra,[allin].Rubro
where [allin].Rubro.Descripcion = Publicacion_Rubro_Descripcion


-- migracion tabla factura

insert into [allin].Factura

select distinct Factura_Nro,factura_Fecha,Factura_Total,1,publicacion_cod from gd_esquema.Maestra

where Factura_Nro is not null

-- migracion tabla item_facturaPublicacion

insert into [allin].Item_FacturaPublicacion

select  Publicacion_Cod,Factura_Nro,Item_Factura_Monto,Item_Factura_Cantidad

from gd_esquema.Maestra

where Factura_Nro is not null
and Item_Factura_Monto <> Publicacion_Visibilidad_Precio

-- migracion tabla item_facturaComision

insert into [allin].Item_FacturaComision

select  distinct Publicacion_Cod,Factura_Nro,Item_Factura_Monto

from gd_esquema.Maestra

where Factura_Nro is not null
and Item_Factura_Monto = Publicacion_Visibilidad_Precio

-- migracion tabla calificacion
insert into [allin].calificacion
 select distinct Calificacion_Codigo,Calificacion_Cant_Estrellas/2,Calificacion_Descripcion
 from gd_esquema.Maestra
 where Calificacion_Codigo is not null
 and Calificacion_Cant_Estrellas is not null

-- migracion tabla compra
insert into [allin].Compra

select distinct Publicacion_Cod,[allin].Clientes.Id_Usuario,
Compra_Fecha,Compra_Cantidad,Calificacion_Codigo,1


from gd_esquema.Maestra, [allin].Clientes

where CONVERT(nvarchar,Cli_Dni) = [allin].Clientes.Nro_Documento
and Publicacion_Cod is not null
and Calificacion_Codigo is not null
and Compra_Fecha is not null
and Compra_Cantidad is not null

-- migracion tabla oferta

insert into [allin].Oferta

select distinct Publicacion_Cod,Oferta_Fecha,Oferta_Monto,[allin].Clientes.Id_Usuario,1

from gd_esquema.Maestra, [allin].Clientes


where CONVERT(nvarchar,Cli_Dni) = [allin].Clientes.Nro_Documento
and Publicacion_Cod is not null
and [allin].Clientes.Id_Cliente is not null
and oferta_fecha is not null

--cargar tabla funcionabilidades
insert into [allin].Funcionalidades values(1,'Ejecutar ABM Cliente');
insert into [allin].Funcionalidades values(2,'Ejecutar ABM Empresa');
insert into [allin].Funcionalidades values(3,'Ejecutar ABM Rol');
insert into [allin].Funcionalidades values(4,'Ejecutar ABM Visibilidad');
insert into [allin].Funcionalidades values(5,'Cambiar contraseña a los usuarios');
insert into [allin].Funcionalidades values(6,'Mostrar listado estadístico');

insert into [allin].Funcionalidades values(10,'Generar publicación');
insert into [allin].Funcionalidades values(11,'Mostrar historial cliente');
insert into [allin].Funcionalidades values(12,'Buscar publicaciones');
insert into [allin].Funcionalidades values(13,'Facturar publicaciones');
insert into [allin].Funcionalidades values(14,'Ejecutar gestor de preguntas');
insert into [allin].Funcionalidades values(15,'Subastas pendientes');
insert into [allin].Funcionalidades values(16,'Editar usuario');
insert into [allin].Funcionalidades values(17,'Editar publicaciones');
insert into [allin].Funcionalidades values(18,'Listar preguntas a responder');
insert into [allin].Funcionalidades values(19,'Subastas pendiente');
insert into [allin].Funcionalidades values(20,'Calificaciones pendiente');


--cargar tabla funcionabilidades
--Lo que hace el admin
INSERT INTO [allin].Func_Rol VALUES(3,1)
INSERT INTO [allin].Func_Rol VALUES(3,2)
INSERT INTO [allin].Func_Rol VALUES(3,3)
INSERT INTO [allin].Func_Rol VALUES(3,4)
INSERT INTO [allin].Func_Rol VALUES(3,5)
INSERT INTO [allin].Func_Rol VALUES(3,6)
--Lo que hace el cliente
INSERT INTO [allin].Func_Rol VALUES(1,12)
INSERT INTO [allin].Func_Rol VALUES(1,14)
INSERT INTO [allin].Func_Rol VALUES(1,10)
INSERT INTO [allin].Func_Rol VALUES(1,11)
INSERT INTO [allin].Func_Rol VALUES(1,16)
INSERT INTO [allin].Func_Rol VALUES(1,13)
INSERT INTO [allin].Func_Rol VALUES(1,20)
INSERT INTO [allin].Func_Rol VALUES(1,15)
--Lo que hace una empresa
INSERT INTO [allin].Func_Rol VALUES(2,17)
INSERT INTO [allin].Func_Rol VALUES(2,15)
INSERT INTO [allin].Func_Rol VALUES(2,10)
INSERT INTO [allin].Func_Rol VALUES(2,16)
INSERT INTO [allin].Func_Rol VALUES(2,13)
INSERT INTO [allin].Func_Rol VALUES(2,18)
INSERT INTO [allin].Func_Rol VALUES(2,14)

--Administrador
INSERT INTO [allin].Usuario VALUES(
'admin','A','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',1,0,1)
Declare @Id_Usuario numeric(18,0)
set @Id_Usuario = (Select id_Usuario From [allin].Usuario where Usuario = 'admin')
exec [allin].agregarNuevoClienteUsuario 0,'Administrador','ApellidoAdmin','20000101','admin@mail','Dom_admin',0,0,'D','0','Admin',1,'000',@Id_Usuario
exec [allin].agregarNuevaEmpresaUsuario 'razonAdmin','00','20000101','admin@mail','Dom_admin',0,0,'D','0','Loc_admin','0','CiudadAdmin','Administrador',@Id_Usuario

INSERT INTO [allin].Usuario_Rol VALUES(@Id_Usuario,3,1)
insert into [allin].Usuario_Rol VALUES(@Id_Usuario,2,1)
insert into [allin].Usuario_Rol VALUES(@Id_Usuario,1,1)
/****** Object:  Trigger [Trig_Insert_Usuario]    Script Date: 07/12/2014 02:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [allin].[Trig_Insert_Usuario] ON [allin].[Usuario]
AFTER INSERT
AS
BEGIN
DECLARE @Id_Usuario numeric(18,0), @Id_Rol numeric(18,0), @Rol char(1)
SET @Id_Usuario = (Select Id_Usuario From inserted)
SET @Rol = (Select Tipo_Usuario from inserted)

SET @Id_Rol = (CASE @Rol 
				WHEN 'C'THEN 1
				WHEN 'E' THEN 2
				ELSE 3 
				END)
				
INSERT INTO [allin].Usuario_Rol VALUES(@Id_Usuario, @Id_Rol,1)
END
GO

create index ix_Pub on [allin].Publicacion (codigo)


