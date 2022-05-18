using System;
using System.Security.Cryptography;

namespace Utils
{
    public class Cryptography
    {
        public static string HashString(string str)
        {
            HashAlgorithm sha = new SHA1CryptoServiceProvider();
            byte[] buf = new byte[str.Length];
            for (int i = 0; i < str.Length; i++)
                buf[i] = (byte)str[i];
            byte[] result = sha.ComputeHash(buf);
            return Convert.ToBase64String(result);
        }
    }
}
