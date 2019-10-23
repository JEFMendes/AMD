CREATE TABLE [dbo].[Veiculos]
(
	[Matricula] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Secos] BIT NULL, 
    [Frescos] BIT NULL, 
    [Congelados] BIT NULL, 
    [Limite de peso] INT NOT NULL, 
    [Classe] NVARCHAR(50) NOT NULL
)
