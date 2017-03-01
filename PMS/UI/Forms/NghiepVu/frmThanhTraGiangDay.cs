using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Core;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.BaoCao;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmThanhTraGiangDay : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btn_Luu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btn_Luu.ShortCut = Shortcut.None;

                btn_Xoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btn_Xoa.ShortCut = Shortcut.None;
            }
            else
            {
                btn_Luu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btn_Xoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion
        public GiangVien objgv;
        
        public VList<ViewThongTinGiangVien> list = DataServices.ViewThongTinGiangVien.GetAll();
         
        public frmThanhTraGiangDay()
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

        private void frmThanhTraGiangDay_Load(object sender, EventArgs e)
        {
            #region Tu ngay - Den ngay
            DateTime dateBD = DateTime.Today;
            DateTime firstDayOfThisMonth = dateBD.Subtract(TimeSpan.FromDays(dateBD.Day - 1));
            DateTime firstDayOfNextMonth = firstDayOfThisMonth.AddMonths(1);
            DateTime lastDayOfThisMonth = firstDayOfNextMonth.Subtract(TimeSpan.FromDays(1));

            dateEditTuNgay.EditValue = firstDayOfThisMonth;
            dateEditTuNgay.DateTime = firstDayOfThisMonth;
            dateEditTuNgay.ShowPopup();

            dateEditDenNgay.EditValue = lastDayOfThisMonth;
            dateEditDenNgay.DateTime = lastDayOfThisMonth;
            dateEditDenNgay.ShowPopup();
            #endregion
            
            #region Init GridView Thanh tra giang day
            AppGridView.InitGridView(gridViewThanhTraGiangDay, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewThanhTraGiangDay, new string[] { "MaQuanLy", "MaHienThi", "Khoa", "LoaiGiangVien", "TenHocPhan", "TinhHinhGhiNhan", "MaHinhThucViPham", "Ngay", "Tiet", "Lop", "Phong", "ThoiDiemGhiNhan", "LyDo", "GhiChu", "DaBaoSuaTkb" },
                new string[] { "Họ tên", "Mã giảng viên", "Phòng/Khoa", "Loại GV", "Tên HP", "Tình hình ghi nhận", "Hình thức vi phạm", "Ngày", "Tiết", "Lớp", "Phòng", "Thời điểm", "Lý do vi phạm", "Ghi chú", "Đã báo sửa TKB" },
                new int[] { 120, 100, 60, 50, 80, 180, 120, 80, 50, 50, 50, 50, 90, 70, 110 });
            AppGridView.ShowEditor(gridViewThanhTraGiangDay, NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewThanhTraGiangDay, "MaQuanLy", repositoryItemGridLookUpEdit1);
            AppGridView.RegisterControlField(gridViewThanhTraGiangDay, "MaHinhThucViPham", repositoryItemGridLookUpEditHinhThucViPham);
            
            #endregion

            #region Init Khoa - don vi
            AppGridLookupEdit.InitGridLookUp(gridLookUpEditDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(gridLookUpEditDonVi, 650, 300);
            AppGridLookupEdit.ShowField(gridLookUpEditDonVi, new string[] { "MaKhoa", "TenKhoa", "MaBoMon", "TenBoMon" }, new string[] { "Mã khoa", "Tên khoa", "Mã bộ môn", "Tên bộ môn" }, new int[] { 90, 210, 90, 210 });
            gridLookUpEditDonVi.Properties.DisplayMember = "TenBoMon";
            gridLookUpEditDonVi.Properties.ValueMember = "MaBoMon";
            gridLookUpEditDonVi.Properties.NullText = string.Empty;
            #endregion
            //bindingSourceThanhTraGiangDay.DataSource = DataServices.ThanhTraGiangDay.GetByTuNgayDenNgay(dateEditTuNgay.DateTime.Date, dateEditDenNgay.DateTime.Date);
            
            #region Giang Vien
            //repositoryItemGridLookUpEdit1.ValidateOnEnterKey = true;
            //repositoryItemGridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //repositoryItemGridLookUpEdit1.PopupFormSize = new System.Drawing.Size(600, 500);
            //bindingSourceGiangVien.DataSource = DataServices.ViewThongTinGiangVien.GetAll();
            //repositoryItemGridLookUpEdit1.DataSource = bindingSourceGiangVien.DataSource;
            //AppRepositoryItemGridLookUpEdit.HideField(repositoryItemGridLookUpEdit1, new string[] { "MaQuanLy", "HoTen","MaKhoa","TenKhoa", "TenBoMon", "NgaySinh", "GioiTinh", "DienThoai", "Email", "NoiSinh", "MatKhau" }); //, "TenBoMon", "NgaySinh", "GioiTinh", "DienThoai", "Email", "NoiSinh", "MatKhau"
            //AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEdit1, new string[] { "MaQuanLy", "HoTen", "TenBoMon" }, new string[] { "Mã giảng viên", "Họ tên", "Bộ môn" });
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEdit1, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEdit1, new string[] { "MaQuanLy", "HoTen", "TenBoMon", "MaTinhTrang" }, new string[] { "Mã giảng viên", "Họ tên", "Bộ môn", "Mã cuộc đời" }, new int[] { 100, 200, 200, 100 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEdit1, 500, 400);
            repositoryItemGridLookUpEdit1.DisplayMember = "HoTen";
            repositoryItemGridLookUpEdit1.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEdit1.NullText = "";
            bindingSourceGiangVien.DataSource = DataServices.ViewThongTinGiangVien.GetAll();
            repositoryItemGridLookUpEdit1.DataSource = bindingSourceGiangVien.DataSource;
            #endregion

            #region Init HinhThucViPham
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHinhThucViPham, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHinhThucViPham, new string[] { "MaQuanLy", "TenHinhThucViPham" }, new string[] { "Mã quản lý", "Tên hình thức vi phạm" }, new int[]{ 100, 400 });
            repositoryItemGridLookUpEditHinhThucViPham.DisplayMember = "TenHinhThucViPham";
            repositoryItemGridLookUpEditHinhThucViPham.ValueMember = "Oid";
            repositoryItemGridLookUpEditHinhThucViPham.NullText = string.Empty;
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditHinhThucViPham, 500, 400);
            bindingSourceHinhThucViPham.DataSource = DataServices.ViewHinhThucViPham.GetAll();
            #endregion

            #region Init Datasource
            repositoryItemGridLookUpEdit1.ValueMember = "MaQuanLy";
            repositoryItemGridLookUpEdit1.DisplayMember = "HoTen";

            VList<ViewKhoaBoMon> vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            bindingSourceDonVi.DataSource = vListKhoaBoMon.Copy();
            vListKhoaBoMon.Insert(0, new ViewKhoaBoMon() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]", MaBoMon = "-1", TenBoMon = "[Tất cả]" });
            bindingSourceDonVi.DataSource = vListKhoaBoMon;
            gridLookUpEditDonVi.DataBindings.Clear();
            gridLookUpEditDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            btn_Loc.PerformClick();

        }

        private void btn_Luu_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewThanhTraGiangDay.FocusedRowHandle = -1;
            TList<ThanhTraGiangDay> list = bindingSourceThanhTraGiangDay.DataSource as TList<ThanhTraGiangDay>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceThanhTraGiangDay.EndEdit();
                            DataServices.ThanhTraGiangDay.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewThanhTraGiangDay, barManager1, layoutControl1 });
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

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            ViewKhoaBoMon objkhoa = bindingSourceDonVi.Current as ViewKhoaBoMon;
            if (dateEditTuNgay.DateTime == DateTime.MinValue || dateEditTuNgay.DateTime == DateTime.MaxValue)
            {
                XtraMessageBox.Show("Bạn chưa chọn từ ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateEditTuNgay.Focus();
                return;
            }
            if (dateEditDenNgay.DateTime == DateTime.MinValue || dateEditDenNgay.DateTime == DateTime.MaxValue)
            {
                XtraMessageBox.Show("Bạn chưa chọn đến ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateEditDenNgay.Focus();
                return;
            }
            bindingSourceThanhTraGiangDay.DataSource = DataServices.ThanhTraGiangDay.GetByTuNgayDenNgayMaDonVi(dateEditTuNgay.DateTime.Date, dateEditDenNgay.DateTime.Date,objkhoa.MaBoMon);
            bindingSourceThanhTraGiangDayClone.DataSource = DataServices.ViewThanhTraGiangDay.GetByTuNgayDenNgayMaDonVi(dateEditTuNgay.DateTime.Date, dateEditDenNgay.DateTime.Date, objkhoa.MaBoMon);
        }

        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewThanhTraGiangDay);
        }

        private void btn_Phuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ThanhTraGiangDay obj = gridViewThanhTraGiangDay.GetFocusedRow() as ThanhTraGiangDay;
            if (obj != null)
            {
                if (obj.EntityState == EntityState.Changed)
                    obj.CancelChanges();
                else
                    RestoreDeletedItems();
            }
            else
                RestoreDeletedItems();
            gridViewThanhTraGiangDay.RefreshData();
        }
        private void RestoreDeletedItems()
        {
            TList<ThanhTraGiangDay> list = bindingSourceThanhTraGiangDay.DataSource as TList<ThanhTraGiangDay>;
            if (list != null)
            {
                if (list.DeletedItems.Count > 0)
                {
                    foreach (ThanhTraGiangDay c in list.DeletedItems)
                    {
                        c.EntityState = EntityState.Changed;
                        list.Add(c);
                        list.DeletedItems.Remove(c);
                        break;
                    }
                }
            }
        }

        private void btn_Lamtuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ViewKhoaBoMon objkhoa = bindingSourceDonVi.Current as ViewKhoaBoMon;
            if (dateEditTuNgay.DateTime == DateTime.MinValue || dateEditTuNgay.DateTime == DateTime.MaxValue)
            {
                XtraMessageBox.Show("Bạn chưa chọn từ ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateEditTuNgay.Focus();
                return;
            }
            if (dateEditDenNgay.DateTime == DateTime.MinValue || dateEditDenNgay.DateTime == DateTime.MaxValue)
            {
                XtraMessageBox.Show("Bạn chưa chọn đến ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateEditDenNgay.Focus();
                return;
            }
            bindingSourceThanhTraGiangDay.DataSource = DataServices.ThanhTraGiangDay.GetByTuNgayDenNgayMaDonVi(dateEditTuNgay.DateTime.Date, dateEditDenNgay.DateTime.Date, objkhoa.MaBoMon);
            bindingSourceThanhTraGiangDayClone.DataSource = DataServices.ViewThanhTraGiangDay.GetByTuNgayDenNgayMaDonVi(dateEditTuNgay.DateTime.Date, dateEditDenNgay.DateTime.Date, objkhoa.MaBoMon);
            #region Init Datasource
            //bindingSourceThanhTraGiangDay.DataSource = DataServices.ThanhTraGiangDay.GetAll();
            //bindingSourceGiangVien.DataSource = DataServices.ViewThongTinGiangVien.GetAll();
            //bindingSourceHinhThucViPham.DataSource = DataServices.ViewHinhThucViPham.GetAll();
            #endregion
        }


        private void btn_TongHopTinhHinhGD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dateEditTuNgay.DateTime == DateTime.MinValue || dateEditTuNgay.DateTime == DateTime.MaxValue)
            {
                XtraMessageBox.Show("Bạn chưa chọn từ ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateEditTuNgay.Focus();
                return;
            }
            if (dateEditDenNgay.DateTime == DateTime.MinValue || dateEditDenNgay.DateTime == DateTime.MaxValue)
            {
                XtraMessageBox.Show("Bạn chưa chọn đến ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateEditDenNgay.Focus();
                return;
            }
            //TList<ThanhTraGiangDay> list = bindingSourceThanhTraGiangDayClone.DataSource as TList<ThanhTraGiangDay>;
            VList<ViewThanhTraGiangDay> tlist = bindingSourceThanhTraGiangDayClone.DataSource as VList<ViewThanhTraGiangDay>;
            if (tlist != null)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InBangThanhTraTinhHinhGiangDay(PMS.Common.Globals._cauhinh.TenTruong, UserInfo.FullName, dateEditTuNgay.DateTime.ToShortDateString(), dateEditDenNgay.DateTime.ToShortDateString(), tlist);
                    frm.ShowDialog();
                }
            }
        }

        private void btn_InPhieuKiemTraHangNgay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmBaoCao frm = new frmBaoCao())
            {
                frm.InPhieuKiemTraHangNgay(PMS.Common.Globals._cauhinh.TenTruong);
                frm.ShowDialog();
            }
        }

        private void gridViewThanhTraGiangDay_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaQuanLy")
            {
                int pos = e.RowHandle;
                object r = gridViewThanhTraGiangDay.GetRow(pos);
                ThanhTraGiangDay o = (ThanhTraGiangDay)r;

                VList<ViewThongTinGiangVien> listgv = DataServices.ViewThongTinGiangVien.GetByMaQuanLy(o.MaQuanLy);
                string magiangvien = "";
                string khoa = "";
                string maloaigiangvien = "";
                string loaigiangvien = "";

                if (listgv.Count>0)
                {
                    magiangvien = listgv[0].MaQuanLy;
                    khoa = listgv[0].MaBoMon;
                    TList<GiangVien> objgv = DataServices.GiangVien.GetByMaQuanLy(listgv[0].MaQuanLy);
                    maloaigiangvien = objgv[0].MaLoaiGiangVien.ToString();

                    switch (maloaigiangvien)
                    {
                        case "1": loaigiangvien = "BC"; break;
                        case "2": loaigiangvien = "HĐ"; break;
                        case "3": loaigiangvien = "TG"; break;
                        case "4": loaigiangvien = "GV.TV"; break;
                        case "5": loaigiangvien = "NV.VTH"; break;
                        case "6": loaigiangvien = "NV.TH"; break;
                        case "7": loaigiangvien = "NV.TV"; break;
                    }
                }
                gridViewThanhTraGiangDay.SetRowCellValue(pos, "MaHienThi", magiangvien);
                gridViewThanhTraGiangDay.SetRowCellValue(pos, "Khoa", khoa);
                gridViewThanhTraGiangDay.SetRowCellValue(pos, "LoaiGiangVien", loaigiangvien);
            }
           
        }

        private void repositoryItemGridLookUpEdit1_Popup(object sender, EventArgs e)
        {
            //if (gridViewThanhTraGiangDay.ActiveEditor != null && gridViewThanhTraGiangDay.ActiveEditor is GridLookUpEdit)
            //{
            //    GridLookUpEdit rGrid = (GridLookUpEdit)gridViewThanhTraGiangDay.ActiveEditor;

            //    rGrid.Properties.View.ActiveFilterString = "MaTinhTrang <> 12 and MaTinhTrang <> 14";
            //}
        }

    }
}