USE [chat]
GO

/****** Object:  Table [dbo].[usuarios]    Script Date: 03/04/2016 14:24:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

--Tabla de roles
CREATE TABLE [dbo].[roles](
	[nIdRol] [int] NOT NULL IDENTITY(1, 1),
	[cNombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[nIdRol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
--Fin Tabla Roles


--Tabla Usuarios
CREATE TABLE [dbo].[usuarios](
	[nIdUsuario] [int] NOT NULL IDENTITY(1, 1),
	[cCodigousu] [varchar](50) NOT NULL,
	[cNomUsuari] [varchar](100) NOT NULL,
	[nIdRol] [int] NOT NULL,
	[nEstadousu] [int] NOT NULL,
 CONSTRAINT [PK_usuarios] PRIMARY KEY CLUSTERED 
(
	[nIdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [FK_usuarios_roles] FOREIGN KEY([nIdRol])
REFERENCES [dbo].[roles] ([nIdRol])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [FK_usuarios_roles]
GO

--Fin tabla usuarios

--Tabla chats
CREATE TABLE [dbo].[chats](
	[nIdChat] [bigint] NOT NULL IDENTITY(1, 1),
	[cNomclient] [varchar](150) NOT NULL,
	[cTelCliente] [varchar](50) NULL,
	[cEmailClien] [varchar](50) NULL,
	[nEstado] [int] NOT NULL,
	[dFechaIng] [datetime] NULL,
	[dFechaAte] [datetime] NULL,
	[dFechaFin] [datetime] NULL,
	[direccionIp] [varchar](30) NULL,
	[cCodigoUsu] [varchar](50) NOT NULL,
	[cTextoChat] [nvarchar](max) NOT NULL,
	[nCalifica] [int] NOT NULL,
	[nComenExt] [varchar](250) NULL,
	[nComenInt] [varchar](250) NULL,
 CONSTRAINT [PK_chats] PRIMARY KEY CLUSTERED 
(
	[nIdChat] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
--fin --Tabla chats

--Tabla bloqueos
CREATE TABLE [dbo].[bloqueos](
	[direccionIp] [varchar](30) NOT NULL,
	[nIntentos] [int] NOT NULL,
 CONSTRAINT [PK_bloqueos] PRIMARY KEY CLUSTERED 
(
	[direccionIp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

--Fin Tabla bloqueos.



SET ANSI_PADDING OFF
GO