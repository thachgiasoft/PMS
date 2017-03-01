using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PMS.Common
{
    class WriteLog
    {
        public static string filepath = "";
        public static void WriteLogFile(string log)
        {
            try
            {

                if (filepath == "")
                {
                    filepath = Directory.GetCurrentDirectory() + "\\PMS_LOG.txt";
                    //filepath = @"C:\LOG_UISERVICE.txt";
                }
                FileStream fs;
                if (!File.Exists(filepath))
                {
                    // Create the file.
                    fs = File.Create(filepath);
                    fs.Close();
                }

                //Open file
                fs = File.Open(filepath, FileMode.Append, FileAccess.Write);

                StreamWriter swFromFileStream = new StreamWriter(fs);
                log = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss    ") + log;
                swFromFileStream.WriteLine(log);
                swFromFileStream.Flush();
                swFromFileStream.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}
