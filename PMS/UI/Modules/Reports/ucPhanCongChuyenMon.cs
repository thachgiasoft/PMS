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
using PMS.Entities;
using PMS.Entities.Validation;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Modules.Reports
{
    public partial class ucPhanCongChuyenMon : XtraUserControl
    {
        public ucPhanCongChuyenMon()
        {
            InitializeComponent();
        }

        private void ucPhanCongChuyenMon_Load(object sender, EventArgs e)
        {
            #region Phan cong chuyen mon
            AppGridView.InitGridView(gridViewPhanCong, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewPhanCong, new string[] { "MaQuanLy", "HoTen", "ChucDanh", "MaMonHoc", "TenMonHoc", "SoTinChi", "NgayPhanCong" },
                new string[] { "Mã GV", "Họ tên", "Chức danh", "Mã môn học", "Tên môn học", "Tín chỉ", "Ngày phân công" },
                new int[] { 90, 180, 90, 90, 300, 60, 110 });
            AppGridView.MergeCell(gridViewPhanCong, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "NgayPhanCong" });
            AppGridView.SummaryField(gridViewPhanCong, "MaQuanLy", "Tổng = {0:#,0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewPhanCong);
            #endregion

            #region DonVi - KhoaBoMon
            AppGridLookupEdit.InitGridLookUp(cboDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboDonVi, 650, 300);
            AppGridLookupEdit.ShowField(cboDonVi, new string[] { "MaKhoa", "TenKhoa", "MaBoMon", "TenBoMon" }, new string[] { "Mã khoa", "Tên khoa", "Mã bộ môn", "Tên bộ môn" }, new int[] { 100, 200, 100, 200 });
            cboDonVi.Properties.DisplayMember = "TenBoMon";
            cboDonVi.Properties.ValueMember = "MaBoMon";
            cboDonVi.Properties.NullText = string.Empty;
            #endregion

            VList<ViewKhoaBoMon> vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            vListKhoaBoMon.Insert(0, new ViewKhoaBoMon() { ThuTu = -1, MaKhoa = "[Tất cả]", TenKhoa = "[Tất cả]", MaBoMon = "[Tất cả]", TenBoMon = "[Tất cả]" });
            bindingSourceDonVi.DataSource = vListKhoaBoMon;
            cboDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            VList<ViewKhoaBoMon> vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            vListKhoaBoMon.Insert(0, new ViewKhoaBoMon() { ThuTu = -1, MaKhoa = "[Tất cả]", TenKhoa = "[Tất cả]", MaBoMon = "[Tất cả]", TenBoMon = "[Tất cả]" });
            bindingSourceDonVi.DataSource = vListKhoaBoMon;
            cboDonVi.DataBindings.Clear();
            cboDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);
            Cursor.Current = Cursors.Default;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ViewKhoaBoMon objDonVi = bindingSourceDonVi.Current as ViewKhoaBoMon;
            if (objDonVi != null)
            {
                if (objDonVi.ThuTu == -1)
                    bindingSourcePhanCong.DataSource = DataServices.ViewPhanCongChuyenMon.GetAll();
                //else
                //    bindingSourcePhanCong.DataSource = DataServices.ViewPhanCongChuyenMon.GetByMaDonVi(objDonVi.MaBoMon);
            }
            else
                XtraMessageBox.Show("Bạn chưa chọn đơn vị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Cursor.Current = Cursors.Default;
        }

        private void btnXuatFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook (*.xls)|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        gridControlPhanCong.ExportToXls(sfd.FileName);
                        XtraMessageBox.Show("Bạn đã xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}