using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities;
using PMS.BLL;
using PMS.Entities.Validation;
using DevExpress.XtraGrid.Columns;
using PMS.Services;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucDonGiaTheoNam : DevExpress.XtraEditors.XtraUserControl
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
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        #endregion
        public ucDonGiaTheoNam()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucDonGiaTheoNam_Load(object sender, EventArgs e)
        {
            #region Init GridView
            switch (_maTruong)
            { 
                case "IUH":
                    InitIUH();
                    break;
                case "CDGTVT":
                    InitCDGTVT();
                    break;
                case "UEL":
                    InitUEL();
                    break;
                case "VHU":
                    InitVHU();
                    break;
                case "HBU":
                    InitHBU();
                    break;
                case "LAW": 
                    InitGridLAW();
                    break;
                case "DLU":
                    InitDLU();
                    break;
                default:
                    InitRemaining();
                    break;
            }
          
            #endregion

            #region NgonNguGiangDay
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNgonNguGiangDay, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNgonNguGiangDay, new string[] { "MaNgonNgu", "TenNgonNgu" }, new string[] { "Mã ngôn ngữ", "Tên ngôn ngữ" }, new int[] { 150, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditNgonNguGiangDay, 350, 400);
            repositoryItemGridLookUpEditNgonNguGiangDay.ValueMember = "MaNgonNgu";
            repositoryItemGridLookUpEditNgonNguGiangDay.DisplayMember = "TenNgonNgu";
            repositoryItemGridLookUpEditNgonNguGiangDay.NullText = string.Empty;
            #endregion

            #region BacDaoTao
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditBacDaoTao, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditBacDaoTao, new string[] { "MaBacDaoTao", "TenBacDaoTao" }, new string[] { "Mã bậc đào tạo", "Tên bậc đào tạo" }, new int[] { 100, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditBacDaoTao, 300, 400);
            repositoryItemGridLookUpEditBacDaoTao.ValueMember = "MaBacDaoTao";
            repositoryItemGridLookUpEditBacDaoTao.DisplayMember = "TenBacDaoTao";
            repositoryItemGridLookUpEditBacDaoTao.NullText = string.Empty;
            #endregion

            #region Check CBO BacDaoTao
            repositoryItemCheckedComboBoxEditBacDaoTao.SelectAllItemCaption = "";
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.Clear();
            repositoryItemCheckedComboBoxEditBacDaoTao.SeparatorChar = ';';
            repositoryItemCheckedComboBoxEditBacDaoTao.TextEditStyle = TextEditStyles.Standard;
            VList<ViewBacDaoTao> _Tlist = DataServices.ViewBacDaoTao.GetAll();
            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            foreach (ViewBacDaoTao v in _Tlist)
            {
                list.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.TenBacDaoTao, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.AddRange(list.ToArray());
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
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

            #region LoaiGiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLoaiGiangVien, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLoaiGiangVien, new string[] { "MaQuanLy", "TenLoaiGiangVien" }, new string[] { "Mã loại giảng viên", "Tên loại giảng viên" }, new int[] { 150, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditLoaiGiangVien, 350, 400);
            repositoryItemGridLookUpEditLoaiGiangVien.ValueMember = "MaLoaiGiangVien";
            repositoryItemGridLookUpEditLoaiGiangVien.DisplayMember = "TenLoaiGiangVien";
            repositoryItemGridLookUpEditLoaiGiangVien.NullText = string.Empty;
            #endregion

            #region HocHam
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocHam, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocHam, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" }, new int[] { 100, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditHocHam, 300, 400);
            repositoryItemGridLookUpEditHocHam.ValueMember = "MaHocHam";
            repositoryItemGridLookUpEditHocHam.DisplayMember = "TenHocHam";
            repositoryItemGridLookUpEditHocHam.NullText = string.Empty;
            #endregion

            #region HocVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocVi, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocVi, new string[] { "MaQuanLy", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" }, new int[] { 100, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditHocVi, 300, 400);
            repositoryItemGridLookUpEditHocVi.ValueMember = "MaHocVi";
            repositoryItemGridLookUpEditHocVi.DisplayMember = "TenHocVi";
            repositoryItemGridLookUpEditHocVi.NullText = string.Empty;
            #endregion

            #region VaiTro
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditVaiTro, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditVaiTro, new string[] { "MaVaiTro", "TenVaiTro" }, new string[] { "Mã vai trò", "Tên vai trò" }, new int[] { 100, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditVaiTro, 300, 400);
            repositoryItemGridLookUpEditVaiTro.ValueMember = "MaVaiTro";
            repositoryItemGridLookUpEditVaiTro.DisplayMember = "TenVaiTro";
            repositoryItemGridLookUpEditVaiTro.NullText = string.Empty;

            DataTable tblVaiTro = new DataTable();
            tblVaiTro.Columns.Add("MaVaiTro", typeof(String));
            tblVaiTro.Columns.Add("TenVaiTro", typeof(String));
            DataRow r = tblVaiTro.NewRow();
            r["MaVaiTro"] = "1";
            r["TenVaiTro"] = "Giảng chính";
            DataRow r2 = tblVaiTro.NewRow();
            r2["MaVaiTro"] = "2";
            r2["TenVaiTro"] = "Trợ giảng";
            tblVaiTro.Rows.Add(r);
            tblVaiTro.Rows.Add(r2);

            bindingSourceVaiTro.DataSource = tblVaiTro;
            #endregion

            #region NhomMonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryGridLookupEditNhomMon, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryGridLookupEditNhomMon, new string[] { "MaNhomMon", "TenNhomMon" }, new string[] { "Mã nhóm môn", "Tên nhóm môn" }, new int[] { 100, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryGridLookupEditNhomMon, 300, 400);
            repositoryGridLookupEditNhomMon.ValueMember = "MaNhomMon";
            repositoryGridLookupEditNhomMon.DisplayMember = "TenNhomMon";
            repositoryGridLookupEditNhomMon.NullText = string.Empty;
            #endregion


            #region Check CBO NhomMonHoc
            repositoryItemCheckedComboBoxEditNhomMonHoc.SelectAllItemCaption = "";
            repositoryItemCheckedComboBoxEditNhomMonHoc.Items.Clear();
            repositoryItemCheckedComboBoxEditNhomMonHoc.SeparatorChar = ';';
            repositoryItemCheckedComboBoxEditNhomMonHoc.TextEditStyle = TextEditStyles.Standard;
            TList<NhomMonHoc> _listNhomMonHoc = DataServices.NhomMonHoc.GetAll();
            List<CheckedListBoxItem> listNhomMon = new List<CheckedListBoxItem>();
            foreach (NhomMonHoc v in _listNhomMonHoc)
            {
                listNhomMon.Add(new CheckedListBoxItem(v.MaNhomMon, v.TenNhomMon, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditNhomMonHoc.Items.AddRange(listNhomMon.ToArray());
            #endregion

            InitData();
        }

        #region InitGridView
        void InitIUH()
        {
            AppGridView.InitGridView(gridViewDonGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDonGia, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDonGia, new string[] { "MaLoaiGiangVien", "MaHocHam", "MaHocVi", "DonGia", "NgayCapNhat", "NguoiCapNhat" }
                        , new string[] { "Loại giảng viên", "Học hàm", "Học vị", "Đơn giá", "NgayCapNhat", "NguoiCapNhat" }
                        , new int[] { 150, 150, 150, 150, 99, 99 });
            AppGridView.AlignHeader(gridViewDonGia, new string[] { "MaLoaiGiangVien", "MaHocHam", "MaHocVi", "DonGia", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDonGia, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
            AppGridView.RegisterControlField(gridViewDonGia, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewDonGia, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewDonGia, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.FormatDataField(gridViewDonGia, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewDonGia, new string[] { "NgayCapNhat", "NguoiCapNhat" });
 
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitCDGTVT()
        {
            AppGridView.InitGridView(gridViewDonGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDonGia, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDonGia, new string[] { "BacDaoTao", "MaLoaiGiangVien", "MaHocHam", "MaHocVi", "DonGia", "NgayCapNhat", "NguoiCapNhat" }
                        , new string[] { "Bậc đào tạo", "Loại giảng viên", "Học hàm", "Học vị", "Đơn giá", "NgayCapNhat", "NguoiCapNhat" }
                        , new int[] { 150, 120, 120, 120, 100, 99, 99 });
            AppGridView.AlignHeader(gridViewDonGia, new string[] { "BacDaoTao", "MaLoaiGiangVien", "MaHocHam", "MaHocVi", "DonGia", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDonGia, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.RegisterControlField(gridViewDonGia, "BacDaoTao", repositoryItemGridLookUpEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewDonGia, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
            AppGridView.RegisterControlField(gridViewDonGia, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewDonGia, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.FormatDataField(gridViewDonGia, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewDonGia, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitUEL()
        {
            AppGridView.InitGridView(gridViewDonGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDonGia, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDonGia, new string[] { "MaQuanLy", "BacDaoTao", "NgonNguGiangDay", "DonGia", "NgayCapNhat", "NguoiCapNhat" }
                        , new string[] { "Vai trò giảng dạy", "Bậc đào tạo", "Ngôn ngữ giảng dạy", "Đơn giá", "NgayCapNhat", "NguoiCapNhat" }
                        , new int[] { 120, 120, 120, 100, 99, 99 });
            AppGridView.AlignHeader(gridViewDonGia, new string[] { "MaQuanLy", "BacDaoTao", "NgonNguGiangDay", "DonGia", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDonGia, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.RegisterControlField(gridViewDonGia, "BacDaoTao", repositoryItemGridLookUpEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewDonGia, "NgonNguGiangDay", repositoryItemGridLookUpEditNgonNguGiangDay);
            AppGridView.RegisterControlField(gridViewDonGia, "MaQuanLy", repositoryItemGridLookUpEditVaiTro);
            AppGridView.FormatDataField(gridViewDonGia, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");

            AppGridView.HideField(gridViewDonGia, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }

        void InitVHU()
        {
            AppGridView.InitGridView(gridViewDonGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDonGia, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDonGia, new string[] { "MaLoaiGiangVien", "DonGia", "NgayCapNhat", "NguoiCapNhat" }
                        , new string[] { "Loại giảng viên", "Đơn giá", "NgayCapNhat", "NguoiCapNhat" }
                        , new int[] { 150, 100, 99, 99 });
            AppGridView.AlignHeader(gridViewDonGia, new string[] { "MaLoaiGiangVien", "DonGia", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDonGia, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.RegisterControlField(gridViewDonGia, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
            AppGridView.FormatDataField(gridViewDonGia, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewDonGia, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitGridLAW()
        {
            AppGridView.InitGridView(gridViewDonGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDonGia, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDonGia, new string[] { "DonGia" }
                        , new string[] { "Đơn giá" }
                        , new int[] { 120 });
            AppGridView.AlignHeader(gridViewDonGia, new string[] { "DonGia" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDonGia, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.FormatDataField(gridViewDonGia, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitDLU()
        {
            AppGridView.InitGridView(gridViewDonGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDonGia, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDonGia, new string[] { "MaHocHam", "MaHocVi", "BacDaoTao", "MaLoaiGiangVien", "NhomMonHoc", "DonGia", "NgayCapNhat", "NguoiCapNhat" }
                        , new string[] { "Học hàm", "Học vị", "Bậc đào tạo", "Loại giảng viên", "Nhóm môn học", "Đơn giá", "NgayCapNhat", "NguoiCapNhat" }
                        , new int[] { 120, 120, 120, 120, 120, 120, 100, 99, 99 });
            AppGridView.AlignHeader(gridViewDonGia, new string[] { "MaHocHam", "MaHocVi", "BacDaoTao", "MaLoaiGiangVien", "NhomMonHoc", "DonGia", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewDonGia, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.RegisterControlField(gridViewDonGia, "BacDaoTao", repositoryItemCheckedComboBoxEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewDonGia, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
            AppGridView.RegisterControlField(gridViewDonGia, "NhomMonHoc", repositoryGridLookupEditNhomMon);
            AppGridView.RegisterControlField(gridViewDonGia, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewDonGia, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.FormatDataField(gridViewDonGia, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewDonGia, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewDonGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDonGia, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDonGia, new string[] { "MaQuanLy", "BacDaoTao", "NgonNguGiangDay", "DonGia", "NgayCapNhat", "NguoiCapNhat" }
                        , new string[] { "Mã quản lý", "Bậc đào tạo", "Ngôn ngữ giảng dạy", "Đơn giá", "NgayCapNhat", "NguoiCapNhat" }
                        , new int[] { 100, 120, 120, 100, 99, 99 });
            AppGridView.AlignHeader(gridViewDonGia, new string[] { "MaQuanLy", "BacDaoTao", "NgonNguGiangDay", "DonGia", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDonGia, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.RegisterControlField(gridViewDonGia, "BacDaoTao", repositoryItemGridLookUpEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewDonGia, "NgonNguGiangDay", repositoryItemGridLookUpEditNgonNguGiangDay);
            AppGridView.FormatDataField(gridViewDonGia, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewDonGia, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitHBU()
        {
            AppGridView.InitGridView(gridViewDonGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDonGia, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDonGia, new string[] { "BacDaoTao", "DonGia", "DonGiaClc", "NgayCapNhat", "NguoiCapNhat" }
                        , new string[] { "Bậc đào tạo", "Đơn giá", "Đơn giá chất lượng cao", "NgayCapNhat", "NguoiCapNhat" }
                        , new int[] {150, 150, 200, 99, 99 });
            AppGridView.AlignHeader(gridViewDonGia, new string[] { "BacDaoTao", "DonGia", "DonGiaClc", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDonGia, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.RegisterControlField(gridViewDonGia, "BacDaoTao", repositoryItemGridLookUpEditBacDaoTao);
            AppGridView.FormatDataField(gridViewDonGia, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewDonGia, "DonGiaClc", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewDonGia, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();
            if (_maTruong == "DLU")
                InitNhomMonHocDLU();
            else
                bindingSourceNhomMon.DataSource = DataServices.NhomMonHoc.GetAll();

            bindingSourceBacDaoTao.DataSource = DataServices.ViewBacDaoTao.GetAll();
            bindingSourceNgonNguGiangDay.DataSource = DataServices.NgonNguGiangDay.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDonGia.DataSource = DataServices.DonGia.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        void InitNhomMonHocDLU()
        {
            TList<NhomMonHoc> _nhomMonHocDLU = new TList<NhomMonHoc>();
            _nhomMonHocDLU.Add(new NhomMonHoc() { MaNhomMon = 1, MaQuanLy = "PC", TenNhomMon = "Nhóm môn Giáo dục thể chất" });
            _nhomMonHocDLU.Add(new NhomMonHoc() { MaNhomMon = 2, MaQuanLy = "NC", TenNhomMon = "Nhóm môn học bình thường" });
            bindingSourceNhomMon.DataSource = _nhomMonHocDLU;
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGia);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewDonGia.FocusedRowHandle = -1;
            TList<DonGia> list = bindingSourceDonGia.DataSource as TList<DonGia>;
            if (list != null)
            {
                foreach (DonGia d in list)

                {
                    d.NamHoc = cboNamHoc.EditValue.ToString();
                    d.HocKy = cboHocKy.EditValue.ToString();
                    //d.NgayCapNhat = DateTime.Now;
                    //d.NguoiCapNhat = UserInfo.UserName;
                }
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceDonGia.EndEdit();
                            DataServices.DonGia.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
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
                        gridControlDonGia.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepDonGia"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepDonGia"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }
        #endregion

        #region Event Grid
        private void gridViewDonGia_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGia, e);
        }

        private void gridViewDonGia_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridViewDonGia_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaQuanLy" || col.FieldName == "MaLoaiGiangVien" || col.FieldName == "MaHocHam" || col.FieldName == "MaHocVi" || col.FieldName == "DonGia" || col.FieldName == "HeSoQuyDoiChatLuong")
            {
                int pos = e.RowHandle;
                gridViewDonGia.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewDonGia.SetRowCellValue(pos, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDonGia.DataSource = DataServices.DonGia.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDonGia.DataSource = DataServices.DonGia.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion

    }
}
