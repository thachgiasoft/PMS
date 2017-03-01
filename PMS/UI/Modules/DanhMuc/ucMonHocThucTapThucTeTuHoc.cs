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
using PMS.Services;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucMonHocThucTapThucTeTuHoc : DevExpress.XtraEditors.XtraUserControl
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
        TList<CauHinhChung> cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion

        #region Event Form
        public ucMonHocThucTapThucTeTuHoc()
        {
            InitializeComponent();
        }

        private void ucMonHocThucTapThucTeTuHoc_Load(object sender, EventArgs e)
        {
            #region Init gridview
            AppGridView.InitGridView(gridViewMonThucTap, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewMonThucTap, new string[] { "ScheduleStudyUnitId", "StudyUnitId", "CurriculumName", "Credits", "StudyUnitTypeName", "ListOfClassStudentId", "ListOfProfessorFirstName", "MaHeSoCongViec", "TermId" },
                        new string[] { "Mã lớp học phần", "Mã học phần", "Tên môn học", "STC", "Loại học phần", "Lớp sinh viên", "Giảng viên", "Loại công việc", "Học kỳ" },
                        new int[] { 140, 100, 200, 70, 90, 100, 100, 150, 70 });
            AppGridView.AlignHeader(gridViewMonThucTap, new string[] { "ScheduleStudyUnitId", "StudyUnitId", "CurriculumName", "Credits", "StudyUnitTypeName", "ListOfClassStudentId", "ListOfProfessorFirstName", "MaHeSoCongViec" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewMonThucTap, new string[] { "ScheduleStudyUnitId", "StudyUnitId", "CurriculumName", "Credits", "StudyUnitTypeName", "ListOfClassStudentId", "ListOfProfessorFirstName" });
            AppGridView.RegisterControlField(gridViewMonThucTap, "MaHeSoCongViec", repositoryItemGridLookUpEditHeSoCongViec);
            AppGridView.SummaryField(gridViewMonThucTap, "ScheduleStudyUnitId", "Tổng: {0} LHP", DevExpress.Data.SummaryItemType.Count);
            gridViewMonThucTap.Columns["TermId"].GroupIndex = 0;
            #endregion

            #region AppGridLookupEdit _namHoc
            AppGridLookupEdit.InitGridLookUp(gridLookUpEditNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(gridLookUpEditNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            gridLookUpEditNamHoc.Properties.ValueMember = "NamHoc";
            gridLookUpEditNamHoc.Properties.DisplayMember = "NamHoc";
            gridLookUpEditNamHoc.Properties.NullText = "[Chọn năm học]";
            #endregion

            #region HeSoCongViec
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHeSoCongViec, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHeSoCongViec, new string[] { "Stt","MaQuanLy", "TenCongViec" },
                    new string[] { "STT", "Mã công việc", "Tên công việc" });
            repositoryItemGridLookUpEditHeSoCongViec.DisplayMember = "TenCongViec";
            repositoryItemGridLookUpEditHeSoCongViec.ValueMember = "MaHeSo";
            repositoryItemGridLookUpEditHeSoCongViec.NullText = string.Empty;
            repositoryItemGridLookUpEditHeSoCongViec.Properties.PopupFormSize = new Size(400, 250);
            #endregion

            gridLookUpEditNamHoc.EditValue = cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;

            InitData();
        }

        #endregion

        #region SetNamHoc, SetHocKy
        private void SetNamHoc()
        {
            gridLookUpEditNamHoc.DataBindings.Clear();
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

        #region InitData
        void InitData()
        {
            SetNamHoc();
            SetHocKy(gridLookUpEditNamHoc.EditValue.ToString());
            bindingSourceHeSoCongViec.DataSource = DataServices.HeSoCongViec.GetAll();
            bindingSourceMonThucTapTuHoc.DataSource = DataServices.ViewThongTinLopHocPhanHeSoCongViec.GetByNamHocHocKy(gridLookUpEditNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            gridViewMonThucTap.ExpandAllGroups();
        }
        #endregion

        #region Event Button
        private void btnLocDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceMonThucTapTuHoc.DataSource = DataServices.ViewThongTinLopHocPhanHeSoCongViec.GetByNamHocHocKy(gridLookUpEditNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            gridViewMonThucTap.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridViewMonThucTap.RowCount > 0)
                if (gridViewMonThucTap.GetSelectedRows().Length > 0)
                    if (XtraMessageBox.Show(String.Format("Bạn có muốn xóa {0} dòng đã chọn không ?", gridViewMonThucTap.GetSelectedRows().Length), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        foreach (int rowIndex in gridViewMonThucTap.GetSelectedRows())
                            ((ViewThongTinLopHocPhanHeSoCongViec)gridViewMonThucTap.GetRow(rowIndex)).MaHeSoCongViec = null;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewMonThucTap.FocusedRowHandle = -1;
            string xmlData = "<Root>";
            int kq = 0;
            VList<ViewThongTinLopHocPhanHeSoCongViec> list = bindingSourceMonThucTapTuHoc.DataSource as VList<ViewThongTinLopHocPhanHeSoCongViec>;
            foreach (ViewThongTinLopHocPhanHeSoCongViec v in list)
            {
                if (v.MaHeSoCongViec != null)
                {
                    xmlData += "<MonThucTapThucTe MaLopHocPhan = \"" + v.ScheduleStudyUnitId
                                + "\" MaHeSoCongViec = \"" + v.MaHeSoCongViec
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
                    DataServices.ThucGiangMonThucTeTuHoc.Luu(xmlData, ref kq);
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
        private void gridViewMonThucTap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                if (gridViewMonThucTap.RowCount > 0)
                    if (gridViewMonThucTap.GetSelectedRows().Length > 0)
                        if (XtraMessageBox.Show(String.Format("Bạn có muốn xóa {0} dòng đã chọn không ?", gridViewMonThucTap.GetSelectedRows().Length), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            foreach (int rowIndex in gridViewMonThucTap.GetSelectedRows())
                                ((ViewThongTinLopHocPhanHeSoCongViec)gridViewMonThucTap.GetRow(rowIndex)).MaHeSoCongViec = null;
        }

        private void gridViewMonThucTap_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
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
