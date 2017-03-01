using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities;
using PMS.Core;
using PMS.Entities.Validation;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucLopHocPhan_BacDaoTao : DevExpress.XtraEditors.XtraUserControl
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

        #region Event Form
        public ucLopHocPhan_BacDaoTao()
        {
            InitializeComponent();
        }

        private void ucLopHocPhan_BacDaoTao_Load(object sender, EventArgs e)
        {
            #region Init gridview
            AppGridView.InitGridView(gridViewLopHPBacDT, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewLopHPBacDT, new string[] { "ScheduleStudyUnitId", "StudyUnitId", "CurriculumName", "StudyUnitTypeName", "GraduateLevelName", "ListOfClassStudentId", "ListOfProfessorFirstName", "Chon", "TermId" },
                        new string[] { "Mã lớp học phần", "Mã học phần", "Tên môn học", "Loại học phần", "Bậc đào tạo", "Lớp sinh viên", "Tên giảng viên", "CLC-AUF-CJL", "Học kỳ" },
                        new int[] { 130, 100, 220, 80, 80, 100, 100, 100, 100 });
            AppGridView.AlignHeader(gridViewLopHPBacDT, new string[] { "ScheduleStudyUnitId", "StudyUnitId", "CurriculumName", "StudyUnitTypeName", "GraduateLevelName", "ListOfClassStudentId", "ListOfProfessorFirstName", "Chon", "TermId" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewLopHPBacDT, new string[] { "ScheduleStudyUnitId", "StudyUnitId", "CurriculumName", "StudyUnitTypeName", "GraduateLevelName", "ListOfClassStudentId", "ListOfProfessorFirstName", "TermId" });
            AppGridView.SummaryField(gridViewLopHPBacDT, "ScheduleStudyUnitId", "Tổng: {0} LHP", DevExpress.Data.SummaryItemType.Count);
            gridViewLopHPBacDT.Columns["TermId"].GroupIndex = 0;
            #endregion

            #region AppGridLookupEdit _namHoc
            AppGridLookupEdit.InitGridLookUp(gridLookUpEditNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(gridLookUpEditNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            gridLookUpEditNamHoc.Properties.ValueMember = "NamHoc";
            gridLookUpEditNamHoc.Properties.DisplayMember = "NamHoc";
            gridLookUpEditNamHoc.Properties.NullText = "[Chọn năm học]";
            #endregion 
            gridLookUpEditNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            SetNamHoc();
            SetHocKy(gridLookUpEditNamHoc.EditValue.ToString());

            bindingSourceLopHPBacDT.DataSource = DataServices.ViewLopHocPhanClcAufCjl.GetByNamHocHocKy(gridLookUpEditNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            gridViewLopHPBacDT.ExpandAllGroups();
        }
        #endregion

        #region Set _namHoc, _hocKy
        private void SetNamHoc()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
        }

        private void SetHocKy(string namHoc)
        {
            cboHocKy.Properties.SelectAllItemCaption = "Tất cả";
            cboHocKy.Properties.TextEditStyle = TextEditStyles.Standard;
            cboHocKy.Properties.Items.Clear();

            VList<ViewHocKy> vListHocKy = DataServices.ViewHocKy.GetByNamHoc(namHoc);

            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            foreach (ViewHocKy obj in vListHocKy)
            {
                list.Add(new CheckedListBoxItem(obj.MaHocKy, CheckState.Unchecked, true));
            }
            cboHocKy.Properties.Items.AddRange(list.ToArray());
            cboHocKy.Properties.SeparatorChar = ';';
            cboHocKy.CheckAll();
        }
        #endregion

        #region Event Button
        private void btnLoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceLopHPBacDT.DataSource = DataServices.ViewLopHocPhanClcAufCjl.GetByNamHocHocKy(gridLookUpEditNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            gridViewLopHPBacDT.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewLopHPBacDT.RowCount > 0)
                if (gridViewLopHPBacDT.GetSelectedRows().Length > 0)
                    if (XtraMessageBox.Show(String.Format("Bạn có muốn xóa {0} dòng đã chọn không ?", gridViewLopHPBacDT.GetSelectedRows().Length), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        foreach (int rowIndex in gridViewLopHPBacDT.GetSelectedRows())
                            ((ViewLopHocPhanClcAufCjl)gridViewLopHPBacDT.GetRow(rowIndex)).Chon = null;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewLopHPBacDT.FocusedRowHandle = -1;
            string xmlData = "<Root>";
            int kq = 0;
            VList<ViewLopHocPhanClcAufCjl> list = bindingSourceLopHPBacDT.DataSource as VList<ViewLopHocPhanClcAufCjl>;
            foreach (ViewLopHocPhanClcAufCjl v in list)
            {
                if (v.Chon != null && v.Chon != false)
                {
                    xmlData += "<LHPCLCAUFCJL MaLopHocPhan = \"" + v.ScheduleStudyUnitId
                                + "\" Chon = \"" + v.Chon
                                + "\" NamHoc = \"" + v.YearStudy
                                + "\" HocKy = \"" + v.TermId
                                + "\" />";
                }
            }
            xmlData += "</Root>";

            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DataServices.LopHocPhanClcAufCjl.Luu(xmlData, ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Thao tác thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion 
        
        #region Event Grid
        private void gridViewLopHPBacDT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                if (gridViewLopHPBacDT.RowCount > 0)
                    if (gridViewLopHPBacDT.GetSelectedRows().Length > 0)
                        if (XtraMessageBox.Show(String.Format("Bạn có muốn xóa {0} dòng đã chọn không ?", gridViewLopHPBacDT.GetSelectedRows().Length), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            foreach (int rowIndex in gridViewLopHPBacDT.GetSelectedRows())
                                ((ViewLopHocPhanClcAufCjl)gridViewLopHPBacDT.GetRow(rowIndex)).Chon = null;
        }

        private void gridViewLopHPBacDT_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridLookUpEditNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            SetHocKy(gridLookUpEditNamHoc.EditValue.ToString());
        }
        #endregion
    }
}
