USE [PoSHop]
GO

/****** Object:  Table [dbo].[movde]    Script Date: 6/20/2016 1:40:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[movde](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[linea] [int] NULL,
	[buscar] [varchar](250) NULL,
	[doc] [varchar](250) NULL,
	[numero] [int] NULL,
	[almacen] [varchar](250) NULL,
	[merc] [int] NULL,
	[cantidad] [decimal](18, 0) NULL,
	[frag] [int] NULL,
	[precio] [decimal](18, 0) NULL,
	[costo] [decimal](18, 0) NULL,
	[total] [decimal](18, 0) NULL,
	[fecha] [datetime] NULL,
	[flujo] [decimal](18, 0) NULL,
	[unidad] [varchar](250) NULL,
	[serial] [varchar](250) NULL,
	[color] [varchar](250) NULL,
	[statussync] [varchar](50) NULL,
 CONSTRAINT [PK_movde] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


