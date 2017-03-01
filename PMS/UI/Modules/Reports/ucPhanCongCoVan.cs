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
using PMS.Services;

namespace PMS.UI.Modules.Reports
{
    public partial class ucPhanCongCoVan : XtraUserControl
    {
        TList<CauHinhChung> cauHinhchung = DataServices.CauHinhChung.GetAll();
        public ucPhanCongCoVan()
        {
            InitializeComponent();
        }

        private void ucPhanCongCoVan_Load(object sender, EventArgs e)
        {
            #region Phan cong chuyen mon
            AppGridView.InitGridView(gridViewPhanCong, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false);
            AppGridView.ShowField(gridViewPhanCong, new string[] { "MaQuanLy", "HoTen", "ChucDanh", "MaBacLoaiHinh", "MaKhoaHoc", "MaLop", "TenLop", "NgayTao" },
                new string[] { "Mã GV", "Họ tên", "Chức danh", "Bậc - Loại hình", "Khóa học", "Mã lớp", "Tên lớp", "Ngày phân công" },
                new int[] { 90, 180, 90, 110, 90, 90, 120, 110 });
            AppGridView.MergeCell(gridViewPhanCong, new string[] { "MaLop", "TenLop", "NgayTao" });
            AppGridView.SummaryField(gridViewPhanCong, "MaQuanLy", "Tổng = {0:#,0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewPhanCong);
            #endregion

            #region DonVi - KhoaBoMon
            AppGridLookupEdit.InitGridLookUp(cboDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboDonVi, 300, 300);
            AppGridLookupEdit.ShowField(cboDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" }, new int[] { 100, 200 });
            cboDonVi.Properties.DisplayMember = "TenKhoa";
            cboDonVi.Properties.ValueMember = "MaKhoa";
            cboDonVi.Properties.NullText = string.Empty;
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            #endregion
            cboNamHoc.EditValue = cauHinhchung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            cboHocKy.EditValue = cauHinhchung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cauHinhchung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri == null)
            {
                cboNamHoc.DataBindings.Clear();
                cboNamHoc.DataBindings.Add("EditValue", bindingSourceNamHoc, "NamHoc", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            

            
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            if (cauHinhchung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri == null)
            {
                cboHocKy.DataBindings.Clear();
                cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
            }

            VList<ViewKhoa> vListKhoaBoMon = DataServices.ViewKhoa.GetAll();
            vListKhoaBoMon.Insert(0, new ViewKhoa() { ThuTu = -1, MaKhoa = "[Tất cả]", TenKhoa = "[Tất cả]" });
            bindingSourceDonVi.DataSource = vListKhoaBoMon;
            cboDonVi.DataBindings.Clear();
            cboDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);

            
            
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            VList<ViewKhoa> vListKhoaBoMon = DataServices.ViewKhoa.GetAll();
            vListKhoaBoMon.Insert(0, new ViewKhoa() { ThuTu = -1, MaKhoa = "[Tất cả]", TenKhoa = "[Tất cả]" });
            bindingSourceDonVi.DataSource = vListKhoaBoMon;
            cboDonVi.DataBindings.Clear();
            cboDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);
            Cursor.Current = Cursors.Default;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ViewKhoa objDonVi = bindingSourceDonVi.Current as ViewKhoa;
            if (cboNamHoc.EditValue == null && cboHocKy.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (objDonVi != null)
            {
                if (objDonVi.ThuTu == -1)
                    bindingSourcePhanCong.DataSource = DataServices.ViewPhanCongCoVan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                else
                    bindingSourcePhanCong.DataSource = DataServices.ViewPhanCongCoVan.GetByMaDonViNamHocHocKy(objDonVi.MaKhoa, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
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

        private void cboNamHoc_CloseUp(object sender, CloseUpEventArgs e)
        {            
            if (e.Value != null)
            {
                if (cboNamHoc.EditValue != null)
                {
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                    cboHocKy.DataBindings.Clear();
                    cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
        }
    }
}