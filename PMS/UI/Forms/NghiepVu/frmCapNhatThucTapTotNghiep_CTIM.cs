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
using PMS.BLL;
using DevExpress.Common.Grid;
using System.Runtime.InteropServices;
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmCapNhatThucTapTotNghiep_CTIM : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
                btnCapNhatSiSo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnCapNhatSiSo.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnCapNhatSiSo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _listCauHinhChung = DataServices.CauHinhChung.GetAll();
        private string groupname = UserInfo.GroupName;
        private bool user = false;
        #endregion

        public frmCapNhatThucTapTotNghiep_CTIM()
        {
            InitializeComponent();
        }

        private void frmCapNhatThucTapTotNghiep_CTIM_Load(object sender, EventArgs e)
        {
            #region Init GridView LoaiKhoiLuong
            AppGridView.InitGridView(gridViewTTTN, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewTTTN, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "MaQuanLy", "HoTen", "SoLuong", "NgayCapNhat", "NguoiCapNhat" },
                new string[] { "Mã học phần", "Tên học phần", "STC", "Mã lớp học phần", "Mã lớp", "Mã giảng viên", "Họ tên", "Số lượng", "NgayCapNhat", "NguoiCapNhat" },
                new int[] { 80, 180, 50, 110, 80, 80, 150, 80, 99, 99 });

            AppGridView.AlignHeader(gridViewTTTN, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "MaQuanLy", "HoTen", "SoLuong", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewTTTN, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.ReadOnlyColumn(gridViewTTTN, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "MaQuanLy", "HoTen" });
            
            #endregion

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
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
           
            #region _khoaDonVi
            AppGridLookupEdit.InitGridLookUp(cboDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" });
            cboDonVi.Properties.ValueMember = "MaKhoa";
            cboDonVi.Properties.DisplayMember = "TenKhoa";
            cboDonVi.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            cboDonVi.DataBindings.Clear();

            #region khoa - bo mon
            VList<ViewKhoaBoMon> vKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            foreach (ViewKhoaBoMon v in vKhoaBoMon)
            {
                if (groupname == v.MaBoMon)
                {
                    user = true; break;
                }
            }
            #endregion

            if (user == true)
            {
                vKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(groupname);
                btnLuu.Enabled = true;
                btnCapNhatSiSo.Enabled = true;
            }
            else
            {
                vKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
                vKhoaBoMon.Add(new ViewKhoaBoMon() { MaKhoa = "-1", TenKhoa = "[Tất cả]", ThuTu = 0 });
                btnLuu.Enabled = false;
                btnCapNhatSiSo.Enabled = false;
            }
            bindingSourceKhoaBoMon.DataSource = vKhoaBoMon;

            cboDonVi.DataBindings.Add("EditValue", bindingSourceKhoaBoMon, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KhoiLuongGiangDayChiTiet.GetLhpThucTapTotNghiepByNamHocHocKyKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceTTTN.DataSource = tb;
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewTTTN.FocusedRowHandle = -1;
            if (XtraMessageBox.Show("Bạn muốn lưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string xmlData = "";
                    DataTable tb = bindingSourceTTTN.DataSource as DataTable;
                    foreach (DataRow r in tb.Rows)
                    {
                        if (r.RowState == DataRowState.Modified)
                        {
                            xmlData += String.Format("<Input M=\"{0}\" L=\"{1}\" S=\"{2}\" D=\"{3}\" U=\"{4}\" />", r["MaQuanLy"], r["MaLopHocPhan"], PMS.Common.Globals.IsNull(r["SoLuong"], "int"), r["NgayCapNhat"], r["NguoiCapNhat"]);
                        }
                    }

                    xmlData = String.Format("<Root>{0}</Root>", xmlData);

                    int kq = -1;
                    DataServices.KhoiLuongGiangDayChiTiet.LuuSoLuongThucTapTotNghiep(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), ref kq);

                    if (kq == 0)
                        XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                        gridControlTTTN.ExportToXls(sf.FileName);
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
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KhoiLuongGiangDayChiTiet.GetLhpThucTapTotNghiepByNamHocHocKyKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceTTTN.DataSource = tb;
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KhoiLuongGiangDayChiTiet.GetLhpThucTapTotNghiepByNamHocHocKyKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceTTTN.DataSource = tb;
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboDonVi_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KhoiLuongGiangDayChiTiet.GetLhpThucTapTotNghiepByNamHocHocKyKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceTTTN.DataSource = tb;
            }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewTTTN_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "SoLuong")
            {
                gridViewTTTN.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewTTTN.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void btnCapNhatSiSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboDonVi.EditValue != null)
            {
                if (XtraMessageBox.Show("Bạn muốn cập nhật lại sĩ số các lớp học phần từ Module Lịch - TKB?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        DataServices.KhoiLuongGiangDayChiTiet.CapNhatSiSoLopThucTapTotNghiep(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                        Cursor.Current = Cursors.Default;
                        XtraMessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    DataTable tb = new DataTable();
                    IDataReader reader = DataServices.KhoiLuongGiangDayChiTiet.GetLhpThucTapTotNghiepByNamHocHocKyKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString());
                    tb.Load(reader);
                    bindingSourceTTTN.DataSource = tb;
                }
            }
        }
    }
}