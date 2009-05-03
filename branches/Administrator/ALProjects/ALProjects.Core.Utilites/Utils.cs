using System;
using System.Security.Cryptography;
using System.Text;

namespace ALProjects.Core
{
    public static class Utils
    {
        /// <summary>
        /// Calculate MD5 hash string
        /// </summary>
        /// <param name="input">Value for hashing</param>
        /// <returns>Hashed value</returns>
        public static String CalculateMD5Hash(String input)
        {
            byte[] tmpSource = Encoding.ASCII.GetBytes(input);
            byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            var output = new StringBuilder(tmpHash.Length);
            for (int i = 0; i < tmpHash.Length; i++)
            {
                output.Append(tmpHash[i].ToString("X2"));
            }
            return output.ToString();
        }
    }
}
