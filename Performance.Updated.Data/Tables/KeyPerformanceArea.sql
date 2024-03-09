CREATE TABLE [dbo].[KeyPerformanceArea]
(
	Id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,10),
	AgreementId BIGINT NOT NULL,
	Description NVARCHAR(2000) NOT NULL,
	Weighting INT NOT NULL,
	ManagerComment NVARCHAR(2000) NULL,
	ModeratorComment NVARCHAR(2000) NULL,
	DateCreated DATETIME NOT NULL
	FOREIGN KEY (AgreementId) REFERENCES Agreement(Id)
)
