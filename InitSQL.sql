CREATE DATABASE TestBase;
GO

USE TestBase;

CREATE TABLE Products (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50)
);


CREATE TABLE Categories (
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) 
);

CREATE TABLE ProductsCategories (
	ProductId INT NOT NULL,
	CategoryId INT,
	FOREIGN KEY (ProductId)  REFERENCES Products (Id),
	FOREIGN KEY (CategoryId)  REFERENCES Categories (Id)
);


INSERT INTO Products ([Name])
VALUES
(N'Перфоратор'),
(N'Отвертка'),
(N'Шуруповерт'),
(N'Сверло');

GO

INSERT  INTO Categories ([Name])
VALUES
(N'Инструменты'),
(N'Комплектующие'),
(N'Действует скидка');

GO

INSERT ProductsCategories VALUES
(1, 1),
(2, 1),
(3, null),
(4, 2),
(4, 3);