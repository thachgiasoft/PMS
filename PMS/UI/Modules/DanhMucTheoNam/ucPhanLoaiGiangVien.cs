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
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucPhanLoaiGiangVien : DevExpress.XtraEditors.XtraUserControl
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
        VList<ViewGiangVien> _listGiangVien = new VList<ViewGiangVien>();
        VList<ViewKhoaBoMon> _listKhoaBoMon;
        #endregion
        public ucPhanLoaiGiangVien()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri; 
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucPhanLoaiGiangVien_Load(object sender, EventArgs e)
        {
             #region Init GridView
            switch (_maTruong)
            {
                case "BUH":
                    InitGridBUH();
                    break;
                case "IUH":
                    InitGridIUH();
                    break;
                default:
                    AppGridView.InitGridView(gridViewPhanLoai, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
                    AppGridView.ShowField(gridViewPhanLoai, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "PhanLoai", "NgayCapNhat", "NguoiCapNhat" },
                                new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Học hàm", "Học vị", "Loại giảng viên", "Phân loại", "d", "u" },
                                new int[] { 90, 160, 200, 120, 120, 120, 120, 120, 99, 99 });
                    AppGridView.AlignHeader(gridViewPhanLoai, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "PhanLoai", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
                    AppGridView.ShowEditor(gridViewPhanLoai, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
                    AppGridView.RegisterControlField(gridViewPhanLoai, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
                    AppGridView.RegisterControlField(gridViewPhanLoai, "PhanLoai", repositoryItemGridLookUpEditPhanLoai);
                    AppGridView.HideField(gridViewPhanLoai, new string[] { "NgayCapNhat", "NguoiCapNhat" });

                    if (_cauHinhHeSoTheoNam.ToLower() == "true")
                    {
                        layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                        cboHocKy.EditValue = "";
                    }
                    break;
            }
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

            #region Khoa-DonVi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaBoMon", "TenBoMon", "TenCoSo" }, new string[] { "Mã khoa", "Tên khoa", "Cơ Sở" }, new int[]{80, 160, 80});
            AppGridLookupEdit.InitPopupFormSize(cboKhoaDonVi, 320, 650);
            cboKhoaDonVi.Properties.ValueMember = "MaBoMon";
            cboKhoaDonVi.Properties.DisplayMember = "TenBoMon";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 740, 650);
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Học hàm", "Học vị", "Loại giảng viên" }, new int[] { 100, 160, 120, 120, 120, 120 });
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitGrid
        void InitGridBUH()
        {
            AppGridView.InitGridView(gridViewPhanLoai, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewPhanLoai, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "PhanLoai", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Học hàm", "Học vị", "Loại giảng viên", "Phân loại", "d", "u" },
                        new int[] { 90, 160, 200, 120, 120, 120, 120, 120, 99, 99 });
            AppGridView.AlignHeader(gridViewPhanLoai, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "PhanLoai", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ShowEditor(gridViewPhanLoai, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewPhanLoai, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewPhanLoai, "PhanLoai", repositoryItemGridLookUpEditPhanLoai);
            AppGridView.HideField(gridViewPhanLoai, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                emptySpaceItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
                cboNamHoc.EditValue = "";
            }
        }

        void InitGridIUH()
        {
            AppGridView.InitGridView(gridViewPhanLoai, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewPhanLoai, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "PhanLoai", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "Mã giảng viên", "Họ tên", "Đơn vị", "Học hàm", "Học vị", "Loại giảng viên", "Phân loại", "d", "u" },
                        new int[] { 90, 160, 200, 120, 120, 120, 120, 120, 99, 99 });
            AppGridView.AlignHeader(gridViewPhanLoai, new string[] { "MaGiangVien", "HoTen", "TenDonVi", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "PhanLoai", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ShowEditor(gridViewPhanLoai, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewPhanLoai, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.RegisterControlField(gridViewPhanLoai, "PhanLoai", repositoryItemGridLookUpEditPhanLoai);
            AppGridView.HideField(gridViewPhanLoai, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }


        #endregion

        #region InitData()
        void InitData()
        {
            switch (_maTruong)
            {
                case "CDGTVT":
                    InitPhanLoaiCDGTVT();
                    break;
                case "IUH":
                    InitPhanLoaiIUH();
                    break;
                case "BUH":
                    InitPhanLoaiBUH();
                    break;
                case "HBU":
                    InitPhanLoaiBUH();
                    break;
            }
            cboKhoaDonVi.DataBindings.Clear();
            _listKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            _listKhoaBoMon.Add(new ViewKhoaBoMon() { MaBoMon = "-1", TenBoMon = "[Tất cả]", ThuTu = 0 });
            bindingSourceKhoaDonVi.DataSource = _listKhoaBoMon;
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);

            if (cboKhoaDonVi.EditValue != null)
            {
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
            }
            bindingSourceGiangVien.DataSource = _listGiangVien;

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                bindingSourcePhanLoaiGiangVien.DataSource = DataServices.ViewPhanLoaiGiangVien.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
        }
        #endregion

        #region InitPhanLoai
        void InitPhanLoaiCDGTVT()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(new DataColumn("PhanLoai"));
            tbl.Columns["PhanLoai"].Caption = "Phân loại";
            tbl.Columns.Add(new DataColumn("TenPhanLoai"));
            tbl.Columns["TenPhanLoai"].Caption = "Tên phân loại";

            DataRow r3 = tbl.NewRow();
            r3["PhanLoai"] = 3;
            r3["TenPhanLoai"] = "GV giảng dạy GDTC";
            DataRow r4 = tbl.NewRow();
            r4["PhanLoai"] = 4;
            r4["TenPhanLoai"] = "GV giảng dạy TCCN";

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

            DataRow r3 = tbl.NewRow();
            r3["PhanLoai"] = 4;
            r3["TenPhanLoai"] = "GV giảng dạy GDTC và GDQP";
            DataRow r4 = tbl.NewRow();
            r4["PhanLoai"] = 2;
            r4["TenPhanLoai"] = "GV giảng dạy trung cấp";
            DataRow r5 = tbl.NewRow();
            r5["PhanLoai"] = 3;
            r5["TenPhanLoai"] = "GV giảng dạy các môn văn hoá THPT";

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

        void InitPhanLoaiBUH()
        {

            DataTable tbl = new DataTable();
            tbl.Columns.Add(new DataColumn("PhanLoai"));
            tbl.Columns["PhanLoai"].Caption = "Phân loại";
            tbl.Columns.Add(new DataColumn("TenPhanLoai"));
            tbl.Columns["TenPhanLoai"].Caption = "Tên phân loại";

            DataRow r1 = tbl.NewRow();
            r1["PhanLoai"] = 1;
            r1["TenPhanLoai"] = "GV giảng dạy GDTC và GDQP";

            DataRow r2 = tbl.NewRow();
            r2["PhanLoai"] = 2;
            r2["TenPhanLoai"] = "Giảng viên nước ngoài";

            tbl.Rows.Add(r1);
            tbl.Rows.Add(r2);
       

            bindingSourcePhanLoai.DataSource = tbl;

            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditPhanLoai, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditPhanLoai, 300, 400);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditPhanLoai, new string[] { "PhanLoai", "TenPhanLoai" }, new string[] { "Mã phân loại", "Phân loại" }, new int[] { 90, 210 });
            repositoryItemGridLookUpEditPhanLoai.DisplayMember = "TenPhanLoai";
            repositoryItemGridLookUpEditPhanLoai.ValueMember = "PhanLoai";
            repositoryItemGridLookUpEditPhanLoai.NullText = string.Empty;
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
            AppGridView.DeleteSelectedRows(gridViewPhanLoai);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewPhanLoai.FocusedRowHandle = -1;
            VList<ViewPhanLoaiGiangVien> list = bindingSourcePhanLoaiGiangVien.DataSource as VList<ViewPhanLoaiGiangVien>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        foreach (ViewPhanLoaiGiangVien h in list)
                        {
                            xmlData += "<Input M=\"" + h.MaGiangVien
                                 + "\" P=\"" + h.PhanLoai
                                 + "\" D=\"" + h.NgayCapNhat
                                 + "\" U=\"" + h.NguoiCapNhat
                                 + "\" />";
                        }
                        xmlData = "<Root>" + xmlData + "</Root>";
                        bindingSourcePhanLoaiGiangVien.EndEdit();

                        int kq = 0;
                        DataServices.PhanLoaiGiangVien.LuuTheoKhoa(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), ref kq);

                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gridViewPhanLoai_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewPhanLoai, e);
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                bindingSourcePhanLoaiGiangVien.DataSource = DataServices.ViewPhanLoaiGiangVien.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                bindingSourcePhanLoaiGiangVien.DataSource = DataServices.ViewPhanLoaiGiangVien.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
        }

        private void gridViewPhanLoai_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVien")
            {
                ViewPhanLoaiGiangVien v = gridViewPhanLoai.GetRow(e.RowHandle) as ViewPhanLoaiGiangVien;
                ViewGiangVien gv = _listGiangVien.Find(p => p.MaGiangVien == v.MaGiangVien);
                gridViewPhanLoai.SetRowCellValue(e.RowHandle, "HoTen", gv.HoTen);
                gridViewPhanLoai.SetRowCellValue(e.RowHandle, "TenDonVi", gv.TenDonVi);
                gridViewPhanLoai.SetRowCellValue(e.RowHandle, "TenHocHam", gv.TenHocHam);
                gridViewPhanLoai.SetRowCellValue(e.RowHandle, "TenHocVi", gv.TenHocVi);
                gridViewPhanLoai.SetRowCellValue(e.RowHandle, "TenLoaiGiangVien", gv.TenLoaiGiangVien);
            }

            if (col.FieldName == "MaGiangVien" || col.FieldName == "PhanLoai")
            {
                gridViewPhanLoai.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewPhanLoai.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepPhanLoaiGiangVien"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepPhanLoaiGiangVien"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if (cboKhoaDonVi.EditValue != null)
            {
                _listGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
            }
            bindingSourceGiangVien.DataSource = _listGiangVien;

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                bindingSourcePhanLoaiGiangVien.DataSource = DataServices.ViewPhanLoaiGiangVien.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            }
        }
    }
}
