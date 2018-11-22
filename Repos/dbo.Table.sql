CREATE TABLE [dbo].[LabourerTasks]
(
	[TaskId] INT NOT NULL PRIMARY KEY, 
    [Task_type] VARCHAR(50) NULL, 
    [LabourerID] INT NULL, 
    [Date_set] DATETIME NULL, 
    [Date_deadline] DATETIME NULL
)
