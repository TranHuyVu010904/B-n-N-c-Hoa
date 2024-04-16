USE [QuanLyChuyenBay]
GO
/****** Object:  Table [dbo].[ChuyenBay]    Script Date: 4/10/2024 2:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuyenBay](
	[MaChuyenBay] [nchar](10) NOT NULL,
	[MaMayBay] [nchar](10) NULL,
	[NgayVaThoiGianDi] [datetime] NULL,
	[NgayVaThoiGianDen] [datetime] NULL,
	[GioBay] [datetime] NULL,
	[GhiChu] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChuyenBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GheNgoi]    Script Date: 4/10/2024 2:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GheNgoi](
	[SoHieuGhe] [nchar](10) NOT NULL,
	[TrangThaiGhe] [nchar](10) NULL,
	[SoGhe] [int] NULL,
	[LoaiGhe] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[SoHieuGhe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HanhKhach]    Script Date: 4/10/2024 2:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HanhKhach](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [varchar](50) NOT NULL,
	[CMND] [nchar](12) NOT NULL,
	[DiaChi] [varchar](255) NULL,
	[Email] [varchar](50) NULL,
	[Name] [nchar](10) NULL,
	[Password] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuHoi]    Script Date: 4/10/2024 2:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuHoi](
	[MaVe] [int] NOT NULL,
	[ThongTinVeKhuHoi] [varbinary](max) NULL,
	[NgayDi] [date] NULL,
	[GioDi] [time](7) NULL,
	[NgayDen] [date] NULL,
	[NgayVe] [date] NULL,
	[GiaVe] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MayBay]    Script Date: 4/10/2024 2:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MayBay](
	[MaMayBay] [nchar](10) NOT NULL,
	[TenMayBay] [varchar](50) NULL,
	[HangSanXuat] [varchar](50) NULL,
	[SoLuongGhe] [int] NULL,
	[LoaiMayBay] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMayBay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MotChieu]    Script Date: 4/10/2024 2:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MotChieu](
	[MaVe] [int] NOT NULL,
	[ThongTinVeMotChieu] [varbinary](max) NULL,
	[NgayDi] [date] NULL,
	[GiaVe] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ve]    Script Date: 4/10/2024 2:28:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ve](
	[MaVe] [int] NOT NULL,
	[LoạiVé] [nchar](10) NULL,
	[MaChuyenBay] [nchar](10) NULL,
	[SoGhe] [int] NULL,
	[SoHieuGhe] [nchar](10) NULL,
	[MaKH] [nchar](10) NULL,
	[TenKH] [varchar](50) NULL,
	[ThoiGianDi] [datetime] NULL,
	[DiaDiemDi] [varchar](50) NULL,
	[DiaDiemDen] [varchar](50) NULL,
	[SoThuTu] [int] NULL,
	[GhiChu] [varchar](max) NULL,
	[HangMayBay] [nchar](10) NULL,
	[GiaVe] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[ChuyenBay] ([MaChuyenBay], [MaMayBay], [NgayVaThoiGianDi], [NgayVaThoiGianDen], [GioBay], [GhiChu]) VALUES (N'CB001     ', N'MB001     ', CAST(N'2024-03-20T09:00:00.000' AS DateTime), CAST(N'2024-03-20T11:00:00.000' AS DateTime), CAST(N'1900-01-01T02:00:00.000' AS DateTime), N'On time')
INSERT [dbo].[ChuyenBay] ([MaChuyenBay], [MaMayBay], [NgayVaThoiGianDi], [NgayVaThoiGianDen], [GioBay], [GhiChu]) VALUES (N'CB002     ', N'MB002     ', CAST(N'2024-03-21T15:00:00.000' AS DateTime), CAST(N'2024-03-21T18:00:00.000' AS DateTime), CAST(N'1900-01-01T03:00:00.000' AS DateTime), N'Delayed')
INSERT [dbo].[ChuyenBay] ([MaChuyenBay], [MaMayBay], [NgayVaThoiGianDi], [NgayVaThoiGianDen], [GioBay], [GhiChu]) VALUES (N'CB003     ', N'MB003     ', CAST(N'2024-03-22T06:00:00.000' AS DateTime), CAST(N'2024-03-22T08:30:00.000' AS DateTime), CAST(N'1900-01-01T02:30:00.000' AS DateTime), N'On time')
INSERT [dbo].[ChuyenBay] ([MaChuyenBay], [MaMayBay], [NgayVaThoiGianDi], [NgayVaThoiGianDen], [GioBay], [GhiChu]) VALUES (N'CB004     ', N'MB004     ', CAST(N'2024-03-23T12:00:00.000' AS DateTime), CAST(N'2024-03-23T14:00:00.000' AS DateTime), CAST(N'1900-01-01T02:00:00.000' AS DateTime), N'On time')
INSERT [dbo].[ChuyenBay] ([MaChuyenBay], [MaMayBay], [NgayVaThoiGianDi], [NgayVaThoiGianDen], [GioBay], [GhiChu]) VALUES (N'CB005     ', N'MB005     ', CAST(N'2024-03-24T16:00:00.000' AS DateTime), CAST(N'2024-03-24T19:00:00.000' AS DateTime), CAST(N'1900-01-01T03:00:00.000' AS DateTime), N'Delayed')
GO
INSERT [dbo].[GheNgoi] ([SoHieuGhe], [TrangThaiGhe], [SoGhe], [LoaiGhe]) VALUES (N'GH001     ', N'Available ', 1, N'Normal    ')
INSERT [dbo].[GheNgoi] ([SoHieuGhe], [TrangThaiGhe], [SoGhe], [LoaiGhe]) VALUES (N'GH002     ', N'Booked    ', 2, N'VIP       ')
INSERT [dbo].[GheNgoi] ([SoHieuGhe], [TrangThaiGhe], [SoGhe], [LoaiGhe]) VALUES (N'GH003     ', N'Available ', 3, N'Normal    ')
INSERT [dbo].[GheNgoi] ([SoHieuGhe], [TrangThaiGhe], [SoGhe], [LoaiGhe]) VALUES (N'GH004     ', N'Booked    ', 4, N'VIP       ')
INSERT [dbo].[GheNgoi] ([SoHieuGhe], [TrangThaiGhe], [SoGhe], [LoaiGhe]) VALUES (N'GH005     ', N'Available ', 5, N'Normal    ')
GO
INSERT [dbo].[HanhKhach] ([MaKH], [TenKH], [CMND], [DiaChi], [Email], [Name], [Password]) VALUES (N'KH001     ', N'Nguyen Van A', N'123456789012', N'123 ABC, HCMC', N'nva@gmail.com', N'nguyenvana', N'123456    ')
INSERT [dbo].[HanhKhach] ([MaKH], [TenKH], [CMND], [DiaChi], [Email], [Name], [Password]) VALUES (N'KH002     ', N'Le Thi B', N'234567890123', N'456 DEF, Hanoi', N'ltb@gmail.com', N'lethib    ', N'123456    ')
INSERT [dbo].[HanhKhach] ([MaKH], [TenKH], [CMND], [DiaChi], [Email], [Name], [Password]) VALUES (N'KH003     ', N'Tran Van C', N'345678901234', N'789 GHI, Da Nang', N'tvc@gmail.com', N'tranvanc  ', N'123456    ')
INSERT [dbo].[HanhKhach] ([MaKH], [TenKH], [CMND], [DiaChi], [Email], [Name], [Password]) VALUES (N'KH004     ', N'Pham Thi D', N'456789012345', N'012 JKL, Can Tho', N'ptd@gmail.com', N'phamthid  ', N'123456    ')
INSERT [dbo].[HanhKhach] ([MaKH], [TenKH], [CMND], [DiaChi], [Email], [Name], [Password]) VALUES (N'KH005     ', N'Hoang Van E', N'567890123456', N'345 MNO, Hue', N'hve@gmail.com', N'hoangvane ', N'123456    ')
GO
INSERT [dbo].[KhuHoi] ([MaVe], [ThongTinVeKhuHoi], [NgayDi], [GioDi], [NgayDen], [NgayVe], [GiaVe]) VALUES (1, 0x, CAST(N'2024-04-01' AS Date), CAST(N'08:00:00' AS Time), CAST(N'2024-04-01' AS Date), CAST(N'2024-04-10' AS Date), CAST(150000.00 AS Decimal(18, 2)))
INSERT [dbo].[KhuHoi] ([MaVe], [ThongTinVeKhuHoi], [NgayDi], [GioDi], [NgayDen], [NgayVe], [GiaVe]) VALUES (2, 0x, CAST(N'2024-04-02' AS Date), CAST(N'09:00:00' AS Time), CAST(N'2024-04-02' AS Date), CAST(N'2024-04-11' AS Date), CAST(250000.00 AS Decimal(18, 2)))
INSERT [dbo].[KhuHoi] ([MaVe], [ThongTinVeKhuHoi], [NgayDi], [GioDi], [NgayDen], [NgayVe], [GiaVe]) VALUES (3, 0x, CAST(N'2024-04-03' AS Date), CAST(N'10:00:00' AS Time), CAST(N'2024-04-03' AS Date), CAST(N'2024-04-12' AS Date), CAST(350000.00 AS Decimal(18, 2)))
INSERT [dbo].[KhuHoi] ([MaVe], [ThongTinVeKhuHoi], [NgayDi], [GioDi], [NgayDen], [NgayVe], [GiaVe]) VALUES (4, 0x, CAST(N'2024-04-04' AS Date), CAST(N'11:00:00' AS Time), CAST(N'2024-04-04' AS Date), CAST(N'2024-04-13' AS Date), CAST(450000.00 AS Decimal(18, 2)))
INSERT [dbo].[KhuHoi] ([MaVe], [ThongTinVeKhuHoi], [NgayDi], [GioDi], [NgayDen], [NgayVe], [GiaVe]) VALUES (5, 0x, CAST(N'2024-04-05' AS Date), CAST(N'12:00:00' AS Time), CAST(N'2024-04-05' AS Date), CAST(N'2024-04-14' AS Date), CAST(550000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[MayBay] ([MaMayBay], [TenMayBay], [HangSanXuat], [SoLuongGhe], [LoaiMayBay]) VALUES (N'MB001     ', N'Airbus A320', N'Airbus', 180, N'Commercial')
INSERT [dbo].[MayBay] ([MaMayBay], [TenMayBay], [HangSanXuat], [SoLuongGhe], [LoaiMayBay]) VALUES (N'MB002     ', N'Boeing 737', N'Boeing', 160, N'Commercial')
INSERT [dbo].[MayBay] ([MaMayBay], [TenMayBay], [HangSanXuat], [SoLuongGhe], [LoaiMayBay]) VALUES (N'MB003     ', N'Airbus A380', N'Airbus', 853, N'Commercial')
INSERT [dbo].[MayBay] ([MaMayBay], [TenMayBay], [HangSanXuat], [SoLuongGhe], [LoaiMayBay]) VALUES (N'MB004     ', N'Boeing 747', N'Boeing', 660, N'Commercial')
INSERT [dbo].[MayBay] ([MaMayBay], [TenMayBay], [HangSanXuat], [SoLuongGhe], [LoaiMayBay]) VALUES (N'MB005     ', N'Embraer E195', N'Embraer', 132, N'Commercial')
GO
INSERT [dbo].[MotChieu] ([MaVe], [ThongTinVeMotChieu], [NgayDi], [GiaVe]) VALUES (1, 0x, CAST(N'2024-04-01' AS Date), CAST(150000.00 AS Decimal(18, 2)))
INSERT [dbo].[MotChieu] ([MaVe], [ThongTinVeMotChieu], [NgayDi], [GiaVe]) VALUES (2, 0x, CAST(N'2024-04-02' AS Date), CAST(250000.00 AS Decimal(18, 2)))
INSERT [dbo].[MotChieu] ([MaVe], [ThongTinVeMotChieu], [NgayDi], [GiaVe]) VALUES (3, 0x, CAST(N'2024-04-03' AS Date), CAST(350000.00 AS Decimal(18, 2)))
INSERT [dbo].[MotChieu] ([MaVe], [ThongTinVeMotChieu], [NgayDi], [GiaVe]) VALUES (4, 0x, CAST(N'2024-04-04' AS Date), CAST(450000.00 AS Decimal(18, 2)))
INSERT [dbo].[MotChieu] ([MaVe], [ThongTinVeMotChieu], [NgayDi], [GiaVe]) VALUES (5, 0x, CAST(N'2024-04-05' AS Date), CAST(550000.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Ve] ([MaVe], [LoạiVé], [MaChuyenBay], [SoGhe], [SoHieuGhe], [MaKH], [TenKH], [ThoiGianDi], [DiaDiemDi], [DiaDiemDen], [SoThuTu], [GhiChu], [HangMayBay], [GiaVe]) VALUES (1, N'LV001     ', N'CB001     ', 1, N'GH001     ', N'KH001     ', N'Nguyen Van A', CAST(N'2024-03-20T09:00:00.000' AS DateTime), N'HCMC', N'Hanoi', 1, N'On time', N'MB001     ', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[Ve] ([MaVe], [LoạiVé], [MaChuyenBay], [SoGhe], [SoHieuGhe], [MaKH], [TenKH], [ThoiGianDi], [DiaDiemDi], [DiaDiemDen], [SoThuTu], [GhiChu], [HangMayBay], [GiaVe]) VALUES (2, N'LV002     ', N'CB002     ', 2, N'GH002     ', N'KH002     ', N'Le Thi B', CAST(N'2024-03-21T15:00:00.000' AS DateTime), N'Hanoi', N'Da Nang', 2, N'Delayed', N'MB002     ', CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Ve] ([MaVe], [LoạiVé], [MaChuyenBay], [SoGhe], [SoHieuGhe], [MaKH], [TenKH], [ThoiGianDi], [DiaDiemDi], [DiaDiemDen], [SoThuTu], [GhiChu], [HangMayBay], [GiaVe]) VALUES (3, N'LV003     ', N'CB003     ', 3, N'GH003     ', N'KH003     ', N'Tran Van C', CAST(N'2024-03-22T06:00:00.000' AS DateTime), N'Da Nang', N'HCMC', 3, N'On time', N'MB003     ', CAST(1100.00 AS Decimal(18, 2)))
INSERT [dbo].[Ve] ([MaVe], [LoạiVé], [MaChuyenBay], [SoGhe], [SoHieuGhe], [MaKH], [TenKH], [ThoiGianDi], [DiaDiemDi], [DiaDiemDen], [SoThuTu], [GhiChu], [HangMayBay], [GiaVe]) VALUES (4, N'LV004     ', N'CB004     ', 4, N'GH004     ', N'KH004     ', N'Pham Thi D', CAST(N'2024-03-23T12:00:00.000' AS DateTime), N'HCMC', N'Hanoi', 4, N'On time', N'MB004     ', CAST(1000.00 AS Decimal(18, 2)))
INSERT [dbo].[Ve] ([MaVe], [LoạiVé], [MaChuyenBay], [SoGhe], [SoHieuGhe], [MaKH], [TenKH], [ThoiGianDi], [DiaDiemDi], [DiaDiemDen], [SoThuTu], [GhiChu], [HangMayBay], [GiaVe]) VALUES (5, N'LV005     ', N'CB005     ', 5, N'GH005     ', N'KH005     ', N'Hoang Van E', CAST(N'2024-03-24T16:00:00.000' AS DateTime), N'Hanoi', N'Da Nang', 5, N'Delayed', N'MB005     ', CAST(1200.00 AS Decimal(18, 2)))
GO
ALTER TABLE [dbo].[ChuyenBay]  WITH CHECK ADD  CONSTRAINT [FK_ChuyenBay_MayBay] FOREIGN KEY([MaMayBay])
REFERENCES [dbo].[MayBay] ([MaMayBay])
GO
ALTER TABLE [dbo].[ChuyenBay] CHECK CONSTRAINT [FK_ChuyenBay_MayBay]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_ChuyenBay] FOREIGN KEY([MaChuyenBay])
REFERENCES [dbo].[ChuyenBay] ([MaChuyenBay])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_ChuyenBay]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_GheNgoi] FOREIGN KEY([SoHieuGhe])
REFERENCES [dbo].[GheNgoi] ([SoHieuGhe])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_GheNgoi]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_KhuHoi] FOREIGN KEY([MaVe])
REFERENCES [dbo].[KhuHoi] ([MaVe])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_KhuHoi]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [FK_Ve_MotChieu] FOREIGN KEY([MaVe])
REFERENCES [dbo].[MotChieu] ([MaVe])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [FK_Ve_MotChieu]
GO
