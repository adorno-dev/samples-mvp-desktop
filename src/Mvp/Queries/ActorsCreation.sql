CREATE DATABASE MovieDb
GO
USE MovieDb

GO

CREATE TABLE Actors
(
    [Id] INT IDENTITY (100000, 1) PRIMARY KEY,
    [Name] NVARCHAR (50) NOT NULL,
    [Country] NVARCHAR (50) NOT NULL,
    [Language] NVARCHAR (50) NOT NULL 
)

GO

INSERT INTO Actors VALUES ('Jack Ryan', 'United States', 'English')
INSERT INTO Actors VALUES ('Developer', 'Brazil', 'Portuguese/English')
INSERT INTO Actors VALUES ('Jason Sthatam', 'England', 'English (UK)')
INSERT INTO Actors VALUES ('Orcelot Anoushka', 'Russia', 'Russian/English (UK)')
INSERT INTO Actors VALUES ('Joao Pedro', 'Brazil', 'Portuguese')
INSERT INTO Actors VALUES ('Milena Miller', 'Africa', 'African/Portuguese')
INSERT INTO Actors VALUES ('Angelina Jollie', 'United States', 'English')
INSERT INTO Actors VALUES ('Maggie Greene', 'France', 'French')
INSERT INTO Actors VALUES ('Beth Greene', 'France', 'French')
INSERT INTO Actors VALUES ('Merle Dixon', 'Holland', 'English')
INSERT INTO Actors VALUES ('Morgan Jones', 'United States', 'English')
INSERT INTO Actors VALUES ('Lance Hornsby', 'Polland', 'Russian/English')
INSERT INTO Actors VALUES ('Judith Grimes', 'United States', 'English')
INSERT INTO Actors VALUES ('Darle Horvath', 'United States', 'English/Portuguese')
INSERT INTO Actors VALUES ('Shane Walsh', 'United States', 'English')