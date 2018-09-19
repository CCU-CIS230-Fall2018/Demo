CREATE DATABASE Attractions;
GO

USE Attractions;
GO

CREATE TABLE Countries
(
	CountryID tinyint PRIMARY KEY,
	CountryName varchar(100)
)

GO

CREATE TABLE Attractions
(
	AttID tinyint PRIMARY KEY,
	AttractionName varchar(200),
	EntranceFee money,
	CountryID tinyint FOREIGN KEY REFERENCES Countries(CountryID)
)

GO

INSERT INTO Countries (CountryID, CountryName) VALUES
(1, 'United States'),
(2, 'France'),
(3, 'Italy'),
(4, 'Mexico');

GO

INSERT INTO Attractions (AttID, AttractionName, EntranceFee, CountryID) VALUES
(100,'Statue of Liberty', 25.00, 1),
(101,'Lincoln Memorial', 0.00,1),
(102,'Eiffel Tower', 74.76,2),
(103,'The Louvre', 56.68,2),
(104,'The Colosseum', 59.00,3),
(105,'Venice Canals', 0, 3);

GO
