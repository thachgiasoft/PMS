using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;
using DevExpress.Common.Grid;
using PMS.Services;

namespace PMS.UI.Modules.DanhMuc.KhongChinhQuy
{
    public partial class frmSaoChepNamHocHocKy_Kcq : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        string NamHoc, HocKy, Loai, LoaiKhoiLuong;
        #endregion

        #region Event Form
        public frmSaoChepNamHocHocKy_Kcq()
        {
            InitializeComponent();
        }

        public frmSaoChepNamHocHocKy_Kcq(string _namHoc, string _hocKy)
        {
            InitializeComponent();
            NamHoc = _namHoc;
            HocKy = _hocKy;
        }

        public frmSaoChepNamHocHocKy_Kcq(string _namHoc, string _hocKy, string _loai)
        {
            InitializeComponent();
            NamHoc = _namHoc;
            HocKy = _hocKy;
            Loai = _loai;
        }

        public frmSaoChepNamHocHocKy_Kcq(string _namHoc, string _hocKy, string _loai, string _loaiKhoiLuong)
        {
            InitializeComponent();
            NamHoc = _namHoc;
            HocKy = _hocKy;
            Loai = _loai;
            LoaiKhoiLuong = _loaiKhoiLuong;
        }

        private void frmSaoChepPhanNhomMonHoc_Load(object sender, EventArgs e)
        {
            #region Nam hoc nguon
            AppGridLookupEdit.InitGridLookUp(cboNamHocNguon, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHocNguon, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHocNguon.Properties.ValueMember = "NamHoc";
            cboNamHocNguon.Properties.DisplayMember = "NamHoc";
            cboNamHocNguon.Properties.NullText = string.Empty;
            cboNamHocNguon.EditValue = NamHoc;
            #endregion

            #region _hocKy nguon
            AppGridLookupEdit.InitGridLookUp(cboHocKyNguon, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKyNguon, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKyNguon.Properties.DisplayMember = "TenHocKy";
            cboHocKyNguon.Properties.ValueMember = "MaHocKy";
            cboHocKyNguon.Properties.NullText = string.Empty;
            cboHocKyNguon.EditValue = HocKy;
            #endregion
            #region Nam hoc dich
            AppGridLookupEdit.InitGridLookUp(cboNamHocDich, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHocDich, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHocDich.Properties.ValueMember = "NamHoc";
            cboNamHocDich.Properties.DisplayMember = "NamHoc";
            cboNamHocDich.Properties.NullText = string.Empty;
            #endregion

            #region _hocKy dich
            AppGridLookupEdit.InitGridLookUp(cboHocKyDich, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKyDich, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKyDich.Properties.DisplayMember = "TenHocKy";
            cboHocKyDich.Properties.ValueMember = "MaHocKy";
            cboHocKyDich.Properties.NullText = string.Empty;
            #endregion

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHocNguon.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHocNguon.EditValue.ToString());
            bindingSourceNamHocDich.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHocDich.EditValue != null)
                bindingSourceHocKyDich.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHocDich.EditValue.ToString());
        }
        #endregion

        #region Event Button
        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loai == "SaoChepTietNghiaVu")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.TietNghiaVu.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepDonGiaNgoaiQuyChe")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.KcqDonGiaNgoaiQuyChe.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepMonThucTapTotNghiep")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.KcqMonThucTapTotNghiep.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepMonKhongTinhKhoiLuong")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.MonHocKhongTinhKhoiLuong.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepQuyUocDatTenLHP")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.QuyUocDatTenLopHocPhan.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoChucDanhChuyenMon")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.HeSoChucDanhChuyenMon.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoChucDanhLanhDao")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.DinhMucGioChuanToiThieuTheoChucVu.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoCoSo")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.HeSoCoSo.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoLopDong")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.HeSoLopDong.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepDonGia")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.DonGia.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepMonTinhTheoQuyCheMoi")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.MonTinhTheoQuyCheMoi.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepCacHeSoKhac")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.QuyDoiGioChuan.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepDonGiaChamBai")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.DonGiaChamBai.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepDinhMucGioChuan")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.DinhMucGioChuan.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepDonGiaCoiThi")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.DonGiaCoiThi.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepCoVanHocTap")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.CoVanHocTap.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoLopDongTheoLoaiKhoiLuong")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.HeSoLopDong.SaoChepTheoLoaiKhoiLuong(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString(), LoaiKhoiLuong);
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoBacDaoTao")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.HeSoBacDaoTao.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoCoVanHocTap")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.HeSoCoVanHocTap.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepPhanLoaiGiangVien")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.PhanLoaiGiangVien.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoNgonNgu")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.HeSoNgonNgu.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoThucTap")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.HeSoThucTap.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepKcqMonTieuLuan")
                {
                    if (cboNamHocDich.EditValue != null && cboHocKyDich.EditValue != null)
                    {
                        DataServices.KcqMonTieuLuan.SaoChep(cboNamHocNguon.EditValue.ToString(), cboHocKyNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString(), cboHocKyDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

            }
            catch
            {
                XtraMessageBox.Show("Sao chép dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Event Cbo
        private void cboNamHocNguon_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocNguon.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHocNguon.EditValue.ToString());
        }

        private void cboNamHocDich_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocDich.EditValue != null)
                bindingSourceHocKyDich.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHocDich.EditValue.ToString());
        }
        #endregion
    }
}