USE [GD1C2014]
GO

/****** Object:  Table [dbo].[Calificacion]    Script Date: 07/13/2014 03:35:14 ******/
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
/****** Object:  Table [dbo].[Estado]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[Cod_Estado] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](255) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[Cod_Estado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funcionalidades]    Script Date: 07/13/2014 03:35:14 ******/
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
/****** Object:  Table [dbo].[Rubro]    Script Date: 07/13/2014 03:35:14 ******/
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
/****** Object:  Table [dbo].[Rol]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
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
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tipo_Publicacion]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Publicacion](
	[Cod_Tipo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Tipo_Publicacion] PRIMARY KEY CLUSTERED 
(
	[Cod_Tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Pago]    Script Date: 07/13/2014 03:35:14 ******/
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
/****** Object:  Table [dbo].[Tipo_Doc]    Script Date: 07/13/2014 03:35:14 ******/
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
/****** Object:  Table [dbo].[Visibilidad]    Script Date: 07/13/2014 03:35:14 ******/
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
/****** Object:  Table [dbo].[Usuario_Rol]    Script Date: 07/13/2014 03:35:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Rol](
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
/****** Object:  StoredProcedure [dbo].[obtenerVisibilidad]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerVisibilidad]
@Cod_visib numeric(18,0)
AS
BEGIN
SELECT Descripcion from Visibilidad
WHERE Codigo = @Cod_visib
END
GO
/****** Object:  StoredProcedure [dbo].[seleccionVisibilidadNotNull]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[seleccionVisibilidadNotNull]
AS
BEGIN 
SELECT Codigo, Descripcion FROM Visibilidad
WHERE Estado <> 0
END
GO
/****** Object:  StoredProcedure [dbo].[obtenerNombreTipoPublicacion]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerNombreTipoPublicacion]
@tipo numeric(18,0)
AS
BEGIN
SELECT Nombre from Tipo_Publicacion
WHERE Cod_Tipo = @tipo
END
GO
/****** Object:  StoredProcedure [dbo].[obtenerNombreIdRol]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerNombreIdRol]
@Id_Rol numeric(18,0)
AS
BEGIN
SELECT nombre FROM Rol 
WHERE Id = @Id_Rol
END
GO
/****** Object:  StoredProcedure [dbo].[obtenerEstado]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerEstado]
@Id_Rol numeric(18,0)
AS
BEGIN
SELECT Estado FROM Rol
WHERE Id = @Id_Rol
END
GO
/****** Object:  StoredProcedure [dbo].[obtenerDescripcionRubro]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerDescripcionRubro]
@IdRubro numeric(18,0)
AS
BEGIN
SELECT Descripcion from Rubro
WHERE Codigo = @IdRubro
END
GO
/****** Object:  StoredProcedure [dbo].[obtenerCodTipoPublicacion]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerCodTipoPublicacion]
@tipo nvarchar(255)
AS
BEGIN
SELECT Cod_Tipo from Tipo_Publicacion
WHERE Nombre = @tipo
END
GO
/****** Object:  StoredProcedure [dbo].[obtenerCodRubro]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerCodRubro]
@Descripcion nvarchar(255)
AS
BEGIN
SELECT Codigo from Rubro
WHERE Descripcion = @Descripcion
END
GO
/****** Object:  StoredProcedure [dbo].[obtenerCodEstadoPublicacion]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerCodEstadoPublicacion]
@estado nvarchar(255)
AS
BEGIN
SELECT Cod_Estado from Estado
WHERE Nombre = @estado
END
GO
/****** Object:  StoredProcedure [dbo].[listaDeVisibilidades]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listaDeVisibilidades]
		@Codigo nvarchar(18),
		@Descripcion nvarchar(255),
		@Precio nvarchar(18),
		@Porcentaje nvarchar(18)
		
	AS
	BEGIN
		SELECT Codigo, Descripcion,Precio, Porcentaje,Vencimiento FROM Visibilidad
			WHERE
				Codigo like '%'+@Codigo+'%'
				AND Descripcion like '%'+@Descripcion+'%'
				AND	Precio like '%'+@Precio+'%'
				AND Porcentaje like '%'+@Porcentaje+'%'
				AND Estado = 1
				
	END
GO
/****** Object:  StoredProcedure [dbo].[filtrarRol]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[filtrarRol]
@Rol nvarchar(50),
@Filtrado int
AS
BEGIN
IF(@Filtrado = 1)
BEGIN
SELECT Id, Nombre FROM Rol
WHERE Nombre like '%'+@Rol+'%'
AND Baja = 1
END
ELSE
BEGIN
SELECT Id, Nombre FROM Rol
WHERE Nombre like '%'+@Rol+'%'
AND Estado <> 0
AND Baja = 1
END
end
GO
/****** Object:  StoredProcedure [dbo].[estaHabilitado]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[estaHabilitado]
@Id numeric (18,0)
AS
BEGIN
SELECT estado from Usuario 
where Id_Usuario = @Id
END
GO
/****** Object:  Table [dbo].[Func_Rol]    Script Date: 07/13/2014 03:35:14 ******/
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
/****** Object:  Table [dbo].[Empresa]    Script Date: 07/13/2014 03:35:14 ******/
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
/****** Object:  Table [dbo].[Publicacion]    Script Date: 07/13/2014 03:35:14 ******/
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
/****** Object:  Table [dbo].[Clientes]    Script Date: 07/13/2014 03:35:14 ******/
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
/****** Object:  StoredProcedure [dbo].[buscarUsuarioCliente]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[buscarUsuarioCliente]
@Id numeric(18,0)
AS
BEGIN
	SELECT usuario FROM Usuario
		WHERE 
		@Id =Id_Usuario
		and Tipo_usuario = 'C'
END
GO
/****** Object:  StoredProcedure [dbo].[darDeBajaVisibilidad]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[darDeBajaVisibilidad]
@Codigo numeric(18,0)
AS
BEGIN
UPDATE Visibilidad
SET Estado = 0, Descripcion = null
WHERE Codigo = @Codigo
END
GO
/****** Object:  StoredProcedure [dbo].[darDeBajaRol]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[darDeBajaRol]
@Rol numeric(18,0)
AS
BEGIN
UPDATE Rol
SET Baja = 0, Estado = 0
WHERE Id = @Rol
END
GO
/****** Object:  StoredProcedure [dbo].[darDeAltaUsuario]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[darDeAltaUsuario]
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


INSERT INTO Usuario(Usuario,Tipo_Usuario,Password,Estado,Intentos,Baja)
VALUES(@UsuarioName,@Tipo_User,@Password,@Estado,@Intentos,1)
END
GO
/****** Object:  StoredProcedure [dbo].[buscarNombreUsuario]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarNombreUsuario]
@IdUsuario numeric(18,0),
@TipoUsuario char(1)
AS
BEGIN
SELECT Usuario FROM Usuario
WHERE @TipoUsuario = Tipo_Usuario AND
@IdUsuario = Id_Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[buscarMiIDUsuario]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarMiIDUsuario]
@UserName nvarchar(50)
AS
BEGIN
SELECT Id_Usuario From Usuario 
WHERE Usuario = @UserName
END
GO
/****** Object:  StoredProcedure [dbo].[buscarIdRol]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarIdRol]
@Rol_Nombre nvarchar(50)
AS
BEGIN
SELECT Id FROM Rol 
WHERE Nombre = @Rol_Nombre
END
GO
/****** Object:  StoredProcedure [dbo].[buscarPublicador]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarPublicador]
@Usuario nvarchar(50)
AS
BEGIN
	SELECT * FROM Usuario 
		WHERE 
		Usuario = @Usuario;
END
GO
/****** Object:  StoredProcedure [dbo].[buscarUnaVisibilidad]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarUnaVisibilidad]
@Codigo numeric(18,0)
AS
BEGIN
	SELECT * FROM Visibilidad
		WHERE 
		Codigo = @Codigo;
END
GO
/****** Object:  StoredProcedure [dbo].[buscarDuracionVisibilidad]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarDuracionVisibilidad]
@Visibilidad nvarchar(50)
AS
BEGIN
	SELECT * FROM Visibilidad 
		WHERE 
		Codigo = @Visibilidad;
END
GO
/****** Object:  StoredProcedure [dbo].[buscarCamposDeUsuario]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarCamposDeUsuario]
@Usuario nvarchar(50)
AS
BEGIN
SELECT Password,Id_Usuario,Intentos, Estado FROM Usuario
WHERE Usuario = @Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[agregarNuevaVisibilidad]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarNuevaVisibilidad]
		@Codigo numeric(18,0),
		@Descripcion nvarchar(255),
		@Precio numeric(18,2),
		@Porcentaje numeric(18,2),
		@Estado smallint,
		@Vencimiento smallint

AS
BEGIN
	INSERT INTO Visibilidad(
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
/****** Object:  StoredProcedure [dbo].[actualizarContraseña]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarContraseña]
@Usuario numeric(18,0),
@Contraseña nvarchar(64)
AS
BEGIN
UPDATE Usuario
SET Password = @Contraseña
WHERE Id_Usuario = @Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[actualizarEstadoDelUsuario]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarEstadoDelUsuario]
@Estado smallint,
@Id numeric(18,0)
AS
BEGIN
UPDATE Usuario
SET Estado = @Estado
WHERE Id_Usuario = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[actualizarNombreRol]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarNombreRol]
@Id_Rol numeric(18,0),
@Nombre_New nvarchar(30)
AS
BEGIN
UPDATE Rol 
SET Nombre = @Nombre_New
WHERE Id = @Id_Rol
END
GO
/****** Object:  StoredProcedure [dbo].[actualizarIntentos]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarIntentos]
@Usuario numeric(18,0),
@Intentos int
AS
BEGIN
UPDATE Usuario
SET Intentos = @Intentos
WHERE
@Usuario = Id_Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarVisibilidad]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarVisibilidad]
@Codigo numeric(18,0),
@Descripcion nvarchar(255),
@Precio numeric(18,2),
@Porcentaje numeric(18,2),
@Vencimiento smallint
AS 
BEGIN
UPDATE Visibilidad
SET Descripcion = @Descripcion, Precio = @Precio , Porcentaje = @Porcentaje,Vencimiento = @Vencimiento
WHERE Codigo = @Codigo
End
GO
/****** Object:  StoredProcedure [dbo].[actualizarStock]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actualizarStock]

@Codigo numeric (18,0),
@Stock numeric (18,0)
AS 
BEGIN
UPDATE Publicacion
SET Stock = (Stock - @Stock)
WHERE Codigo = @Codigo 
END
GO
/****** Object:  StoredProcedure [dbo].[actualizarEstadoRol]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarEstadoRol]
@Id_Rol numeric(18,0),
@Estado smallint
AS
BEGIN
UPDATE Rol
SET Estado = @Estado
WHERE Id = @Id_Rol

UPDATE Usuario_Rol
SET Estado = @Estado 
WHERE Id_Rol = @Id_Rol
END
GO
/****** Object:  StoredProcedure [dbo].[actualizarEmpresa]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarEmpresa]
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
UPDATE Empresa 
SET Razon_Social = @RazonSocial, Nombre_Contacto = @Nombre_Contacto, Ciudad = @Ciudad, Piso = @Piso, 
Localidad = @Localidad, Cod_Postal = @Cod_Postal, Depto = @Depto, Nro_Calle = @Nro_Calle, Dom_Calle = @Dom_Calle, 
Mail = @Mail, Fecha_Creacion = @Fecha_Creacion, Nro_Documento = @Cuit , Telefono = @Telefono
WHERE Id_Usuario = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[actualizarCliente]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarCliente]
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
UPDATE Clientes
SET Apellido = @Apellido, Nombre = @Nombre , Nro_Documento = @Dni, Fecha_Nac = @Fecha_Nac, Mail = @Mail, Dom_Calle = @Dom_Calle,
Nro_Calle = @Nro_Calle, Piso = @Piso, Depto = @Piso, Cod_Postal = @Cod_Postal, Localidad = @Localidad,
Tipo_Doc = @Tipo_dni, Telefono = @Telefono
WHERE Id_Usuario = @Id
End
GO
/****** Object:  StoredProcedure [dbo].[agregarNuevaEmpresa]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarNuevaEmpresa]
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
	INSERT INTO Empresa(
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
/****** Object:  StoredProcedure [dbo].[agregarFuncionabilidadAlRol]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarFuncionabilidadAlRol]
@Id_Rol numeric(18,0),
@Id_Funcionabilidad int
AS
BEGIN
INSERT INTO Func_Rol(Id_Rol,
Id_Func)
VALUES(@Id_Rol, @Id_Funcionabilidad)
END
GO
/****** Object:  StoredProcedure [dbo].[agregarNuevoCliente]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarNuevoCliente]
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
	INSERT INTO Clientes(
	Id_Usuario,	Nro_Documento,Nombre,Apellido,Fecha_Nac,Mail,Dom_Calle,Nro_Calle,Piso,Depto,
	Cod_Postal,	Localidad,Tipo_Doc,	Telefono)
	VALUES(@IdUsuario, @Dni, @Nombre,@Apellido,@Fecha_Nac,@Mail,@Dom_Calle,@Nro_Calle,@Piso,
	@Depto,	@Cod_Postal,@Localidad,	@Tipo_dni,@Telefono )	
	END
GO
/****** Object:  StoredProcedure [dbo].[agregarNuevoRol]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarNuevoRol]
@Rol_Nombre nvarchar(30)
AS
DECLARE @Id_Rol numeric(18,0)
BEGIN
INSERT Rol(Nombre, Estado, Baja)
VALUES(@Rol_Nombre, 1,1)
END
GO
/****** Object:  StoredProcedure [dbo].[averiguarStock]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[averiguarStock]
@Codigo numeric(18,0)
AS
BEGIN

select Stock from Publicacion where Codigo = @Codigo
end
GO
/****** Object:  StoredProcedure [dbo].[buscarIdEmpresa]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[buscarIdEmpresa]
@Cuit nvarchar(255)
AS
BEGIN
SELECT Id_Usuario from Empresa
WHERE Nro_Documento = @Cuit
END
GO
/****** Object:  StoredProcedure [dbo].[buscarFuncionalidades]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarFuncionalidades]
@rol nvarchar(50)
AS
BEGIN
SELECT FR.id_Func from Func_Rol FR 
INNER JOIN Rol R ON FR.id_Rol = R.Id 
WHERE 
R.Nombre = @rol
END
GO
/****** Object:  StoredProcedure [dbo].[buscarUsuarioCod]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarUsuarioCod]
@Codigo numeric(18,0)
AS
BEGIN
	SELECT Usuario FROM Publicacion 
		WHERE 
		Codigo = @Codigo;
END
GO
/****** Object:  StoredProcedure [dbo].[buscarUnaSolaEmpresa]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarUnaSolaEmpresa]
@Id numeric (18,0)
AS 
BEGIN
SELECT e.Id_Usuario,e.Razon_Social, e.Nro_Documento, e.Fecha_Creacion, e.Mail, e.Dom_Calle,
 e.Nro_Calle, e.Piso, e.Depto, e.Cod_Postal, e.Localidad, e.Telefono, e.Ciudad, e.Nombre_Contacto FROM Empresa e

WHERE e.Id_Usuario = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[buscarPrecio]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarPrecio]
@Cod_Pub numeric(18,0)
AS
BEGIN
SELECT Precio FROM Publicacion
WHERE Codigo = @Cod_Pub
END
GO
/****** Object:  StoredProcedure [dbo].[buscarIdPorPublicacion]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[buscarIdPorPublicacion]
@Codigo numeric(18,0)
AS
BEGIN

select Usuario from Publicacion where Codigo = @Codigo
end
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 07/13/2014 03:35:14 ******/
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
	[Facturada] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[darDeBajaAUsuario]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[darDeBajaAUsuario]
@Id_Usuario numeric(18,0),
@Id_Rol numeric(18,0)
AS
BEGIN
UPDATE Usuario
SET Baja = 0, Estado = 0
WHERE Id_Usuario = @Id_Usuario

UPDATE Publicacion
SET Estado = 4
WHERE Publicacion.Usuario = @Id_Usuario

IF(@Id_Rol = 1)
BEGIN
UPDATE Clientes
SET  Nro_Documento = 0, Telefono = null
where Id_Usuario = @Id_Usuario
END
ELSE IF(@Id_Rol = 2)
BEGIN
UPDATE Empresa 
SET  Nro_Documento = 0, Telefono = null
where Id_Usuario = @Id_Usuario
END

END
GO
/****** Object:  StoredProcedure [dbo].[buscarUnSoloCliente]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarUnSoloCliente]
@Id numeric(18,0)
AS
BEGIN
	SELECT  u.Usuario,c.Nro_Documento, c.Nombre, c.Apellido, c.Fecha_Nac, c.Mail, c.Dom_Calle,
	c.Nro_Calle, c.Piso, c.Depto, c.Cod_Postal, c.Localidad,t.Nombre,c.Telefono FROM Clientes c 
	INNER JOIN Tipo_Doc t ON t.Codigo = c.Tipo_Doc
	join Usuario u on c.Id_Usuario = u.Id_Usuario
		WHERE 
		c.Id_Usuario = @Id;
END
GO
/****** Object:  Table [dbo].[PreguntasYRespuestas]    Script Date: 07/13/2014 03:35:14 ******/
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
/****** Object:  Table [dbo].[Oferta]    Script Date: 07/13/2014 03:35:14 ******/
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
/****** Object:  Table [dbo].[Factura]    Script Date: 07/13/2014 03:35:14 ******/
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
/****** Object:  StoredProcedure [dbo].[esBonificada]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[esBonificada]
@Id numeric (18,0),

@Visibilidad numeric (18,0)
as
begin
select Codigo,Usuario,Visibilidad_Cod,Fecha, RowNumber  
from (select Codigo, Usuario, Visibilidad_Cod, Fecha,row_number() over(order by Codigo,usuario,Visibilidad_Cod,Fecha)as RowNumber
  from Publicacion
  where Usuario = @Id AND Visibilidad_Cod = @Visibilidad) as Pub 
where RowNumber % 10 = 0
end
GO
/****** Object:  StoredProcedure [dbo].[editarPublicacionPublicada]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[editarPublicacionPublicada]
		
		
		@Stock numeric(18,0),
		@Descripcion nvarchar(255),
		@Estado Decimal,
		@Codigo numeric(18,0)

 
AS
BEGIN
	UPDATE Publicacion
SET  Stock = @Stock, Descripcion = @Descripcion,
Estado = @Estado
WHERE Codigo = @Codigo

END
GO
/****** Object:  StoredProcedure [dbo].[editarPublicacionBorradorAPublicada]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[editarPublicacionBorradorAPublicada]
		
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

	UPDATE Publicacion
SET Visibilidad_Cod = @Visibilidad, Tipo = @Tipo , Stock = @Stock, Precio = @Precio, Descripcion = @Descripcion,
Estado = @Estado, Preguntas_permitidas = @Permitir_Preguntas, Fecha_Venc = @Fecha_Venc, Fecha = @Fecha
WHERE Codigo = @Codigo
	
	

END
GO
/****** Object:  StoredProcedure [dbo].[editarPublicacionBorrador]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[editarPublicacionBorrador]
		
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

	UPDATE Publicacion
SET Visibilidad_Cod = @Visibilidad, Tipo = @Tipo , Stock = @Stock, Precio = @Precio, Descripcion = @Descripcion,
Estado = @Estado, Preguntas_permitidas = @Permitir_Preguntas
WHERE Codigo = @Codigo
	
	

END
GO
/****** Object:  StoredProcedure [dbo].[listaDeEmpresas]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listaDeEmpresas]
@Razon_Social nvarchar(255),
@CUIT nvarchar(50),
@Mail nvarchar(50)
AS
BEGIN
SELECT e.Id_Usuario, e.Nombre_Contacto, e.Razon_Social as 'Razón Social', e.Nro_Documento as 'Nro de Documento', e.Fecha_Creacion as 'Fecha de Creación',e.Mail,
e.Dom_Calle as 'Domicilio', e.Nro_Calle as 'Nro domicilio',e.Piso,e.Depto, e.Cod_Postal,e.Localidad, e.Ciudad, e.Telefono FROM Empresa e

WHERE
Razon_Social LIKE '%'+@Razon_Social+'%' AND
Mail LIKE '%'+@Mail+'%' AND
(@CUIT = [Nro_Documento] or @CUIT = '' or @CUIT = '  -        -')
AND Nro_Documento <> '0'
END
GO
/****** Object:  StoredProcedure [dbo].[listaDeCliente]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listaDeCliente]
		@Nombre nvarchar(255),
		@Apellido nvarchar(255),
		@Dni nvarchar(50),
		@Mail nvarchar(255),
		@Tipo_dni nvarchar(1)
	AS
	BEGIN
		SELECT c.Id_Usuario, c.Nombre, c.Apellido, td.Nombre as 'Tipo de documento', c.Nro_Documento as 'Nro documento', c.Fecha_Nac as 'Fecha de Nacimiento', c.Mail, c.Dom_Calle as 'Domicilio',
		c.Nro_Calle as 'Nro domicilio', c.Piso, c.Depto, c.Localidad, c.Telefono FROM Clientes c 
		INNER JOIN Tipo_Doc TD ON c.Tipo_Doc = TD.Codigo
			WHERE
				c.Nombre like '%'+@Nombre+'%'
				AND Apellido like '%'+@Apellido+'%'
				AND Nro_Documento like '%'+@Dni+'%'
				AND Nro_Documento <> '0'
				AND Mail like '%'+@Mail+'%'
				AND ((c.Tipo_Doc = @Tipo_dni AND @Tipo_dni <>0) OR @Tipo_dni = 0)
				
	END
GO
/****** Object:  StoredProcedure [dbo].[listadodeFunc]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listadodeFunc]
@Id_Rol numeric(18,0)
AS
BEGIN
IF(@Id_Rol = 0)
BEGIN
SELECT f.id_funcionabilidad as 'ID', f.nom_funcionalidad as 'Nombre' FROM Funcionalidades f 
END
ELSE
BEGIN
SELECT f.id_funcionabilidad as 'ID', f.nom_funcionalidad as 'Nombre' FROM Funcionalidades f 
INNER JOIN Func_Rol fr ON f.id_funcionabilidad = fr.id_Func
WHERE fr.id_Rol = @Id_Rol
END
END

select * from Rol
exec listadodeFunc 12
GO
/****** Object:  StoredProcedure [dbo].[quitarRol]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[quitarRol]
@Id_Rol int,
@funcionalidad int
AS
BEGIN
DELETE Func_Rol
WHERE Id_Rol = @Id_Rol AND
Id_Func = @funcionalidad
END
GO
/****** Object:  StoredProcedure [dbo].[verificarTresGratuitas]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[verificarTresGratuitas]
@Usuario numeric(18,0)
AS
BEGIN
SELECT COUNT(Visibilidad_Cod) from Publicacion
WHERE Usuario = @Usuario AND Visibilidad_Cod = 10006 AND Codigo > 68380 AND Estado = 1
END
GO
/****** Object:  StoredProcedure [dbo].[verificarEstado]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[verificarEstado]
@Codigo numeric(18,0)
AS
BEGIN
	SELECT Estado FROM Publicacion 
		WHERE 
		Codigo = @Codigo;
END
GO
/****** Object:  Table [dbo].[Publicacion_Rubro]    Script Date: 07/13/2014 03:35:14 ******/
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
/****** Object:  StoredProcedure [dbo].[listadoVendedoresQueVendenMenos]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listadoVendedoresQueVendenMenos]
@Año smallint,
@Visibilidad numeric(18,0),
@Mes int
AS
BEGIN
IF(@Visibilidad <> 0)
BEGIN
SELECT TOP 5 u.Usuario, SUM(Stock) as 'Stock Total', v.Descripcion as 'Visibilidad' from publicacion P
INNER JOIN Usuario U ON p.Usuario = U.Id_Usuario
INNER JOIN Visibilidad V on v.Codigo = p.Visibilidad_Cod
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
SELECT TOP 5 u.Usuario, SUM(Stock) as 'Stock Total', v.Descripcion as 'Visibilidad' from publicacion P
INNER JOIN Usuario U ON p.Usuario = U.Id_Usuario
INNER JOIN Visibilidad V on v.Codigo = p.Visibilidad_Cod
WHERE p.Estado <> 4 AND p.Estado <> 2
AND YEAR(p.Fecha) = @Año 
AND MONTH(p.Fecha) = @Mes
AND U.Baja <> 0
AND U.Estado <> 0
group by u.Usuario, v.Descripcion
order by [Stock Total] DESC, v.Descripcion
END
GO
/****** Object:  StoredProcedure [dbo].[obtenerTodosLosRoles]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerTodosLosRoles]
@Id_Usuario numeric(18,0)
AS
BEGIN
SELECT UR.Id_Rol, r.Nombre From Usuario_Rol UR 
INNER JOIN Rol R ON R.Id = UR.Id_Rol 

WHERE UR.Id_Usuario = @Id_Usuario
AND r.Estado <> 0
AND r.Baja <> 0
END
GO
/****** Object:  StoredProcedure [dbo].[obtenerPregunta]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerPregunta]
@Id numeric(18,0)
AS
BEGIN
SELECT Pregunta FROM PreguntasYRespuestas
WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[listadoMayoresSinCalificaciones]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listadoMayoresSinCalificaciones]
	@Año smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
		SELECT TOP 5 U.Usuario AS 'Usuario', COUNT(CA.Cant_Estrellas) as 'Cantidad sin calificar'
	FROM Compra C 
	INNER JOIN Usuario U ON c.Id_Cliente = u.Id_Usuario
	INNER JOIN Calificacion CA ON CA.Cod_Calificacion = C.Calificacion_Codigo
	WHERE YEAR(C.Fecha) = @Año AND
	 (MONTH(C.Fecha) = 1 + 3*(@Trimestre-1)OR 
	 MONTH(C.Fecha) = 2 + 3*(@Trimestre-1) OR
	  MONTH(C.Fecha) = 3 + 3*(@Trimestre-1)) AND 
	  CA.Cant_Estrellas IS NULL
	  AND U.Baja <> 0
		AND U.Estado <> 0
    GROUP BY U.Usuario
    ORDER BY [Cantidad sin calificar] DESC
  
    END
GO
/****** Object:  StoredProcedure [dbo].[listadoMayoresFacturacion]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listadoMayoresFacturacion]
	@Año smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
		SELECT TOP 5 U.Usuario AS 'Usuario', SUM(Total) as 'Facturación'
		
    FROM Publicacion P 
	INNER JOIN Factura F ON P.Codigo = F.Pub_Cod
     INNER JOIN Usuario U ON p.Usuario = u.Id_Usuario
    WHERE YEAR(F.Fecha) = @Año AND (MONTH(F.Fecha) = 1 + 3*(@Trimestre-1) OR MONTH(F.Fecha) = 2 + 3*(@Trimestre-1) OR MONTH(F.Fecha) = 3 + 3*(@Trimestre-1))
		AND U.Baja <> 0
		AND U.Estado <> 0
    GROUP BY U.Id_Usuario, u.Usuario
    ORDER BY Facturación DESC
  
    END
GO
/****** Object:  StoredProcedure [dbo].[listadoMayoresCalificaciones]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listadoMayoresCalificaciones]
	@Año smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
	SELECT TOP 5 U.Usuario AS 'Usuario', AVG(Ca.Cant_Estrellas) as 'Promedio calificación'
	FROM  Compra C 
		INNER JOIN Usuario U ON C.Id_Cliente = u.Id_Usuario
		INNER JOIN Calificacion Ca ON C.Calificacion_Codigo = Ca.Cod_Calificacion
	WHERE YEAR(C.Fecha) = @Año 
		AND(MONTH(C.Fecha) = 1 + 3*(@Trimestre-1) 
		OR MONTH(C.Fecha) = 2 + 3*(@Trimestre-1) 
		OR MONTH(C.Fecha) = 3 + 3*(@Trimestre-1))
		AND Ca.Cant_Estrellas IS NOT NULL
		AND U.Baja <> 0
		AND U.Estado <> 0

GROUP BY u.Usuario  
ORDER BY [Promedio calificación] DESC
    END
GO
/****** Object:  StoredProcedure [dbo].[listadoDeRespYProducto]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listadoDeRespYProducto]
@Id numeric(18,0)
AS
BEGIN
  SELECT PyR.Pregunta, PyR.Respuesta, PyR.FechaRespuesta,
   P.Descripcion as 'Descripción del Producto', P.Precio, TP.Nombre as 'Tipo de Publicación',
    V.Descripcion as 'Visibilidad', R.Descripcion as 'Rubro' 
    FROM Publicacion P 
JOIN Tipo_Publicacion TP ON p.Tipo = TP.Cod_Tipo 
JOIN Visibilidad V ON P.Visibilidad_Cod = V.Codigo 
JOIN Publicacion_Rubro PR ON Pr.id_Publicacion = p.Codigo
JOIN Rubro R ON R.Codigo = pr.id_Rubro
JOIN PreguntasYRespuestas PyR ON P.Codigo = PyR.Id_Publicacion
  WHERE PyR.UsuarioPregunta = @Id AND
  PyR.Respuesta IS NOT NULL
  
  END
GO
/****** Object:  StoredProcedure [dbo].[listadoDePreguntasAResponder]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listadoDePreguntasAResponder]
@Usuario numeric(18,0)
AS
BEGIN
SELECT Id, Id_Publicacion, u.Usuario, PR.Pregunta FROM PreguntasYRespuestas PR
INNER JOIN Publicacion P ON p.Codigo = PR.Id_Publicacion
INNER JOIN Usuario U ON u.Id_Usuario = PR.UsuarioPregunta
WHERE Respuesta IS NULL 
AND P.Usuario = @Usuario
END


select *from Publicacion
GO
/****** Object:  StoredProcedure [dbo].[quitarPublicacionRubro]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[quitarPublicacionRubro]
@codigo Decimal,
@rubro Decimal
AS
BEGIN
DELETE FROM Publicacion_Rubro
WHERE @codigo = id_Publicacion AND @rubro = id_Rubro
END
GO
/****** Object:  StoredProcedure [dbo].[publicacionAFacturar]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[publicacionAFacturar]
@Codigo numeric (18,0)
as
begin

select Compra.Codigo_Pub,compra.Cantidad,tabla.Porcentaje,precioPub, precioVis from 

(select Publicacion.Codigo,Visibilidad.Porcentaje,Visibilidad.Precio as 'precioVis', Publicacion.Precio as 'precioPub' from Visibilidad,Publicacion

where  Visibilidad.Codigo= Publicacion.Visibilidad_Cod and Publicacion.Codigo = @Codigo
)as tabla,Compra where compra.Codigo_Pub = tabla.Codigo 

end
GO
/****** Object:  StoredProcedure [dbo].[nroFactura]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[nroFactura]
as
begin 

 SELECT MAX(numero) from Factura 
end
GO
/****** Object:  StoredProcedure [dbo].[listaSubastasSinConfirmarGanador]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[listaSubastasSinConfirmarGanador]
@id_Cliente numeric(18,0),
@Fecha datetime
AS
BEGIN

SELECT Oferta.Codigo_Pub,Oferta.Monto,Oferta.Id_Cliente
FROM 
(SELECT Ofer.Codigo_Pub,MAX(Ofer.Monto) as Monto 
from Oferta as Ofer
inner join Publicacion
on Ofer.Codigo_Pub = publicacion.Codigo
where Publicacion.Usuario = @id_Cliente
and @Fecha>Ofer.Fecha
and Ofer.Con_Ganador = 0
group by Ofer.Codigo_Pub) AS Tabla
,Oferta
WHERE Tabla.Codigo_Pub = Oferta.Codigo_Pub
AND   Tabla.Monto = Oferta.Monto
END
GO
/****** Object:  StoredProcedure [dbo].[facturasTop]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[facturasTop]

@Id numeric (18,0),
@Cant int 
as
begin
select top (@Cant) 
 Codigo,Visibilidad_Cod,Usuario.Usuario from Publicacion 
 join Usuario on Usuario.Id_Usuario=Publicacion.Usuario
where Codigo not in(select Pub_Cod from Factura)
and Id_Usuario = @Id
order by Fecha desc

end
GO
/****** Object:  StoredProcedure [dbo].[listaDePubSinCalificar]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE  [dbo].[listaDePubSinCalificar]

@id_Cliente numeric (18,0)

AS
	BEGIN
		SELECT * FROM Compra join Calificacion on Cod_Calificacion=Calificacion_Codigo
		
		
		WHERE Id_Cliente = @id_Cliente
		and Cant_Estrellas = 0
		
				order by Fecha
	END
GO
/****** Object:  StoredProcedure [dbo].[listaDePublicacionesSinFacturar]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listaDePublicacionesSinFacturar]

@id numeric (18,0)
as
begin
select Codigo,Descripcion,Tipo_Publicacion.Nombre Tipo,Estado.Nombre Estado from Publicacion 
join Tipo_Publicacion on Tipo=Tipo_Publicacion.Cod_Tipo
join Estado on Estado.Cod_Estado = publicacion.Estado
join Compra on compra.Codigo_Pub=Publicacion.Codigo
where Compra.facturada = 0
and Publicacion.Usuario = @id
end
GO
/****** Object:  StoredProcedure [dbo].[listaDePublicaciones]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[listaDePublicaciones]
		@Descripcion nvarchar(255),
		@Estado nvarchar(255),
		@Tipo nvarchar(255),
		@Visibilidad nvarchar(30),
		--@Rol nvarchar(10),
		@Rubro numeric (18,0),
		@Id numeric (18,0),
		@FechaActual datetime
	AS
	BEGIN
		SELECT P.Codigo, p.Descripcion, p.Stock, p.Fecha, p.Fecha_Venc, p.Precio, tp.Nombre as 'Tipo', v.Descripcion AS 'Visibilidad', e.Nombre as 'Estado', r.Descripcion as 'Rubro', p.Preguntas_permitidas,p.Usuario,Usuario.tipo_Usuario FROM Publicacion as P
	join Publicacion_Rubro pr on pr.id_Publicacion = p.Codigo
	JOIN Rubro r ON r.Codigo = pr.id_Rubro
	JOIN Visibilidad V ON p.Visibilidad_Cod = v.Codigo
	join Estado e on e.Cod_Estado=p.Estado
	join Tipo_Publicacion tp on tp.Cod_Tipo = p.Tipo
	join Usuario on Usuario.Id_Usuario = p.Usuario
			WHERE
				p.Descripcion like '%'+@Descripcion+'%'
				AND (r.Codigo= @Rubro or @Rubro=0)
				AND tp.Nombre like '%'+@Tipo+'%'
				AND p.Visibilidad_Cod like '%'+@Visibilidad+'%'
				and p.stock > 0
 				and e.Nombre like '%'+@Estado+'%'
 				and p.Fecha_Venc > @FechaActual
 				--and p.Fecha < @FechaActual
 				and (p.Usuario <> @Id )
 				and e.Nombre = 'Publicada'
 				
				
			order by Visibilidad_Cod

	END
GO
/****** Object:  StoredProcedure [dbo].[listaDeMisPublicaciones]    Script Date: 07/13/2014 03:35:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listaDeMisPublicaciones]
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
				and p.stock > 0
 				and E.Nombre like '%'+@Estado+'%'
				and (p.Usuario = @Id )
				
			order by Visibilidad_Cod
	END
GO
/****** Object:  Table [dbo].[Item_FacturaPublicacion]    Script Date: 07/13/2014 03:35:14 ******/
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
/****** Object:  Table [dbo].[Item_FacturaComision]    Script Date: 07/13/2014 03:35:14 ******/
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
/****** Object:  StoredProcedure [dbo].[historialOfertas]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[historialOfertas]
		@Id numeric (18,0)
    
   	AS
	BEGIN
		
	SELECT O.Fecha, P.Descripcion, O.Monto, U.Usuario AS 'Vendedor',
	 ( case when  O.Con_ganador = 0 THEN 'No finalizada' ELSE 'Finalizada' END) AS 'Resultado'
		--CASE WHEN C.Id_Cliente = O.Id_Cliente AND C.Codigo_Pub = O.Codigo_Pub
    FROM Publicacion P 
	JOIN Oferta O ON
    P.Codigo = O.Codigo_Pub
   -- JOIN Compra C ON
  --  P.Codigo = C.Codigo_Pub
    JOIN Usuario U ON
    P.Usuario = U.Id_Usuario
	
    WHERE O.Id_Cliente= @Id
    order by O.Fecha
  
    END
GO
/****** Object:  StoredProcedure [dbo].[historialCompras]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[historialCompras]
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
		SELECT C.Fecha, P.Descripcion, C.Cantidad, U.Usuario AS 'Vendedor'
		
    FROM Publicacion P
	JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN Usuario U ON
    P.Usuario = U.Id_Usuario
	
    WHERE C.Id_Cliente = @Id
    order by C.Fecha
  
    END
GO
/****** Object:  StoredProcedure [dbo].[historialCalificacionesRecibidas]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[historialCalificacionesRecibidas]
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
		SELECT C.Fecha, P.Descripcion, U.Usuario AS 'Comprador',cal.Cant_Estrellas AS 'Estrellas', cal.Descripcion AS 'Opinion'
		
    FROM Publicacion P 
	JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN Usuario U ON
    u.Id_Usuario = p.Usuario
   -- (C.Id_Cliente = U.Id_Usuario AND U.Id_Rol = 1)
   join Calificacion cal on cal.Cod_Calificacion=c.Calificacion_Codigo
	
    WHERE P.Usuario = @Id
    order by C.Fecha
  
    END
GO
/****** Object:  StoredProcedure [dbo].[historialCalificacionesOtorgadas]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[historialCalificacionesOtorgadas]
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
		SELECT C.Fecha, P.Descripcion, U.Usuario AS 'Vendedor', cal.Cant_Estrellas AS 'Estrellas', cal.Descripcion AS 'Opinion'
		
    FROM Publicacion P 
	JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN Usuario U ON
  -- P.Publicador = (CASE WHEN U.Id_Rol = 1 THEn    'C' WHEN U.Id_Rol = 2 THen    'E'END) 
    P.Usuario = U.Id_Usuario
	join Calificacion cal on Calificacion_Codigo=Cod_Calificacion
    WHERE C.Id_Cliente = @Id
    and Cant_Estrellas <>0
    order by C.Fecha
  
    END
GO
/****** Object:  StoredProcedure [dbo].[filtrarRubro]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[filtrarRubro]
@Descripcion nvarchar(255),
@codigo numeric(18,0),
@flag nvarchar(255)
AS
BEGIN
IF(@codigo = 0)
begin
	SELECT Codigo, Descripcion FROM Rubro
	WHERE Descripcion like '%'+@Descripcion+'%'
end
if(@flag = 'quitar')
begin
	SELECT Codigo, Descripcion FROM Rubro
	where Descripcion like '%'+@Descripcion+'%' AND codigo IN(select r.codigo from Publicacion p 
																   Inner join Publicacion_Rubro pr ON pr.id_Publicacion = p.Codigo
															       INNER JOIN Rubro r on pr.id_Rubro = r.codigo
																   where p.codigo = @codigo)
end
if(@flag = 'agregar')
begin
	select Codigo, Descripcion from Rubro 
	Where Descripcion like '%'+@Descripcion+'%' AND codigo NOT IN( select r.codigo from Publicacion p 
																   Inner join Publicacion_Rubro pr ON pr.id_Publicacion = p.Codigo
															       INNER JOIN Rubro r on pr.id_Rubro = r.codigo
																   where p.codigo = @codigo)
end
END
GO
/****** Object:  StoredProcedure [dbo].[cambiarConGanador]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[cambiarConGanador]
@Codigo numeric (18,0)
as
begin
update Oferta SET Con_Ganador = 1 WHERE Codigo_Pub = @Codigo
end
GO
/****** Object:  StoredProcedure [dbo].[buscarMaximaOferta]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarMaximaOferta]
@Cod_Pub numeric(18,0)
AS
BEGIN
select MAX(monto) from Oferta
where Codigo_Pub = @Cod_Pub
END
GO
/****** Object:  StoredProcedure [dbo].[buscarIdMaximaOferta]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[buscarIdMaximaOferta]
@Cod_Pub numeric(18,0)
AS
BEGIN
select o.Id_Cliente from Oferta o

where o.Monto=(select MAX(monto) montomax from Oferta where  Codigo_Pub = @Cod_Pub)


END
GO
/****** Object:  StoredProcedure [dbo].[buscarDatosPublicacion]    Script Date: 07/13/2014 03:35:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarDatosPublicacion]

@Codigo numeric(18,0)
AS
BEGIN
SELECT * from Publicacion P
JOIN Publicacion_Rubro PR on P.Codigo = PR.id_Publicacion 
WHERE Codigo = @Codigo
END
GO
/****** Object:  StoredProcedure [dbo].[agregarUnaPregunta]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarUnaPregunta]
@UsuarioPreg numeric(18,0),
@Id_Publicacion numeric(18,0),
@Pregunta nvarchar(255)
AS
BEGIN
INSERT INTO PreguntasYRespuestas(UsuarioPregunta,
Pregunta,
Id_Publicacion)
VALUES(@UsuarioPreg,
@Pregunta,
@Id_Publicacion)
END
GO
/****** Object:  StoredProcedure [dbo].[agregarRespuesta]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarRespuesta]
@Id numeric(18,0),
@Respuesta nvarchar(255)
AS
BEGIN
UPDATE PreguntasYRespuestas
SET Respuesta = @Respuesta, FechaRespuesta = GETDATE()
WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[agregarPublicacionRubro]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarPublicacionRubro]
@codigo Decimal,
@rubro Decimal
AS
BEGIN
INSERT INTO Publicacion_Rubro
VALUES(@codigo,@rubro)
END
GO
/****** Object:  StoredProcedure [dbo].[agregarNuevoClienteUsuario]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarNuevoClienteUsuario]
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
EXEC darDeAltaUsuario @Mail, @Dni, 1 , 10, 0

SET @IdUsuario2 = (SELECT Id_Usuario FROM Usuario WHERE 
Usuario = @Mail AND Password = @Dni)

exec agregarNuevoCliente @Dni, @Nombre , @Apellido,@Fecha_Nac,@Mail,@Dom_Calle,@Nro_Calle,@Piso,
	@Depto,	@Cod_Postal,@Localidad,	@Tipo_dni,@Telefono, @IdUsuario2
END
else
exec agregarNuevoCliente @Dni, @Nombre , @Apellido,@Fecha_Nac,@Mail,@Dom_Calle,@Nro_Calle,@Piso,
	@Depto,	@Cod_Postal,@Localidad,	@Tipo_dni,@Telefono, @IdUsuario 
END
GO
/****** Object:  StoredProcedure [dbo].[agregarNuevaPublicacion]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarNuevaPublicacion]
		
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
	
	SET @idPub = (SELECT MAX(Codigo)+1 from Publicacion)
	
	INSERT INTO Publicacion(
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
	
	INSERT INTO Publicacion_Rubro(id_Publicacion, id_Rubro)
	VALUES(@idPub,@Rubro)

END
GO
/****** Object:  StoredProcedure [dbo].[agregarNuevaOferta]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[agregarNuevaOferta]
		@Cod_Pub numeric(18,0),
		@Monto numeric(18,2),
		@Id_Cli numeric(18,0),
		@Fecha datetime

AS
BEGIN
	INSERT INTO Oferta(
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
/****** Object:  StoredProcedure [dbo].[agregarNuevaEmpresaUsuario]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarNuevaEmpresaUsuario]
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
			EXEC darDeAltaUsuario @Mail, @Cuit, 2 , 10, 0
			
			SET @IdUsuario2 = (SELECT Id_Usuario FROM Usuario WHERE 
			Usuario = @Mail AND Password = @Cuit)
			
			EXEC agregarNuevaEmpresa @RazonSocial ,@Cuit,@Fecha_Creacion ,@Mail ,@Dom_Calle,@Nro_Calle,@Piso,@Depto,@Cod_Postal ,@Localidad,	
					@Telefono,@Ciudad,@Nombre_Contacto,@IdUsuario2
		END
ELSE

		EXEC agregarNuevaEmpresa @RazonSocial ,@Cuit,@Fecha_Creacion ,@Mail ,@Dom_Calle,@Nro_Calle,@Piso,@Depto,@Cod_Postal ,@Localidad,	
				@Telefono,@Ciudad,@Nombre_Contacto,@IdUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[agregarFactura]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[agregarFactura]

@Codigo numeric (18,0),
@Precio numeric (18,2),
@Tipo_Pago smallint,
@Nro_Fac numeric (18,0),
@Fecha datetime
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
@Fecha,
@Precio,
@Tipo_Pago,
@Codigo)
eND
GO
/****** Object:  StoredProcedure [dbo].[agregarCompra]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[agregarCompra]
		@Codigo numeric(18,0),
		@Id numeric(18,0),
		@Stock numeric(18,0),
		@Fecha datetime

AS
BEGIN
	insert into Calificacion(Cod_Calificacion,Cant_Estrellas) 
	values ((select MAX(Cod_Calificacion)+1 from Calificacion),0)
	
DECLARE @Cod_Calif numeric(18,0)
SET @Cod_Calif = (select MAX(Cod_Calificacion) from Calificacion)

	INSERT INTO Compra(
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
/****** Object:  StoredProcedure [dbo].[agregarCalificacion]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[agregarCalificacion]

@Id numeric (18,0),
@Cant_Est numeric (18,0),
@Desc nvarchar(255)
AS 
BEGIN
declare @codcal numeric(18,0)
 (select @codcal=Calificacion_Codigo from Compra where @Id=compra.Id)  

UPDATE Calificacion
SET Cant_Estrellas= @Cant_Est,
Descripcion= @Desc

WHERE @codcal=Cod_Calificacion
END
GO
/****** Object:  StoredProcedure [dbo].[agregarItemFacturaPublicacion]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[agregarItemFacturaPublicacion]
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
GO
/****** Object:  StoredProcedure [dbo].[agregarItemFacturaComision]    Script Date: 07/13/2014 03:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[agregarItemFacturaComision]

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
END
GO
/****** Object:  StoredProcedure [dbo].[obtenerIdRol]    Script Date: 07/17/2014 18:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerIdRol]
@NombreRol nvarchar(30)
AS
BEGIN
SELECT Id From Rol
WHERE Nombre = @NombreRol
END
GO
/****** Object:  ForeignKey [FK_Clientes_Tipo_Doc]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Tipo_Doc] FOREIGN KEY([Tipo_Doc])
REFERENCES [dbo].[Tipo_Doc] ([Codigo])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Tipo_Doc]
GO
/****** Object:  ForeignKey [FK_Clientes_Usuario]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Usuario]
GO
/****** Object:  ForeignKey [FK_Compra_Calificacion]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Calificacion] FOREIGN KEY([Calificacion_Codigo])
REFERENCES [dbo].[Calificacion] ([Cod_Calificacion])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Calificacion]
GO
/****** Object:  ForeignKey [FK_Compra_Publicacion]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Publicacion] FOREIGN KEY([Codigo_Pub])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Publicacion]
GO
/****** Object:  ForeignKey [FK_Compra_Usuario]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Usuario] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Usuario]
GO
/****** Object:  ForeignKey [FK_Empresa_Usuario]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Empresa]  WITH CHECK ADD  CONSTRAINT [FK_Empresa_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[Empresa] CHECK CONSTRAINT [FK_Empresa_Usuario]
GO
/****** Object:  ForeignKey [FK_Factura_Publicacion]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Publicacion] FOREIGN KEY([Pub_Cod])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Publicacion]
GO
/****** Object:  ForeignKey [FK_Factura_Tipo_Pago]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Tipo_Pago] FOREIGN KEY([Forma_Pago_Desc])
REFERENCES [dbo].[Tipo_Pago] ([Codigo])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Tipo_Pago]
GO
/****** Object:  ForeignKey [FK__Func_Rol__id_Fun__766D4B53]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Func_Rol]  WITH CHECK ADD FOREIGN KEY([id_Func])
REFERENCES [dbo].[Funcionalidades] ([id_funcionabilidad])
GO
/****** Object:  ForeignKey [FK__Func_Rol__id_Rol__77616F8C]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Func_Rol]  WITH CHECK ADD FOREIGN KEY([id_Rol])
REFERENCES [dbo].[Rol] ([Id])
GO
/****** Object:  ForeignKey [FK_Item_FacturaComision_Factura]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Item_FacturaComision]  WITH CHECK ADD  CONSTRAINT [FK_Item_FacturaComision_Factura] FOREIGN KEY([Nro_Fact], [Pub_Cod])
REFERENCES [dbo].[Factura] ([Numero], [Pub_Cod])
GO
ALTER TABLE [dbo].[Item_FacturaComision] CHECK CONSTRAINT [FK_Item_FacturaComision_Factura]
GO
/****** Object:  ForeignKey [FK_Item_FacturaPublicacion_Factura]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Item_FacturaPublicacion]  WITH CHECK ADD  CONSTRAINT [FK_Item_FacturaPublicacion_Factura] FOREIGN KEY([Nro_Fact], [Pub_Cod])
REFERENCES [dbo].[Factura] ([Numero], [Pub_Cod])
GO
ALTER TABLE [dbo].[Item_FacturaPublicacion] CHECK CONSTRAINT [FK_Item_FacturaPublicacion_Factura]
GO
/****** Object:  ForeignKey [FK_Oferta_Publicacion]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Oferta]  WITH CHECK ADD  CONSTRAINT [FK_Oferta_Publicacion] FOREIGN KEY([Codigo_Pub])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[Oferta] CHECK CONSTRAINT [FK_Oferta_Publicacion]
GO
/****** Object:  ForeignKey [FK_Oferta_Usuario]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Oferta]  WITH CHECK ADD  CONSTRAINT [FK_Oferta_Usuario] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[Oferta] CHECK CONSTRAINT [FK_Oferta_Usuario]
GO
/****** Object:  ForeignKey [FK_PreguntasYRespuestas_Publicacion]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[PreguntasYRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_PreguntasYRespuestas_Publicacion] FOREIGN KEY([Id_Publicacion])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[PreguntasYRespuestas] CHECK CONSTRAINT [FK_PreguntasYRespuestas_Publicacion]
GO
/****** Object:  ForeignKey [FK_PreguntasYRespuestas_Usuario]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[PreguntasYRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_PreguntasYRespuestas_Usuario] FOREIGN KEY([UsuarioPregunta])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[PreguntasYRespuestas] CHECK CONSTRAINT [FK_PreguntasYRespuestas_Usuario]
GO
/****** Object:  ForeignKey [FK_Publicacion_Estado]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Estado] FOREIGN KEY([Estado])
REFERENCES [dbo].[Estado] ([Cod_Estado])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Estado]
GO
/****** Object:  ForeignKey [FK_Publicacion_Tipo_Publicacion]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Tipo_Publicacion] FOREIGN KEY([Tipo])
REFERENCES [dbo].[Tipo_Publicacion] ([Cod_Tipo])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Tipo_Publicacion]
GO
/****** Object:  ForeignKey [FK_Publicacion_Usuario]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Usuario] FOREIGN KEY([Usuario])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Usuario]
GO
/****** Object:  ForeignKey [FK_Publicacion_Visibilidad]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Visibilidad] FOREIGN KEY([Visibilidad_Cod])
REFERENCES [dbo].[Visibilidad] ([Codigo])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Visibilidad]
GO
/****** Object:  ForeignKey [FK_Publicacion_Rubro_Publicacion]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Publicacion_Rubro]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Rubro_Publicacion] FOREIGN KEY([id_Publicacion])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[Publicacion_Rubro] CHECK CONSTRAINT [FK_Publicacion_Rubro_Publicacion]
GO
/****** Object:  ForeignKey [FK_Publicacion_Rubro_Rubro]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Publicacion_Rubro]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Rubro_Rubro] FOREIGN KEY([id_Rubro])
REFERENCES [dbo].[Rubro] ([Codigo])
GO
ALTER TABLE [dbo].[Publicacion_Rubro] CHECK CONSTRAINT [FK_Publicacion_Rubro_Rubro]
GO
/****** Object:  ForeignKey [FK_Usuario_Rol_Rol]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Usuario_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol_Rol] FOREIGN KEY([Id_Rol])
REFERENCES [dbo].[Rol] ([Id])
GO
ALTER TABLE [dbo].[Usuario_Rol] CHECK CONSTRAINT [FK_Usuario_Rol_Rol]
GO
/****** Object:  ForeignKey [FK_Usuario_Rol_Usuario]    Script Date: 07/13/2014 03:35:14 ******/
ALTER TABLE [dbo].[Usuario_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol_Usuario] FOREIGN KEY([Id_Usuario])
REFERENCES [dbo].[Usuario] ([Id_Usuario])
GO
ALTER TABLE [dbo].[Usuario_Rol] CHECK CONSTRAINT [FK_Usuario_Rol_Usuario]
GO

--Carga Tabla Tipos de Documentos
INSERT INTO Tipo_DOC VALUES (1,'DNI')
INSERT INTO Tipo_Doc VALUES (2,'CUIT')
INSERT INTO Tipo_Doc VALUES (3,'LE')
INSERT INTO Tipo_Doc VALUES (4,'LC')


 --carga tabla rol
INSERT INTO rol VALUES ('Cliente',1,1)
INSERT INTO rol VALUES ('Empresa',1,1)
INSERT INTO rol VALUES ('Admin',1,1)

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


insert into Usuario_Rol
select u.Id_Usuario, r.Id ,1 From Usuario u, Rol r
WHERE u.Tipo_Usuario = 'C'
AND r.Nombre = 'Cliente'

union all 
select u2.Id_Usuario, r2.Id, 1 From Usuario u2, Rol r2
WHERE u2.Tipo_Usuario = 'E'
AND r2.Nombre = 'Empresa'

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

Insert into Estado Values('Borrador')
Insert into Estado Values('Pausada')
Insert into Estado Values('Finalizada')

--Migracion tabla Tipo_Pub
insert into Tipo_Publicacion
select distinct  Publicacion_Tipo
from gd_esquema.Maestra


-- Migracion tabla publicacion

insert into Publicacion
select distinct Publicacion_Cod,Publicacion_Descripcion,0,
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
select distinct Publicacion_Cod,Publicacion_Descripcion,0,
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

select distinct Publicacion_Cod,Clientes.Id_Usuario,
Compra_Fecha,Compra_Cantidad,Calificacion_Codigo,1


from gd_esquema.Maestra, Clientes

where CONVERT(nvarchar,Cli_Dni) = Clientes.Nro_Documento
and Publicacion_Cod is not null
and Calificacion_Codigo is not null
and Compra_Fecha is not null
and Compra_Cantidad is not null

-- migracion tabla oferta

insert into Oferta

select distinct Publicacion_Cod,Oferta_Fecha,Oferta_Monto,Clientes.Id_Usuario,1

from gd_esquema.Maestra, Clientes


where CONVERT(nvarchar,Cli_Dni) = Clientes.Nro_Documento
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

insert into Funcionalidades values(10,'Generar publicación');
insert into Funcionalidades values(11,'Mostrar historial cliente');
insert into Funcionalidades values(12,'Buscar publicaciones');
insert into Funcionalidades values(13,'Facturar publicaciones');
insert into Funcionalidades values(14,'Ejecutar gestor de preguntas');
insert into Funcionalidades values(15,'Subastas pendientes');
insert into Funcionalidades values(16,'Editar usuario');
insert into Funcionalidades values(17,'Editar publicaciones');
insert into Funcionalidades values(18,'Listar preguntas a responder');
insert into Funcionalidades values(19,'Subastas pendiente');
insert into Funcionalidades values(20,'Calificaciones pendiente');


--cargar tabla funcionabilidades
--Lo que hace el admin
INSERT INTO Func_Rol VALUES(3,1)
INSERT INTO Func_Rol VALUES(3,2)
INSERT INTO Func_Rol VALUES(3,3)
INSERT INTO Func_Rol VALUES(3,4)
INSERT INTO Func_Rol VALUES(3,5)
INSERT INTO Func_Rol VALUES(3,6)
--Lo que hace el cliente
INSERT INTO Func_Rol VALUES(1,12)
INSERT INTO Func_Rol VALUES(1,14)
INSERT INTO Func_Rol VALUES(1,10)
INSERT INTO Func_Rol VALUES(1,11)
INSERT INTO Func_Rol VALUES(1,16)
INSERT INTO Func_Rol VALUES(1,13)
INSERT INTO Func_Rol VALUES(1,20)
INSERT INTO Func_Rol VALUES(1,15)
--Lo que hace una empresa
INSERT INTO Func_Rol VALUES(2,17)
INSERT INTO Func_Rol VALUES(2,15)
INSERT INTO Func_Rol VALUES(2,10)
INSERT INTO Func_Rol VALUES(2,16)
INSERT INTO Func_Rol VALUES(2,13)
INSERT INTO Func_Rol VALUES(2,18)
INSERT INTO Func_Rol VALUES(2,14)

--Administrador
INSERT INTO Usuario VALUES(
'admin','A','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7',1,0,1)
Declare @Id_Usuario numeric(18,0)
set @Id_Usuario = (Select id_Usuario From Usuario where Usuario = 'admin')
exec agregarNuevoClienteUsuario 0,'Administrador','ApellidoAdmin','20000101','admin@mail','Dom_admin',0,0,'D','0','Admin',1,'000',@Id_Usuario
exec agregarNuevaEmpresaUsuario 'razonAdmin','00','20000101','admin@mail','Dom_admin',0,0,'D','0','Loc_admin','0','CiudadAdmin','Administrador',@Id_Usuario

INSERT INTO Usuario_Rol VALUES(@Id_Usuario,3,1)
insert into Usuario_Rol VALUES(@Id_Usuario,2,1)
insert into Usuario_Rol VALUES(@Id_Usuario,1,1)
/****** Object:  Trigger [Trig_Insert_Usuario]    Script Date: 07/12/2014 02:22:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[Trig_Insert_Usuario] ON [dbo].[Usuario]
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
				
INSERT INTO Usuario_Rol VALUES(@Id_Usuario, @Id_Rol,1)
END
GO

create index ix_Pub on Publicacion (codigo)