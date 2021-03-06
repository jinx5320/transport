SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CATG]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CATG](
	[NAME] [varchar](20) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CREDITS]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CREDITS](
	[CREDITNO] [numeric](16, 0) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MESSAGES]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MESSAGES](
	[FROMID] [varchar](6) NULL,
	[TOID] [varchar](6) NULL,
	[SUBJECT] [varchar](20) NULL,
	[MSG] [varchar](500) NULL,
	[SDATE] [varchar](30) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PORDER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PORDER](
	[POID] [varchar](6) NULL,
	[SID] [varchar](6) NULL,
	[PID] [varchar](6) NULL,
	[QTY] [numeric](7, 0) NULL,
	[DDATE] [datetime] NULL,
	[BID] [varchar](6) NULL,
	[RQTY] [numeric](7, 0) NULL,
	[CDATE] [datetime] NULL,
	[TOTAL] [numeric](10, 2) NULL,
	[STATUS] [numeric](1, 0) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PRODUCT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PRODUCT](
	[PID] [varchar](6) NULL,
	[PNAME] [varchar](30) NULL,
	[PRICE] [numeric](9, 2) NULL,
	[CATEGORY] [varchar](20) NULL,
	[SID] [varchar](6) NULL,
	[CNAME] [varchar](30) NULL,
	[TAX] [numeric](9, 2) NULL,
	[DOM] [datetime] NULL,
	[BATCHNO] [numeric](5, 0) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SUPPLIER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SUPPLIER](
	[SID] [varchar](6) NOT NULL,
	[SPASSWORD] [varchar](20) NULL,
	[CNAME] [varchar](30) NULL,
	[ADDRESS] [varchar](100) NULL,
	[PIONEER] [varchar](20) NULL,
	[EMAIL] [varchar](30) NULL,
	[WEBSITE] [varchar](30) NULL,
	[DOE] [datetime] NULL,
	[TURNOVER] [numeric](10, 2) NULL,
	[RDATE] [datetime] NULL,
	[CREDITNO] [numeric](16, 0) NULL,
	[STATUS] [numeric](2, 0) NULL,
	[VALDATE] [datetime] NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ADMIN]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ADMIN](
	[USERNAME] [varchar](20) NULL,
	[PASSWORD] [varchar](20) NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BUYER]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BUYER](
	[BID] [varchar](6) NOT NULL,
	[BPASSWORD] [varchar](20) NULL,
	[CNAME] [varchar](30) NULL,
	[ADDRESS] [varchar](100) NULL,
	[PIONEER] [varchar](20) NULL,
	[EMAIL] [varchar](20) NULL,
	[WEBSITE] [varchar](30) NULL,
	[DOE] [datetime] NULL,
	[TURNOVER] [numeric](10, 2) NULL,
	[STATUS] [numeric](1, 0) NULL,
	[RDATE] [datetime] NULL,
	[DOLT] [datetime] NULL
) ON [PRIMARY]
END
