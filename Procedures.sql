-- Calculate the winning and losing teams for each game within a 
-- day-by-day time frame based on adding the points scored by every player 
-- from each team and comparing the totals. The teams will then be ranked from 
-- best to worst according to the each’s winning percentage.
CREATE OR ALTER PROCEDURE CalculateStandings @FirstDate DateTime, @LastDate DateTime 
AS
WITH EachGameCte(TeamID, TeamName, GameID, TotalPoints) AS
(
	SELECT T.TeamID, T.TeamName, G.GameID, SUM(PS.Points)
	FROM Team T
		INNER JOIN TeamGame TG ON T.TeamID = TG.TeamID
		INNER JOIN Game G ON TG.GameID = G.GameID
			AND G.GameDate BETWEEN @FirstDate AND @LastDate
		INNER JOIN PlayerStats PS ON TG.GameID = PS.GameID
			AND TG.TeamID = PS.TeamID
	GROUP BY G.GameID, T.TeamName, T.TeamID
)
SELECT EGC_f.TeamID, EGC_f.TeamName, SUM(IIF(EGC_f.TotalPoints >= EGC_s.TotalPoints, 1, 0)) AS WinningTotal,
	SUM(IIF(EGC_f.TotalPoints < EGC_s.TotalPoints, 1, 0)) AS LosingTotal,
	RANK() OVER(ORDER BY SUM(IIF(EGC_f.TotalPoints >= EGC_s.TotalPoints, 1, 0)) / (COUNT(*) * 1.0) DESC, 
		SUM(IIF(EGC_f.TotalPoints >= EGC_s.TotalPoints, 1, 0)) DESC, 
		SUM(IIF(EGC_f.TotalPoints < EGC_s.TotalPoints, 1, 0)) ASC) AS Standing
FROM EachGameCte EGC_f
	INNER JOIN EachGameCte EGC_s ON EGC_f.GameID = EGC_s.GameID
		AND EGC_f.TeamName != EGC_s.TeamName
GROUP BY EGC_f.TeamID, EGC_f.TeamName
GO


-- Calculate the averages for each statistic of every player in a certain time period, 
-- compare the totals and rank them accordingly.
CREATE OR ALTER PROCEDURE CalculatePlayerAverages @FirstDate DateTime, @LastDate DateTime 
AS
SELECT P.PlayerID, P.[Name], CAST(ROUND(AVG(PS.Points * 1.0), 2) AS DECIMAL(4, 2)) AS PPG,
	CAST(ROUND(AVG(PS.Rebounds * 1.0), 2) AS DECIMAL(4, 2)) AS REB,
	CAST(ROUND(AVG(PS.Assists * 1.0), 2) AS DECIMAL(4, 2)) AS AST,
	RANK() OVER(ORDER BY CAST(ROUND(AVG(PS.Points * 1.0), 2) AS DECIMAL(4, 2)) DESC) AS PointsRanking,
	RANK() OVER(ORDER BY CAST(ROUND(AVG(PS.Rebounds * 1.0), 2) AS DECIMAL(4, 2)) DESC) AS ReboundsRanking,
	RANK() OVER(ORDER BY CAST(ROUND(AVG(PS.Assists * 1.0), 2) AS DECIMAL(4, 2)) DESC) AS AssistsRanking
FROM Player P
	INNER JOIN PlayerStats PS ON P.PlayerID = PS.PlayerID
		AND P.TeamID = PS.TeamID
	INNER JOIN TeamGame TG ON PS.GameID = TG.GameID
		AND PS.TeamID = TG.TeamID
	INNER JOIN Game G ON TG.GameID = G.GameID
		AND G.GameDate BETWEEN @FirstDate AND @LastDate
GROUP BY P.PlayerID, P.[Name]
ORDER BY PointsRanking, ReboundsRanking, AssistsRanking
GO


-- Calculate the average amount of points scored by each player on a certain date as well as 
-- the highest and lowest scorers on that same day.
CREATE OR ALTER PROCEDURE CalculateDayPointTotals @Date DateTime
AS
SELECT @Date AS [Date], CAST(ROUND(AVG(PS.Points * 1.0), 2) AS DECIMAL(4, 2)) AS PPG,
	MAX(PS.Points) AS Highest, MIN(PS.Points) AS Lowest
FROM PlayerStats PS
	INNER JOIN TeamGame TG ON PS.GameID = TG.GameID
		AND PS.TeamID = TG.TeamID
	INNER JOIN Game G ON TG.GameID = G.GameID
		AND G.GameDate = @Date
GROUP BY G.GameDate
GO


-- Show the number of games played and the total points, rebounds, and assists for each player for a given team.
CREATE OR ALTER PROCEDURE CalculatePlayerTotals @TeamID INT
AS
SELECT P.PlayerID, P.[Name], SUM(PS.Points) AS TotalPoints, SUM(PS.Rebounds) AS TotalRebounds,
	SUM(PS.Assists) AS TotalAssists, COUNT(*) AS GamesPlayed
FROM Player P
	INNER JOIN Team T ON P.TeamID = T.TeamID
		AND T.TeamID = @TeamID
	INNER JOIN PlayerStats PS ON P.PlayerID = PS.PlayerID
		AND P.TeamID = PS.TeamID
GROUP BY P.PlayerID, P.[Name]
ORDER BY SUM(PS.Points) DESC, SUM(PS.Rebounds) DESC, SUM(PS.Assists) DESC
GO
