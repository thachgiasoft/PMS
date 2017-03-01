using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PMS.Common
{
    class XuLyChuoi
    {
        public static bool soSanhMatKhau(string username_nhapvao, string matkhau_nhapvao, string matkhau_thatsu)
        {
            return string.Compare(matkhau_nhapvao, matkhau_thatsu, false) == 0 || string.Compare(matkhau_thatsu, PMS.Common.Globals.EncodeMD5(username_nhapvao, matkhau_nhapvao), false) == 0;
        }

        public static string RefreshXmlString(string value)
        {
            try
            {
                if (value.Contains("&"))
                    value = value.Replace("&", "&#038;");
                if (value.Contains(">"))
                    value = value.Replace(">", "&#062;");
                if (value.Contains("<"))
                    value = value.Replace("<", "&#060;");
                if (value.Contains("\""))
                    value = value.Replace("\"", "&#034;");
                if (value.Contains("'"))
                    value = value.Replace("'", "&#039;");
            }
            catch { }
            return value;
        }

        /// <summary>
        /// Tạo chuỗi XML từ một số dòng và thuộc tính trong DataTable. (Đang làm dở dang)
        /// </summary>
        /// <param name="dataTable">DataTable cần tạo</param>
        /// <param name="attributeNames">Danh sách các thuộc tính cần tạo trong XML</param>
        /// <param name="fieldNames">Danh sách các thuộc tính cần tạo trong dataTable</param>
        /// <param name="notNullFieldNames">Danh sách các thuộc tính quan trọng, không được null</param>
        /// <param name="rowIndexes">Danh sách các index dòng càn tạo trong dataTable</param>
        public static string CreateXML(System.Data.DataTable dataTable, string[] attributeNames, string[] fieldNames, string[] notNullFieldNames, int[] rowIndexes)
        {
            string xmlData = "";
            foreach (DataRow v in dataTable.Rows)
            {
                if (v.RowState != DataRowState.Deleted)
                {
                    foreach (string keyField in notNullFieldNames)
                    {
                        if (v[keyField] == null) return null;
                    }
                    string strTag = "<Input ";
                    for (int i = 0; i < attributeNames.Length; i++)
                    {
                        strTag += attributeNames[i] + "=\"" + v[i] + "\" ";
                    }

                    xmlData += String.Format("<Input M=\"{0}\" MN=\"{1}\" S=\"{2}\" D=\"{3}\" U=\"{4}\" T=\"{5}\" NN=\"{6}\" SL=\"{7}\" V=\"{8}\" DK=\"{9}\" X=\"{10}\" NX=\"{11}\" Id=\"{12}\" />"
                        , v["MaGiangVien"], v["MaNckh"], v["SoTiet"], v["NgayCapNhat"], v["NguoiCapNhat"]
                        , PMS.Common.XuLyChuoi.RefreshXmlString(v["TenNckh"].ToString())
                        , v["NgayNhap"]
                        , v["SoLuongThanhVien"], v["MaVaiTro"]
                        , PMS.Common.Globals.IsNull(v["DuKien"], "bool")
                        , PMS.Common.Globals.IsNull(v["XacNhan"], "bool")
                        , v["NgayXacNhan"]
                        , PMS.Common.Globals.IsNull(v["Id"], "int"));
            }
            }
            xmlData = String.Format("<Root>{0}</Root>", xmlData);
            return xmlData;
        }

        /// <summary>
        /// So sánh một số ký tự trong hai chuỗi
        /// </summary>
        /// <param name="dau">Ký tự bắt đầu so sánh</param>
        /// <param name="cuoi">Ký tự kết thúc so sánh</param>
        /// <param name="chuoi01">Chuỗi thứ nhất</param>
        /// <param name="chuoi02">Chuỗi thứ hai</param>
        public static bool SoSanhChuoi(int dau, int cuoi, string chuoi01, string chuoi02)
        {
            int length = chuoi01.Length < chuoi02.Length ? chuoi01.Length : chuoi02.Length;
            if (dau <= length - 1 && length - 1 <= cuoi)
            {
                for (int i = dau; i <= cuoi; i++)
                {
                    if (chuoi01[i] != chuoi02[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else return false;
        }
    }
}
