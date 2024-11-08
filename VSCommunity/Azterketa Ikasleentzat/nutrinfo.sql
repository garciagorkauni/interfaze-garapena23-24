USE [Nutrinfo]
GO
/****** Object:  Table [dbo].[Berria]    Script Date: 03/01/2024 18:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Berria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Titularra] [nvarchar](max) NULL,
	[Deskripzioa] [nvarchar](max) NULL,
	[Nabarmena] [bit] NULL,
	[Autorea] [nvarchar](50) NULL,
	[Data] [datetime] NULL,
 CONSTRAINT [PK_Berria] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Elikagaia]    Script Date: 03/01/2024 18:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Elikagaia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Izena] [nvarchar](50) NULL,
	[Marka] [nvarchar](50) NULL,
	[Deskripzioa] [nvarchar](max) NULL,
	[Irudia] [nvarchar](50) NULL,
 CONSTRAINT [PK_Elikagaia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Informazioa]    Script Date: 03/01/2024 18:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Informazioa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OsagaiaId] [int] NULL,
	[Urtea] [int] NULL,
	[Kantitatea] [int] NULL,
	[ElikagaiaId] [int] NULL,
 CONSTRAINT [PK_Informazioa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Osagaia]    Script Date: 03/01/2024 18:36:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Osagaia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Izena] [nvarchar](50) NULL,
	[Unitatea] [nvarchar](50) NULL,
	[Konparaketa] [int] NULL,
 CONSTRAINT [PK_Osagaia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Berria] ON 

INSERT [dbo].[Berria] ([Id], [Titularra], [Deskripzioa], [Nabarmena], [Autorea], [Data]) VALUES (1, N'Lehenengo proba', N'Lehenengo proba egiteko berria', 1, N'izaskun@uni.eus', CAST(N'2024-01-03T18:12:12.797' AS DateTime))
SET IDENTITY_INSERT [dbo].[Berria] OFF
GO
SET IDENTITY_INSERT [dbo].[Elikagaia] ON 

INSERT [dbo].[Elikagaia] ([Id], [Izena], [Marka], [Deskripzioa], [Irudia]) VALUES (1, N'Moldeko ogia', N'Silueta', N'
Kanpotik eta barrutik zaintzea errazagoa da Siluetarekin, zure egunerokotasunerako aliatu ezin hobea baita. Egin apustu Siluetaren alde, eta utzi harritzen zure digestio-zirkulazioa erregulatzen lagunduko duten osagaien hautaketa bikainarekin.

', N'ogia.jpg')
INSERT [dbo].[Elikagaia] ([Id], [Izena], [Marka], [Deskripzioa], [Irudia]) VALUES (2, N'Tomatea', N'Orlando', N'Sibarita, gourmet, sofistikatua eta dotorea.
Foodientzat. Barietate honek tomate eta oliba-olio kontzentrazio handiagoa du, eta, horrela, zaporea indartzen duen usaimena eta lodiera lortzen da. Benetako gozamena da gastronomia zaleentzat.', N'tomatea.jpg')
INSERT [dbo].[Elikagaia] ([Id], [Izena], [Marka], [Deskripzioa], [Irudia]) VALUES (3, N'Esnea', N'Euskal Herria', N'Esnea ugaztunen ugatz-guruinen zelulek sortutako jariakin nutritibo bat da. Ugaztunen artean monotremek ere jariatzen dute.

Bere funtzio nagusia kumeak elikatzea da, beste elikagai batzuk digeritzeko gai izan arte, euren traktu gastrointestinala patogenoetatik babeztuz.', N'esnea.jpg')
SET IDENTITY_INSERT [dbo].[Elikagaia] OFF
GO
SET IDENTITY_INSERT [dbo].[Informazioa] ON 

INSERT [dbo].[Informazioa] ([Id], [OsagaiaId], [Urtea], [Kantitatea], [ElikagaiaId]) VALUES (1, 2, 2022, 11, 1)
INSERT [dbo].[Informazioa] ([Id], [OsagaiaId], [Urtea], [Kantitatea], [ElikagaiaId]) VALUES (2, 1, 2022, 100, 1)
INSERT [dbo].[Informazioa] ([Id], [OsagaiaId], [Urtea], [Kantitatea], [ElikagaiaId]) VALUES (3, 3, 2021, 60, 1)
INSERT [dbo].[Informazioa] ([Id], [OsagaiaId], [Urtea], [Kantitatea], [ElikagaiaId]) VALUES (4, 4, 2023, 12, 1)
INSERT [dbo].[Informazioa] ([Id], [OsagaiaId], [Urtea], [Kantitatea], [ElikagaiaId]) VALUES (5, 5, 2023, 20, 1)
INSERT [dbo].[Informazioa] ([Id], [OsagaiaId], [Urtea], [Kantitatea], [ElikagaiaId]) VALUES (6, 6, 2022, 1, 1)
INSERT [dbo].[Informazioa] ([Id], [OsagaiaId], [Urtea], [Kantitatea], [ElikagaiaId]) VALUES (7, 1, 2020, 90, 2)
INSERT [dbo].[Informazioa] ([Id], [OsagaiaId], [Urtea], [Kantitatea], [ElikagaiaId]) VALUES (8, 2, 2020, 5, 2)
INSERT [dbo].[Informazioa] ([Id], [OsagaiaId], [Urtea], [Kantitatea], [ElikagaiaId]) VALUES (9, 3, 2020, 50, 2)
INSERT [dbo].[Informazioa] ([Id], [OsagaiaId], [Urtea], [Kantitatea], [ElikagaiaId]) VALUES (10, 4, 2020, 15, 2)
INSERT [dbo].[Informazioa] ([Id], [OsagaiaId], [Urtea], [Kantitatea], [ElikagaiaId]) VALUES (11, 5, 2020, 10, 2)
INSERT [dbo].[Informazioa] ([Id], [OsagaiaId], [Urtea], [Kantitatea], [ElikagaiaId]) VALUES (12, 6, 2020, 6, 2)
SET IDENTITY_INSERT [dbo].[Informazioa] OFF
GO
SET IDENTITY_INSERT [dbo].[Osagaia] ON 

INSERT [dbo].[Osagaia] ([Id], [Izena], [Unitatea], [Konparaketa]) VALUES (1, N'Energia', N'Kaloria', 200)
INSERT [dbo].[Osagaia] ([Id], [Izena], [Unitatea], [Konparaketa]) VALUES (2, N'Koipea', N'gramo', 10)
INSERT [dbo].[Osagaia] ([Id], [Izena], [Unitatea], [Konparaketa]) VALUES (3, N'Karbohidratoak', N'gramo', 30)
INSERT [dbo].[Osagaia] ([Id], [Izena], [Unitatea], [Konparaketa]) VALUES (4, N'Azukreak', N'gramo', 9)
INSERT [dbo].[Osagaia] ([Id], [Izena], [Unitatea], [Konparaketa]) VALUES (5, N'Proteinak', N'gramo', 26)
INSERT [dbo].[Osagaia] ([Id], [Izena], [Unitatea], [Konparaketa]) VALUES (6, N'Gatza', N'gramo', 3)
SET IDENTITY_INSERT [dbo].[Osagaia] OFF
GO
SET IDENTITY_INSERT [dbo].[Berria] ON 

INSERT [dbo].[Berria] ([Id], [Titularra], [Deskripzioa], [Nabarmena], [Autorea], [Data]) VALUES (1, N'Lehenengo proba', N'Lehenengo proba egiteko berria', 1, N'izaskun@uni.eus', CAST(N'2024-01-03T18:12:12.797' AS DateTime))
SET IDENTITY_INSERT [dbo].[Berria] OFF
GO
