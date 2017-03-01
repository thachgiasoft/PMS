using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PMS.Common
{
    class XuLySo
    {
        /// <summary>
        /// Làm tròn lên cho một số thực
        /// </summary>
        /// <param name="so">Số thực cần làm tròn</param>
        /// <returns> Số nguyên, kết quả sau khi làm tròn </returns>
        public static int LamTronLen(double so)
        {
            return so - (int)so > 0 ? (int)so + 1 : (int)so;
        }
    }
}
