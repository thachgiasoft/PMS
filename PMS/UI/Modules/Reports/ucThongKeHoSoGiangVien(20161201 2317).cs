using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using DevExpress.Common.Grid;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeHoSoGiangVien : DevExpress.XtraEditors.XtraUserControl
    {
        DateTime _ngayIn;
        public ucThongKeHoSoGiangVien()
        {
            InitializeComponent();
        }

        private void ucThongKeHoSoGiangVien_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTen", "TenDonVi", "TenHoSo" }
                    , new string[] { "STT", "Mã giảng viên", "Họ tên", "Khoa - Đơn vị", "Danh sách hồ sơ" }
                    , new int[] { 50, 90, 170, 200, 550 });
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTen", "TenDonVi", "TenHoSo" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewThongKe, "TenHoSo", repositoryItemMemoEditDanhSachHoSo);
            InitData();
        }

        void InitData()
        {
            #region Init Khoa-DonVi
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = new VList<ViewKhoaBoMon>();
            _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaBoMon, string.Format("{0} - {1}", v.MaBoMon, v.TenBoMon), CheckState.Unchecked, true));
            }
            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
            #endregion

            
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboDonVi.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.GiangVien.ThongKeHoSoGiangVien(cboDonVi.EditValue.ToString());
                tbl.Load(reader);
                bindingSourceThongKe.DataSource = tbl;
            }
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
            if (vListBaoCao == null)
                return;
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

            string filter = gridViewThongKe.ActiveFilterString;
            if (filter.Contains(".0000m"))
                filter = filter.Replace(".0000m", "");
            if (filter.Contains(".000m"))
                filter = filter.Replace(".000m", "");
            if (filter.Contains(".00m"))
                filter = filter.Replace(".00m", "");
            if (filter.Contains(".0m"))
                filter = filter.Replace(".0m", "");
            if (filter.Contains(".m"))
                filter = filter.Replace(".m", "");

            DataView dv = new DataView(vListBaoCao, filter, sort, DataViewRowState.CurrentRows);
            vListBaoCao = dv.ToTable();
            if (vListBaoCao == null)
                return;

            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeHoSoGiangVien(PMS.Common.Globals._cauhinh.TenTruong, cboDonVi.Text, PMS.Common.Globals._cauhinh.NguoiLapbieu
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
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    sf.ShowDialog();
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
