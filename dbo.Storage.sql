CREATE TABLE [dbo].[Storage] (
    [StorageId]    INT          NOT NULL,
    [Type]         VARCHAR (10) NULL,
    [Availability] CHAR (1)     NULL,
    [Size]         VARCHAR (20) NULL,
    [Price]        MONEY        NULL,
    [Longitude]    VARCHAR (11) NULL,
    [Latitude]     VARCHAR (11) NULL,
    [usedStorage] INT NULL, 
    [availableStorage] INT NULL, 
    [maxStorage] INT NULL, 
    [temparature] INT NULL, 
    [storageDate] DATE NULL, 
    PRIMARY KEY CLUSTERED ([StorageId] ASC)
);

