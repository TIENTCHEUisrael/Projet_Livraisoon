CREATE TABLE [dbo].[Client] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [Nom]   VARCHAR (50) NOT NULL,
    [Phone] INT          NOT NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED ([Id] ASC)
);

