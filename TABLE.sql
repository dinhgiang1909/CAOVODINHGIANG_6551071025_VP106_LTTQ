CREATE DATABASE DuLieu;
GO
USE DuLieu;
GO

CREATE TABLE SanPham (
    MaSanPham  NVARCHAR(10)  PRIMARY KEY,
    TenSanPham NText NOT NULL,
    GiaBan   NVARCHAR(12) NOT NULL
);
GO

INSERT INTO SanPham (MaSanPham, TenSanPham, GiaBan) VALUES
(N'SP001', N'Nước Khoáng', 10000),
(N'SP002', N'Sữa tươi', 25000),
(N'SP003', N'Gạo tẻ thơm', 45000),
(N'SP004', N'Bánh quy', 30000),
(N'SP005', N'Dầu ăn', 65000);
GO


