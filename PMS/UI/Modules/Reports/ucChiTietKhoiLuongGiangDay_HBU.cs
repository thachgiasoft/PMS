using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Modules.Reports
{
    public partial class ucChiTietKhoiLuongGiangDay_HBU : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion

        public ucChiTietKhoiLuongGiangDay_HBU()
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

        private void ucChiTietKhoiLuongGiangDay_HBU_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewKhoiLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewKhoiLuong, new string[] { "MaDonVi", "TenDonVi", "MaQuanLy", "HoTen", "Loai", "MaMonHoc", "TenMonHoc", "Nhom", "MaLop", "SiSo", "TietThucDay", "HeSoNgoaiGio", "HeSoLopDong", "HeSoChucDanhChuyenMon", "HeSoKhoiNganh", "HeSoBacDaoTao", "HeSoNgonNgu", "TietQuyDoi", "DonGia", "ThanhTien", "Thue", "ThucLanh" }
                    , new string[] { "Mã bộ môn", "Bộ môn", "Mã giảng viên", "Họ và tên", "Loại", "Mã môn học", "Tên môn học", "Nhóm", "Mã lớp", "Sĩ số", "Tiết", "HS đặc biệt", "HS lớp đông", "HS chức danh", "HS khối ngành", "HS bậc đào tạo", "HS ngôn ngữ", "Tiết quy đổi", "Đơn giá", "Số tiền", "Thuế TNCN", "Thực lãnh" }
                    , new int[] { 80, 150, 90, 145, 100, 90, 150, 50, 90, 70, 50, 50, 50, 60, 60, 60, 60, 80, 100, 80, 80, 80, 90 });
            AppGridView.AlignHeader(gridViewKhoiLuong, new string[] { "MaDonVi", "TenDonVi", "MaQuanLy", "HoTen", "Loai", "MaMonHoc", "TenMonHoc", "Nhom", "MaLop", "SiSo", "TietThucDay", "HeSoNgoaiGio", "HeSoLopDong", "HeSoChucDanhChuyenMon", "HeSoKhoiNganh", "HeSoBacDaoTao", "HeSoNgonNgu", "TietQuyDoi", "DonGia", "ThanhTien", "Thue", "ThucLanh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewKhoiLuong, "MaMonHoc", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewKhoiLuong);
            //gridViewKhoiLuong.Columns["TenDonVi"].GroupIndex = 0;
            //gridViewKhoiLuong.Columns["HoTen"].GroupIndex = 1;
            PMS.Common.Globals.WordWrapHeader(gridViewKhoiLuong, 40);
            AppGridView.FormatDataField(gridViewKhoiLuong, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuong, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuong, "Thue", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewKhoiLuong, "ThucLanh", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FixedField(gridViewKhoiLuong, new string[] { "MaQuanLy", "HoTen" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            AppGridView.HideField(gridViewKhoiLuong, new string[] { "DonGia", "ThanhTien", "Thue", "ThucLanh" });
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
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
            
            DataTable data = bindingSourceKhoiLuong.DataSource as DataTable;
            if (data == null)
                return;
            DataTable vListBaoCao = data;
            
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewKhoiLuong, bindingSourceKhoiLuong);

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {

                using (frmBaoCao frm = new frmBaoCao())
                {
                    //frm.InLietKeKhoiLuongGiangDay(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), PMS.Common.Globals._cauhinh.TenTruong, gv.MaQuanLy, gv.HoTen, gv.MaDonVi, gv.TenDonVi, gv.TenHocHam, gv.TenHocVi, gv.GioiTinh, DateTime.Now.ToString(), _tongTietQuyDoi, _tietGiangDay, _tietDAMHLA, (decimal)_tietNghiaVu, _donGiaTinh, _soTietThieu, _tienThieuTiet, _soTienThucLanh, PMS.Common.Globals._cauhinh.NguoiLapbieu, vListBaoCao);
                    frm.InChiTietKhoiLuongGiangDay_HBU(DateTime.Now, vListBaoCao);
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
                //bindingSourceKhoiLuong.DataSource = DataServices.ViewKetQuaThanhToanThuLao.GetByMaGiangVienNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboGiangVien.EditValue.ToString());
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.GetKhoiLuongChiTietHbu(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboGiangVien.EditValue.ToString());
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
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
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

        }
        #endregion

    }
}