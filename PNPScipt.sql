USE [PNPdata]
GO
/****** Object:  Table [dbo].[tbBill*]    Script Date: 2024-05-10 2:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbBill*](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BillCode] [nvarchar](20) NOT NULL,
	[CustomerID] [int] NULL,
	[StaffID] [int] NULL,
	[DOS] [datetime] NULL,
	[Total] [float] NULL,
	[CustomerCode] [nvarchar](20) NULL,
	[StaffCode] [nvarchar](20) NULL,
 CONSTRAINT [PK_tbBill] PRIMARY KEY CLUSTERED 
(
	[BillCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbBillDetails*]    Script Date: 2024-05-10 2:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbBillDetails*](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[ProductName] [nvarchar](50) NULL,
	[ProductCode] [nvarchar](20) NULL,
	[BillID] [int] NULL,
	[BillCode] [nvarchar](20) NULL,
	[Amount] [int] NULL,
	[UnitPrice] [float] NULL,
	[Discount] [float] NULL,
	[IntoMoney] [float] NULL,
 CONSTRAINT [PK_tbBillDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbCustomer*]    Script Date: 2024-05-10 2:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbCustomer*](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerCode] [nvarchar](20) NULL,
	[Name] [nvarchar](50) NULL,
	[Age] [datetime] NULL,
	[Gender] [nvarchar](10) NULL,
	[PhoneNumber] [nvarchar](12) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbCustomer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbLogin]    Script Date: 2024-05-10 2:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbLogin](
	[ID] [int] NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbLogin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbProduct*]    Script Date: 2024-05-10 2:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbProduct*](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductCode] [nvarchar](20) NULL,
	[ProductName] [nvarchar](50) NULL,
	[Size] [nvarchar](5) NULL,
	[Color] [nvarchar](10) NULL,
	[Amount] [int] NULL,
	[ProductType] [nvarchar](10) NULL,
	[Price] [float] NULL,
 CONSTRAINT [PK_tbProduct] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbSalary*]    Script Date: 2024-05-10 2:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbSalary*](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StaffID] [int] NULL,
	[StaffCode] [nvarchar](20) NULL,
	[StaffName] [nvarchar](20) NULL,
	[Hours work] [int] NULL,
	[Bonus] [float] NULL,
	[Total Salary] [float] NULL,
 CONSTRAINT [PK_tbSalary] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbStaff*]    Script Date: 2024-05-10 2:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbStaff*](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StaffCode] [nvarchar](20) NULL,
	[Name] [nvarchar](50) NULL,
	[Age] [datetime] NULL,
	[Gender] [nvarchar](10) NULL,
	[PhoneNumber] [nvarchar](12) NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbStaff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbStatistic*]    Script Date: 2024-05-10 2:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbStatistic*](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Total amount of bill] [int] NULL,
	[[Total salary of Staff] [float] NULL,
	[Revuene] [float] NULL,
	[Profit] [float] NULL,
	[BillIDDetails] [int] NULL,
	[SalaryID] [int] NULL,
	[ProductID] [int] NULL,
 CONSTRAINT [PK_tbStatistic] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbWarehouse*]    Script Date: 2024-05-10 2:02:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbWarehouse*](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NULL,
	[ProductName] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[ProductCode] [nvarchar](20) NULL,
 CONSTRAINT [PK_tbWarehouse] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbBillDetails*]  WITH CHECK ADD  CONSTRAINT [FK_tbBillDetails*_tbBill*] FOREIGN KEY([BillCode])
REFERENCES [dbo].[tbBill*] ([BillCode])
GO
ALTER TABLE [dbo].[tbBillDetails*] CHECK CONSTRAINT [FK_tbBillDetails*_tbBill*]
GO
ALTER TABLE [dbo].[tbBillDetails*]  WITH CHECK ADD  CONSTRAINT [FK_tbBillDetails_tbProduct] FOREIGN KEY([ProductID])
REFERENCES [dbo].[tbProduct*] ([ID])
GO
ALTER TABLE [dbo].[tbBillDetails*] CHECK CONSTRAINT [FK_tbBillDetails_tbProduct]
GO
ALTER TABLE [dbo].[tbSalary*]  WITH CHECK ADD  CONSTRAINT [FK_tbSalary_tbStaff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[tbStaff*] ([ID])
GO
ALTER TABLE [dbo].[tbSalary*] CHECK CONSTRAINT [FK_tbSalary_tbStaff]
GO
ALTER TABLE [dbo].[tbStatistic*]  WITH CHECK ADD  CONSTRAINT [FK_tbStatistic_tbBillDetails] FOREIGN KEY([BillIDDetails])
REFERENCES [dbo].[tbBillDetails*] ([ID])
GO
ALTER TABLE [dbo].[tbStatistic*] CHECK CONSTRAINT [FK_tbStatistic_tbBillDetails]
GO
ALTER TABLE [dbo].[tbStatistic*]  WITH CHECK ADD  CONSTRAINT [FK_tbStatistic_tbProduct] FOREIGN KEY([ProductID])
REFERENCES [dbo].[tbProduct*] ([ID])
GO
ALTER TABLE [dbo].[tbStatistic*] CHECK CONSTRAINT [FK_tbStatistic_tbProduct]
GO
ALTER TABLE [dbo].[tbStatistic*]  WITH CHECK ADD  CONSTRAINT [FK_tbStatistic_tbSalary] FOREIGN KEY([SalaryID])
REFERENCES [dbo].[tbSalary*] ([ID])
GO
ALTER TABLE [dbo].[tbStatistic*] CHECK CONSTRAINT [FK_tbStatistic_tbSalary]
GO
ALTER TABLE [dbo].[tbWarehouse*]  WITH CHECK ADD  CONSTRAINT [FK_tbWarehouse_tbProduct] FOREIGN KEY([ProductID])
REFERENCES [dbo].[tbProduct*] ([ID])
GO
ALTER TABLE [dbo].[tbWarehouse*] CHECK CONSTRAINT [FK_tbWarehouse_tbProduct]
GO
