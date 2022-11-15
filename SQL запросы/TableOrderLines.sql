CREATE TABLE [dbo].[OrderLines] (
    [OrderLineID]   INT IDENTITY (1, 1) NOT NULL,
    [Quantity]      INT NOT NULL,
    [Game_GameID]   INT NULL,
    [Order_OrderID] INT NULL,
    CONSTRAINT [PK_dbo.OrderLines] PRIMARY KEY CLUSTERED ([OrderLineID] ASC),
    CONSTRAINT [FK_dbo.OrderLines_dbo.Games_GameID] FOREIGN KEY ([Game_GameID]) REFERENCES [dbo].[Games] ([GameID]),
    CONSTRAINT [FK_dbo.OrderLines_dbo.Order_OrderID] FOREIGN KEY ([Order_OrderID]) REFERENCES [dbo].[Orders] ([OrderID])
);

