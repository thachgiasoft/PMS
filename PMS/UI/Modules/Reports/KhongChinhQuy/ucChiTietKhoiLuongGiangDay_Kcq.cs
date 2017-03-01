using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.BaoCao;
using PMS.Services;

namespace PMS.UI.Modules.Reports.KhongChinhQuy
{
    public partial class ucChiTietKhoiLuongGiangDay_Kcq : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion
        public ucChiTietKhoiLuongGiangDay_Kcq()
        {
            InitializeComponent();
            TList<CauHinh> listCauHinh = DataServices.CauHinh.GetAll();
            if (listCauHinh != null)
            {
                foreach (CauHinh ch in listCauHinh)
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
            }
        }

        private void ucChiTietKhoiLuongGiangDay_Kcq_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewKhoiLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewKhoiLuong, new string[] { "MaDonVi", "TenDonVi", "MaQuanLy", "HoTen", "SoHieuCongChuc", "Loai", "MaMonHoc", "TenMonHoc", "Nhom", "MaLop", "SiSo", "TietThucDay", "TietChuNhat", "T7", "Hstp", "HeSoLopDong", "TietQuyDoi", "DonGia", "ThanhTien" }
                    , new string[] { "Mã bộ môn", "Bộ môn", "Mã giảng viên", "Họ và tên", "Mã công chức", "Loại", "Mã môn học", "Tên môn học", "Nhóm", "Mã lớp", "Sĩ số", "Tiết", "CN + Tối", "T7", "HSTP", "HSLĐ", "Tiết quy đổi", "Đơn giá", "Số tiền" }
                    , new int[] { 80, 150, 90, 145, 90, 100, 90, 150, 50, 90, 60, 60, 70, 50, 50, 50, 80, 100, 80, 80 });
            AppGridView.AlignHeader(gridViewKhoiLuong, new string[] { "MaDonVi", "TenDonVi", "MaQuanLy", "HoTen", "SoHieuCongChuc", "Loai", "MaMonHoc", "TenMonHoc", "Nhom", "MaLop", "SiSo", "TietThucDay", "TietChuNhat", "T7", "Hstp", "HeSoLopDong", "TietQuyDoi", "DonGia", "ThanhTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuong, "MaMonHoc", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewKhoiLuong);
            //gridViewKhoiLuong.Columns["TenDonVi"].GroupIndex = 0;
            //gridViewKhoiLuong.Columns["HoTen"].GroupIndex = 1;

            AppGridView.FormatDataField(gridViewKhoiLuong, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuong, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            #endregion
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            InitData();
        }
        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                InitHocKy();
            }
            InitKhoaDonVi();
            InitLoaiGiangVien();
            if (cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                InitGiangVien();
            }
        }
        void InitKhoaDonVi()
        {
            cboKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoaDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = new VList<ViewKhoaBoMon>();
            _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            //if (groupname != "Administrator")
            //{
            //    if (_maTruong == "UTE")
            //        _vListKhoa = _vListKhoa.FindAll(p => p.TenKhoa == groupname) as VList<ViewKhoaBoMon>;
            //    else
            //        _vListKhoa = _vListKhoa.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoaBoMon>;
            //}

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaBoMon, string.Format("{0} - {1}", v.MaBoMon, v.TenBoMon), CheckState.Unchecked, true));
            }
            cboKhoaDonVi.Properties.Items.AddRange(_list.ToArray());
            cboKhoaDonVi.Properties.SeparatorChar = ';';
            cboKhoaDonVi.CheckAll();
        }

        void InitLoaiGiangVien()
        {
            cboLoaiGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiGiangVien.Properties.Items.Clear();
            TList<LoaiGiangVien> _listLoaiGiangVien = DataServices.LoaiGiangVien.GetAll();
            List<CheckedListBoxItem> _listLoaiGV = new List<CheckedListBoxItem>();
            foreach (LoaiGiangVien l in _listLoaiGiangVien)
            {
                _listLoaiGV.Add(new CheckedListBoxItem(l.MaLoaiGiangVien, l.TenLoaiGiangVien, CheckState.Unchecked, true));
            }
            cboLoaiGiangVien.Properties.Items.AddRange(_listLoaiGV.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
        }

        void InitHocKy()
        {
            cboHocKy.Properties.SelectAllItemCaption = "Tất cả";
            cboHocKy.Properties.TextEditStyle = TextEditStyles.Standard;
            cboHocKy.Properties.Items.Clear();
            VList<ViewHocKy> _listHocKy = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            List<CheckedListBoxItem> _listHK = new List<CheckedListBoxItem>();
            foreach (ViewHocKy v in _listHocKy)
            {
                _listHK.Add(new CheckedListBoxItem(v.MaHocKy, v.MaHocKy, CheckState.Unchecked, true));
            }
            cboHocKy.Properties.Items.AddRange(_listHK.ToArray());
            cboHocKy.Properties.SeparatorChar = ';';
            cboHocKy.CheckAll();
        }

        void InitGiangVien()
        {
            cboGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboGiangVien.Properties.Items.Clear();
            VList<ViewGiangVien> _listGiangVien = DataServices.ViewGiangVien.GetByMaDonViMaLoaiGiangVien(cboKhoaDonVi.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString());
            List<CheckedListBoxItem> _listGV = new List<CheckedListBoxItem>();
            foreach (ViewGiangVien v in _listGiangVien)
            {
                _listGV.Add(new CheckedListBoxItem(v.MaQuanLy, string.Format("{0} - {1}", v.MaQuanLy, v.HoTen), CheckState.Unchecked, true));
            }
            cboGiangVien.Properties.Items.AddRange(_listGV.ToArray());
            cboGiangVien.Properties.SeparatorChar = ';';
            cboGiangVien.CheckAll();
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.WaitCursor;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlKhoiLuong.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewKhoiLuong.FocusedRowHandle = -1;
            bindingSourceKhoiLuong.EndEdit();
            if (dateEditHanPhanHoi.Text == "")
            {
                XtraMessageBox.Show("Vui lòng chọn thời hạn phản hồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateEditHanPhanHoi.Focus();
                return;
            }
            //AppType objLoaiBaoCao = bindingSourceDanhSachGiangVien.Current as AppType;
            //VList<ViewKcqKetQuaThanhToanThuLao> vListKetQua = bindingSourceKhoiLuong.DataSource as VList<ViewKcqKetQuaThanhToanThuLao>;

            //DataTable data = bindingSourceKhoiLuong.DataSource as DataTable;
            //DataSet ds = vListKetQua.ToDataSet(false);
            //data = ds.Tables[0];
            DataTable data = bindingSourceKhoiLuong.DataSource as DataTable;
            if (data == null)
                return;
            DataTable vListBaoCao = data;
           
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewKhoiLuong, bindingSourceKhoiLuong);

            //#region Tinh cac khoan tien
            //decimal _tongTietQuyDoi = 0, _tietGiangDay = 0, _tietDAMHLA = 0, _tietNghiaVu = 0, _donGiaTinh = 0, _soTietThieu = 0, _tienThieuTiet = 0
            //    , _soTienThucLanh = 0, _tienGiangDayDAMHLA = 0, _tienGiangDayLTTHKLK = 0;
            //foreach (DataRow row in vListBaoCao.Rows)
            //{
            //    _tongTietQuyDoi += (decimal)row["TietQuyDoi"];
            //    if (row["Loai"].ToString() == "LT" || row["Loai"].ToString() == "TH" || row["Loai"].ToString() == "KLK")
            //    {
            //        _tietGiangDay += (decimal)row["TietQuyDoi"];
            //        _tienGiangDayLTTHKLK += (decimal)row["TongThanhTien"];
            //    }
            //    else
            //    {
            //        _tietDAMHLA += (decimal)row["TietQuyDoi"];
            //        _tienGiangDayDAMHLA += (decimal)row["TongThanhTien"];
            //    }
            //}

            //double TietNghiaVu = 0;
            //ViewGiangVien gv = bindingSourceKhoiLuong.Current as ViewGiangVien;
            //DataServices.GiangVien.GetSoTietNghiaVuByMaQuanLyNamHocHocKy(gv.MaQuanLy, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref TietNghiaVu);
            //_tietNghiaVu = (decimal)TietNghiaVu / 2;
            //double DonGia = 0;
            ////DataServices.DonGia.GetByMaLoaiGiangVienMaHocHamMaHocViHocKy((int)gv.MaLoaiGiangVien, (int)gv.MaHocHam, (int)gv.MaHocVi, cboHocKy.EditValue.ToString(), ref DonGia);
            //DataServices.DonGia.GetByMaQuanLyNamHocHocKy(gv.MaQuanLy, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref DonGia);
            //_donGiaTinh = (int)DonGia;
            //if (_tietNghiaVu > _tietGiangDay)
            //{
            //    _soTietThieu = _tietNghiaVu - _tietGiangDay;
            //    _tienThieuTiet = _soTietThieu * _donGiaTinh;
            //    //_soTienThucLanh = _tietDAMHLA * _donGiaTinh;
            //    _soTienThucLanh = _tienGiangDayDAMHLA;
            //}
            //else
            //{
            //    _soTietThieu = 0;
            //    _tienThieuTiet = 0;
            //    //_soTienThucLanh = ((_tietGiangDay - _tietNghiaVu) + _tietDAMHLA) * _donGiaTinh;
            //    _soTienThucLanh = (_tienGiangDayLTTHKLK + _tienGiangDayDAMHLA) - (_tietNghiaVu * _donGiaTinh);
            //}
            
            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
               
                using (frmBaoCao frm = new frmBaoCao())
                {
                    //frm.InLietKeKhoiLuongGiangDay(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), PMS.Common.Globals._cauhinh.TenTruong, gv.MaQuanLy, gv.HoTen, gv.MaDonVi, gv.TenDonVi, gv.TenHocHam, gv.TenHocVi, gv.GioiTinh, dateEditThoiHanPhanHoi.Text, _tongTietQuyDoi, _tietGiangDay, _tietDAMHLA, (decimal)_tietNghiaVu, _donGiaTinh, _soTietThieu, _tienThieuTiet, _soTienThucLanh, PMS.Common.Globals._cauhinh.NguoiLapbieu, vListBaoCao);
                    frm.InChiTietKhoiLuongGiangDay(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), PMS.Common.Globals._cauhinh.TenTruong, "", "", "", "", "", "", "", dateEditHanPhanHoi.Text, 0, 0, 0, 0, 0, 0, 0, 0, PMS.Common.Globals._cauhinh.NguoiLapbieu, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn năm học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNamHoc.Focus();
                return;
            }
            if (cboHocKy.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn năm học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboHocKy.Focus();
                return;
            }
            if (cboGiangVien.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGiangVien.Focus();
                return;
            }
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboGiangVien.EditValue != null)
            {
                //bindingSourceKhoiLuong.DataSource = DataServices.ViewKcqKetQuaThanhToanThuLao.GetByMaGiangVienNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboGiangVien.EditValue.ToString());
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.ViewKcqKetQuaThanhToanThuLao.GetByMaGiangVienNamHocHocKyReader(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboGiangVien.EditValue.ToString());
                tb.Load(reader);
                bindingSourceKhoiLuong.DataSource = tb;
            }
            gridViewKhoiLuong.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }
        #endregion
        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                InitHocKy();
            Cursor.Current = Cursors.Default;
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                InitGiangVien();
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboLoaiGiangVien_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboKhoaDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                InitGiangVien();
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion
    }
}
