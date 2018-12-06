CREATE TABLE [dbo].[Vehicles] (
    [VehiclesId]    INT          NOT NULL,
    [Max_Space]     INT          NULL,
    [Current_Space] INT          NULL,
    [Type]          VARCHAR (10) NULL,
    [Availability]  CHAR (1)     NULL,
    PRIMARY KEY CLUSTERED ([VehiclesId] ASC)
);

