USE gameStore

UPDATE Games
SET Poster =
	(SELECT * FROM OPENROWSET(BULK N'D:\������2\Images\Dune.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 1

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\������\�������\Shoushenk.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 2

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\������\�������\Gentlemen.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 3

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\������\�������\Interstellar.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 4

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\������\�������\Seven.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 5

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\������\�������\Inception.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 6

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\������\�������\warZ.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 7

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\������\�������\GhostInTheShell.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 8

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\������\�������\GoneGirl.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 9

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\������\�������\US.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 10

UPDATE Games
SET Posters =
	(SELECT * FROM OPENROWSET(BULK N'C:\Users\kudemeow\Desktop\������\�������\Drive.jpg', SINGLE_BLOB) AS Posters)
WHERE Film_ID = 11