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
using PMS.UI.Forms.BaoCao;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.BLL;

namespace PMS.UI.Modules.Reports.ThongKeThanhTra
{
    public partial class ucThongKeChiTietThucGiangTheoNgay : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        VList<ViewKhoaBoMon> _listKhoaDonVi;
        DateTime _ngayIn;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion

        #region Event Form
        public ucThongKeChiTietThucGiangTheoNgay()
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
                barButtonItem1.Caption = "Cập nhật mới";
        }

        private void ucThongKeChiTietThucGiangTheoNgay_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "MaLop", "TenMonHoc", "Nhom", "Thu", "Tiet", "SoTietGhiNhan", "TietQuyDoi", "Ngay" }
                    , new string[] { "STT", "Lớp học", "Môn học", "Nhóm", "Thứ", "Tiết", "Số tiết TT", "Số tiết quy đổi", "Ngày chấm" }
                    , new int[] { 45, 100, 200, 50, 40, 60, 80, 100, 90 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "MaLop", "TenMonHoc", "Nhom", "Thu", "Tiet", "SoTietGhiNhan", "TietQuyDoi", "Ngay" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewThongKe, new string[] { "Stt", "Nhom", "Thu", "Tiet", "SoTietGhiNhan", "Ngay" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKe);

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
        #endregion

        void InitData()
        {
            dateEditTuNgay.DateTime = DateTime.Now;
            dateEditDenNgay.DateTime = DateTime.Now;

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

        #region Event Button
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboKhoaDonVi.EditValue != null && dateEditTuNgay.DateTime != null && dateEditDenNgay.DateTime != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ThanhTraTheoThoiKhoaBieu.GetByMaGiangVienTuNgayDenNgay(cboGiangVien.EditValue.ToString(), dateEditTuNgay.DateTime, dateEditDenNgay.DateTime);
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;
                Cursor.Current = Cursors.Default;
            }
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
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongKe);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThongKe.SortedColumns)
                    {
                        switch (c.SortOrder)
                        {
                            case DevExpress.Data.ColumnSortOrder.Ascending:
                                sort += string.Format("{0} ASC, ", c.FieldName);
                                break;
                            case DevExpress.Data.ColumnSortOrder.Descending:
                                sort += string.Format("{0} DESC, ", c.FieldName);
                                break;
                        }
                    }
                }
                if (sort != "")
                    sort = sort.Substring(0, sort.Length - 2);
            }

            //string filter = gridViewThongKe.ActiveFilterString;
            //if (filter.Contains(".0000m"))
            //    filter = filter.Replace(".0000m", "");
            //if (filter.Contains(".000m"))
            //    filter = filter.Replace(".000m", "");
            //if (filter.Contains(".00m"))
            //    filter = filter.Replace(".00m", "");
            //if (filter.Contains(".0m"))
            //    filter = filter.Replace(".0m", "");
            //if (filter.Contains(".m"))
            //    filter = filter.Replace(".m", "");

            //string filter = gridViewHopDongMoiGiangVien.ActiveFilterString;
            //vListBaoCao = dv.ToTable();
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongKe);

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeChiTietThucGiangTungGiangVien(PMS.Common.Globals._cauhinh.TenTruong, dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), UserInfo.FullName, _ngayIn, vListBaoCao);
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
        #endregion

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if (cboKhoaDonVi.EditValue != null)
            {
                cboGiangVien.DataBindings.Clear();
                bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetByMaDonViThongKeThanhTra(cboKhoaDonVi.EditValue.ToString());
                cboGiangVien.DataBindings.Add("EditValue", bindingSourceGiangVien, "MaQuanLy", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        private void dateEditTuNgay_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateEditDenNgay_EditValueChanged(object sender, EventArgs e)
        {
         
        }

        private void btnInTongHop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();

                if (frmChon.NgayIn.ToString("dd/MM/yyyy") == "01/01/0001")
                    return;
                _ngayIn = frmChon.NgayIn;

            }

            Cursor.Current = Cursors.WaitCursor;

            DataTable data = new DataTable();
            IDataReader reader = DataServices.ThanhTraTheoThoiKhoaBieu.ThongKeTongHopTungGiangVienTheoNgay(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime, cboGiangVien.EditValue.ToString());
            data.Load(reader);

            if (data == null)
                return;

            if (data != null && data.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeTongSoTietThucGiangCuaTungGiangVienTheoNgay(PMS.Common.Globals._cauhinh.TenTruong, dateEditTuNgay.DateTime.ToString("dd/MM/yyyy"), dateEditDenNgay.DateTime.ToString("dd/MM/yyyy"), UserInfo.FullName, _ngayIn, data);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
