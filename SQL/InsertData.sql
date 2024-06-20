USE QuanLyQuanCafe
GO

-- Thêm dữ liệu vào bảng TableFood
INSERT INTO TableFood ([name], [status]) VALUES (N'Bàn 1', N'Trống')
INSERT INTO TableFood ([name], [status]) VALUES (N'Bàn 2', N'Có người')
INSERT INTO TableFood ([name], [status]) VALUES (N'Bàn 3', N'Trống')
INSERT INTO TableFood ([name], [status]) VALUES (N'Bàn 4', N'Có người')
INSERT INTO TableFood ([name], [status]) VALUES (N'Bàn 5', N'Trống')
INSERT INTO TableFood ([name], [status]) VALUES (N'Bàn 6', N'Có người')
INSERT INTO TableFood ([name], [status]) VALUES (N'Bàn 7', N'Trống')
INSERT INTO TableFood ([name], [status]) VALUES (N'Bàn 8', N'Có người')
INSERT INTO TableFood ([name], [status]) VALUES (N'Bàn 9', N'Trống')
INSERT INTO TableFood ([name], [status]) VALUES (N'Bàn 10', N'Có người')
GO

-- Thêm dữ liệu vào bảng Account
INSERT INTO Account ([displayName], [userName], [passWord], [type]) VALUES (N'Nguyễn Văn A', 'admin', '123456', 1)
INSERT INTO Account ([displayName], [userName], [passWord], [type]) VALUES (N'Trần Thị B', 'user1', 'password1', 0)
INSERT INTO Account ([displayName], [userName], [passWord], [type]) VALUES (N'Lê Văn C', 'user2', 'password2', 0)
INSERT INTO Account ([displayName], [userName], [passWord], [type]) VALUES (N'Phạm Thị D', 'user3', 'password3', 0)
INSERT INTO Account ([displayName], [userName], [passWord], [type]) VALUES (N'Hoàng Văn E', 'user4', 'password4', 0)
INSERT INTO Account ([displayName], [userName], [passWord], [type]) VALUES (N'Đặng Thị F', 'user5', 'password5', 0)
INSERT INTO Account ([displayName], [userName], [passWord], [type]) VALUES (N'Vũ Văn G', 'admin2', 'adminpass', 1)
GO

-- Thêm dữ liệu vào bảng FoodCategory
INSERT INTO FoodCategory ([name]) VALUES (N'Đồ uống')
INSERT INTO FoodCategory ([name]) VALUES (N'Đồ ăn nhẹ')
INSERT INTO FoodCategory ([name]) VALUES (N'Tráng miệng')
INSERT INTO FoodCategory ([name]) VALUES (N'Món chính')
GO

-- Thêm dữ liệu vào bảng Food
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Cà phê đen', 1, 25000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Nước cam ép', 1, 35000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Nước chanh leo', 1, 30000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Sinh tố dâu tây', 1, 40000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Trà sữa trân châu đường đen', 1, 45000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Bánh mì thịt nướng', 2, 35000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Gỏi cuốn', 2, 25000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Xôi chiên phồng', 2, 30000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Bánh bao nhân thịt', 2, 15000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Chả giò', 2, 20000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Chè trôi nước', 3, 25000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Bánh flan', 3, 35000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Kem dâu tây', 3, 30000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Chuối chiên', 3, 20000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Xôi đậu xanh', 3, 25000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Cơm gà', 4, 45000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Bún chả', 4, 40000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Hủ tiếu', 4, 35000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Phở bò', 4, 50000);
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Cơm chiên', 4, 30000);
GO

-- Thêm dữ liệu vào bảng Bill
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-01', '2023-05-01', 1, 1)
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-02', NULL, 2, 0)
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-03', '2023-05-03', 3, 1)
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-04', NULL, 4, 0)
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-05', '2023-05-05', 5, 1)
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-06', NULL, 6, 0)
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-07', '2023-05-07', 7, 1)
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-08', NULL, 8, 0)
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-09', '2023-05-09', 9, 1)
GO

-- Thêm dữ liệu vào bảng BillInfo
INSERT INTO BillInfo ([idBill], [idFood], [count]) VALUES (1, 1, 2)
INSERT INTO BillInfo ([idBill], [idFood], [count]) VALUES (1, 3, 1)
INSERT INTO BillInfo ([idBill], [idFood], [count]) VALUES (2, 2, 1)
INSERT INTO BillInfo ([idBill], [idFood], [count]) VALUES (3, 4, 3)
INSERT INTO BillInfo ([idBill], [idFood], [count]) VALUES (4, 5, 1)
INSERT INTO BillInfo ([idBill], [idFood], [count]) VALUES (4, 6, 2)
INSERT INTO BillInfo ([idBill], [idFood], [count]) VALUES (5, 7, 3)
INSERT INTO BillInfo ([idBill], [idFood], [count]) VALUES (5, 8, 1)
INSERT INTO BillInfo ([idBill], [idFood], [count]) VALUES (6, 9, 2)
INSERT INTO BillInfo ([idBill], [idFood], [count]) VALUES (7, 10, 1)
INSERT INTO BillInfo ([idBill], [idFood], [count]) VALUES (9, 1, 1)
INSERT INTO BillInfo ([idBill], [idFood], [count]) VALUES (9, 2, 1)
GO
