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
using PMS.Entities;
using PMS.Services;
using PMS.Core;
using PMS.Entities.Validation;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucMonHocGiangBangTiengNuocNgoai : DevExpress.XtraEditors.XtraUserControl
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
        string _maTruong;
        #endregion

        #region Event Form
        public ucMonHocGiangBangTiengNuocNgoai()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucMonHocGiangBangTiengNuocNgoai_Load(object sender, EventArgs e)
        {
            #region Init gridview
            switch (_maTruong)
            { 
                case "IUH":
                    InitGridIUH();
                    break;
                default:
                    InitRemaining();
                    break;
            }
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
            bindingSourceGVLHPNN.DataSource = DataServices.ViewLopHocPhanGiangBangTiengNuocNgoai.GetByNamHocHocKy(gridLookUpEditNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            gridViewGVLHPNN.ExpandAllGroups();
        }

        #endregion

        #region InitGridView
        void InitGridIUH()
        {
            AppGridView.InitGridView(gridViewGVLHPNN, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewGVLHPNN, new string[] { "TermId", "ScheduleStudyUnitId", "StudyUnitId", "CurriculumId", "CurriculumName", "ListOfClassStudentId", "ListOfProfessorFirstName", "Chon" },
                        new string[] { "Học kỳ", "ScheduleStudyUnitId", "Mã lớp học phần", "Mã học phần", "Tên môn học", "Lớp sinh viên", "Tên giảng viên", "Giảng bằng tiếng nước ngoài" },
                        new int[] { 70, 99, 130, 100, 250, 100, 100, 150 });
            AppGridView.AlignHeader(gridViewGVLHPNN, new string[] { "TermId", "ScheduleStudyUnitId", "StudyUnitId", "CurriculumId", "CurriculumName", "ListOfClassStudentId", "ListOfProfessorFirstName", "Chon" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewGVLHPNN, new string[] { "TermId", "ScheduleStudyUnitId", "StudyUnitId", "CurriculumId", "CurriculumName", "ListOfClassStudentId", "ListOfProfessorFirstName" });
            AppGridView.SummaryField(gridViewGVLHPNN, "StudyUnitId", "Tổng: {0} LHP", DevExpress.Data.SummaryItemType.Count);
            gridViewGVLHPNN.Columns["TermId"].GroupIndex = 0;
            AppGridView.HideField(gridViewGVLHPNN, new string[] { "ScheduleStudyUnitId" });
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewGVLHPNN, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewGVLHPNN, new string[] { "TermId", "ScheduleStudyUnitId", "StudyUnitId", "CurriculumName", "ListOfClassStudentId", "ListOfProfessorFirstName", "Chon" },
                        new string[] { "Học kỳ", "Mã lớp học phần", "Mã học phần", "Tên môn học", "Lớp sinh viên", "Tên giảng viên", "Giảng bằng tiếng nước ngoài" },
                        new int[] { 70, 130, 100, 250, 100, 100, 150 });
            AppGridView.AlignHeader(gridViewGVLHPNN, new string[] { "TermId", "ScheduleStudyUnitId", "StudyUnitId", "CurriculumName", "ListOfClassStudentId", "ListOfProfessorFirstName", "Chon" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewGVLHPNN, new string[] { "TermId", "ScheduleStudyUnitId", "StudyUnitId", "CurriculumName", "ListOfClassStudentId", "ListOfProfessorFirstName" });
            AppGridView.SummaryField(gridViewGVLHPNN, "ScheduleStudyUnitId", "Tổng: {0} LHP", DevExpress.Data.SummaryItemType.Count);
            gridViewGVLHPNN.Columns["TermId"].GroupIndex = 0;
        }
        #endregion


        #region SetNamHoc, SetHocKy
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
        private void btnLocDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceGVLHPNN.DataSource = DataServices.ViewLopHocPhanGiangBangTiengNuocNgoai.GetByNamHocHocKy(gridLookUpEditNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            gridViewGVLHPNN.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewGVLHPNN.RowCount > 0)
                if (gridViewGVLHPNN.GetSelectedRows().Length > 0)
                    if (XtraMessageBox.Show(String.Format("Bạn có muốn xóa {0} dòng đã chọn không ?", gridViewGVLHPNN.GetSelectedRows().Length), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        foreach (int rowIndex in gridViewGVLHPNN.GetSelectedRows())
                            ((ViewLopHocPhanGiangBangTiengNuocNgoai)gridViewGVLHPNN.GetRow(rowIndex)).Chon = null;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewGVLHPNN.FocusedRowHandle = -1;
            string xmlData = "<Root>";
            int kq = 0;
            VList<ViewLopHocPhanGiangBangTiengNuocNgoai> list = bindingSourceGVLHPNN.DataSource as VList<ViewLopHocPhanGiangBangTiengNuocNgoai>;
            foreach (ViewLopHocPhanGiangBangTiengNuocNgoai v in list)
            {
                if (v.Chon != null && v.Chon != false)
                {
                    xmlData += "<LHPGiangTiengNuocNgoai MaLopHocPhan = \"" + v.ScheduleStudyUnitId
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
                    DataServices.LopHocPhanGiangBangTiengNuocNgoai.Luu(xmlData,"-1", ref kq);
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
        private void gridViewGVLHPNN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                if (gridViewGVLHPNN.RowCount > 0)
                    if (gridViewGVLHPNN.GetSelectedRows().Length > 0)
                        if (XtraMessageBox.Show(String.Format("Bạn có muốn xóa {0} dòng đã chọn không ?", gridViewGVLHPNN.GetSelectedRows().Length), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            foreach (int rowIndex in gridViewGVLHPNN.GetSelectedRows())
                                ((ViewLopHocPhanGiangBangTiengNuocNgoai)gridViewGVLHPNN.GetRow(rowIndex)).Chon = null;
        }

        private void gridViewGVLHPNN_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridLookUpEditNamHoc_EditValueChanged(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            if (gridLookUpEditNamHoc.EditValue != null)
                SetHocKy(gridLookUpEditNamHoc.EditValue.ToString());
            if (gridLookUpEditNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceGVLHPNN.DataSource = DataServices.ViewLopHocPhanGiangBangTiengNuocNgoai.GetByNamHocHocKy(gridLookUpEditNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            gridViewGVLHPNN.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (gridLookUpEditNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceGVLHPNN.DataSource = DataServices.ViewLopHocPhanGiangBangTiengNuocNgoai.GetByNamHocHocKy(gridLookUpEditNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            gridViewGVLHPNN.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }
        #endregion


    }
}
