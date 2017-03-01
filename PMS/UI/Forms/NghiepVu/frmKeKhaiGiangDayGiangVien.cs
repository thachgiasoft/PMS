using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.BaoCao;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmKeKhaiGiangDayGiangVien : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string tenTruong = "", namHoc = "", hoTenGV = "", donVi = "", chucDanh = "";
        double soTietNghiaVu = 0;
        #endregion
        #region Event Form
        public frmKeKhaiGiangDayGiangVien()
        {
            InitializeComponent();
        }

        private void frmKeKhaiGiangDayGiangVien_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewBangKeKhai, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewBangKeKhai, new string[] { "MaLop", "TenMonHoc", "SoTietThucTe", "SoTietThucTeQuyDoi", "SoLuong", "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "SoTietQuyDoi", "TenBacDaoTao", "PhanLoai" }
                                                         , new string[] { "Lớp", "Môn giảng", "STTT", "STTTQD", "Sĩ số lớp", "KQ", "KB", "KN", "KC", "KD", "KV", "STQD", "Phần kê khai các lớp", "Đào tạo theo" }
                                                         , new int[] { 150, 200, 70, 70, 90, 70, 70, 70, 70, 70, 70, 70, 100, 100 });
            AppGridView.AlignHeader(gridViewBangKeKhai, new string[] { "MaLop", "TenMonHoc", "SoTietThucTe", "SoTietThucTeQuyDoi", "SoLuong", "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "SoTietQuyDoi", "TenBacDaoTao", "PhanLoai" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewBangKeKhai, new string[] { "SoTietThucTe", "SoTietThucTeQuyDoi", "SoLuong", "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "SoTietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewBangKeKhai);
            AppGridView.SummaryField(gridViewBangKeKhai, "MaLop", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewBangKeKhai, "SoTietThucTe", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewBangKeKhai, "SoTietThucTeQuyDoi", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewBangKeKhai, "SoTietQuyDoi", "{0}", DevExpress.Data.SummaryItemType.Sum);
            gridViewBangKeKhai.Columns["TenBacDaoTao"].GroupIndex = 0;
            gridViewBangKeKhai.Columns["PhanLoai"].GroupIndex = 1;
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            #endregion

            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;

            #region GiangVien
            AppGridLookupEdit.InitGridLookUp(cboGiangVien, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboGiangVien, new string[] { "MaQuanLy", "HoTen", "NgaySinh" }, new string[] { "Mã giảng viên", "Họ tên", "Ngày sinh" });
            cboGiangVien.Properties.ValueMember = "MaQuanLy";
            cboGiangVien.Properties.DisplayMember = "HoTen";
            cboGiangVien.Properties.NullText = string.Empty;
            #endregion
            InitData();
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetAll();
            //cboGiangVien.DataBindings.Clear();
            //cboGiangVien.DataBindings.Add("EditValue", bindingSourceGiangVien, "MaQuanLy", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion

        #region Event button
        private void btnLocDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            cboGiangVien.Text = "";
            txtHoTen.Text = "";
            txtDonVi.Text = "";
            txtChucDanh.Text = "";
            txtSoTietNghiaVu.Text = "";
            txtDonGiaTieuChuan.Text = "";
            bindingSourceBangKeKhai.DataSource = null;
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable dt = bindingSourceBangKeKhai.DataSource as DataTable;
            tenTruong = _cauHinhChung.Find(p=>p.TenCauHinh == "Tên trường").GiaTri;
            namHoc = cboNamHoc.EditValue.ToString();
            hoTenGV = txtHoTen.Text;
            float _dinhMucNCKH, _thucHienNCKH;
            TList<NghienCuuKhoaHoc> listNCKH = DataServices.NghienCuuKhoaHoc.GetByMaQuanLyNamHoc(cboGiangVien.EditValue.ToString(), cboNamHoc.EditValue.ToString());
            if (listNCKH.Count > 0)
            {
                NghienCuuKhoaHoc nckh = listNCKH[0];
                _dinhMucNCKH = (float)nckh.SoTietDinhMuc;
                _thucHienNCKH = (float)nckh.SoTietThucHien;
            }
            else
            {
                _dinhMucNCKH = 0; _thucHienNCKH = 0;
            }
            float _heSoVuotDinhMuc = float.Parse(_cauHinhChung.Find(p => p.TenCauHinh == "Hệ số vượt định mức").GiaTri);
            TList<GiangVienTamUng> listTamUng = DataServices.GiangVienTamUng.GetByMaQuanLyGiangVienNamHoc(cboGiangVien.EditValue.ToString(), cboNamHoc.EditValue.ToString());
            using (frmBaoCao frm = new frmBaoCao())
            {
                frm.InBangKeKhaiThanhToanTienGiang(tenTruong, namHoc, hoTenGV, donVi, chucDanh, soTietNghiaVu.ToString(), txtDonGiaTieuChuan.Text, _dinhMucNCKH, _thucHienNCKH, _heSoVuotDinhMuc, dt, listTamUng);
                frm.ShowDialog();
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.Text != "" && cboGiangVien.Text != "")
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KhoiLuongQuyDoi.GetByMaGiangVienNamHoc(cboGiangVien.EditValue.ToString(), cboNamHoc.EditValue.ToString());
                dt.Load(reader);
                bindingSourceBangKeKhai.DataSource = dt;
                gridViewBangKeKhai.ExpandAllGroups();

                txtHoTen.Text = cboGiangVien.Text;
                DataServices.GiangVien.GetDonVi(cboGiangVien.EditValue.ToString(), ref donVi);
                txtDonVi.Text = donVi;
                ViewGiangVien ttGV = bindingSourceGiangVien.Current as ViewGiangVien;
                chucDanh = String.Format("{0} - {1}", ttGV.TenHocHam, ttGV.TenHocVi);
                txtChucDanh.Text = chucDanh;
                DataServices.GiangVien.GetSoTietNghiaVuByMaQuanLyNamHoc(cboGiangVien.EditValue.ToString(), cboNamHoc.EditValue.ToString(), ref soTietNghiaVu);
                soTietNghiaVu = Math.Round(soTietNghiaVu, 0, MidpointRounding.AwayFromZero);
                txtSoTietNghiaVu.Text = soTietNghiaVu.ToString();
                txtDonGiaTieuChuan.Text = _cauHinhChung.Find(p => p.TenCauHinh == "Đơn giá tiết chuẩn").GiaTri;
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGiangVien.Focus();
            }
            Cursor.Current = Cursors.Default;
        }

        #endregion
    }
}