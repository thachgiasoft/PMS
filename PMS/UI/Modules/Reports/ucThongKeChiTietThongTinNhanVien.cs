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
using PMS.Services;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeChiTietThongTinNhanVien : UserControl
    {
        #region Variable
        string groupname = UserInfo.GroupName;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        private bool user = false;
        #endregion




        public ucThongKeChiTietThongTinNhanVien()
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

        private void ucThongKeChiTietThongTinNhanVien_Load(object sender, EventArgs e)
        {

            AppGridView.InitGridView(gridViewThongKeChiTietThongTinNhanVien, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThongKeChiTietThongTinNhanVien, new string[] {"MaQuanLy","HoTen","TenBoMon","TenLoaiNhanVien","TenHocHam","TenHocVi"
                    ,"TenLoaiGiangVien","NgaySinh","EthnicName","ReligionName","TenTinhTrang","NgayKyHopDong","NgayKetThucHopDong","ThoiGianBatDau","NgayHuongLuong"
                    ,"BacLuong","NamLamViec","ChuyenNganh","TenNgach","TenTrinhDoChinhTri","TenTrinhDoSuPham","TenTrinhDoNgoaiNgu","TenTrinhDoTinHoc","TenTrinhDoQuanLyNhaNuoc"}
                , new string[] {"Mã giảng viên","Họ tên","Khoa - đơn vị","Loại nhân viên","Học hàm","Học vị","Loại giảng viên","Ngày sinh","Dân tộc","Tôn giáo"
                    ,"Tình trạng","Ngày ký hợp đồng","Ngày kết thúc","Thời gian bắt đầu","Ngày hưởng lương","Bậc lương","Năm làm việc","Chuyên ngành","Ngạch công chức"
                    ,"Trình độ chính trị","Trình độ sư phạm","Trình độ ngoại ngữ","Trình độ tin học","Trình độ quản lý nhà nước"}
                , new int[] { 90, 150, 130, 100, 80, 80, 80, 100, 70, 70, 70, 100, 100, 100, 100, 90, 80, 110, 80, 100, 100, 100, 100, 100 });
            AppGridView.AlignHeader(gridViewThongKeChiTietThongTinNhanVien, new string[] {"MaQuanLy","HoTen","TenBoMon","TenLoaiNhanVien","TenHocHam","TenHocVi"
                    ,"TenLoaiGiangVien","NgaySinh","EthnicName","ReligionName","TenTinhTrang","NgayKyHopDong","NgayKetThucHopDong","ThoiGianBatDau","NgayHuongLuong"
                    ,"BacLuong","NamLamViec","ChuyenNganh","TenNgach","TenTrinhDoChinhTri","TenTrinhDoSuPham","TenTrinhDoNgoaiNgu","TenTrinhDoTinHoc","TenTrinhDoQuanLyNhaNuoc"}, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKeChiTietThongTinNhanVien);
            AppGridView.SummaryField(gridViewThongKeChiTietThongTinNhanVien, "HoTen", "Tổng cộng: {0} GV.", DevExpress.Data.SummaryItemType.Count);

            InitData();
        }

        void InitData()
        {
            cboKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoaDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = new VList<ViewKhoaBoMon>();
            _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();

            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (groupname == v.MaBoMon)
                {
                    user = true; break;
                }
            }

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
            cboKhoaDonVi.Properties.Items.AddRange(_list.ToArray());
            cboKhoaDonVi.Properties.SeparatorChar = ';';
            cboKhoaDonVi.CheckAll();



            cboLoaiNhanVien.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiNhanVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiNhanVien.Properties.Items.Clear();

            TList<LoaiNhanVien> _tListLoaiNhanVien = DataServices.LoaiNhanVien.GetAll();
            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            foreach (LoaiNhanVien l in _tListLoaiNhanVien)
                list.Add(new CheckedListBoxItem(l.MaLoaiNhanVien, string.Format("{0} - {1}", l.MaQuanLy, l.TenLoaiNhanVien), CheckState.Unchecked, true));
            cboLoaiNhanVien.Properties.Items.AddRange(list.ToArray());
            cboLoaiNhanVien.Properties.SeparatorChar = ';';
            cboLoaiNhanVien.CheckAll();

            gridViewThongKeChiTietThongTinNhanVien.ExpandAllGroups();
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboKhoaDonVi.EditValue.ToString() != "" && cboLoaiNhanVien.EditValue.ToString() != "")
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.GiangVien.GetThongKeByMaDonViMaLoaiNhanVien(cboKhoaDonVi.EditValue.ToString(), cboLoaiNhanVien.EditValue.ToString());
                tb.Load(reader);
                bindingSourceThongKeChiTietThongTinNhanVien.DataSource = tb;
                
            }
            gridViewThongKeChiTietThongTinNhanVien.ExpandAllGroups();
            Cursor.Current = Cursors.Default;

        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
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
                    gridControlThongKeChiTietThongTinNhanVien.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



                
            }
            catch
            { }
        } 
    }
}
