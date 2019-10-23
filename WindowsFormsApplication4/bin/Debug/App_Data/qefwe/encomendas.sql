CREATE TABLE [dbo].[Table]
(
	[Cliente] VARCHAR(50) NOT NULL , 
    [CodEncomenda] NCHAR(10) NOT NULL, 
    [QtPalSec] INT NULL DEFAULT 0, 
    [QtRollSec] INT NULL DEFAULT 0, 
    [QtPalFres] INT NULL DEFAULT 0, 
    [QtRollFres] INT NULL DEFAULT 0, 
    [QtPalCong] INT NULL DEFAULT 0, 
    [QtRollCong] INT NULL DEFAULT 0, 
    [Peso] DECIMAL NULL DEFAULT 0, 
    [Ridelle] BIT NULL DEFAULT 0, 
    [Manual] BIT NULL DEFAULT 0, 
    [HoraCarga] TIME NOT NULL, 
    PRIMARY KEY ([CodEncomenda])
)
CREATE TABLE [dbo].[Veiculos]
(
	[Matricula] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [Secos] BIT NULL, 
    [Frescos] BIT NULL, 
    [Congelados] BIT NULL, 
    [Limite de peso] INT NOT NULL, 
    [Classe] NVARCHAR(50) NOT NULL
)
