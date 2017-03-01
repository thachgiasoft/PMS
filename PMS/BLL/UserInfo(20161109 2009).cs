using System;
using PMS.Services;
using PMS.Entities;
using DevExpress.Common.Config;
using System.Windows.Forms;
using System.Deployment.Application;
using PMS.Services;
using PMS.Common;

namespace PMS.BLL
{
    public static class UserInfo
    {
        private static AppSetting config;

        /// <summary>
        /// User information
        /// </summary>
        public static int GroupID { get; set; }
        public static string GroupName { get; set; }
        public static int UserID { get; set; }
        public static string UserName { get; set; }
        public static string FullName { get; set; }        
        public static TaiKhoan User { get; set; }
        public static UserTypes LoginType { get; set; }

        //Thêm vào gọi exe từ module khác---------------------------------
        public static string _UserID, staffName = null;
        public static string _UserGroup = "";
        public static string _UserPass = "";
        public static string[] _ParaFromUIS = null;
        //----------------------------------------------------------------
        /// <summary>
        /// Constructor UserInfo
        /// </summary>
        static UserInfo()
        {
            config = new AppSetting();
        }

        /// <summary>
        /// Get set your system password
        /// </summary>
        public static string SysPwd
        {
            get
            {
                try { return config.GetSetting("SysPwd"); }
                catch { return string.Empty; }
            }
            set { config.SetSetting("SysPwd", value); }
        }

        /// <summary>
        /// Get set use xml
        /// </summary>
        public static bool IsXml
        {
            get
            {
                try { return config.GetSetting("IsXml") == "true"; }
                catch { return false; }
            }
            set { config.SetSetting("IsXml", value); }
        }

        /// <summary>
        /// Get set your system user
        /// </summary>
        public static string SysUser
        {
            get
            {
                try { return config.GetSetting("SysUser"); }
                catch { return string.Empty; }
            }
            set { config.SetSetting("SysUser", value); }
        }

        /// <summary>
        /// Get set your skin
        /// </summary>
        public static string SkinName
        {
            get
            {
                try { return config.GetSetting("SkinName"); }
                catch { return string.Empty; }
            }
            set { config.SetSetting("SkinName", value); }
        }

        /// <summary>
        /// Thay doi mat khau he thong
        /// </summary>
        /// <param name="newpPassword"></param>
        public static void ChangeSystemPassword(string newpPassword)
        {
            SysPwd = PMS.Common.Globals.EncodeMD5(UserInfo.UserName.ToUpper(), newpPassword);
        }

        /// <summary>
        /// Kiem tra ten dang nhap da con ton tai chua
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static bool IsSystemValid(string userName)
        {
            if (userName == SysUser)
                return true;
            return false;
        }

        /// <summary>
        /// Kiem tra dang nhap vao he thong
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool IsSystemLogin(string userName, string password)
        {
            if (userName == SysUser)
            {
                if (PMS.Common.Globals.IsMD5(SysPwd))
                {
                    if (PMS.Common.Globals.EncodeMD5(userName.ToUpper(), password) == SysPwd)
                    {
                        UserName = SysUser;
                        FullName = "System";
                        GroupName = "System";
                        return true;
                    }
                }
                else 
                {
                    if (password == SysPwd)
                    {
                        UserName = SysUser;
                        FullName = "System";
                        GroupName = "System";
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Kiem tra dang nhap vao he thong
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool? IsLogin(string userName, string password)
        {
            TaiKhoan objTaiKhoan = DataServices.TaiKhoan.GetByTenDangNhap(userName);
            if (objTaiKhoan != null)
            {
                if (string.Compare(objTaiKhoan.MatKhau, password, false) == 0 || string.Compare(objTaiKhoan.MatKhau, PMS.Common.Globals.EncodeMD5(userName, password), false) == 0)
                {
                    UserID = objTaiKhoan.MaTaiKhoan;
                    GroupID = objTaiKhoan.MaNhomQuyen.Value;
                    UserName = objTaiKhoan.TenDangNhap;
                    FullName = objTaiKhoan.HoTen;
                    NhomQuyen objNhomQuyen = DataServices.NhomQuyen.GetByMaNhomQuyen(GroupID);
                    if (objNhomQuyen != null)
                        GroupName = objNhomQuyen.TenNhomQuyen;
                    objTaiKhoan.NgayDangNhap = DateTime.Now;
                    objTaiKhoan.TenMayTinh = SystemInformation.ComputerName;
                    objTaiKhoan.PhienBan = Application.ProductVersion;
                    if (ApplicationDeployment.IsNetworkDeployed)
                    {
                        ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                        if (ad != null)
                            objTaiKhoan.DuongDan = ad.UpdateLocation.AbsoluteUri;
                    }
                    //Update tai khoan
                    DataServices.TaiKhoan.Update(objTaiKhoan);
                    User = objTaiKhoan;
                    return true;
                }
                else
                    return false;
            }
            return null;
        }
    }
}