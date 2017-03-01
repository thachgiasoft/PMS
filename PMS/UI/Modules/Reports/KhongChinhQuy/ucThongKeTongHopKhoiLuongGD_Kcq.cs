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
using PMS.BLL;
using PMS.UI.Forms.BaoCao;
using PMS.Services;


namespace PMS.UI.Modules.Reports.KhongChinhQuy
{
    public partial class ucThongKeTongHopKhoiLuongGD_Kcq : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        string groupname = UserInfo.GroupName;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        int lanchot = 0;
        #endregion

        public ucThongKeTongHopKhoiLuongGD_Kcq()
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

        private void ucThongKeTongHopKhoiLuongGD_Kcq_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewTongHopKhoiLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewTongHopKhoiLuong, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenKhoa", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "Nhom", "MaLop", "SiSo", "TietThucDay", "HeSoHocKy", "HeSoLopDong", "MaDiaDiem", "TenDiaDiem", "DonGia", "TienXeDiaDiem", "DonGiaDiaDiem", "HeSoDiaDiem", "SoTinChi", "TietQuyDoi", "ThanhTien" }
                    , new string[] { "Mã giảng viên","Họ và tên","Học hàm","Học vị","Loại giảng viên","Bộ môn","Mã môn học","Tên môn học","Loại","Nhóm","Mã lớp","Sĩ số","Số tiết","Hệ số học kỳ","Hệ số lớp đông","Mã địa điểm","Tên địa điểm","Đơn giá học vị","Tiền xe địa điểm","Đơn giá địa điểm","Hệ số địa điểm","Số tín chỉ","Tiết quy đổi","Thành tiền"}
                    , new int[] {90,130,100,100,100,150,90,120,100,80,90,80,80,100,100,90,150,100,100,100,100,90,100,130});
            AppGridView.AlignHeader(gridViewTongHopKhoiLuong, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenKhoa", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "Nhom", "MaLop", "SiSo", "TietThucDay", "HeSoHocKy", "HeSoLopDong", "MaDiaDiem", "TenDiaDiem", "DonGia", "TienXeDiaDiem", "DonGiaDiaDiem", "HeSoDiaDiem", "SoTinChi", "TietQuyDoi", "ThanhTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewTongHopKhoiLuong, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewTongHopKhoiLuong);
            AppGridView.FormatDataField(gridViewTongHopKhoiLuong, "SiSo", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongHopKhoiLuong, "TietThucDay", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongHopKhoiLuong, "HeSoLopDong", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongHopKhoiLuong, "HeSoHocKy", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewTongHopKhoiLuong, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongHopKhoiLuong, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongHopKhoiLuong, "DonGiaDiaDiem", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongHopKhoiLuong, "TienXeDiaDiem", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewTongHopKhoiLuong, "TietQuyDoi", DevExpress.Utils.FormatType.Custom, "n2");
            //gridViewThongKe.Columns["TenDonVi"].GroupIndex = 0;
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

            #region _lanChot
            AppGridLookupEdit.InitGridLookUp(cboLanChot, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChot, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChot.Properties.ValueMember = "LanChot";
            cboLanChot.Properties.DisplayMember = "LanChot";
            cboLanChot.Properties.NullText = string.Empty;
            #endregion

            #region Khoa-DonVi
            InitKhoaDonVi();
            #endregion

            #region LoaiGiangVien
            InitLoaiGiangVien();
            #endregion

            InitData();
            
        }


        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoa.EditValue != null && cboLoaiGiangVien.EditValue != null && cboLanChot.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.ViewKcqKetQuaThanhToanThuLao.GetByNamHocHocKyMaDonViMaLoaiGiangVienLanChot2(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoa.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), cboLanChot.EditValue.ToString());
                dt.Load(reader);
                bindingSourceTongHopKhoiLuong.DataSource = dt;
            }
            gridViewTongHopKhoiLuong.ExpandAllGroups();
        }

        void InitLanChot()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                cboLanChot.DataBindings.Clear();
                DataServices.KcqKetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                DataTable tblLanChot = new DataTable();
                tblLanChot.Columns.Add("LanChot");
                if (lanchot > 0)
                {
                    for (int i = lanchot; i >= 1; i--)
                    {
                        tblLanChot.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChot.DataSource = tblLanChot;
                cboLanChot.DataBindings.Add("EditValue", bindingSourceLanChot, "LanChot", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }

        void InitKhoaDonVi()
        {
            cboKhoa.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoa.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoa.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon =  DataServices.ViewKhoaBoMon.GetAll();
            if (groupname != "AdminKhongChinhQuy")
            {
                if (_maTruong == "UTE")
                    _vListKhoaBoMon = _vListKhoaBoMon.FindAll(p => p.TenKhoa == groupname) as VList<ViewKhoaBoMon>;
                else
                    _vListKhoaBoMon = _vListKhoaBoMon.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoaBoMon>;
            }

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaBoMon, string.Format("{0} - {1}", v.MaBoMon, v.TenBoMon), CheckState.Unchecked, true));
            }
            cboKhoa.Properties.Items.AddRange(_list.ToArray());
            cboKhoa.Properties.SeparatorChar = ';';
            cboKhoa.CheckAll();
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
                _listLoaiGV.Add(new CheckedListBoxItem(l.MaLoaiGiangVien, string.Format("{0}", l.TenLoaiGiangVien), CheckState.Unchecked, true));
            }
            cboLoaiGiangVien.Properties.Items.AddRange(_listLoaiGV.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
        }
        #endregion

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboLanChot.EditValue == null)
                XtraMessageBox.Show("Vui lòng chọn lần chốt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            InitData();
            Cursor.Current = Cursors.WaitCursor;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            InitLoaiGiangVien();
            InitKhoaDonVi();
            cboLanChot.EditValue = null;
            bindingSourceTongHopKhoiLuong.DataSource = null;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewTongHopKhoiLuong.FocusedRowHandle = -1;
            bindingSourceTongHopKhoiLuong.EndEdit();
            DataTable data = bindingSourceTongHopKhoiLuong.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewTongHopKhoiLuong, bindingSourceTongHopKhoiLuong);


            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InTongHopKhoiLuongGiangDayTheoNam(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                        , layoutControlItem4.Text, cboLanChot.EditValue.ToString(), PMS.Common.Globals._cauhinh.NguoiLapbieu
                        , PMS.Common.Globals._cauhinh.PhongDaoTao, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
