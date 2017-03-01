using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.SQLHelper;
using DevExpress.Common.Config;
using PMS.BLL;
using PMS.UI.Forms.HeThong;
using PMS.Services;
using PMS.Core;
using PMS.Common;

namespace PMS.UI.Forms.HeThong
{
    public partial class frmDangNhap : XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap()
        {
            #region Kiem tra dieu kien
            if (string.IsNullOrEmpty(txtTenTruyCap.Text.Trim()))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên truy cập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTruyCap.Focus();
                return;
            }
            #endregion
            //Gắn tên đăng nhập để lưu log
            PMS.Data.Utility.userID = UserInfo.UserName;

            bool? isValid = UserInfo.IsLogin(txtTenTruyCap.Text, txtMatKhau.Text);

            if (isValid != null)
            {
                if (isValid == true)
                {
                    if (UserInfo.User.TrangThai == true)
                    {
                        XtraMessageBox.Show("Tên truy cập này hiện tại đã bị khóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTenTruyCap.Focus();
                        return;
                    }
                    Close();
                    //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(UserInfo.User.SkinName);
                    //UserInfo.SkinName = UserInfo.User.SkinName;
                    AppSystem.InitControl();
                    UserInfo.LoginType = UserTypes.None;
                    frmThongTin frm = new frmThongTin { MdiParent = frmMain.Instance };
                    frm.Show();
                    //Init cache
                }
                else
                {
                    XtraMessageBox.Show("Tên truy cập và mật khẩu không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                }
            }
            else
            {
                if (UserInfo.IsSystemValid(txtTenTruyCap.Text))
                {
                    if (UserInfo.IsSystemLogin(txtTenTruyCap.Text, txtMatKhau.Text))
                    {
                        Close();
                        //DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(UserInfo.SkinName);
                        AppSystem.InitSystem();
                        UserInfo.LoginType = UserTypes.System;
                        frmThongTin frm = new frmThongTin { MdiParent = frmMain.Instance };
                        frm.Show();
                    }
                    else
                    {
                        XtraMessageBox.Show("Tên truy cập và mật khẩu không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMatKhau.Focus();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Không tìm thấy tên truy cập trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenTruyCap.Focus();
                }
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            SqlHelper help = new SqlHelper(AppConnection.ConnectionString);
            if (help.CheckConnection())
            {
                try
                {
                    DangNhap();
                }
                catch(Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                using (frmConfig frm = new frmConfig())
                {
                    frm.ShowDialog(this);
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void txtTenTruyCap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtMatKhau.Focus();
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Cursor.Current = Cursors.WaitCursor;
                SqlHelper help = new SqlHelper(AppConnection.ConnectionString);
                if (help.CheckConnection())
                {
                    try
                    {
                        DangNhap();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //XtraMessageBox.Show("Đã xảy ra lỗi khi kết nối đến server.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    this.SettingApplication();
                Cursor.Current = Cursors.Default;
            }
        }

        private void SettingApplication()
        {
            using (frmConfig frm = new frmConfig())
            {
                frm.ShowDialog(this);
            }
        }

        private void txtTenTruyCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.R)
                this.SettingApplication();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.R)
                this.SettingApplication();
        }
    }
}