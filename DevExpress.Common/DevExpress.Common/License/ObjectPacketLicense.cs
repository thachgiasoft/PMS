using System;
using System.IO;

namespace DevExpress.Common.License
{
    public class ObjectPacketLicense : ObjectEncryptor
    {
        private string _fileName;
        public ObjectPacketLicense(string fileName)
        {
            _fileName = fileName;
        }

        /// <summary>
        /// protected virtual void WriteFile(string data, Version version, AlgorithmType algType, AlgorithmKeyType algKeyType)
        /// </summary>
        /// <param name="data"></param>
        /// <param name="version"></param>
        /// <param name="algType"></param>
        /// <param name="algKeyType"></param>
        protected virtual void WriteFile(string data, Version version, AlgorithmType algType, AlgorithmKeyType algKeyType)
        {
            using (FileStream f = new FileStream(_fileName, FileMode.Create))
            {
                using (BinaryWriter w = new BinaryWriter(f))
                {
                    try
                    {
                        w.Write((Int16)5);
                        w.Write((byte)version);
                        w.Write(Convert.ToByte((int)algType));
                        w.Write(Convert.ToByte((int)algKeyType));
                        w.Write(data);
                        w.Flush();
                    }
                    catch (IOException e)
                    {
                        throw e;
                    }
                    finally
                    {
                        w.Close();
                        f.Close();
                    }
                }
            }
        }

        /// <summary>
        /// protected virtual void WriteFile(string secretKey, string data, Version version, Encryptor encryptor, AlgorithmType algType, AlgorithmKeyType algKeyType)
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="data"></param>
        /// <param name="version"></param>
        /// <param name="encryptor"></param>
        /// <param name="algType"></param>
        /// <param name="algKeyType"></param>
        protected virtual void WriteFile(string secretKey, string data, Version version, Encryptor encryptor, AlgorithmType algType, AlgorithmKeyType algKeyType)
        {
            using (FileStream f = new FileStream(_fileName, FileMode.Create))
            {
                using (BinaryWriter w = new BinaryWriter(f))
                {
                    try
                    {
                        w.Write((Int16)5);
                        w.Write((byte)version);
                        w.Write(Convert.ToByte((int)algType));
                        w.Write(Convert.ToByte((int)algKeyType));
                        w.Write(encryptor.ObjectCryptography(data, TransformType.ENCRYPT));
                        w.Flush();
                    }
                    catch (IOException e)
                    {
                        throw e;
                    }
                    finally
                    {
                        w.Close();
                        f.Close();
                    }
                }
            }
        }

        /// <summary>
        /// protected virtual string ReadFile(Int16 lHeader, Version version, out AlgorithmType algType, out AlgorithmKeyType algKeyType)
        /// </summary>
        /// <param name="lHeader"></param>
        /// <param name="version"></param>
        /// <param name="algType"></param>
        /// <param name="algKeyType"></param>
        /// <returns></returns>
        protected virtual string ReadFile(Int16 lHeader, Version version, out AlgorithmType algType, out AlgorithmKeyType algKeyType)
        {
            using (FileStream f = new FileStream(_fileName, FileMode.Open))
            {
                using (BinaryReader r = new BinaryReader(f))
                {
                    string value = null;
                    algType = 0;
                    algKeyType = 0;
                    try
                    {
                        if (r.ReadInt16() == lHeader && r.ReadByte() == (byte)version)
                        {
                            algType = (AlgorithmType)r.ReadByte();
                            algKeyType = (AlgorithmKeyType)r.ReadByte();
                            value = r.ReadString();
                        }
                    }
                    catch (IOException e)
                    {
                        throw e;
                    }
                    finally
                    {
                        r.Close();
                        f.Close();
                    }
                    return value;
                }
            }
        }

        /// <summary>
        /// public virtual string ReadLicense(string secretKey, Version version)
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public virtual string ReadLicense(string secretKey, Version version)
        {
            AlgorithmType algType;
            AlgorithmKeyType algKeyType;
            string value = null;
            string data = ReadFile(5, version, out algType, out algKeyType);
            if (data != null)
            {
                switch (algType)
                {
                    case AlgorithmType.DES:
                        try
                        {
                            Encryptor = new AlgorithmDES(secretKey, algKeyType);
                            value = Encryptor.ObjectCryptography(data, TransformType.DECRYPT);
                        }
                        catch (Exception e) { throw e; }
                        break;
                    case AlgorithmType.Rijndael:
                        try
                        {
                            Encryptor = new AlgorithmRijndael(secretKey, algKeyType);
                            value = Encryptor.ObjectCryptography(data, TransformType.DECRYPT);
                        }
                        catch (Exception e) { throw e; }
                        break;
                    case AlgorithmType.TripleDES:
                        try
                        {
                            Encryptor = new AlgorithmTripleDES(secretKey, algKeyType);
                            value = Encryptor.ObjectCryptography(data, TransformType.DECRYPT);
                        }
                        catch (Exception e) { throw e; }
                        break;
                    case AlgorithmType.None:
                        value = data;
                        break;
                    default:
                        break;
                }
            }
            return value;
        }
        
        /// <summary>
        /// public virtual void SaveLicense(string secretKey, string data, Version version, AlgorithmType algType, AlgorithmKeyType algKeyType)
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="data"></param>
        /// <param name="version"></param>
        /// <param name="algType"></param>
        /// <param name="algKeyType"></param>
        public virtual void SaveLicense(string secretKey, string data, Version version, AlgorithmType algType, AlgorithmKeyType algKeyType)
        {
            switch (algType)
            {
                case AlgorithmType.DES:
                    try
                    {
                        Encryptor = new AlgorithmDES(secretKey, algKeyType);
                        WriteFile(secretKey, data, version, Encryptor, AlgorithmType.DES, algKeyType);
                    }
                    catch {
                        return;
                    }
                    break;
                case AlgorithmType.Rijndael:
                    try
                    {
                        Encryptor = new AlgorithmRijndael(secretKey, algKeyType);
                        WriteFile(secretKey, data, version, Encryptor, AlgorithmType.Rijndael, algKeyType);
                    }
                    catch {
                        return;
                    }
                    break;
                case AlgorithmType.TripleDES:
                    try
                    {
                        Encryptor = new AlgorithmTripleDES(secretKey, algKeyType);
                        WriteFile(secretKey, data, version, Encryptor, AlgorithmType.TripleDES, algKeyType);
                    }
                    catch {
                        return;
                    }
                    break;
                case AlgorithmType.None:
                    try
                    {
                        WriteFile(data, version, AlgorithmType.None, AlgorithmKeyType.None);
                    }
                    catch {
                        return;
                    }
                    break;
            }
        }

        /// <summary>
        /// public void CreateLicense(string secretKey, string ID, Version version)
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="ID"></param>
        /// <param name="version"></param>
        public void CreateLicense(string secretKey, string ID, Version version)
        {
            try
            {
                SaveLicense(secretKey, ID.Trim(), version, AlgorithmType.Rijndael, AlgorithmKeyType.SHA512);
            }
            catch {
                return;
            }
        }

        /// <summary>
        /// public bool IsRegister(string secretKey, string ID, Version version)
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="ID"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public bool IsRegister(string secretKey, string ID, Version version)
        {
            if (string.Compare(ID.Trim(), this.ReadLicense(secretKey, version).Trim()) == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// public bool IsRegister(string ProductID, string ProductKey)
        /// </summary>
        /// <param name="ProductID"></param>
        /// <param name="ProductKey"></param>
        /// <returns></returns>
        public bool IsRegister(string ProductID, string ProductKey)
        {
            if (string.Compare(ProductID.Trim(), ProductKey.Trim()) == 0)
                return true;
            else
                return false;
        }
    }
}
