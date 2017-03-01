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
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucLopHocPhanChuyenNganh : DevExpress.XtraEditors.XtraUserControl
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
        #endregion
        public ucLopHocPhanChuyenNganh()
        {
            InitializeComponent();
        }

        private void ucLopHocPhanChuyenNganh_Load(object sender, EventArgs e)
        {
            #region Init Grid
            AppGridView.InitGridView(gridViewLHPChuyenNganh, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewLHPChuyenNganh, new string[] { "MaLopHocPhan", "TenLopHocPhan", "MaMonHoc", "TenMonHoc", "MaLop", "Nhom", "SiSo", "TenLoaiHocPhan", "TrangThai" }
                    , new string[] { "Mã lớp học phần", "Tên lớp học phần", "Mã môn học", "tên môn học", "Mã lớp", "Nhóm", "Sĩ số đăng ký", "Loại học phần", "Lớp học phần chuyên ngành" }
                    , new int[] { 110, 100, 80, 180, 80, 70, 90, 90, 120 });
            AppGridView.AlignHeader(gridViewLHPChuyenNganh, new string[] { "MaLopHocPhan", "TenLopHocPhan", "MaMonHoc", "TenMonHoc", "MaLop", "Nhom", "SiSo", "TenLoaiHocPhan", "TrangThai" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewLHPChuyenNganh, new string[] { "MaLopHocPhan", "TenLopHocPhan", "MaMonHoc", "TenMonHoc", "MaLop", "Nhom", "SiSo", "TenLoaiHocPhan" });

            AppGridView.SummaryField(gridViewLHPChuyenNganh, "MaLopHocPhan", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewLHPChuyenNganh, "TrangThai", "{0}", DevExpress.Data.SummaryItemType.Sum);
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

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceLHPChuyenNganh.DataSource = DataServices.ViewLopHocPhanChuyenNganh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewLHPChuyenNganh.FocusedRowHandle = -1;
            VList<ViewLopHocPhanChuyenNganh> list = bindingSourceLHPChuyenNganh.DataSource as VList<ViewLopHocPhanChuyenNganh>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        string xmlData = "";
                        foreach (ViewLopHocPhanChuyenNganh cv in list)
                        {
                            if (cv.TrangThai == true)
                                xmlData += cv.MaLopHocPhan + ";";
                        }
                        bindingSourceLHPChuyenNganh.EndEdit();

                        int kq = 0;
                        DataServices.LopHocPhanChuyenNganh.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
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

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceLHPChuyenNganh.DataSource = DataServices.ViewLopHocPhanChuyenNganh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceLHPChuyenNganh.DataSource = DataServices.ViewLopHocPhanChuyenNganh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditChonTatCa.EditValue.ToString() == "True")
            {
                for (int i = 0; i < gridViewLHPChuyenNganh.DataRowCount; i++)
                {
                    gridViewLHPChuyenNganh.SetRowCellValue(i, "TrangThai", "True");
                }
            }
            if (checkEditChonTatCa.EditValue.ToString() == "False")
            {
                for (int i = 0; i < gridViewLHPChuyenNganh.DataRowCount; i++)
                {
                    gridViewLHPChuyenNganh.SetRowCellValue(i, "TrangThai", "False");
                }
            }
        }
    }
}
