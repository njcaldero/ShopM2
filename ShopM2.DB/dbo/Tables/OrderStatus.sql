CREATE TABLE [dbo].[OrderStatus] (
    [Id]     INT          IDENTITY (1, 1) NOT NULL,
    [Status] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_OrderStatus] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Order Status', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'OrderStatus', @level2type = N'COLUMN', @level2name = N'Status';

