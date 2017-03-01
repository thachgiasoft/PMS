using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using DevExpress.Common.Grid;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucDinhMucGioChuanTheoNam : DevExpress.XtraEditors.XtraUserControl
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
        public ucDinhMucGioChuanTheoNam()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucDinhMucGioChuanTheoNam_Load(object sender, EventArgs e)
        {
            #region Init Gridview
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
                case "DLU":
                    InitGridDLU();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion

            #region HocHam
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocHam, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocHam, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" });
            repositoryItemGridLookUpEditHocHam.ValueMember = "MaHocHam";
            repositoryItemGridLookUpEditHocHam.DisplayMember = "TenHocHam";
            repositoryItemGridLookUpEditHocHam.NullText = string.Empty;
            #endregion

            #region HocVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocVi, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocVi, new string[] { "MaQuanLy", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" });
            repositoryItemGridLookUpEditHocVi.DisplayMember = "TenHocVi";
            repositoryItemGridLookUpEditHocVi.ValueMember = "MaHocVi";
            repositoryItemGridLookUpEditHocVi.NullText = string.Empty;
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

            #region BacLuong
            repositoryItemCheckedComboBoxEditBacLuong.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditBacLuong.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditBacLuong.Items.Clear();
            TList<BacLuong> listBacLuong = DataServices.BacLuong.GetAll();
            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            foreach (BacLuong bl in listBacLuong)
                list.Add(new CheckedListBoxItem(bl.MaBacLuong, bl.TenBacLuong, CheckState.Unchecked, true));
            repositoryItemCheckedComboBoxEditBacLuong.Items.AddRange(list.ToArray());
            repositoryItemCheckedComboBoxEditBacLuong.SeparatorChar = ';';

            #endregion

            InitData();
        }

        #region InitGridView()
        void InitGridCDGTVT()
        {
            AppGridView.InitGridView(gridViewDinhMucGioGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDinhMucGioGiang, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDinhMucGioGiang, new string[] { "Stt", "DinhMucMonHoc", "DinhMucNckh", "DinhMucHoatDongChuyenMonKhac", "TongDinhMuc", "NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "Phân loại", "Định mức giảng dạy", "Định mức NCKH", "Định mức các HĐ khác", "Tổng định mức", "NgayCapNhat", "NguoiCapNhat" },
                                                           new int[] { 200, 150, 150, 150, 120, 99, 99 });
            AppGridView.AlignHeader(gridViewDinhMucGioGiang, new string[] { "Stt", "DinhMucMonHoc", "DinhMucNckh", "DinhMucHoatDongChuyenMonKhac", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucMonHoc", repositoryItemSpinEditDinhMucMonHoc);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucNckh", repositoryItemSpinEditDinhMucNCKH);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucHoatDongChuyenMonKhac", repositoryItemSpinEditDinhMucHDKhac);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "Stt", repositoryItemGridLookUpEditPhanLoai);
            AppGridView.HideField(gridViewDinhMucGioGiang, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitGridIUH()
        {
            AppGridView.InitGridView(gridViewDinhMucGioGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDinhMucGioGiang, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDinhMucGioGiang, new string[] { "Stt", "TongDinhMuc", "NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "Phân loại", "Giờ chuẩn/năm", "NgayCapNhat", "NguoiCapNhat" },
                                                           new int[] { 200, 150, 99, 99 });
            AppGridView.AlignHeader(gridViewDinhMucGioGiang, new string[] { "Stt", "TongDinhMuc", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "Stt", repositoryItemGridLookUpEditPhanLoai);
            AppGridView.HideField(gridViewDinhMucGioGiang, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitGridVHU()
        {
          
            AppGridView.InitGridView(gridViewDinhMucGioGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDinhMucGioGiang, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDinhMucGioGiang, new string[] { "Stt", "MaHocHam", "MaBacLuong", "DinhMucMonHoc", "DinhMucNckh", "DinhMucHoatDongChuyenMonKhac", "TongDinhMuc", "NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "STT", "Học hàm", "Bậc lương", "Định mức giảng dạy", "Định mức NCKH", "Định mức các HĐ khác", "Tổng định mức", "Ngày cập nhật", "Người cập nhật" },
                                                           new int[] { 60, 120, 80, 120, 120, 150, 150, 99, 99 });
            AppGridView.AlignHeader(gridViewDinhMucGioGiang, new string[] { "Stt", "MaHocHam", "MaBacLuong", "DinhMucMonHoc", "DinhMucNckh", "DinhMucHoatDongChuyenMonKhac", "TongDinhMuc", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            //AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucMonHoc", repositoryItemSpinEditDinhMucMonHoc);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucNckh", repositoryItemSpinEditDinhMucNCKH);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaBacLuong", repositoryItemCheckedComboBoxEditBacLuong);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucHoatDongChuyenMonKhac", repositoryItemSpinEditDinhMucHDKhac);
            AppGridView.HideField(gridViewDinhMucGioGiang, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitGridLAW()
        {
            AppGridView.InitGridView(gridViewDinhMucGioGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDinhMucGioGiang, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDinhMucGioGiang, new string[] { "Stt", "MaHocHam", "MaHocVi", "HeSo", "TongDinhMuc", "DinhMucMonHoc" },
                                                           new string[] { "STT", "Học hàm", "Học vị", "Hệ số", "Tiết nghĩa vụ/năm", "Tiết nghĩa vụ /Học kỳ" },
                                                           new int[] { 60, 120, 120, 80, 150, 150 });
            AppGridView.AlignHeader(gridViewDinhMucGioGiang, new string[] { "Stt", "MaHocHam", "MaHocVi", "HeSo", "TongDinhMuc", "DinhMucMonHoc" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaHocVi", repositoryItemGridLookUpEditHocVi);

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitGridDLU()
        {
            AppGridView.InitGridView(gridViewDinhMucGioGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDinhMucGioGiang, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDinhMucGioGiang, new string[] { "Stt", "MaHocHam", "PhanLoaiGiangVien", "TuHeSoLuong", "DenHeSoLuong", "DinhMucMonHoc", "DinhMucNckh", "TongDinhMuc", "NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "STT", "Học hàm", "Nhóm giảng viên", "HS lương từ", "Đến HS lương", "Định mức giảng dạy", "Định mức NCKH", "Tổng định mức", "Ngày cập nhật", "Người cập nhật" },
                                                           new int[] { 60, 120, 250, 80, 90, 120, 120, 150, 99, 99 });
            AppGridView.AlignHeader(gridViewDinhMucGioGiang, new string[] { "Stt", "MaHocHam", "PhanLoaiGiangVien", "TuHeSoLuong", "DenHeSoLuong", "DinhMucMonHoc", "DinhMucNckh", "TongDinhMuc", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            //AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucMonHoc", repositoryItemSpinEditDinhMucMonHoc);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucNckh", repositoryItemSpinEditDinhMucNCKH);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "PhanLoaiGiangVien", repositoryItemGridLookUpEditPhanLoai);
            AppGridView.HideField(gridViewDinhMucGioGiang, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewDinhMucGioGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDinhMucGioGiang, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDinhMucGioGiang, new string[] { "MaHocHam", "MaHocVi", "DinhMucMonHoc", "DinhMucNckh", "DinhMucHoatDongChuyenMonKhac", "DinhMucMonGdtcQp", "TongDinhMuc", "NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "Học hàm", "Học vị", "Định mức giảng dạy", "Định mức NCKH", "Định mức các HĐ khác", "Định mức GDTC-QP", "Tổng định mức", "NgayCapNhat", "NguoiCapNhat" },
                                                           new int[] { 100, 100, 140, 140, 150, 150, 130, 99, 99 });
            AppGridView.AlignHeader(gridViewDinhMucGioGiang, new string[] { "MaHocHam", "MaHocVi", "DinhMucMonHoc", "DinhMucNckh", "DinhMucHoatDongChuyenMonKhac", "DinhMucMonGdtcQp", "TongDinhMuc", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucMonHoc", repositoryItemSpinEditDinhMucMonHoc);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucNckh", repositoryItemSpinEditDinhMucNCKH);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucHoatDongChuyenMonKhac", repositoryItemSpinEditDinhMucHDKhac);
            AppGridView.HideField(gridViewDinhMucGioGiang, new string[] { "NgayCapNhat", "NguoiCapNhat" });

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
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();

            switch (_maTruong)
            {
                case "CDGTVT":
                    InitPhanLoaiCDGTVT();
                    break;
                case "IUH":
                    InitPhanLoaiIUH();
                    break;
                case "DLU":
                    InitPhanLoaiDLU();
                    break;
            }

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDinhMucGioGiang.DataSource = DataServices.DinhMucGioChuan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        void InitPhanLoaiDLU()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(new DataColumn("PhanLoai"));
            tbl.Columns["PhanLoai"].Caption = "Mã nhóm GV";
            tbl.Columns.Add(new DataColumn("TenPhanLoai"));
            tbl.Columns["TenPhanLoai"].Caption = "Tên nhóm giảng viên";
            DataRow r1 = tbl.NewRow();
            r1["PhanLoai"] = 1;
            r1["TenPhanLoai"] = "Giảng viên giảng các môn học bình thường";
            DataRow r2 = tbl.NewRow();
            r2["PhanLoai"] = 2;
            r2["TenPhanLoai"] = "Giảng viên giảng dạy các môn GDTC, QP-AN";

            tbl.Rows.Add(r1);
            tbl.Rows.Add(r2);

            bindingSourcePhanLoai.DataSource = tbl;

            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditPhanLoai, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditPhanLoai, 300, 400);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditPhanLoai, new string[] { "PhanLoai", "TenPhanLoai" }, new string[] { "Mã phân loại", "Phân loại" }, new int[] { 90, 210 });
            repositoryItemGridLookUpEditPhanLoai.DisplayMember = "TenPhanLoai";
            repositoryItemGridLookUpEditPhanLoai.ValueMember = "PhanLoai";
            repositoryItemGridLookUpEditPhanLoai.NullText = "";
        }

        void InitPhanLoaiCDGTVT()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(new DataColumn("PhanLoai"));
            tbl.Columns["PhanLoai"].Caption = "Phân loại";
            tbl.Columns.Add(new DataColumn("TenPhanLoai"));
            tbl.Columns["TenPhanLoai"].Caption = "Tên phân loại";
            DataRow r1 = tbl.NewRow();
            r1["PhanLoai"] = 1;
            r1["TenPhanLoai"] ="Giảng viên chuyên trách";
            DataRow r2 = tbl.NewRow();
            r2["PhanLoai"] = 2;
            r2["TenPhanLoai"] = "Giảng viên kiêm nhiệm";
            DataRow r3 = tbl.NewRow();
            r3["PhanLoai"] = 3;
            r3["TenPhanLoai"] = "GV giảng dạy GDTC";
            DataRow r4 = tbl.NewRow();
            r4["PhanLoai"] = 4;
            r4["TenPhanLoai"] = "GV giảng dạy TCCN";

            tbl.Rows.Add(r1);
            tbl.Rows.Add(r2);
            tbl.Rows.Add(r3);
            tbl.Rows.Add(r4);

            bindingSourcePhanLoai.DataSource = tbl;

            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditPhanLoai, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditPhanLoai, 300, 400);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditPhanLoai, new string[] { "PhanLoai", "TenPhanLoai" }, new string[] { "Mã phân loại", "Phân loại" }, new int[] { 90, 210 });
            repositoryItemGridLookUpEditPhanLoai.DisplayMember = "TenPhanLoai";
            repositoryItemGridLookUpEditPhanLoai.ValueMember = "PhanLoai";
            repositoryItemGridLookUpEditPhanLoai.NullText = "";
        }

        void InitPhanLoaiIUH()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(new DataColumn("PhanLoai"));
            tbl.Columns["PhanLoai"].Caption = "Phân loại";
            tbl.Columns.Add(new DataColumn("TenPhanLoai"));
            tbl.Columns["TenPhanLoai"].Caption = "Tên phân loại";

            DataRow r1 = tbl.NewRow();
            r1["PhanLoai"] = 1;
            r1["TenPhanLoai"] = "GV giảng dạy đại học, cao đẳng";
            DataRow r3 = tbl.NewRow();
            r3["PhanLoai"] = 4;
            r3["TenPhanLoai"] = "GV giảng dạy GDTC và GDQP";
            DataRow r4 = tbl.NewRow();
            r4["PhanLoai"] = 2;
            r4["TenPhanLoai"] = "GV giảng dạy trung cấp";
            DataRow r5 = tbl.NewRow();
            r5["PhanLoai"] = 3;
            r5["TenPhanLoai"] = "GV giảng dạy các môn văn hoá THPT";

            tbl.Rows.Add(r1);
            tbl.Rows.Add(r4);
            tbl.Rows.Add(r3);
            tbl.Rows.Add(r5);

            bindingSourcePhanLoai.DataSource = tbl;

            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditPhanLoai, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditPhanLoai, 300, 400);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditPhanLoai, new string[] { "PhanLoai", "TenPhanLoai" }, new string[] { "Mã phân loại", "Phân loại" }, new int[] { 90, 210 });
            repositoryItemGridLookUpEditPhanLoai.DisplayMember = "TenPhanLoai";
            repositoryItemGridLookUpEditPhanLoai.ValueMember = "PhanLoai";
            repositoryItemGridLookUpEditPhanLoai.NullText = "";
        }
        #endregion

        #region Event button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDinhMucGioGiang);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewDinhMucGioGiang.FocusedRowHandle = -1;
            TList<DinhMucGioChuan> list = bindingSourceDinhMucGioGiang.DataSource as TList<DinhMucGioChuan>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (DinhMucGioChuan d in list)
                            {
                                d.NamHoc = cboNamHoc.EditValue.ToString();
                                d.HocKy = cboHocKy.EditValue.ToString();
                            }
                            bindingSourceDinhMucGioGiang.EndEdit();
                            DataServices.DinhMucGioChuan.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    InitData();
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void gridViewDinhMucGioGiang_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDinhMucGioGiang, e);
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDinhMucGioGiang.DataSource = DataServices.DinhMucGioChuan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDinhMucGioGiang.DataSource = DataServices.DinhMucGioChuan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void gridViewDinhMucGioGiang_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (_maTruong != "LAW")
            {
                if (col.FieldName == "MaHocHam" || col.FieldName == "MaHocVi" || col.FieldName == "DinhMucMonHoc" || col.FieldName == "DinhMucNckh" 
                    || col.FieldName == "DinhMucHoatDongChuyenMonKhac" || col.FieldName == "TongDinhMuc"
                    || col.FieldName == "PhanLoaiGiangVien" || col.FieldName == "TuHeSoLuong" || col.FieldName == "DenHeSoLuong")
                {
                    int pos = e.RowHandle;
                    gridViewDinhMucGioGiang.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    gridViewDinhMucGioGiang.SetRowCellValue(pos, "NguoiCapNhat", UserInfo.UserName);
                }

                if (col.FieldName == "DinhMucMonHoc" || col.FieldName == "DinhMucNckh" || col.FieldName == "DinhMucHoatDongChuyenMonKhac")
                {
                    int pos = e.RowHandle;
                    DinhMucGioChuan d = gridViewDinhMucGioGiang.GetRow(pos) as DinhMucGioChuan;
                    int? sum = IsNull(d.DinhMucMonHoc) + IsNull(d.DinhMucNckh) + IsNull(d.DinhMucHoatDongChuyenMonKhac);
                    gridViewDinhMucGioGiang.SetRowCellValue(pos, "TongDinhMuc", sum);
                }
            }

            if (_maTruong == "LAW" && col.FieldName == "TongDinhMuc")
            {
                DinhMucGioChuan d = gridViewDinhMucGioGiang.GetRow(e.RowHandle) as DinhMucGioChuan;
                int? _DinhMucMonHoc = IsNull(d.TongDinhMuc) / 2;
                gridViewDinhMucGioGiang.SetRowCellValue(e.RowHandle, "DinhMucMonHoc", _DinhMucMonHoc);
            }
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepDinhMucGioChuan"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepDinhMucGioChuan"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }

        int? IsNull(int? a)
        {
            if (a == null)
                return 0;
            else
                return a;
        }
    }
}
