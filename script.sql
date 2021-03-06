USE [Projet_Livraison]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Livraison]') AND type in (N'U'))
ALTER TABLE [dbo].[Livraison] DROP CONSTRAINT IF EXISTS [FK_Livraison_Client]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Livraison]') AND type in (N'U'))
ALTER TABLE [dbo].[Livraison] DROP CONSTRAINT IF EXISTS [DF_Livraison_CreatedAt]
GO
/****** Object:  Table [dbo].[Livraison]    Script Date: 14/04/2022 12:34:10 ******/
DROP TABLE IF EXISTS [dbo].[Livraison]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 14/04/2022 12:34:10 ******/
DROP TABLE IF EXISTS [dbo].[Client]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 14/04/2022 12:34:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](50) NOT NULL,
	[Phone] [int] NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Livraison]    Script Date: 14/04/2022 12:34:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livraison](
	[Id_Livraison] [int] IDENTITY(1,1) NOT NULL,
	[Reference] [varchar](50) NOT NULL,
	[Lieu] [varchar](50) NOT NULL,
	[CreatedAt] [date] NOT NULL,
	[ClientId] [int] NULL,
 CONSTRAINT [PK_Livraison] PRIMARY KEY CLUSTERED 
(
	[Id_Livraison] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Livraison] ADD  CONSTRAINT [DF_Livraison_CreatedAt]  DEFAULT (getdate()) FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Livraison]  WITH CHECK ADD  CONSTRAINT [FK_Livraison_Client] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Client] ([Id])
GO
ALTER TABLE [dbo].[Livraison] CHECK CONSTRAINT [FK_Livraison_Client]
GO
