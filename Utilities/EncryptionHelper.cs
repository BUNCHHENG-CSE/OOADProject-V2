using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class EncryptionHelper
{
    private static readonly string encryptionKey = "iamnobody";

    public static void EncryptToFile(string path, string plainText, string password)
    {
        using FileStream fs = new(path, FileMode.Create, FileAccess.Write);
        using Aes aes = Aes.Create();

        var key = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes("salt1234"), 10000);
        aes.Key = key.GetBytes(32);
        aes.IV = key.GetBytes(16);

        using CryptoStream cs = new(fs, aes.CreateEncryptor(), CryptoStreamMode.Write);
        using StreamWriter writer = new(cs);
        writer.Write(plainText);
    }

    public static string DecryptFromFile(string path, string password)
    {
        using FileStream fs = new(path, FileMode.Open, FileAccess.Read);
        using Aes aes = Aes.Create();

        var key = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes("salt1234"), 10000);
        aes.Key = key.GetBytes(32);
        aes.IV = key.GetBytes(16);

        using CryptoStream cs = new(fs, aes.CreateDecryptor(), CryptoStreamMode.Read);
        using StreamReader reader = new(cs);
        return reader.ReadToEnd();
    }


}
