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
using DevExpress.XtraGrid.Columns;
using PMS.Services;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class frmPhuCapHanhChinh : DevExpress.XtraEditors.XtraForm
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


                btnLayDuLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLayDuLieu.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnLayDuLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewGiangVien> _listGiangVien;
        #endregion
        public frmPhuCapHanhChinh()
        {
            InitializeComponent();
        }

        private void frmPhuCapHanhChinh_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewPhuCapHanhChinh, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewPhuCapHanhChinh, new string[] { "MaGiangVien", "HoTen", "SoThangTruPhuCapHanhChinh", "DonGiaPhuCapHanhChinh" }
                    , new string[] { "Mã giảng viên", "Họ và tên", "Số tháng trừ PCHC", "Đơn giá PCHC" }
                    , new int[] { 90, 150, 130, 130 });
            AppGridView.ShowEditor(gridViewPhuCapHanhChinh, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewPhuCapHanhChinh, new string[] { "MaGiangVien", "HoTen", "SoThangTruPhuCapHanhChinh", "DonGiaPhuCapHanhChinh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewPhuCapHanhChinh, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewPhuCapHanhChinh, new string[] { "HoTen" });
            AppGridView.FormatDataField(gridViewPhuCapHanhChinh, "DonGiaPhuCapHanhChinh", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewPhuCapHanhChinh, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
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

            #region Init GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 400, 700);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Bộ môn" }, new int[] { 100, 150, 150 });
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            InitData();
        }
        #region InitData
        void InitData()
        {
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHocKy.Text != "")
            {
                bindingSourcePhuCapHanhChinh.DataSource = DataServices.ViewPhuCapHanhChinh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }
        #endregion
        #region Event button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewPhuCapHanhChinh);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewPhuCapHanhChinh.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VList<ViewPhuCapHanhChinh> list = bindingSourcePhuCapHanhChinh.DataSource as VList<ViewPhuCapHanhChinh>;
                if (list != null)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (ViewPhuCapHanhChinh kl in list)
                        {
                            if (kl.MaGiangVien != null)
                            {
                                xmlData += String.Format("<Input M=\"{0}\" S=\"{1}\" D=\"{2}\" />", kl.MaGiangVien, PMS.Common.Globals.IsNull(kl.SoThangTruPhuCapHanhChinh, "decimal"), PMS.Common.Globals.IsNull(kl.DonGiaPhuCapHanhChinh, "decimal"));
                            }
                        }
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);
                        bindingSourcePhuCapHanhChinh.EndEdit();
                        int kq = 0;
                        DataServices.PhuCapHanhChinh.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
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
                    gridControlPhuhCapHanhChinh.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }

        private void btnLayDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show("Lấy dữ liệu giảng viên tập sự?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataServices.PhuCapHanhChinh.LayDuLieu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    bindingSourcePhuCapHanhChinh.DataSource = DataServices.ViewPhuCapHanhChinh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }
        }
        #endregion
        #region Event Grid
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHocKy.Text != "")
            {
                bindingSourcePhuCapHanhChinh.DataSource = DataServices.ViewPhuCapHanhChinh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboHocKy.Text != "")
            {
                bindingSourcePhuCapHanhChinh.DataSource = DataServices.ViewPhuCapHanhChinh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewPhuCapHanhChinh_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            int pos = e.RowHandle;
            if (col.FieldName == "MaGiangVien")
            {
                ViewPhuCapHanhChinh v = (ViewPhuCapHanhChinh)gridViewPhuCapHanhChinh.GetRow(pos);
                string _hoten = _listGiangVien.Find(p => p.MaGiangVien == v.MaGiangVien).HoTen;
                gridViewPhuCapHanhChinh.SetRowCellValue(pos, "HoTen", _hoten);
            }
        }

        private void gridViewPhuCapHanhChinh_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewPhuCapHanhChinh, e);
        }
        #endregion

       
    }
}