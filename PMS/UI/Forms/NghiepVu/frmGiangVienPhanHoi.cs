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
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmGiangVienPhanHoi : DevExpress.XtraEditors.XtraForm
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
        public frmGiangVienPhanHoi()
        {
            InitializeComponent();
        }

        private void frmGiangVienPhanHoi_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewPhanHoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewPhanHoi, new string[]{"MaGiangVienQuanLy", "HoTen", "NoiDungPhanHoi", "NgayPhanHoi", "TraLoiPhanHoi", "NgayTraLoi", "NguoiTraLoi" }
                , new string[]{"Mã giảng viên", "Họ tên", "Nội dung phản hồi", "Ngày phản hồi", "Trả lời", "Ngày trả lời", "Người trả lời" }
                , new int[] { 90, 150,350, 90, 350, 100, 100 });
            AppGridView.AlignHeader(gridViewPhanHoi, new string[] { "MaGiangVienQuanLy", "HoTen", "NoiDungPhanHoi", "NgayPhanHoi", "TraLoiPhanHoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewPhanHoi, new string[] { "MaGiangVienQuanLy", "HoTen", "NoiDungPhanHoi", "NgayPhanHoi" });
            AppGridView.HideField(gridViewPhanHoi, new string[] { "NgayTraLoi", "NguoiTraLoi" });
            AppGridView.RegisterControlField(gridViewPhanHoi, "NoiDungPhanHoi", repositoryItemMemoEditNoiDung);
            AppGridView.RegisterControlField(gridViewPhanHoi, "TraLoiPhanHoi", repositoryItemMemoEditTraLoi);
            
            //gridViewPhanHoi.Columns[0].AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
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
        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourcePhanHoi.DataSource = DataServices.GiangVienPhanHoi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion
        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
          
            gridViewPhanHoi.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TList<GiangVienPhanHoi> list = bindingSourcePhanHoi.DataSource as TList<GiangVienPhanHoi>;
                //if (list != null || list.Count > 0)
                if (list != null)
                {
                    try
                    {
                        foreach (GiangVienPhanHoi g in list)
                        {
                            g.NamHoc = cboNamHoc.EditValue.ToString();
                            g.HocKy = cboHocKy.EditValue.ToString();
                        }
                        bindingSourcePhanHoi.EndEdit();
                        DataServices.GiangVienPhanHoi.Save(list);
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlPhanHoi.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
        #endregion
        #region Event Grid, Cbo
        private void gridViewPhanHoi_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            int pos = e.RowHandle;
            if (col.FieldName == "TraLoiPhanHoi")
            {
                gridViewPhanHoi.SetRowCellValue(pos, "NgayTraLoi", DateTime.Now.ToString());
                gridViewPhanHoi.SetRowCellValue(pos, "NguoiTraLoi", UserInfo.User.TenDangNhap);
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourcePhanHoi.DataSource = DataServices.GiangVienPhanHoi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourcePhanHoi.DataSource = DataServices.GiangVienPhanHoi.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion

    }
}