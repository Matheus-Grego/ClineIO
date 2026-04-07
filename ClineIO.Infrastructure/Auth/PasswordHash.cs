using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

namespace ClineIO.Infrastructure.Auth;

public static class PasswordHash
{
    public static string HashPassword(string password)
    {
        using (var hash = SHA256.Create())
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            var hashedBytes = hash.ComputeHash(bytes);
            var builder = new StringBuilder();
            for (var i = 0; i < hashedBytes.Length; i++)
            {
                builder.Append(hashedBytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
    
}