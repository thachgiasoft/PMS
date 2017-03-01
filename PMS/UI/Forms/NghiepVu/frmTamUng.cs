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
using PMS.Core;
using DevExpress.XtraGrid.Columns;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmTamUng : DevExpress.XtraEditors.XtraForm
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
        decimal? t = 0;
        #endregion
        public frmTamUng()
        {
            InitializeComponent();
        }

        private void frmTamUng_Load(object sender, EventArgs e)
        {
            #region GridView
            AppGridView.InitGridView(gridViewTamUng, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewTamUng, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewTamUng, new string[] { "MaGiangVien", "HoTen", "SoTien", "NgayTamUng", "GhiChu" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Số tiền", "Ngày tạm ứng", "Ghi ghú"}, new int[] { 100, 170, 100, 120, 200 });
            AppGridView.AlignHeader(gridViewTamUng, new string[] { "MaGiangVien", "HoTen", "SoTien", "NgayTamUng", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewTamUng, new string[] { "HoTen" });
            AppGridView.RegisterControlField(gridViewTamUng, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewTamUng, "SoTien", repositoryItemSpinEditSoTien);
            AppGridView.FormatDataField(gridViewTamUng, "SoTien", DevExpress.Utils.FormatType.Custom, "n0");
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
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            
            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "NgaySinh" }, new string[] { "Mã giảng viên", "Họ tên", "Ngày sinh" });
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            InitData();
        }
        #region InitData
        void InitData()
        {
            bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if(cboNamHoc.EditValue!=null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
           if(cboNamHoc.EditValue!=null && cboHocKy.EditValue!=null)
               bindingSourceTamUng.DataSource = DataServices.GiangVienTamUng.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewTamUng);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewTamUng.FocusedRowHandle = -1;
            TList<GiangVienTamUng> list = bindingSourceTamUng.DataSource as TList<GiangVienTamUng>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach(GiangVienTamUng tamUng in list)
                            {
                                tamUng.NamHoc = cboNamHoc.EditValue.ToString();
                                tamUng.HocKy = cboHocKy.EditValue.ToString();
                            }
                            bindingSourceTamUng.EndEdit();
                            DataServices.GiangVienTamUng.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewTamUng, barManager1, layoutControl1 });
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Cursor.Current = Cursors.WaitCursor;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }
        
        private void gridViewTamUng_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            int pos = e.RowHandle;
            object r = gridViewTamUng.GetRow(pos);
            GiangVienTamUng o = (GiangVienTamUng)r;
            if (col.FieldName == "MaGiangVien")
            {
                if (o.MaGiangVien != null)
                {
                    ViewGiangVien vGiangVien = DataServices.ViewGiangVien.Get("MaGiangVien = " + o.MaGiangVien, "MaGiangVien")[0];
                    if (vGiangVien != null)
                    {
                        gridViewTamUng.SetRowCellValue(pos, "HoTen", vGiangVien.HoTen);
                    }
                }
            }
            if (col.FieldName == "SoTien") 
            {
                if (o.MaGiangVien != null)
                {
                    double SoTienDuocUng = 0, SoTienDaUng = 0, SoTienConDuocUng = 0;
                    DataServices.GiangVienTamUng.KiemTraSoTien((int)o.MaGiangVien, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref SoTienDuocUng, ref SoTienDaUng, ref SoTienConDuocUng);
                    SoTienDuocUng = Math.Round(SoTienDuocUng, MidpointRounding.AwayFromZero);
                    SoTienConDuocUng = Math.Round(SoTienConDuocUng, MidpointRounding.AwayFromZero);

                    GiangVienTamUng kiemtra = DataServices.GiangVienTamUng.GetByMaQuanLy(o.MaQuanLy);
                    decimal? _soTien = 0, _tienCu = 0;
                    if (kiemtra == null)
                    {
                        _soTien = o.SoTien;
                        _tienCu = (decimal?)SoTienConDuocUng;
                    }
                    else
                    {
                        _soTien = o.SoTien - kiemtra.SoTien;
                        _tienCu = kiemtra.SoTien + (decimal?)SoTienConDuocUng;
                    }
                    if (_soTien > (decimal?)(SoTienConDuocUng))
                    {
                        XtraMessageBox.Show(string.Format("Giảng viên {0} có thể ứng {1} vnđ.\nĐã ứng trước {2} vnđ, còn được phép ứng {3} vnđ", o.HoTen, SoTienDuocUng, SoTienDaUng, SoTienConDuocUng), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridViewTamUng.SetRowCellValue(pos, "SoTien", _tienCu);
                    }
                }
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceTamUng.DataSource = DataServices.GiangVienTamUng.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceTamUng.DataSource = DataServices.GiangVienTamUng.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

         private void gridViewTamUng_KeyUp(object sender, KeyEventArgs e)
         {
             AppGridView.DeleteSelectedRows(gridViewTamUng, e);
         }
    }
}