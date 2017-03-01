using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraGrid.Views.Grid;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucTietNghiaVuCuaGiangVienCoChucVu : DevExpress.XtraEditors.XtraUserControl
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

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        public ucTietNghiaVuCuaGiangVienCoChucVu()
        {
            InitializeComponent();
        }

        private void ucTietNghiaVuCuaGiangVienCoChucVu_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewTietNghiaVu, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTietNghiaVu, new string[] { "MaGiangVien", "MaQuanLy", "HoTen", "TenDonVi", "TenChucVu", "NgayBatDau", "NgayKetThuc", "NgayDuocHuong", "TietNghiaVu", "Bold" }
                                                     , new string[] { "Hide field", "Mã giảng viên", "Họ tên", "Khoa - Bộ môn", "Chức vụ", "Ngày bắt đầu", "Ngày kết thúc", "Số ngày", "Tiết nghĩa vụ", "Bold" }
                                                     , new int[] { 99, 80, 160, 170, 170, 90, 90, 80, 100, 99 });
            AppGridView.AlignHeader(gridViewTietNghiaVu, new string[] { "MaGiangVien", "MaQuanLy", "HoTen", "TenDonVi", "TenChucVu", "NgayBatDau", "NgayKetThuc", "NgayDuocHuong", "TietNghiaVu" }, DevExpress.Utils.HorzAlignment.Center);
            //AppGridView.FormatDataField(gridViewTietNghiaVu, "NgayBatDau", DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy");
            AppGridView.HideField(gridViewTietNghiaVu, new string[] { "MaGiangVien", "Bold" });
            AppGridView.ReadOnlyColumn(gridViewTietNghiaVu);
            #region InitNamHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            if (cboNamHoc.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.TietNghiaVu.GetTietNghiaVuCuaGiangVienCoChucVu(cboNamHoc.EditValue.ToString());
                tbl.Load(reader);
                bindingSourceTietNghiaVu.DataSource = tbl;
            }

            PMS.Common.Globals.GridRowColor(gridViewTietNghiaVu, new Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold), Color.White, "Bold", "1");
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlTietNghiaVu.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }
    }
}
