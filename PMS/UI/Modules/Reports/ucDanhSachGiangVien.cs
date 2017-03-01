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
    public partial class ucDanhSachGiangVien : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        string groupname = UserInfo.GroupName;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        private bool user = false;
        #endregion

        #region Event Form
        public ucDanhSachGiangVien()
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

        private void ucDanhSachGiangVien_Load(object sender, EventArgs e)
        {
            #region InitGridView 
            AppGridView.InitGridView(gridViewDanhSachGiangVien, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewDanhSachGiangVien, new string[] { "MaQuanLy", "Ho", "Ten", "Khoa", "TenDonVi", "MaHocHam", "TenHocHam", "MaHocVi", "TenHocVi", "TenLoaiGiangVien", "GioiTinh", "NgaySinh", "NoiSinh", "Cmnd", "DiaChi", "DienThoai", "SoDiDong", "Email", "SoHieuCongChuc", "SoTaiKhoan", "MaSoThue", "TenNganHang", "Ngach", "TenTinhTrang", "ChuyenNganh" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Khoa", "Bộ môn", "Mã học hàm", "Học hàm", "Mã học vị", "Học vị", "Loại giảng viên", "Giới tính", "Ngày Sinh", "Nơi sinh", "CMND", "Địa chỉ", "Số điện thoại", "Di động", "Email", "Số hiệu công chức", "Số tài khoản", "Mã số thuế", "Ngân hàng", "Ngạch","Tình trạng", "Chuyên ngành" }
                    , new int[] { 90, 120, 70, 130, 150, 80, 150, 80, 150, 100, 70, 90, 100, 100, 150, 100, 100, 100, 120, 90, 90, 150, 90, 100, 100 });
            AppGridView.AlignHeader(gridViewDanhSachGiangVien, new string[] { "MaQuanLy", "SoHieuCongChuc", "Ho", "Ten", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "GioiTinh", "NgaySinh", "NoiSinh", "Cmnd", "DiaChi", "DienThoai", "SoDiDong", "Email", "Khoa", "SoTaiKhoan", "MaSoThue", "TenNganHang", "Ngach", "TenTinhTrang", "ChuyenNganh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewDanhSachGiangVien);
            AppGridView.SummaryField(gridViewDanhSachGiangVien, "Ho", "Tổng cộng: {0} GV.", DevExpress.Data.SummaryItemType.Count);
            //gridViewDanhSachGiangVien.Columns["Khoa"].GroupIndex = 0;
            AppGridView.FixedField(gridViewDanhSachGiangVien, new string[] { "MaQuanLy", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            #endregion

            InitData();
        }
        #endregion

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

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewDanhSachGiangVien.FocusedRowHandle = -1;
            bindingSourceDanhSachGiangVien.EndEdit();
            AppType objLoaiBaoCao = bindingSourceDanhSachGiangVien.Current as AppType;
            DataTable data = bindingSourceDanhSachGiangVien.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewDanhSachGiangVien, bindingSourceDanhSachGiangVien);

            string khoa = "";
            if (_maTruong == "UTE")
            {
                khoa = groupname;
            }
            else
            {
                VList<ViewKhoa> _vKhoa = DataServices.ViewKhoa.GetAll();
                try
                {
                    khoa = _vKhoa.Find(p => p.MaKhoa == groupname).TenKhoa;
                }
                catch
                {
                    khoa = "";
                }
            }
            if (groupname == "Administrator"  || groupname == "User")
                khoa = "";


            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InDanhSachGiangVien(_maTruong, PMS.Common.Globals._cauhinh.TenTruong, khoa, PMS.Common.Globals._cauhinh.NguoiLapbieu, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboKhoa.EditValue.ToString() != "" && cboLoaiGiangVien.EditValue.ToString() != "" && cboTinhTrang.EditValue.ToString() != "")
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.GiangVien.GetByMaDonViLoaiGiangVien(cboKhoa.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), cboTinhTrang.EditValue.ToString());
                tb.Load(reader);
                bindingSourceDanhSachGiangVien.DataSource = tb;
            }
            gridViewDanhSachGiangVien.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }
    }
}
