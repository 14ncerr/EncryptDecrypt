using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDecrypt
{
    public abstract class Vigenere
    {
        public static string Encrypt(string input, string key)
        {
            string EnglishAlph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            input = input.ToUpper();
            key = key.ToUpper();
            var sb = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!(char.IsLetter(input[i])))
                {
                    sb.Append(input[i]);
                    counter++;
                }
                else
                {
                    var inputCharIndex = EnglishAlph.IndexOf(input[i]);
                    var keyIndex = (i - counter) % key.Length;
                    var decryptedChar = EnglishAlph[(inputCharIndex + EnglishAlph.IndexOf(key[keyIndex]))
                        % EnglishAlph.Length];
                    sb.Append(decryptedChar);
                }
            }
            return sb.ToString(); ;
        }

        public static string Decrypt(string input, string key)
        {
            string EnglishAlph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            input = input.ToUpper();
            key = key.ToUpper();
            var sb = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!(char.IsLetter(input[i])))
                {
                    sb.Append(input[i]);
                    counter++;
                }
                else
                {
                    var inputCharIndex = EnglishAlph.IndexOf(input[i]);
                    var keyIndex = (i - counter) % key.Length;
                    var decryptedChar = EnglishAlph[(inputCharIndex + EnglishAlph.Length - EnglishAlph.IndexOf(key[keyIndex])) 
                        % EnglishAlph.Length];
                    sb.Append(decryptedChar);
                }
            }
            return sb.ToString();
        }

    }
}
