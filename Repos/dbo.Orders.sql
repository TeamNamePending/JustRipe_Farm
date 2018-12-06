CREATE TABLE [dbo].[Orders] (
    [OrderId]          INT          IDENTITY (1, 1) NOT NULL,
    [CustomerID]       INT          NULL,
    [OrderInformation] VARCHAR (50) NULL,
    [TotalPrice]       MONEY        NULL,
    [StorageRequired]  INT          NULL,
    [Completed]        VARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([OrderId] ASC)
);

