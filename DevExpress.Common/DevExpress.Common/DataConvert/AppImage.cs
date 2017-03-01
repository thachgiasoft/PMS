using System;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace DevExpress.Common.DataConvert
{
    public static class AppImage
    {
        /// <summary>
        /// Convert from byte array to image.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Image ByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        
        /// <summary>
        /// Convert from image to byte[]
        /// </summary>
        /// <param name="img"></param>
        /// <param name="imgFormat"></param>
        /// <returns></returns>
        public static byte[] ImageToByteArray(Image img, ImageFormat imgFormat)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, imgFormat);
                return ms.ToArray();
            }
        }
    }
}
