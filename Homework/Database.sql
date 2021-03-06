USE [ShopProductDB]
GO
/****** Object:  Table [dbo].[ShopTable]    Script Date: 10/17/2014 03:52:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ShopTable](
	[ShopId] [int] IDENTITY(1,1) NOT NULL,
	[ShopName] [varchar](50) NOT NULL,
	[ShopAddress] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ShopTable] PRIMARY KEY CLUSTERED 
(
	[ShopId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ShopTable] ON
INSERT [dbo].[ShopTable] ([ShopId], [ShopName], [ShopAddress]) VALUES (1, N'Ronok', N'Dhaka')
INSERT [dbo].[ShopTable] ([ShopId], [ShopName], [ShopAddress]) VALUES (2, N'Sajib', N'Dhaka')
INSERT [dbo].[ShopTable] ([ShopId], [ShopName], [ShopAddress]) VALUES (3, N'df', N'dvv')
INSERT [dbo].[ShopTable] ([ShopId], [ShopName], [ShopAddress]) VALUES (4, N'rttttt', N'dhaaaaa')
SET IDENTITY_INSERT [dbo].[ShopTable] OFF
/****** Object:  Table [dbo].[ProductTable]    Script Date: 10/17/2014 03:52:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductTable](
	[ProductId] [int] NOT NULL,
	[ProductQuantity] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ProductTable] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ProductTable] ([ProductId], [ProductQuantity]) VALUES (1, N'12345')
INSERT [dbo].[ProductTable] ([ProductId], [ProductQuantity]) VALUES (5, N'100')
INSERT [dbo].[ProductTable] ([ProductId], [ProductQuantity]) VALUES (6, N'200')
INSERT [dbo].[ProductTable] ([ProductId], [ProductQuantity]) VALUES (8, N'100')
INSERT [dbo].[ProductTable] ([ProductId], [ProductQuantity]) VALUES (10, N'200')
INSERT [dbo].[ProductTable] ([ProductId], [ProductQuantity]) VALUES (123, N'1000')
