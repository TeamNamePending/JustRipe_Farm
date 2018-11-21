CREATE TABLE [dbo].[Containers] (
    [CotainersId]  INT          NOT NULL,
    [Type]         VARCHAR (10) NULL,
    [Size]         VARCHAR (20) NULL,
    [Availability] CHAR (1)     NULL,
    [Price]        MONEY        NULL,
    PRIMARY KEY CLUSTERED ([CotainersId] ASC)
);

