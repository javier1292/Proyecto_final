USE [master]
GO
/****** Object:  Database [Red]    Script Date: 09/08/2020 20:10:29 ******/
CREATE DATABASE [Red]
go
USE [Red]
GO
/****** Object:  Table [dbo].[amigos]    Script Date: 09/08/2020 20:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[amigos](
	[IDA] [int] IDENTITY(1,1) NOT NULL,
	[IDU] [int] NULL,
	[IDUA] [int] NULL,
	[NombreU] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comentario]    Script Date: 09/08/2020 20:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comentario](
	[IDC] [int] IDENTITY(1,1) NOT NULL,
	[IDP] [int] NULL,
	[IDU] [int] NULL,
	[comentario] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[eventos]    Script Date: 09/08/2020 20:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eventos](
	[IDE] [int] IDENTITY(1,1) NOT NULL,
	[IDU] [int] NULL,
	[NombreE] [varchar](100) NULL,
	[Lugar] [varchar](max) NULL,
	[cantidadI] [int] NULL,
	[fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[invitados]    Script Date: 09/08/2020 20:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[invitados](
	[IDI] [int] IDENTITY(1,1) NOT NULL,
	[IDE] [int] NULL,
	[IDUA] [int] NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[nombreU] [varchar](50) NULL,
	[respuesta] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[publicacion]    Script Date: 09/08/2020 20:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[publicacion](
	[IDP] [int] IDENTITY(1,1) NOT NULL,
	[IDU] [int] NULL,
	[titulo] [varchar](30) NULL,
	[contenido] [varchar](max) NULL,
	[fecha] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registro]    Script Date: 09/08/2020 20:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro](
	[IDU] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
	[Apellido] [varchar](30) NULL,
	[foto] [varchar](max) NULL,
	[correo] [varchar](30) NULL,
	[usuario] [varchar](30) NULL,
	[contraseña] [varchar](30) NULL,
	[Ccontra] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[amigos]  WITH CHECK ADD FOREIGN KEY([IDU])
REFERENCES [dbo].[Registro] ([IDU])
GO
ALTER TABLE [dbo].[comentario]  WITH CHECK ADD  CONSTRAINT [FK__comentario__IDP__29572725] FOREIGN KEY([IDP])
REFERENCES [dbo].[publicacion] ([IDP])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[comentario] CHECK CONSTRAINT [FK__comentario__IDP__29572725]
GO
ALTER TABLE [dbo].[comentario]  WITH CHECK ADD  CONSTRAINT [FK__comentario__IDU__2A4B4B5E] FOREIGN KEY([IDU])
REFERENCES [dbo].[Registro] ([IDU])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[comentario] CHECK CONSTRAINT [FK__comentario__IDU__2A4B4B5E]
GO
ALTER TABLE [dbo].[eventos]  WITH CHECK ADD FOREIGN KEY([IDU])
REFERENCES [dbo].[Registro] ([IDU])
GO
ALTER TABLE [dbo].[invitados]  WITH CHECK ADD  CONSTRAINT [FK__invitados__IDE__4AB81AF0] FOREIGN KEY([IDE])
REFERENCES [dbo].[eventos] ([IDE])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[invitados] CHECK CONSTRAINT [FK__invitados__IDE__4AB81AF0]
GO
ALTER TABLE [dbo].[invitados]  WITH CHECK ADD FOREIGN KEY([IDUA])
REFERENCES [dbo].[Registro] ([IDU])
GO
ALTER TABLE [dbo].[publicacion]  WITH CHECK ADD FOREIGN KEY([IDU])
REFERENCES [dbo].[Registro] ([IDU])
GO
/****** Object:  StoredProcedure [dbo].[edi]    Script Date: 09/08/2020 20:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[edi]
@IDU int,
@contra varchar (30),
@Ccontra varchar (30)
as
update Registro set  contraseña=@contra, Ccontra=@Ccontra
where IDU=@IDU
GO
/****** Object:  StoredProcedure [dbo].[Editar]    Script Date: 09/08/2020 20:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Editar]
@Id int,		
@titulo varchar(30) ,
@contenido varchar (max)
as
update publicacion set titulo=@titulo,contenido=@contenido
where IDP = @Id
GO
/****** Object:  StoredProcedure [dbo].[EliminarA]    Script Date: 09/08/2020 20:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarA]
@IDA int
as
delete from amigos where IDA = @IDA
GO
/****** Object:  StoredProcedure [dbo].[eliminarE]    Script Date: 09/08/2020 20:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[eliminarE]
@IDE int 
as
delete from eventos where IDE=@IDE
GO
/****** Object:  StoredProcedure [dbo].[eliminarI]    Script Date: 09/08/2020 20:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminarI]
@IDI int 
as
delete from invitados where IDI=@IDI
GO
/****** Object:  StoredProcedure [dbo].[EliminarP]    Script Date: 09/08/2020 20:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EliminarP]
@IDP int
as
delete from publicacion where IDP = @IDP
GO
/****** Object:  StoredProcedure [dbo].[Respuesta]    Script Date: 09/08/2020 20:10:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Respuesta]
@IDI int,
@Respuesta varchar (30)
as
update invitados set respuesta=@Respuesta
where IDI=@IDI
GO
USE [master]
GO
ALTER DATABASE [Red] SET  READ_WRITE 
GO
