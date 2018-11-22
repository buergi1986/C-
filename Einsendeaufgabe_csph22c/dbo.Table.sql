CREATE TABLE [dbo].[Medium]
(
	[mNummer] INT NOT NULL PRIMARY KEY, 
    [titel] NVARCHAR(50) NOT NULL, 
    [typ] NVARCHAR(1) NOT NULL, 
    [standort] NVARCHAR(50) NOT NULL, 
    [ausgeliehen] BIT NULL, 
    [bestand] BIT NULL
)
