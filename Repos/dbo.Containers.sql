CREATE TABLE [dbo].[Containers] (
    [ContainersId]  INT          NOT NULL,
    [Availability] CHAR (1)     NULL,
    [Max_Size] INT NULL, 
    [Storage_Slot_number] INT NULL, 
    PRIMARY KEY CLUSTERED ([ContainersId] ASC)
);

