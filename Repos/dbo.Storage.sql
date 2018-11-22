CREATE TABLE [dbo].[Storage] (
    [StorageId]    INT          NOT NULL,
    [Type]         VARCHAR (10) NULL,
    [Availability] CHAR (1)     NULL,
    [Size]         VARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([StorageId] ASC)
);

