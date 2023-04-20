DROP TABLE IF EXISTS PlayerStats;
DROP TABLE IF EXISTS Player;
DROP TABLE IF EXISTS TeamGame;
DROP TABLE IF EXISTS TeamType;
DROP TABLE IF EXISTS Team;
DROP TABLE IF EXISTS Game;

CREATE TABLE Team
(
	TeamID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	TeamName NVARCHAR(128) NOT NULL UNIQUE,
	TeamColor NVARCHAR(32) NOT NULL
);

CREATE TABLE Player
(
	PlayerID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	TeamID INT NOT NULL FOREIGN KEY REFERENCES Team(TeamID),
	[Name] NVARCHAR(128) NOT NULL,
	JerseyNumber INT NOT NULL,
	Height INT NOT NULL,
	[Weight] INT NOT NULL,
	Age INT NOT NULL,

	UNIQUE(PlayerID, TeamID)
);

CREATE TABLE TeamType
(
	TeamTypeID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(128) NOT NULL UNIQUE
);

CREATE TABLE Game
(
	GameID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	GameDate DATETIME NOT NULL
);

CREATE TABLE TeamGame
(
	TeamGameID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	GameID INT NOT NULL FOREIGN KEY REFERENCES Game(GameID),
	TeamTypeID INT NOT NULL FOREIGN KEY REFERENCES TeamType(TeamTypeID),
	TeamID INT NOT NULL FOREIGN KEY REFERENCES Team(TeamID),

	UNIQUE(GameID, TeamTypeID),
	UNIQUE(GameID, TeamID)
);

CREATE TABLE PlayerStats
(
	PlayerStatsID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	GameID INT NOT NULL,
	TeamID INT NOT NULL,
	PlayerID INT NOT NULL,
	Points INT NOT NULL CHECK(Points >= 0) DEFAULT 0,
	Rebounds INT NOT NULL CHECK(Rebounds >= 0) DEFAULT 0,
	Assists INT NOT NULL CHECK(Assists >= 0) DEFAULT 0,

	UNIQUE(GameID, PlayerID),
	FOREIGN KEY (GameID, TeamID) REFERENCES TeamGame(GameID, TeamID),
	FOREIGN KEY (PlayerID, TeamID) REFERENCES Player(PlayerID, TeamID)
);




-- Queries

--This query joins the Player, PlayerStats, and TeamGame and Team tables
-- and returns the total statistics of each player on a specific team

DECLARE @TeamName NVARCHAR(128) = 'Jazz'; -- Replace with the desired team name

SELECT 
    Player.PlayerID,
    Player.JerseyNumber,
    Player.Name,
    SUM(PlayerStats.Points) AS 'Total Points',
    SUM(PlayerStats.Rebounds) AS 'Total Rebounds',
    SUM(PlayerStats.Assists) AS 'Total Assists',
    COUNT(DISTINCT PlayerStats.GameID) AS 'Games Played'
FROM 
    Player
    JOIN PlayerStats ON Player.PlayerID = PlayerStats.PlayerID
    JOIN TeamGame ON PlayerStats.GameID = TeamGame.GameID AND PlayerStats.TeamID = TeamGame.TeamID
    JOIN Team ON TeamGame.TeamID = Team.TeamID
WHERE 
    Team.TeamName = @TeamName
GROUP BY 
    Player.PlayerID,
    Player.JerseyNumber,
    Player.Name
