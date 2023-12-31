USE [master]
GO
/****** Object:  Database [AddCart_DB]    Script Date: 12/1/2023 12:49:42 PM ******/
CREATE DATABASE [AddCart_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AddCart_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\AddCart_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AddCart_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\AddCart_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AddCart_DB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AddCart_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AddCart_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AddCart_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AddCart_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AddCart_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AddCart_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [AddCart_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AddCart_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AddCart_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AddCart_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AddCart_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AddCart_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AddCart_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AddCart_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AddCart_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AddCart_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AddCart_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AddCart_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AddCart_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AddCart_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AddCart_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AddCart_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AddCart_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AddCart_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [AddCart_DB] SET  MULTI_USER 
GO
ALTER DATABASE [AddCart_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AddCart_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AddCart_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AddCart_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AddCart_DB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AddCart_DB', N'ON'
GO
ALTER DATABASE [AddCart_DB] SET QUERY_STORE = OFF
GO
USE [AddCart_DB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [AddCart_DB]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/1/2023 12:49:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[catid] [int] IDENTITY(1,1) NOT NULL,
	[catname] [varchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[catid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/1/2023 12:49:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[cust_id] [int] IDENTITY(1,1) NOT NULL,
	[cust_name] [varchar](50) NULL,
	[cust_email] [varchar](50) NULL,
	[cust_password] [varchar](50) NULL,
	[cust_phone] [varchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[cust_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderTable]    Script Date: 12/1/2023 12:49:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderTable](
	[Order_id] [int] IDENTITY(1,1) NOT NULL,
	[Fullname] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[Total_Amount] [varchar](50) NULL,
	[Order_Date] [varchar](50) NULL,
	[P_id_fk] [int] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/1/2023 12:49:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[proid] [int] IDENTITY(1,1) NOT NULL,
	[proname] [varchar](50) NULL,
	[proprice] [float] NULL,
	[prodes] [varchar](250) NULL,
	[proimage] [varchar](50) NULL,
	[cat_id_fk] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[proid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([catid], [catname]) VALUES (1, N'Men’s')
INSERT [dbo].[Category] ([catid], [catname]) VALUES (2, N'Women’s')
INSERT [dbo].[Category] ([catid], [catname]) VALUES (3, N'Kid’s')
INSERT [dbo].[Category] ([catid], [catname]) VALUES (4, N'Watch')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([cust_id], [cust_name], [cust_email], [cust_password], [cust_phone]) VALUES (1, N'Marium', N'm@gmail.com', N'123', N'12345678')
INSERT [dbo].[Customer] ([cust_id], [cust_name], [cust_email], [cust_password], [cust_phone]) VALUES (2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Customer] ([cust_id], [cust_name], [cust_email], [cust_password], [cust_phone]) VALUES (3, N'Rufaida', N'r@gmail.com', N'aptech', N'03212525315372')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[OrderTable] ON 

INSERT [dbo].[OrderTable] ([Order_id], [Fullname], [Phone], [Address], [Quantity], [Total_Amount], [Order_Date], [P_id_fk]) VALUES (1, N'Marium Younus', N'0347-2145450', N'Sakhi Hassan', 2, N'1,054.35 $', N'12/1/2023 12:41:59 PM', 1)
INSERT [dbo].[OrderTable] ([Order_id], [Fullname], [Phone], [Address], [Quantity], [Total_Amount], [Order_Date], [P_id_fk]) VALUES (2, N'Rufaida Mehmood', N'035521343450', N'Gulshan', 1, N'563.39 $', N'12/1/2023 12:46:47 PM', 1)
SET IDENTITY_INSERT [dbo].[OrderTable] OFF
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([proid], [proname], [proprice], [prodes], [proimage], [cat_id_fk]) VALUES (1, N'Guangzhou sweater', 495, N'Lorem ipsum dolor sit amet, consectetur ing elit, sed do eiusmod tempor sum dolor sit amet, consectetur adipisicing elit, sed do mod tempor', N'product-3.jpg', 1)
INSERT [dbo].[Product] ([proid], [proname], [proprice], [prodes], [proimage], [cat_id_fk]) VALUES (2, N'Pure Pineapple', 35, N'Lorem ipsum dolor sit amet, consectetur ing elit, sed do eiusmod tempor sum dolor sit amet, consectetur adipisicing elit, sed do mod tempor', N'product-1.jpg', 2)
INSERT [dbo].[Product] ([proid], [proname], [proprice], [prodes], [proimage], [cat_id_fk]) VALUES (3, N'Converse Shoes', 34, N'Lorem ipsum dolor sit amet, consectetur ing elit, sed do eiusmod tempor sum dolor sit amet, consectetur adipisicing elit, sed do mod tempor', N'product-6.jpg', 2)
SET IDENTITY_INSERT [dbo].[Product] OFF
ALTER TABLE [dbo].[OrderTable]  WITH CHECK ADD  CONSTRAINT [FK_OrderTable_Product] FOREIGN KEY([P_id_fk])
REFERENCES [dbo].[Product] ([proid])
GO
ALTER TABLE [dbo].[OrderTable] CHECK CONSTRAINT [FK_OrderTable_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([cat_id_fk])
REFERENCES [dbo].[Category] ([catid])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
USE [master]
GO
ALTER DATABASE [AddCart_DB] SET  READ_WRITE 
GO
