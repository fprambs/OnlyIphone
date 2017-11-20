using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

        /// <summary>
        /// Firsts the letter to upeer.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static string FirstLetterToUpeer(string text)
        {
             text = text.ToLower().Trim();
             text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());
             return text;
 
        }

        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
        }

        public static bool ComprobarFormatoEmail(string email)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, sFormato))
            {
                if (Regex.Replace(email, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
