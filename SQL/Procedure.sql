USE QuanLyQuanCafe
GO

CREATE PROCEDURE DeleteAccount
    @userName NVARCHAR(100)
AS
BEGIN
    DELETE FROM Account
    WHERE [userName] = @userName
END
GO

CREATE PROCEDURE DeleteFood
    @id INT
AS
BEGIN
    DELETE FROM Food
    WHERE [id] = @id
END
GO

CREATE PROCEDURE DeleteFoodCategory
    @id INT
AS
BEGIN
    DELETE FROM FoodCategory
    WHERE [id] = @id
END
GO

CREATE PROCEDURE DeleteTableFood
    @id INT
AS
BEGIN
    DELETE FROM TableFood
    WHERE [id] = @id
END
GO

CREATE PROCEDURE GetAccount
AS
BEGIN
    SELECT [displayName], [userName], [type] FROM Account
END
GO

CREATE PROCEDURE GetAllFood
AS
BEGIN
    SELECT * FROM Food
END
GO

CREATE PROCEDURE GetBillByIdTable
    @idTable INT
AS
BEGIN
    SELECT *
    FROM Bill
    WHERE idTable = @idTable;
END
GO

CREATE PROCEDURE GetListBillByDate
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SELECT 
        tf.[name] AS TableName,
        b.[id] AS BillID,
        b.[dateCheckIn],
        b.[dateCheckOut],
        b.[totalPrice],
        b.[discount]
    FROM 
        Bill b
        JOIN TableFood tf ON b.[idTable] = tf.[id]
    WHERE 
        b.[dateCheckIn] >= @StartDate AND b.[dateCheckOut] <= @EndDate
    ORDER BY 
        b.[dateCheckIn]
END
GO

CREATE PROCEDURE GetListMenuByTable
    @idTable INT
AS
BEGIN
    SELECT f.name, 
           bi.count, 
           f.price, 
           f.price * bi.count AS totalPrice 
    FROM dbo.BillInfo AS bi
    JOIN dbo.Bill AS b ON bi.idBill = b.id
    JOIN dbo.Food AS f ON bi.idFood = f.id
    WHERE b.status = 0 
      AND b.idTable = @idTable;
END
GO

CREATE PROCEDURE GetTableFood
AS
BEGIN
    SELECT * FROM TableFood;
END
GO

CREATE PROCEDURE InsertAccount
    @displayName NVARCHAR(100),
    @userName NVARCHAR(100),
    @type INT
AS
BEGIN
    INSERT INTO Account ([displayName], [userName], [type])
    VALUES (@displayName, @userName, @type)
END
GO

CREATE PROCEDURE InsertBill
    @idTable INT
AS
BEGIN
    INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status])
    VALUES (GETDATE(), NULL, @idTable, 0)
END;
GO

CREATE PROCEDURE InsertBillInfo
    @idBill INT, @idFood INT, @count INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM BillInfo WHERE idBill = @idBill AND idFood = @idFood)
    BEGIN
        UPDATE BillInfo
        SET count = count + @count
        WHERE idBill = @idBill AND idFood = @idFood
    END
    ELSE
    BEGIN
        INSERT INTO BillInfo ([idBill], [idFood], [count]) 
        VALUES (@idBill, @idFood, @count)
    END
END;
GO

CREATE PROCEDURE InsertFood
    @name NVARCHAR(100),
    @idCategory INT,
    @price FLOAT
AS
BEGIN
    INSERT INTO Food ([name], [idCategory], [price])
    VALUES (@name, @idCategory, @price)
END
GO

CREATE PROCEDURE InsertFoodCategory
    @name NVARCHAR(100) = N'Chưa đặt tên'
AS
BEGIN
    INSERT INTO FoodCategory ([name])
    VALUES (@name)
END
GO

CREATE PROCEDURE InsertTableFood
    @name NVARCHAR(100) = N'Chưa có tên',
    @status NVARCHAR(100) = N'Trống'
AS
BEGIN
    INSERT INTO TableFood ([name], [status])
    VALUES (@name, @status)
END
GO

CREATE PROCEDURE LoginAccount
    @userName NVARCHAR(100),
    @passWord NVARCHAR(MAX)
AS
BEGIN
    SELECT COUNT(*) AS [count] FROM Account WHERE [userName] = @userName AND [passWord] = @passWord;
END;
GO

CREATE PROCEDURE SearchAccountByUserName
    @userName NVARCHAR(100)
AS
BEGIN
    SELECT [displayName], [userName], [type] FROM Account
    WHERE [userName] LIKE '%' + @userName + '%'
END
GO

CREATE PROCEDURE SearchBillInfoByIdFood
    @idFood INT
AS
BEGIN
    SELECT *
    FROM BillInfo
    WHERE idFood = @idFood;
END
GO

CREATE PROCEDURE SearchFoodById
    @id INT
AS
BEGIN
    SELECT * FROM Food
    WHERE [id] = @id
END
GO

CREATE PROCEDURE SearchFoodByName
    @name NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Food
    WHERE [name] LIKE '%' + @name + '%'
END
GO

CREATE PROCEDURE SearchFoodCategoryByName
    @name NVARCHAR(100)
AS
BEGIN
    SELECT * FROM FoodCategory
    WHERE [name] LIKE '%' + @name + '%'
END
GO

CREATE PROCEDURE SearchTableFoodByName
    @name NVARCHAR(100)
AS
BEGIN
    SELECT * FROM TableFood
    WHERE [name] LIKE '%' + @name + '%'
END
GO

CREATE PROCEDURE SwapTableBill
    @TableAId INT,
    @TableBId INT
AS
BEGIN
    DECLARE @BillAId INT;
    DECLARE @BillBId INT;

    SELECT @BillAId = [id]
    FROM Bill
    WHERE [idTable] = @TableAId AND [status] = 0;

    SELECT @BillBId = [id]
    FROM Bill
    WHERE [idTable] = @TableBId AND [status] = 0;

    IF @BillAId IS NOT NULL
    BEGIN
        UPDATE Bill
        SET [idTable] = @TableBId
        WHERE [id] = @BillAId;
    END

    IF @BillBId IS NOT NULL
    BEGIN
        UPDATE Bill
        SET [idTable] = @TableAId
        WHERE [id] = @BillBId;
    END
END
GO

CREATE PROCEDURE SwapTableStatus
    @TableAId INT,
    @TableBId INT
AS
BEGIN
    DECLARE @StatusA NVARCHAR(100);
    DECLARE @StatusB NVARCHAR(100);

    SELECT @StatusA = [status]
    FROM TableFood
    WHERE [id] = @TableAId;

    SELECT @StatusB = [status]
    FROM TableFood
    WHERE [id] = @TableBId;

    UPDATE TableFood
    SET [status] = @StatusB
    WHERE [id] = @TableAId;

    UPDATE TableFood
    SET [status] = @StatusA
    WHERE [id] = @TableBId;
END
GO

CREATE PROCEDURE UpdateAccount
    @userNameOld NVARCHAR(100), @passWordOld NVARCHAR(MAX),
    @displayNameNew NVARCHAR(100), @userNameNew NVARCHAR(100), @passWordNew NVARCHAR(MAX), @type INT
AS
BEGIN
    UPDATE Account
    SET displayName = @displayNameNew,
        userName = @userNameNew,
        passWord = @passWordNew,
        type = @type
    WHERE userName = @userNameOld AND passWord = @passWordOld;
END
GO

CREATE PROCEDURE UpdateBill
    @id INT, @discount INT, @totalPrice FLOAT
AS
BEGIN
    UPDATE Bill
    SET dateCheckOut = GETDATE(),
        status = 1,
        discount = @discount,
        totalPrice = @totalPrice
    WHERE id = @id;
END
GO

CREATE PROCEDURE UpdateBillInfo
    @id INT,
    @idBill INT,
    @idFood INT,
    @count INT
AS
BEGIN
    UPDATE BillInfo
    SET [idBill] = @idBill,
        [idFood] = @idFood,
        [count] = @count
    WHERE [id] = @id;
END
GO

CREATE PROCEDURE UpdateFood
    @id INT,
    @name NVARCHAR(100),
    @idCategory INT,
    @price FLOAT
AS
BEGIN
    UPDATE Food
    SET [name] = @name,
        [idCategory] = @idCategory,
        [price] = @price
    WHERE [id] = @id
END
GO

CREATE PROCEDURE UpdateFoodCategory
    @id INT,
    @name NVARCHAR(100)
AS
BEGIN
    UPDATE FoodCategory
    SET [name] = @name
    WHERE [id] = @id
END
GO

CREATE PROCEDURE UpdateIdTableBill
    @id INT,
    @idTable INT
AS
BEGIN
    UPDATE Bill
    SET idTable = @idTable
    WHERE id = @id;
END
GO

CREATE PROCEDURE UpdateTableFood
    @id INT,
    @name NVARCHAR(100),
    @status NVARCHAR(100)
AS
BEGIN
    UPDATE TableFood
    SET [name] = @name,
        [status] = @status
    WHERE [id] = @id
END
GO

CREATE PROCEDURE UpdateTableStatus
    @id INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM TableFood WHERE [id] = @id AND [status] = N'Trống')
    BEGIN
        UPDATE TableFood
        SET [status] = N'Có người'
        WHERE [id] = @id;
    END
    ELSE IF EXISTS (SELECT 1 FROM TableFood WHERE [id] = @id AND [status] = N'Có người')
    BEGIN
        UPDATE TableFood
        SET [status] = N'Trống'
        WHERE [id] = @id;
    END
END
GO
