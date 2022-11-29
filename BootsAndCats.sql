USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = 'BootsAndCats'
)
CREATE DATABASE BootsAndCats
GO

CREATE TABLE Users(
	Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    UserName NVARCHAR(50) UNIQUE,
	Password NVARCHAR(50)
)

CREATE TABLE Reviews(
	Id INT IDENTITY NOT NULL PRIMARY KEY,
    UserId INT FOREIGN KEY REFERENCES Users(Id),
    Rating INT,
	ReviewContent NVARCHAR(500),
	Recommendation BIT,
    Tag NVARCHAR(50),
    DateSubmitted DATETIME
)

-- select * From Users
select * from Reviews
