using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyIphone
{
    /// <summary>
    /// Class that contains several utility methods
    /// </summary>
    public class Utils
    {

        /// <summary>
        /// Encrypts the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static string Encrypt(string text)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(text);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// <summary>
        /// Decrypts the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static string Decrypt(string text)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(text);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
