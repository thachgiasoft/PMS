using System;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using PMS.BLL;
using PMS.Services;
using PMS.Common;

namespace PMS.UI.Forms.HeThong
{
    public partial class frmDoiMatKhau : XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMatKhauCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtMatKhauMoi.Focus();
        }

        private void txtMatKhauMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtXacNhan.Focus();
        }

        private void ChangePass()
        {
            if (UserInfo.LoginType == UserTypes.None)
            {
                if (UserInfo.IsLogin(UserInfo.UserName, txtMatKhauCu.Text) == true)
                {
                    if (txtMatKhauMoi.Text != txtXacNhan.Text)
                    {
                        XtraMessageBox.Show("Mật khẩu mới và xác nhận không giống nhau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtXacNhan.Focus();
                        return;
                    }
                    if (UserInfo.User != null)
                    {
                        UserInfo.User.MatKhau = PMS.Common.Globals.EncodeMD5(UserInfo.UserName, txtMatKhauMoi.Text);
                        if (DataServices.TaiKhoan.Update(UserInfo.User))
                        {
                            XtraMessageBox.Show("Bạn đã thay đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình thay đổi mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Mật khẩu cũ không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhauCu.Focus();
                }
            }
            else
            {
                if (UserInfo.IsSystemLogin(UserInfo.SysUser, txtMatKhauCu.Text))
                {
                    if (txtMatKhauMoi.Text != txtXacNhan.Text)
                    {
                        XtraMessageBox.Show("Mật khẩu mới và xác nhận không giống nhau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtXacNhan.Focus();
                        return;
                    }
                    UserInfo.ChangeSystemPassword(txtMatKhauMoi.Text);
                    XtraMessageBox.Show("Bạn đã thay đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    XtraMessageBox.Show("Mật khẩu cũ không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhauCu.Focus();
                }
            }
        }

        private void txtXacNhan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                ChangePass();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ChangePass();
        }
    }
}