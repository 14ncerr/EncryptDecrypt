using System;

namespace EncryptDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "attack at dawn";
            string key = "lemon";

            Console.WriteLine(Vigenere.Encrypt(str, key));
            str = Vigenere.Encrypt(str, key);
            Console.WriteLine(Vigenere.Decrypt(str, key));
        }
    }
}
