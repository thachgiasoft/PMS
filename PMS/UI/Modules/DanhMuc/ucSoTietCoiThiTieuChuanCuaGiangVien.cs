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
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucSoTietCoiThiTieuChuanCuaGiangVien : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion

        public ucSoTietCoiThiTieuChuanCuaGiangVien()
        {
            InitializeComponent();
        }

        private void ucSoTietCoiThiTieuChuanCuaGiangVien_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewTietCTTCGV, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTietCTTCGV, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "SoTietCoiThiTieuChuan", "NgayCapNhat", "NguoiCapNhat", "MaGiangVien", "GhiChu" }
                    , new string[] { "Khoa - Đơn vị", "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Loại giảng viên", "Số tiết coi thi TC", "Ngày cập nhật", "người cập nhật", "MaGiangVien", "Ghi chú" }
                    , new int[] { 99, 90, 160, 100, 100, 100, 100, 99, 99, 99, 150 });
            AppGridView.AlignHeader(gridViewTietCTTCGV, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "SoTietCoiThiTieuChuan", "NgayCapNhat", "NguoiCapNhat", "MaGiangVien", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewTietCTTCGV, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "MaGiangVien" });
            AppGridView.SummaryField(gridViewTietCTTCGV, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewTietCTTCGV, "SoTietCoiThiTieuChuan", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.HideField(gridViewTietCTTCGV, new string[] { "NgayCapNhat", "NguoiCapNhat", "MaGiangVien" });
            gridViewTietCTTCGV.Columns["TenDonVi"].GroupIndex = 0;

            #region _namHoc
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
                bindingSourceTietCTTCGV.DataSource = DataServices.ViewSoTietCoiThiTieuChuanCuaGiangVien.GetByNamHoc(cboNamHoc.EditValue.ToString());
                gridViewTietCTTCGV.ExpandAllGroups();
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewTietCTTCGV.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    VList<ViewSoTietCoiThiTieuChuanCuaGiangVien> _vList = bindingSourceTietCTTCGV.DataSource as VList<ViewSoTietCoiThiTieuChuanCuaGiangVien>;
                    string xmlData = "";
                    foreach (ViewSoTietCoiThiTieuChuanCuaGiangVien v in _vList)
                    {
                        xmlData += "<Input M=\"" + v.MaGiangVien
                                + "\" S=\"" + v.SoTietCoiThiTieuChuan
                                + "\" D=\"" + v.NgayCapNhat
                                + "\" U=\"" + v.NguoiCapNhat
                                + "\" G=\"" + v.GhiChu
                                + "\" />";
                    }
                    xmlData = "<Root>" + xmlData + "</Root>";

                    int kq = 0;
                    DataServices.ViewSoTietCoiThiTieuChuanCuaGiangVien.Luu(xmlData, cboNamHoc.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch 
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                            gridControlTietCTTCGV.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceTietCTTCGV.DataSource = DataServices.ViewSoTietCoiThiTieuChuanCuaGiangVien.GetByNamHoc(cboNamHoc.EditValue.ToString());
                gridViewTietCTTCGV.ExpandAllGroups();
            }
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepSoTietCoiThiTieuChuan"))
            {
                frm.ShowDialog();
            }
            InitData();
        }
    }
}
