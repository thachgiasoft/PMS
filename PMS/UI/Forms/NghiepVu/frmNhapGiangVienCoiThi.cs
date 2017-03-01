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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmNhapGiangVienCoiThi : DevExpress.XtraEditors.XtraForm
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
        public frmNhapGiangVienCoiThi()
        {
            InitializeComponent();
        }

        private void frmNhapGiangVienCoiThi_Load(object sender, EventArgs e)
        {
            #region InitGrid
            AppGridView.InitGridView(gridViewCoiThi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewCoiThi, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewCoiThi, new string[] { "MaGiangVienQuanLy", "HoTen", "SoTien", "NoiDung", "NgayCapNhat", "NguoiCapNhat" }
                                    , new string[] { "Mã giảng viên", "Họ tên", "Số tiết", "Ghi chú", "d", "u" }, new int[] { 100, 170, 120, 250, 99, 99 });
            AppGridView.AlignHeader(gridViewCoiThi, new string[] { "MaGiangVienQuanLy", "HoTen", "SoTien", "NoiDung", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewCoiThi, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.RegisterControlField(gridViewCoiThi, "MaGiangVienQuanLy", repositoryItemGridLookUpEditGiangVien);
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
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "NgaySinh" }, new string[] { "Mã giảng viên", "Họ tên", "Ngày sinh" }, new int[] { 100, 200, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 400, 650);
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion
            #region DonVi
            AppGridLookupEdit.InitGridLookUp(cboDonVi, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDonVi, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã đơn vị", "Tên đơn vị" });
            cboDonVi.Properties.ValueMember = "MaBoMon";
            cboDonVi.Properties.DisplayMember = "TenBoMon";
            cboDonVi.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }
        void InitData()
        {
            cboDonVi.DataBindings.Clear();
            bindingSourceDonVi.DataSource = DataServices.ViewKhoaBoMon.GetAll();
            cboDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);
            if (cboDonVi.EditValue != null)
            {
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboDonVi.EditValue.ToString());
                bindingSourceGiangVien.DataSource = _listGiangVien;
            }
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.ThuLaoCoiThi.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tbl.Load(reader);
                foreach (DataColumn col in tbl.Columns)
                {
                    col.ReadOnly = false;
                }
                bindingSourceCoiThi.DataSource = tbl;
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
            AppGridView.DeleteSelectedRows(gridViewCoiThi);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewCoiThi.FocusedRowHandle = -1;
            DataTable list = bindingSourceCoiThi.DataSource as DataTable;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        string xmlData = "";
                        foreach (DataRow v in list.Rows)
                        {
                            if(v.RowState != DataRowState.Deleted)
                            {
                                if (v["MaGiangVienQuanLy"] != null || v["SoTien"] != null)
                                {
                                    xmlData += "<Input M=\"" + v["MaGiangVienQuanLy"].ToString()
                                                + "\" S=\"" + PMS.Common.Globals.IsNull(v["SoTien"], "decimal").ToString()
                                                + "\" G=\"" + v["NoiDung"].ToString()
                                                + "\" D=\"" + v["NgayCapNhat"].ToString()
                                                + "\" U=\"" + v["NguoiCapNhat"].ToString()
                                                + "\" />";
                                }
                            }
                        }
                        xmlData = String.Format("<Root>{0}</Root>", xmlData);
                        int kq = 0;
                        DataServices.ThuLaoCoiThi.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi. Kiểm tra lại dữ liệu vừa nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi. Kiểm tra lại dữ liệu vừa nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cursor.Current = Cursors.Default;
                }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (SaveFileDialog file = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (file.FileName != "")
                    {
                        gridControlCoiThi.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void gridViewCoiThi_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewCoiThi, e);
        }

        private void gridViewCoiThi_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVienQuanLy")
            {
                DataRowView r = gridViewCoiThi.GetRow(e.RowHandle) as DataRowView;
                string _hoTen = _listGiangVien.Find(p => p.MaQuanLy == r["MaGiangVienQuanLy"]).HoTen;

                gridViewCoiThi.SetRowCellValue(e.RowHandle, "HoTen", _hoTen);
            }

            if (col.FieldName == "MaGiangVienQuanLy" || col.FieldName == "SoTien" || col.FieldName == "NoiDung")
            {
                gridViewCoiThi.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewCoiThi.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.ThuLaoCoiThi.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tbl.Load(reader);
                foreach (DataColumn col in tbl.Columns)
                {
                    col.ReadOnly = false;
                }
                bindingSourceCoiThi.DataSource = tbl;
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.ThuLaoCoiThi.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tbl.Load(reader);
                foreach (DataColumn col in tbl.Columns)
                {
                    col.ReadOnly = false;
                }
                bindingSourceCoiThi.DataSource = tbl;
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboDonVi_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboDonVi.EditValue != null)
            {
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboDonVi.EditValue.ToString());
                bindingSourceGiangVien.DataSource = _listGiangVien;
            }
           
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.ThuLaoCoiThi.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tbl.Load(reader);
                foreach (DataColumn col in tbl.Columns)
                {
                    col.ReadOnly = false;
                }
                bindingSourceCoiThi.DataSource = tbl;
            }
            Cursor.Current = Cursors.Default;
        }
    }
}