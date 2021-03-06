USE [GD1C2014]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 06/18/2014 01:46:15 ******/
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
/****** Object:  Table [dbo].[Rubro]    Script Date: 06/18/2014 01:46:15 ******/
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
/****** Object:  Table [dbo].[Rol]    Script Date: 06/18/2014 01:46:15 ******/
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
/****** Object:  StoredProcedure [dbo].[quitarRol]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[quitarRol]
@Id_Rol int,
@funcionalidad int
AS
BEGIN
DELETE Funcionabilidades
WHERE Id_Rol = @Id_Rol AND
Id_Funcionabilidad = @funcionalidad
END
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 06/18/2014 01:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id_Usuario] [numeric](18, 0) IDENTITY(1,1),
	[Usuario] [nvarchar](50) NOT NULL,
	[Rol_Usuario] [numeric](18,0) NOT NULL,
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
/****** Object:  Table [dbo].[Tipo_Pago]    Script Date: 06/18/2014 01:46:15 ******/
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
/****** Object:  Table [dbo].[Tipo_Doc]    Script Date: 06/18/2014 01:46:15 ******/
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
/****** Object:  Table [dbo].[Visibilidad]    Script Date: 06/18/2014 01:46:15 ******/
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
/****** Object:  StoredProcedure [dbo].[obtenerVisibilidad]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[seleccionVisibilidadNotNull]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[obtenerNombreIdRol]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[obtenerEstadoDelId]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[obtenerEstadoDelId]
@Id numeric (18,0),
@Rol numeric (18,0)
AS
BEGIN
SELECT estado from Usuario 
where Id_Usuario = @Id
AND Id_Rol = @Rol
END
GO
/****** Object:  StoredProcedure [dbo].[obtenerEstado]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[obtenerDescripcionRubro]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[obtenerCodRubro]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[listadoMayoresSinCalificaciones]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listadoMayoresSinCalificaciones]
	@Año smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
		SELECT TOP 5 U.Usuario AS 'Usuario', COUNT(Calificacion_Cant_Estrellas) as 'Cantidad sin calificar'
	FROM (Compra C 
	INNER JOIN Usuario U ON (c.Id_Cliente = u.Id_Usuario AND U.Id_Rol = 1))
	WHERE YEAR(C.Fecha) = @Año AND
	 (MONTH(C.Fecha) = 1 + 3*(@Trimestre-1)OR 
	 MONTH(C.Fecha) = 2 + 3*(@Trimestre-1) OR
	  MONTH(C.Fecha) = 3 + 3*(@Trimestre-1)) AND 
	  Calificacion_Cant_Estrellas IS NULL
    GROUP BY U.Usuario
    ORDER BY [Cantidad sin calificar] DESC
  
    END
GO
/****** Object:  StoredProcedure [dbo].[listaDeVisibilidades]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[listaDePubSinCalificar]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[listaDePubSinCalificar]

@id_Cliente numeric (18,0)

AS
	BEGIN
		SELECT * FROM Compra
		
		WHERE Id_Cliente = @id_Cliente
		and Calificacion_Codigo = 0
		
				order by Fecha
	END
GO
/****** Object:  Table [dbo].[Funcionalidades]    Script Date: 06/18/2014 01:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionalidades](
	[Id_Rol] [numeric](18, 0) NOT NULL,
	[Id_Funcionalidad] [smallint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[darDeAltaUsuario]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[darDeAltaUsuario]
@Usuario nvarchar(50),
@Password nvarchar(64),
@IdUsuario numeric(18,0),
@IdRol numeric(18,0),
@Estado int,
@Intentos int
AS
BEGIN
INSERT INTO Usuario(Usuario,Password,Id_Usuario,Id_Rol,Estado,Intentos,Baja)
VALUES(@Usuario,@Password,@IdUsuario,@IdRol,@Estado,@Intentos,1)
END
GO
/****** Object:  StoredProcedure [dbo].[filtrarRubro]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[filtrarRubro]
@Descripcion nvarchar(255)
AS
BEGIN
SELECT Codigo, Descripcion FROM Rubro
WHERE Descripcion like '%'+@Descripcion+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[filtrarRol]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[filtrarRol]
@Rol nvarchar(50)
AS
BEGIN
SELECT Id, Nombre FROM Rol
WHERE Nombre like '%'+@Rol+'%'
AND Estado <> 0
end
GO
/****** Object:  Table [dbo].[Publicacion]    Script Date: 06/18/2014 01:46:15 ******/
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
/****** Object:  Table [dbo].[Clientes]    Script Date: 06/18/2014 01:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id_Cliente] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Id_Usuario] [numeric](18, 0) NOT NULL,
	[Nro_Documento] [nvarchar](255) NOT NULL,
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
	[Tipo_Doc] [smallint] NOT NULL,
	[Telefono] [nvarchar](255) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[buscarUnaVisibilidad]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[buscarUsuarioEmpresa]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[buscarUsuarioEmpresa]
@Id numeric(18,0)
AS
BEGIN
	SELECT usuario FROM Usuario
		WHERE 
		@Id =Id_Usuario
		and Id_Rol = 2
END
GO
/****** Object:  StoredProcedure [dbo].[buscarUsuarioCliente]    Script Date: 06/18/2014 01:46:17 ******/
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
		and Id_Rol = 1
END
GO
/****** Object:  StoredProcedure [dbo].[darDeBajaVisibilidad]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[darDeBajaRol]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[darDeBajaRol]
@Rol numeric(18,0)
AS
BEGIN
UPDATE Rol
SET Estado = 0
WHERE Id = @Rol
END
GO
/****** Object:  Table [dbo].[Empresa]    Script Date: 06/18/2014 01:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresa](
	[Id_Empresa] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Id_Usuario] [numeric](18, 0) NOT NULL,
	[Razon_Social] [nvarchar](255) NOT NULL,
	[Nro_Documento] [nvarchar](255) NOT NULL,
	[Tipo_Doc] [smallint] NOT NULL,
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
	
 CONSTRAINT [PK_Empresa] PRIMARY KEY CLUSTERED 
(
	[Id_Empresa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[buscarNombreUsuario]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarNombreUsuario]
@IdUsuario numeric(18,0),
@IdRol numeric(18,0)
AS
BEGIN
SELECT Usuario FROM Usuario
WHERE @IdRol = Id_Rol AND
@IdUsuario = Id_Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[buscarPublicador]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[buscarIdRol]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[buscarCamposDeUsuario]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarCamposDeUsuario]
@Usuario nvarchar(50)
AS
BEGIN
SELECT Password,Id_Usuario, Id_Rol, Intentos, Estado FROM Usuario
WHERE Usuario = @Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[agregarNuevoRol]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarNuevoRol]
@Rol_Nombre nvarchar(255)
AS
BEGIN
INSERT Rol(Nombre, Estado)
VALUES(@Rol_Nombre, 1)
END
GO
/****** Object:  StoredProcedure [dbo].[buscarDuracionVisibilidad]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[actualizarContraseña]    Script Date: 06/18/2014 01:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarContraseña]
@Usuario nvarchar(50),
@Contraseña nvarchar(64)
AS
BEGIN
UPDATE Usuario
SET Password = @Contraseña
WHERE Usuario = @Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[agregarNuevaVisibilidad]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[actualizarIntentos]    Script Date: 06/18/2014 01:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarIntentos]
@Usuario nvarchar(50),
@Intentos int
AS
BEGIN
UPDATE Usuario
SET Intentos = @Intentos
WHERE
@Usuario = Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[actualizarEstadoRol]    Script Date: 06/18/2014 01:46:16 ******/
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
END
GO
/****** Object:  StoredProcedure [dbo].[actualizarEstadoDelUsuario]    Script Date: 06/18/2014 01:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[actualizarEstadoDelUsuario]
@Estado smallint,
@Rol numeric(18,0),
@Id numeric(18,0)
AS
BEGIN
UPDATE Usuario
SET Estado = @Estado
WHERE Id_Rol = @Rol AND
Id_Usuario = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[agregarCompra]    Script Date: 06/18/2014 01:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarCompra]
		@Codigo numeric(18,0),
		@Id numeric(18,0),
		@Stock numeric(18,0)

AS
BEGIN
	INSERT INTO Compra(
	Codigo_Pub,
	Id_Cliente,
	Fecha,
	Cantidad,
	Calificacion_Codigo)
	VALUES(
	@Codigo,
	@Id,
	GETDATE(),
	@Stock,
	0)	

END
GO
/****** Object:  StoredProcedure [dbo].[agregarCalificacion]    Script Date: 06/18/2014 01:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[agregarCalificacion]

@Id numeric (18,0),
@Cal_Cod numeric (18,0),
@Cant_Est numeric (18,0),
@Desc nvarchar(255)
AS 
BEGIN
UPDATE Compra
SET Calificacion_Codigo = @Cal_Cod,Calificacion_Cant_Estrellas = @Cant_Est,
Calificaciones_Descripcion = @Desc
WHERE Id = @Id 
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarVisibilidad]    Script Date: 06/18/2014 01:46:16 ******/
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
/****** Object:  StoredProcedure [dbo].[actualizarStock]    Script Date: 06/18/2014 01:46:16 ******/
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
/****** Object:  StoredProcedure [dbo].[actualizarEmpresa]    Script Date: 06/18/2014 01:46:16 ******/
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
		@Nombre_Contacto nvarchar(255),
		@Tipo_doc smallint
AS
BEGIN
UPDATE Empresa 
SET Razon_Social = @RazonSocial, Tipo = @Tipo_doc, Nombre_Contacto = @Nombre_Contacto, Ciudad = @Ciudad, Piso = @Piso, 
Localidad = @Localidad, Cod_Postal = @Cod_Postal, Depto = @Depto, Nro_Calle = @Nro_Calle, Dom_Calle = @Dom_Calle, 
Mail = @Mail, Fecha_Creacion = @Fecha_Creacion, Cuit = @Cuit
WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[agregarNuevaEmpresa]    Script Date: 06/18/2014 01:46:17 ******/
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
		@Tipo_doc smallint

AS
BEGIN
	INSERT INTO Empresa(
	Razon_Social,
	Cuit,
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
	Tipo)
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
		@Tipo_doc
	)	

END
GO
/****** Object:  StoredProcedure [dbo].[agregarNuevaPublicacion]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarNuevaPublicacion]
		
		@Visibilidad numeric(18,0),
		@Tipo nvarchar(255),
		@Rubro numeric(18,0),
		@Stock numeric(18,0),
		@Precio numeric(18,2),
		@Descripcion nvarchar(255),
		@Permitir_Preguntas bit,
		@Fecha_Venc datetime,
		@Publicador nvarchar(1),
		@Id numeric(18,0)
 
AS
BEGIN
	INSERT INTO Publicacion(
	Visibilidad_Cod,
	Tipo,
	Rubro_Cod,
	Stock,
	Precio,
	Descripcion,
	Preguntas_permitidas,
	Fecha,
	Estado,
	Fecha_Venc,
	Publicador,
	Id)
	
	VALUES(
	@Visibilidad,
	@Tipo,
	@Rubro,
	@Stock,
	@Precio,
	@Descripcion,
	@Permitir_Preguntas,
	GETDATE(),
	'Borrador',
	@Fecha_Venc,
	@Publicador,
	@Id)

END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarCliente]    Script Date: 06/18/2014 01:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarCliente]
@Id numeric(18,0),
@Dni numeric(18,0),
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
SET Apellido = @Apellido, Nombre = @Nombre , Dni = @Dni, Fecha_Nac = @Fecha_Nac, Mail = @Mail, Dom_Calle = @Dom_Calle,
Nro_Calle = @Nro_Calle, Piso = @Piso, Depto = @Piso, Cod_Postal = @Cod_Postal, Localidad = @Localidad,
Tipo_dni = @Tipo_dni, Telefono = @Telefono
WHERE Id = @Id
End
GO
/****** Object:  StoredProcedure [dbo].[agregarFuncionabilidadAlRol]    Script Date: 06/18/2014 01:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarFuncionabilidadAlRol]
@Id_Rol numeric(18,0),
@Id_Funcionabilidad int
AS
BEGIN
INSERT INTO Funcionalidades(Id_Rol,
Id_Funcionalidad)
VALUES(@Id_Rol, @Id_Funcionabilidad)
END
GO
/****** Object:  StoredProcedure [dbo].[buscarDatosPublicacion]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarDatosPublicacion]

@Codigo numeric(18,0)
AS
BEGIN
SELECT * from Publicacion
WHERE Codigo = @Codigo
END
GO
/****** Object:  StoredProcedure [dbo].[agregarNuevoCliente]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarNuevoCliente]
		@Dni numeric(18,0),
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
	INSERT INTO Clientes(
	Dni,
	Nombre,
	Apellido,
	Fecha_Nac,
	Mail,
	Dom_Calle,
	Nro_Calle,
	Piso,
	Depto,
	Cod_Postal,
	Localidad,
	Tipo_dni,
	Telefono)
	VALUES(
	@Dni,
	@Nombre,
	@Apellido,
	@Fecha_Nac,
	@Mail,
	@Dom_Calle,
	@Nro_Calle,
	@Piso,
	@Depto,
	@Cod_Postal,
	@Localidad,
	@Tipo_dni,
	@Telefono 
	)	

END
GO
/****** Object:  StoredProcedure [dbo].[averiguarStock]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[buscarIdPorPublicacion]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[buscarIdPorPublicacion]
@Codigo numeric(18,0)
AS
BEGIN

select Id from Publicacion where Codigo = @Codigo
end
GO
/****** Object:  StoredProcedure [dbo].[buscarIdEmpresa]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarIdEmpresa]
@Cuit nvarchar(255)
AS
BEGIN
SELECT id from Empresa
WHERE Cuit = @Cuit
END
GO
/****** Object:  StoredProcedure [dbo].[buscarIdCliente]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarIdCliente]
@Dni numeric(18,0)
AS
BEGIN
SELECT id from Clientes
WHERE Dni = @Dni
END
GO
/****** Object:  StoredProcedure [dbo].[buscarPrecio]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[editarPublicacionPublicada]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[editarPublicacionPublicada]
		
		
		@Stock numeric(18,0),
		@Descripcion nvarchar(255),
		@Estado nvarchar(255),
		@Codigo numeric(18,0)

 
AS
BEGIN
	UPDATE Publicacion
SET  Stock = @Stock, Descripcion = @Descripcion,
Estado = @Estado
WHERE Codigo = @Codigo

END
GO
/****** Object:  StoredProcedure [dbo].[editarPublicacionBorrador]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[editarPublicacionBorrador]
		
		@Visibilidad numeric(18,0),
		@Tipo nvarchar(255),
		@Rubro numeric(18,0),
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
SET Visibilidad_Cod = @Visibilidad, Tipo = @Tipo , Rubro_Cod = @Rubro, Stock = @Stock, Precio = @Precio, Descripcion = @Descripcion,
Estado = @Estado, Preguntas_permitidas = @Permitir_Preguntas, Fecha_Venc = @Fecha_Venc
WHERE Codigo = @Codigo

END
GO
/****** Object:  StoredProcedure [dbo].[darDeBajaAlCliente]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[darDeBajaAlCliente]
@Id numeric(18,0),
@Rol numeric(18,0)
AS
BEGIN
UPDATE Usuario
SET Baja = 0
WHERE Id_Usuario = @Id
AND Id_Rol = @Rol

UPDATE Clientes 
SET  Dni = 0, Telefono = null
where Id = @Id

UPDATE Publicacion
SET Estado = 'Finalizada'
WHERE Id = @Id
AND Publicador = 'C'
END
GO
/****** Object:  StoredProcedure [dbo].[darDeBajaAEmpresa]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[darDeBajaAEmpresa]
@Id_Empresa numeric(18,0),
@Rol numeric(18,0)
AS
BEGIN
UPDATE Usuario
SET Baja = 0
WHERE Id_Usuario = @Id_Empresa
AND Id_Rol = @Rol

UPDATE Empresa 
SET  Cuit = 0, Telefono = null
where Id = @Id_Empresa

UPDATE Publicacion
SET Estado = 'Finalizada'
WHERE Id = @Id_Empresa
AND Publicador = 'E'

END
GO
/****** Object:  StoredProcedure [dbo].[buscarUnSoloCliente]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarUnSoloCliente]
@Id numeric(18,0)
AS
BEGIN
	SELECT * FROM Clientes 
		WHERE 
		Id = @Id;
END
GO
/****** Object:  StoredProcedure [dbo].[buscarUnaSolaEmpresa]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarUnaSolaEmpresa]
@Id numeric (18,0)
AS 
BEGIN
SELECT *FROM Empresa 
WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[buscarPublicadorCod]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscarPublicadorCod]
@Codigo numeric(18,0)
AS
BEGIN
	SELECT Id,Publicador FROM Publicacion 
		WHERE 
		Codigo = @Codigo;
END
GO
/****** Object:  Table [dbo].[PreguntasYRespuestas]    Script Date: 06/18/2014 01:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreguntasYRespuestas](
	[Id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[UsuarioPublicador] [nvarchar](100) NOT NULL,
	[UsuarioPregunta] [nvarchar](100) NOT NULL,
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
/****** Object:  Table [dbo].[Oferta]    Script Date: 06/18/2014 01:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oferta](
	[Codigo_Pub] [numeric](18, 0) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Monto] [numeric](18, 2) NOT NULL,
	[Id] [numeric](18, 0) NOT NULL,
	[Con_Ganador] [numeric](18, 0) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 06/18/2014 01:46:15 ******/
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
/****** Object:  StoredProcedure [dbo].[listaDePublicaciones]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listaDePublicaciones]
		@Descripcion nvarchar(255),
		@Estado nvarchar(255),
		@Tipo nvarchar(255),
		@Visibilidad nvarchar(30),
		@Rol nvarchar(10),
		@Rubro nvarchar(30),
		@Id nvarchar(30)
	AS
	BEGIN
		SELECT P.Codigo, p.Descripcion, p.Stock, p.Fecha, p.Fecha_Venc, p.Precio, p.Tipo, v.Descripcion AS 'Visibilidad', p.Estado, r.Descripcion as 'Rubro', p.Publicador, p.Preguntas_permitidas,p.Id FROM Publicacion as P
	JOIN Rubro r ON r.Codigo = p.Rubro_Cod
	JOIN Visibilidad V ON p.Visibilidad_Cod = v.Codigo
			WHERE
				p.Descripcion like '%'+@Descripcion+'%'
				AND p.Rubro_Cod like '%'+@Rubro+'%'
				AND p.Tipo like '%'+@Tipo+'%'
				AND p.Visibilidad_Cod like '%'+@Visibilidad+'%'
				and p.stock > 0
 				and p.Estado like '%'+@Estado+'%'
 				and (p.Id <> @Id and p.Publicador <> @Rol)
				
			order by Visibilidad_Cod

	END

/****** Object:  StoredProcedure [dbo].[historialCalificacionesOtorgadas]    Script Date: 06/17/2014 20:00:55 ******/
GO
/****** Object:  StoredProcedure [dbo].[listaDeMisPublicaciones]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listaDeMisPublicaciones]
		@Descripcion nvarchar(255),
		@Estado nvarchar(255),
		@Tipo nvarchar(255),
		@Visibilidad nvarchar(30),
		@Rol nvarchar(10),
		@Rubro nvarchar(30),
		@Id nvarchar(30)
	AS
	BEGIN
		SELECT P.Codigo, p.Descripcion, p.Stock, p.Fecha, p.Fecha_Venc, p.Precio, p.Tipo, p.Visibilidad_Cod, p.Estado, r.Descripcion as 'Rubro', p.Publicador, p.Preguntas_permitidas,p.Id FROM Publicacion as P
	JOIN Rubro r ON r.Codigo = p.Rubro_Cod
			WHERE
				p.Descripcion like '%'+@Descripcion+'%'
				AND p.Rubro_Cod like '%'+@Rubro+'%'
				AND p.Tipo like '%'+@Tipo+'%'
				AND p.Visibilidad_Cod like '%'+@Visibilidad+'%'
				and p.stock > 0
 				and p.Estado like '%'+@Estado+'%'
 				and (p.Id <> @Id and p.Publicador <> @Rol)
				
			order by Visibilidad_Cod

	END
GO
/****** Object:  StoredProcedure [dbo].[listaDeEmpresas]    Script Date: 06/18/2014 01:46:17 ******/
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
SELECT * FROM Empresa 
WHERE
Razon_Social LIKE '%'+@Razon_Social+'%' AND
Mail LIKE '%'+@Mail+'%' AND
(@CUIT = [Cuit] or @CUIT = '')
AND Cuit <> '0'
END
GO
/****** Object:  StoredProcedure [dbo].[listaDeCliente2]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listaDeCliente2]
		@Nombre nvarchar(255),
		@Apellido nvarchar(255),
		@Dni nvarchar(50),
		@Mail nvarchar(255)
	AS
	BEGIN
		SELECT C.Id,c.Dni, c.Nombre, c.Apellido, c.Fecha_Nac as 'Fecha de Nacimiento',c.Mail, C.Dom_Calle as 'Domicilio',
		 c.Nro_Calle as 'Nro de Calle', c.Piso, c.Depto, c.Cod_Postal as 'Código postal' , c.Localidad, T.Nombre as 'Tipo de Documento',
		  c.Telefono as 'Teléfono' FROM(Clientes C
			JOIN Tipo_Doc T ON t.Codigo = c.Tipo_dni)
			WHERE
				c.Nombre like '%'+@Nombre+'%'
				AND c.Apellido like '%'+@Apellido+'%'
				AND c.Dni like '%'+@Dni+'%'
				AND c.Dni <> 0
				AND c.Mail like '%'+@Mail+'%'
				
	END
GO
/****** Object:  StoredProcedure [dbo].[listaDeCliente]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listaDeCliente]
		@Nombre nvarchar(255),
		@Apellido nvarchar(255),
		@Dni nvarchar(50),
		@Mail nvarchar(255),
		@Tipo_dni nvarchar(2)
	AS
	BEGIN
SELECT C.Id,c.Dni, c.Nombre, c.Apellido, c.Fecha_Nac as 'Fecha de Nacimiento',c.Mail, C.Dom_Calle as 'Domicilio',
		 c.Nro_Calle as 'Nro de Calle', c.Piso, c.Depto, c.Cod_Postal as 'Código postal' , c.Localidad, T.Nombre as 'Tipo de Documento',
		  c.Telefono as 'Teléfono' FROM(Clientes C
			JOIN Tipo_Doc T ON t.Codigo = c.Tipo_dni)
			WHERE
				c.Nombre like '%'+@Nombre+'%'
				AND c.Apellido like '%'+@Apellido+'%'
				AND c.Dni like '%'+@Dni+'%'
				AND c.Dni <> 0
				AND c.Mail like '%'+@Mail+'%'
				AND c.Tipo_dni like '%'+@Tipo_dni+'%'
				
	END
GO
/****** Object:  StoredProcedure [dbo].[buscarIdUsuario]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[buscarIdUsuario]
@Cod_Pub numeric(18,0)
AS
BEGIN
SELECT id,Publicador from Publicacion
WHERE Codigo= @Cod_Pub
END
GO
/****** Object:  StoredProcedure [dbo].[historialCompras]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[historialCompras]
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
		SELECT C.Fecha, P.Descripcion, C.Cantidad, U.Usuario AS 'Vendedor'
		
    FROM Publicacion P
	JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN Usuario U ON
    P.Publicador = (CASE WHEN U.Id_Rol = 1 THEN 
        'C'
    WHEN U.Id_Rol = 2 THEN
        'E'
    END) AND P.Id = U.Id_Usuario
	
    WHERE C.Id_Cliente = @Id
    order by C.Fecha
  
    END
GO
/****** Object:  StoredProcedure [dbo].[historialCalificacionesRecibidas]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[historialCalificacionesRecibidas]
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
		SELECT C.Fecha, P.Descripcion, U.Usuario AS 'Comprador', C.Calificacion_Cant_Estrellas AS 'Estrellas', C.Calificaciones_Descripcion AS 'Opinión'
		
   FROM (Publicacion P 
	JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN Usuario U ON
    (C.Id_Cliente = U.Id_Usuario AND U.Id_Rol = 1)
	)
    WHERE P.Id = @Id AND p.Publicador = 'C'
    order by C.Fecha
  
    END
GO
/****** Object:  StoredProcedure [dbo].[historialCalificacionesOtorgadas]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[historialCalificacionesOtorgadas]
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
		SELECT C.Fecha, P.Descripcion, U.Usuario AS 'Vendedor', C.Calificacion_Cant_Estrellas AS 'Estrellas', C.Calificaciones_Descripcion AS 'Opinion'
		
    FROM Publicacion P 
	JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN Usuario U ON
    P.Publicador = (CASE WHEN U.Id_Rol = 1 THEN 
        'C'
    WHEN U.Id_Rol = 2 THEN
        'E'
    END) AND P.Id = U.Id_Usuario
	
    WHERE C.Id_Cliente = @Id
    order by C.Fecha
  
    END
GO
/****** Object:  StoredProcedure [dbo].[listadoMayoresCalificaciones]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listadoMayoresCalificaciones]
	@Año smallint,
	@Trimestre smallint
   	AS
	BEGIN
		
		SELECT TOP 5 U.Usuario AS 'Usuario', AVG(C.Calificacion_Cant_Estrellas) as 'Promedio calificacion'
		
    FROM (Publicacion P 
	INNER JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
   INNER JOIN Usuario U ON ((p.Id = u.Id_Usuario) AND (P.Publicador = (CASE WHEN U.Id_Rol = 1 THEN 
        'C'
    WHEN U.Id_Rol = 2 THEN
        'E'
    END))))
 WHERE YEAR(C.Fecha) = @Año 
 AND(MONTH(C.Fecha) = 1 + 3*(@Trimestre-1) 
 OR MONTH(C.Fecha) = 2 + 3*(@Trimestre-1) 
 OR MONTH(C.Fecha) = 3 + 3*(@Trimestre-1))
 AND C.Calificacion_Cant_Estrellas IS NOT NULL

GROUP BY u.Usuario  
ORDER BY [Promedio calificacion] DESC
    END
GO
/****** Object:  StoredProcedure [dbo].[publicacionAFacturar]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[publicacionAFacturar]
@Codigo numeric (18,0)
as
begin

select Compra.Codigo_Pub,compra.Cantidad,tabla.Porcentaje,tabla.Precio from 

(select Publicacion.Codigo,Visibilidad.Porcentaje,Visibilidad.Precio from Visibilidad,Publicacion

where  Visibilidad.Codigo= Publicacion.Visibilidad_Cod and Publicacion.Codigo = @Codigo
)as tabla,Compra where compra.Codigo_Pub = tabla.Codigo 

end
GO
/****** Object:  StoredProcedure [dbo].[verificarTresGratuitas]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[verificarTresGratuitas]
@Id numeric(18,0),
@Publicador nvarchar(1)
AS
BEGIN
SELECT COUNT(Visibilidad_Cod) from Publicacion
WHERE Id = @Id AND Publicador = @Publicador AND Visibilidad_Cod = 10006 AND Codigo > 68380 AND Estado = 'Publicada'
END
GO
/****** Object:  StoredProcedure [dbo].[verificarEstado]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[listadoVendedoresQueVendenMenos]    Script Date: 06/18/2014 01:46:17 ******/
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

SELECT TOP 5 u.Usuario ,SUM(Stock) as 'Stock Total' from (publicacion P
INNER JOIN Usuario U ON ((p.Id = u.Id_Usuario) AND (P.Publicador = (CASE WHEN U.Id_Rol = 1 THEN 
        'C'
    WHEN U.Id_Rol = 2 THEN
        'E'
    END))
    ) 
    )
WHERE p.Estado <> 'Finalizado' AND p.Estado <> 'Borrador'
AND p.Visibilidad_Cod = @Visibilidad AND 
YEAR(p.Fecha) = @Año AND
MONTH(p.Fecha) = @Mes
group by u.Usuario
order by [Stock Total] DESC
END
GO
/****** Object:  StoredProcedure [dbo].[listadoDeFuncionabilidades]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listadoDeFuncionabilidades]
@Rol numeric(18,0)
AS
BEGIN
SELECT Id_Funcionalidad FROM Funcionalidades
WHERE Id_Rol = @Rol
END
GO
/****** Object:  StoredProcedure [dbo].[obtenerPregunta]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[nroFactura]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[listaSubastasSinConfirmarGanador]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[listaSubastasSinConfirmarGanador]

@id_Cliente numeric(18,0)
AS
BEGIN

SELECT Oferta.Codigo_Pub,Oferta.Monto,Oferta.Id 
FROM 
(SELECT Ofer.Codigo_Pub,MAX(Ofer.Monto) as Monto 
from Oferta as Ofer
inner join Publicacion
on Ofer.Codigo_Pub = publicacion.Codigo
where Publicacion.Id = @id_Cliente
and GETDATE()>Ofer.Fecha
and Ofer.Con_Ganador = 0
group by Ofer.Codigo_Pub) AS Tabla
,Oferta
WHERE Tabla.Codigo_Pub = Oferta.Codigo_Pub
AND   Tabla.Monto = Oferta.Monto
END
GO
/****** Object:  StoredProcedure [dbo].[listadoMayoresFacturacion]    Script Date: 06/18/2014 01:46:17 ******/
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
		
    FROM (Publicacion P 
	INNER JOIN Factura F ON
    P.Codigo = F.Pub_Cod
     INNER JOIN Usuario U ON ((p.Id = u.Id_Usuario) AND (P.Publicador = (CASE WHEN U.Id_Rol = 1 THEN 
        'C'
    WHEN U.Id_Rol = 2 THEN
        'E'
    END))))
	
    WHERE YEAR(F.Fecha) = @Año AND (MONTH(F.Fecha) = 1 + 3*(@Trimestre-1) OR MONTH(F.Fecha) = 2 + 3*(@Trimestre-1) OR MONTH(F.Fecha) = 3 + 3*(@Trimestre-1))

    GROUP BY U.Usuario
    ORDER BY Facturación DESC
  
    END
GO
/****** Object:  StoredProcedure [dbo].[listadoDeRespYProducto]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listadoDeRespYProducto]
@Id nvarchar(100)
AS
BEGIN
  SELECT PyR.Pregunta, PyR.Respuesta, PyR.FechaRespuesta, PyR.UsuarioPregunta AS 'Usuario Pregunta',
   P.Descripcion as 'Descripción del Producto', P.Precio, P.Tipo as 'Tipo de Publicación',
    V.Descripcion as 'Visibilidad', R.Descripcion as 'Rubro' 
    FROM Publicacion P 
	JOIN Visibilidad V ON
P.Visibilidad_Cod = V.Codigo 
	JOIN Rubro R ON
R.Codigo = P.Rubro_Cod 
	JOIN PreguntasYRespuestas PyR ON
P.Codigo = PyR.Id_Publicacion
  WHERE PyR.UsuarioPregunta = @Id AND
  PyR.Respuesta IS NOT NULL
  
  END
GO
/****** Object:  StoredProcedure [dbo].[listadoDePreguntasAResponder]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listadoDePreguntasAResponder]
@Usuario nvarchar(100)
AS
BEGIN
SELECT Id, Id_Publicacion, UsuarioPregunta, Pregunta FROM PreguntasYRespuestas
WHERE Respuesta IS NULL 
AND UsuarioPublicador = @Usuario
END
GO
/****** Object:  StoredProcedure [dbo].[listaDePublicacionesSinFacturar]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listaDePublicacionesSinFacturar]

@id numeric (18,0)
as
begin
select Codigo,Descripcion,Tipo,Estado from Publicacion 
where Codigo not in(select Pub_Cod from Factura)
and id = @id
end
GO
/****** Object:  Table [dbo].[Item_Factura]    Script Date: 06/18/2014 01:46:15 ******/
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
/****** Object:  StoredProcedure [dbo].[historialOfertas]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[historialOfertas]
		@Id nvarchar(30)
    
   	AS
	BEGIN
		
	SELECT O.Fecha, P.Descripcion, O.Monto, U.Usuario AS 'Vendedor', (CASE WHEN C.Id_Cliente = O.Id AND C.Codigo_Pub = O.Codigo_Pub THEN 'Ganó subasta' WHEN O.Con_ganador = 0 THEN 'No finalizada' ELSE 'No ganó' END) AS 'Resultado'
		
    FROM Publicacion P 
	JOIN Oferta O ON
    P.Codigo = O.Codigo_Pub
    JOIN Compra C ON
    P.Codigo = C.Codigo_Pub
    JOIN Usuario U ON
    P.Publicador = (CASE WHEN U.Id_Rol = 1 THEN 
        'C'
    WHEN U.Id_Rol = 2 THEN
        'E'
    END) AND P.Id = U.Id_Usuario
	
    WHERE O.Id = @Id
    order by O.Fecha
  
    END
GO
/****** Object:  StoredProcedure [dbo].[facturasTop]    Script Date: 06/18/2014 01:46:17 ******/
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
 Codigo from Publicacion 
where Codigo not in(select Pub_Cod from Factura)
and id = @Id
order by Fecha desc

end
GO
/****** Object:  StoredProcedure [dbo].[cambiarConGanador]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[buscarMaximaOferta]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[agregarUnaPregunta]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarUnaPregunta]
@UsuarioPreg nvarchar(100),
@Id_Publicacion numeric(18,0),
@Pregunta nvarchar(255),
@Publicador nvarchar(100)
AS
BEGIN
INSERT INTO PreguntasYRespuestas(UsuarioPublicador,
UsuarioPregunta,
Pregunta,
Id_Publicacion)
VALUES(@Publicador,
@UsuarioPreg,
@Pregunta,
@Id_Publicacion)
END
GO
/****** Object:  StoredProcedure [dbo].[agregarRespuesta]    Script Date: 06/18/2014 01:46:17 ******/
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
/****** Object:  StoredProcedure [dbo].[agregarFactura]    Script Date: 06/18/2014 01:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[agregarFactura]

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
GO
/****** Object:  StoredProcedure [dbo].[agregarNuevaOferta]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[agregarNuevaOferta]
		@Cod_Pub numeric(18,0),
		@Monto numeric(18,2),
		@Id_Cli numeric(18,0)

AS
BEGIN
	INSERT INTO Oferta(
	Codigo_Pub,
	Fecha,
	Id,
	Monto)
	VALUES(
	@Cod_Pub,
	GETDATE(),
	@Id_Cli,
	@Monto)	

END
GO
/****** Object:  StoredProcedure [dbo].[agregarItemFactura]    Script Date: 06/18/2014 01:46:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[agregarItemFactura]

@Codigo numeric (18,0),
@Precio numeric (18,2),
@Nro_Fact numeric (18,2),
@Cant numeric (18,0)
AS 
BEGIN
insert into Item_Factura
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
/****** Object:  Default [DF__Clientes__Tipo_d__09946309]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT ((1)) FOR [Tipo_dni]
GO
/****** Object:  Default [DF__Clientes__Telefo__0A888742]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Clientes] ADD  DEFAULT ('') FOR [Telefono]
GO
/****** Object:  Default [DF__Empresa__Telefon__0B7CAB7B]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Empresa] ADD  DEFAULT ('') FOR [Telefono]
GO
/****** Object:  Default [DF__Empresa__Ciudad__0C70CFB4]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Empresa] ADD  DEFAULT ('') FOR [Ciudad]
GO
/****** Object:  Default [DF__Empresa__Nombre___0D64F3ED]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Empresa] ADD  DEFAULT ('') FOR [Nombre_Contacto]
GO
/****** Object:  Default [DF__Empresa__Tipo__0E591826]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Empresa] ADD  DEFAULT ((2)) FOR [Tipo]
GO
/****** Object:  Default [DF__Publicaci__Pregu__0F4D3C5F]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Publicacion] ADD  DEFAULT ((0)) FOR [Preguntas_permitidas]
GO
/****** Object:  ForeignKey [FK_Clientes_Tipo_Doc]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Tipo_Doc] FOREIGN KEY([Tipo_dni])
REFERENCES [dbo].[Tipo_Doc] ([Codigo])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Tipo_Doc]
GO
/****** Object:  ForeignKey [FK_Empresa_Tipo_Doc]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Empresa]  WITH CHECK ADD  CONSTRAINT [FK_Empresa_Tipo_Doc] FOREIGN KEY([Tipo])
REFERENCES [dbo].[Tipo_Doc] ([Codigo])
GO
ALTER TABLE [dbo].[Empresa] CHECK CONSTRAINT [FK_Empresa_Tipo_Doc]
GO
/****** Object:  ForeignKey [FK_Factura_Publicacion]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Publicacion] FOREIGN KEY([Pub_Cod])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Publicacion]
GO
/****** Object:  ForeignKey [FK_Factura_Tipo_Pago]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Tipo_Pago] FOREIGN KEY([Forma_Pago_Desc])
REFERENCES [dbo].[Tipo_Pago] ([Codigo])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Tipo_Pago]
GO
/****** Object:  ForeignKey [FK_Funcionalidades_Rol]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Funcionalidades]  WITH CHECK ADD  CONSTRAINT [FK_Funcionalidades_Rol] FOREIGN KEY([Id_Rol])
REFERENCES [dbo].[Rol] ([Id])
GO
ALTER TABLE [dbo].[Funcionalidades] CHECK CONSTRAINT [FK_Funcionalidades_Rol]
GO
/****** Object:  ForeignKey [FK_Item_Factura_Factura]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Item_Factura]  WITH CHECK ADD  CONSTRAINT [FK_Item_Factura_Factura] FOREIGN KEY([Nro_Fact], [Pub_Cod])
REFERENCES [dbo].[Factura] ([Numero], [Pub_Cod])
GO
ALTER TABLE [dbo].[Item_Factura] CHECK CONSTRAINT [FK_Item_Factura_Factura]
GO
/****** Object:  ForeignKey [FK_Oferta_Clientes]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Oferta]  WITH CHECK ADD  CONSTRAINT [FK_Oferta_Clientes] FOREIGN KEY([Id])
REFERENCES [dbo].[Clientes] ([Id])
GO
ALTER TABLE [dbo].[Oferta] CHECK CONSTRAINT [FK_Oferta_Clientes]
GO
/****** Object:  ForeignKey [FK_Oferta_Publicacion]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Oferta]  WITH CHECK ADD  CONSTRAINT [FK_Oferta_Publicacion] FOREIGN KEY([Codigo_Pub])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[Oferta] CHECK CONSTRAINT [FK_Oferta_Publicacion]
GO
/****** Object:  ForeignKey [FK_PreguntasYRespuestas_Publicacion]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[PreguntasYRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_PreguntasYRespuestas_Publicacion] FOREIGN KEY([Id_Publicacion])
REFERENCES [dbo].[Publicacion] ([Codigo])
GO
ALTER TABLE [dbo].[PreguntasYRespuestas] CHECK CONSTRAINT [FK_PreguntasYRespuestas_Publicacion]
GO
/****** Object:  ForeignKey [FK_Publicacion_Rubro]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Rubro] FOREIGN KEY([Rubro_Cod])
REFERENCES [dbo].[Rubro] ([Codigo])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Rubro]
GO
/****** Object:  ForeignKey [FK_Publicacion_Visibilidad]    Script Date: 06/18/2014 01:46:15 ******/
ALTER TABLE [dbo].[Publicacion]  WITH CHECK ADD  CONSTRAINT [FK_Publicacion_Visibilidad] FOREIGN KEY([Visibilidad_Cod])
REFERENCES [dbo].[Visibilidad] ([Codigo])
GO
ALTER TABLE [dbo].[Publicacion] CHECK CONSTRAINT [FK_Publicacion_Visibilidad]
GO




--Carga Tabla Tipos de Documentos
INSERT INTO Tipo_DOC VALUES (1,'DNI')
INSERT INTO Tipo_Doc VALUES (2,'CUIT')
INSERT INTO Tipo_Doc VALUES (3,'LE')
INSERT INTO Tipo_Doc VALUES (4,'LC')
INSERT INTO Tipo_Doc VALUES (5,'PAS')

--Carga Tabla Tipos de Pago
INSERT INTO Tipo_Pago VALUES (1,'Efectivo')
INSERT INTO Tipo_Pago VALUES (2,'Tarjeta de crédito')
INSERT INTO Tipo_Pago VALUES (3,'Tarjeta de débito')
INSERT INTO Tipo_Pago VALUES (4,'Transferencia')
INSERT INTO Tipo_Pago VALUES (5,'Depósito bancario')

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

select distinct Publicacion_Cod,Clientes.id,Compra_Fecha,Compra_Cantidad,Calificacion_Codigo,
 Calificacion_Cant_Estrellas/2,Calificacion_Descripcion

from gd_esquema.Maestra, Clientes

where Cli_Dni= Clientes.dni
and Publicacion_Cod is not null
and Calificacion_Codigo is not null
and Compra_Fecha is not null
and Compra_Cantidad is not null

-- migracion tabla oferta

insert into Oferta

select distinct Publicacion_Cod,Oferta_Fecha,Oferta_Monto,Clientes.id,1

from gd_esquema.Maestra, Clientes


where cli_dni = clientes.dni
and Publicacion_Cod is not null
and Clientes.Id is not null
and oferta_fecha is not null


 --carga tabla rol
INSERT INTO rol VALUES ('Cliente',1)
INSERT INTO rol VALUES ('Empresa',1)
INSERT INTO rol VALUES ('Admin',1)

--migracion tabla usuario

insert into Usuario
select distinct clientes.Mail,convert(nvarchar,Clientes.Dni),clientes.Id,rol.id,10,0,1
 from Clientes,rol
 where rol.nombre = 'Cliente'
union all
 select distinct Empresa.Mail,Empresa.Cuit,Empresa.Id,rol.id,10,0,1
 from Empresa,rol
 where rol.nombre = 'Empresa'

--cargar tabla funcionabilidades
--Lo que hace el admin
INSERT INTO Funcionalidades VALUES(3,1)
INSERT INTO Funcionalidades VALUES(3,2)
INSERT INTO Funcionalidades VALUES(3,3)
INSERT INTO Funcionalidades VALUES(3,4)
INSERT INTO Funcionalidades VALUES(3,5)
INSERT INTO Funcionalidades VALUES(3,6)
--Lo que hace el cliente
INSERT INTO Funcionalidades VALUES(1,10)
INSERT INTO Funcionalidades VALUES(1,11)
INSERT INTO Funcionalidades VALUES(1,12)
INSERT INTO Funcionalidades VALUES(1,14)
INSERT INTO Funcionalidades VALUES(1,15)
INSERT INTO Funcionalidades VALUES(1,16)
INSERT INTO Funcionalidades VALUES(1,17)
INSERT INTO Funcionalidades VALUES(1,18)
--Lo que hace una empresa
INSERT INTO Funcionalidades VALUES(2,10)
INSERT INTO Funcionalidades VALUES(2,11)
INSERT INTO Funcionalidades VALUES(2,12)
INSERT INTO Funcionalidades VALUES(2,15)
INSERT INTO Funcionalidades VALUES(2,16)

--Administrador
INSERT INTO Usuario VALUES(
'admin','781b2694e28e47c7664253f49183aed409c96bd439600f113befdaeede93eae6',0,3,1,0,1)