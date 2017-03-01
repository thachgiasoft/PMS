using System;

namespace DevExpress.Common.License
{
    public class ObjectEncryptor
    {
        protected Encryptor Encryptor { get; set; }

        /// <summary>
        /// public virtual string ObjectCryptography(string secretKey, string data, TransformType type, AlgorithmType algType, AlgorithmKeyType algKeyType)
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="data"></param>
        /// <param name="type"></param>
        /// <param name="algType"></param>
        /// <param name="algKeyType"></param>
        /// <returns></returns>
        public virtual string ObjectCryptography(string secretKey, string data, TransformType type, AlgorithmType algType, AlgorithmKeyType algKeyType)
        {
            string value = null;
            switch (algType)
            {
                case AlgorithmType.DES:
                    Encryptor = new AlgorithmDES(secretKey, algKeyType);
                    value = Encryptor.ObjectCryptography(data, type);
                    break;
                case AlgorithmType.Rijndael:
                    Encryptor = new AlgorithmRijndael(secretKey, algKeyType);
                    value = Encryptor.ObjectCryptography(data, type);
                    break;
                case AlgorithmType.TripleDES:
                    Encryptor = new AlgorithmTripleDES(secretKey, algKeyType);
                    value = Encryptor.ObjectCryptography(data, type);
                    break;
                default:
                    break;
            }
            return value;
        }
    }
}
