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
using DevExpress.XtraGrid.Views.Grid;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class ucGiangVienChuyenDoiGioGiang : DevExpress.XtraEditors.XtraForm
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

                btnTuDong.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnTuDong.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnTuDong.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _listCauHinhChung = DataServices.CauHinhChung.GetAll();
        string _cauHinhHeSoTheoNam;
        VList<ViewGiangVien> _listGiangVien = new VList<ViewGiangVien>();
        #endregion

        public ucGiangVienChuyenDoiGioGiang()
        {
            InitializeComponent();
            _cauHinhHeSoTheoNam = _listCauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucGiangVienChuyenDoiGioGiang_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewChuyen, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewChuyen, new string[] {"MaGiangVien", "HoTen", "TenDonVi", "SoTietGiangChuyenSangNckh", "GhiChu" },
                new string[] { "Mã giảng viên", "Họ và tên", "Khoa - Đơn vị", "Số tiết giảng dạy chuyển sang NCKH", "Ghi chú" },
                new int[] { 80, 150, 150, 200, 150 });
            AppGridView.ShowEditor(gridViewChuyen, NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewChuyen, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.AlignHeader(gridViewChuyen, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "SoTietGiangChuyenSangNckh", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewChuyen, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            #endregion

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" }, new int[] { 90, 110 });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị" }, new int[] { 80, 150, 150 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 400, 650);
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if(cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            _listGiangVien = DataServices.ViewGiangVien.GetAll();
            bindingSourceGiangVien.DataSource = _listGiangVien;
            LoadDataSource();
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.GiangVienChuyenDoiGioGiang.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tb.Load(reader);
                foreach (DataColumn col in tb.Columns)
                    col.ReadOnly = false;
                bindingSourceChuyen.DataSource = tb;
                gridViewChuyen.ExpandAllGroups();
            }
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnTuDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                if (XtraMessageBox.Show("Lưu ý: chức năng tự động chuyển giờ giảng vượt sang NCKH sẽ ghi đè dữ liệu cũ.\n Bạn muốn hệ thống tự động chuyển giờ vượt giảng dạy sang NCKH?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int result = 0;
                        DataServices.GiangVienChuyenDoiGioGiang.TuDongChuyenDoiGio(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref result);
                        if (result == 0)
                            XtraMessageBox.Show("Tự động chuyển đổi giờ giảng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã có lỗi xảy ra trong quá trình chuyển đổi tự động.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadDataSource();
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã có lỗi xảy ra trong quá trình chuyển đổi tự động.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);   
                    }
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewChuyen);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewChuyen.FocusedRowHandle = -1;
            DataTable tb = bindingSourceChuyen.DataSource as DataTable;

            if (XtraMessageBox.Show("Bạn muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string xmlData = "";
                    foreach (DataRow r in tb.Rows)
                    {
                        if (r.RowState != DataRowState.Deleted)
                        {
                            if (r["MaGiangVien"].ToString() != "")
                            {
                                xmlData += "<Input M=\"" + r["MaGiangVien"]
                                        + "\" TG=\"" + PMS.Common.Globals.IsNull(r["SoTietGiangChuyenSangNckh"], "decimal")
                                        + "\" NC=\"" + 0//PMS.Common.Globals.IsNull(r["SoTietNckhChuyenSangGiangDay"], "decimal")
                                        + "\" G=\"" + r["GhiChu"]
                                        + "\" />";
                            }
                            else
                            {
                                XtraMessageBox.Show("Mã giảng viên không được bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                    }

                    xmlData = "<Root>" + xmlData + "</Root>";

                    int result = 0;
                    DataServices.GiangVienChuyenDoiGioGiang.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref result);
                    if (result == 0)
                        XtraMessageBox.Show("Lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã có lỗi xảy ra trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadDataSource();
                }
                catch
                { XtraMessageBox.Show("Đã có lỗi xảy ra trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK && sf.FileName != "")
                    {
                        gridControlChuyen.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }
        #endregion
        #region Event cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            LoadDataSource();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }
        #endregion

        private void gridViewChuyen_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "MaGiangVien")
            {
                try
                {
                    ViewGiangVien gv = _listGiangVien.Find(p => p.MaGiangVien == int.Parse(e.Value.ToString()));
                    gridViewChuyen.SetRowCellValue(e.RowHandle, "HoTen", gv.HoTen);
                    gridViewChuyen.SetRowCellValue(e.RowHandle, "TenDonVi", gv.TenDonVi);
                }
                catch 
                {
                    
                }
            }
        }
    }
}