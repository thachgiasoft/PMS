using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmHopDongThinhGiang : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;

                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoa.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion

        public frmHopDongThinhGiang()
        {
            InitializeComponent();
        }

        private void frmHopDongThinhGiang_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewHopDongThinhGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewHopDongThinhGiang, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenBoMon", "TenKhoa", "TongTietDaiTra", "DonGiaDaiTra", "DonGiaHopDongDaiTra_HRM", "TongTietClc", "DonGiaClc", "DonGiaHopDongClc_HRM", "TongTietDoAn", "CoHopDongThinhGiang" }
                    , new string[] { "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Bộ môn", "Khoa", "Tổng tiết đại trà", "Đơn giá đại trà", "Đơn giá hợp đồng đại trà (HRM)", "Tổng tiết CLC", "Đơn giá CLC", "Đơn giá hợp đồng CLC (HRM)", "Tổng tiết đồ án", "Có hợp đồng thỉnh giảng" }
                    , new int[] { 80, 150, 110, 100, 150, 150, 100, 90, 100, 100, 90, 100, 90, 80 });
            AppGridView.ShowEditor(gridViewHopDongThinhGiang, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHopDongThinhGiang, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenBoMon", "TenKhoa", "TongTietDaiTra", "DonGiaDaiTra", "DonGiaHopDongDaiTra_HRM", "TongTietClc", "DonGiaClc", "DonGiaHopDongClc_HRM", "TongTietDoAn", "CoHopDongThinhGiang" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewHopDongThinhGiang, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewHopDongThinhGiang, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenBoMon", "TenKhoa", "TongTietDaiTra", "DonGiaDaiTra", "DonGiaHopDongDaiTra_HRM", "TongTietClc", "DonGiaClc", "DonGiaHopDongClc_HRM", "TongTietDoAn" });
            AppGridView.FormatDataField(gridViewHopDongThinhGiang, "DonGiaDaiTra", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewHopDongThinhGiang, "DonGiaClc", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewHopDongThinhGiang, "DonGiaHopDongDaiTra_HRM", DevExpress.Utils.FormatType.Custom, "n0");
            //AppGridView.FormatDataField(gridViewHopDongThinhGiang, "DonGiaHopDongClc_HRM", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewHopDongThinhGiang, "CoHopDongThinhGiang", repositoryItemCheckEditCoHopDong);
            PMS.Common.Globals.WordWrapHeader(gridViewHopDongThinhGiang, 50);
            #endregion
            
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
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            LoadDataSource();
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHocKy.Text != "")
            {
                //bindingSourceHopDongThinhGiang.DataSource = DataServices.ViewHopDongThinhGiang.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.HopDongThinhGiang.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                foreach (DataColumn col in tb.Columns)
                    col.ReadOnly = false;
                bindingSourceHopDongThinhGiang.DataSource = tb;
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHopDongThinhGiang);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewHopDongThinhGiang.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //VList<ViewHopDongThinhGiang> list = bindingSourceHopDongThinhGiang.DataSource as VList<ViewHopDongThinhGiang>;
                //if (list != null)
                //{
                //    try
                //    {
                //        string xmlData = "";
                //        foreach (ViewHopDongThinhGiang kl in list)
                //        {
                //            if (kl.MaGiangVien != null && kl.CoHopDongThinhGiang == true)
                //            {
                //                xmlData += String.Format("<Input M=\"{0}\" C=\"{1}\" />", kl.MaGiangVien, PMS.Common.Globals.IsNull(kl.CoHopDongThinhGiang, "bool"));
                //            }
                //        }
                //        xmlData = string.Format("<Root>{0}</Root>", xmlData);
                //        bindingSourceHopDongThinhGiang.EndEdit();
                //        int kq = 0;
                //        DataServices.HopDongThinhGiang.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                //        if (kq == 0)
                //            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //    catch
                //    {
                //        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                DataTable list = bindingSourceHopDongThinhGiang.DataSource as DataTable;
                if (list != null)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (DataRow kl in list.Rows)
                        {
                            if (kl["MaGiangVien"].ToString() != "" && kl["CoHopDongThinhGiang"].ToString().ToLower() == "true")
                            {
                                xmlData += String.Format("<Input M=\"{0}\" C=\"{1}\" />", kl["MaGiangVien"], PMS.Common.Globals.IsNull(kl["CoHopDongThinhGiang"], "bool"));
                            }
                        }
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);
                        bindingSourceHopDongThinhGiang.EndEdit();
                        int kq = 0;
                        DataServices.HopDongThinhGiang.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            InitData();
            Cursor.Current = Cursors.Default;
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
                    //PMS.Common.Globals.NoWrapHeader(gridViewHopDongThinhGiang);
                    gridControlHopDongThinhGiang.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            LoadDataSource();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void gridViewHopDongThinhGiang_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHopDongThinhGiang, e);
        }
    }
}