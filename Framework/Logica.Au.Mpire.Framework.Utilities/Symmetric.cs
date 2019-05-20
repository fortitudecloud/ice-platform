using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Logica.Au.Mpire.Framework.Utilities
{
    public class Symmetric
    {
        private static string PASS = "BF7EBBC5-7B17-48D2-8CFF-E9AD3A6BF5C9";
        private static string SALT = "D034C09C-84CE-4E23-9C96-531E95D1496D";

        public static string Encrypt(string input, string salt)
        {
            SALT = salt;
            return Symmetric.Encrypt(input);
        }

        public static string Decrypt(string input, string salt)
        {
            SALT = salt;
            return Symmetric.Decrypt(input);
        }

        public static string Encrypt(string input)
        {
            // Test data

            byte[] utfdata = UTF8Encoding.UTF8.GetBytes(input);
            byte[] saltBytes = UTF8Encoding.UTF8.GetBytes(Symmetric.SALT);

            // We're using the PBKDF2 standard for password-based key generation
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(Symmetric.PASS, saltBytes, 1000);

            // Our symmetric encryption algorithm
            AesManaged aes = new AesManaged();
            aes.BlockSize = aes.LegalBlockSizes[0].MaxSize;
            aes.KeySize = aes.LegalKeySizes[0].MaxSize;
            aes.Key = rfc.GetBytes(aes.KeySize / 8);
            aes.IV = rfc.GetBytes(aes.BlockSize / 8);

            // Encryption
            ICryptoTransform encryptTransf = aes.CreateEncryptor();

            // Output stream, can be also a FileStream
            MemoryStream encryptStream = new MemoryStream();
            CryptoStream encryptor = new CryptoStream(encryptStream, encryptTransf, CryptoStreamMode.Write);
            encryptor.Write(utfdata, 0, utfdata.Length);
            encryptor.Flush();
            encryptor.Close();

            // Showing our encrypted content
            byte[] encryptBytes = encryptStream.ToArray();
            string encryptedString = Convert.ToBase64String(encryptBytes);

            // Close stream
            encryptStream.Close();

            // Return encrypted text
            return encryptedString;
        }

        public static string Decrypt(string base64Input)
        {
            // Get inputs as bytes
            byte[] encryptBytes = Convert.FromBase64String(base64Input);
            byte[] saltBytes = Encoding.UTF8.GetBytes(Symmetric.SALT);

            // We're using the PBKDF2 standard for password-based key generation
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(Symmetric.PASS, saltBytes);

            // Our symmetric encryption algorithm
            AesManaged aes = new AesManaged();
            aes.BlockSize = aes.LegalBlockSizes[0].MaxSize;
            aes.KeySize = aes.LegalKeySizes[0].MaxSize;
            aes.Key = rfc.GetBytes(aes.KeySize / 8);
            aes.IV = rfc.GetBytes(aes.BlockSize / 8);

            // Now, decryption
            ICryptoTransform decryptTrans = aes.CreateDecryptor();

            // Output stream, can be also a FileStream
            MemoryStream decryptStream = new MemoryStream();
            CryptoStream decryptor = new CryptoStream(decryptStream, decryptTrans, CryptoStreamMode.Write);
            decryptor.Write(encryptBytes, 0, encryptBytes.Length);
            decryptor.Flush();
            decryptor.Close();

            // Showing our decrypted content
            byte[] decryptBytes = decryptStream.ToArray();
            string decryptedString = UTF8Encoding.UTF8.GetString(decryptBytes, 0, decryptBytes.Length);

            // Close Stream
            decryptStream.Close();

            // Return decrypted text
            return decryptedString;
        }
    }
}
