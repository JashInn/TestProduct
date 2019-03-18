USE [master]
GO
/****** Object:  Database [TestDB]    Script Date: 3/18/2019 11:19:26 AM ******/
CREATE DATABASE [TestDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TestDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\TestDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TestDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\TestDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

USE [TestDB]
GO
/****** Object:  Table [dbo].[Attribute]    Script Date: 3/18/2019 11:19:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attribute](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_Attribute] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AttributeCategoryMap]    Script Date: 3/18/2019 11:19:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AttributeCategoryMap](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AttributeId] [int] NULL,
	[CategoryId] [int] NULL,
 CONSTRAINT [PK_AttributeCategoryMap] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 3/18/2019 11:19:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 3/18/2019 11:19:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Description] [varchar](max) NULL,
	[CategoryId] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductAttributeMap]    Script Date: 3/18/2019 11:19:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductAttributeMap](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[AttributeId] [int] NULL,
	[Value] [varchar](200) NULL,
 CONSTRAINT [PK_ProductAttributeMap] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AttributeCategoryMap]  WITH CHECK ADD  CONSTRAINT [FK_AttributeCategoryMap_Attribute] FOREIGN KEY([AttributeId])
REFERENCES [dbo].[Attribute] ([Id])
GO
ALTER TABLE [dbo].[AttributeCategoryMap] CHECK CONSTRAINT [FK_AttributeCategoryMap_Attribute]
GO
ALTER TABLE [dbo].[AttributeCategoryMap]  WITH CHECK ADD  CONSTRAINT [FK_AttributeCategoryMap_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[AttributeCategoryMap] CHECK CONSTRAINT [FK_AttributeCategoryMap_Category]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
ALTER TABLE [dbo].[ProductAttributeMap]  WITH CHECK ADD  CONSTRAINT [FK_ProductAttributeMap_Attribute] FOREIGN KEY([AttributeId])
REFERENCES [dbo].[Attribute] ([Id])
GO
ALTER TABLE [dbo].[ProductAttributeMap] CHECK CONSTRAINT [FK_ProductAttributeMap_Attribute]
GO
ALTER TABLE [dbo].[ProductAttributeMap]  WITH CHECK ADD  CONSTRAINT [FK_ProductAttributeMap_Product] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[ProductAttributeMap] CHECK CONSTRAINT [FK_ProductAttributeMap_Product]
GO
set identity_insert Category ON
Insert into Category (Id,[Name]) values (1,'Mobile'),(2,'Apparal'),(3,'Cosmetic')
set identity_insert Category OFF
set identity_insert Attribute ON
Insert into Attribute (Id,[Name]) values (1,'Make'),(2,'Model'),(3,'Brand'),(4,'Size'),(5,'Weight')
set identity_insert Attribute OFF
Insert into AttributeCategoryMap (AttributeId,CategoryId) values (1,1),(2,1),(3,1),(3,2),(4,2),(3,3),(5,3)
USE [master]
GO
ALTER DATABASE [TestDB] SET  READ_WRITE 
GO
