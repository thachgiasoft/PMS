using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace DevExpress.Common.License
{
    //This algorithm supports a key length of 64 bits. Key=8 byte, IV=8 byte
    public class AlgorithmDES : Encryptor
    {
        public AlgorithmDES(string secretKey, AlgorithmKeyType AlgType)
            : base(secretKey, AlgType)
        {
        }

        private byte[] Key { get; set; }
        private byte[] IV { get; set; }

        /// <summary>
        /// public override void GenerateKey(string secretKey, AlgorithmKeyType type)
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="type"></param>
        public override void GenerateKey(string secretKey, AlgorithmKeyType type)
        {
            Key = new byte[8];
            IV = new byte[8];
            byte[] bKey = Encoding.UTF8.GetBytes(secretKey);
            switch (type)
            {
                case AlgorithmKeyType.MD5://16 byte
                    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                    {
                        md5.ComputeHash(bKey);
                        byte[] rmd5 = md5.Hash;
                        for (int i = 0; i < 8; i++)
                            Key[i] = rmd5[i];
                        for (int j = 15; j >= 8; j--)
                            IV[15 - j] = rmd5[j];
                    }
                    break;
                case AlgorithmKeyType.SHA1://20 byte
                    using (SHA1Managed sha1 = new SHA1Managed())
                    {
                        sha1.ComputeHash(bKey);
                        byte[] rsha1 = sha1.Hash;
                        for (int i = 0; i < 8; i++)
                            Key[i] = rsha1[i];
                        for (int j = 19; j > 11; j--)
                            IV[19 - j] = rsha1[j];
                    }
                    break;
                case AlgorithmKeyType.SHA256://32 byte
                    using (SHA256Managed sha256 = new SHA256Managed())
                    {
                        sha256.ComputeHash(bKey);
                        byte[] rsha256 = sha256.Hash;
                        for (int i = 0; i < 8; i++)
                            Key[i] = rsha256[i];
                        for (int j = 31; j >= 24; j--)
                            IV[31 - j] = rsha256[j];
                    }
                    break;
                case AlgorithmKeyType.SHA384://48 byte
                    using (SHA384Managed sha384 = new SHA384Managed())
                    {
                        sha384.ComputeHash(bKey);
                        byte[] rsha384 = sha384.Hash;
                        for (int i = 0; i < 8; i++)
                            Key[i] = rsha384[i];
                        for (int j = 47; j > 39; j--)
                            IV[47 - j] = rsha384[j];
                    }
                    break;
                case AlgorithmKeyType.SHA512://64 byte
                    using (SHA512Managed sha512 = new SHA512Managed())
                    {
                        sha512.ComputeHash(bKey);
                        byte[] rsha512 = sha512.Hash;
                        for (int i = 0; i < 8; i++)
                            Key[i] = rsha512[i];
                        for (int j = 63; j > 55; j--)
                            IV[63 - j] = rsha512[j];
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// public override byte[] Transform(byte[] data, TransformType type)
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public override byte[] Transform(byte[] data, TransformType type)
        {
            MemoryStream ms = null;
            CryptoStream cs = null;
            ICryptoTransform transform = null;
            DES des = DES.Create();
            try
            {
                ms = new MemoryStream();
                des.Key = Key;
                des.IV = IV;
                if (type == TransformType.ENCRYPT)
                    transform = des.CreateEncryptor();
                else
                    transform = des.CreateDecryptor();
                if (data != null && data.Length > 0)
                {
                    cs = new CryptoStream(ms, transform, CryptoStreamMode.Write);
                    cs.Write(data, 0, data.Length);
                    cs.FlushFinalBlock();
                    return ms.ToArray();
                }
                else
                    return null;
            }
            catch (CryptographicException e)
            {
                throw new CryptographicException(e.Message);
            }
            finally
            {
                if (des != null)
                    des.Clear();
                if (transform != null)
                    transform.Dispose();
                ms.Close();
            }
        }
    }
}
