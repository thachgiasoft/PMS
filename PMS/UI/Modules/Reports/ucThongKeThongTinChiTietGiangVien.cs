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
using PMS.BLL;
using PMS.Services;
using DevExpress.XtraEditors.Controls;
using DevExpress.Common.DataForm;
using PMS.UI.Forms.BaoCao;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.Services;
using DevExpress.XtraGrid;
using PMS.Common;
using ExcelLibrary;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeThongTinChiTietGiangVien : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        string groupname = UserInfo.GroupName;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        private bool user = false;
        private DataSet dsGiangVien;
        public DataTable tbgiangvien = new DataTable();
        string[] fileName, capTion;
        
        #endregion

        public ucThongKeThongTinChiTietGiangVien()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

            TList<CauHinh> cauHinh = DataServices.CauHinh.GetAll();
            if (cauHinh != null)
            {
                foreach (CauHinh ch in cauHinh)
                {
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
                }
            }
        }

        public ucThongKeThongTinChiTietGiangVien(string[] _fieldName, string[] _capTion)
        {
            InitializeComponent();
            fileName = _fieldName;
            capTion = _capTion;

        }




        #region InitData
        void InitData()
        {
           

            #region Init Khoa-DonVi
            cboKhoa.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoa.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoa.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = new VList<ViewKhoaBoMon>();
            _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();

            #region khoa - bo mon

            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (groupname == v.MaBoMon)
                {
                    user = true; break;
                }
            }
            #endregion
            if (user == true)
            {
                if (_maTruong == "UTE")
                    _vListKhoaBoMon = _vListKhoaBoMon.FindAll(p => p.TenKhoa == groupname) as VList<ViewKhoaBoMon>;
                else
                {
                    _vListKhoaBoMon = _vListKhoaBoMon.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoaBoMon>;
                }
            }
            else
            {
                _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            }

            //if (groupname != "Administrator" && groupname != "Phòng công tác HSSV")
            //{
            //    if (_maTruong == "UTE")
            //        _vListKhoa = _vListKhoa.FindAll(p => p.TenKhoa == groupname) as VList<ViewKhoaBoMon>;
            //    else
            //    {
            //        _vListKhoa = _vListKhoa.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoaBoMon>;
            //    }
            //}

            if (_maTruong == "CTIM")
            {
                VList<ViewKhoaBoMon> v = _vListKhoaBoMon.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoaBoMon>;
                if (v.Count > 0)
                {
                    _vListKhoaBoMon = _vListKhoaBoMon.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoaBoMon>;
                }
                else
                    _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            }

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaBoMon, string.Format("{0} - {1}", v.MaBoMon, v.TenBoMon), CheckState.Unchecked, true));
            }
            cboKhoa.Properties.Items.AddRange(_list.ToArray());
            cboKhoa.Properties.SeparatorChar = ';';
            cboKhoa.CheckAll();
            #endregion

            #region LoaiGiangVien
            cboLoaiGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiGiangVien.Properties.Items.Clear();

            TList<LoaiGiangVien> _tListLoaiGiangVien = DataServices.LoaiGiangVien.GetAll();

            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();

            foreach (LoaiGiangVien l in _tListLoaiGiangVien)
                list.Add(new CheckedListBoxItem(l.MaLoaiGiangVien, string.Format("{0} - {1}", l.MaQuanLy, l.TenLoaiGiangVien), CheckState.Unchecked, true));
            cboLoaiGiangVien.Properties.Items.AddRange(list.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
            #endregion

            #region TinhTrang
            cboTinhTrang.Properties.SelectAllItemCaption = "Tất cả";
            cboTinhTrang.Properties.TextEditStyle = TextEditStyles.Standard;
            cboTinhTrang.Properties.Items.Clear();

            TList<TinhTrang> _tListTinhTrang = DataServices.TinhTrang.GetAll();
            List<CheckedListBoxItem> listTinhTrang = new List<CheckedListBoxItem>();
            foreach (TinhTrang t in _tListTinhTrang)
            {
                listTinhTrang.Add(new CheckedListBoxItem(t.MaTinhTrang, string.Format("{0} - {1}", t.MaQuanLy, t.TenTinhTrang), CheckState.Unchecked, true));
            }
            cboTinhTrang.Properties.Items.AddRange(listTinhTrang.ToArray());
            cboTinhTrang.Properties.SeparatorChar = ';';
            cboTinhTrang.CheckAll();
            #endregion

            //if (cboKhoa.EditValue.ToString() != "" && cboLoaiGiangVien.EditValue.ToString() != "" && cboTinhTrang.EditValue.ToString() != "")
            //{
            //    DataTable tb = new DataTable();
            //    IDataReader reader = DataServices.GiangVien.GetByMaDonViLoaiGiangVien(cboKhoa.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), cboTinhTrang.EditValue.ToString());
            //    tb.Load(reader);
            //    bindingSourceDanhSachGiangVien.DataSource = tb;
            //}
            gridViewDanhSachGiangVien.ExpandAllGroups();
        }
        #endregion

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
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlDanhSachGiangVien.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }

            //DataTable tbgv = bindingSourceDanhSachGiangVien.DataSource as DataTable;
            //if (tbgv.Rows.Count>0)
            //{
            //    DataTable table = new DataTable();
            //    table.Columns.Add("MaQuanLy", typeof(string));
            //    table.Columns.Add("Ho", typeof(string));
            //    table.Columns.Add("Ten", typeof(string));
            //    table.Columns.Add("Khoa", typeof(string));
            //    table.Columns.Add("TenDonVi", typeof(string));
            //    table.Columns.Add("MaHocHam", typeof(string));
            //    table.Columns.Add("TenHocHam", typeof(string));
            //    table.Columns.Add("MaHocVi", typeof(string));
            //    table.Columns.Add("TenHocVi", typeof(string));
            //    table.Columns.Add("TenLoaiGiangVien", typeof(string));
            //    table.Columns.Add("GioiTinh", typeof(string));
            //    table.Columns.Add("NgaySinh", typeof(string));
            //    table.Columns.Add("NoiSinh", typeof(string));
            //    table.Columns.Add("Cmnd", typeof(string));
            //    table.Columns.Add("NgayCap", typeof(string));
            //    table.Columns.Add("NoiCap", typeof(string));
            //    table.Columns.Add("TenDanToc", typeof(string));
            //    table.Columns.Add("TenTonGiao", typeof(string));
            //    table.Columns.Add("DoanDang", typeof(bool));
            //    table.Columns.Add("NgayVaoDoanDang", typeof(string));
            //    table.Columns.Add("DiaChi", typeof(string));
            //    table.Columns.Add("ThuongTru", typeof(string));
            //    table.Columns.Add("Email", typeof(string));
            //    table.Columns.Add("DienThoai", typeof(string));
            //    table.Columns.Add("SoDiDong", typeof(string));
            //    table.Columns.Add("NoiLamViec", typeof(string));
            //    table.Columns.Add("NgayKyHopDong", typeof(DateTime));
            //    table.Columns.Add("NgayKetThucHopDong", typeof(DateTime));
            //    table.Columns.Add("TenTinhTrang", typeof(string));
            //    table.Columns.Add("SoTaiKhoan", typeof(string));
            //    table.Columns.Add("TenNganHang", typeof(string));
            //    table.Columns.Add("MaSoThue", typeof(string));
            //    table.Columns.Add("ChiNhanh", typeof(string));
            //    table.Columns.Add("SoSoBaoHiem", typeof(string));
            //    table.Columns.Add("ThoiGianBatDau", typeof(string));
            //    table.Columns.Add("BacLuong", typeof(decimal));
            //    table.Columns.Add("NgayHuongLuong", typeof(string));
            //    table.Columns.Add("NamLamViec", typeof(string));
            //    table.Columns.Add("ChuyenNganh", typeof(string));
            //    table.Columns.Add("Ngach", typeof(string));
            //    table.Columns.Add("SoHieuCongChuc", typeof(string));
            //    table.Columns.Add("NoiCapBang", typeof(string));
            //    table.Columns.Add("KhoaTaiKhoan", typeof(string));
            //    table.Columns.Add("TenLoaiNhanVien", typeof(string));
            //    table.Columns.Add("TenNgach", typeof(string));
            //    table.Columns.Add("TenTrinhDoChinhTri", typeof(string));
            //    table.Columns.Add("TenTrinhDoSuPham", typeof(string));
            //    table.Columns.Add("TenTrinhDoNgoaiNgu", typeof(string));
            //    table.Columns.Add("TenTrinhDoTinHoc", typeof(string));
            //    table.Columns.Add("TenTrinhDoQuanLyNhaNuoc", typeof(string));
            //    table.Columns.Add("NgayCapNhat", typeof(DateTime));
            //    table.Columns.Add("NguoiCapNhat", typeof(string));

            //    foreach (DataRow row in tbgv.Rows)
            //    {


            //        table.Rows.Add(
            //           row["MaQuanLy"], row["Ho"], row["Ten"], row["Khoa"], row["TenDonVi"]
            //           , row["MaHocHam"], row["TenHocHam"], row["MaHocVi"], row["TenHocVi"]
            //           , row["TenLoaiGiangVien"], row["GioiTinh"], row["NgaySinh"], row["NoiSinh"]
            //           , row["Cmnd"], row["NgayCap"], row["NoiCap"], row["TenDanToc"], row["TenTonGiao"]
            //           , row["DoanDang"], row["NgayVaoDoanDang"], row["DiaChi"], row["ThuongTru"]
            //           , row["Email"], row["DienThoai"], row["SoDiDong"], row["NoiLamViec"]
            //           , row["NgayKyHopDong"], row["NgayKetThucHopDong"], row["TenTinhTrang"]
            //           , row["SoTaiKhoan"], row["TenNganHang"], row["MaSoThue"], row["ChiNhanh"]
            //           , row["SoSoBaoHiem"], row["ThoiGianBatDau"], row["BacLuong"], row["NgayHuongLuong"]
            //           , row["NamLamViec"], row["ChuyenNganh"], row["Ngach"], row["SoHieuCongChuc"]
            //           , row["NoiCapBang"], row["KhoaTaiKhoan"], row["TenLoaiNhanVien"], row["TenNgach"]
            //           , row["TenTrinhDoChinhTri"], row["TenTrinhDoSuPham"], row["TenTrinhDoNgoaiNgu"]
            //           , row["TenTrinhDoTinHoc"], row["TenTrinhDoQuanLyNhaNuoc"], row["NgayCapNhat"], row["NguoiCapNhat"]
            //           );
            //    }
            //    dsGiangVien = new DataSet("DsGiangVien");
            //    dsGiangVien.Tables.Add(table);
            //    SaveFileDialog f = new SaveFileDialog();
            //    f.Filter = "Excel file (*.xls)|*.xls";
            //    if (f.ShowDialog() == DialogResult.OK)
            //    {
            //        try
            //        {
            //            iloveit1208Library k = new iloveit1208Library();//Lib ExcelLibrary
            //            k.ExportToExcel(dsGiangVien, f.FileName);
            //            XtraMessageBox.Show("Đã xuất danh sách thành công.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //        catch
            //        {
            //            XtraMessageBox.Show("Lỗi xuất dữ liệu.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    Cursor.Current = Cursors.Default;
            //}
            //else
            //{
            //    XtraMessageBox.Show("Chưa lọc danh sách giảng viên.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //Cursor.Current = Cursors.Default;




         
        }

        

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (dateEditNgay.Text == "")
            {
                XtraMessageBox.Show("Chưa chọn ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {


                if (cboKhoa.EditValue.ToString() != "" && cboLoaiGiangVien.EditValue.ToString() != "" && cboTinhTrang.EditValue.ToString() != "" && dateEditNgay.Text != "")
                {
                    DataTable tb = new DataTable();
                    IDataReader reader = DataServices.GiangVien.GetThongTinChiTietByMaDonViLoaiGiangVienTinhTrang(cboKhoa.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), cboTinhTrang.EditValue.ToString(), dateEditNgay.DateTime);
                    tb.Load(reader);
                    bindingSourceDanhSachGiangVien.DataSource = tb;
                    tbgiangvien = tb;
                    gridViewDanhSachGiangVien.BestFitColumns();
                    gridViewDanhSachGiangVien.BestFitMaxRowCount = 5000;
                }
            }
            gridViewDanhSachGiangVien.ExpandAllGroups();
     

            Cursor.Current = Cursors.Default;
        }

        private void ucThongKeThongTinChiTietGiangVien_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewDanhSachGiangVien, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            //AppGridView.ShowField(gridViewDanhSachGiangVien, new string[] { "MaQuanLy", "Ho", "Ten", "Khoa", "TenDonVi", "MaHocHam", "TenHocHam", "MaHocVi", "TenHocVi", "TenLoaiGiangVien", "GioiTinh", "NgaySinh", "NoiSinh", "Cmnd", "NgayCap", "NoiCap", "TenDanToc", "TenTonGiao", "DoanDang", "NgayVaoDoanDang", "DiaChi", "ThuongTru", "Email", "DienThoai", "SoDiDong", "NoiLamViec", "NgayKyHopDong", "NgayKetThucHopDong", "TenTinhTrang", "SoTaiKhoan", "TenNganHang", "MaSoThue", "ChiNhanh", "SoSoBaoHiem", "ThoiGianBatDau", , "NgayHuongLuong", "NamLamViec", "ChuyenNganh", "Ngach", "SoHieuCongChuc", "NoiCapBang", "KhoaTaiKhoan", "TenLoaiNhanVien", "TenNgach", "TenTrinhDoChinhTri", "TenTrinhDoSuPham", "TenTrinhDoNgoaiNgu", "TenTrinhDoTinHoc", "TenTrinhDoQuanLyNhaNuoc", "NgayCapNhat", "NguoiCapNhat" }
            //        , new string[] { "Mã giảng viên", "Họ", "Tên", "-", "bộ môn", "Mã học hàm", "Học hàm", "Mã học vị", "Học vị", "Loại giảng viên", "Giới tính", "Ngày sinh", "Nơi sinh", "CMND", "Ngày cấp", "Nơi cấp", "Dân tộc", "Tôn giáo", "Đoàn đảng", "Ngày vào đoàn đảng", "Địa chỉ", "Thường trú", "E-mail", "Điện thoại", "Số di động", "Nơi làm việc", "Ngày ký hợp đồng", "Ngày kết thúc hợp đồng", "Tình trạng", "Số tài khoản", "Tên ngân hàng", "Mã số thuế", "Chi nhánh ngân hàng", "Số sổ bảo hiểm", "Thời gian bắt đầu", "Bậc lương", "Ngày hưởng lương", "Năm làm việc", "Chuyên ngành", "Ngạch", "Số hiệu công chức", "Nơi cấp bằng", "Khóa tài khoản", "Loại nhân viên", "Ngạch công chức", "Trình độ chính trị", "Trình độ sư phạm", "Trình độ ngoại ngữ", "Trình độ tin học", "Trình độ quản lý nhà nước", "Ngày cập nhật", "Người cập nhật" }
            //        , new int[] { 90, 90, 50, 150, 150, 70, 90, 70, 90, 90, 80, 90, 100, 90, 90, 100, 90, 90, 90, 100, 200, 200, 100, 90, 90, 150, 100, 100, 100, 110, 250, 100, 250, 100, 100, 80, 100, 90, 100, 90, 90, 100, 90, 100, 100, 100, 100, 100, 100, 100, 100, 100 });
            AppGridView.ShowField(gridViewDanhSachGiangVien, fileName, capTion, new int[] { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 });
            AppGridView.AlignHeader(gridViewDanhSachGiangVien, fileName, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewDanhSachGiangVien);
            //AppGridView.SummaryField(gridViewDanhSachGiangVien, "Ho", "Tổng cộng: {0} GV.", DevExpress.Data.SummaryItemType.Count);
            //gridViewDanhSachGiangVien.Columns["Khoa"].GroupIndex = 0;

            //gridViewDanhSachGiangVien.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            //gridViewDanhSachGiangVien.BestFitColumns();
            //gridViewDanhSachGiangVien.BestFitMaxRowCount = 5000;
            #endregion
            dateEditNgay.DateTime = DateTime.Now;
         
            InitData();
        }

        private void dateEditNgay_EditValueChanged(object sender, EventArgs e)
        {
          
        }
    }
}
