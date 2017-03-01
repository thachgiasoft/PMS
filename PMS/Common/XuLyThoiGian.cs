using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.Common
{
    class XuLyThoiGian
    {
        /// <summary>
        /// Lấy tổng số milli giây giữa hai mốc thời gian.
        /// </summary>
        /// <param name="bat_dau">Thời gian bắt đầu</param>
        /// <param name="ket_thuc">Thời gian kết thúc</param>
        /// <returns></returns>
        public static long SoMillisecond(DateTime bat_dau, DateTime ket_thuc)
        {
            TimeSpan span = ket_thuc - bat_dau;
            return (long)span.TotalMilliseconds;
        }
    }
}
