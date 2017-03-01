using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace PMS.Common
{
    class XuLyTapTin
    {
        private static StreamWriter STREAM_WRITER;
        /// <summary>
        /// Tạo stream đến tập tin txt.
        /// </summary>
        /// <param name="fileName">Tên tập tin (bao gồm đường dẫn và phần mở rộng).</param>
        /// <returns> StreamWriter để bắt đầu ghi dữ liệu. </returns>
        public static void OpenTextFileForWrite(string fileName)
        {
            STREAM_WRITER = new StreamWriter(fileName);
        }

        /// <summary>
        /// Ghi chuỗi vào tập tin đang mở.
        /// </summary>
        /// <param name="text">Dữ liệu cần ghi.</param>
        public static void WriteTextFile(string text)
        {
            STREAM_WRITER.Write(text);
        }

        /// <summary>
        /// Đóng stream của tập tin đang mở.
        /// </summary>
        public static void CloseCurrentTextFile()
        {
            STREAM_WRITER.Close();
        }
    }
}
