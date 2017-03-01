using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu.FormXuLy
{
    public partial class frmXacNhanLaiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        string NamHoc, HocKy, Loai, DotThanhToan;
        public string KhoaDonVi { get; set; }

        public frmXacNhanLaiMatKhau()
        {
            InitializeComponent();
        }

        public frmXacNhanLaiMatKhau(string namhoc, string hocky)
        {
            InitializeComponent();
            NamHoc = namhoc;
            HocKy = hocky;
        }

        public frmXacNhanLaiMatKhau(string namhoc, string hocky, string loai)
        {
            InitializeComponent();
            NamHoc = namhoc;
            HocKy = hocky;
            Loai = loai;
        }

        public frmXacNhanLaiMatKhau(string namhoc, string hocky, string dotthanhtoan, string loai)
        {
            InitializeComponent();
            NamHoc = namhoc;
            HocKy = hocky;
            Loai = loai;
            DotThanhToan = dotthanhtoan;
        }

        private void frmXacNhanLaiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (PMS.Common.XuLyChuoi.soSanhMatKhau(UserInfo.UserName, txtMatKhau.Text, UserInfo.User.MatKhau))
                //txtMatKhau.Text == UserInfo.User.MatKhau || PMS.Common.Globals.EncodeMD5(UserInfo.UserName, txtMatKhau.Text) == UserInfo.User.MatKhau)
            {
                if (Loai == "HuyHuongDanCuoiKhoa")
                {
                    DataServices.ThuLaoHuongDanCuoiKhoa.HuyChotKhoiLuong(NamHoc, HocKy);
                    XtraMessageBox.Show("Huỷ chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

                if (Loai == "HuyXetDuyetLuanVanCaoHoc")
                {
                    DataServices.XetDuyetDeCuongLuanVanCaoHoc.HuyChot(NamHoc, HocKy);
                    XtraMessageBox.Show("Huỷ chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

                if (Loai == "HuyThamDinhLuanVanThacSy")
                {
                    DataServices.ThamDinhLuanVanThacSy.HuyChot(NamHoc, HocKy);
                    XtraMessageBox.Show("Huỷ chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

                if (Loai == "HuyThuLaoChamBai")
                {
                    DataServices.ThuLaoChamBai.HuyChotTheoKhoa(NamHoc, HocKy, KhoaDonVi, DotThanhToan);
                    XtraMessageBox.Show("Huỷ chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                if (Loai == "HuyThuLaoCoiThi")
                {
                    DataServices.ThuLaoCoiThi.HuyChotTheoKhoa(NamHoc, HocKy, KhoaDonVi, DotThanhToan);
                    XtraMessageBox.Show("Huỷ chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                
                if (Loai == "HuyHuongDanKhoaLuanThucTap")
                {
                    DataServices.HuongDanKhoaLuanThucTap.HuyChotTheoKhoa(NamHoc, HocKy, KhoaDonVi);
                    XtraMessageBox.Show("Huỷ chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

                if (Loai == "HuyCacKhoiLuongKhac_VHU")
                {
                    DataServices.KhoiLuongCacCongViecKhac.HuyChot(NamHoc, HocKy);
                    XtraMessageBox.Show("Huỷ chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

                if (Loai == "HuyThuLaoCoiThi_VHU")
                {
                    DataServices.ThuLaoCoiThiVhu.HuyChot(NamHoc, HocKy);
                    XtraMessageBox.Show("Huỷ chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

                if (Loai == "HuyThuLaoChamBai_VHU")
                {
                    DataServices.ThuLaoChamBaiVhu.HuyChot(NamHoc, HocKy);
                    XtraMessageBox.Show("Huỷ chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

                if (Loai == "HuyThuLaoRaDe_VHU")
                {
                    DataServices.ThuLaoRaDeVhu.HuyChot(NamHoc, HocKy);
                    XtraMessageBox.Show("Huỷ chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

                if (Loai == "HuyCacKhoiLuongKhacTheoDot")
                {
                    DataServices.KhoiLuongCacCongViecKhac.HuyChotTheoDot(NamHoc, HocKy, int.Parse(DotThanhToan));
                    XtraMessageBox.Show("Huỷ chốt thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }

            }
            else
            {
                XtraMessageBox.Show("Mật khẩu không chính xác. Vui lòng nhập đúng mật khẩu người dùng đang đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}