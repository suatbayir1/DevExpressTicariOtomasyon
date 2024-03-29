USE [Otomasyon]
GO
/****** Object:  User [YeniKullanici]    Script Date: 12.01.2019 15:10:50 ******/
CREATE USER [YeniKullanici] FOR LOGIN [YeniKullanici] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[TBL_STOKHAREKETLERI]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_STOKHAREKETLERI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FATURAID] [int] NULL,
	[IRSALIYEID] [int] NULL,
	[STOKKODU] [nvarchar](30) NULL,
	[GCKODU] [nvarchar](1) NULL,
	[MIKTAR] [int] NULL,
	[BIRIMFIYAT] [decimal](18, 2) NULL,
	[KDV] [decimal](8, 2) NULL,
	[TIPI] [nvarchar](20) NULL,
	[SAVEUSER] [int] NULL,
	[SAVEDATE] [datetime] NULL,
	[EDITUSER] [int] NULL,
	[EDITDATE] [datetime] NULL,
 CONSTRAINT [PK_TBL_STOKHAREKETLERI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_STOKLAR]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_STOKLAR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[STOKBARKOD] [nvarchar](30) NULL,
	[STOKKODU] [nvarchar](20) NULL,
	[STOKADI] [nvarchar](50) NULL,
	[STOKBIRIM] [nvarchar](15) NULL,
	[STOKALISFIYAT] [decimal](8, 2) NULL,
	[STOKSATISFIYAT] [decimal](8, 2) NULL,
	[STOKALISKDV] [decimal](8, 2) NULL,
	[STOKSATISKDV] [decimal](8, 2) NULL,
	[STOKGRUPID] [int] NULL,
	[STOKRESIM] [image] NULL,
	[STOKSAVEUSER] [int] NULL,
	[STOKSAVEDATE] [datetime] NULL,
	[STOKEDITUSER] [int] NULL,
	[STOKEDITDATE] [datetime] NULL,
 CONSTRAINT [PK_TBL_STOKLAR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_KALEMLER]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_KALEMLER]
AS
SELECT        dbo.TBL_STOKHAREKETLERI.ID, dbo.TBL_STOKLAR.ID AS STOKID, dbo.TBL_STOKHAREKETLERI.FATURAID, dbo.TBL_STOKHAREKETLERI.IRSALIYEID, dbo.TBL_STOKLAR.STOKKODU, dbo.TBL_STOKLAR.STOKADI, 
                         dbo.TBL_STOKLAR.STOKBARKOD, dbo.TBL_STOKLAR.STOKBIRIM, dbo.TBL_STOKHAREKETLERI.BIRIMFIYAT, dbo.TBL_STOKHAREKETLERI.KDV, dbo.TBL_STOKHAREKETLERI.MIKTAR, 
                         dbo.TBL_STOKHAREKETLERI.MIKTAR * dbo.TBL_STOKHAREKETLERI.BIRIMFIYAT AS TOPLAM
FROM            dbo.TBL_STOKHAREKETLERI LEFT OUTER JOIN
                         dbo.TBL_STOKLAR ON dbo.TBL_STOKHAREKETLERI.STOKKODU = dbo.TBL_STOKLAR.STOKKODU
GO
/****** Object:  Table [dbo].[TBL_FATURALAR]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_FATURALAR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FATURATURU] [nvarchar](25) NULL,
	[FATURASERI] [nvarchar](5) NULL,
	[FATURANO] [nvarchar](15) NULL,
	[IRSALIYEID] [int] NULL,
	[CARIKODU] [nvarchar](30) NULL,
	[TARIHI] [datetime] NULL,
	[ACIKLAMA] [text] NULL,
	[GENELTOPLAM] [decimal](18, 2) NULL,
	[ODEMEYERI] [nvarchar](10) NULL,
	[ODEMEYERIID] [int] NULL,
	[SAVEUSER] [int] NULL,
	[SAVEDATE] [datetime] NULL,
	[EDITUSER] [int] NULL,
	[EDITDATE] [datetime] NULL,
 CONSTRAINT [PK_TBLFATURALAR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_CARILER]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_CARILER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CARIKODU] [nvarchar](30) NULL,
	[CARIADI] [nvarchar](30) NULL,
	[VERGIDAIRESI] [nvarchar](50) NULL,
	[VERGINO] [nvarchar](20) NULL,
	[GRUPID] [int] NULL,
	[ULKE] [nvarchar](30) NULL,
	[SEHIR] [nvarchar](30) NULL,
	[ILCE] [nvarchar](30) NULL,
	[ADRES] [text] NULL,
	[TELEFON1] [nvarchar](16) NULL,
	[TELEFON2] [nvarchar](16) NULL,
	[FAX1] [nvarchar](16) NULL,
	[FAX2] [nvarchar](16) NULL,
	[WEBADRES] [nvarchar](150) NULL,
	[MAILINFO] [nvarchar](250) NULL,
	[YETKILI1] [nvarchar](50) NULL,
	[YETKILI2] [nvarchar](50) NULL,
	[YETKILIMAIL1] [nvarchar](100) NULL,
	[YETKILIMAIL2] [nvarchar](100) NULL,
	[SAVEDATE] [datetime] NULL,
	[SAVEUSER] [int] NULL,
	[EDITDATE] [datetime] NULL,
	[EDITUSER] [int] NULL,
 CONSTRAINT [PK_TBL_CARILER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_FATURALAR]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[VW_FATURALAR]
AS
SELECT        dbo.TBL_FATURALAR.CARIKODU, dbo.TBL_CARILER.CARIADI, dbo.TBL_CARILER.VERGIDAIRESI, dbo.TBL_CARILER.VERGINO, dbo.TBL_CARILER.SEHIR, dbo.TBL_CARILER.ILCE, dbo.TBL_CARILER.ADRES, 
                         dbo.TBL_FATURALAR.FATURANO, dbo.TBL_FATURALAR.TARIHI, dbo.TBL_FATURALAR.ACIKLAMA, dbo.TBL_FATURALAR.GENELTOPLAM, dbo.VW_KALEMLER.STOKKODU, dbo.VW_KALEMLER.STOKADI, 
                         dbo.VW_KALEMLER.STOKBIRIM, dbo.VW_KALEMLER.BIRIMFIYAT, dbo.VW_KALEMLER.KDV, dbo.VW_KALEMLER.STOKBARKOD, dbo.VW_KALEMLER.MIKTAR, dbo.VW_KALEMLER.TOPLAM
FROM            dbo.VW_KALEMLER INNER JOIN
                         dbo.TBL_FATURALAR ON dbo.VW_KALEMLER.FATURAID = dbo.TBL_FATURALAR.ID LEFT OUTER JOIN
                         dbo.TBL_CARILER ON dbo.TBL_FATURALAR.CARIKODU = dbo.TBL_CARILER.CARIKODU

GO
/****** Object:  Table [dbo].[TBL_KASALAR]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_KASALAR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KASAKODU] [nvarchar](30) NULL,
	[KASAADI] [nvarchar](30) NULL,
	[ACIKLAMA] [text] NULL,
	[SAVEDATE] [datetime] NULL,
	[SAVEUSER] [int] NULL,
	[EDITDATE] [datetime] NULL,
	[EDITUSER] [int] NULL,
 CONSTRAINT [PK_TBL_KASALAR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_KASAHAREKETLERI]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_KASAHAREKETLERI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KASAID] [int] NULL,
	[CARIID] [int] NULL,
	[BELGENO] [nvarchar](50) NULL,
	[EVRAKID] [int] NULL,
	[EVRAKTURU] [nvarchar](30) NULL,
	[GCKODU] [nvarchar](1) NULL,
	[TARIH] [datetime] NULL,
	[TUTAR] [decimal](18, 2) NULL,
	[ACIKLAMA] [text] NULL,
	[SAVEDATE] [datetime] NULL,
	[SAVEUSER] [int] NULL,
	[EDITDATE] [datetime] NULL,
	[EDITUSER] [int] NULL,
 CONSTRAINT [PK_TBL_KASAHAREKETLERI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_KASAHAREKETLERI]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_KASAHAREKETLERI]
AS
SELECT        dbo.TBL_KASAHAREKETLERI.ID, dbo.TBL_KASAHAREKETLERI.KASAID, dbo.TBL_KASAHAREKETLERI.CARIID, dbo.TBL_KASALAR.KASAKODU, dbo.TBL_KASALAR.KASAADI, dbo.TBL_CARILER.CARIKODU, 
                         dbo.TBL_CARILER.CARIADI, dbo.TBL_KASAHAREKETLERI.BELGENO, dbo.TBL_KASAHAREKETLERI.EVRAKID, dbo.TBL_KASAHAREKETLERI.EVRAKTURU, dbo.TBL_KASAHAREKETLERI.TARIH, 
                         (CASE WHEN dbo.TBL_KASAHAREKETLERI.GCKODU = 'G' THEN dbo.TBL_KASAHAREKETLERI.TUTAR ELSE 0 END) AS GIRIS, 
                         (CASE WHEN dbo.TBL_KASAHAREKETLERI.GCKODU = 'C' THEN dbo.TBL_KASAHAREKETLERI.TUTAR ELSE 0 END) AS CIKIS, dbo.TBL_KASAHAREKETLERI.ACIKLAMA
FROM            dbo.TBL_KASAHAREKETLERI LEFT OUTER JOIN
                         dbo.TBL_KASALAR ON dbo.TBL_KASAHAREKETLERI.KASAID = dbo.TBL_KASALAR.ID LEFT OUTER JOIN
                         dbo.TBL_CARILER ON dbo.TBL_KASAHAREKETLERI.CARIID = dbo.TBL_CARILER.ID
GO
/****** Object:  View [dbo].[VW_KASADURUM]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_KASADURUM]
AS
SELECT        KASAID, SUM(CASE WHEN GCKODU = 'G' THEN TUTAR ELSE 0 END) AS GIRIS, KASAID AS Expr1, SUM(CASE WHEN GCKODU = 'C' THEN TUTAR ELSE 0 END) AS CIKIS, 
                         SUM(CASE WHEN GCKODU = 'G' THEN TUTAR ELSE 0 END) - SUM(CASE WHEN GCKODU = 'C' THEN TUTAR ELSE 0 END) AS BAKIYE
FROM            dbo.TBL_KASAHAREKETLERI
GROUP BY KASAID
GO
/****** Object:  View [dbo].[VW_KASALISTESI]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_KASALISTESI]
AS
SELECT        dbo.TBL_KASALAR.ID, dbo.TBL_KASALAR.KASAKODU, dbo.TBL_KASALAR.KASAADI, dbo.TBL_KASALAR.ACIKLAMA, (CASE WHEN dbo.VW_KASADURUM.GIRIS IS NULL THEN 0 ELSE dbo.VW_KASADURUM.GIRIS END) AS GIRIS, 
                         (CASE WHEN dbo.VW_KASADURUM.CIKIS IS NULL THEN 0 ELSE dbo.VW_KASADURUM.CIKIS END) AS CIKIS, (CASE WHEN dbo.VW_KASADURUM.BAKIYE IS NULL THEN 0 ELSE dbo.VW_KASADURUM.BAKIYE END) 
                         AS BAKIYE
FROM            dbo.TBL_KASALAR LEFT OUTER JOIN
                         dbo.VW_KASADURUM ON dbo.TBL_KASALAR.ID = dbo.VW_KASADURUM.KASAID
GO
/****** Object:  Table [dbo].[TBL_BANKALAR]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_BANKALAR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HESAPNO] [nvarchar](30) NULL,
	[IBAN] [nvarchar](50) NULL,
	[BANKAADI] [nvarchar](30) NULL,
	[HESAPADI] [nvarchar](30) NULL,
	[SUBE] [nvarchar](30) NULL,
	[TEL] [nvarchar](16) NULL,
	[ADRES] [text] NULL,
	[TEMSILCI] [nvarchar](50) NULL,
	[TEMSILCIEMAIL] [nvarchar](150) NULL,
	[SAVEDATE] [datetime] NULL,
	[SAVEUSER] [int] NULL,
	[EDITDATE] [datetime] NULL,
	[EDITUSER] [int] NULL,
 CONSTRAINT [PK_TBL_BANKALAR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_BANKAHAREKETLERI]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_BANKAHAREKETLERI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BANKAID] [int] NULL,
	[CARIID] [int] NULL,
	[BELGENO] [nvarchar](30) NULL,
	[TARIH] [datetime] NULL,
	[EVRAKTURU] [nvarchar](30) NULL,
	[EVRAKID] [int] NULL,
	[GCKODU] [nvarchar](1) NULL,
	[TUTAR] [decimal](18, 2) NULL,
	[ACIKLAMA] [text] NULL,
	[SAVEDATE] [datetime] NULL,
	[SAVEUSER] [int] NULL,
	[EDITDATE] [datetime] NULL,
	[EDITUSER] [int] NULL,
 CONSTRAINT [PK_TBL_BANKAHAREKETLERI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_BANKAHAREKETLERI]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_BANKAHAREKETLERI]
AS
SELECT        dbo.TBL_BANKAHAREKETLERI.ID, dbo.TBL_BANKAHAREKETLERI.BANKAID, dbo.TBL_BANKAHAREKETLERI.CARIID, dbo.TBL_BANKAHAREKETLERI.BELGENO, dbo.TBL_BANKAHAREKETLERI.TARIH, 
                         dbo.TBL_BANKAHAREKETLERI.EVRAKTURU, dbo.TBL_BANKAHAREKETLERI.EVRAKID, dbo.TBL_BANKAHAREKETLERI.TUTAR, dbo.TBL_BANKAHAREKETLERI.ACIKLAMA, 
                         (CASE WHEN dbo.TBL_BANKAHAREKETLERI.GCKODU = 'G' THEN dbo.TBL_BANKAHAREKETLERI.TUTAR ELSE 0 END) AS GIRIS, 
                         (CASE WHEN dbo.TBL_BANKAHAREKETLERI.GCKODU = 'C' THEN dbo.TBL_BANKAHAREKETLERI.TUTAR ELSE 0 END) AS CIKIS, dbo.TBL_BANKALAR.HESAPNO, dbo.TBL_BANKALAR.HESAPADI
FROM            dbo.TBL_BANKAHAREKETLERI LEFT OUTER JOIN
                         dbo.TBL_BANKALAR ON dbo.TBL_BANKAHAREKETLERI.BANKAID = dbo.TBL_BANKALAR.ID
GO
/****** Object:  View [dbo].[VW_BANKADURUM]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_BANKADURUM]
AS
SELECT        dbo.TBL_BANKALAR.ID, SUM(CASE WHEN dbo.TBL_BANKAHAREKETLERI.GCKODU = 'G' THEN dbo.TBL_BANKAHAREKETLERI.TUTAR ELSE 0 END) AS GIRIS, 
                         SUM(CASE WHEN dbo.TBL_BANKAHAREKETLERI.GCKODU = 'C' THEN dbo.TBL_BANKAHAREKETLERI.TUTAR ELSE 0 END) AS CIKIS, 
                         SUM(CASE WHEN dbo.TBL_BANKAHAREKETLERI.GCKODU = 'G' THEN dbo.TBL_BANKAHAREKETLERI.TUTAR ELSE 0 END) 
                         - SUM(CASE WHEN dbo.TBL_BANKAHAREKETLERI.GCKODU = 'C' THEN dbo.TBL_BANKAHAREKETLERI.TUTAR ELSE 0 END) AS BAKIYE
FROM            dbo.TBL_BANKAHAREKETLERI LEFT OUTER JOIN
                         dbo.TBL_BANKALAR ON dbo.TBL_BANKAHAREKETLERI.BANKAID = dbo.TBL_BANKALAR.ID
GROUP BY dbo.TBL_BANKALAR.ID
GO
/****** Object:  View [dbo].[VW_BANKALISTESI]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_BANKALISTESI]
AS
SELECT        dbo.TBL_BANKALAR.ID, dbo.TBL_BANKALAR.HESAPNO, dbo.TBL_BANKALAR.IBAN, dbo.TBL_BANKALAR.BANKAADI, dbo.TBL_BANKALAR.HESAPADI, dbo.VW_BANKADURUM.GIRIS, dbo.VW_BANKADURUM.CIKIS, 
                         dbo.VW_BANKADURUM.BAKIYE
FROM            dbo.TBL_BANKALAR LEFT OUTER JOIN
                         dbo.VW_BANKADURUM ON dbo.TBL_BANKALAR.ID = dbo.VW_BANKADURUM.ID
GO
/****** Object:  Table [dbo].[TBL_BORDROLAR]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_BORDROLAR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NUMARA] [nvarchar](30) NULL,
	[CARIID] [int] NULL,
	[TARIH] [datetime] NULL,
	[ACIKLAMA] [text] NULL,
	[SAVEUSER] [int] NULL,
	[SAVEDATE] [datetime] NULL,
	[EDITUSER] [int] NULL,
	[EDITDATE] [datetime] NULL,
 CONSTRAINT [PK_TBL_BORDROLAR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_CARIGRUPLARI]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_CARIGRUPLARI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GRUPADI] [nvarchar](30) NULL,
	[GRUPKODU] [nvarchar](30) NULL,
	[GRUPSAVEDATE] [datetime] NULL,
	[GRUPSAVEUSER] [int] NULL,
	[GRUPEDITDATE] [datetime] NULL,
	[GRUPEDITUSER] [int] NULL,
 CONSTRAINT [PK_TBL_CARIGRUPLARI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_CARIHAREKETLERI]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_CARIHAREKETLERI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CARIID] [int] NULL,
	[EVRAKTURU] [nvarchar](30) NULL,
	[EVRAKID] [int] NULL,
	[BORC] [decimal](18, 2) NULL,
	[ALACAK] [decimal](18, 2) NULL,
	[ACIKLAMA] [text] NULL,
	[TARIH] [datetime] NULL,
	[TIPI] [nvarchar](25) NULL,
	[SAVEDATE] [datetime] NULL,
	[SAVEUSER] [int] NULL,
	[EDITDATE] [datetime] NULL,
	[EDITUSER] [int] NULL,
 CONSTRAINT [PK_TBL_CARIHAREKETLERI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_CEKLER]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_CEKLER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BELGENO] [nvarchar](30) NULL,
	[CEKNO] [nvarchar](50) NULL,
	[ASILBORCLU] [nvarchar](50) NULL,
	[TIPI] [nvarchar](50) NULL,
	[ALINANCARIID] [int] NULL,
	[VERILENCARIID] [int] NULL,
	[ACKODU] [nvarchar](1) NULL,
	[VADETARIHI] [datetime] NULL,
	[BANKASI] [nvarchar](50) NULL,
	[SUBE] [nvarchar](50) NULL,
	[HESAPNO] [nvarchar](50) NULL,
	[TUTAR] [decimal](18, 2) NULL,
	[ACIKLAMA] [text] NULL,
	[VERILENBANKA_TARIHI] [datetime] NULL,
	[VERILENBANKA_BELGENO] [nvarchar](30) NULL,
	[VERILENCARI_TARIHI] [datetime] NULL,
	[VERILENCARI_BELGENO] [nvarchar](30) NULL,
	[VERILENBANKAID] [int] NULL,
	[DURUMU] [nvarchar](50) NULL,
	[TAHSIL] [nvarchar](50) NULL,
	[BORDROID] [int] NULL,
	[TARIH] [datetime] NULL,
	[SAVEUSER] [int] NULL,
	[SAVEDATE] [datetime] NULL,
	[EDITUSER] [int] NULL,
	[EDITDATE] [datetime] NULL,
 CONSTRAINT [PK_TBL_CEKLER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_IRSALIYELER]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_IRSALIYELER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IRSALIYESERI] [nvarchar](5) NULL,
	[IRSALIYENO] [nvarchar](15) NULL,
	[FATURAID] [int] NULL,
	[CARIKODU] [nvarchar](30) NULL,
	[TARIHI] [datetime] NULL,
	[ACIKLAMA] [text] NULL,
	[SAVEUSER] [int] NULL,
	[SAVEDATE] [datetime] NULL,
	[EDITUSER] [int] NULL,
	[EDITDATE] [datetime] NULL,
 CONSTRAINT [PK_TBLIRSALIYELER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_KULLANICILAR]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_KULLANICILAR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KULLANICI] [nvarchar](50) NULL,
	[SIFRE] [nvarchar](50) NULL,
	[ISIM] [nvarchar](50) NULL,
	[SOYISIM] [nvarchar](50) NULL,
	[AKTIF] [bit] NULL,
	[KODU] [nvarchar](50) NULL,
	[SAVEDATE] [datetime] NULL,
	[EDITDATE] [datetime] NULL,
	[LASTLOGIN] [datetime] NULL,
 CONSTRAINT [PK_TBL_KULLANICILAR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_TBL_KULLANICILAR] UNIQUE NONCLUSTERED 
(
	[KULLANICI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBL_STOKGRUPLARI]    Script Date: 12.01.2019 15:10:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_STOKGRUPLARI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GRUPADI] [nvarchar](30) NULL,
	[GRUPKODU] [nvarchar](30) NULL,
	[GRUPSAVEUSER] [int] NULL,
	[GRUPSAVEDATE] [datetime] NULL,
	[GRUPEDITUSER] [int] NULL,
	[GRUPEDITDATE] [datetime] NULL,
 CONSTRAINT [PK_TBL_STOKGRUPLARI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TBL_STOKHAREKETLERI] ADD  CONSTRAINT [DF_TBL_STOKHAREKETLERI_SAVEUSER]  DEFAULT ((-1)) FOR [SAVEUSER]
GO
ALTER TABLE [dbo].[TBL_STOKHAREKETLERI] ADD  CONSTRAINT [DF_TBL_STOKHAREKETLERI_SAVEDATE]  DEFAULT (getdate()) FOR [SAVEDATE]
GO
ALTER TABLE [dbo].[TBL_STOKHAREKETLERI] ADD  CONSTRAINT [DF_TBL_STOKHAREKETLERI_EDITUSER]  DEFAULT ((-1)) FOR [EDITUSER]
GO
ALTER TABLE [dbo].[TBL_STOKHAREKETLERI] ADD  CONSTRAINT [DF_TBL_STOKHAREKETLERI_EDITDATE]  DEFAULT (getdate()) FOR [EDITDATE]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[17] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TBL_BANKAHAREKETLERI"
            Begin Extent = 
               Top = 3
               Left = 353
               Bottom = 133
               Right = 523
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "TBL_BANKALAR"
            Begin Extent = 
               Top = 9
               Left = 49
               Bottom = 139
               Right = 222
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_BANKADURUM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_BANKADURUM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[15] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -288
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TBL_BANKAHAREKETLERI"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 7
         End
         Begin Table = "TBL_BANKALAR"
            Begin Extent = 
               Top = 17
               Left = 332
               Bottom = 147
               Right = 505
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 12
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_BANKAHAREKETLERI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_BANKAHAREKETLERI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TBL_BANKALAR"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 200
               Right = 211
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "VW_BANKADURUM"
            Begin Extent = 
               Top = 15
               Left = 342
               Bottom = 175
               Right = 512
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_BANKALISTESI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_BANKALISTESI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[14] 2[18] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1[50] 4[25] 3) )"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1[38] 3) )"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3) )"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TBL_CARILER"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 248
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 14
         End
         Begin Table = "TBL_FATURALAR"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 244
               Right = 418
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "VW_KALEMLER"
            Begin Extent = 
               Top = 21
               Left = 521
               Bottom = 238
               Right = 691
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 20
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      En' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_FATURALAR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'd
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_FATURALAR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_FATURALAR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[42] 4[19] 2[22] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TBL_STOKHAREKETLERI"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 125
               Right = 198
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TBL_STOKLAR"
            Begin Extent = 
               Top = 6
               Left = 236
               Bottom = 125
               Right = 409
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 13
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_KALEMLER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_KALEMLER'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TBL_KASAHAREKETLERI"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 201
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_KASADURUM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_KASADURUM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1[50] 2[25] 3) )"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 2
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TBL_KASAHAREKETLERI"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 10
         End
         Begin Table = "TBL_KASALAR"
            Begin Extent = 
               Top = 102
               Left = 279
               Bottom = 233
               Right = 449
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TBL_CARILER"
            Begin Extent = 
               Top = 25
               Left = 522
               Bottom = 155
               Right = 692
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 14
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      PaneHidden = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_KASAHAREKETLERI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_KASAHAREKETLERI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[32] 4[15] 2[25] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TBL_KASALAR"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "VW_KASADURUM"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_KASALISTESI'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_KASALISTESI'
GO
