CREATE TABLE [dbo].[Table]
(
	[Numero_interno] INT IDENTITY NOT NULL PRIMARY KEY, 
    [CPF] VARCHAR(11) NULL, 
    [Nome] VARCHAR(50) NULL, 
    [Data_Nascimento] DATE NULL
)
