using System;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities.Validation;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Modules.Reports
{
    public partial class ucLietKeKhoiLuongGiangDay : XtraUserControl
    {
        #region variables
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion

        public ucLietKeKhoiLuongGiangDay()
        {
            InitializeComponent();
        }

        private void ucLietKeKhoiLuongGiangDay_Load(object sender, EventArgs e)
        {
            #region Init GridView ThanhToanThuLao
            AppGridView.InitGridView(gridViewThanhToanThuLao, true, true, GridMultiSelectMode.CellSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewThanhToanThuLao, new string[] { "TenLoaiKhoiLuong", "MaLoaiKhoiLuong", "MaMonHoc", "TenMonHoc", "MaNhom", "MaLop", "SiSoLop", "TrongGio", "ChatLuongCao", "NgoaiGio", "HeSoThanhPhan", "HeSoLopDong", "DonGia", "ThanhTien", "TietQuyDoi" },
                new string[] { "Loại", "Mã KL", "Mã MH", "Tên MH", "Nhóm", "Mã lớp", "Sĩ số", "Trong giờ", "CLC", "Ngoài giờ", "HS TP", "HS LĐ", "Đơn giá", "Số tiền", "Tiết QĐ" },
                new int[] { 150, 80, 80, 300, 80, 80, 80, 80, 80, 80, 80, 80, 80, 100, 80 });
            AppGridView.MergeCell(gridViewThanhToanThuLao, new string[] { "MaLoaiKhoiLuong", "MaMonHoc", "TenMonHoc", "MaNhom", "MaLop", "SiSoLop", "TrongGio", "ChatLuongCao", "NgoaiGio", "HeSoThanhPhan", "HeSoLopDong", "DonGia", "ThanhTien", "TietQuyDoi" });
            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.RegisterControlField(gridViewThanhToanThuLao, "ThanhTien", repositoryItemSpinEditTienGiangDay);
            AppGridView.SummaryField(gridViewThanhToanThuLao, "TenLoaiKhoiLuong", "Tổng = {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewThanhToanThuLao);
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            #endregion

            #region DonVi
            AppGridLookupEdit.InitGridLookUp(cboDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboDonVi, 600, 300);
            AppGridLookupEdit.ShowField(cboDonVi, new string[] { "MaKhoa", "TenKhoa","MaBoMon","TenBoMon","MaQuanLy", "HoTen" },
                new string[] { "Mã khoa", "Tên khoa","Mã bộ môn","Tên bộ môn", "Mã GV", "Họ tên" },
                new int[] { 80, 200,80,200, 80, 200 });
            cboDonVi.Properties.DisplayMember = "HoTen";
            cboDonVi.Properties.ValueMember = "MaGiangVien";
            cboDonVi.Properties.NullText = string.Empty;
            #endregion

            #region Init Data Source
            InitData();
            #endregion

            #region Init CauHinh
            TList<CauHinh> listCauHinh = DataServices.CauHinh.GetAll() as TList<CauHinh>;
            if (listCauHinh != null)
            {
                foreach (CauHinh ch in listCauHinh)
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
            }
            #endregion
        }

        private void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            cboNamHoc.DataBindings.Clear();
            cboNamHoc.DataBindings.Add("EditValue", bindingSourceNamHoc, "NamHoc", true, DataSourceUpdateMode.OnPropertyChanged);

            ViewNamHoc objNamHoc = bindingSourceNamHoc.Current as ViewNamHoc;
            if (objNamHoc != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(objNamHoc.NamHoc);
                cboHocKy.DataBindings.Clear();
                cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
            }

            bindingSourceDonVi.DataSource = DataServices.ViewGiangVienKhoa.GetAll();
            cboDonVi.DataBindings.Clear();
            cboDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaGiangVien", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ViewHocKy vHocKy = bindingSourceHocKy.Current as ViewHocKy;
            if (vHocKy == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ViewGiangVienKhoa vDonVi = bindingSourceDonVi.Current as ViewGiangVienKhoa;
            if (vDonVi == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn đơn vị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bindingSourceThanhToanThuLao.DataSource = DataServices.ViewChiTietKhoiLuong.GetByNamHocHocKyMaDonViMaGiangVien(vHocKy.NamHoc, vHocKy.MaHocKy, vDonVi.MaBoMon, vDonVi.MaGiangVien);
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                ViewNamHoc objNamHoc = cboNamHoc.Properties.GetRowByKeyValue(e.Value) as ViewNamHoc;
                if (objNamHoc != null)
                {
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(objNamHoc.NamHoc);
                    cboHocKy.DataBindings.Clear();
                    cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                ViewHocKy vHocKy = bindingSourceHocKy.Current as ViewHocKy;
                if (vHocKy == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ViewGiangVienKhoa vDonVi = bindingSourceDonVi.Current as ViewGiangVienKhoa;
                if (vDonVi == null)
                {
                    XtraMessageBox.Show("Bạn chưa chọn đơn vị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Init Report.
                VList<ViewChiTietKhoiLuong> vList = bindingSourceThanhToanThuLao.DataSource as VList<ViewChiTietKhoiLuong>;
                if (vList == null)
                    return;
                if (vList.Count != 0)
                {
                    frmBaoCao frm = new frmBaoCao();
                    GiangVien giangVien = DataServices.GiangVien.GetByMaGiangVien(vDonVi.MaGiangVien);
                    HocHam hocHam = DataServices.HocHam.GetByMaHocHam(Convert.ToInt32(giangVien.MaHocHam));
                    string maHocHam = "";
                    if (hocHam != null)
                        maHocHam = hocHam.MaQuanLy;
                    int soTietNghiaVu = 0;
                    int soTietDoAn = 0;
                    int tongTietQD = 0;
                    foreach (ViewChiTietKhoiLuong vChiTiet in vList)
                    {
                        tongTietQD += Convert.ToInt32(vChiTiet.TietQuyDoi);
                        if(vChiTiet.TietNghiaVu != null)
                            soTietNghiaVu = Convert.ToInt32(vChiTiet.TietNghiaVu);
                        if (vChiTiet.PhanLoai == "DA")
                            soTietDoAn += Convert.ToInt32(vChiTiet.TietQuyDoi);
                    }
                    double _soTienNghiaVu = Convert.ToDouble(soTietNghiaVu * vList[0].DonGia);
                    double _soTienDAMH = Convert.ToDouble(soTietDoAn * vList[0].DonGia);
                    double _soTienGiangDay = Convert.ToDouble((tongTietQD - soTietNghiaVu) * vList[0].DonGia);
                    double _soTienThucLanh = _soTienGiangDay + _soTienDAMH;
                    string _soTiengBangChu =  PMS.Common.Globals.DocTien(Convert.ToDecimal(_soTienThucLanh));

                    if (PMS.Common.Globals._cauhinh != null)
                    {
                        frm.InBangLietKeKhoiLuongGiangDay(PMS.Common.Globals._cauhinh.TenTruong.ToUpper(), PMS.Common.Globals._cauhinh.NguoiLapbieu, vHocKy.NamHoc, vHocKy.MaHocKy, string.Format("{0} ({1})", vDonVi.TenBoMon, vDonVi.MaDonVi), string.Format("{0} ({1}) - Mã KL: {2}", vDonVi.HoTen, vDonVi.MaQuanLy, maHocHam), maHocHam, _soTienNghiaVu, _soTienGiangDay, _soTienDAMH, _soTienThucLanh, _soTiengBangChu, soTietNghiaVu, vList);
                        frm.ShowDialog();
                    }
                    else
                    {
                        XtraMessageBox.Show("Chưa cấu hình tên trường và các thông tin phòng ban liên quan", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }

                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Lỗi trong quá trình thống kê. Vui lòng liên hệ người phụ trách\n" +ex.Message, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}