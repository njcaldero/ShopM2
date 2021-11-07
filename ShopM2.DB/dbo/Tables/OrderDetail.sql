CREATE TABLE [dbo].[OrderDetail] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [IdProduct]  INT NOT NULL,
    [Price]      INT NOT NULL,
    [Cantidad]   INT NOT NULL,
    [TotalPrice] INT NOT NULL,
    CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'id primary key of the table', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'OrderDetail', @level2type = N'COLUMN', @level2name = N'Id';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'id foreign key of the table products', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'OrderDetail', @level2type = N'COLUMN', @level2name = N'IdProduct';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Product price at the time of purchase', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'OrderDetail', @level2type = N'COLUMN', @level2name = N'Price';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Product quantity', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'OrderDetail', @level2type = N'COLUMN', @level2name = N'Cantidad';


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'total item price', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'OrderDetail', @level2type = N'COLUMN', @level2name = N'TotalPrice';

