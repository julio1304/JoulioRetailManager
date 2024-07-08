CREATE TABLE [dbo].[SaleDetail]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [SaleId] INT NOT NULL, 
    [ProduceId] INT NOT NULL, 
    [Quantity] INT NOT NULL DEFAULT 1,
    [PurchasePrice] MONEY NOT NULL,
    [Tax] MONEY NOT NULL DEFAULT 0
)
