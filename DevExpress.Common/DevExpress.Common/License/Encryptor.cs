using System;
using System.Text;
using System.Security.Cryptography;

namespace DevExpress.Common.License
{
    public abstract class Encryptor
    {
        public Encryptor(string secretKey, AlgorithmKeyType AlgType)
        {
            GenerateKey(secretKey, AlgType);
        }

        /// <summary>
        /// public string ObjectCryptography(string data, TransformType type)
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public string ObjectCryptography(string data, TransformType type)
        {
            string value = null;
            try
            {
                if (data.Length > 0)
                {
                    switch (type)
                    {
                        case TransformType.ENCRYPT:
                            byte[] bEncrypt = Encoding.UTF8.GetBytes(data);
                            value = Convert.ToBase64String(Transform(bEncrypt, TransformType.ENCRYPT));
                            break;
                        case TransformType.DECRYPT:
                            byte[] bDecrypt = Convert.FromBase64String(data);
                            value = Encoding.UTF8.GetString(Transform(bDecrypt, TransformType.DECRYPT));
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (CryptographicException e) { throw e; }
            return value;
        }

        /// <summary>
        /// public byte[] ObjectCryptography(byte[] data, TransformType type)
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public byte[] ObjectCryptography(byte[] data, TransformType type)
        {
            byte[] value = null;
            try
            {
                if (data != null && data.Length > 0)
                {
                    switch (type)
                    {
                        case TransformType.ENCRYPT:
                            value = Transform(data, TransformType.ENCRYPT);
                            break;
                        case TransformType.DECRYPT:
                            value = Transform(data, TransformType.DECRYPT);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (CryptographicException e) { throw e; }
            return value;
        }

        /// <summary>
        /// public string Encrypt(string data)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string Encrypt(string data)
        {
            try
            {
                if (data.Length > 0)
                {
                    byte[] b = Encoding.UTF8.GetBytes(data);
                    return Convert.ToBase64String(Transform(b, TransformType.ENCRYPT));
                }
                else
                    return null;
            }
            catch (CryptographicException e) { throw e; }
        }

        /// <summary>
        /// public string Decrypt(string data)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string Decrypt(string data)
        {
            try
            {
                if (data.Length > 0)
                {
                    byte[] b = Convert.FromBase64String(data);
                    return Encoding.UTF8.GetString(Transform(b, TransformType.DECRYPT));
                }
                else
                    return null;
            }
            catch (CryptographicException e) { throw e; }
        }

        public abstract void GenerateKey(string secretKey, AlgorithmKeyType type);
        public abstract byte[] Transform(byte[] data, TransformType type);
    }
}
