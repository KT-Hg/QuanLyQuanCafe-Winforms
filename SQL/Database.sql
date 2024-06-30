CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	[id] INT IDENTITY PRIMARY KEY,
	[name] NVARCHAR(100) NOT NULL DEFAULT N'Chưa có tên',
	[status] NVARCHAR(100) NOT NULL DEFAULT N'Trống'
)
GO

CREATE TABLE Account
(
	[displayName] NVARCHAR(100) NOT NULL ,
	[userName] NVARCHAR(100) PRIMARY KEY,
	[passWord] NVARCHAR(MAX) NOT NULL DEFAULT N'0',
	[type] INT NOT NULL
)
GO

CREATE TABLE FoodCategory
(
	[id] INT IDENTITY PRIMARY KEY,
	[name] NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Food
(
	[id] INT IDENTITY PRIMARY KEY,
	[name] NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	[idCategory] INT,
	[price] FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY ([idCategory]) REFERENCES dbo.FoodCategory([id])
)
GO

CREATE TABLE Bill
(
	[id] INT IDENTITY PRIMARY KEY,
	[dateCheckIn] DATE NOT NULL DEFAULT GETDATE(),
	[dateCheckOut] DATE,
	[idTable] INT,
	[status] INT NOT NULL DEFAULT 0,
	[discount] INT NOT NULL DEFAULT 0,
	[totalPrice] FLOAT NOT NULL DEFAULT 0

	FOREIGN KEY ([idTable]) REFERENCES dbo.TableFood([id])

)
GO

CREATE TABLE BillInfo
(
	[id] INT IDENTITY PRIMARY KEY,
	[idBill] INT NOT NULL,
	[idFood] INT,
	[count] INT NOT NULL DEFAULT 0,

	FOREIGN KEY ([idBill]) REFERENCES dbo.Bill([id]),
	FOREIGN KEY ([idFood]) REFERENCES dbo.Food([id])
)
GO