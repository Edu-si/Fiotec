USE [Bd_Fiotec]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 03/04/2023 08:28:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 03/04/2023 08:28:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [uniqueidentifier] NOT NULL,
	[ClienteId] [uniqueidentifier] NOT NULL,
	[Nome] [varchar](200) NOT NULL,
	[Cpf] [varchar](50) NOT NULL,
	[DataAplicacao] [datetime] NOT NULL,
	[RelatorioId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Relatorio]    Script Date: 03/04/2023 08:28:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Relatorio](
	[Id] [uniqueidentifier] NOT NULL,
	[ClienteId] [uniqueidentifier] NOT NULL,
	[NomeSolicitante] [varchar](200) NOT NULL,
	[Descricao] [varchar](200) NOT NULL,
	[DataAplicacao] [datetime2](7) NOT NULL,
	[DataSolicitacao] [datetime2](7) NOT NULL,
	[QuantidadeTotal] [int] NOT NULL,
 CONSTRAINT [PK_Relatorio] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Relatorio_RelatorioId] FOREIGN KEY([RelatorioId])
REFERENCES [dbo].[Relatorio] ([Id])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Relatorio_RelatorioId]
GO
