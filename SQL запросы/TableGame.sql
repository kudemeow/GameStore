CREATE TABLE Games
(
	[GameID] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(100) NOT NULL,
	[Description] NVARCHAR(500) NOT NULL,
	[Category] NVARCHAR(50) NOT NULL,
	[Price] DECIMAL(16, 2) NOT NULL,
	[Picture] varbinary(MAX) NULL
)

INSERT INTO Games([Name], [Description], [Category], [Price]) 
VALUES 
	('Subnautica', '���������� � ������� ������������� ���������� ����, ������������ �������� � �����������." ���������� ����������, ���������� ���������� ������� � ����������� ����� ��������, ����� �����������
    ������ ���������� ����, �������, ������� ����� � ������ ������, ������� ������.', '���������', 999.00),
	('TITANFALL', '��� ���� ��������� ��� �� ���������, ��� ����� ������������������� ��������, ������� � ���������, � ������� � ������', '�����', 2299.00),
	('Battlefield 4', 'Battlefield 4 � ��� ������������ ��� �����, ������ ������ ������, ��������� ����� ��������������, ������ ������� ���', '�����', 899.40),
	('The Sims 4', '� ���������� ������� �������� ���� ������� ���� ���� �����. �� � ������� The Sims 4 ��� ����������� ����� �����! 
		��� ������ � ���, ��� � � ��� ����, ��� ����������, ��� �������� � ������������ ���� ���', '���������', 15.00),
	('Dark Souls 2', '����������� ����������� �������� ������ ����� �������� ������� ������ ����� ���������� ���������. Dark Souls II ��������� 
		������ �����, ����� ������� � ����� ���. ���� ���� ��������� � ������ � ������� ��������� Dark Souls ����� ��������.', 'RPG', 949.00),
	('The Elder Scrolls V: Skyrim', '����� �������� ������ �������� ������� ��������� �� ����� ����������. ������ ������������ �� ������� ���������� ����� �����, 
		� ���������� ��������. � ���� ��, ��� ������������� ������� ������, � ��� ��������� �������� � ����������� �������. ������ ������� �������� � ���� 
		������� ������� �� ����������������� � ��������, � ����� �������� ����� ����� ����������� �������.', 'RPG', 1399.00),
	('FIFA 14', '�����������, ��������, ������������� ������! ����������� �������� �������� FIFA ���� ��� ����� ��������� ����������, ���������� ���������� ���� �
		 ������ ���� � ����������� �������� � ����.', '���������', 699.00),
	('Need for Speed Rivals', '�������� ��� ����������� ������ ����. ������� ����� ����� ��������� � ��������������������� ������� � ���������� ������������� 
		����� ��������� � ��������. �������� ������� � ���, � ������� ���� ������ ��� ��������� � ������ � �������. ', '���������', 15.00),
	('Crysis 3', '�������� ���� ��������������� � 2047 ����, � ��� ��������� ��������� � ���� �������.', '�����', 1299.00),
	('Dead Space 3', '� Dead Space 3 ����� ����� � ������� ������ ���� ������ ������������ � ����������� �����������, ����� ������ � ������������� �����������.', '�����', 499.00),
	('Deus Ex', '�������� ���� ��������������� � ����������� ��������������� ���� ����� 2052 ����. �� ������� ���������� ������������� ����������, ������������ ������������� ������� � ���������� ������ ���������������� �����������, ����������� �������� ����������� ����������� ������� � ������ ������.
	����� ��������� �� ���� ���������� �������������������� �����������, ��������� ��� ������ � ���������� �����������.', '�����', 149.00),
	('Gris', '���� - ������ ������ ������� �������, ������������ � ����� ����������� ����, ������������ �����������
    ���� � ����� �����. �� ����������� ����� ���� ����������� � �� ������, ������� ���� ����� �����������,
    ����� ����� ��������������� � �� ������� ����������.', '����������', 392.00),
	('Sid Meier�s Civilization VI', 'Civilization VI � �������� ����� ���������� ��������� �������� Civilization. ���������� ���� �������,
    ���������� ���� �������� � ���������� ����� � ���� � ����������� �������� � �������. �������� �� ����
    ����������� ��������� ��������?', '���������', 1999.00),
	('Knock-knock', '� ������� ��������� ���� ����� ��������� ���. ���� ���������� ������� �� ������ � ������������,
    � �������. � �������� ��� ��������� ����� ���� �������� �������� ��������� � ��������� ���������� �
    ��������� ����, �������� ��� � �������. �� ���� ���� ���-�� ����������. �� ����� � ����� �������, ���
    ���-�� ����������� � ��������� ������, �������� � ��������. ���� ���-�� ������������ �� ��������,
    �� ������ ���� � �������� �� ����� � ��� �� ������.', '������', 249.00),
	('HITMAN� 2 ', '������������� �� ���� � ������������ ���� ���� � ������������ ��������-���������� � HITMAN� 2. �� ������� ������� ���� �� ������ � ������� ����������� ����� �
	����� �� ������������ �� ������ ���������������� ������ � ����, ������ 47, � ����������� ��������� ��������.', '�����', 1599.00),
	('HITMAN 3', '������ ����. ����� 47 ������������ � HITMAN 3, ������������� ���������� �������� ���� �������.', '�����', 2698.00)