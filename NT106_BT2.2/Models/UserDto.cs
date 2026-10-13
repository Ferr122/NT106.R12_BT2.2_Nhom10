using System;

namespace NT106_BT2._2.Models
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string TenDangNhap { get; set; } = string.Empty;
        public string MatKhauBam { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public string HoTen { get; set; } = string.Empty;
        public string? SoDienThoai { get; set; }
        public string? Email { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime? LanDangNhapCuoi { get; set; }
    }
}
