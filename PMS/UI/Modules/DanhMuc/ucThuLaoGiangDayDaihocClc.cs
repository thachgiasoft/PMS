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
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucThuLaoGiangDayDaihocClc : DevExpress.XtraEditors.XtraUserControl
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

        public ucThuLaoGiangDayDaihocClc()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void ucThuLaoGiangDayDaihocClc_Load(object sender, EventArgs e)
        {
            #region Init Gridview
            switch (_maTruong)
            {
               
                case "VHU":
                    InitGridVHU();
                    break;
                default:
                    InitRemaining();
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

            #region HocHam
            AppRepositoryItemGridLookUpEdit. InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocHam, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocHam, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" });
            repositoryItemGridLookUpEditHocHam.ValueMember = "MaHocHam";
            repositoryItemGridLookUpEditHocHam.DisplayMember = "TenHocHam";
            repositoryItemGridLookUpEditHocHam.NullText = string.Empty;
            #endregion

            #region HocVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocVi, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocVi, new string[] { "MaQuanLy", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" });
            repositoryItemGridLookUpEditHocVi.ValueMember = "MaHocVi";
            repositoryItemGridLookUpEditHocVi.DisplayMember = "TenHocVi";
            repositoryItemGridLookUpEditHocVi.NullText = string.Empty;
            #endregion

            #region HocVi cbb
            repositoryItemCheckedComboBoxEditHocVi.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditHocVi.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditHocVi.Items.Clear();
            TList<HocVi> listHocVi = DataServices.HocVi.GetAll();
            List<CheckedListBoxItem> listhv = new List<CheckedListBoxItem>();
            foreach (HocVi hv in listHocVi)
                listhv.Add(new CheckedListBoxItem(hv.MaHocVi, hv.TenHocVi, CheckState.Unchecked, true));
            repositoryItemCheckedComboBoxEditHocVi.Items.AddRange(listhv.ToArray());
            repositoryItemCheckedComboBoxEditHocVi.SeparatorChar = ';';
            #endregion

            #region NhomMonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomMonHoc, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomMonHoc, new string[] { "MaQuanLy", "TenNhomMon" }, new string[] { "Mã nhóm môn", "Tên nhóm môn" });
            repositoryItemGridLookUpEditNhomMonHoc.ValueMember = "MaNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.DisplayMember = "TenNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.NullText = string.Empty;
            #endregion

            InitPhanLoaiGV();
            
            InitData();

        }

        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewThuLaoGiangDayClc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewThuLaoGiangDayClc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewThuLaoGiangDayClc, new string[] { "Stt", "PhanLoaiGiangVien", "MaNhomMon", "MaHocHam", "MaHocVi", "DonGia", "NguoiCapNhat", "NgayCapNhat" },
                                                           new string[] { "STT", "Phân loại giảng viên", "Nhóm môn", "Học hàm", "Học vị", "Đơn giá", "Người cập nhật", "Ngày cập nhật" },
                                                           new int[] { 60, 350, 170, 100, 100, 110, 100, 100 });
            AppGridView.AlignHeader(gridViewThuLaoGiangDayClc, new string[] { "Stt", "PhanLoaiGiangVien", "MaNhomMon", "MaHocHam", "MaHocVi", "DonGia", "NguoiCapNhat", "NgayCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.FormatDataField(gridViewThuLaoGiangDayClc, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewThuLaoGiangDayClc, "MaNhomMon", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.RegisterControlField(gridViewThuLaoGiangDayClc, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewThuLaoGiangDayClc, "MaHocVi", repositoryItemCheckedComboBoxEditHocVi);
            AppGridView.RegisterControlField(gridViewThuLaoGiangDayClc, "PhanLoaiGiangVien", repositoryItemGridLookUpEditPhanLoaiGiangVien);
            AppGridView.HideField(gridViewThuLaoGiangDayClc, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewThuLaoGiangDayClc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewThuLaoGiangDayClc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewThuLaoGiangDayClc, new string[] { "Stt", "PhanLoaiGiangVien", "MaNhomMon", "MaHocHam", "MaHocVi", "DonGia", "NguoiCapNhat", "NgayCapNhat" },
                                                           new string[] { "STT", "Phân loại giảng viên", "Nhóm môn", "Học hàm", "Học vị", "Đơn giá", "Người cập nhật", "Ngày cập nhật" },
                                                           new int[] { 60, 350, 170, 100, 100, 110, 100, 100 });
            AppGridView.AlignHeader(gridViewThuLaoGiangDayClc, new string[] { "Stt", "PhanLoaiGiangVien", "MaNhomMon", "MaHocHam", "MaHocVi", "DonGia", "NguoiCapNhat", "NgayCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.FormatDataField(gridViewThuLaoGiangDayClc, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewThuLaoGiangDayClc, "MaNhomMon", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.RegisterControlField(gridViewThuLaoGiangDayClc, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewThuLaoGiangDayClc, "MaHocVi", repositoryItemCheckedComboBoxEditHocVi);
            AppGridView.RegisterControlField(gridViewThuLaoGiangDayClc, "PhanLoaiGiangVien", repositoryItemGridLookUpEditPhanLoaiGiangVien);
            AppGridView.HideField(gridViewThuLaoGiangDayClc, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }

        void InitPhanLoaiGV()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(new DataColumn("PhanLoaiGiangVien"));
            tbl.Columns["PhanLoaiGiangVien"].Caption = "Phân loại giảng viên";
            tbl.Columns.Add(new DataColumn("TenPhanLoai"));
            tbl.Columns["TenPhanLoai"].Caption = "Tên phân loại";

            DataRow r0 = tbl.NewRow();
            r0["PhanLoaiGiangVien"] = 1;
            r0["TenPhanLoai"] = "Giảng viên Việt Nam";

            DataRow r1 = tbl.NewRow();
            r1["PhanLoaiGiangVien"] = 2;
            r1["TenPhanLoai"] = "Giảng viên Nước ngoài";

            DataRow r2 = tbl.NewRow();
            r2["PhanLoaiGiangVien"] = 3;
            r2["TenPhanLoai"] = "Thực hành tại phòng máy";

            tbl.Rows.Add(r0);
            tbl.Rows.Add(r1);
            tbl.Rows.Add(r2);

            bindingSourcePhanLoaiGiangVien.DataSource = tbl;

            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditPhanLoaiGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditPhanLoaiGiangVien, 350, 400);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditPhanLoaiGiangVien, new string[] { "PhanLoaiGiangVien", "TenPhanLoai" }, new string[] { "Mã phân loại GV", "Phân loại giảng viên" }, new int[] { 90, 210 });
            repositoryItemGridLookUpEditPhanLoaiGiangVien.DisplayMember = "TenPhanLoai";
            repositoryItemGridLookUpEditPhanLoaiGiangVien.ValueMember = "PhanLoaiGiangVien";
            repositoryItemGridLookUpEditPhanLoaiGiangVien.NullText = "";

        }

        void InitData()
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceNhomMonHoc.DataSource = DataServices.NhomMonHoc.GetAll();
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceThuLaoGiangDayClc.DataSource = DataServices.ThuLaoGiangDayDaiHocLopClc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        
            switch (_maTruong)
            {
                case "VHU":
                    InitPhanLoaiGV();
                    break;
                
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitData();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewThuLaoGiangDayClc);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThuLaoGiangDayClc.FocusedRowHandle = -1;
            TList<ThuLaoGiangDayDaiHocLopClc> list = bindingSourceThuLaoGiangDayClc.DataSource as TList<ThuLaoGiangDayDaiHocLopClc>;
            if (list != null)
            {
                foreach (ThuLaoGiangDayDaiHocLopClc t in list)
                {
                    t.NgayCapNhat = DateTime.Now;
                    t.NguoiCapNhat = UserInfo.UserName;
                }

                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (ThuLaoGiangDayDaiHocLopClc d in list)
                            {
                                d.NamHoc = cboNamHoc.EditValue.ToString();
                                d.HocKy = cboHocKy.EditValue.ToString();
                            }

                            bindingSourceThuLaoGiangDayClc.EndEdit();
                            DataServices.ThuLaoGiangDayDaiHocLopClc.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceThuLaoGiangDayClc.DataSource = DataServices.ThuLaoGiangDayDaiHocLopClc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceThuLaoGiangDayClc.DataSource = DataServices.ThuLaoGiangDayDaiHocLopClc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepThuLaoGiangDayDaiHocClc"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepThuLaoGiangDayDaiHocClc"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }
    }
}
