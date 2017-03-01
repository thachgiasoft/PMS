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
using PMS.BLL;
using PMS.Services;
using DevExpress.XtraEditors.Controls;
using DevExpress.Common.DataForm;
using PMS.UI.Forms.BaoCao;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.Services;
using DevExpress.XtraGrid;
using PMS.Common;
using ExcelLibrary;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeDanhSachGiangVienCoHuu : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        string groupname = UserInfo.GroupName;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        private bool user = false;
        DateTime _ngayin;
        
        #endregion

        public ucThongKeDanhSachGiangVienCoHuu()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

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

        private void ucThongKeDanhSachGiangVienCoHuu_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "TenBoMon", "NgaySinh", "ChucDanh", "TrinhDoDaoTao", "ChuyenNganh", "KhoiKienThucDaiCuong", "KhoiKienThucChuyenNghiep", "NganhDaoTao", "SoSoBaoHiem" }
                , new string[] { "Mã giãng viên", "Họ tên", "Đơn vị", "Ngày, tháng, năm sinh", "Chức danh", "Trình độ đào tạo", "Chuyên môn được đào tạo", "Giảng dạy khối kiến thức đại cương", "Giảng dạy khối kiến thức chuyên nghiệp", "Ngành đào tạo tham gia chủ trì", "Số sổ BHXH" }
                , new int[] { 100, 150, 200, 100, 120, 120, 100, 150,150, 100, 100 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "TenBoMon", "NgaySinh", "ChucDanh", "TrinhDoDaoTao", "ChuyenNganh", "KhoiKienThucDaiCuong", "KhoiKienThucChuyenNghiep", "NganhDaoTao", "SoSoBaoHiem" }, DevExpress.Utils.HorzAlignment.Center);
            #endregion
            dateEditNgay.DateTime = DateTime.Now;
        }

        void InitData()
        {

            if (dateEditNgay.Text == "")
            {
                XtraMessageBox.Show("Chưa chọn ngày .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable tb = new DataTable();
                IDataReader reader=DataServices.GiangVien.GetDanhSachGiangVienCoHuuByNgay(dateEditNgay.DateTime);
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;

            }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            InitData();
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlThongKe.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                _ngayin = frmChon.NgayIn;
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
                    frm.InThongKeDanhSachGiangVienCoHuu(PMS.Common.Globals._cauhinh.TenTruong,textEditNamHoc.Text, dateEditNgay.DateTime.ToShortDateString(), _ngayin, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void dateEditNgay_EditValueChanged(object sender, EventArgs e)
        {
            if (dateEditNgay.Text != "")
            {
                DataTable tbNamHoc = new DataTable();
                IDataReader reader = DataServices.ViewNamHoc.GetNamHocByNgay(dateEditNgay.DateTime);
                tbNamHoc.Load(reader);
                bindingSourceNamHoc.DataSource = tbNamHoc;

                if (tbNamHoc.Rows.Count > 0)
                {
                    foreach (DataRow row in tbNamHoc.Rows)
                    {
                        textEditNamHoc.Text = row["YearStudy"].ToString();
                    }
                }
                else
                    textEditNamHoc.Text = "";
            }
        }

    }
}
