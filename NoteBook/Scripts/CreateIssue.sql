USE [DayPlanner]
GO

/****** Object:  Table [dbo].[Issue]    Script Date: 29.06.2021 21:07:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Issue](
	[IssueId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[DateStart] [datetime] NULL,
	[DateEnd] [datetime] NULL,
	[Note] [nvarchar](max) NULL,
	[TypeId] [int] NULL,
	[RepetitionId] [int] NULL,
	[StatusId] [int] NULL,
 CONSTRAINT [PK_Issue] PRIMARY KEY CLUSTERED 
(
	[IssueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Issue]  WITH CHECK ADD  CONSTRAINT [FK_Issue_IssueStatus] FOREIGN KEY([StatusId])
REFERENCES [dbo].[IssueStatus] ([StatusId])
ON UPDATE CASCADE
ON DELETE SET NULL
GO

ALTER TABLE [dbo].[Issue] CHECK CONSTRAINT [FK_Issue_IssueStatus]
GO

ALTER TABLE [dbo].[Issue]  WITH CHECK ADD  CONSTRAINT [FK_Issue_IssueType] FOREIGN KEY([TypeId])
REFERENCES [dbo].[IssueType] ([TypeId])
ON UPDATE CASCADE
ON DELETE SET NULL
GO

ALTER TABLE [dbo].[Issue] CHECK CONSTRAINT [FK_Issue_IssueType]
GO

ALTER TABLE [dbo].[Issue]  WITH CHECK ADD  CONSTRAINT [FK_Issue_RepetitionRate] FOREIGN KEY([RepetitionId])
REFERENCES [dbo].[RepetitionRate] ([RepetitionId])
ON UPDATE CASCADE
ON DELETE SET NULL
GO

ALTER TABLE [dbo].[Issue] CHECK CONSTRAINT [FK_Issue_RepetitionRate]
GO

