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
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucGiangVienGiamTruGioChuan : DevExpress.XtraEditors.XtraUserControl
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
        VList<ViewGiangVien> _listGiangVien = new VList<ViewGiangVien>();
        TList<GiamTruDinhMuc> _listGiamTru = new TList<GiamTruDinhMuc>();
        #endregion
        public ucGiangVienGiamTruGioChuan()
        {
            InitializeComponent();
        }

        private void ucGiangVienGiamTruGioChuan_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewGiamTru, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewGiamTru, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "TietNghiaVu", "MaGiamTruKhac", "SoTietGiamTruKhac", "TietNghiaVuSauGiamTru", "GhiChu2", "NgayCapNhat", "NguoiCapNhat" }
                                                     , new string[] { "Mã giảng viên", "Họ tên", "Khoa - Bộ môn", "Giờ chuẩn", "Nội dung giảm trừ", "Số tiết giảm trừ", "Tổng giờ chuẩn", "Ghi chú", "Ngày cập nhật", "Người cập nhật" }
                                                     , new int[] { 80, 160, 170, 80, 150, 80, 80, 150, 99, 99 });
            AppGridView.ShowEditor(gridViewGiamTru, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewGiamTru, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "TietNghiaVu", "MaGiamTruKhac", "SoTietGiamTruKhac", "TietNghiaVuSauGiamTru", "GhiChu2", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewGiamTru, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.ReadOnlyColumn(gridViewGiamTru, new string[] { "HoTen", "TenDonVi", "TietNghiaVu", "SoTietGiamTruKhac", "TietNghiaVuSauGiamTru" });
            AppGridView.RegisterControlField(gridViewGiamTru, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewGiamTru, "MaGiamTruKhac", repositoryItemGridLookUpEditNoiDungGiamTru);

            #region InitNamHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Khoa - Bộ môn" }, new int[] { 90, 170, 240 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 500, 650);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region Noi dung giam tru
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNoiDungGiamTru, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNoiDungGiamTru, new string[] { "NoiDungGiamTru", "MucGiam", "DonVi" }, new string[] { "Nội dung giảm trừ", "Mức giảm", "Đơn vị" }, new int[] { 250, 80, 70 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditNoiDungGiamTru, 400, 650);
            repositoryItemGridLookUpEditNoiDungGiamTru.DisplayMember = "NoiDungGiamTru";
            repositoryItemGridLookUpEditNoiDungGiamTru.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditNoiDungGiamTru.NullText = string.Empty;
            #endregion

            InitData();
        }

        void InitData()
        {
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            _listGiamTru = DataServices.GiamTruDinhMuc.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;
            bindingSourceNoiDungGiamTru.DataSource = _listGiamTru;
            if (cboNamHoc.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.TietNghiaVu.GetGiangVienGiamTru(cboNamHoc.EditValue.ToString());
                tbl.Load(reader);
                foreach (DataColumn col in tbl.Columns)
                {
                    col.ReadOnly = false;
                }
                bindingSourceGiamTru.DataSource = tbl;
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiamTru);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewGiamTru.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataTable list = bindingSourceGiamTru.DataSource as DataTable;

                try
                {
                    string xmlData = "";
                    foreach (DataRow kl in list.Rows)
                    {
                        //Kiểm tra điều kiện nếu có sửa mới cho insert hay update xuống
                        if (kl.RowState != DataRowState.Deleted)
                        {
                            xmlData += String.Format("<Input M=\"{0}\" MK=\"{1}\" TK=\"{2}\" T=\"{3}\" N=\"{4}\" U=\"{5}\" G2=\"{6}\" />"
                                    , kl["MaGiangVien"], PMS.Common.Globals.IsNull(kl["MaGiamTruKhac"], "int").ToString()
                                    , PMS.Common.Globals.IsNull(kl["SoTietGiamTruKhac"], "int")
                                    , PMS.Common.Globals.IsNull(Math.Round((decimal)kl["TietNghiaVuSauGiamTru"], 2, MidpointRounding.AwayFromZero), "decimal")
                                    , kl["NgayCapNhat"], kl["NguoiCapNhat"], kl["GhiChu2"]);
                        }
                    }
                    xmlData = string.Format("<Root>{0}</Root>", xmlData);
                    bindingSourceGiamTru.EndEdit();
                    int kq = 0;
                    DataServices.TietNghiaVu.LuuTheoNam(xmlData, cboNamHoc.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                            gridControlGiamTru.ExportToXls(sf.FileName);
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

        private void gridViewGiamTru_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVien")
            { 
                DataRowView row = gridViewGiamTru.GetRow(e.RowHandle) as DataRowView;
                ViewGiangVien gv = _listGiangVien.Find(p => p.MaGiangVien == int.Parse(row["MaGiangVien"].ToString()));
                int _tietNghiaVu = 0;
                DataServices.TietNghiaVu.GetByMaGiangVienNamHoc(gv.MaGiangVien, cboNamHoc.EditValue.ToString(), ref _tietNghiaVu);
                gridViewGiamTru.SetRowCellValue(e.RowHandle, "HoTen", gv.HoTen);
                gridViewGiamTru.SetRowCellValue(e.RowHandle, "TenDonVi", gv.TenDonVi);
                gridViewGiamTru.SetRowCellValue(e.RowHandle, "TietNghiaVu", _tietNghiaVu);
                gridViewGiamTru.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewGiamTru.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }

            if (col.FieldName == "MaGiamTruKhac")
            {
                DataRowView row = gridViewGiamTru.GetRow(e.RowHandle) as DataRowView;
                GiamTruDinhMuc g = _listGiamTru.Find(p => p.MaQuanLy == int.Parse(row["MaGiamTruKhac"].ToString()));

                decimal? t, v, q;

                t = decimal.Parse(row["TietNghiaVu"].ToString());
                if (g.DonVi.ToLower() == "phantram")
                {
                    q = (t * (100 - g.MucGiam)) / 100;
                    v = t - q;
                }
                else
                {
                    q = t - g.MucGiam;
                    v = g.MucGiam;
                }

                gridViewGiamTru.SetRowCellValue(e.RowHandle, "SoTietGiamTruKhac", Math.Round((decimal)v, 2, MidpointRounding.AwayFromZero));
                gridViewGiamTru.SetRowCellValue(e.RowHandle, "TietNghiaVuSauGiamTru", Math.Round((decimal)q, 2, MidpointRounding.AwayFromZero));
                gridViewGiamTru.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewGiamTru.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void gridViewGiamTru_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewGiamTru, e);
        }
    }
}
