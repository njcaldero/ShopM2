CREATE TABLE [dbo].[TransactionLog] (
    [Id]        INT      IDENTITY (1, 1) NOT NULL,
    [IdOrder]   INT      NOT NULL,
    [IdRequest] INT      NOT NULL,
    [Message]   INT      NOT NULL,
    [DateTime]  DATETIME NOT NULL,
    CONSTRAINT [PK_TransactionLog] PRIMARY KEY CLUSTERED ([Id] ASC)
);

