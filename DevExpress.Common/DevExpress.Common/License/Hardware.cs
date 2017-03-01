using System;
using System.Management;

namespace DevExpress.Common.License
{
    public static class Hardware
    {
        private static string strCoder = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

        /// <summary>
        /// public static string GetCPUID()
        /// </summary>
        /// <returns></returns>
        public static string GetCPUID()
        {
            string cpuInfo = String.Empty;
            //create an instance of the Managemnet class with the
            //Win32_Processor class
            using (ManagementClass mgmt = new ManagementClass("Win32_Processor"))
            {
                //create a ManagementObjectCollection to loop through
                ManagementObjectCollection objCol = mgmt.GetInstances();
                //start our loop for all processors found
                foreach (ManagementObject obj in objCol)
                    if (cpuInfo == String.Empty)
                        // only return cpuInfo from first CPU
                        cpuInfo = obj.Properties["ProcessorId"].Value.ToString();
            }
            return cpuInfo;
        }

        /// <summary>
        /// public static string GetMotherBoard()
        /// </summary>
        /// <returns></returns>
        public static string GetMotherBoard()
        {
            string cpuMan = String.Empty;
            //create an instance of the Managemnet class with the
            //Win32_Processor class
            using (ManagementClass mgmt = new ManagementClass("Win32_BaseBoard"))
            {
                //create a ManagementObjectCollection to loop through
                ManagementObjectCollection objCol = mgmt.GetInstances();
                //start our loop for all processors found
                foreach (ManagementObject obj in objCol)
                    if (cpuMan == String.Empty)
                        // only return manufacturer from first CPU
                        cpuMan = obj.Properties["SerialNumber"].Value.ToString();
            }
            return cpuMan;
        }

        /// <summary>
        /// public static string GetMachineID()
        /// </summary>
        /// <returns></returns>
        public static string GetMachineID()
        {
            string CPUID = "";
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                CPUID += mo.Properties["ProcessorId"].Value.ToString() + Environment.NewLine;
                break;
            }
            CPUID.PadRight(16, 'A');
            CPUID = CPUID.Substring(0, 4) + CPUID.Substring(12);
            long iCPUID = 0;
            try
            {
                iCPUID = long.Parse(CPUID, System.Globalization.NumberStyles.HexNumber);
            }
            catch
            {
                return "---=== Unknow ===---";
            }
            string strCPUID = "";
            while (iCPUID > 35)
            {
                strCPUID += strCoder[Convert.ToInt32(iCPUID % 35)].ToString();
                iCPUID /= 35;
            }
            strCPUID += strCoder[Convert.ToInt32(iCPUID)].ToString();
            string MainBoard = "";
            mc = new ManagementClass("Win32_BaseBoard");
            moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                MainBoard += mo.Properties["SerialNumber"].Value.ToString().Trim();
                break;
            }
            mc.Dispose();
            moc.Dispose();
            string tmpMainBoard = "";
            for (int i = MainBoard.Length - 1; i > -1 && tmpMainBoard.Length < 12; i--)
                if (strCoder.Contains(MainBoard[i].ToString()))
                    tmpMainBoard = MainBoard[i].ToString() + tmpMainBoard;
            tmpMainBoard.PadLeft(12, 'A');
            long iMainboard = 0;
            for (int i = 0; i < tmpMainBoard.Length; i++)
                iMainboard += Convert.ToInt64(strCoder.IndexOf(tmpMainBoard[i]) * Math.Pow(36, i));
            string strMainBoard = "";
            while (iMainboard > 35)
            {
                strMainBoard += strCoder[Convert.ToInt32(iMainboard % 35)].ToString();
                iMainboard /= 35;
            }
            strMainBoard += strCoder[Convert.ToInt32(iMainboard)].ToString();
            return strCPUID + strMainBoard;
        }
    }
}
