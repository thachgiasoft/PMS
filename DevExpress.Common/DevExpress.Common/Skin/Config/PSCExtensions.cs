using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.IO;
namespace DevExpress.Common.Config
{
    public static class PSCExtensions
    {
        // Fields
        private static readonly byte[] initVectorBytes = Encoding.ASCII.GetBytes("tu89geji340t89u2");
        private const int keysize = 0x100;

        // Methods
        public static string DecodeString(this string cipherText)
        {
            cipherText = cipherText.PSCDecryptPasswordInString("aquafina@1163", 2);
            return cipherText;
        }

        public static string PSCDecrypt(this string cipherText, string passPhrase)
        {
            string str;
            if (cipherText.Contains(@"rce=.\SQLEXPRESS"))
            {
                return cipherText;
            }
            cipherText = cipherText.Replace('_', '+');
            cipherText = cipherText.Replace('-', '/');
            cipherText = cipherText.Replace('$', '=');
            byte[] buffer = Convert.FromBase64String(cipherText);
            byte[] bytes = new PasswordDeriveBytes(passPhrase, null).GetBytes(0x20);
            using (RijndaelManaged managed = new RijndaelManaged())
            {
                managed.Mode = CipherMode.CBC;
                using (ICryptoTransform transform = managed.CreateDecryptor(bytes, initVectorBytes))
                {
                    using (MemoryStream stream = new MemoryStream(buffer))
                    {
                        using (CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read))
                        {
                            byte[] buffer3 = new byte[buffer.Length];
                            int count = stream2.Read(buffer3, 0, buffer3.Length);
                            str = Encoding.UTF8.GetString(buffer3, 0, count);
                        }
                    }
                }
            }
            return str;
        }

        public static string PSCDecryptPasswordInString(this string cipherText, string passPhrase, int EncryptionMode)
        {
            switch (EncryptionMode)
            {
                case 0:
                    return cipherText;

                case 1:
                    {
                        int startIndex = cipherText.IndexOf("password", StringComparison.CurrentCultureIgnoreCase) + "password".Length;
                        int index = cipherText.IndexOf(';', startIndex);
                        if (index == -1)
                        {
                            index = cipherText.Length;
                        }
                        string oldValue = cipherText.Substring(startIndex, index - startIndex).Trim().Substring(1).Trim();
                        cipherText = cipherText.Replace(oldValue, oldValue.PSCDecrypt(passPhrase));
                        return cipherText;
                    }
                case 2:
                    cipherText = cipherText.PSCDecrypt(passPhrase);
                    return cipherText;
            }
            return cipherText;
        }

        public static string PSCEncrypt(this string plainText, string passPhrase)
        {
            string str2;
            byte[] bytes = Encoding.UTF8.GetBytes(plainText);
            byte[] rgbKey = new PasswordDeriveBytes(passPhrase, null).GetBytes(0x20);
            using (RijndaelManaged managed = new RijndaelManaged())
            {
                managed.Mode = CipherMode.CBC;
                using (ICryptoTransform transform = managed.CreateEncryptor(rgbKey, initVectorBytes))
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        using (CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write))
                        {
                            stream2.Write(bytes, 0, bytes.Length);
                            stream2.FlushFinalBlock();
                            str2 = Convert.ToBase64String(stream.ToArray()).Replace('+', '_').Replace('/', '-').Replace('=', '$');
                        }
                    }
                }
            }
            return str2;
        }
    }
}
