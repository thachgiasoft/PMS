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

namespace PMS.UI.Modules.Reports.NCKH
{
    public partial class ucTrichXuatThongTinGiangVienTheoChuyenMonTrinhDo : DevExpress.XtraEditors.XtraUserControl
    {
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;

        public ucTrichXuatThongTinGiangVienTheoChuyenMonTrinhDo()
        {
            InitializeComponent();
        }

        private void ucTrichXuatThongTinGiangVienTheoChuyenMonTrinhDo_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThongKe, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "TenKhoa", "MaHocHam", "TenHocHam", "MaHocVi", "TenHocVi", "TenTinhTrang", "TenLoaiGiangVien", "GioiTinh", "NgaySinh", "NoiSinh", "Cmnd", "DiaChi", "SoDiDong", "Email", "ChuyenNganh" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Khoa - Đơn vị", "Mã học hàm", "Tên học hàm", "Mã học vị", "Tên học vị", "tình trạng", "Loại giảng viên", "Giới tính", "Ngày sinh", "Nơi sinh", "CMND", "Địa chỉ", "Số di động", "Email", "Chuyên ngành" }
                    , new int[] { 80, 110, 60, 130, 100, 100, 100, 100, 100, 100, 80, 90, 100, 80, 130, 90, 90, 120 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "TenKhoa", "MaHocHam", "TenHocHam", "MaHocVi", "TenHocVi", "TenTinhTrang", "TenLoaiGiangVien", "GioiTinh", "NgaySinh", "NoiSinh", "Cmnd", "DiaChi", "SoDiDong", "Email", "ChuyenNganh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 40);
            AppGridView.FixedField(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);

            InitData();
        }

        void InitData()
        {
            dateEditNgay.DateTime = DateTime.Now;

            #region Init HocHam
            cboHocHam.Properties.SelectAllItemCaption = "Tất cả";
            cboHocHam.Properties.TextEditStyle = TextEditStyles.Standard;
            cboHocHam.Properties.Items.Clear();

            TList<HocHam> _vListHH = new TList<HocHam>();
            _vListHH = DataServices.HocHam.GetAll();

            List<CheckedListBoxItem> _listHH = new List<CheckedListBoxItem>();
            foreach (HocHam v in _vListHH)
            {
                _listHH.Add(new CheckedListBoxItem(v.MaHocHam, v.TenHocHam, CheckState.Unchecked, true));
            }
            cboHocHam.Properties.Items.AddRange(_listHH.ToArray());
            cboHocHam.Properties.SeparatorChar = ';';
            cboHocHam.CheckAll();
            #endregion
            
            #region Init HocVi
            cboHocVi.Properties.SelectAllItemCaption = "Tất cả";
            cboHocVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboHocVi.Properties.Items.Clear();

            TList<HocVi> _vListHV = new TList<HocVi>();
            _vListHV = DataServices.HocVi.GetAll();

            List<CheckedListBoxItem> _listHV = new List<CheckedListBoxItem>();
            foreach (HocVi v in _vListHV)
            {
                _listHV.Add(new CheckedListBoxItem(v.MaHocVi, v.TenHocVi, CheckState.Unchecked, true));
            }
            cboHocVi.Properties.Items.AddRange(_listHV.ToArray());
            cboHocVi.Properties.SeparatorChar = ';';
            cboHocVi.CheckAll();
            #endregion
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboHocHam.EditValue != null && cboHocVi.EditValue != null && dateEditNgay.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.GiangVien.TrichXuatThongTinTheoChuyenMonTrinhDo(dateEditNgay.DateTime, cboHocHam.EditValue.ToString(), cboHocVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;
                gridViewThongKe.ExpandAllGroups();
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
                    frm.InTrichXuatThongTinGiangVienTheoChuyenMonTrinhDo(PMS.Common.Globals._cauhinh.TenTruong, dateEditNgay.DateTime.ToString("dd/MM/yyyy"), UserInfo.FullName, _ngayIn, vListBaoCao);
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
