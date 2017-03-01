using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using PMS.Common;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;
using PMS.BLL;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeNhatnXetDanhGiaVuotGioGVCH : DevExpress.XtraEditors.XtraUserControl
    {

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        VList<ViewKhoa> _vListKhoaBoMon;
        string groupname = UserInfo.GroupName;
        string _maTruong;
        #endregion
        public ucThongKeNhatnXetDanhGiaVuotGioGVCH()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucThongKeNhatnXetDanhGiaVuotGioGVCH_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TietNghiaVu", "TenHocVi", "NoiDungDanhGia", "ThoiGianLamViecQuyDinh", "DanhGiaThoiGianThucHien", "PhanTramDanhGia", "GhiChu" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Chức danh", "Định mức chuẩn", "Trình độ", "Nội dung đánh giá", "Thời gian làm việc quy định", "Giờ thực hiện", "Phần trăm đánh giá (%)", "Ghi chú" }
                    , new int[] { 90, 140, 90, 90, 90, 100, 90, 90, 90, 90, 99, 99 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TietNghiaVu", "TenHocVi", "NoiDungDanhGia", "ThoiGianLamViecQuyDinh", "DanhGiaThoiGianThucHien", "PhanTramDanhGia", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.MergeCell(gridViewThongKe, new string[] { "ThoiGianLamViecQuyDinh", "DanhGiaThoiGianThucHien", "PhanTramDanhGia", "GhiChu" });
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            WordWrapHeader(gridViewThongKe, 50);

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Khoa - Don vi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" });
            cboKhoaDonVi.Properties.ValueMember = "MaKhoa";
            cboKhoaDonVi.Properties.DisplayMember = "TenKhoa";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }
        void WordWrapHeader(GridView grid, int height)
        {
            for (int i = 0; i < grid.Columns.Count; i++)
                grid.Columns[i].AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            AutoHeightHelper a = new AutoHeightHelper(gridViewThongKe, height);
            a.EnableColumnPanelAutoHeight();
        }

        void InitGiangVien()
        {
            #region GiangVien
            if (cboKhoaDonVi.EditValue != null)
            {
                cboGiangVien.Properties.SelectAllItemCaption = "Tất cả";
                cboGiangVien.Properties.Items.Clear();
                cboGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
                VList<ViewGiangVien> _listGV = new VList<ViewGiangVien>();
                _listGV = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());

                List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();

                foreach (ViewGiangVien v in _listGV)
                {
                    list.Add(new CheckedListBoxItem(v.MaGiangVien, v.HoTen, CheckState.Unchecked, true));
                }
                cboGiangVien.Properties.Items.AddRange(list.ToArray());
                cboGiangVien.Properties.SeparatorChar = ';';
                cboGiangVien.CheckAll();
            }
            #endregion
        }

        void InitData()
        {
            InitGiangVien();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            cboKhoaDonVi.DataBindings.Clear();

            _vListKhoaBoMon = DataServices.ViewKhoa.GetAll();

            if (_maTruong == "CTIM")
            {
                VList<ViewKhoa> v = _vListKhoaBoMon.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoa>;
                if (v.Count > 0)
                {
                    _vListKhoaBoMon = _vListKhoaBoMon.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoa>;
                }
                else
                    _vListKhoaBoMon = DataServices.ViewKhoa.GetAll();
            }


            bindingSourceKhoaDonVi.DataSource = _vListKhoaBoMon;

            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);
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
            if (cboNamHoc.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KetQuaDanhGiaVuotGio.ThongKeByNamHocKhoaDonViMaGiangVien(cboNamHoc.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cboGiangVien.EditValue.ToString());
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;
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
                    frm.InThongKeNhanXetDanhGiaVuotGio(cboKhoaDonVi.Text, cboNamHoc.EditValue.ToString(), UserInfo.FullName, _ngayIn, vListBaoCao);
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

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            InitGiangVien();
        }
    }
}
