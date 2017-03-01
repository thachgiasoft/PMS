using System;
using DevExpress.Common.Config;
using System.Data;
using PMS.Core;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using System.Windows.Forms;
using PMS.Entities;
using PMS.Services;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;

namespace PMS.Common
{
    public static class Globals
    {
        private static AppSetting config;
        public static CauHinh _cauhinh;
        public static string _matkhau;
        static Globals() { config = new AppSetting(); }

        /// <summary>
        /// Load layout control.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="ctl"></param>
        public static void LoadLayout(AppModule obj, object[] ctl)
        {
            if (obj != null)
            {
                if (obj.Module.DataLayout != null)
                    PMS.Core.Manager.LayoutServices.LoadLayoutControl(ctl, obj.Module.DataLayout);
            }
        }

        /// <summary>
        /// Save layout control
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="gridView"></param>
        public static void SaveLayout(AppModule obj, object[] ctl)
        {
            //Save layout
            if (obj != null)
            {
                obj.Module.DataLayout = PMS.Core.Manager.Converter.ObjectToByteArray(PMS.Core.Manager.LayoutServices.SaveLayoutControl(ctl));
                DataServices.ChucNang.Update(obj.Module);
            }
        }

        /// <summary>
        /// Get last name.
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        public static string GetLastName(string fullName)
        {
            string result = string.Empty;
            try
            {
                string pupilName = fullName.Trim().Replace(' ', '#');
                if (!pupilName.Contains("#"))
                    return string.Empty;
                string[] token = pupilName.Split('#');
                result = token[0].ToString();
            }
            catch
            {
            }
            return result;
        }

        /// <summary>
        /// Get middle name.
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        public static string GetMiddleName(string fullName)
        {
            string result = string.Empty;
            try
            {
                string pupilName = fullName.Trim().Replace(' ', '#');
                if (!pupilName.Contains("#"))
                    return string.Empty;
                string[] token = pupilName.Split('#');
                if (token.Length == 2)
                    return string.Empty;
                for (int i = 1; i < token.Length - 1; i++)
                    result += token[i].ToString() + " ";
                result = result.Trim();
            }
            catch
            {
            }
            return result;
        }

        /// <summary>
        /// Get first name.
        /// </summary>
        /// <param name="fullName"></param>
        /// <returns></returns>
        public static string GetFirstName(string fullName)
        {
            string result = string.Empty;
            try
            {
                string pupilName = fullName.Trim().Replace(' ', '#');
                if (fullName.Trim() == string.Empty)
                    return string.Empty;
                if (!pupilName.Contains("#"))
                    return pupilName.Trim();
                string[] token = pupilName.Split('#');
                result = token[token.Length - 1].ToString();
            }
            catch
            {
            }
            return result;
        }

        /// <summary>
        /// Sentence case.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToSentenceCase(string s)
        {
            if (s.Length > 1)
                return s.Substring(0, 1).ToUpper() + s.Substring(1, s.Length - 1);
            else
                return s.ToUpper();
        }

        /// <summary>
        /// Modify column table.
        /// </summary>
        /// <param name="dt"></param>
        public static void ModifyData(DataTable dt)
        {
            if (dt != null)
            {
                foreach (DataColumn d in dt.Columns)
                    d.ReadOnly = false;
            }
        }

        /// <summary>
        /// Chuyen tu so sang chu
        /// </summary>
        /// <param name="NumCurrency"></param>
        /// <returns></returns>
        public static string DocTien(decimal NumCurrency)
        {
            string SoRaChu = "";
            decimal _soAm = NumCurrency;
            if (NumCurrency == 0)
            {
                SoRaChu = "Không dùng";
                return SoRaChu;
            }
            if (NumCurrency < 0)
                NumCurrency = Math.Abs(NumCurrency);

            string[] CharVND = new string[10] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string BangChu;
            int I;
            //As String, BangChu As String, I As Integer
            int SoLe, SoDoi;
            string PhanChan, Ten;
            string DonViTien, DonViLe;
            int NganTy, Ty, Trieu, Ngan;
            int Dong, Tram, Muoi, DonVi;

            SoDoi = 0;
            Muoi = 0;
            Tram = 0;
            DonVi = 0;

            Ten = "";
            //Dim SoLe, SoDoi As Integer, PhanChan, Ten As String
            //Dim DonViTien As String, DonViLe As String
            //Dim NganTy As Integer, Ty As Integer, Trieu As Integer, Ngan As Integer
            //Dim Dong As Integer, Tram As Integer, Muoi As Integer, DonVi As Integer

            DonViTien = "đồng";
            DonViLe = "xu";


            SoLe = (int)((NumCurrency - (Int64)NumCurrency) * 100); //'2 kí so^' le?
            PhanChan = ((Int64)NumCurrency).ToString().Trim();

            int khoangtrang = 15 - PhanChan.Length;
            for (int i = 0; i < khoangtrang; i++)
                PhanChan = "0" + PhanChan;
            //PhanChan = Space(15 - PhanChan.Length) + PhanChan;

            NganTy = int.Parse(PhanChan.Substring(0, 3));
            Ty = int.Parse(PhanChan.Substring(3, 3));
            Trieu = int.Parse(PhanChan.Substring(6, 3));
            Ngan = int.Parse(PhanChan.Substring(9, 3));
            Dong = int.Parse(PhanChan.Substring(12, 3));
            //Ty = Val(Mid$(PhanChan, 4, 3))
            //Trieu = Val(Mid$(PhanChan, 7, 3))
            //Ngan = Val(Mid$(PhanChan, 10, 3))
            //Dong = Val(Mid$(PhanChan, 13, 3))

            if (NganTy == 0 & Ty == 0 & Trieu == 0 & Ngan == 0 & Dong == 0)
            {
                BangChu = "không " + DonViTien + " ";
                I = 5;
            }
            else
            {
                BangChu = "";
                I = 0;
            }

            while (I <= 5)
            {
                switch (I)
                {
                    case 0:
                        SoDoi = NganTy;
                        Ten = "ngàn";
                        break;
                    case 1:
                        SoDoi = Ty;
                        Ten = "tỷ";
                        break;
                    case 2:
                        SoDoi = Trieu;
                        Ten = "triệu";
                        break;
                    case 3:
                        SoDoi = Ngan;
                        Ten = "ngàn";
                        break;
                    case 4:
                        SoDoi = Dong;
                        Ten = DonViTien;
                        break;
                    case 5:
                        SoDoi = SoLe;
                        Ten = DonViLe;
                        break;
                }

                if (SoDoi != 0)
                {
                    Tram = (int)(SoDoi / 100);
                    Muoi = (int)((SoDoi - Tram * 100) / 10);
                    DonVi = (SoDoi - Tram * 100) - Muoi * 10;
                    BangChu = BangChu.Trim() + (BangChu.Length == 0 ? "" : " ") + (Tram != 0 ? CharVND[Tram].Trim() + " trăm " : "");
                    if (Muoi == 0 & Tram != 0 & DonVi != 0)
                        BangChu = BangChu + "lẻ ";
                    else if (Muoi != 0)
                        BangChu = BangChu + ((Muoi != 0 & Muoi != 1) ? CharVND[Muoi].Trim() + " mươi " : "mười ");

                    if (Muoi != 0 & DonVi == 5)
                        BangChu = BangChu + "lăm " + Ten + " ";
                    else if (Muoi > 1 & DonVi == 1)
                        BangChu = BangChu + "mốt " + Ten + " ";
                    else
                        BangChu = BangChu + ((DonVi != 0) ? CharVND[DonVi].Trim() + " " + Ten + " " : Ten + " ");
                }
                else
                    BangChu = BangChu + ((I == 4) ? DonViTien + " " : "");

                I = I + 1;
            }
            if (SoLe == 0)
                //BangChu = BangChu + "chẵn";
                BangChu = BangChu;
            BangChu = BangChu[0].ToString().ToUpper() + BangChu.Substring(1);
            SoRaChu = BangChu;

            if (_soAm < 0)
            {
                SoRaChu = "Âm " + SoRaChu.ToLower();
            }

            return SoRaChu;
        }

        #region Roman(int Num, bool upper)
        public static string Roman(int Num, bool upper)
        {
            string ch = "";
            if (Num > 10000) return "";
            int tam = Num / 1000;
            for (int i = 0; i < tam; i++)
                ch += "M";
            Num = Num % 1000;

            tam = Num / 100;
            for (int i = 0; i < tam; i++)
                ch += "C";
            Num = Num % 100;

            tam = Num / 10;
            for (int i = 0; i < tam; i++)
                ch += "X";
            Num = Num % 10;

            for (int i = 0; i < Num; i++)
                ch += "I";

            ch = ch.Replace("CCCCCCCCC", "CM");
            ch = ch.Replace("XXXXXXXXX", "XC");
            ch = ch.Replace("IIIIIIIII", "IX");
            ch = ch.Replace("CCCCC", "D");
            ch = ch.Replace("XXXXX", "L");
            ch = ch.Replace("IIIII", "V");
            ch = ch.Replace("CCCC", "CD");
            ch = ch.Replace("XXXX", "XL");
            ch = ch.Replace("IIII", "IV");
            if (upper == true) ch = ch.ToUpper();
            else ch = ch.ToLower();
            return ch;
        }
        #endregion

        #region Char(string Num, bool upper)
        public static string Char(string Num, bool upper)
        {
            string[] Nm = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26" };
            string[] Ch = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int index = Array.IndexOf(Nm, Num);
            if (index < 0) return "";
            string reVal = "";
            reVal = Ch[index];
            if (upper) return reVal.ToUpper();
            else return reVal.ToLower();
        }
        #endregion
        #region IsNull
        public static object IsNull(object o, string dataType)
        {
            if (dataType == "string")
                if (o == "" || o == null)
                    o = "";
            if (dataType == "int" || dataType == "decimal")
                if (o == "" || o == null || o.ToString()=="")
                    o = (int)0;
            if (dataType == "bool" || (o.ToString() == "" && dataType == "bool"))
                if (o == "" || o == null)
                    o = false;
            return o;
        }
        #endregion
        #region ReplaceDot: convert "," to "."
        public static string ReplaceDot(string s)
        {
            if (s.Contains(",") == true)
            {
                s = s.Replace(",", ".");
            }
            else
                s = s.Replace(".", ",");
            return s;
        }
        #endregion

        #region EncodeMD5(string userName, string password)
        public static string EncodeMD5(string userName, string password)
        {
            string result = string.Empty;
            try
            {
                result = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile("UisStaffID=" + userName.ToUpper() + ";UisPassword=" + password, "MD5");
            }
            catch
            {
                result = string.Empty;
            }
            return result;
        }
        #endregion

        #region IsMD5(string text)
        public static bool IsMD5(string text)
        {
            if (text.Length == 32)
                return true;
            else
                return false;
        }
        #endregion

        #region ReplaceChar: thay thế ký tự unicode
        public static string ReplaceChar(string _char)
        {
            _char = _char.ToUpper();
            if (_char.Contains("Đ"))
                _char = "D";
            if (_char.Contains("Á"))
                _char = "A";
            if (_char.Contains("?"))
                _char = "A";
            if (_char.Contains("À"))
                _char = "A";
            if (_char.Contains("Ả"))
                _char = "A";
            if (_char.Contains("Ã"))
                _char = "A";
            if (_char.Contains("Ạ"))
                _char = "A";
            if (_char.Contains("Â"))
                _char = "A";
            if (_char.Contains("Ă"))
                _char = "A";
            if (_char.Contains("Ấ"))
                _char = "A";
            if (_char.Contains("Ầ"))
                _char = "A";
            if (_char.Contains("Ẩ"))
                _char = "A";
            if (_char.Contains("Ẫ"))
                _char = "A";
            if (_char.Contains("Ậ"))
                _char = "A";
            if (_char.Contains("Ắ"))
                _char = "A";
            if (_char.Contains("Ằ"))
                _char = "A";
            if (_char.Contains("Ẳ"))
                _char = "A";
            if (_char.Contains("Ẵ"))
                _char = "A";
            if (_char.Contains("Ặ"))
                _char = "A";
            if (_char.Contains("É"))
                _char = "E";
            if (_char.Contains("È"))
                _char = "E";
            if (_char.Contains("Ẻ"))
                _char = "E";
            if (_char.Contains("Ẽ"))
                _char = "E";
            if (_char.Contains("Ẹ"))
                _char = "E";
            if (_char.Contains("Ê"))
                _char = "E";
            if (_char.Contains("Ế"))
                _char = "E";
            if (_char.Contains("Ề"))
                _char = "E";
            if (_char.Contains("Ể"))
                _char = "E";
            if (_char.Contains("Ễ"))
                _char = "E";
            if (_char.Contains("Ệ"))
                _char = "E";
            if (_char.Contains("Í"))
                _char = "I";
            if (_char.Contains("Ì"))
                _char = "I";
            if (_char.Contains("Ỉ"))
                _char = "I";
            if (_char.Contains("Ĩ"))
                _char = "I";
            if (_char.Contains("Ị"))
                _char = "I";
            if (_char.Contains("Ó"))
                _char = "O";
            if (_char.Contains("Ò"))
                _char = "O";
            if (_char.Contains("Ỏ"))
                _char = "O";
            if (_char.Contains("Õ"))
                _char = "O";
            if (_char.Contains("Ọ"))
                _char = "O";
            if (_char.Contains("Ô"))
                _char = "O";
            if (_char.Contains("Ơ"))
                _char = "O";
            if (_char.Contains("Ố"))
                _char = "O";
            if (_char.Contains("Ồ"))
                _char = "O";
            if (_char.Contains("Ổ"))
                _char = "O";
            if (_char.Contains("Ỗ"))
                _char = "O";
            if (_char.Contains("Ộ"))
                _char = "O";
            if (_char.Contains("Ớ"))
                _char = "O";
            if (_char.Contains("Ờ"))
                _char = "O";
            if (_char.Contains("Ở"))
                _char = "O";
            if (_char.Contains("Ỡ"))
                _char = "O";
            if (_char.Contains("Ợ"))
                _char = "O";
            if (_char.Contains("Ú"))
                _char = "U";
            if (_char.Contains("Ù"))
                _char = "U";
            if (_char.Contains("Ủ"))
                _char = "U";
            if (_char.Contains("Ũ"))
                _char = "U";
            if (_char.Contains("Ụ"))
                _char = "U";
            if (_char.Contains("Ư"))
                _char = "U";
            if (_char.Contains("Ứ"))
                _char = "U";
            if (_char.Contains("Ừ"))
                _char = "U";
            if (_char.Contains("Ử"))
                _char = "U";
            if (_char.Contains("Ữ"))
                _char = "U";
            if (_char.Contains("Ự"))
                _char = "U";
            if (_char.Contains("Ý"))
                _char = "Y";
            if (_char.Contains("Ỳ"))
                _char = "Y";
            if (_char.Contains("Ỷ"))
                _char = "Y";
            if (_char.Contains("Ỹ"))
                _char = "Y";
            if (_char.Contains("Ỵ"))
                _char = "Y";
            return _char.ToLower();
        }
        #endregion

        #region WrapHeader GridView
        public static void WordWrapHeader(GridView grid, int height)
        {
            for (int i = 0; i < grid.Columns.Count; i++)
                grid.Columns[i].AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            AutoHeightHelper a = new AutoHeightHelper(grid, height);
            a.EnableColumnPanelAutoHeight();
        }
        #endregion

        #region No WrapHeader GridView
        public static void NoWrapHeader(GridView grid)
        {
            for (int i = 0; i < grid.Columns.Count; i++)
                grid.Columns[i].AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            AutoHeightHelper a = new AutoHeightHelper(grid, 0);
            a.DisableColumnPanelAutoHeight();
            grid.BestFitColumns();
        }
        #endregion

        #region GridRowColor
        public static void GridRowColor(GridView grid, System.Drawing.Font font, System.Drawing.Color backColor, string coLumnName, string value)
        {
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatCondition1.Appearance.BackColor = backColor;
            styleFormatCondition1.Appearance.Font = font;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = grid.Columns[coLumnName];
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = value;
            grid.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
        }

        public static void GridRowColor(GridView grid, System.Drawing.Color backColor, string coLumnName, string value)
        {
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            styleFormatCondition1.Appearance.BackColor = backColor;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            //styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = grid.Columns[coLumnName];
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = value;
            grid.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
        }
        #endregion

        #region Convert List to DataTable (VList, TList...)
        public static DataTable ToDataTable<T>(IEnumerable<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
        #endregion

        #region Replace dot enviroment: những máy tính thay đổi biến môi trường ngăn cách phần thập phân thành dấu phẩy
        public static object ReplaceDotEnviroment(object s, string type)
        {
            object input = IsNull(s, type);
            object result = null;
            System.Globalization.NumberFormatInfo num = new System.Globalization.NumberFormatInfo();
            num = System.Threading.Thread.CurrentThread.CurrentUICulture.NumberFormat;

            if (num.NumberDecimalSeparator == ".")
            {
                result = input;
            }
            if (num.NumberDecimalSeparator == ",")
            {
                result = input.ToString().Replace(",", ".");
            }

            return result;
        }
        #endregion

        #region FixGridColumn
        public static void FixGridColumn(GridView grid, string[] fieldName, DevExpress.XtraGrid.Columns.FixedStyle style)
        {
            for (int i = 0; i < fieldName.Length; i++)
                grid.Columns[fieldName[i]].Fixed = style;
        }
        #endregion
    }
}