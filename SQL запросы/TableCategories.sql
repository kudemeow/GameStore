CREATE TABLE Categories
(
	CategoryID INT NOT NULL PRIMARY KEY IDENTITY,
	CategoryName VARCHAR(50) NOT NULL
)

INSERT INTO Categories([CategoryName])
VALUES('Выживание'),
	  ('RPG'),
	  ('Стелс'),
	  ('Хоррор'),
	  ('Стратегия'),	
	  ('Шутер'),
	  ('Симулятор'),
	  ('Платформер')