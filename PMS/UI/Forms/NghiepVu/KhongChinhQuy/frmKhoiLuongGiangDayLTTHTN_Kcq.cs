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
using PMS.Services;
using System.Reflection;
using DevExpress.XtraGrid.Columns;

namespace PMS.UI.Forms.NghiepVu.KhongChinhQuy
{
    public partial class frmKhoiLuongGiangDayLTTHTN_Kcq : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;


                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnDongBo.ShortCut = Shortcut.None;

                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnQuyDoi.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnDongBo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnQuyDoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        TList<KcqHeSoDiaDiem> _listDiaDiem= DataServices.KcqHeSoDiaDiem.GetAll();
        string _maTruong;
        #endregion
        #region Event Form
        public frmKhoiLuongGiangDayLTTHTN_Kcq()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmKhoiLuongGiangDayLTTHTN_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewKhoiLuongGiangDay, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewKhoiLuongGiangDay, new string[] { "MaGiangVienQuanLy", "HoTen", "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "MaDiaDiem", "TenDiaDiem", "TienXeDiaDiem", "Nhom", "SiSo", "SoTiet", "SoTietDayChuNhat", "TenLoaiHocPhan", "TenNhomMon", "HeSoLopDongLyThuyet", "HeSoLopDongThTnTt", "SoGioThucGiangTrenLop", "SoGioChuanTinhThem", "HeSoHocKy", "TietQuyDoi" }
                , new string[] { "Mã giảng viên", "Họ và tên", "Mã môn học", "Tên môn học", "STC", "Mã lớp học phần", "Mã lớp", "Mã địa điểm", "Tên địa điểm", "Tiền xe địa điểm", "Nhóm", "Sĩ số", "Số tiết", "Số tiết chủ nhật", "Loại học phần", "Nhóm môn học", "HSLD Lý thuyết", "HSLD TH - TN", "Giờ thực giảng trên lớp", "Giờ chuẩn tính thêm", "Hệ số học kỳ", "Tổng tiêt quy đổi" }
                , new int[] { 80, 150, 100, 200, 50, 120, 100,90,150,90, 80, 50, 50, 100, 100, 100, 100, 100, 120, 120, 90, 90 });
            AppGridView.AlignHeader(gridViewKhoiLuongGiangDay, new string[] { "MaGiangVienQuanLy", "HoTen", "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "MaDiaDiem", "TenDiaDiem", "TienXeDiaDiem", "Nhom", "SiSo", "SoTiet", "SoTietDayChuNhat", "TenLoaiHocPhan", "TenNhomMon", "HeSoLopDongLyThuyet", "HeSoLopDongThTnTt", "SoGioThucGiangTrenLop", "SoGioChuanTinhThem", "HeSoHocKy", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuongGiangDay, "MaGiangVienQuanLy", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewKhoiLuongGiangDay, new string[] { "MaGiangVienQuanLy", "HoTen", "MaMonHoc", "TenMonHoc", "SoTinChi", "MaLopHocPhan", "MaLop", "Nhom", "SoTiet", "SoTietDayChuNhat", "TenLoaiHocPhan", "TenNhomMon", "HeSoLopDongLyThuyet", "HeSoLopDongThTnTt", "SoGioThucGiangTrenLop", "SoGioChuanTinhThem", "HeSoHocKy", "TietQuyDoi" });
            AppGridView.FormatDataField(gridViewKhoiLuongGiangDay, "TienXeDiaDiem", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewKhoiLuongGiangDay, "MaDiaDiem", repositoryItemGridLookUpEditDiaDiem);
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
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region MaDiaDiem
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDiaDiem, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditDiaDiem, 360, 600);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDiaDiem, new string[] { "MaQuanLy", "TenDiaDiem", "HeSoDiaDiem", "DonGia", "TienXeDiaDiem" }, new string[] { "Mã địa điểm", "Tên địa điểm", "Hệ số địa điểm", "Đơn giá", "Tiền xe địa điểm" }, new int[] { 100, 150, 80, 80, 90 });
            repositoryItemGridLookUpEditDiaDiem.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEditDiaDiem.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditDiaDiem.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion
        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            bindingSourceDiaDiem.DataSource = DataServices.KcqHeSoDiaDiem.GetAll();
            
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if(cboNamHoc.EditValue!=null && cboHocKy.EditValue!=null)
                bindingSourceKhoiLuongGiangDay.DataSource = DataServices.ViewKcqUteKhoiLuongQuyDoi2.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnDongBo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int kiemtra = 0;
            DataServices.KcqChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "LTTH", ref kiemtra);
            if (kiemtra == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép đồng bộ lại.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboNamHoc.EditValue == null && cboHocKy.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn năm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }
            if (XtraMessageBox.Show("Bạn có muốn đồng bộ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    using (frmXuLyDongBoDuLieu_Kcq frm = new frmXuLyDongBoDuLieu_Kcq(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _maTruong))
                    {
                        frm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Đã xãy ra lỗi trong quá trình đồng bộ." + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bindingSourceKhoiLuongGiangDay.DataSource = DataServices.ViewKcqUteKhoiLuongQuyDoi2.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void btnQuyDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Lưu ý: thực hiện phân loại học phần trước khi quy đổi. Bạn có muốn chuyển đến mục phân loại học phần?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (frmPhanLoaiHocPhanChoLopHocPhan_Kcq frm = new frmPhanLoaiHocPhanChoLopHocPhan_Kcq())
                {
                    frm.ShowDialog();
                }
            }
            int kiemtra = 0;
            DataServices.KcqChotKhoiLuongGiangDay.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "LTTH", ref kiemtra);
            if (kiemtra == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã chốt, không được phép quy đổi lại.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboNamHoc.EditValue == null && cboHocKy.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn năm học, học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }
            int kt = 0;
            DataServices.KcqUteKhoiLuongGiangDay.KiemTraDongBo(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kt);
            if (kt == 2)
            {
                if (XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã được quy đổi. Quy đổi lại sẽ xoá dữ liệu cũ. Bạn có muốn tiếp tục?", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmXuLyQuyDoiGioiChuanUTE_Kcq frm = new frmXuLyQuyDoiGioiChuanUTE_Kcq(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), true);
                    frm.ShowDialog();
                }
            }
            else
            {
                frmXuLyQuyDoiGioiChuanUTE_Kcq frm = new frmXuLyQuyDoiGioiChuanUTE_Kcq(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), true);
                frm.ShowDialog();
            }
            //Lay lai du lieu sau khi tinh.
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceKhoiLuongGiangDay.DataSource = DataServices.ViewKcqUteKhoiLuongQuyDoi2.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceKhoiLuongGiangDay.DataSource = DataServices.ViewKcqUteKhoiLuongQuyDoi2.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceKhoiLuongGiangDay.DataSource = DataServices.ViewKcqUteKhoiLuongQuyDoi2.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlKhoiLuongGiangDay.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }

        public static DataTable ToDataTable<T>(IEnumerable<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             gridViewKhoiLuongGiangDay.FocusedRowHandle = -1;
            Cursor.Current = Cursors.WaitCursor;

            VList<ViewKcqUteKhoiLuongQuyDoi2> list = bindingSourceKhoiLuongGiangDay.DataSource as VList<ViewKcqUteKhoiLuongQuyDoi2>;
            DataTable tb = ToDataTable(list);
           
            if (tb.Rows.Count > 0)
            {
                if (XtraMessageBox.Show("Bạn muốn lưu thay đổi sĩ số sinh viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string xmlData = "";
                    foreach (DataRow row in tb.Rows)
                    {

                        xmlData += "<Input LHP=\"" + row["MaLopHocPhan"].ToString()
                                    + "\" S=\"" + PMS.Common.Globals.IsNull(row["SiSo"].ToString(), "int")
                                    + "\" D=\"" + row["MaDiaDiem"].ToString()
                                    + "\" />";
                    }
                    xmlData = "<Root>" + xmlData + "</Root>";

                    int kq = 0;
                    DataServices.KcqUteKhoiLuongGiangDay.CapNhatSiSo(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                    if (kq == 0)
                        XtraMessageBox.Show("Lưu thay đổi sĩ số thành công. Lưu ý: thực hiện quy đổi lại để tính lại hệ số lớp đông.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
      
            Cursor.Current = Cursors.Default;
            
        }

        private void gridViewKhoiLuongGiangDay_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridColumn col = e.Column;
                int pos = e.RowHandle;
                if (col.FieldName == "MaDiaDiem")
                {
                    ViewKcqUteKhoiLuongQuyDoi2 v = gridViewKhoiLuongGiangDay.GetRow(pos) as ViewKcqUteKhoiLuongQuyDoi2;

                    string _tenDiaDiem = _listDiaDiem.Find(p => p.MaQuanLy == v.MaDiaDiem).TenDiaDiem;
                    decimal? _tienxeDiaDiem = _listDiaDiem.Find(p => p.MaQuanLy == v.MaDiaDiem).TienXeDiaDiem;
                    try
                    {
                        VMonHocTinChi _mh = DataServices.VMonHocTinChi.Get("MaMonHoc ='" + v.MaMonHoc + "'", "MaMonHoc")[0];

                        if (_mh.SoTinChi >= 4 || (_mh.SoTinChi >= 3 && _mh.ThucHanh > 0))//môn có số tín chỉ >= 4 hoặc tổng tín chỉ LT + TH >=3
                            _tienxeDiaDiem = _tienxeDiaDiem * int.Parse(_cauHinhChung.Find(p => p.TenCauHinh == "Hệ số nhân tiền xe địa điểm giảng dạy trên 60 tiết").GiaTri);

                    }
                    catch
                    { _tienxeDiaDiem = _listDiaDiem.Find(p => p.MaQuanLy == v.MaDiaDiem).TienXeDiaDiem; }
                   
                    gridViewKhoiLuongGiangDay.SetRowCellValue(e.RowHandle, "TenDiaDiem", _tenDiaDiem);
                    gridViewKhoiLuongGiangDay.SetRowCellValue(e.RowHandle, "TienXeDiaDiem", _tienxeDiaDiem);
                    gridViewKhoiLuongGiangDay.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now);
                }
            }
            catch
            { }
        }
        
    }
}