CREATE TABLE [dbo].[Accounts] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [UserName]     NVARCHAR (MAX) NOT NULL,
    [FirstName]    NVARCHAR (MAX) NOT NULL,
    [Neighborhood] NVARCHAR (MAX) NOT NULL,
    [Email]        NVARCHAR (MAX) NOT NULL,
    [DateOfBirth]  INT            NOT NULL,
    CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED ([Id] ASC)
);

