           using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities;
using DevExpress.XtraEditors;
using PMS.Core;
using PMS.Entities.Validation;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucHeSoLopDongTheoNam : DevExpress.XtraEditors.XtraUserControl
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
        VList<ViewHocKy> _listHocKy;
        #endregion

        public ucHeSoLopDongTheoNam()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucHeSoLopDongTheoNam_Load(object sender, EventArgs e)
        {
            #region InitGridView
            switch (_maTruong)
            {
                case "CDGTVT":
                    InitGridCDGTVT();
                    break;
                case "IUH":
                    InitGridIUH();
                    break;
                case "VHU":
                    InitGridVHU();
                    break;
                case "LAW":
                    InitGridLAW();
                    break;
                case "HBU":
                    InitGridHBU();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion
            #region BacDaoTao
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditBacDaoTao, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditBacDaoTao, new string[] { "TenBacDaoTao" }, new string[] { "Tên bậc đào tạo" });
            repositoryItemGridLookUpEditBacDaoTao.DisplayMember = "TenBacDaoTao";
            repositoryItemGridLookUpEditBacDaoTao.ValueMember = "MaBacDaoTao";
            repositoryItemGridLookUpEditBacDaoTao.NullText = string.Empty;
            #endregion
            #region NhomMonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomMonHoc, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomMonHoc, new string[] { "MaQuanLy", "TenNhomMon" }, new string[] { "Mã nhóm môn học", "Tên nhóm môn học" });
            repositoryItemGridLookUpEditNhomMonHoc.DisplayMember = "TenNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.ValueMember = "MaNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.NullText = string.Empty;
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

            InitData();
        }

        #region Init GridView
        void InitGridCDGTVT()
        {
            AppGridView.InitGridView(gridViewHeSoLopDong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoLopDong, new string[] { "MaBacDaoTao", "MaNhomMonHoc", "TuKhoan", "DenKhoan", "HeSo", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "Bậc đào tạo", "Nhóm môn học", "Từ khoản", "Đến khoản", "Hệ số", "ngày cập nhật", "Người cập nhật" },
                        new int[] { 200, 250, 90, 90, 80, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSoLopDong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoLopDong, new string[] { "MaBacDaoTao", "MaNhomMonHoc", "TuKhoan", "DenKhoan", "HeSo", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaNhomMonHoc", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "TuKhoan", repositoryItemSpinEditTuKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "DenKhoan", repositoryItemSpinEditDenKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaBacDaoTao", repositoryItemCheckedComboBoxEditBacDaoTao);
            AppGridView.HideField(gridViewHeSoLopDong, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitGridIUH()
        {
            AppGridView.InitGridView(gridViewHeSoLopDong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoLopDong, new string[] { "MaBacDaoTao", "MaNhomMonHoc", "MaLoaiKhoiLuong", "TuKhoan", "DenKhoan", "HeSo", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "Bậc đào tạo", "Nhóm môn học", "Loại khối lượng", "Từ khoản", "Đến khoản", "Hệ số", "ngày cập nhật", "Người cập nhật" },
                        new int[] { 150, 150, 120, 90, 90, 80, 150, 150, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSoLopDong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoLopDong, new string[] { "MaBacDaoTao", "MaNhomMonHoc", "MaLoaiKhoiLuong", "TuKhoan", "DenKhoan", "HeSo" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaNhomMonHoc", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "TuKhoan", repositoryItemSpinEditTuKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "DenKhoan", repositoryItemSpinEditDenKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaBacDaoTao", repositoryItemCheckedComboBoxEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaLoaiKhoiLuong", repositoryItemCheckedComboBoxEditLoaiKhoiLuong);
            AppGridView.HideField(gridViewHeSoLopDong, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewHeSoLopDong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoLopDong, new string[] { "Stt", "MaNhomMonHoc", "TuKhoan", "DenKhoan", "HeSo", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "STT", "Nhóm môn học", "Từ khoản", "Đến khoản", "Hệ số", "Ngày cập nhật", "Người cập nhật" },
                        new int[] { 80, 150, 90, 90, 80, 150, 150 });
            AppGridView.ShowEditor(gridViewHeSoLopDong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoLopDong, new string[] { "Stt", "MaNhomMonHoc", "TuKhoan", "DenKhoan", "HeSo", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaNhomMonHoc", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "TuKhoan", repositoryItemSpinEditTuKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "DenKhoan", repositoryItemSpinEditDenKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "HeSo", repositoryItemSpinEditHeSo);
       
     
            AppGridView.HideField(gridViewHeSoLopDong, new string[] { "NgayCapNhat", "NguoiCapNhat" });


            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitGridLAW()
        {
            AppGridView.InitGridView(gridViewHeSoLopDong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoLopDong, new string[] { "MaQuanLy", "MaBacDaoTao", "LoaiLop", "MaNhomMonHoc", "TuKhoan", "DenKhoan", "HeSo" },
                        new string[] { "Mã HSLD", "Bậc đào tạo", "Loại lớp", "Nhóm môn học", "Từ khoản", "Đến khoản", "Hệ số" },
                        new int[] { 80, 150, 150, 150, 90, 90, 80 });
            AppGridView.ShowEditor(gridViewHeSoLopDong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoLopDong, new string[] { "MaQuanLy", "MaBacDaoTao", "LoaiLop", "MaNhomMonHoc", "TuKhoan", "DenKhoan", "HeSo" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaNhomMonHoc", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "TuKhoan", repositoryItemSpinEditTuKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "DenKhoan", repositoryItemSpinEditDenKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "HeSo", repositoryItemSpinEditHeSo);
            //AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaBacDaoTao", repositoryItemGridLookUpEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaBacDaoTao", repositoryItemCheckedComboBoxEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "LoaiLop", repositoryItemCheckedComboBoxEditLoaiLop);
         
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitGridHBU()
        {
            AppGridView.InitGridView(gridViewHeSoLopDong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoLopDong, new string[] { "MaNhomMonHoc", "TuKhoan", "DenKhoan", "HeSo", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "Nhóm môn học", "Từ khoản", "Đến khoản", "Hệ số", "Ngày cập nhật", "Người cập nhật" },
                        new int[] { 250, 90, 90, 80, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSoLopDong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoLopDong, new string[] { "MaNhomMonHoc", "TuKhoan", "DenKhoan", "HeSo", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaNhomMonHoc", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "TuKhoan", repositoryItemSpinEditTuKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "DenKhoan", repositoryItemSpinEditDenKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.HideField(gridViewHeSoLopDong, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewHeSoLopDong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoLopDong, new string[] { "MaQuanLy", "MaBacDaoTao", "MaNhomMonHoc", "HocKyApDung", "TuKhoan", "DenKhoan", "HeSo", "NgayBdApDung", "NgayKtApDung", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "Mã HSLD", "Bậc đào tạo", "Nhóm môn học", "Học kỳ áp dụng", "Từ khoản", "Đến khoản", "Hệ số", "Ngày BD áp dụng", "Ngày KT áp dụng", "ngày cập nhật", "Người cập nhật" },
                        new int[] { 80, 150, 150, 120, 90, 90, 80, 150, 150, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSoLopDong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoLopDong, new string[] { "MaQuanLy", "MaBacDaoTao", "MaNhomMonHoc", "HocKyApDung", "TuKhoan", "DenKhoan", "HeSo", "NgayBdApDung", "NgayKtApDung" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaNhomMonHoc", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "TuKhoan", repositoryItemSpinEditTuKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "DenKhoan", repositoryItemSpinEditDenKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "HocKyApDung", repositoryItemCheckedComboBoxEditHocKyApDung);
            //AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaBacDaoTao", repositoryItemGridLookUpEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaBacDaoTao", repositoryItemCheckedComboBoxEditBacDaoTao);
            AppGridView.HideField(gridViewHeSoLopDong, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            if (_maTruong != "LAW")
                AppGridView.HideField(gridViewHeSoLopDong, new string[] { "NgayBdApDung", "NgayKtApDung" });
            if (_maTruong == "TCB" || _maTruong == "USSH")
                AppGridView.HideField(gridViewHeSoLopDong, new string[] { "MaQuanLy", "MaBacDaoTao", "MaNhomMonHoc", "NgayBdApDung", "NgayKtApDung" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }
        #endregion

        #region InitData
        void InitLoaiLop()
        {
            repositoryItemCheckedComboBoxEditLoaiLop.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditLoaiLop.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditLoaiLop.Items.Clear();

            TList<LoaiLop> _vListLoaiLop = new TList<LoaiLop>();
            _vListLoaiLop = DataServices.LoaiLop.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (LoaiLop v in _vListLoaiLop)
            {
                _list.Add(new CheckedListBoxItem(v.Id, v.TenLoaiLop, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditLoaiLop.Items.AddRange(_list.ToArray());
            repositoryItemCheckedComboBoxEditLoaiLop.SeparatorChar = ';';
        }

        private void InitData()
        {
            InitLoaiLop();

            bindingSourceNhomMonHoc.DataSource = DataServices.NhomMonHoc.GetAll();
            //bindingSourceBacDaoTao.DataSource = DataServices.ViewBacDaoTao.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
           
            bindingSourceLoaiCongViec.DataSource = DataServices.HeSoCongViec.GetAll();

            #region BacDaoTao
            VList<ViewBacDaoTao> _listBacDaoTao = DataServices.ViewBacDaoTao.GetAll();
            repositoryItemCheckedComboBoxEditBacDaoTao.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditBacDaoTao.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.Clear();
            List<CheckedListBoxItem> listBac = new List<CheckedListBoxItem>();
            foreach (ViewBacDaoTao v in _listBacDaoTao)
                listBac.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.TenBacDaoTao, CheckState.Unchecked, true));
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.AddRange(listBac.ToArray());
            repositoryItemCheckedComboBoxEditBacDaoTao.SeparatorChar = ';';
            #endregion

            #region LoaiKhoiLuong
            TList<LoaiKhoiLuong> _listLoaiKhoiLuong = DataServices.LoaiKhoiLuong.GetAll();
            repositoryItemCheckedComboBoxEditLoaiKhoiLuong.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditLoaiKhoiLuong.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditLoaiKhoiLuong.Items.Clear();
            List<CheckedListBoxItem> listLoai = new List<CheckedListBoxItem>();
            foreach (LoaiKhoiLuong v in _listLoaiKhoiLuong)
                listLoai.Add(new CheckedListBoxItem(v.MaLoaiKhoiLuong, v.TenLoaiKhoiLuong, CheckState.Unchecked, true));
            repositoryItemCheckedComboBoxEditLoaiKhoiLuong.Items.AddRange(listLoai.ToArray());
            repositoryItemCheckedComboBoxEditLoaiKhoiLuong.SeparatorChar = ';';
            #endregion
            
            if (cboNamHoc.EditValue != null)
            {
                _listHocKy = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                bindingSourceHocKy.DataSource = _listHocKy;
                #region HocKyApDung
                repositoryItemCheckedComboBoxEditHocKyApDung.SelectAllItemCaption = "Tất cả";
                repositoryItemCheckedComboBoxEditHocKyApDung.TextEditStyle = TextEditStyles.Standard;
                repositoryItemCheckedComboBoxEditHocKyApDung.Items.Clear();

                List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
                foreach (ViewHocKy dr in _listHocKy)
                    list.Add(new CheckedListBoxItem(dr.MaHocKy, dr.TenHocKy, CheckState.Unchecked, true));
                repositoryItemCheckedComboBoxEditHocKyApDung.Items.AddRange(list.ToArray());
                repositoryItemCheckedComboBoxEditHocKyApDung.SeparatorChar = ';';
                #endregion
            }
            if (cboNamHoc.EditValue != null && (cboHocKy.EditValue != null || _cauHinhHeSoTheoNam.ToLower() == "true"))
                bindingSourceHeSoLopDong.DataSource = DataServices.HeSoLopDong.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion

        private void btnLamtuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoLopDong);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoLopDong.FocusedRowHandle = -1;
            TList<HeSoLopDong> list = bindingSourceHeSoLopDong.DataSource as TList<HeSoLopDong>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (HeSoLopDong hs in list)
                            {
                                hs.NamHoc = cboNamHoc.EditValue.ToString();
                                if (_cauHinhHeSoTheoNam.ToLower() == "true")
                                    hs.HocKy = "";
                                else
                                    hs.HocKy = cboHocKy.EditValue.ToString();
                            }
                            bindingSourceHeSoLopDong.EndEdit();
                            DataServices.HeSoLopDong.Save(list);
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

        private void gridViewHeSoLopDong_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoLopDong, e);
        }

        private void gridViewHeSoLopDong_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHeSoLopDong, e);
        }

        private void gridViewHeSoLopDong_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //HeSoLopDong obj = e.Row as HeSoLopDong;
            //if (obj != null)
            //{
            //    obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaQuanLy");
            //    if (obj.IsValid)
            //        e.Valid = true;
            //    else
            //    {
            //        XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        e.Valid = false;
            //    }
            //}
        }

        //private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        //{
        //    HeSoLopDong obj = target as HeSoLopDong;
        //    if (obj != null)
        //    {
        //        if (((TList<HeSoLopDong>)bindingSourceHeSoLopDong.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
        //        {
        //            e.Description = string.Format("Mã quy đổi {0} hiện tại đã có.", obj.MaQuanLy);
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        private void gridViewHeSoLopDong_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    sf.ShowDialog();
                    if (sf.FileName != "")
                    {
                        gridControlHeSoLopDong.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && (cboHocKy.EditValue != null || _cauHinhHeSoTheoNam.ToLower() == "true"))
                bindingSourceHeSoLopDong.DataSource = DataServices.HeSoLopDong.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && (cboHocKy.EditValue != null || _cauHinhHeSoTheoNam.ToLower() == "true"))
                bindingSourceHeSoLopDong.DataSource = DataServices.HeSoLopDong.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void gridViewHeSoLopDong_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaQuanLy" || col.FieldName == "MaBacDaoTao" || col.FieldName == "MaNhomMonHoc" || col.FieldName == "TuKhoan" || col.FieldName == "DenKhoan" || col.FieldName == "HeSo" || col.FieldName == "NgayBdApDung" || col.FieldName == "NgayKtApDung")
            {
                gridViewHeSoLopDong.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewHeSoLopDong.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void btnSapChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepHeSoLopDong"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepHeSoLopDong"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }
    }
}
