CREATE TABLE [dbo].[Livraison] (
    [Id_Livraison] INT          IDENTITY (1, 1) NOT NULL,
    [Reference]    VARCHAR (50) NOT NULL,
    [Lieu]         VARCHAR (50) NOT NULL,
    [CreatedAt]    DATE         CONSTRAINT [DF_Livraison_CreatedAt] DEFAULT (getdate()) NOT NULL,
    [ClientId]     INT          NULL,
    CONSTRAINT [PK_Livraison] PRIMARY KEY CLUSTERED ([Id_Livraison] ASC),
    CONSTRAINT [FK_Livraison_Client] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Client] ([Id])
);

