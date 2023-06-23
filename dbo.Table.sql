CREATE TABLE [dbo].[empTable]
(
	[Employee ID] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Position] NVARCHAR(50) NOT NULL, 
    [Contact Number 1] NVARCHAR(50) NOT NULL, 
    [Contact Number 2] NVARCHAR(50) NULL, 
    [Address] NVARCHAR(MAX) NOT NULL
)
