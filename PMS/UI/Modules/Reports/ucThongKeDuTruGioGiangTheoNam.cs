using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeDuTruGioGiangTheoNam : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        #endregion
        public ucThongKeDuTruGioGiangTheoNam()
        {
            InitializeComponent();

            #region Init CauHinh
            TList<CauHinh> listCauHinh = DataServices.CauHinh.GetAll() as TList<CauHinh>;
            foreach (CauHinh ch in listCauHinh)
                if (ch.TrangThai == true)
                    PMS.Common.Globals._cauhinh = ch;
            #endregion
        }

        private void ucThongKeDuTruGioGiangTheoNam_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThongKe, false, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThongKe, new string[] { "TenDonVi", "SoLuongGiangVien", "GioGiangHk01", "GioKhacHk01", "SoTietGiamTruKhacHk01", "SoTietNghiaVuHk01", "GioVuotHk01", "GioGiangHk02", "GioKhacHk02", "SoTietGiamTruKhacHk02", "SoTietNghiaVuHk02", "GioVuotHk02", "GioGiangCaNam", "GioKhacCaNam", "SoTietGiamTruKhacCaNam", "SoTietNghiaVuCaNam", "GioVuotCaNam", "TiLeVuot" }
                , new string[] { "Tên khoa - Đơn vị", "Số lượng giảng viên", "Giờ giảng HK01", "Giờ khác HK01", "Giảm trừ khác HK01", "Định mức HK01", "Giờ vượt HK01", "Giờ giảng HK02", "Giờ khác HK02", "Giảm trừ khác HK02", "Định mức HK02", "Giờ vượt HK02", "Giờ giảng cả năm", "Giờ khác cả năm", "Giảm trừ khác cả năm", "Định mức cả năm", "Giờ vượt cả năm", "Tỉ lệ vượt" }
                , new int[] { 150, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60, 60 });
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 50);
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "TenDonVi", "SoLuongGiangVien", "GioGiangHk01", "GioKhacHk01", "SoTietGiamTruKhacHk01", "SoTietNghiaVuHk01", "GioVuotHk01", "GioGiangHk02", "GioKhacHk02", "SoTietGiamTruKhacHk02", "SoTietNghiaVuHk02", "GioVuotHk02", "GioGiangCaNam", "GioKhacCaNam", "SoTietGiamTruKhacCaNam", "SoTietNghiaVuCaNam", "GioVuotCaNam", "TiLeVuot" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "TenDonVi", "{0}", DevExpress.Data.SummaryItemType.Count);

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            gridViewThongKe.ExpandAllGroups();
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.DuTruGioGiangTruocThoiKhoaBieu.ThongKeTheoNam(cboNamHoc.EditValue.ToString());
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;
            }
            Cursor.Current = Cursors.Default;
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
            //    return;
//            int dem = vListBaoCao.Rows.Count;


            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeDuTruGioGiangTruocTKBTheoNam(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), PMS.Common.Globals._cauhinh.NguoiLapbieu
                        , _ngayIn, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlThongKe.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }
    }
}
