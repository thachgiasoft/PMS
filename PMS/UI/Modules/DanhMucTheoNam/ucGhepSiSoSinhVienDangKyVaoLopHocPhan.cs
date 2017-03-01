using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Base;
using PMS.Services;
using PMS.UI.Forms.NghiepVu.ChucNangCon;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucGhepSiSoSinhVienDangKyVaoLopHocPhan : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
                btnGhep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnGhep.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnGhep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion

        #region Event Form
        public ucGhepSiSoSinhVienDangKyVaoLopHocPhan()
        {
            InitializeComponent();
        }

        private void ucGhepSiSoSinhVienDangKyVaoLopHocPhan_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewGhep, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, true);
            AppGridView.ShowField(gridViewGhep, new string[] { "DepartmentName", "CurriculumId", "CurriculumName", "ScheduleStudyUnitId", "ListOfClassStudents", "MaCanBoGiangDay", "HoTen", "SiSoLop", "ChiTiet" }
                                              , new string[] { "Khoa - Bộ môn", "Mã môn học", "Tên môn học", "Mã LHP", "Lớp", "Mã giảng viên", "Họ tên", "Sĩ số đăng ký", "Chi tiết" }
                                              , new int[] { 99, 80, 180, 110, 110, 100, 150, 70, 60 });
            AppGridView.AlignHeader(gridViewGhep, new string[] { "DepartmentName", "CurriculumId", "CurriculumName", "ScheduleStudyUnitId", "ListOfClassStudents", "MaCanBoGiangDay", "HoTen", "SiSoLop", "ChiTiet" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewGhep, new string[] { "SiSoLop", "ChiTiet" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewGhep, "CurriculumId", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewGhep, new string[] { "DepartmentName", "CurriculumId", "CurriculumName", "ScheduleStudyUnitId", "ListOfClassStudents", "MaCanBoGiangDay", "HoTen" });
            AppGridView.RegisterControlField(gridViewGhep, "ChiTiet", repositoryItemButtonEditChiTiet);
            gridViewGhep.Columns["DepartmentName"].GroupIndex = 0;
            
            #endregion
            PMS.Common.Globals.WordWrapHeader(gridViewGhep, 45);

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Hoc Ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã hoc kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            InitData();
        }
        #endregion

        #region InitData
        void InitData()
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if(cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.SiSoLopHocPhan.LaySiSoLopGhep(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                bindingSourceGhep.DataSource = tb;
                gridViewGhep.ExpandAllGroups();
            }
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnGhep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    if (XtraMessageBox.Show("Bạn muốn lấy dữ liệu ghép sĩ số sinh viên đăng ký cho những LHP chưa có sinh viên đăng ký?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int kq = 0;
                        DataServices.SiSoLopHocPhan.GhepSiSoDangKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);

                        if (kq == 0)
                            XtraMessageBox.Show("Lấy dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã có lỗi trong quá trình lấy dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        LoadDataSource();
                    }
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewGhep.FocusedRowHandle = -1;
            DataTable tb = bindingSourceGhep.DataSource as DataTable;
            if (tb != null)
            {
               
                if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string xmlData = "";
                    foreach (DataRow r in tb.Rows)
                    {
                        if (r.RowState == DataRowState.Modified)
                        {
                            xmlData += String.Format("<Input M=\"{0}\" S=\"{1}\" />", r["ScheduleStudyUnitId"]
                                    , PMS.Common.Globals.IsNull(r["SiSoLop"].ToString(), "int"));
                        }
                    }
                    xmlData = String.Format("<Root>{0}</Root>", xmlData);

                    int kq = 0;
                    DataServices.SiSoLopHocPhan.Luu(xmlData, ref kq);

                    if (kq == 0)
                        XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã có lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadDataSource();
            }
            Cursor.Current = Cursors.Default;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlGhep.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
        #endregion

        #region Event Grid
        private void gridViewGhep_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            //if (view.ActiveFilter.IsEmpty)
            {
                if (view.FocusedColumn.FieldName == "ChiTiet")
                {
                    DataRowView obj = gridViewGhep.GetFocusedRow() as DataRowView;
                    if (obj != null)
                    {
                        using (frmChiTietLopHocPhanGhepSiSo frm = new frmChiTietLopHocPhanGhepSiSo(obj["ScheduleStudyUnitId"].ToString()))
                        {
                            frm.ShowDialog();
                        }
                    }
                }
            }
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }
        #endregion
    }
}
