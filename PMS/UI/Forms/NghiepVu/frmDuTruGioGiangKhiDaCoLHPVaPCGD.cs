using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmDuTruGioGiangKhiDaCoLHPVaPCGD : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnTinhQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnTinhQuyDoi.ShortCut = Shortcut.None;
            }
            else
            {
                btnTinhQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        #endregion
        
        
        public frmDuTruGioGiangKhiDaCoLHPVaPCGD()
        {
            #region Init CauHinh
            TList<CauHinh> listCauHinh = DataServices.CauHinh.GetAll() as TList<CauHinh>;
            foreach (CauHinh ch in listCauHinh)
                if (ch.TrangThai == true)
                    PMS.Common.Globals._cauhinh = ch;
            #endregion

            InitializeComponent();
        }

        private void frmDuTruGioGiangKhiDaCoLHPVaPCGD_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewDuTru, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewDuTru, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "MaMonHoc", "TenMonHoc", "TenLopHocPhan", "Nhom", "Lt", "Th", "SiSo", "MaBacDaoTao", "HeSoBacDaoTao", "HeSoLopDong", "HeSoMonThucTap", "HeSoCoVanHocTap", "SoTietQuyDoi" }
                , new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị", "Học hàm", "Học vị", "Loại giảng viên", "Mã học phần", "Tên học phần", "Lớp học phần", "Nhóm", "LT", "TH", "Sĩ số", "Bậc đào tạo", "Hệ số bậc đào tạo", "Hệ số lớp đông", "Hệ số môn thực tập", "Hệ số cố vấn học tập", "Số tiết quy đổi" }
                , new int[] { 70, 150, 150, 100, 100, 100, 90, 150, 100, 50, 80, 60, 70, 70, 70, 70, 70, 70, 70 });
            AppGridView.AlignHeader(gridViewDuTru, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "MaMonHoc", "TenMonHoc", "TenLopHocPhan", "Nhom", "Lt", "Th", "SiSo", "MaBacDaoTao", "HeSoBacDaoTao", "HeSoLopDong", "HeSoMonThucTap", "HeSoCoVanHocTap", "SoTietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewDuTru);
            AppGridView.AlignField(gridViewDuTru, new string[] { "Lt", "Th", "Nhom", "SiSo", "MaBacDaoTao", "HeSoBacDaoTao", "HeSoLopDong", "HeSoMonThucTap", "HeSoCoVanHocTap" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewDuTru, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewDuTru, "Lt", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewDuTru, "Th", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewDuTru, "SoTietQuyDoi", "{0}", DevExpress.Data.SummaryItemType.Sum);
            gridViewDuTru.Columns["TenDonVi"].GroupIndex = 0;
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

            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.DuTruGioGiangTruocThoiKhoaBieu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                bindingSourceDuTru.DataSource = tb;
            }
            gridViewDuTru.ExpandAllGroups();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.DuTruGioGiangTruocThoiKhoaBieu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                bindingSourceDuTru.DataSource = tb;
            }
            gridViewDuTru.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.DuTruGioGiangTruocThoiKhoaBieu.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                bindingSourceDuTru.DataSource = tb;
            }
            gridViewDuTru.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void btnTinhQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show(string.Format("Tính dự trù giờ giảng năm học {0} - {1}?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        DataServices.DuTruGioGiangTruocThoiKhoaBieu.TinhQuyDoi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                        Cursor.Current = Cursors.Default;
                        XtraMessageBox.Show("Tính dự trù giờ giảng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cursor.Current = Cursors.WaitCursor;
                        InitData();
                        Cursor.Current = Cursors.Default;
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình tính dự trù giờ giảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                _ngayIn = frmChon.NgayIn;
            }
            Cursor.Current = Cursors.WaitCursor;
            gridViewDuTru.FocusedRowHandle = -1;
            bindingSourceDuTru.EndEdit();
            DataTable data = bindingSourceDuTru.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewDuTru, bindingSourceDuTru);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewDuTru.SortedColumns)
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

            //string filter = gridViewDuTru.ActiveFilterString;
            ////if (filter.Contains(".0000m"))
            ////    filter = filter.Replace(".0000m", "");
            ////if (filter.Contains(".000m"))
            ////    filter = filter.Replace(".000m", "");
            ////if (filter.Contains(".00m"))
            ////    filter = filter.Replace(".00m", "");
            ////if (filter.Contains(".0m"))
            ////    filter = filter.Replace(".0m", "");
            ////if (filter.Contains(".m"))
            ////    filter = filter.Replace(".m", "");

            //DataView dv = new DataView(vListBaoCao, filter, sort, DataViewRowState.CurrentRows);
            ////vListBaoCao = dv.ToTable();
            ////if (vListBaoCao == null)
            //    return;

            int dem = vListBaoCao.Rows.Count;


            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InDuTruGioGiangChiTietTruocTKB(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), PMS.Common.Globals._cauhinh.NguoiLapbieu,_ngayIn, vListBaoCao);
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
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlDuTru.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
    }
}