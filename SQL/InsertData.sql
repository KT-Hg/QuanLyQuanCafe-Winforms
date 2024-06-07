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
INSERT INTO FoodCategory ([name]) VALUES (N'Đồ uống nóng')
INSERT INTO FoodCategory ([name]) VALUES (N'Đồ uống lạnh')
INSERT INTO FoodCategory ([name]) VALUES (N'Món chính')
GO

-- Thêm dữ liệu vào bảng Food
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Cà phê sữa', 1, 25000)
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Sinh tố xoài', 1, 30000)
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Bánh mì kẹp thịt', 2, 50000)
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Bánh ngọt', 3, 20000)
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Trá cà phê', 4, 20000)
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Trá xanh', 4, 15000)
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Nước cam', 5, 25000)
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Nước ép táo', 5, 30000)
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Phở bò', 6, 45000)
INSERT INTO Food ([name], [idCategory], [price]) VALUES (N'Cơm gà', 6, 50000)
GO

-- Thêm dữ liệu vào bảng Bill
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-01', '2023-05-01', 1, 1)
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-02', '2023-05-02', 2, 1)
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-03', '2023-05-03', 3, 1)
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-04', '2023-05-04', 4, 1)
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-05', '2023-05-05', 5, 1)
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-06', '2023-05-06', 6, 1)
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-07', '2023-05-07', 7, 1)
INSERT INTO Bill ([dateCheckIn], [dateCheckOut], [idTable], [status]) VALUES ('2023-05-08', '2023-05-08', 8, 1)
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
INSERT INTO BillInfo ([idBill], [idFood], [count]) VALUES (7, 11, 1)
INSERT INTO BillInfo ([idBill], [idFood], [count]) VALUES (8, 12, 3)
INSERT INTO BillInfo ([idBill], [idFood], [count]) VALUES (9, 1, 1)
INSERT INTO BillInfo ([idBill], [idFood], [count]) VALUES (9, 2, 1)
GO
