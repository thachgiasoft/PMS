using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using PMS.Core;
using PMS.UI.Forms.HeThong;
using System.Text.RegularExpressions;
using PMS.BLL;
using PMS.Core.Manager;
using DevExpress.XtraEditors;
using System.Configuration;
using DevExpress.Common.Config;

namespace PMS
{
    public partial class frmMain : RibbonForm
    {
        private static frmMain _instance;

        public static frmMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmMain();
                return _instance;
            }
        }

        public frmMain()
        {
            //Init Component
            InitializeComponent();
            //Company
            //barCompany.Caption = string.Format("PSC PMS Version {0} Copyright ©  2011 All rights reserved.", Application.ProductVersion);

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(Application.StartupPath + "\\" + Application.ProductName +".exe");
            DateTime lastModified = fileInfo.LastWriteTime;
            barCompany.Caption = string.Format("PSC PMS Version {0} Copyright © 2011 All rights reserved. Release date {1}.", Application.ProductVersion, lastModified.ToString("dd/MM/yyyy"));
            //EncodeConnectionString();

            
            string _connectionString;
            try
            {
                bool flag = false;
                foreach (char c in AppConnection.ConnectionString)
                {
                    if (c != '0' && c != '1')//Mã hoá cũ: bit 01
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                    _connectionString = CipherLib.PSCExtensions.DecodeString(AppConnection.ConnectionString) + ";Max Pool Size=1000";
                else
                    _connectionString = DecodeString(AppConnection.ConnectionString);
            }
            catch
            {
                _connectionString = AppConnection.ConnectionString;
            }

            Libraries.DAL.CommondMethods._connectionString = _connectionString;
        }

        /// <summary>
        /// Form Loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(UserInfo.SkinName);
            //Init Plugin
            try
            {
                AppPlugin.InitPlugin();
                //Init Component
                _instance = this;
                DevExpress.Common.Culture.AppCulture.InitCulture();

                if (DateTime.Now.Day == 25 && DateTime.Now.Month == 12)
                {
                    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Xmax 2008 Blue");
                }
                else if (DateTime.Now.Day == 1 && DateTime.Now.Month == 1)
                {
                    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Springtime");
                }
                else if (DateTime.Now.Day == 14 && DateTime.Now.Month == 2)
                {
                    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Valentine");
                }
                else if (DateTime.Now.Day == 31 && DateTime.Now.Month == 10)
                {
                    DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Pumbkin");
                }

                if (UserInfo._UserID != null && UserInfo._UserID != "")
                {
                    var ok = DangNhap(UserInfo._UserID, UserInfo._UserPass);
                    if (!ok)
                    {
                        frmDangNhap frm = new frmDangNhap { MdiParent = this };
                        frm.Show();
                    }
                }
                else
                {
                    frmDangNhap frm = new frmDangNhap { MdiParent = this };
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DangNhap(string user, string pass)
        {
            if (user == "") return false;
         
            //Gắn tên đăng nhập để lưu log
            PMS.Data.Utility.userID = UserInfo.UserName;

            bool? isValid = UserInfo.IsLogin(user, pass);

            if (isValid != null)
            {
                if (isValid == true)
                {
                    if (UserInfo.User.TrangThai == true)
                    {
                        return false;
                    }

                    AppSystem.InitControl();
                    UserInfo.LoginType = PMS.Common.UserTypes.None;
                    frmThongTin frm = new frmThongTin { MdiParent = frmMain.Instance };
                    frm.Show();
                    //Init cache
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (UserInfo.IsSystemValid(user))
                {
                    if (UserInfo.IsSystemLogin(user, pass))
                    {
                        Close();
                        //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(UserInfo.SkinName);
                        AppSystem.InitSystem();
                        UserInfo.LoginType = PMS.Common.UserTypes.System;
                        frmThongTin frm = new frmThongTin { MdiParent = frmMain.Instance };
                        frm.Show();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Log out.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemDangXuat_Click(object sender, EventArgs e)
        {
            //Remove Forms
            Cursor.Current = Cursors.WaitCursor;
            Array.ForEach(xtraTabbedMdiManager.MdiParent.MdiChildren, frm =>
            {
                frm.Close();
            });

            //Remove all item in ribbon control.
            for (int i = ribbon.Pages.Count - 1; i >= 0; i--)
            {
                for (int j = ribbon.Pages[i].Groups.Count - 1; j >= 0; j--)
                    ribbon.Pages[i].Groups[j].ItemLinks.Clear();//Clear item
                //Clear group
                ribbon.Pages[i].Groups.Clear();
            }
            //Clear pages
            ribbon.Pages.Clear();

            //Remove Link
            frmMain.Instance.DangXuat.Visibility = BarItemVisibility.Never;

            //Init Form Login
            frmDangNhap frmLogin = new frmDangNhap { MdiParent = this };
            frmLogin.Show();
            Cursor.Current = Cursors.Default;
        }

        #region Cac ham ma hoa
        //Ham ma hoa
        private void EncodeConnectionString()
        {
            //Ma hoa chuoi ket noi
            //string stringConnect = EncodeString(ConfigurationManager.ConnectionStrings["netTiersConnectionString"].ConnectionString);
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.ConnectionStrings.ConnectionStrings["netTiersConnectionString"].ConnectionString = EncodeString(AppConnection.ConnectionString);
            config.Save(ConfigurationSaveMode.Modified);
            //ConfigurationManager.RefreshSection("ConnectionStrings");

            //Libraries.DAL.CommondMethods._connectionString = AppConnection.ConnectionString;
        }
        /// <summary>
        /// Ham ma hoa chuoi 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string EncodeString(string s)
        {
            string result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                result += ConvertFromCharacterToBinary(s[i]);
            }
            return result;
        }

        /// <summary>
        /// Ham convert tu Character sang Binary
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private static string ConvertFromCharacterToBinary(char c)
        {
            string result = string.Empty;
            double value = Convert.ToDouble(Convert.ToInt32(c));
            for (double i = 15; i >= 0; i--)
            {
                if (value >= Math.Pow(2, i))
                {
                    result += "1";
                    value -= Math.Pow(2, i);
                }
                else
                    result += "0";
            }
            return result;
        }

        public static string DecodeString(string s)
        {
            string result = string.Empty;
            if (s == string.Empty) return string.Empty;
            for (int i = 0; i < s.Length; i += 16)
            {
                string temp = string.Empty;
                for (int j = 0; j < 16; j++)
                {
                    temp += s[i + j].ToString();
                }
                result += ConvertFromBinaryToCharacter(temp);
            }
            return result;
        }

        private static string ConvertFromBinaryToCharacter(string b)
        {
            double result = 0;
            for (int i = 0; i < 16; i++)
            {
                if (b[i] == '1') result += Math.Pow(2, 15 - i);
            }
            return Convert.ToChar(Convert.ToInt32(result)).ToString();
        }
        #endregion


    }
}