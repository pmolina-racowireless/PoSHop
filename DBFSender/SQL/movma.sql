USE [PoSHop]
GO

/****** Object:  Table [dbo].[movma]    Script Date: 6/20/2016 1:41:17 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[movma](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[numero] [int] NOT NULL,
	[doc] [varchar](250) NULL,
	[Almacen] [varchar](250) NULL,
	[Cliente] [int] NULL,
	[fecha] [datetime] NULL,
	[vence] [datetime] NULL,
	[vendedor] [varchar](250) NULL,
	[orden] [int] NULL,
	[conduce] [int] NULL,
	[condicion] [int] NULL,
	[comentario] [varchar](500) NULL,
	[flujo] [decimal](18, 0) NULL,
	[entidad] [varchar](250) NULL,
	[pagares] [decimal](18, 0) NULL,
	[vencepag] [datetime] NULL,
	[inicial] [decimal](18, 0) NULL,
	[fpago] [int] NULL,
	[descper] [decimal](18, 0) NULL,
	[descval] [decimal](18, 0) NULL,
	[itbis] [bit] NULL,
	[itbisval] [decimal](18, 0) NULL,
	[bruto] [decimal](18, 0) NULL,
	[cargo] [decimal](18, 0) NULL,
	[transferid] [bit] NULL,
	[transalm] [bit] NULL,
	[time] [varchar](250) NULL,
	[impreso] [bit] NULL,
	[serial] [bit] NULL,
	[ddoc] [varchar](250) NULL,
	[dnumero] [int] NULL,
	[pgdo] [decimal](18, 0) NULL,
	[otrcargo] [decimal](18, 0) NULL,
	[ncf] [varchar](250) NULL,
	[statussync] [varchar](50) NULL,
 CONSTRAINT [PK_movma_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


