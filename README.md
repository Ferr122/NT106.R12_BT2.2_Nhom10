# NT106.R12 - Bài tập 2.2 - Nhóm 10

Ứng dụng Windows Forms quản lý người dùng với SQL Server: Đăng nhập, Đăng ký và Trang chủ.

# Các thành viên:

## 👥 Danh sách thành viên

| STT | MSSV | Họ và tên | Phân công dự kiến |
|:---:|---|---|---|
| 1 | 25521671 | Đoàn Hữu Thắng | Tổng hợp, kiểm thử, chạy demo và viết báo cáo |
| 2 | 25521758 | Chung Quốc Thịnh | Database |
| 3 | 25520903 | Ngô Hoàng Minh Khôi | Form Đăng nhập |
| 4 | 25520374 | Nguyễn Tuấn Dũng | Form Trang Chính |
| 5 | 25521016 | Ngô Tấn Lộc | Form Đăng kí |

## Cấu trúc Project

```text
NT106.R12_BT2.2_Nhom10/
├── NT106.R12_BT2.2_Nhom10.sln   # Solution chính
├── .gitignore                    # Lọc file
├── README.md
└── NT106_BT2.2/                 # Project
    ├── Database/
    │   ├── SQLQuery1.sql        # Script tạo Database & Table Users
    │   └── UserRepository.cs    # Thao tác CSDL (ADO.NET / Microsoft.Data.SqlClient)
    ├── Forms/
    │   ├── FrmDangNhap.cs       # Form Đăng nhập & logic xác thực
    │   ├── FrmDangKy.cs         # Form Đăng ký & kiểm tra ràng buộc nhập liệu
    │   └── FrmChinh.cs          # Form Trang chính hiển thị sau khi đăng nhập
    ├── Helpers/
    │   └── MatKhau.cs           # Mã hóa băm SHA256 kèm Salt bảo mật
    ├── Models/
    │   └── UserDto.cs           # Mô hình dữ liệu User
    └── Program.cs               # Entry point khởi chạy ứng dụng
```

## Hướng dẫn chạy

1. **Chuẩn bị CSDL:**
   - Mở SQL Server Management Studio (SSMS).
   - Chạy script trong file [SQLQuery1.sql](NT106_BT2.2/Database/SQLQuery1.sql) để tạo database `QuanLyNguoiDung` và bảng `Users`.
   - Cấu hình chuỗi kết nối trong [UserRepository.cs](NT106_BT2.2/Database/UserRepository.cs) nếu cần (`Server=localhost\SQLEXPRESS;...`).

2. **Chạy ứng dụng:**
   - Mở solution `NT106.R12_BT2.2_Nhom10.sln` bằng Visual Studio 2022/2026 hoặc gõ lệnh:
     ```bash
     dotnet run --project NT106_BT2.2/NT106_BT2.2.csproj
     ```
