using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmNhapCacKhoiLuongKhac_VHU : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;

                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoa.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        VList<ViewGiangVien> _listGiangVien;
        TList<CauHinhChung> _listCauHinhChung = DataServices.CauHinhChung.GetAll();
        VList<ViewKhoa> _listKhoaDonVi;
        string _groupName = UserInfo.GroupName;
        bool _status;
        string _cauHinhHeSoTheoNam, _maTruong;
        Keys firstKey;
        bool copied = false;
        #endregion

        #region Xử lý nghiệp vụ
        void InitData()
        {
            _listKhoaDonVi = DataServices.ViewKhoa.GetAll();
            if (_maTruong.Equals("VHU"))
            {
                foreach (ViewKhoa v in _listKhoaDonVi)
                {
                    if (v.MaKhoa == _groupName)
                    {
                        _status = true;
                        break;
                    }
                }
            }

            if (_status)
                _listKhoaDonVi = _listKhoaDonVi.FindAll(p => p.MaKhoa == _groupName) as VList<ViewKhoa>;
            else
            {
                _listKhoaDonVi.Insert(0, new ViewKhoa() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]" });
            }

            cboKhoaDonVi.DataBindings.Clear();
            bindingSourceKhoaDonVi.DataSource = _listKhoaDonVi;
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);

            if (cboKhoaDonVi.EditValue != null)
            {
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
                bindingSourceGiangVien.DataSource = _listGiangVien;
            }

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            cboLoaiKhoiLuong.DataBindings.Clear();
            bindingSourceLoaiKhoiLuong.DataSource = DataServices.LoaiKhoiLuong.GetAll();
            cboLoaiKhoiLuong.DataBindings.Add("EditValue", bindingSourceLoaiKhoiLuong, "MaLoaiKhoiLuong", true, DataSourceUpdateMode.OnPropertyChanged);

            InitDotThanhToan();

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiKhoiLuong.EditValue != null)
            {
                bindingSourceKhoiLuong.DataSource = DataServices.ViewKhoiLuongCacCongViecKhac.GetByNamHocHocKyLoaiCongViecKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
        }
        void copyGridViewRow(int[] selectedRowsHandle)
        {
            VList<ViewKhoiLuongCacCongViecKhac> list = bindingSourceKhoiLuong.DataSource as VList<ViewKhoiLuongCacCongViecKhac>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Xác nhận sao chép các dòng được chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < selectedRowsHandle.Length; i++)
                    {
                        //Gridview được bound bằng List<> thì nếu GetDataRow hay GetRow sẽ ra null.
                        ViewKhoiLuongCacCongViecKhac cv = new ViewKhoiLuongCacCongViecKhac();
                        cv.MaGiangVien = (int)gridViewKhoiLuong.GetRowCellValue(selectedRowsHandle[i],"MaGiangVien");
                        cv.Ho = (string)gridViewKhoiLuong.GetRowCellValue(selectedRowsHandle[i],"Ho");
                        cv.Ten = (string)gridViewKhoiLuong.GetRowCellValue(selectedRowsHandle[i],"Ten");
                        cv.MaLoaiCongViec = (int)gridViewKhoiLuong.GetRowCellValue(selectedRowsHandle[i],"MaLoaiCongViec");
                        cv.MaLop = (string)gridViewKhoiLuong.GetRowCellValue(selectedRowsHandle[i],"MaLop");
                        cv.MaNhom = (string)gridViewKhoiLuong.GetRowCellValue(selectedRowsHandle[i],"MaNhom");
                        cv.SoLuong = (decimal)gridViewKhoiLuong.GetRowCellValue(selectedRowsHandle[i],"SoLuong");
                        cv.DotThanhToan = (string)gridViewKhoiLuong.GetRowCellValue(selectedRowsHandle[i],"DotThanhToan");
                        cv.GhiChu = (string)gridViewKhoiLuong.GetRowCellValue(selectedRowsHandle[i],"GhiChu");
                        cv.NgayCapNhat = (string)gridViewKhoiLuong.GetRowCellValue(selectedRowsHandle[i],"NgayCapNhat");
                        cv.NguoiCapNhat = (string)gridViewKhoiLuong.GetRowCellValue(selectedRowsHandle[i],"NguoiCapNhat");
                        cv.HeSoNhan = (int)gridViewKhoiLuong.GetRowCellValue(selectedRowsHandle[i], "HeSoNhan");
                        list.Add(cv);
                    }
                    bindingSourceKhoiLuong.DataSource = list;
                    gridViewKhoiLuong.RefreshData();
                }
            }
        }
        #endregion

        public frmNhapCacKhoiLuongKhac_VHU()
        {
            InitializeComponent();
            _cauHinhHeSoTheoNam = _listCauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
            _maTruong = _listCauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmNhapCacKhoiLuongKhac_VHU_Load(object sender, EventArgs e)
        {
            #region InitGridView
            switch (_maTruong)
            { 
                case "VHU":
                    InitGridVHU();
                    break;
                case "DLU":
                    InitGridDLU();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" }, new int[] { 90, 110 });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _listCauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region _khoaDonVi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" }, new int[] {60, 200});
            cboKhoaDonVi.Properties.ValueMember = "MaKhoa";
            cboKhoaDonVi.Properties.DisplayMember = "TenKhoa";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion

            #region LoaiKhoiLuong
            AppGridLookupEdit.InitGridLookUp(cboLoaiKhoiLuong, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiKhoiLuong, new string[] { "MaLoaiKhoiLuong", "TenLoaiKhoiLuong" }, new string[] { "Mã loại", "Tên loại" }, new int[]{ 50, 250 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 400, 650);
            cboLoaiKhoiLuong.Properties.ValueMember = "MaLoaiKhoiLuong";
            cboLoaiKhoiLuong.Properties.DisplayMember = "TenLoaiKhoiLuong";
            cboLoaiKhoiLuong.Properties.NullText = string.Empty;
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "TenDonVi" }, new string[] { "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Loại giảng viên", "Đơn vị" }, new int[] { 90, 130, 100, 100, 100, 150 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 670, 650);
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region QuyDoiGioChuan
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLoaiCongViec, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLoaiCongViec, new string[] { "MaQuanLy", "TenQuyDoi" }, new string[] { "Mã quản lý", "Tên quy đổi" }, new int[] { 90, 300 });
            repositoryItemGridLookUpEditLoaiCongViec.ValueMember = "MaQuyDoi";
            repositoryItemGridLookUpEditLoaiCongViec.DisplayMember = "TenQuyDoi";
            repositoryItemGridLookUpEditLoaiCongViec.NullText = string.Empty;
            #endregion

            #region QuyDoiGioChuan
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDotThanhToan, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDotThanhToan, new string[] { "MaQuanLy", "TenQuanLy", "TuNgay", "DenNgay" }, new string[] { "Mã đợt thanh toán", "Tên đợt thanh toán", "Từ ngày", "Đến ngày" }, new int[] { 100, 100, 100, 100 });
            repositoryItemGridLookUpEditDotThanhToan.BestFitMode = BestFitMode.BestFit;
            repositoryItemGridLookUpEditDotThanhToan.ValueMember = "MaCauHinhChotGio";
            repositoryItemGridLookUpEditDotThanhToan.DisplayMember = "TenQuanLy";
            repositoryItemGridLookUpEditDotThanhToan.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitGrid
        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewKhoiLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewKhoiLuong, new string[] { "MaGiangVien", "Ho", "Ten", "MaLoaiCongViec", "HeSoNhan", "MaLop", "MaNhom", "SoLuong", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Loại công việc", "Số tín chỉ", "Mã lớp", "Nhóm", "Số lượng", "Ghi chú", "Ngày cập nhật", "Người cập nhật" }
                    , new int[] { 90, 115, 55, 150, 90, 130, 130, 90, 250, 99, 99 });
            AppGridView.ShowEditor(gridViewKhoiLuong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewKhoiLuong, new string[] { "MaGiangVien", "Ho", "Ten", "MaLoaiCongViec", "HeSoNhan", "MaLop", "MaNhom", "SoLuong", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewKhoiLuong, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewKhoiLuong, "MaLoaiCongViec", repositoryItemGridLookUpEditLoaiCongViec);
            AppGridView.HideField(gridViewKhoiLuong, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.ReadOnlyColumn(gridViewKhoiLuong, new string[] { "Ho", "Ten" });
        }

        void InitGridDLU()
        {
            AppGridView.InitGridView(gridViewKhoiLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewKhoiLuong, new string[] { "MaGiangVien", "Ho", "Ten", "MaLoaiCongViec", "SoLuong", "DotThanhToan", "GhiChu", "NgayCapNhat", "NguoiCapNhat", "HeSoNhan" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Loại công việc", "Số lượng", "Đợt tạm ứng", "Ghi chú", "Ngày cập nhật", "Người cập nhật", "HeSoNhan" }
                    , new int[] { 90, 115, 55, 500, 90, 90, 90, 99, 99, 99 });
            AppGridView.ShowEditor(gridViewKhoiLuong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewKhoiLuong, new string[] { "MaGiangVien", "Ho", "Ten", "MaLoaiCongViec", "SoLuong", "DotThanhToan", "GhiChu", "NgayCapNhat", "NguoiCapNhat", "HeSoNhan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewKhoiLuong, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewKhoiLuong, "MaLoaiCongViec", repositoryItemGridLookUpEditLoaiCongViec);
            AppGridView.RegisterControlField(gridViewKhoiLuong, "DotThanhToan", repositoryItemGridLookUpEditDotThanhToan);
            AppGridView.HideField(gridViewKhoiLuong, new string[] { "NgayCapNhat", "NguoiCapNhat", "HeSoNhan" });
            AppGridView.ReadOnlyColumn(gridViewKhoiLuong, new string[] { "Ho", "Ten" });
            AppGridView.SummaryField(gridViewKhoiLuong, "MaGiangVien", "{0} dòng.", DevExpress.Data.SummaryItemType.Count);
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewKhoiLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewKhoiLuong, new string[] { "MaGiangVien", "Ho", "Ten", "MaLoaiCongViec", "MaLop", "MaNhom", "SoLuong", "GhiChu", "NgayCapNhat", "NguoiCapNhat", "HeSoNhan" }
                    , new string[] { "Mã giảng viên", "Họ", "Tên", "Mã loại công việc", "mã lớp", "Nhóm", "Số lượng", "Ghi chú", "Ngày cập nhật", "Người cập nhật", "HeSoNhan" }
                    , new int[] { 90, 115, 55, 150, 130, 130, 90, 250, 99, 99, 99 });
            AppGridView.ShowEditor(gridViewKhoiLuong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewKhoiLuong, new string[] { "MaGiangVien", "Ho", "Ten", "MaLoaiCongViec", "MaLop", "MaNhom", "SoLuong", "GhiChu", "NgayCapNhat", "NguoiCapNhat", "HeSoNhan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewKhoiLuong, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewKhoiLuong, "MaLoaiCongViec", repositoryItemGridLookUpEditLoaiCongViec);
            AppGridView.HideField(gridViewKhoiLuong, new string[] { "NgayCapNhat", "NguoiCapNhat", "HeSoNhan" });
            AppGridView.ReadOnlyColumn(gridViewKhoiLuong, new string[] { "Ho", "Ten" });
        }
        #endregion 

        #region InitData()
        

        void InitDotThanhToan()
        {
            try
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                {
                    #region _dotThanhToan
                    TList<CauHinhChotGio> _listDotThanhToan = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    bindingSourceDotThanhToan.DataSource = _listDotThanhToan;
                    #endregion
                }
            }
            catch
            {  }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKhoiLuong);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            int kiemtra = 0;
            DataServices.KhoiLuongCacCongViecKhac.KiemTraChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kiemtra);
            if (kiemtra == 1)
            {
                XtraMessageBox.Show(string.Format("Khối lượng giảng dạy năm học {0} - {1} đã bị chốt để thực hiện thanh toán thù lao. \nVui lòng liên hệ phòng ban quản lý để biết thêm chi tiết.", cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.WaitCursor;
                //InitData();   Init sẽ xóa hết dữ liệu đang nhập, bắt người ta nhập lại hết là không đẹp rồi :))
                Cursor.Current = Cursors.Default;
                return;
            }

            gridViewKhoiLuong.FocusedRowHandle = -1;
            VList<ViewKhoiLuongCacCongViecKhac> list = bindingSourceKhoiLuong.DataSource as VList<ViewKhoiLuongCacCongViecKhac>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (ViewKhoiLuongCacCongViecKhac cv in list)
                        {
                            if (decimal.Parse(PMS.Common.Globals.IsNull(cv.SoLuong, "decimal").ToString()) != 0 && cv.MaGiangVien != null && cv.MaLoaiCongViec != 0)
                            {
                                xmlData += "<Input M=\"" + cv.MaGiangVien
                                        + "\" S=\"" + cv.SoLuong
                                        + "\" ML=\"" + PMS.Common.Globals.IsNull(cv.MaLop, "string")
                                        + "\" MN=\"" + PMS.Common.Globals.IsNull(cv.MaNhom, "string")
                                        + "\" G=\"" + cv.GhiChu
                                        + "\" D=\"" + cv.NgayCapNhat
                                        + "\" U=\"" + cv.NguoiCapNhat
                                        + "\" L=\"" + cv.MaLoaiCongViec
                                        + "\" DTT=\"" + cv.DotThanhToan
                                        + "\" ID=\"" + cv.Id
                                        + "\" HS=\"" + cv.HeSoNhan
                                        + "\" />";
                            }
                            else
                            {
                                XtraMessageBox.Show("Vui lòng nhập đủ thông tin tối thiểu: Giảng viên, loại công việc, số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        xmlData = "<Root>" + xmlData + "</Root>";
                        bindingSourceKhoiLuong.EndEdit();
                        int kq = 0;
                        DataServices.KhoiLuongCacCongViecKhac.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString(), ref kq);
                        if (kq == 0)
                        {
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //InitData();
                        }
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi:\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewKhoiLuong_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewKhoiLuong, e);   //Có thể delete if (e.KeyCode == Keys.Delete)
         
            if (firstKey == Keys.Control && e.KeyCode == Keys.C)
            {
                copied = true;
                MessageBox.Show("Copied!");
            }
            else if (copied && firstKey == Keys.Control && e.KeyCode == Keys.V)
            {
                copyGridViewRow(gridViewKhoiLuong.GetSelectedRows());
            }
            else
            {
                firstKey = e.KeyCode;
                copied = false;
            }
        }

        private void gridViewKhoiLuong_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor; 
                GridColumn col = e.Column;
                if (col.FieldName == "MaGiangVien")
                {
                    //ViewKhoiLuongCacCongViecKhac objHD = gridViewKhoiLuong.GetRow(e.RowHandle) as ViewKhoiLuongCacCongViecKhac;
                    ViewGiangVien objGV = _listGiangVien.Find(p => p.MaGiangVien == int.Parse(e.Value.ToString())); 
                    gridViewKhoiLuong.SetRowCellValue(e.RowHandle, "Ho", objGV.Ho);
                    gridViewKhoiLuong.SetRowCellValue(e.RowHandle, "Ten", objGV.Ten);
                }
                if (col.FieldName == "MaGiangVien" || col.FieldName == "MaLop" || col.FieldName == "MaNhom" || col.FieldName == "SoLuong" || col.FieldName == "GhiChu" || col.FieldName == "HeSoNhan")
                {
                    gridViewKhoiLuong.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    gridViewKhoiLuong.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Object reference not set"))
                {
                    //gridViewKhoiLuong.AddNewRow();
                }
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            InitDotThanhToan();

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiKhoiLuong.EditValue != null)
            {
                bindingSourceKhoiLuong.DataSource = DataServices.ViewKhoiLuongCacCongViecKhac.GetByNamHocHocKyLoaiCongViecKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            InitDotThanhToan();

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiKhoiLuong.EditValue != null)
            {
                bindingSourceKhoiLuong.DataSource = DataServices.ViewKhoiLuongCacCongViecKhac.GetByNamHocHocKyLoaiCongViecKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboLoaiCongViec_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if(cboLoaiKhoiLuong.EditValue.ToString() != "")
                bindingSourceLoaiCongViec.DataSource = DataServices.QuyDoiGioChuan.GetByMaLoaiKhoiLuongNamHocHocKy(cboLoaiKhoiLuong.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiKhoiLuong.EditValue != null)
            {
                bindingSourceKhoiLuong.DataSource = DataServices.ViewKhoiLuongCacCongViecKhac.GetByNamHocHocKyLoaiCongViecKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
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

        private void cboKhoaDonVi_EditValueChanged_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboKhoaDonVi.EditValue != null)
            {
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
                bindingSourceGiangVien.DataSource = _listGiangVien;
            }

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null && cboLoaiKhoiLuong.EditValue != null)
            {
                bindingSourceKhoiLuong.DataSource = DataServices.ViewKhoiLuongCacCongViecKhac.GetByNamHocHocKyLoaiCongViecKhoaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            copyGridViewRow(gridViewKhoiLuong.GetSelectedRows());
        }

        private void gridViewKhoiLuong_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode == Keys.ControlKey) 
            {
                firstKey = e.KeyCode;
            }
        }
    }
}