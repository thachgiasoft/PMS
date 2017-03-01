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

namespace PMS.UI.Modules.Reports
{
    public partial class ucBangThanhToanThuLaoTheoKhoa : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        #endregion
        public ucBangThanhToanThuLaoTheoKhoa()
        {
            InitializeComponent(); 
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

        private void ucBangThanhToanThuLaoTheoKhoa_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewBangThanhToan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewBangThanhToan, new string[] { "TenDonVi", "MaQuanLy", "Ho", "Ten", "TenChucVu", "DinhMucToiThieu", "GiangVienHopDong", "TenHocHam", "TenHocVi", "SoTietGiangSdh", "SoTietNckh", "SoTietGiangDayClc", "GioChuan", "GioChuanSauGiamTru", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "MaLop", "TenCoSo", "SiSo", "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet", "SoTietMonHoc", "TietThucDay", "TietQuyDoi", "TongTietQuyDoi", "SoTietTrongChuan", "DonGiaTrongChuan", "NgoaiChuan1", "NgoaiChuan2", "DonGiaNgoaiChuan", "TienNgoaiChuan", "ThanhTien" }
                                                       , new string[] { "Khoa-Đơn vị", "Mã giảng viên", "Họ", "Tên", "Kiêm nhiệm", "Phần trăm thực hiện", "Giảng viên hợp đồng", "Chức danh", "Học vị", "Giảng SĐH", "NCKH", "CLC", "Giờ chuẩn", "Giờ chuẩn sau giảm trừ", "Mã môn học", "Tên môn học", "Loại học phần", "Lớp", "Cơ sở", "Sĩ số", "Hệ số lớp đông", "Hệ số cơ sở", "Hệ số quy đồi TH sang LT", "Số tiết môn học", "Tiết thực dạy", "Tiết quy đổi", "Tổng tiết quy đổi", "Số tiết trong chuẩn", "Đơn giá trong chuẩn", "Số tiết ngoài chuẩn 1", "Số tiết ngoài chuẩn 2", "Đơn giá ngoài chuẩn", "Tiền ngoài chuẩn", "Thành tiền" }
                                                       , new int[] { 99, 85, 110, 45, 80, 110, 110, 100, 100, 80, 70, 70, 80, 120, 80, 140, 110, 90, 90, 80, 110, 110, 120, 90, 90, 90, 110, 110, 110, 110, 110, 110, 110, 110 });
            AppGridView.AlignHeader(gridViewBangThanhToan, new string[] { "TenDonVi", "MaQuanLy", "Ho", "Ten", "TenChucVu", "DinhMucToiThieu", "GiangVienHopDong", "TenHocHam", "TenHocVi", "SoTietGiangSdh", "SoTietNckh", "SoTietGiangDayClc", "GioChuan", "GioChuanSauGiamTru", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "MaLop", "TenCoSo", "SiSo", "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet", "SoTietMonHoc", "TietThucDay", "TietQuyDoi", "TongTietQuyDoi", "SoTietTrongChuan", "DonGiaTrongChuan", "NgoaiChuan1", "NgoaiChuan2", "DonGiaNgoaiChuan", "TienNgoaiChuan", "ThanhTien" }, DevExpress.Utils.HorzAlignment.Center);
            //AppGridView.ShowField(gridViewBangThanhToan, new string[] { "TenDonVi", "MaQuanLy", "Ho", "Ten", "TenChucVu", "DinhMucToiThieu", "GiangVienHopDong", "TenHocHam", "TenHocVi", "SoTietGiangSdh", "SoTietNckh", "SoTietGiangDayClc", "GioChuan", "GioChuanSauGiamTru", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "MaLop", "TenCoSo", "SiSo", "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet", "SoTietMonHoc", "TietThucDay", "TietQuyDoi", "TongTietQuyDoi", "SoTietTrongChuan", "DonGiaTrongChuan", "SoTietNgoaiChuan", "DonGiaNgoaiChuan", "TienNgoaiChuan", "ThanhTien" }
            //                                         , new string[] { "Khoa-Đơn vị", "Mã giảng viên", "Họ", "Tên", "Kiêm nhiệm", "Phần trăm thực hiện", "Giảng viên hợp đồng", "Chức danh", "Học vị", "Giảng SĐH", "NCKH", "CLC", "Giờ chuẩn", "Giờ chuẩn sau giảm trừ", "Mã môn học", "Tên môn học", "Loại học phần", "Lớp", "Cơ sở", "Sĩ số", "Hệ số lớp đông", "Hệ số cơ sở", "Hệ số quy đồi TH sang LT", "Số tiết môn học", "Tiết thực dạy", "Tiết quy đổi", "Tổng tiết quy đổi", "Số tiết trong chuẩn", "Đơn giá trong chuẩn", "Số tiết ngoài chuẩn", "Đơn giá ngoài chuẩn", "Tiền ngoài chuẩn", "Thành tiền" }
            //                                         , new int[] { 99, 85, 110, 45, 80, 110, 110, 100, 100, 80, 70, 70, 80, 120, 80, 140, 110, 90, 90, 80, 110, 110, 120, 90, 90, 90, 110, 110, 110, 110, 110, 110, 110 });
            //AppGridView.AlignHeader(gridViewBangThanhToan, new string[] { "TenDonVi", "MaQuanLy", "Ho", "Ten", "TenChucVu", "DinhMucToiThieu", "GiangVienHopDong", "TenHocHam", "TenHocVi", "SoTietGiangSdh", "SoTietNckh", "SoTietGiangDayClc", "GioChuan", "GioChuanSauGiamTru", "MaMonHoc", "TenMonHoc", "LoaiHocPhan", "MaLop", "TenCoSo", "SiSo", "HeSoLopDong", "HeSoCoSo", "HeSoQuyDoiThucHanhSangLyThuyet", "SoTietMonHoc", "TietThucDay", "TietQuyDoi", "TongTietQuyDoi", "SoTietTrongChuan", "DonGiaTrongChuan", "SoTietNgoaiChuan", "DonGiaNgoaiChuan", "TienNgoaiChuan", "ThanhTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewBangThanhToan, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);

            AppGridView.FormatDataField(gridViewBangThanhToan, "SoTietTrongChuan", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewBangThanhToan, "NgoaiChuan1", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewBangThanhToan, "NgoaiChuan2", DevExpress.Utils.FormatType.Custom, "n2");
            //AppGridView.FormatDataField(gridViewBangThanhToan, "SoTietNgoaiChuan", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewBangThanhToan, "GioChuanSauGiamTru", DevExpress.Utils.FormatType.Custom, "n2");
            AppGridView.FormatDataField(gridViewBangThanhToan, "DonGiaTrongChuan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewBangThanhToan, "DonGiaNgoaiChuan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewBangThanhToan, "TienNgoaiChuan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewBangThanhToan, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewBangThanhToan);

            gridViewBangThanhToan.GroupPanelText = "Gom nhóm bằng cách kéo tên cột thả vào đây";
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
            #region _lanChot
            AppGridLookupEdit.InitGridLookUp(cboLanChot, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChot, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChot.Properties.ValueMember = "LanChot";
            cboLanChot.Properties.DisplayMember = "LanChot";
            cboLanChot.Properties.NullText = string.Empty;
            #endregion
            #region Init Khoa-DonVi
            cboKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoaDonVi.Properties.Items.Clear();

            VList<ViewKhoa> _vListKhoaBoMon = new VList<ViewKhoa>();
            _vListKhoaBoMon = DataServices.ViewKhoa.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoa v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaKhoa, v.TenKhoa, CheckState.Unchecked, true));
            }
            cboKhoaDonVi.Properties.Items.AddRange(_list.ToArray());
            cboKhoaDonVi.Properties.SeparatorChar = ';';
            cboKhoaDonVi.CheckAll();
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
            if (cboNamHoc.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.GetByNamHocHocKyLanChotKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()), cboKhoaDonVi.EditValue.ToString());
                dt.Load(reader);
                bindingSourceBangThanhToan.DataSource = dt;
            }
            gridViewBangThanhToan.ExpandAllGroups();
        }

        void InitLanChot()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                cboLanChot.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
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
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.GetByNamHocHocKyLanChotKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()), cboKhoaDonVi.EditValue.ToString());
                dt.Load(reader);
                bindingSourceBangThanhToan.DataSource = dt;
            }
            gridViewBangThanhToan.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewBangThanhToan.FocusedRowHandle = -1;
            bindingSourceBangThanhToan.EndEdit();
            DataTable data = bindingSourceBangThanhToan.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;

            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewBangThanhToan, bindingSourceBangThanhToan);

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InBangThanhToanThuLaoTheoKhoa(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                        , PMS.Common.Globals._cauhinh.PhongToChucCanBo, PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.NguoiLapbieu
                        , vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void Excel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlBangThanhToan.ExportToXls(sf.FileName);
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
            InitLanChot();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitLanChot();
            Cursor.Current = Cursors.Default;
        }
        
    }
}
