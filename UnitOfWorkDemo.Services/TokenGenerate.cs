using System.Security.Cryptography;

namespace PMS.Endpoints
{
    public class TokenGenerate
    {
        private static readonly Lazy<string> _lazyKey = new Lazy<string>(() => GenerateRandomKey(32));

        public static string SecretKey => _lazyKey.Value;

        private static string GenerateRandomKey(int keyLength)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] keyBytes = new byte[keyLength];
                rng.GetBytes(keyBytes);
                return Convert.ToBase64String(keyBytes);
            }
        }
    }
}
