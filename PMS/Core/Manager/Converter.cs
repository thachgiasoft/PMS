using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PMS.Core.Manager
{
    public static class Converter
    {
        /// <summary>
        /// Convert an object to a byte array.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte[] ObjectToByteArray(object obj)
        {
            if (obj != null)
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (MemoryStream ms = new MemoryStream())
                {
                    bf.Serialize(ms, obj);
                    return ms.ToArray();
                }
            }
            return null;
        }

        /// <summary>
        /// Convert a byte array to an Object.
        /// </summary>
        /// <param name="arrBytes"></param>
        /// <returns></returns>
        public static object ByteArrayToObject(byte[] arrBytes)
        {
            using (MemoryStream memStream = new MemoryStream())
            {
                BinaryFormatter binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                return (object)binForm.Deserialize(memStream);
            }
        }
    }
}
