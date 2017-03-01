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

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmSaoChepNamHoc : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        string NamHoc, Loai;
        #endregion

        #region Event Form

        public frmSaoChepNamHoc()
        {
            InitializeComponent();
        }


        public frmSaoChepNamHoc(string _namHoc, string _loai)
        {
            InitializeComponent();
            NamHoc = _namHoc;
            Loai = _loai;
        }

        private void frmSaoChepNamHoc_Load(object sender, EventArgs e)
        {
            #region Nam hoc nguon
            AppGridLookupEdit.InitGridLookUp(cboNamHocNguon, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHocNguon, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHocNguon.Properties.ValueMember = "NamHoc";
            cboNamHocNguon.Properties.DisplayMember = "NamHoc";
            cboNamHocNguon.Properties.NullText = string.Empty;
            cboNamHocNguon.EditValue = NamHoc;
            #endregion

            #region Nam hoc dich
            AppGridLookupEdit.InitGridLookUp(cboNamHocDich, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHocDich, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHocDich.Properties.ValueMember = "NamHoc";
            cboNamHocDich.Properties.DisplayMember = "NamHoc";
            cboNamHocDich.Properties.NullText = string.Empty;
            string namHocKeTiep="";
            DataServices.ViewNamHoc.GetNamHocKeTiep(NamHoc, ref namHocKeTiep);
            cboNamHocDich.EditValue = namHocKeTiep;
            #endregion


            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            bindingSourceNamHocDich.DataSource = DataServices.ViewNamHoc.GetAll();
        }
        #endregion

        #region Event Button
        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            try
            {
                if (Loai == "SaoChepPhanNhomMonHoc")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.PhanNhomMonHoc.SaoChepTheoNam(cboNamHocNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepPhanNhomMonHocSdh")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.SdhPhanNhomMonHoc.SaoChepTheoNam(cboNamHocNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoChucDanhLanhDao")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.DinhMucGioChuanToiThieuTheoChucVu.SaoChepTheoNam(cboNamHocNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepTietNghiaVu")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.TietNghiaVu.SaoChepTheoNam(cboNamHocNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoLopDong")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.HeSoLopDong.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
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
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.HeSoBacDaoTao.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
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
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.DonGia.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
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
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.DinhMucGioChuan.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
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
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.HeSoCoVanHocTap.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
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
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.PhanLoaiGiangVien.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
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
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.HeSoThucTap.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
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
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.HeSoNgonNgu.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
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
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.DonGiaNgoaiQuyChe.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepGiangVienTinhGioChuan")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.GiangVienTinhGioChuan.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepSoTietCoiThiTieuChuan")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.SoTietCoiThiTieuChuanCuaGiangVien.SaoChep(cboNamHocNguon.EditValue.ToString(), cboNamHocDich.EditValue.ToString());
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoNhomThucHanh")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.HeSoNhomThucHanh.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepQuyDinhCacHeSoKhac_VHU")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.QuyDoiGioChuan.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
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
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.HeSoChucDanhChuyenMon.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoThanhToanGioChuanVuotMuc")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.HeSoThanhToanGioChuanVuotMuc.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepThuLaoGiangDayThucHanh")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.ThuLaoGiangDayThucHanh.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepThuLaoGiangDayDaiHocClc")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.ThuLaoGiangDayDaiHocLopClc.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHoatDongChuyenMonKhac")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.HoatDongChuyenMonKhac.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
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
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.HeSoCoSo.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoCongViec")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.HeSoCongViec.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepThanhTraChamGiangTheoBacHeKhoaHoc")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.ThanhTraChamGiangTheoKhoaHoc.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }


                if (Loai == "SaoChepDotChiTra")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.DotChiTra.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoNgoaiGio")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.HeSoNgoaiGio.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoKhoiNganh")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.HeSoKhoiNganh.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepTienCanTren")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.QuyDinhTienCanTren.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
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
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.QuyDoiGioChuan.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }


                if (Loai == "SaoChepHeSoKhoiLuongCongThem")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.HeSoKhoiLuongCongThem.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepHeSoQuyDoiGioTroi")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.HeSoQuyDoiGioTroi.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepThoiGianNghiTamThoi")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.ThoiGianNghiTamThoiCuaGiangVien.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cboNamHocDich.Focus();
                    }
                }

                if (Loai == "SaoChepGiangVienKhongTinhGioGiang")
                {
                    if (cboNamHocNguon.EditValue != null || cboNamHocDich.EditValue != null)
                    {
                        DataServices.GiangVienKhongTinhGioGiang.SaoChep(cboNamHocNguon.EditValue.ToString(), "", cboNamHocDich.EditValue.ToString(), "");
                        XtraMessageBox.Show("Sao chép thành công, thoát giao diện sao chép.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn năm học đích.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

    }
}