CREATE TABLE [dbo].[Crops] (
    [CropId]                   INT          NOT NULL,
    [name]                     VARCHAR (50) NULL,
    [Type]                     VARCHAR (20) NULL,
    [FertiliserTypeRequired]   VARCHAR (20) NULL,
    [FertiliserAmountRequired] VARCHAR (10) NULL,
    [HarvestTime]              VARCHAR (10) NULL,
    [Avaliability]             CHAR (1)     NULL,
    [EquipmentNeeded]          VARCHAR (50) NULL,
    [Price/kg]                 MONEY        NULL,
    [Temperature]              FLOAT (53)   NULL,
    [Treatment]                VARCHAR (50) NULL,
    [TreatmentTime]            TIME (7)     NULL,
    PRIMARY KEY CLUSTERED ([CropId] ASC)
);

