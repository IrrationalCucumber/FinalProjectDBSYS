using System;
using System.IO;
using System.Security.Cryptography;

public static class Encryption
{
    private static readonly byte[] EncryptionKey = { 0x25, 0x5A, 0x19, 0x61, 0x2F, 0x3C, 0x17, 0x95, 0x7B, 0x4E, 0x09, 0x3D, 0x5F, 0x62, 0x6D, 0x38 };
    private static readonly byte[] IV = { 0x58, 0x3E, 0x1D, 0x7F, 0x14, 0x3C, 0x71, 0x9C, 0x2E, 0x6F, 0x1A, 0x6B, 0x4F, 0x36, 0x2D, 0x1E };

    public static string Encrypt(string plainText)
    {
        byte[] encryptedBytes;

        using (Aes aes = Aes.Create())
        {
            aes.Key = EncryptionKey;
            aes.IV = IV;

            ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                using (StreamWriter writer = new StreamWriter(cs))
                {
                    writer.Write(plainText);
                }

                encryptedBytes = ms.ToArray();
            }
        }

        return Convert.ToBase64String(encryptedBytes);
    }

    public static string Decrypt(string encryptedText)
    {
        byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
        string decryptedText;

        using (Aes aes = Aes.Create())
        {
            aes.Key = EncryptionKey;
            aes.IV = IV;

            ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

            using (MemoryStream ms = new MemoryStream(encryptedBytes))
            using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
            using (StreamReader reader = new StreamReader(cs))
            {
                decryptedText = reader.ReadToEnd();
            }
        }

        return decryptedText;
    }
}
