
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'QuanLyNguoiDung')
BEGIN
    CREATE DATABASE QuanLyNguoiDung;
END
GO

USE QuanLyNguoiDung;
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
BEGIN
    CREATE TABLE Users (
        UserId INT IDENTITY(1,1) PRIMARY KEY,
        TenDangNhap NVARCHAR(20) NOT NULL UNIQUE,
        MatKhauBam NVARCHAR(64) NOT NULL,
        Salt NVARCHAR(32) NOT NULL,
        HoTen NVARCHAR(50) NOT NULL,
        SoDienThoai NVARCHAR(15) NULL,
        Email NVARCHAR(100) NULL,
        NgayTao DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
        LanDangNhapCuoi DATETIME2 NULL
    );
END
GO

INSERT INTO Users (TenDangNhap, MatKhauBam, Salt, HoTen, Email)
VALUES (
    N'admin', 
    N'dGhpcyBpcyBhIHNhbXBsZSBoYXNoIHZhbHVlIGZvciB0ZXN0aW5n', 
    N'c2FtcGxlX3NhbHRfdmFs', 
    N'Quản trị viên', 
    N'admin@example.com'
);
GO

SELECT * FROM Users;
GO