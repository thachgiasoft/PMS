using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.BaoCao;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.BLL;

namespace PMS.UI.Modules.Reports.ThongKeThanhTra
{
    public partial class ucThongKeTongSoTietThucGiangTungGiangVien : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        DateTime _ngayIn;
        VList<ViewKhoaBoMon> _listKhoaDonVi;
        #endregion

        public ucThongKeTongSoTietThucGiangTungGiangVien()
        {
            InitializeComponent();

            TList<CauHinh> cauHinh = DataServices.CauHinh.GetAll();
            if (cauHinh != null)
            {
                foreach (CauHinh ch in cauHinh)
                {
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
                }
            }

            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

            if (_maTruong == "IUH")
                btnLamTuoi.Caption = "Cập nhật mới";
        }

        private void ucThongKeTongSoTietThucGiangTungGiangVien_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "MaLop", "TenMonHoc", "Nhom", "Lt", "Th", "SoTietGhiNhan", "TietQuyDoi" }
                    , new string[] { "STT", "Lớp học", "Môn học", "Nhóm", "Số tiết LT", "Số tiết TH", "Số tiết TG", "Số tiết quy đổi" }
                    , new int[] { 45, 100, 200, 50, 80, 80, 80, 80, 100 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "MaLop", "TenMonHoc", "Nhom", "Lt", "Th", "SoTietGhiNhan", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.SummaryField(gridViewThongKe, "Stt", "{0}", DevExpress.Data.SummaryItemType.Count);
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region _khoaDonVi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaBoMon", "TenBoMon", "TenCoSo" }, new string[] { "Mã khoa-Đơn vị", "Tên Khoa-Đơn vị", "Cơ sở" }, new int[] { 90, 250, 190 });
            AppGridLookupEdit.InitPopupFormSize(cboKhoaDonVi, 530, 650);
            cboKhoaDonVi.Properties.DisplayMember = "TenBoMon";
            cboKhoaDonVi.Properties.ValueMember = "MaBoMon";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion

            #region GiangVien
            AppGridLookupEdit.InitGridLookUp(cboGiangVien, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboGiangVien, new string[] { "MaQuanLy", "HoTen" }, new string[] { "Mã giảng viên", "Họ tên" }, new int[] { 100, 200 });
            AppGridLookupEdit.InitPopupFormSize(cboGiangVien, 300, 650);
            cboGiangVien.Properties.DisplayMember = "HoTen";
            cboGiangVien.Properties.ValueMember = "MaQuanLy";
            cboGiangVien.Properties.NullText = string.Empty;
            #endregion
            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            cboKhoaDonVi.DataBindings.Clear();
            _listKhoaDonVi = DataServices.ViewKhoaBoMon.GetAll();
            _listKhoaDonVi.Add(new ViewKhoaBoMon { MaBoMon = "-1", TenBoMon = "[Tất cả]", ThuTu = 0 });
            bindingSourceKhoaDonVi.DataSource = _listKhoaDonVi;
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);

            if (cboKhoaDonVi.EditValue != null)
            {
                cboGiangVien.DataBindings.Clear();
                bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetByMaDonViThongKeThanhTra(cboKhoaDonVi.EditValue.ToString());
                cboGiangVien.DataBindings.Add("EditValue", bindingSourceGiangVien, "MaQuanLy", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }
        #endregion

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if (cboKhoaDonVi.EditValue != null)
            {
                cboGiangVien.DataBindings.Clear();
                bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetByMaDonViThongKeThanhTra(cboKhoaDonVi.EditValue.ToString());
                cboGiangVien.DataBindings.Add("EditValue", bindingSourceGiangVien, "MaQuanLy", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboGiangVien.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ThanhTraTheoThoiKhoaBieu.ThongKeTongHopTheoHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboGiangVien.EditValue.ToString());
                tb.Load(reader);
                bindingSourceThongke.DataSource = tb;
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();

                if (frmChon.NgayIn.ToString("dd/MM/yyyy") == "01/01/0001")
                    return;
                _ngayIn = frmChon.NgayIn;

            }

            Cursor.Current = Cursors.WaitCursor;
            gridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongke.EndEdit();
            DataTable data = bindingSourceThongke.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongke);

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeTongSoTietThucGiangCuaTungGiangVien(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.Text, UserInfo.FullName, _ngayIn, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog file = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (file.FileName != "")
                    {
                        gridControlThongKe.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
