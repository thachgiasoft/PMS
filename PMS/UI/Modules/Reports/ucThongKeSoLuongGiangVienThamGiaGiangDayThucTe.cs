using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.Entities;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeSoLuongGiangVienThamGiaGiangDayThucTe : DevExpress.XtraEditors.XtraUserControl
    {
        DateTime _ngayIn;
        public ucThongKeSoLuongGiangVienThamGiaGiangDayThucTe()
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

        }

        private void ucThongKeSoLuongGiangVienThamGiaGiangDayThucTe_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "NamHoc", "GraduateLevelName", "StudyTypeName", "OlogyName", "SoLuongSinhVien", "SoLuongGiangVien", "GiangVienCoHuu", "GiangVienThinhGiang" }
                    , new string[] { "STT", "Năm học", "Bậc đào tạo", "Hệ đào tạo", "Ngành đào tạo", "Số lượng sinh viên", "Tổng số giảng viên", "Giảng viên cơ hữu", "Giảng viên thỉnh giảng" }
                    , new int[] { 50, 90, 120, 150, 150, 100, 100, 100, 100 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "NamHoc", "GraduateLevelName", "StudyTypeName", "OlogyName", "SoLuongSinhVien", "SoLuongGiangVien", "GiangVienCoHuu", "GiangVienThinhGiang" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "Stt", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThongKe, "SoLuongSinhVien", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThongKe, "SoLuongGiangVien", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThongKe, "GiangVienCoHuu", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThongKe, "GiangVienThinhGiang", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewThongKe, "SoLuongSinhVien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "SoLuongGiangVien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "GiangVienCoHuu", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "GiangVienThinhGiang", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewThongKe);

            gridViewThongKe.BestFitColumns();

            dateEditNgay.DateTime = DateTime.Now;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewThongKe.BestFitColumns();

            dateEditNgay.DateTime = DateTime.Now;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (dateEditNgay.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeSoLuongGiangVienTheoHe(dateEditNgay.DateTime);
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;
                gridViewThongKe.BestFitColumns();
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        if (sf.FileName != "")
                        {
                            gridViewThongKe.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch
            { }
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


            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeGiangVienGiangTheoNamHeNganhThucTe(PMS.Common.Globals._cauhinh.TenTruong, dateEditNgay.DateTime, _ngayIn, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
