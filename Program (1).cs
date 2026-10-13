using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace QuanLyNguoiDungApp
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string TenDangNhap { get; set; } = string.Empty;
        public string MatKhauBam { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public string HoTen { get; set; } = string.Empty;
        public string? Email { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime? LanDangNhapCuoi { get; set; }
    }

    public class UserRepository
    {
        private const string ChuoiKetNoi = 
            @"Server=localhost\SQLEXPRESS;Database=QuanLyNguoiDung;Trusted_Connection=True;TrustServerCertificate=True;";

        private async Task<SqlConnection> TaoKetNoiAsync()
        {
            var conn = new SqlConnection(ChuoiKetNoi);
            await conn.OpenAsync();
            return conn;
        }

        public async Task<bool> KiemTraTenDangNhapTonTaiAsync(string tenDangNhap)
        {
            const string sql = "SELECT COUNT(1) FROM Users WHERE TenDangNhap = @ten";

            using var conn = await TaoKetNoiAsync();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;

            var result = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(result) > 0;
        }

        public async Task<bool> ThemNguoiDungAsync(string tenDangNhap, string matKhauBam, string salt, string hoTen, string? email)
        {
            const string sql = @"
                INSERT INTO Users (TenDangNhap, MatKhauBam, Salt, HoTen, Email)
                VALUES (@ten, @matKhauBam, @salt, @hoTen, @email);";

            using var conn = await TaoKetNoiAsync();
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;
            cmd.Parameters.Add("@matKhauBam", SqlDbType.NVarChar, 64).Value = matKhauBam;
            cmd.Parameters.Add("@salt", SqlDbType.NVarChar, 32).Value = salt;
            cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar, 50).Value = hoTen;
            
            if (string.IsNullOrWhiteSpace(email))
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = email.Trim();

            int rowsAffected = await cmd.ExecuteNonQueryAsync();
            return rowsAffected > 0;
        }
        
        public async Task<UserDto?> LayNguoiDungTheoTenDangNhapAsync(string tenDangNhap)
        {
            const string sql = @"
                SELECT UserId, TenDangNhap, MatKhauBam, Salt, HoTen, Email, NgayTao, LanDangNhapCuoi
                FROM Users 
                WHERE TenDangNhap = @ten";

            using var conn = await TaoKetNoiAsync();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;

            using var reader = await cmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                return new UserDto
                {
                    UserId = reader.GetInt32(reader.GetOrdinal("UserId")),
                    TenDangNhap = reader.GetString(reader.GetOrdinal("TenDangNhap")),
                    MatKhauBam = reader.GetString(reader.GetOrdinal("MatKhauBam")),
                    Salt = reader.GetString(reader.GetOrdinal("Salt")),
                    HoTen = reader.GetString(reader.GetOrdinal("HoTen")),
                    Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? null : reader.GetString(reader.GetOrdinal("Email")),
                    NgayTao = reader.GetDateTime(reader.GetOrdinal("NgayTao")),
                    LanDangNhapCuoi = reader.IsDBNull(reader.GetOrdinal("LanDangNhapCuoi")) 
                                      ? null 
                                      : reader.GetDateTime(reader.GetOrdinal("LanDangNhapCuoi"))
                };
            }

            return null; 
        }

        public async Task CapNhatLanDangNhapCuoiAsync(string tenDangNhap)
        {
            const string sql = "UPDATE Users SET LanDangNhapCuoi = SYSDATETIME() WHERE TenDangNhap = @ten";

            using var conn = await TaoKetNoiAsync();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;

            await cmd.ExecuteNonQueryAsync();
        }
    }
}