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
using DevExpress.XtraGrid.Views.Base;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmKhoiLuongGiangDayDoAnTotNghiep : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLayDuLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLayDuLieu.ShortCut = Shortcut.None;
            }
            else
            {
                btnLayDuLieu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int kiemtra = 0;
        #endregion
        #region Event Form
        public frmKhoiLuongGiangDayDoAnTotNghiep()
        {
            InitializeComponent();
        }

        private void frmKhoiLuongGiangDayDoAnTotNghiep_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewDoAnTotNghiep, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewDoAnTotNghiep, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "Nhom", "SiSo", "ChiTiet" }
                    , new string[] { "Mã môn học", "Tên môn học", "Số tín chỉ", "Mã lớp học phần", "Mã lớp", "Nhóm", "Sĩ số", "Chi tiết" }
                    , new int[] { 100, 150, 90, 110, 100, 80, 80, 90 });
            AppGridView.AlignHeader(gridViewDoAnTotNghiep, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "Nhom", "SiSo", "ChiTiet" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewDoAnTotNghiep, "MaMonHoc", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.RegisterControlField(gridViewDoAnTotNghiep, "ChiTiet", repositoryItemButtonEditChiTiet);
            AppGridView.ReadOnlyColumn(gridViewDoAnTotNghiep);
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
        #endregion
        #region InitData()
        void InitData()
        { 
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDoAnTotNghiep.DataSource = DataServices.KhoiLuongGiangDayDoAnTotNghiep.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion
        #region Evewnt Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLayDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataServices.ChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DATN", ref kiemtra);
                if (kiemtra == 1)
                {
                    XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép sửa đổi.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int kq = 0;
                DataServices.KhoiLuongGiangDayDoAnTotNghiep.KiemTraDongBo(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                if (kq == 0)
                {
                    using (frmDongBoDuLieuDoAnUIS frm = new frmDongBoDuLieuDoAnUIS(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DATN"))
                    {
                        frm.ShowDialog();
                    }
                    bindingSourceDoAnTotNghiep.DataSource = DataServices.KhoiLuongGiangDayDoAnTotNghiep.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
                if (kq == 1)
                {
                    if (XtraMessageBox.Show(string.Format("Dữ liệu đồ án của năm học {0} - {1} đã có, tiếp tục lấy dữ liệu sẽ ghi đè dữ liệu cũ.\n Bạn có muốn tiếp tục?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (frmDongBoDuLieuDoAnUIS frm = new frmDongBoDuLieuDoAnUIS(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "DATN"))
                        {
                            frm.ShowDialog();
                        }
                        bindingSourceDoAnTotNghiep.DataSource = DataServices.KhoiLuongGiangDayDoAnTotNghiep.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    }
                    else return;
                }
            }
        }
        #endregion
        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDoAnTotNghiep.DataSource = DataServices.KhoiLuongGiangDayDoAnTotNghiep.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDoAnTotNghiep.DataSource = DataServices.KhoiLuongGiangDayDoAnTotNghiep.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion

        private void gridViewDoAnTotNghiep_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            ColumnView view = sender as ColumnView;
            if (view.ActiveFilter.IsEmpty)
            {
                if (view.FocusedColumn.FieldName == "ChiTiet")
                {
                    KhoiLuongGiangDayDoAnTotNghiep obj = gridViewDoAnTotNghiep.GetFocusedRow() as KhoiLuongGiangDayDoAnTotNghiep;
                    if (obj != null)
                    {
                        if (!obj.IsNew)
                        {
                            using (frmChiTietPhanCongDoAnTotNghiep frm = new frmChiTietPhanCongDoAnTotNghiep(obj.MaLopHocPhan, obj.TenMonHoc, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()))
                            {
                                frm.ShowDialog();
                            }
                        }
                        else
                            XtraMessageBox.Show("Bạn chưa lưu lại dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

    }
}