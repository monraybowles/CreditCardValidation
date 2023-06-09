USE [CreditCard]
GO
/****** Object:  Table [dbo].[Card]    Script Date: 5/15/2023 2:33:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Card](
	[CreditCardID] [uniqueidentifier] NOT NULL,
	[CardType] [nvarchar](50) NOT NULL,
	[CardHolder] [nvarchar](70) NOT NULL,
	[CardNumber] [nvarchar](25) NOT NULL,
	[ExpMonth] [tinyint] NOT NULL,
	[ExpYear] [smallint] NOT NULL,
	[CVV] [smallint] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CardName]    Script Date: 5/15/2023 2:33:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CardName](
	[TypeID] [uniqueidentifier] NOT NULL,
	[CardType] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CardName] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Card] ([CreditCardID], [CardType], [CardHolder], [CardNumber], [ExpMonth], [ExpYear], [CVV], [ModifiedDate]) VALUES (N'750e69c3-7613-42e8-87c9-cd812ada366a', N'AMEX', N'MR M Bowles', N'378282246310005', 12, 2023, 234, CAST(N'2023-05-15T12:42:17.683' AS DateTime))
GO
INSERT [dbo].[CardName] ([TypeID], [CardType]) VALUES (N'8705282a-15fd-489a-995b-21ddef413511', N'MasterCard')
INSERT [dbo].[CardName] ([TypeID], [CardType]) VALUES (N'5562f172-6877-46bc-a99b-813ab60abc44', N'VISA')
INSERT [dbo].[CardName] ([TypeID], [CardType]) VALUES (N'f2fe8167-0abe-4237-a273-b66bd75909c2', N'AMEX')
INSERT [dbo].[CardName] ([TypeID], [CardType]) VALUES (N'ed63a24b-ed50-4d44-a3c4-be4677606fec', N'Discover')
GO
ALTER TABLE [dbo].[Card] ADD  CONSTRAINT [DF_CreditCard_ModifiedDate]  DEFAULT (getdate()) FOR [ModifiedDate]
GO
