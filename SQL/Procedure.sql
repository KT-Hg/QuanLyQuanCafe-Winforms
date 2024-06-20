USE QuanLyQuanCafe
GO

CREATE PROCEDURE GetTableFood
AS
BEGIN
    SELECT * FROM TableFood;
END;
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

CREATE PROCEDURE UpdateBill
    @id INT, @discount INT
AS
BEGIN
    UPDATE Bill
    SET dateCheckOut = GETDATE(),
        status = 1,
		discount = @discount
    WHERE id = @id;
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