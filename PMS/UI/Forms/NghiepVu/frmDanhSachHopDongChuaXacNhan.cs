using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.ChucNangCon;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmDanhSachHopDongChuaXacNhan : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;

                btnXoaHopDong.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoaHopDong.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoaHopDong.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        //string _maTruong;
        string _groupUser = UserInfo.GroupName;
        bool _userRole = false;
        VList<ViewKhoaBoMon> _listKhoaBoMon = new VList<ViewKhoaBoMon>();
        VList<ViewGiangVien> _listGiangVien = new VList<ViewGiangVien>();
        DanhSachHopDongThinhGiang _objHopDong = new DanhSachHopDongThinhGiang();
        VList<ViewLopHocPhan> _listLopHocPhan = new VList<ViewLopHocPhan>();
        string _heSoThucHanh;
        DateTime _ngayIn;
        string _nguoiDaiDien, _tenChucVu;
        VList<ViewDanhSachHopDongThinhGiang> _listHopDong;
        #endregion

        #region Event Form
        public frmDanhSachHopDongChuaXacNhan()
        {
            InitializeComponent();
        }

        private void frmDanhSachHopDongChuaXacNhan_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewDanhSachHopDong, true, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false);
            AppGridView.ShowField(gridViewDanhSachHopDong, new string[] { "SoHopDong", "HoTen", "TenMonHoc", "MaLop", "NamHoc", "HocKy", "TenDonVi", "NgayBatDau", "NgayKetThuc", "TongSoTiet", "DonGia", "TongGiaTriHopDong", "Thue", "GiaTriHopDongConLai" }
                    , new string[] { "Số hợp đồng", "Giảng viên", "Môn học", "Lớp", "Năm học", "Học kỳ", "Khoa", "Ngày BĐ", "Ngày KT", "Tổng số tiết", "Đơn giá", "Tổng giá trị HĐ", "Thuế", "Giá trị HĐ còn lại" }
                    , new int[] { 70, 150, 150, 130, 60, 60, 140, 70, 70, 80, 70, 90, 70, 90 });
            AppGridView.AlignHeader(gridViewDanhSachHopDong, new string[] { "SoHopDong", "HoTen", "TenMonHoc", "MaLop", "NamHoc", "HocKy", "TenDonVi", "NgayBatDau", "NgayKetThuc", "TongSoTiet", "DonGia", "TongGiaTriHopDong", "Thue", "GiaTriHopDongConLai" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewDanhSachHopDong);

            AppGridView.FormatDataField(gridViewDanhSachHopDong, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewDanhSachHopDong, "TongGiaTriHopDong", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewDanhSachHopDong, "Thue", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewDanhSachHopDong, "GiaTriHopDongConLai", DevExpress.Utils.FormatType.Custom, "n0");
            #endregion

            #region DonVi - KhoaBoMon
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboKhoaDonVi, 370, 650);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã bộ môn", "Tên bộ môn" }, new int[] { 90, 250 });
            cboKhoaDonVi.Properties.DisplayMember = "TenBoMon";
            cboKhoaDonVi.Properties.ValueMember = "MaBoMon";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion

            #region LopHocPhan
            AppGridLookupEdit.InitGridLookUp(cboLopHocPhan, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboLopHocPhan, 710, 650);
            AppGridLookupEdit.ShowField(cboLopHocPhan, new string[] { "TenLop", "TenLopHocPhan", "TenMonHoc", "SoTinChi", "TenLoaiHocPhan", "NamHoc", "HocKy" }, new string[] { "Tên lớp", "Tên lớp học phần", "Tên môn học", "STC", "Loại học phần", "Năm học", "Học kỳ" }, new int[] { 170, 100, 150, 50, 80, 60, 60 });
            cboLopHocPhan.Properties.DisplayMember = "TenLop";
            cboLopHocPhan.Properties.ValueMember = "MaLopHocPhan";
            cboLopHocPhan.Properties.NullText = string.Empty;
            #endregion

            #region Năm học
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboNamHoc, 200, 100);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            cboNamHoc.Properties.NullText = string.Empty;
            #endregion

            #region Học kỳ
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboHocKy, 300, 100);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            cboHocKy.Properties.NullText = string.Empty;
            #endregion

            #region MonHoc
            AppGridLookupEdit.InitGridLookUp(cboMonHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboMonHoc, 600, 650);
            AppGridLookupEdit.ShowField(cboMonHoc, new string[] { "MaMonHoc", "TenMonHoc", "SoTinChi", "TenBoMon" }, new string[] { "Mã môn học", "Tên môn học", "STC", "Khoa - Đơn vị" }, new int[] { 80, 230, 50, 210 });
            cboMonHoc.Properties.DisplayMember = "TenMonHoc";
            cboMonHoc.Properties.ValueMember = "MaMonHoc";
            cboMonHoc.Properties.NullText = string.Empty;
            #endregion

            #region GiangVien
            AppGridLookupEdit.InitGridLookUp(cboTenGiangVien, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboTenGiangVien, 490, 650);
            AppGridLookupEdit.ShowField(cboTenGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Khoa - Đơn vị" }, new int[] { 80, 170, 170 });
            cboTenGiangVien.Properties.DisplayMember = "HoTen";
            cboTenGiangVien.Properties.ValueMember = "MaGiangVien";
            cboTenGiangVien.Properties.NullText = string.Empty;
            #endregion

            #region HocHam
            AppGridLookupEdit.InitGridLookUp(cboHocHam, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboHocHam, 300, 350);
            AppGridLookupEdit.ShowField(cboHocHam, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" }, new int[] { 90, 180 });
            cboHocHam.Properties.DisplayMember = "TenHocHam";
            cboHocHam.Properties.ValueMember = "MaHocHam";
            cboHocHam.Properties.NullText = string.Empty;
            #endregion

            #region HocVi
            AppGridLookupEdit.InitGridLookUp(cboHocVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboHocVi, 300, 350);
            AppGridLookupEdit.ShowField(cboHocVi, new string[] { "MaQuanLy", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" }, new int[] { 80, 180 });
            cboHocVi.Properties.DisplayMember = "TenHocVi";
            cboHocVi.Properties.ValueMember = "MaHocVi";
            cboHocVi.Properties.NullText = string.Empty;
            #endregion

            #region Tien Te
            AppGridLookupEdit.InitGridLookUp(cboTienTe, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboTienTe, 250, 300);
            AppGridLookupEdit.ShowField(cboTienTe, new string[] { "DonViTienTe", "TenTienTe" }, new string[] { "Đơn vị tiền tệ", "Tên tiền tệ" }, new int[] { 80, 150 });
            cboTienTe.Properties.DisplayMember = "DonViTienTe";
            cboTienTe.Properties.ValueMember = "DonViTienTe";
            cboTienTe.Properties.NullText = string.Empty;
            #endregion
            
            GetKhoaBoMonByNhomQuyen();
            PhanQuyenControl();
            InitCboTienTe();
            InitData();
        }
        #endregion

        #region Event Grid
        private void gridViewDanhSachHopDong_Click(object sender, EventArgs e)
        {
            ViewDanhSachHopDongThinhGiang _vHopDong = bindingSourceDanhSachHopDong.Current as ViewDanhSachHopDongThinhGiang;
            if (_vHopDong != null)
            {
                DanhSachHopDongThinhGiang _hopDong = DataServices.DanhSachHopDongThinhGiang.GetById(_vHopDong.Id);
                _objHopDong = _hopDong;
                bindingSourceHopDong.DataSource = _objHopDong;
                txtChuyenNganh.Text = _vHopDong.ChuyenNganh;
                txtCoQuanCongTac.Text = _vHopDong.CoQuanCongTac;
            }
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            if (_userRole)
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    _listLopHocPhan = DataServices.ViewLopHocPhan.GetByNamHocHocKyKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _groupUser);
                }
                bindingSourceMonHoc.DataSource = DataServices.ViewMonHocKhoa.GetByMaDonVi(_groupUser);
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(_groupUser);
            }
            else
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    _listLopHocPhan = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
                bindingSourceMonHoc.DataSource = DataServices.ViewMonHocKhoa.GetAll();
                _listGiangVien = DataServices.ViewGiangVien.GetAll();
            }

            bindingSourceGiangVien.DataSource = _listGiangVien;

            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();
            bindingSourceLopHocPhan.DataSource = _listLopHocPhan;
            dateEditNgayBatDau.DateTime = DateTime.Now;

            LoadHopDong();
        }

        void GetKhoaBoMonByNhomQuyen()
        {
            _listKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            foreach (ViewKhoaBoMon v in _listKhoaBoMon)
            {
                if (v.MaBoMon == _groupUser)
                {
                    _userRole = true;
                    break;
                }
                else
                {
                    _userRole = false;
                }
            }

            if (_userRole)
            {
                _listKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupUser);
            }
            bindingSourceKhoaDonVi.DataSource = _listKhoaBoMon;
        }

        void RefreshForm()
        {
            _objHopDong = new DanhSachHopDongThinhGiang();
            _objHopDong.NgayBatDau = DateTime.Now;
            //Lấy số hợp đồng tự động
            string _soHopDongMoi = "";
            DataServices.DanhSachHopDongThinhGiang.GetSoHopDong(ref _soHopDongMoi);
            _objHopDong.SoHopDong = _soHopDongMoi;

            if (_userRole)
                _objHopDong.MaDonVi = _groupUser;
            //else
            _objHopDong.DonViTienTe = "VNĐ";

            bindingSourceHopDong.DataSource = _objHopDong;
        }

        void PhanQuyenControl()
        {
            if (_userRole)
            {
                spinEditHeSoQuyDoi.Enabled = false;
                //spinEditSoNhomTH.Enabled = false;
                //spinEditSoTietLTTuan.Enabled = false;
                //spinEditSoTietHTTuan.Enabled = false;
                //spinEditTSoTietTuan.Enabled = false;
                spinEditHeSoLopDong.Enabled = false;
                //spinEditSiSo.Enabled = false;
                //spinEditTongSoTiet.Enabled = false;
                spinEditDonGiaChiTiet.Enabled = false;
                spinEditTongGiaTriHD.Enabled = false;
                spinEditGiaTriHDConLai.Enabled = false;
                spinEditThue.Enabled = false;
                richTextBoxGhiChu.Enabled = false;
                cboTienTe.Enabled = false;
                checkEditXacNhanHopDong.Enabled = false;
                btnHeSoQuyDoi.Enabled = false;
                btnDonGiaChiTiet.Enabled = false;
            }
        }

        void InitCboTienTe()
        {
            //cboTienTe.DataBindings.Clear();
            DataTable _tienTe = new DataTable();
            _tienTe.Columns.Add(new DataColumn("DonViTienTe", typeof(System.String)));
            _tienTe.Columns.Add(new DataColumn("TenTienTe", typeof(System.String)));
            DataRow rVND = _tienTe.NewRow();
            rVND["DonViTienTe"] = "VNĐ";
            rVND["TenTienTe"] = "Việt Nam Đồng";
            DataRow rUSD = _tienTe.NewRow();
            rUSD["DonViTienTe"] = "USD";
            rUSD["TenTienTe"] = "Đô la Mỹ";
            _tienTe.Rows.Add(rVND);
            _tienTe.Rows.Add(rUSD);
            bindingSourceDonViTienTe.DataSource = _tienTe;
            //cboTienTe.DataBindings.Add("EditValue", bindingSourceDonViTienTe, "DonViTienTe", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        void LoadHopDong()
        {
            if (_userRole)
            {
                if (radioGroupHopDong.SelectedIndex == 0)
                {
                    _listHopDong = DataServices.ViewDanhSachHopDongThinhGiang.GetHopDongChuaXacNhan("", "", _groupUser);
                    
                    btnLuu.Enabled = true;
                    btnXoaHopDong.Enabled = true;
                }
                else
                {
                    _listHopDong = DataServices.ViewDanhSachHopDongThinhGiang.GetHopDongDaXacNhan("", "", _groupUser);
                    btnLuu.Enabled = false;
                    btnXoaHopDong.Enabled = false;
                }
                btnIn.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else
            {
                if (radioGroupHopDong.SelectedIndex == 0)
                    _listHopDong = DataServices.ViewDanhSachHopDongThinhGiang.GetHopDongChuaXacNhan("", "", "-1");
                else
                    _listHopDong = DataServices.ViewDanhSachHopDongThinhGiang.GetHopDongDaXacNhan("", "", "-1");

                btnIn.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }

            bindingSourceDanhSachHopDong.DataSource = _listHopDong;
        }
        #endregion

        #region Event Button

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            InitData();
            
            RefreshForm();

            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            gridViewDanhSachHopDong.FocusedRowHandle = -1;
            txtSoHopDong.Focus();

            if (_objHopDong != null)
            {
                _objHopDong.NgayCapNhat = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                _objHopDong.NguoiCapNhat = UserInfo.UserName;

                string _kiemTraHopDong = "1";
                if (_objHopDong.IsNew)
                    DataServices.DanhSachHopDongThinhGiang.KiemTraSoHopDong(_objHopDong.SoHopDong, ref _kiemTraHopDong);

                if (_kiemTraHopDong != "1")
                {
                    if (XtraMessageBox.Show(_kiemTraHopDong, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string _soHopDongMoi = "";
                        DataServices.DanhSachHopDongThinhGiang.GetSoHopDong(ref _soHopDongMoi);
                        _objHopDong.SoHopDong = _soHopDongMoi;
                        if (_objHopDong.MaLopHocPhan != null && _objHopDong.MaDonVi != null)
                        {
                            if (XtraMessageBox.Show("Bạn muốn lưu những thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                try
                                {
                                    DataServices.DanhSachHopDongThinhGiang.Save(_objHopDong);
                                    XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch
                                {
                                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        else XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (_objHopDong.MaLopHocPhan != null && _objHopDong.MaDonVi != null)
                    {
                        if (XtraMessageBox.Show("Bạn muốn lưu những thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                DataServices.DanhSachHopDongThinhGiang.Save(_objHopDong);
                                XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //Load lại dữ liệu sau khi lưu
            LoadHopDong();

            Cursor.Current = Cursors.Default;
        }

        private void btnHeSoQuyDoi_Click(object sender, EventArgs e)
        {
            using (frmChonHeSoThucHanh frm = new frmChonHeSoThucHanh())
            {
                frm.ShowDialog();
                _objHopDong.HeSoQuyDoiThucHanh = frm._hesoquydoithuchanhsanglythuyet;
            }
        }

        private void btnDonGiaChiTiet_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
            {
                string _namHoc = cboNamHoc.EditValue.ToString();
                if (_namHoc == "")
                    _namHoc = _cauHinhChung.Find(p => p.TenCauHinh == "").GiaTri;
                using (frmChonDonGia frm = new frmChonDonGia(_namHoc))
                {
                    frm.ShowDialog();
                    _objHopDong.DonGia = frm._donGia;
                }
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_objHopDong != null)
                {
                    using (frmChonNgay_NguoiDaiDien frm = new frmChonNgay_NguoiDaiDien())
                    {
                        frm.ShowDialog();
                        _ngayIn = frm.NgayIn;
                        _nguoiDaiDien = frm.NguoiDaiDien;
                        _tenChucVu = frm.TenChucVu;

                        GiangVien _objGiangVien = DataServices.GiangVien.GetByMaGiangVien((int)_objHopDong.MaGiangVien);
                        ViewDanhSachHopDongThinhGiang _objViewHopDong = _listHopDong.Find(p => p.Id == _objHopDong.Id);
                        ViewKhoaBoMon _vKhoaBoMon = _listKhoaBoMon.Find(p => p.MaBoMon == _objHopDong.MaDonVi);
                        string _coSo = _vKhoaBoMon.TenCoSo;
                        string _diaChiCoSo = PMS.Common.Globals.IsNull(DataServices.ViewCoSo.Get("MaCoSo='" + _vKhoaBoMon.MaCoSo + "'", "MaCoSo")[0].DiaChi, "string").ToString();
                        string _tenLop = cboLopHocPhan.Text;
                        using (frmBaoCao frmBC = new frmBaoCao())
                        {
                            frmBC.InHopDongMoiGiangMonHocIUH(_objViewHopDong, _ngayIn, _nguoiDaiDien, _tenChucVu, _objGiangVien, _coSo, _diaChiCoSo, _tenLop);
                            frmBC.ShowDialog();
                        }
                    }
                }
            }
            catch
            { }
        }

        private void btnXoaHopDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewDanhSachHopDongThinhGiang _vHopDong = bindingSourceDanhSachHopDong.Current as ViewDanhSachHopDongThinhGiang;
            if (_vHopDong != null)
            {
                if (XtraMessageBox.Show(string.Format("Bạn muốn xoá hợp đồng số {0}?", _vHopDong.SoHopDong), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DanhSachHopDongThinhGiang _hopDong = DataServices.DanhSachHopDongThinhGiang.GetById(_vHopDong.Id);
                    DataServices.DanhSachHopDongThinhGiang.Delete(_hopDong);

                    XtraMessageBox.Show(string.Format("Hợp đồng số {0} đã bị xoá.", _vHopDong.SoHopDong), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadHopDong();
            }
        }
        #endregion

        #region Event Radio group
        private void radioGroupHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadHopDong();
            RefreshForm();
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (cboNamHoc.EditValue != null)
                {
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                }

                if (_userRole)
                {
                    if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    {
                        _listLopHocPhan = DataServices.ViewLopHocPhan.GetByNamHocHocKyKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _groupUser);
                    }
                }
                else
                {
                    if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    {
                        _listLopHocPhan = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    }
                }
                bindingSourceLopHocPhan.DataSource = _listLopHocPhan;
                Cursor.Current = Cursors.Default;
            }
            catch
            {   }
            
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (_userRole)
                {
                    if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    {
                        _listLopHocPhan = DataServices.ViewLopHocPhan.GetByNamHocHocKyKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), _groupUser);
                    }
                }
                else
                {
                    if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                    {
                        _listLopHocPhan = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    }
                }
                bindingSourceLopHocPhan.DataSource = _listLopHocPhan;
                Cursor.Current = Cursors.Default;
            }
            catch 
            {}
          
        }

        private void cboLopHocPhan_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboLopHocPhan.EditValue.ToString() != "")
                {
                    ViewLopHocPhan v = _listLopHocPhan.Find(p => p.MaLopHocPhan == cboLopHocPhan.EditValue.ToString());
                    _objHopDong.MaLopHocPhan = v.MaLopHocPhan;
                    _objHopDong.MaMonHoc = v.MaMonHoc;
                    _objHopDong.MaLop = v.MaLop;
                    if(v.MaLop == "")
                        _objHopDong.MaLop = v.TenLopHocPhan;

                    DataTable tblLHP = new DataTable();
                    IDataReader reader = DataServices.DanhSachHopDongThinhGiang.GetThongTinLopHocPhan(v.MaLopHocPhan);
                    tblLHP.Load(reader);
                    if (tblLHP != null && tblLHP.Rows.Count > 0)
                    {
                        //spinEditSoTietLT.EditValue = tblLHP.Rows[0]["LyThuyet"];
                        //spinEditSoTietTH.EditValue = tblLHP.Rows[0]["ThucHanh"];
                        //spinEditHeSoQuyDoi.EditValue = tblLHP.Rows[0]["HeSoQuyDoiThucHanhSangLyThuyet"];
                        //spinEditSiSo.EditValue = tblLHP.Rows[0]["SiSo"];
                        _objHopDong.SoTietLyThuyet = decimal.Parse(tblLHP.Rows[0]["LyThuyet"].ToString());
                        _objHopDong.SoTietThucHanh = decimal.Parse(tblLHP.Rows[0]["ThucHanh"].ToString());
                        _objHopDong.HeSoQuyDoiThucHanh = decimal.Parse(tblLHP.Rows[0]["HeSoQuyDoiThucHanhSangLyThuyet"].ToString());
                        _objHopDong.SiSo = int.Parse(tblLHP.Rows[0]["SiSo"].ToString());
                    }
                }
            }
            catch
            { }
            
        }

        private void cboTenGiangVien_EditValueChanged(object sender, EventArgs e)
        {
            if (cboTenGiangVien.EditValue.ToString() != "")
            {
                ViewGiangVien _vGiangVien = _listGiangVien.Find(p => p.MaGiangVien == int.Parse(cboTenGiangVien.EditValue.ToString()));
                _objHopDong.MaGiangVien = _vGiangVien.MaGiangVien;
                _objHopDong.HoTen = _vGiangVien.HoTen;
                _objHopDong.NgaySinh = _vGiangVien.NgaySinh;
                _objHopDong.SoCmnd = _vGiangVien.Cmnd;
                _objHopDong.MaHocHam = _vGiangVien.MaHocHam;
                _objHopDong.MaHocVi = _vGiangVien.MaHocVi;
                _objHopDong.ChuyenNganh = _vGiangVien.ChuyenNganh;
                _objHopDong.MaSoThue = _vGiangVien.MaSoThue;
                _objHopDong.CoQuanCongTac = _vGiangVien.NoiLamViec;
            }
        }

        private void cboTienTe_EditValueChanged(object sender, EventArgs e)
        {
            if (cboTienTe.EditValue.ToString() != "")
            {
                spinEditTongGiaTriHD.Properties.DisplayFormat.FormatString = "{0:n0} " + cboTienTe.EditValue.ToString();
                spinEditGiaTriHDConLai.Properties.DisplayFormat.FormatString = "{0:n0} " + cboTienTe.EditValue.ToString();
                spinEditThue.Properties.DisplayFormat.FormatString = "{0:n0} " + cboTienTe.EditValue.ToString();
            }
        }
        #endregion

        #region Validated value
        private void dateEditNgayBatDau_Validated(object sender, EventArgs e)
        {
            try
            {
                if (_userRole)
                {
                    if (dateEditNgayBatDau.DateTime < DateTime.Now)
                    {
                        XtraMessageBox.Show("Không được phép chọn ngày bắt đầu nhỏ hơn ngày hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dateEditNgayBatDau.Focus();
                    }
                }
            }
            catch
            { }
        }

        private void dateEditNgayKetThuc_Validated(object sender, EventArgs e)
        {
            try
            {
                if (_userRole)
                {
                    if (dateEditNgayBatDau.DateTime > dateEditNgayKetThuc.DateTime)
                    {
                        XtraMessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dateEditNgayKetThuc.Focus();
                    }
                }
            }
            catch
            { }
        }
        #endregion

        #region spinEditHeSoQuyDoi_CustomDisplayText
        private void spinEditHeSoQuyDoi_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (Math.Round(Convert.ToDouble(e.Value), 2, MidpointRounding.AwayFromZero) == 0.67)
                e.DisplayText = "2/3";
        }
        #endregion

        #region Event Textbox and SpinEdit
        private void spinEditTongSoTiet_EditValueChanged(object sender, EventArgs e)
        {
            if (spinEditTongSoTiet.EditValue != null && spinEditDonGiaChiTiet.EditValue != null)
            {
                _objHopDong.TongSoTiet = (decimal)spinEditTongSoTiet.EditValue;
                _objHopDong.TongGiaTriHopDong = (decimal)spinEditTongSoTiet.EditValue * (decimal)spinEditDonGiaChiTiet.EditValue;
                //_objHopDong.GiaTriHopDongConLai = _objHopDong.TongGiaTriHopDong;
                //_objHopDong.Thue = _objHopDong.TongGiaTriHopDong * (decimal)0.1;
            }
        }

        private void spinEditDonGiaChiTiet_EditValueChanged(object sender, EventArgs e)
        {
            if (spinEditTongSoTiet.EditValue != null && spinEditDonGiaChiTiet.EditValue != null)
            {
                cboTienTe.Focus();
                
                _objHopDong.DonGia = (decimal)spinEditDonGiaChiTiet.EditValue;

                _objHopDong.TongGiaTriHopDong = _objHopDong.TongSoTiet * _objHopDong.DonGia;
                //_objHopDong.GiaTriHopDongConLai = _objHopDong.TongGiaTriHopDong;
                //_objHopDong.Thue = _objHopDong.TongGiaTriHopDong * (decimal)0.1;

                spinEditTongGiaTriHD.Text = _objHopDong.TongGiaTriHopDong.ToString();
                //spinEditGiaTriHDConLai.Text = _objHopDong.GiaTriHopDongConLai.ToString();
                //spinEditThue.Text = _objHopDong.Thue.ToString();
            }
        }

        private void spinEditSoTietLTTuan_EditValueChanged(object sender, EventArgs e)
        {
            if (spinEditSoTietLTTuan.EditValue != null && spinEditSoTietHTTuan.EditValue != null)
            {
                _objHopDong.SoTietLyThuyetTrenTuan = (decimal)spinEditSoTietLTTuan.EditValue;
                _objHopDong.TongSoTietTrenTuan = (decimal)spinEditSoTietLTTuan.EditValue + (decimal)spinEditSoTietHTTuan.EditValue;
            }
        }

        private void spinEditSoTietHTTuan_EditValueChanged(object sender, EventArgs e)
        {
            if (spinEditSoTietLTTuan.EditValue != null && spinEditSoTietHTTuan.EditValue != null)
            {
                _objHopDong.SoTietThucHanhTrenTuan = (decimal)spinEditSoTietHTTuan.EditValue;
                _objHopDong.TongSoTietTrenTuan = (decimal)spinEditSoTietLTTuan.EditValue + (decimal)spinEditSoTietHTTuan.EditValue;
            }
        }

        private void spinEditSoTietLT_EditValueChanged(object sender, EventArgs e)
        {
            if (spinEditSoTietLT.Value > 0 && spinEditSoTietTH.Value == 0)
            {
                btnHeSoQuyDoi.Enabled = false;
            }
            else
            {
                btnHeSoQuyDoi.Enabled = true;
            }
        }

        private void spinEditSoTietTH_EditValueChanged(object sender, EventArgs e)
        {
            if (spinEditSoTietLT.Value > 0 && spinEditSoTietTH.Value == 0)
            {
                btnHeSoQuyDoi.Enabled = false;
            }
            else
            {
                btnHeSoQuyDoi.Enabled = true;
            }
        }

        #endregion

    }
}