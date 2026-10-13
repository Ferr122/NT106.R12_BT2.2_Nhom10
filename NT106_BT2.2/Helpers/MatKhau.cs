using System;
using System.Security.Cryptography;

namespace NT106_BT2._2.Helpers
{
    public static class MatKhau
    {
        private const int VONG_LAP = 600_000;

        // Gọi khi đăng ký: tạo salt ngẫu nhiên và băm PBKDF2-HMAC-SHA256
        public static (string Salt, string Bam) Tao(string matKhau)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            byte[] bam = Rfc2898DeriveBytes.Pbkdf2(
                matKhau, salt, VONG_LAP, HashAlgorithmName.SHA256, 32);
            return (Convert.ToBase64String(salt), Convert.ToBase64String(bam));
        }

        // Gọi khi đăng nhập: băm lại mật khẩu với salt lưu rồi dùng FixedTimeEquals
        public static bool KiemTra(string matKhau, string saltLuu, string bamLuu)
        {
            byte[] salt = Convert.FromBase64String(saltLuu);
            byte[] bamCu = Convert.FromBase64String(bamLuu);
            byte[] bamMoi = Rfc2898DeriveBytes.Pbkdf2(
                matKhau, salt, VONG_LAP, HashAlgorithmName.SHA256, 32);
            return CryptographicOperations.FixedTimeEquals(bamCu, bamMoi);
        }
    }
}
