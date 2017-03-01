using System;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using PMS.Services;
using PMS.BLL;
using PMS.Services;
using DevExpress.Skins;
using PMS.Common;

namespace PMS.UI.Forms.HeThong
{
    public partial class frmSuaThongTin : XtraForm
    {
        public frmSuaThongTin()
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
                        //Cap nhat cac field
                        UserInfo.User.HoTen = txtHoTen.Text;
                        UserInfo.User.MatKhau = txtMatKhauMoi.Text;
                        UserInfo.User.SkinName = cboSkin.Text;
                        UserInfo.SkinName = cboSkin.Text;
                        if (DataServices.TaiKhoan.Update(UserInfo.User))
                        {
                            XtraMessageBox.Show("Bạn đã thay đổi thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình thay đổi thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    UserInfo.SkinName = cboSkin.Text;
                    XtraMessageBox.Show("Bạn đã thay đổi thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmSuaThongTin_Load(object sender, EventArgs e)
        {
            foreach (SkinContainer cnt in SkinManager.Default.Skins)
                cboSkin.Properties.Items.Add(cnt.SkinName);
            if (UserInfo.LoginType == UserTypes.None)
            {
                cboSkin.SelectedItem = UserInfo.User.SkinName;
                txtHoTen.Text = UserInfo.User.HoTen;
            }
            else
            {
                txtHoTen.Text = UserInfo.FullName;
                txtHoTen.Properties.ReadOnly = true;
                cboSkin.SelectedItem = UserInfo.SkinName;
            }
        }

        private string SelectedSkinName { get { return cboSkin.Text; } }

        private void cboSkin_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SelectedSkinName);
        }
    }
}