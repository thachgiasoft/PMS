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
    public partial class ucThoiGianNghiTamThoi : DevExpress.XtraEditors.XtraUserControl
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
        VList<ViewGiangVien> _listGiangVien;
        string _maTruong;
        #endregion

        #region Event Form
        public ucThoiGianNghiTamThoi()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucThoiGianNghiTamThoi_Load(object sender, EventArgs e)
        {
            #region InitGridView
            switch (_maTruong)
            { 
                case "DLU":
                    InitGridDLU();
                    break;
                case "VHU":
                    InitGridDLU();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Khoa - Bộ môn" }, new int[] { 90, 170, 240 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 500, 650);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region LyDoNghi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLyDo, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLyDo, new string[] { "MaQuanLy", "TenLyDoTamNghi" }, new string[] { "Mã quản lý", "Tên lý do tạm nghỉ" }, new int[] { 90, 210 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLyDo, 300, 650);
            repositoryItemGridLookUpEditLyDo.DisplayMember = "TenLyDoTamNghi";
            repositoryItemGridLookUpEditLyDo.ValueMember = "Id";
            repositoryItemGridLookUpEditLyDo.NullText = string.Empty;
            #endregion

            #region NoiDungGiamTru
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNoiDungGiamTru, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNoiDungGiamTru, new string[] { "NoiDungGiamTru" }, new string[] { "Lý do" }, new int[] { 300 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditNoiDungGiamTru, 300, 650);
            repositoryItemGridLookUpEditNoiDungGiamTru.DisplayMember = "NoiDungGiamTru";
            repositoryItemGridLookUpEditNoiDungGiamTru.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditNoiDungGiamTru.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion

        #region InitGrid
        void InitGridDLU()
        {
            AppGridView.InitGridView(gridViewThoiGian, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewThoiGian, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewThoiGian, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "MaTamNghi", "TuNgay", "DenNgay", "GhiChu" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Lý do", "Từ ngày", "Đến ngày", "Ghi chú" }
                    , new int[] { 90, 150, 160, 200, 90, 90, 200 });
            AppGridView.AlignHeader(gridViewThoiGian, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "MaTamNghi", "TuNgay", "DenNgay", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewThoiGian, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewThoiGian, "MaTamNghi", repositoryItemGridLookUpEditNoiDungGiamTru);
            AppGridView.SummaryField(gridViewThoiGian, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewThoiGian, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewThoiGian, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewThoiGian, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "MaTamNghi", "TuNgay", "DenNgay", "GhiChu" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Lý do", "Từ ngày", "Đến ngày", "Ghi chú" }
                    , new int[] { 90, 150, 160, 200, 90, 90, 200 });
            AppGridView.AlignHeader(gridViewThoiGian, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "MaTamNghi", "TuNgay", "DenNgay", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewThoiGian, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewThoiGian, "MaTamNghi", repositoryItemGridLookUpEditLyDo);
            AppGridView.SummaryField(gridViewThoiGian, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
        }
        #endregion

        #region InitData
        void InitData()
        {
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;
            bindingSourceLyDo.DataSource = DataServices.LyDoTamNghi.GetAll();

            bindingSourceNoiDungGiamTru.DataSource = DataServices.GiamTruDinhMuc.GetAll();

            DataTable tb = new DataTable();
            IDataReader reader = DataServices.ThoiGianNghiTamThoiCuaGiangVien.GetAllGiangVienTamNghi();
            tb.Load(reader);
            foreach (DataColumn col in tb.Columns)
            {
                col.ReadOnly = false;
            }
            bindingSourceThoiGian.DataSource = tb;
            
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewThoiGian);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThoiGian.FocusedRowHandle = -1;
            DataTable list = bindingSourceThoiGian.DataSource as DataTable;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string xmlData = "";
                    foreach (DataRow v in list.Rows)
                    {
                        if (v.RowState != DataRowState.Deleted)
                        {
                            if (v["TuNgay"].ToString() != "" && v["DenNgay"].ToString() != "")
                            {
                                xmlData += "<Input Id=\"" + v["Id"]
                                        + "\" M=\"" + v["MaGiangVien"]
                                        + "\" G=\"" + v["MaTamNghi"]
                                        + "\" Tu=\"" + ((DateTime)v["TuNgay"]).ToString("dd/MM/yyyy")
                                        + "\" Den=\"" + ((DateTime)v["DenNgay"]).ToString("dd/MM/yyyy")
                                        + "\" GC=\"" + v["GhiChu"]
                                        + "\" />";
                            }
                            else
                            {
                                XtraMessageBox.Show("Thời gian từ ngày, đến ngày không được phép bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }
                    xmlData = "<Root>" + xmlData + "</Root>";
                    bindingSourceThoiGian.EndEdit();
                    int kq = 0;
                    DataServices.ThoiGianNghiTamThoiCuaGiangVien.Luu(xmlData, ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                InitData();
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    sf.ShowDialog();
                    if (sf.FileName != "")
                    {
                        gridControlThoiGian.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void gridViewThoiGian_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVien")
            {
                DataRowView v = gridViewThoiGian.GetRow(e.RowHandle) as DataRowView;
                ViewGiangVien gv = _listGiangVien.Find(p => p.MaGiangVien == int.Parse(v["MaGiangVien"].ToString()));
                gridViewThoiGian.SetRowCellValue(e.RowHandle, "HoTen", gv.HoTen);
                gridViewThoiGian.SetRowCellValue(e.RowHandle, "TenDonVi", gv.TenDonVi);
            }
        }

        private void gridViewThoiGian_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewThoiGian, e);
        }
    }
}
