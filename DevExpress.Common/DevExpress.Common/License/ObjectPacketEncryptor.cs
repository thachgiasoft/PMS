using System;
using System.IO;

namespace DevExpress.Common.License
{
    public class ObjectPacketEncryptor : ObjectEncryptor
    {
        private string _fileName;
        public ObjectPacketEncryptor(string _fileName)
        {
            this._fileName = _fileName;
        }

        /// <summary>
        /// public virtual byte[] OpenPacket(string secretKey, Version version)
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public virtual byte[] OpenPacket(string secretKey, Version version)
        {
            AlgorithmType algType;
            AlgorithmKeyType algKeyType;
            byte[] value = null;
            byte[] data = ReadFile(5, version, out algType, out algKeyType);
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
                        catch (Exception ex) { throw ex; }
                        break;
                    case AlgorithmType.Rijndael:
                        try
                        {
                            Encryptor = new AlgorithmRijndael(secretKey, algKeyType);
                            value = Encryptor.ObjectCryptography(data, TransformType.DECRYPT);
                        }
                        catch (Exception ex) { throw ex; }
                        break;
                    case AlgorithmType.TripleDES:
                        try
                        {
                            Encryptor = new AlgorithmTripleDES(secretKey, algKeyType);
                            value = Encryptor.ObjectCryptography(data, TransformType.DECRYPT);
                        }
                        catch (Exception ex) { throw ex; }
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
        /// protected virtual void WriteFile(string secretKey, byte[] data, Version version, Encryptor encryptor, AlgorithmType algType, AlgorithmKeyType algKeyType)
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="data"></param>
        /// <param name="version"></param>
        /// <param name="encryptor"></param>
        /// <param name="algType"></param>
        /// <param name="algKeyType"></param>
        protected virtual void WriteFile(string secretKey, byte[] data, Version version, Encryptor encryptor, AlgorithmType algType, AlgorithmKeyType algKeyType)
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
        /// protected virtual void WriteFile(byte[] data, Version version, AlgorithmType algType, AlgorithmKeyType algKeyType)
        /// </summary>
        /// <param name="data"></param>
        /// <param name="version"></param>
        /// <param name="algType"></param>
        /// <param name="algKeyType"></param>
        protected virtual void WriteFile(byte[] data, Version version, AlgorithmType algType, AlgorithmKeyType algKeyType)
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
        /// public virtual bool IsValidFormat(Int16 lHeader, Version version)
        /// </summary>
        /// <param name="lHeader"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public virtual bool IsValidFormat(Int16 lHeader, Version version)
        {
            using (FileStream f = new FileStream(_fileName, FileMode.Open))
            {
                using (BinaryReader r = new BinaryReader(f))
                {
                    bool flag = false;
                    try
                    {
                        if (r.ReadInt16() == lHeader && r.ReadByte() == (byte)version)
                            flag = true;
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
                    return flag;
                }
            }
        }

        /// <summary>
        /// public virtual bool IsValidFormat(Int16 lHeader, Version version, out AlgorithmType algType, out AlgorithmKeyType algKeyType)
        /// </summary>
        /// <param name="lHeader"></param>
        /// <param name="version"></param>
        /// <param name="algType"></param>
        /// <param name="algKeyType"></param>
        /// <returns></returns>
        public virtual bool IsValidFormat(Int16 lHeader, Version version, out AlgorithmType algType, out AlgorithmKeyType algKeyType)
        {
            using (FileStream f = new FileStream(_fileName, FileMode.Open))
            {
                using (BinaryReader r = new BinaryReader(f))
                {
                    algType = 0;
                    algKeyType = 0;
                    bool flag = false;
                    try
                    {
                        if (r.ReadInt16() == lHeader && r.ReadByte() == (byte)version)
                        {
                            algType = (AlgorithmType)r.ReadByte();
                            algKeyType = (AlgorithmKeyType)r.ReadByte();
                            flag = true;
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
                    return flag;
                }
            }
        }

        /// <summary>
        /// protected virtual byte[] ReadFile(Int16 lHeader, Version version, out AlgorithmType algType, out AlgorithmKeyType algKeyType)
        /// </summary>
        /// <param name="lHeader"></param>
        /// <param name="version"></param>
        /// <param name="algType"></param>
        /// <param name="algKeyType"></param>
        /// <returns></returns>
        protected virtual byte[] ReadFile(Int16 lHeader, Version version, out AlgorithmType algType, out AlgorithmKeyType algKeyType)
        {
            using (FileStream f = new FileStream(_fileName, FileMode.Open))
            {
                using (BinaryReader r = new BinaryReader(f))
                {
                    byte[] value = null;
                    algType = 0;
                    algKeyType = 0;
                    try
                    {
                        if (r.ReadInt16() == lHeader && r.ReadByte() == (byte)version)
                        {
                            algType = (AlgorithmType)r.ReadByte();
                            algKeyType = (AlgorithmKeyType)r.ReadByte();
                            value = r.ReadBytes((int)f.Length - 5);
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
        /// protected virtual byte[] WriteMenoryStream(string seretKey, byte[] data, Version version, Encryptor encryptor, AlgorithmType algType, AlgorithmKeyType algKeyType)
        /// </summary>
        /// <param name="seretKey"></param>
        /// <param name="data"></param>
        /// <param name="version"></param>
        /// <param name="encryptor"></param>
        /// <param name="algType"></param>
        /// <param name="algKeyType"></param>
        /// <returns></returns>
        protected virtual byte[] WriteMenoryStream(string seretKey, byte[] data, Version version, Encryptor encryptor, AlgorithmType algType, AlgorithmKeyType algKeyType)
        {
            byte[] value = null;
            using (MemoryStream ms = new MemoryStream())
            {
                using (BinaryWriter w = new BinaryWriter(ms))
                {
                    try
                    {
                        w.Write((Int16)5);
                        w.Write((byte)version);
                        w.Write(Convert.ToByte((int)algType));
                        w.Write(Convert.ToByte((int)algKeyType));
                        w.Write(encryptor.ObjectCryptography(data, TransformType.ENCRYPT));
                        w.Flush();
                        value = ms.ToArray();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        w.Close();
                        ms.Close();
                    }
                }
            }
            return value;
        }

        /// <summary>
        /// protected virtual byte[] WriteMenoryStream(byte[] data, Version version, AlgorithmType algType, AlgorithmKeyType algKeyType)
        /// </summary>
        /// <param name="data"></param>
        /// <param name="version"></param>
        /// <param name="algType"></param>
        /// <param name="algKeyType"></param>
        /// <returns></returns>
        protected virtual byte[] WriteMenoryStream(byte[] data, Version version, AlgorithmType algType, AlgorithmKeyType algKeyType)
        {
            byte[] value = null;
            using (MemoryStream ms = new MemoryStream())
            {
                using (BinaryWriter w = new BinaryWriter(ms))
                {
                    try
                    {
                        w.Write((Int16)5);
                        w.Write((byte)version);
                        w.Write(Convert.ToByte((int)algType));
                        w.Write(Convert.ToByte((int)algKeyType));
                        w.Write(data);
                        w.Flush();
                        value = ms.ToArray();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        w.Close();
                        ms.Close();
                    }
                }
            }
            return value;
        }

        /// <summary>
        /// public virtual byte[] MemoryPacket(string secretKey, byte[] data, Version version, AlgorithmType algType, AlgorithmKeyType algKeyType)
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="data"></param>
        /// <param name="version"></param>
        /// <param name="algType"></param>
        /// <param name="algKeyType"></param>
        /// <returns></returns>
        public virtual byte[] MemoryPacket(string secretKey, byte[] data, Version version, AlgorithmType algType, AlgorithmKeyType algKeyType)
        {
            byte[] value = null;
            switch (algType)
            {
                case AlgorithmType.DES:
                    try
                    {
                        Encryptor = new AlgorithmDES(secretKey, algKeyType);
                        value = WriteMenoryStream(secretKey, data, version, Encryptor, AlgorithmType.DES, algKeyType);
                    }
                    catch (Exception e) { throw e; }
                    break;
                case AlgorithmType.Rijndael:
                    try
                    {
                        Encryptor = new AlgorithmRijndael(secretKey, algKeyType);
                        value = WriteMenoryStream(secretKey, data, version, Encryptor, AlgorithmType.Rijndael, algKeyType);
                    }
                    catch (Exception e) { throw e; }
                    break;
                case AlgorithmType.TripleDES:
                    try
                    {
                        Encryptor = new AlgorithmTripleDES(secretKey, algKeyType);
                        value = WriteMenoryStream(secretKey, data, version, Encryptor, AlgorithmType.TripleDES, algKeyType);
                    }
                    catch (Exception e) { throw e; }
                    break;
                case AlgorithmType.None:
                    try
                    {
                        value = WriteMenoryStream(data, version, AlgorithmType.None, AlgorithmKeyType.None);
                    }
                    catch (Exception e) { throw e; }
                    break;
                default:
                    break;
            }
            return value;
        }

        /// <summary>
        /// public virtual bool SavePacket(byte[] data, Version version)
        /// </summary>
        /// <param name="data"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public virtual bool SavePacket(byte[] data, Version version)
        {
            try
            {
                WriteFile(data, version, AlgorithmType.None, AlgorithmKeyType.None);
            }
            catch { return false; }
            return true;
        }

        /// <summary>
        /// public virtual bool SavePacket(string secretKey, byte[] data, Version version, AlgorithmType algType, AlgorithmKeyType algKeyType)
        /// </summary>
        /// <param name="secretKey"></param>
        /// <param name="data"></param>
        /// <param name="version"></param>
        /// <param name="algType"></param>
        /// <param name="algKeyType"></param>
        /// <returns></returns>
        public virtual bool SavePacket(string secretKey, byte[] data, Version version, AlgorithmType algType, AlgorithmKeyType algKeyType)
        {
            bool flag = false;
            switch (algType)
            {
                case AlgorithmType.DES:
                    try
                    {
                        Encryptor = new AlgorithmDES(secretKey, algKeyType);
                        WriteFile(secretKey, data, version, Encryptor, AlgorithmType.DES, algKeyType);
                        flag = true;
                    }
                    catch { flag = false; }
                    break;
                case AlgorithmType.Rijndael:
                    try
                    {
                        Encryptor = new AlgorithmRijndael(secretKey, algKeyType);
                        WriteFile(secretKey, data, version, Encryptor, AlgorithmType.Rijndael, algKeyType);
                        flag = true;
                    }
                    catch { flag = false; }
                    break;
                case AlgorithmType.TripleDES:
                    try
                    {
                        Encryptor = new AlgorithmTripleDES(secretKey, algKeyType);
                        WriteFile(secretKey, data, version, Encryptor, AlgorithmType.TripleDES, algKeyType);
                        flag = true;
                    }
                    catch { flag = false; }
                    break;
                case AlgorithmType.None:
                    try
                    {
                        WriteFile(data, version, AlgorithmType.None, AlgorithmKeyType.None);
                        flag = true;
                    }
                    catch { flag = false; }
                    break;
                default:
                    break;
            }
            return flag;
        }
    }
}
