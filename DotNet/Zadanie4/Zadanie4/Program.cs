using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalFilePath = "path_to_your_original_file.txt";
            string encryptedFilePath = "path_to_save_encrypted_file.txt";
            string decryptedFilePath = "path_to_save_decrypted_file.txt";

            // Generowanie kluczy RSA
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                try
                {
                    // Eksportowanie kluczy
                    string publicKey = rsa.ToXmlString(false); // Public key
                    string privateKey = rsa.ToXmlString(true); // Private key

                    // Read original file
                    byte[] originalData = File.ReadAllBytes(originalFilePath);

                    // Encrypt data
                    byte[] encryptedData = EncryptData(originalData, publicKey);
                    File.WriteAllBytes(encryptedFilePath, encryptedData);
                    Console.WriteLine("Dane zostały enkryptowane i zapisane do " + encryptedFilePath);

                    // Decrypt data
                    byte[] decryptedData = DecryptData(encryptedData, privateKey);
                    File.WriteAllBytes(decryptedFilePath, decryptedData);
                    Console.WriteLine("Dane zostały dekryptowane i zapisane do " + decryptedFilePath);
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        public static byte[] EncryptData(byte[] data, string publicKey)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                try
                {
                    rsa.FromXmlString(publicKey);
                    return rsa.Encrypt(data, true);
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        public static byte[] DecryptData(byte[] data, string privateKey)
        {
            using (var rsa = new RSACryptoServiceProvider())
            {
                try
                {
                    rsa.FromXmlString(privateKey);
                    return rsa.Decrypt(data, true);
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }
    }
}