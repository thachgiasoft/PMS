using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu.ChucNangCon
{
    public partial class frmChiTietLopHocPhanGhepSiSo : DevExpress.XtraEditors.XtraForm
    {
        string MaLopHocPhanChinh;
        public frmChiTietLopHocPhanGhepSiSo()
        {
            InitializeComponent();
        }

        public frmChiTietLopHocPhanGhepSiSo(string maLopHocPhan)
        {
            InitializeComponent();
            MaLopHocPhanChinh = maLopHocPhan;
        }

        private void frmChiTietLopHocPhanGhepSiSo_Load(object sender, EventArgs e)
        {
            try
            {
                textEditMaLopHocPhanChinh.Text = MaLopHocPhanChinh;

                #region Init GridView
                AppGridView.InitGridView(gridViewLopGhep, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
                AppGridView.ShowField(gridViewLopGhep, new string[] { "CurriculumID", "CurriculumName", "ScheduleStudyUnitID", "ListOfClassStudents", "NumberOfStudents" }
                                                  , new string[] { "Mã môn học", "Tên môn học", "Mã LHP", "Lớp", "Sĩ số đăng ký" }
                                                  , new int[] { 70, 180, 110, 140, 90, 90 });
                AppGridView.AlignHeader(gridViewLopGhep, new string[] { "CurriculumID", "CurriculumName", "ScheduleStudyUnitID", "ListOfClassStudents", "NumberOfStudents" }, DevExpress.Utils.HorzAlignment.Center);
                AppGridView.SummaryField(gridViewLopGhep, "CurriculumID", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
                AppGridView.SummaryField(gridViewLopGhep, "NumberOfStudents", "Tổng: {0}", DevExpress.Data.SummaryItemType.Sum);
                #endregion
                PMS.Common.Globals.WordWrapHeader(gridViewLopGhep, 45);

                DataTable tb = new DataTable();
                IDataReader reader = DataServices.SiSoLopHocPhan.LayChiTietlopGhep(MaLopHocPhanChinh);
                tb.Load(reader);
                bindingSourceChiTiet.DataSource = tb;
            }
            catch
            { }
        }
    }
}