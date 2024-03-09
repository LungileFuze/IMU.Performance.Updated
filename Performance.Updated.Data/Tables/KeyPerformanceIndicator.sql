CREATE TABLE [dbo].[KeyPerformanceIndicator]
(
	Id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,10),
	KeyPerformanceAreaId BIGINT NOT NULL,
	Description NVARCHAR(2000) NOT NULL,
	Weighting INT NOT NULL,
	MidtermScore INT NULL,
	MidtermWeightedScore DECIMAL(3,2) NULL,
	FinalScore INT NULL,
	FinalWeightedScore DECIMAL(3,2) NULL,
	DateCreated DATETIME NOT NULL
	FOREIGN KEY (KeyPerformanceAreaId) REFERENCES KeyPerformanceArea(Id)
)
