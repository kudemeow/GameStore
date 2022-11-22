CREATE PROCEDURE SearchGameName AS SET NOCOUNT ON
DECLARE @searchString VARCHAR(MAX)
SELECT Name FROM Games WHERE Name LIKE @searchString

EXEC @searchString