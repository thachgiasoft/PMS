using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmTongTienLuongTrongNamCuaGiangVien : DevExpress.XtraEditors.XtraForm
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
        #endregion
        public frmTongTienLuongTrongNamCuaGiangVien()
        {
            InitializeComponent();
        }

        private void frmTongTienLuongTrongNamCuaGiangVien_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewTongTienLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewTongTienLuong, new string[] { "MaGiangVien", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenDonVi", "TongTienLuong", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Loại giảng viên", "Khoa - Bộ môn", "Tổng tiền lương", "ngày cập nhật", "Người cập nhật" },
                        new int[] { 80, 170, 110, 110, 110, 150, 100, 99, 99 });
            AppGridView.ShowEditor(gridViewTongTienLuong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewTongTienLuong, new string[] { "MaGiangVien", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenDonVi", "TongTienLuong", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewTongTienLuong, new string[] { "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenDonVi" });
            AppGridView.RegisterControlField(gridViewTongTienLuong, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.HideField(gridViewTongTienLuong, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.FormatDataField(gridViewTongTienLuong, "TongTienLuong", DevExpress.Utils.FormatType.Custom, "n0");

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien" }, new string[] { "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Loại giảng viên" }, new int[] { 90, 150, 120, 120, 120 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 600, 600);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;

            if (cboNamHoc.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.TongTienLuongTrongNamCuaGiangVien.GetByNamHoc(cboNamHoc.EditValue.ToString());
                tb.Load(reader);
                foreach (DataColumn d in tb.Columns)
                {
                    d.ReadOnly = false;
                }
                bindingSourceTongTienLuong.DataSource = tb;
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
            AppGridView.DeleteSelectedRows(gridViewTongTienLuong);
        }

        private void gridViewTongTienLuong_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewTongTienLuong, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewTongTienLuong.FocusedRowHandle = -1;
            DataTable list = bindingSourceTongTienLuong.DataSource as DataTable;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string xmlData = "";
                    foreach (DataRow hs in list.Rows)
                    {
                        if (PMS.Common.Globals.IsNull(hs["MaGiangVien"], "int").ToString() != "0" && PMS.Common.Globals.IsNull(hs["TongTienLuong"], "decimal").ToString() != "0")
                        {
                            xmlData += "<Input M=\"" + hs["MaGiangVien"].ToString()
                                        + "\" T=\"" + hs["TongTienLuong"].ToString()
                                        + "\" D=\"" + hs["NgayCapNhat"].ToString()
                                        + "\" U=\"" + hs["NguoiCapNhat"].ToString()
                                        + "\" />";
                        }
                    }
                    xmlData = "<Root>" + xmlData + "</Root>";
                    bindingSourceTongTienLuong.EndEdit();
                    int kq = 0;
                    DataServices.TongTienLuongTrongNamCuaGiangVien.Luu(xmlData, cboNamHoc.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    sf.ShowDialog();
                    if (sf.FileName != "")
                    {
                        gridControlTongTienLuong.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewTongTienLuong_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVien")
            {
                DataRowView v = gridViewTongTienLuong.GetRow(e.RowHandle) as DataRowView;
                if (v != null)
                {
                    ViewGiangVien gv = _listGiangVien.Find(p => p.MaGiangVien == int.Parse(v["MaGiangVien"].ToString()));
                    gridViewTongTienLuong.SetRowCellValue(e.RowHandle, "HoTen", gv.HoTen);
                    gridViewTongTienLuong.SetRowCellValue(e.RowHandle, "TenHocHam", gv.TenHocHam);
                    gridViewTongTienLuong.SetRowCellValue(e.RowHandle, "TenHocVi", gv.TenHocVi);
                    gridViewTongTienLuong.SetRowCellValue(e.RowHandle, "TenLoaiGiangVien", gv.TenLoaiGiangVien);
                    gridViewTongTienLuong.SetRowCellValue(e.RowHandle, "TenDonVi", gv.TenDonVi);
                }
            }
            if (col.FieldName == "MaGiangVien" || col.FieldName == "TongTienLuong")
            {
                gridViewTongTienLuong.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToLongDateString());
                gridViewTongTienLuong.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void gridViewTongTienLuong_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

    }
}