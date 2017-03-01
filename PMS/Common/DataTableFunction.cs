using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PMSUI.Common
{
    public static class DataTableFunction
    {
        /// <summary>
        /// Chi dinh cac filed khong duoc phep edit
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="fieldName"></param>
        public static void AllowEditColumn(DataTable dt, string[] fieldName)
        {
            for (int i = 0; i < fieldName.Length; i++)
            {
                dt.Columns[fieldName[i]].ReadOnly = false;
            }
        }
    }
}
