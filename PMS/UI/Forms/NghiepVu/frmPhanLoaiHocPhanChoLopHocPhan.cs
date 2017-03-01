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

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmPhanLoaiHocPhanChoLopHocPhan : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion
        public frmPhanLoaiHocPhanChoLopHocPhan()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmPhanLoaiHocPhanChoLopHocPhan_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewPhanLoaiHocPhan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewPhanLoaiHocPhan, new string[] { "MaGiangVienQuanLy", "HoTen", "TenMonHoc", "TenKhoa", "MaLopHocPhan", "MaLop", "Nhom", "SiSo", "SoTiet", "MaLoaiHocPhanGanMoi", "Chon" }
                , new string[] { "Mã giảng viên", "Họ và tên", "Tên môn học", "Tên khoa", "Mã lớp học phần", "Mã lớp", "Nhóm", "Sĩ số", "Số tiết", "Loại học phần", "Chọn" }
                    , new int[] { 80, 150, 200, 140, 120, 80, 50, 80, 80, 150, 80 });
            
            AppGridView.AlignHeader(gridViewPhanLoaiHocPhan, new string[] { "MaGiangVienQuanLy", "HoTen", "TenMonHoc", "TenKhoa", "MaLopHocPhan", "MaLop", "Nhom", "SiSo", "SoTiet", "MaLoaiHocPhanGanMoi", "Chon" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewPhanLoaiHocPhan, "MaGiangVienQuanLy", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewPhanLoaiHocPhan, new string[] { "MaGiangVienQuanLy", "HoTen", "TenMonHoc", "TenKhoa", "MaLopHocPhan", "MaLop", "Nhom", "SiSo", "SoTiet" });
            AppGridView.RegisterControlField(gridViewPhanLoaiHocPhan, "MaLoaiHocPhanGanMoi", repositoryItemGridLookUpEditLoaiHocPhan);
            AppGridView.SummaryField(gridViewPhanLoaiHocPhan, "MaGiangVienQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
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

            #region LoaiHocPhan
            AppGridLookupEdit.InitGridLookUp(cboLoaiHocPhan, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiHocPhan, new string[] { "MaLoaiKhoiLuong", "TenLoaiKhoiLuong", "HeSo" }, new string[] { "Mã Loại học phần", "Loại học phần", "hệ số" });
            cboLoaiHocPhan.Properties.ValueMember = "MaLoaiKhoiLuong";
            cboLoaiHocPhan.Properties.DisplayMember = "TenLoaiKhoiLuong";
            cboLoaiHocPhan.Properties.NullText = string.Empty;
            #endregion

            #region LoaiHocPhanRepo
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLoaiHocPhan, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLoaiHocPhan, new string[] { "MaLoaiKhoiLuong", "TenLoaiKhoiLuong", "HeSo" }, new string[] { "Mã Loại học phần", "Loại học phần", "hệ số" }, new int[] { 120, 150, 80 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLoaiHocPhan, 350, 500);
            repositoryItemGridLookUpEditLoaiHocPhan.ValueMember = "MaLoaiKhoiLuong";
            repositoryItemGridLookUpEditLoaiHocPhan.DisplayMember = "TenLoaiKhoiLuong";
            repositoryItemGridLookUpEditLoaiHocPhan.NullText = string.Empty;
            #endregion

            InitData();
        }
        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            TList<LoaiKhoiLuong> _listLoaiKhoiLuong = DataServices.LoaiKhoiLuong.GetAll();
            bindingSourceLoaiHocPhanRepo.DataSource = _listLoaiKhoiLuong;
            cboLoaiHocPhan.DataBindings.Clear();
            bindingSourceLoaiHocPhan.DataSource = _listLoaiKhoiLuong;
            cboLoaiHocPhan.DataBindings.Add("EditValue", bindingSourceLoaiHocPhan, "MaLoaiKhoiLuong", true, DataSourceUpdateMode.OnPropertyChanged);
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourcePhanLoaiHocPhan.DataSource = DataServices.ViewUteKhoiLuongGiangDay.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion

        #region event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnGanLoaiHocPhan_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < gridViewPhanLoaiHocPhan.DataRowCount; i++)
            {
                ViewUteKhoiLuongGiangDay v = gridViewPhanLoaiHocPhan.GetRow(i) as ViewUteKhoiLuongGiangDay;
                if (v.Chon == true)
                {
                    gridViewPhanLoaiHocPhan.SetRowCellValue(i, "MaLoaiHocPhanGanMoi", cboLoaiHocPhan.EditValue.ToString());
                    gridViewPhanLoaiHocPhan.SetRowCellValue(i, "Chon", "False");
                }
            }        
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewPhanLoaiHocPhan.FocusedRowHandle = -1;
            VList<ViewUteKhoiLuongGiangDay> list = bindingSourcePhanLoaiHocPhan.DataSource as VList<ViewUteKhoiLuongGiangDay>;
            if (list != null)
            {
                
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        string xmlData = "";
                        foreach (ViewUteKhoiLuongGiangDay cv in list)
                        {
                            xmlData += String.Format("<Input GV=\"{0}\" MH=\"{1}\" M=\"{2}\" L=\"{3}\" N=\"{4}\" LM=\"{5}\" LC=\"{6}\" />", cv.MaGiangVienQuanLy, cv.MaMonHoc, cv.MaLopHocPhan, cv.MaLop, cv.Nhom, cv.MaLoaiHocPhanGanMoi, cv.MaLoaiHocPhan);
                        }
                        bindingSourcePhanLoaiHocPhan.EndEdit();
                        xmlData = string.Format("<Root>{0}</Root>", xmlData);

                        int kq = 0;
                        DataServices.PhanLoaiHocPhan.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog())
                {
                    sf.Filter = "(*.xls)|*.xls";
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlPhanLoaiHocPhan.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
        #endregion
        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourcePhanLoaiHocPhan.DataSource = DataServices.ViewUteKhoiLuongGiangDay.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourcePhanLoaiHocPhan.DataSource = DataServices.ViewUteKhoiLuongGiangDay.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChonTatCa.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewPhanLoaiHocPhan.DataRowCount; i++)
                {
                    gridViewPhanLoaiHocPhan.SetRowCellValue(i, "Chon", "True");
                }
            }
            if (checkEditChonTatCa.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewPhanLoaiHocPhan.DataRowCount; i++)
                {
                    gridViewPhanLoaiHocPhan.SetRowCellValue(i, "Chon", "False");
                }
            }
        }
    }
}