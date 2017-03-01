using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities;
using DevExpress.XtraGrid.Columns;
using PMS.Core;
using ExcelLibrary;
using PMS.BLL;
using DevExpress.XtraGrid.Views.Grid;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmCoVanHocTap2 : DevExpress.XtraEditors.XtraForm
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

                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ShortCut = Shortcut.None;

                btnChotCVHT.Enabled = false;
                btnHuyChotCVHT.Enabled = false;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                btnChotCVHT.Enabled = true;
                btnHuyChotCVHT.Enabled = true;
            }
        }
        #endregion

        #region Variable
        int danhDau = 0;
        TList<CauHinhChung> cauHinh = DataServices.CauHinhChung.GetAll();
        string _maTruong, _coVanTheoNam, _tenTruong;
        private string groupname = UserInfo.GroupName;
        private bool user = false;
        int _kiemTra = 0;
        
        #endregion

        #region Event Form
        public frmCoVanHocTap2()
        {
            InitializeComponent();
            _maTruong = cauHinh.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _tenTruong = cauHinh.Find(p => p.TenCauHinh == "Tên trường").GiaTri;
            _coVanTheoNam = cauHinh.Find(p => p.TenCauHinh == "Cố vấn học tập phân theo năm học").GiaTri;
            if (_coVanTheoNam == "True")
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }             

        private void frmCoVanHocTap2_Load(object sender, EventArgs e)
        {
           
            #region InitGridView
            switch (_maTruong)
            {
                case "UEL":
                    if (_coVanTheoNam == "True")
                        InitGridUEL();
                    else
                        InitRemaining();
                    break;
                case "CTIM":
                    InitGridCTIM();
                    break;
                case "UTE":
                    if (_tenTruong == "Trường Đại Học Tài Chính - Marketing")
                        InitGridUFM();
                    else
                        InitRemaining();
                    break;
                case "UFM":
                    InitGridUFM();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            
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

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen" },
                    new string[] { "Mã giảng viên", "Họ tên" });
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "HoTen";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            #region Lớp
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLop, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLop, new string[] { "MaBacLoaiHinh", "MaKhoaHoc", "TenKhoa", "MaLop", "TenLop" },
                    new string[] { "Bậc - Loại hình", "Mã khóa học", "Tên khoa", "Mã lớp", "Tên lớp" }
                    , new int[] { 100, 100, 120, 90, 90 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLop, 500, 450);
            repositoryItemGridLookUpEditLop.DisplayMember = "MaLop";
            repositoryItemGridLookUpEditLop.ValueMember = "MaLop";
            repositoryItemGridLookUpEditLop.NullText = string.Empty;
            #endregion

            #region Đánh giá hoàn thành
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDanhGia, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDanhGia, new string[] { "NoiDungDanhGia", "PhanTramHuongThu" },
                    new string[] { "Nội dung đánh giá", "Phần trăm hưởng thụ (%)" }
                    , new int[] { 150, 150 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditDanhGia, 300, 450);
            repositoryItemGridLookUpEditDanhGia.DisplayMember = "NoiDungDanhGia";
            repositoryItemGridLookUpEditDanhGia.ValueMember = "Id";
            repositoryItemGridLookUpEditDanhGia.NullText = string.Empty;
            #endregion

            #region Nhóm
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhom, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhom, new string[] { "MaNhom" },
                    new string[] { "Nhóm" });
            repositoryItemGridLookUpEditNhom.DisplayMember = "MaNhom";
            repositoryItemGridLookUpEditNhom.ValueMember = "MaNhom";
            repositoryItemGridLookUpEditNhom.NullText = string.Empty;
            #endregion

            #region Init nam hoc - hoc ky hien tai
            cboNamHoc.EditValue = cauHinh.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            cboHocKy.EditValue = cauHinh.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Init Data
            InitData();
            #endregion
        }
        #endregion

        #region InitGrid
        #region Init Grid CTIM
        void InitGridCTIM()
        {
            AppGridView.InitGridView(gridViewCoVan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewCoVan, new string[] { "MaGiangVien", "MaLop", "MaKhoaHoc", "SiSo", "NgayTao", "SoTien", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                                    new string[] { "Họ tên giảng viên", "Mã lớp", "Khóa học", "Sĩ số", "Ngày phân công", "Số tiền", "Ghi chú", "NgayCapNhat", "NguoiCapNhat" },
                                    new int[] { 180, 150, 60, 80, 120, 100, 150, 99, 99 });
            AppGridView.ShowEditor(gridViewCoVan, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.SummaryField(gridViewCoVan, "MaLop", "Tổng số lớp: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewCoVan, "SoTien", "Tổng tiền: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.AlignHeader(gridViewCoVan, new string[] { "MaGiangVien", "MaKhoaHoc", "MaLop", "SiSo", "NgayTao", "SoTien", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewCoVan, new string[] { "MaKhoaHoc", "SiSo" });
            AppGridView.RegisterControlField(gridViewCoVan, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewCoVan, "MaLop", repositoryItemGridLookUpEditLop);
            AppGridView.RegisterControlField(gridViewCoVan, "SoTien", repositoryItemSpinEditSoTien);
            AppGridView.FormatDataField(gridViewCoVan, "SoTien", DevExpress.Utils.FormatType.Custom, "n0");

            if (groupname != "Administrator" && groupname != "10" && groupname != "008")//Admin và phòng CT-HSSV, ban gdcn
            {
                layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btn_Excel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            AppGridView.HideField(gridViewCoVan, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }
        #endregion
        #region Init Grid UEL
        void InitGridUEL()
        {
            AppGridView.InitGridView(gridViewCoVan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewCoVan, new string[] { "MaGiangVien", "MaKhoaHoc", "MaLop", "NgayTao", "NgayKetThuc", "SoTiet", "DanhGiaHoanThanh", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                                    new string[] { "Họ tên giảng viên", "Khóa học", "Mã lớp", "Ngày phân công", "Ngày kết thúc", "Số tiết", "Đánh giá hoàn thành", "Ghi chú", "Ngày cập nhật", "Người cập nhật" },
                                    new int[] { 180, 80, 150, 120, 120, 100, 150, 200, 99, 99 });
            AppGridView.ShowEditor(gridViewCoVan, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.SummaryField(gridViewCoVan, "MaLop", "Tổng số lớp: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.AlignHeader(gridViewCoVan, new string[] { "MaGiangVien", "MaKhoaHoc", "MaLop", "NgayTao", "NgayKetThuc", "SoTiet", "DanhGiaHoanThanh", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewCoVan, new string[] { "MaKhoaHoc" });
            AppGridView.RegisterControlField(gridViewCoVan, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewCoVan, "MaLop", repositoryItemGridLookUpEditLop);
            AppGridView.RegisterControlField(gridViewCoVan, "SoTiet", repositoryItemSpinEditSoTiet);
            AppGridView.RegisterControlField(gridViewCoVan, "DanhGiaHoanThanh", repositoryItemGridLookUpEditDanhGia);

            if (groupname != "Administrator" && groupname != "20")
            {
                //layoutControlGroup2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btn_Excel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            AppGridView.HideField(gridViewCoVan, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }
        #endregion
        #region Init UFM
        void InitGridUFM()
        {
            AppGridView.InitGridView(gridViewCoVan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewCoVan, new string[] { "MaGiangVien", "MaKhoaHoc", "MaLop", "Nhom", "SiSo", "NgayTao", "SoTiet", "NgayCapNhat", "NguoiCapNhat" },
                                    new string[] { "Họ tên giảng viên", "Khóa học", "Mã lớp", "Nhóm", "Sĩ số", "Ngày phân công", "Số tiết", "NgayCapNhat", "NguoiCapNhat" },
                                    new int[] { 180, 80, 150, 80, 80, 120, 100, 99, 99 });
            AppGridView.ShowEditor(gridViewCoVan, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.SummaryField(gridViewCoVan, "MaLop", "Tổng số lớp: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.AlignHeader(gridViewCoVan, new string[] { "MaGiangVien", "MaKhoaHoc", "MaLop", "Nhom", "SiSo", "NgayTao", "SoTiet", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewCoVan, new string[] { "MaKhoaHoc", "SiSo" });
            AppGridView.RegisterControlField(gridViewCoVan, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewCoVan, "MaLop", repositoryItemGridLookUpEditLop);
            AppGridView.RegisterControlField(gridViewCoVan, "SoTiet", repositoryItemSpinEditSoTiet);
            AppGridView.RegisterControlField(gridViewCoVan, "Nhom", repositoryItemGridLookUpEditNhom);
            
            
            if (UserInfo.GroupID != 1)//administrator
                AppGridView.ReadOnlyColumn(gridViewCoVan, new string[] { "SoTiet", "SoTien" });

            AppGridView.HideField(gridViewCoVan, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }
        #endregion
        #region Init Remaining
        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewCoVan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewCoVan, new string[] { "MaGiangVien", "MaKhoaHoc", "MaLop", "SiSo", "NgayTao", "SoTiet", "SoTien", "NgayCapNhat", "NguoiCapNhat" },
                                    new string[] { "Họ tên giảng viên", "Khóa học", "Mã lớp", "Sĩ số", "Ngày phân công", "Số tiết", "Số tiền", "NgayCapNhat", "NguoiCapNhat" },
                                    new int[] { 180, 80, 150, 80, 120, 100, 100, 99, 99 });
            AppGridView.ShowEditor(gridViewCoVan, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.SummaryField(gridViewCoVan, "MaLop", "Tổng số lớp: {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewCoVan, "SoTien", "Tổng tiền: {0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.AlignHeader(gridViewCoVan, new string[] { "MaGiangVien", "MaKhoaHoc", "MaLop", "SiSo", "NgayTao", "SoTiet", "SoTien", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewCoVan, new string[] { "MaKhoaHoc", "SiSo" });
            AppGridView.RegisterControlField(gridViewCoVan, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewCoVan, "MaLop", repositoryItemGridLookUpEditLop);
            AppGridView.RegisterControlField(gridViewCoVan, "SoTiet", repositoryItemSpinEditSoTiet);
            AppGridView.RegisterControlField(gridViewCoVan, "SoTien", repositoryItemSpinEditSoTien);
            AppGridView.FormatDataField(gridViewCoVan, "SoTien", DevExpress.Utils.FormatType.Custom, "n0");

            if (_maTruong == "UFM" || _tenTruong == "Trường Đại Học Tài Chính - Marketing")
            {
                AppGridView.HideField(gridViewCoVan, new string[] { "SoTien" });
                AppGridView.ReadOnlyColumn(gridViewCoVan, new string[] { "SoTien" });
            }
            else
            {
                AppGridView.HideField(gridViewCoVan, new string[] { "SiSo" });
            }
            if (UserInfo.GroupID != 1)//administrator
                AppGridView.ReadOnlyColumn(gridViewCoVan, new string[] { "SoTiet", "SoTien" });

            AppGridView.HideField(gridViewCoVan, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }
        #endregion
        #endregion

        #region InitData
        void InitData()
        {
            #region BindingData
            
            //bindingSourceCoVan.DataSource = DataServices.CoVanHocTap.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            //bindingSourceGiangVien.DataSource = DataServices.GiangVien.GetAll();
            //bindingSourceLop.DataSource = DataServices.ViewLop.GetAll();
            
            bindingSourceGiangVien.DataSource = DataServices.GiangVien.GetByNhomQuyen(groupname);
            bindingSourceLop.DataSource = DataServices.ViewLop.GetByNhomQuyen(groupname);

            bindingSourceDanhGia.DataSource = DataServices.DanhGiaCoVanHocTap.GetAll();
            DataTable _tblNhom = new DataTable();
            IDataReader readerNhom = DataServices.ViewLop.GetAllNhom();
            _tblNhom.Load(readerNhom);
            bindingSourceNhom.DataSource = _tblNhom;

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (danhDau == 0 && cauHinh.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri == null)
            {
                cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
                danhDau = 1;
            }

            if (cboNamHoc.EditValue != null && (cboHocKy.EditValue != null || _coVanTheoNam == "True"))
            {
                bindingSourceCoVan.DataSource = DataServices.CoVanHocTap.GetByNamHocHocKyNhomQuyen(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), groupname);
                DataServices.ChotCoVanHocTap.KiemTra(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref _kiemTra);
            }
            if (_kiemTra == 1)
            {
                AppGridView.ReadOnlyColumn(gridViewCoVan);
                btnChotCVHT.Enabled = false;
                btnHuyChotCVHT.Enabled = true;
                lblGhiChu.Text = "Dữ liệu cố vấn học tập đã bị khoá, liên hệ với bộ phận quản lý cố vấn học tập để biết thêm chi tiết.";
            }
            else
            {
                AllowEditColumn(gridViewCoVan);
                btnChotCVHT.Enabled = true;
                btnHuyChotCVHT.Enabled = false;
                lblGhiChu.Text = "";
            }
            #endregion
        }

        void AllowEditColumn(GridView grid)
        {
            for (int i = 0; i < grid.Columns.Count; i++)
                grid.Columns[i].OptionsColumn.AllowEdit = true;

        }
        #endregion

        #region Event Button
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewCoVan);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_kiemTra == 1)
            {
                XtraMessageBox.Show("Dữ liệu cố vấn học tập đã bị khoá. Liên hệ với bộ phận quản lý CVHT để biết thêm chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            gridViewCoVan.FocusedRowHandle = -1;
            TList<CoVanHocTap> list = bindingSourceCoVan.DataSource as TList<CoVanHocTap>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (CoVanHocTap cv in list)
                            {
                                cv.NamHoc = cboNamHoc.EditValue.ToString();
                                cv.HocKy = cboHocKy.EditValue.ToString();
                                if (_maTruong == "CTIM")
                                    cv.SoTiet = 1;
                                if (_coVanTheoNam == "True")
                                    cv.HocKy = "HK01";
                                if (cv.MaLop == null || cv.MaLop == "")
                                {
                                    XtraMessageBox.Show("Mã lớp không được bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                if (cv.MaGiangVien == null || cv.MaGiangVien < 1)
                                {
                                    XtraMessageBox.Show("Mã giảng viên không được bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                            
                            bindingSourceCoVan.EndEdit();
                            DataServices.CoVanHocTap.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewCoVan, barManager1, layoutControl1 });
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmXuLySaoChepCoVan frm = new frmXuLySaoChepCoVan();
            //frm.ShowDialog();
            frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepCoVanHocTap");
            frm.ShowDialog();
        }

        private void btn_Nhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmImportCoVanHocTap frm = new frmImportCoVanHocTap())
            {
                frm.ShowDialog();
            }
        }

        #region Ham Xuat Excel
        void Excel01()
        {
            using (SaveFileDialog file = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (file.FileName != "")
                    {
                        gridControlCoVan.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        void Excel02()
        {
            try
            {
                TList<CoVanHocTap> _listCoVan = bindingSourceCoVan.DataSource as TList<CoVanHocTap>;
                DataTable table = new DataTable();
                VList<ViewGiangVien> _listGiangVien = DataServices.ViewGiangVien.GetAll();

                if (_listCoVan != null)
                {
                    table.Columns.Add("Mã giảng viên", typeof(string));
                    //table.Columns["MaGiangVien"].Caption = "Mã giảng viên";
                    table.Columns.Add("Họ tên", typeof(string));
                    //table.Columns["HoTen"].Caption = "Họ tên";
                    table.Columns.Add("Năm học", typeof(string));
                    //table.Columns["_namHoc"].Caption = "Năm học";
                    table.Columns.Add("Học kỳ", typeof(string));
                    //table.Columns["_hocKy"].Caption = "Học kỳ";
                    table.Columns.Add("Khóa học", typeof(string));
                    //table.Columns["MaKhoaHoc"].Caption = "Khóa học";
                    table.Columns.Add("Mã lớp", typeof(string));
                    //table.Columns["MaLop"].Caption = "Mã lớp"; 
                    table.Columns.Add("Nhóm", typeof(string));
                    //table.Columns["Nhom"].Caption = "Nhóm";
                    table.Columns.Add("Ngày phân công", typeof(string));
                    //table.Columns["NgayTao"].Caption = "Ngày phân công";
                    table.Columns.Add("Số tiết", typeof(string));
                    //table.Columns["SoTiet"].Caption = "Số tiết";
                    table.Columns.Add("Số tiền", typeof(string));
                    //table.Columns["SoTien"].Caption = "Số tiền";

                }

                foreach (CoVanHocTap c in _listCoVan)
                {
                    table.Rows.Add(_listGiangVien.Find(p => p.MaGiangVien == (int)c.MaGiangVien).MaQuanLy
                        , _listGiangVien.Find(p => p.MaGiangVien == (int)c.MaGiangVien).HoTen
                        , c.NamHoc, c.HocKy, c.MaKhoaHoc, c.MaLop, c.Nhom, c.NgayTao, c.SoTiet, c.SoTien);
                }

                DataSet dsGiangVien = new DataSet("DsGiangVien");
                dsGiangVien.Tables.Add(table);
                SaveFileDialog f = new SaveFileDialog();
                f.Filter = "Excel file (*.xls)|*.xls";
                if (f.ShowDialog() == DialogResult.OK)
                {
                    iloveit1208Library k = new iloveit1208Library();//Lib ExcelLibrary
                    k.ExportToExcel(dsGiangVien, f.FileName);
                    XtraMessageBox.Show("Đã xuất danh sách thành công.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { XtraMessageBox.Show("Lỗi xuất dữ liệu.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion
        private void btn_Xuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (_maTruong)
            {
                case "UTE":
                    if (_tenTruong == "Trường Đại Học Tài Chính - Marketing")
                        Excel02();
                    else
                        Excel01();
                    break;
                case "UFM":
                    Excel02();
                    break;
                default:
                    Excel01();
                    break;
            }
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnChotCVHT_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && (cboHocKy.EditValue != null || _coVanTheoNam == "True"))
                if (XtraMessageBox.Show("Bạn muốn chốt dữ liệu CVHT?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataServices.ChotCoVanHocTap.Chot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), DateTime.Now.ToString(), UserInfo.UserName);
                    InitData();
                }
        }

        private void btnHuyChotCVHT_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && (cboHocKy.EditValue != null || _coVanTheoNam == "True"))
                if (XtraMessageBox.Show("Bạn muốn huỷ chốt dữ liệu CVHT?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataServices.ChotCoVanHocTap.HuyChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                    InitData();
                }
        }

        #endregion

        #region Event GridView
        private void gridViewCoVan_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaLop")
            {
                int pos = e.RowHandle;
                object r = gridViewCoVan.GetRow(pos);

                CoVanHocTap dt = (CoVanHocTap)r;
                VList<ViewLop> lop = DataServices.ViewLop.Get(String.Format("MaLop = '{0}'", dt.MaLop), "MaLop");

                gridViewCoVan.SetRowCellValue(pos, "MaKhoaHoc", lop[0].MaKhoaHoc);
                
                //int _siSo = 0;
                //DataServices.CoVanHocTap.GetSiSoByMaLopNamHocHocKy(dt.MaLop, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref _siSo);
                //gridViewCoVan.SetRowCellValue(pos, "SiSo", _siSo);

                //if (_maTruong == "UFM")
                //{
                //    if (_siSo > 0)
                //    {
                //        decimal _heSoCoVan = 0;
                //        DataServices.HeSoCoVanHocTap.GetBySiSo(_siSo, ref _heSoCoVan);
                //        gridViewCoVan.SetRowCellValue(pos, "SoTiet", _heSoCoVan);
                //    }
                //}

                if (_maTruong == "CTIM")
                {
                    int _siSo = 0;
                    DataServices.CoVanHocTap.GetSiSoByMaLopNamHocHocKy(dt.MaLop, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref _siSo);
                    gridViewCoVan.SetRowCellValue(pos, "SiSo", _siSo);
                }
            }

            if (_maTruong == "UFM" || _tenTruong == "Trường Đại Học Tài Chính - Marketing")
            {
                if (col.FieldName == "MaLop")
                {
                    int pos = e.RowHandle;
                    object r = gridViewCoVan.GetRow(pos);

                    CoVanHocTap dt = (CoVanHocTap)r;
                    VList<ViewLop> lop = DataServices.ViewLop.Get(String.Format("MaLop = '{0}'", dt.MaLop), "MaLop");
                    int _maxNhom = 0;
                    DataServices.ViewLop.GetMaxNhomByMaLopSinhVien(lop[0].MaLop, ref _maxNhom);
                    repositoryItemGridLookUpEditNhom.View.ActiveFilterString = String.Format("MaNhom <= '{0}'", _maxNhom);
                }
                if (col.FieldName == "Nhom")
                    repositoryItemGridLookUpEditNhom.View.ActiveFilterString = "";
            }


            if (_maTruong == "UEL")
            {
                if (col.FieldName == "MaGiangVien" || col.FieldName == "MaLop" || col.FieldName == "NgayTao" || col.FieldName == "NgayKetThuc" || col.FieldName == "SoTiet" || col.FieldName == "DanhGiaHoanThanh" || col.FieldName == "GhiChu")
                {
                    gridViewCoVan.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                    gridViewCoVan.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
                }
            }
            else
                if (col.FieldName == "MaGiangVien" || col.FieldName == "MaLop" || col.FieldName == "NgayTao" || col.FieldName == "SoTiet" || col.FieldName == "SoTien" || col.FieldName == "GhiChu" || col.FieldName == "Nhom")
                {
                    gridViewCoVan.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                    gridViewCoVan.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
                }
        }

        private void gridViewCoVan_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewCoVan, e);
        }
        #endregion

    }
}