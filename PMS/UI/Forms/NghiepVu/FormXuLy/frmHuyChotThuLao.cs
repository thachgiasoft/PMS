using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu.FormXuLy
{
    public partial class frmHuyChotThuLao : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        string _namHoc, _hocKy, _tenDotThanhToan, _khoaDonVi;
        int _lanChot, _dotThanhToan;
        #endregion

        public frmHuyChotThuLao()
        {
            InitializeComponent();
        }

        public frmHuyChotThuLao(string nam_hoc, string hoc_ky, int lan_chot)
        {
            InitializeComponent();
            _namHoc = nam_hoc;
            _hocKy = hoc_ky;
            _lanChot = lan_chot;
        }

        public frmHuyChotThuLao(string nam_hoc, string hoc_ky, int dot_thanh_toan, string ten_dot, int lan_chot)
        {
            InitializeComponent();
            _namHoc = nam_hoc;
            _hocKy = hoc_ky;
            _lanChot = lan_chot;
            _dotThanhToan = dot_thanh_toan;
            _tenDotThanhToan = ten_dot;
        }

        public frmHuyChotThuLao(string nam_hoc, string hoc_ky, string khoa_don_vi, int lan_chot)
        {
            InitializeComponent();
            _namHoc = nam_hoc;
            _hocKy = hoc_ky;
            _khoaDonVi = khoa_don_vi;
            _lanChot = lan_chot;
        }

        private void frmHuyChotThuLao_Load(object sender, EventArgs e)
        {
            txtLanChot.Text = _lanChot.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (_dotThanhToan > 0)
                HuyTheoDoThanhToan();
            else if(_khoaDonVi != null)
                HuyTheoNamHocHocKyKhoaDonVi();
            else
                HuyTheoNamHocHocKy();
        }

        #region Ham Huy chot
        void HuyTheoNamHocHocKy()
        {
            if (txtMatKhau.Text == UserInfo.User.MatKhau || PMS.Common.Globals.EncodeMD5(UserInfo.UserName, txtMatKhau.Text) == UserInfo.User.MatKhau)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn huỷ chốt thanh toán lần thứ {0} năm học {1} - {2}", _lanChot.ToString(), _namHoc, _hocKy), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = 0;
                    DataServices.KetQuaThanhToanThuLao.HuyChotThuLao(_namHoc, _hocKy, _lanChot, ref kq);
                    if (kq == 0)
                    {
                        XtraMessageBox.Show("Huỷ thành công, thoát giao diện huỷ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        XtraMessageBox.Show("Thao tác huỷ thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Sai mật khẩu. Vui lòng nhập đúng mật khẩu người dùng đang đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
            }
        }

        void HuyTheoNamHocHocKyKhoaDonVi()
        {
            if (txtMatKhau.Text == UserInfo.User.MatKhau || PMS.Common.Globals.EncodeMD5(UserInfo.UserName, txtMatKhau.Text) == UserInfo.User.MatKhau)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn huỷ chốt thanh toán lần thứ {0} năm học {1} - {2}", _lanChot.ToString(), _namHoc, _hocKy), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = 0;
                    DataServices.KetQuaThanhToanThuLao.HuyChotThuLaoKhoaDonVi(_namHoc, _hocKy, _khoaDonVi, _lanChot, ref kq);
                    if (kq == 0)
                    {
                        XtraMessageBox.Show("Huỷ thành công, thoát giao diện huỷ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        XtraMessageBox.Show("Thao tác huỷ thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Sai mật khẩu. Vui lòng nhập đúng mật khẩu người dùng đang đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
            }
        }

        void HuyTheoDoThanhToan()
        {
            if (txtMatKhau.Text == UserInfo.User.MatKhau || PMS.Common.Globals.EncodeMD5(UserInfo.UserName, txtMatKhau.Text) == UserInfo.User.MatKhau)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn huỷ chốt thanh toán lần thứ {0} năm học {1} - {2} - {3}", _lanChot.ToString(), _namHoc, _hocKy, _tenDotThanhToan), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int kq = 0;
                    DataServices.KetQuaThanhToanThuLao.HuyChotThuLaoTheoDot(_namHoc, _hocKy, _dotThanhToan, _lanChot, ref kq);
                    if (kq == 0)
                    {
                        XtraMessageBox.Show("Huỷ thành công, thoát giao diện huỷ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        XtraMessageBox.Show("Thao tác huỷ thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Sai mật khẩu. Vui lòng nhập đúng mật khẩu người dùng đang đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
            }
        }
        #endregion
    }
}