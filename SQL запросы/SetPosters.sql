USE gameStore

UPDATE Games
SET Poster =
	(SELECT * FROM OPENROWSET(BULK N'D:\视醒雷2\Images\Dune.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 1

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\视醒雷\项耱屦鸤Shoushenk.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 2

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\视醒雷\项耱屦鸤Gentlemen.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 3

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\视醒雷\项耱屦鸤Interstellar.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 4

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\视醒雷\项耱屦鸤Seven.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 5

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\视醒雷\项耱屦鸤Inception.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 6

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\视醒雷\项耱屦鸤warZ.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 7

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\视醒雷\项耱屦鸤GhostInTheShell.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 8

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\视醒雷\项耱屦鸤GoneGirl.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 9

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\视醒雷\项耱屦鸤US.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 10

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\视醒雷\项耱屦鸤Drive.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 11