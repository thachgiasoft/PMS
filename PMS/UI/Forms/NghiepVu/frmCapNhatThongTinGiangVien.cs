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

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmCapNhatThongTinGiangVien : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        public frmCapNhatThongTinGiangVien()
        {
            InitializeComponent();
        }

        private void frmCapNhatThongTinGiangVien_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewGiangVien, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewGiangVien, new string[] { "MaQuanLy", "HoTen", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaDonVi" }
                , new string[] { "Mã giảng viên", "Họ và tên", "Học hàm", "Học vị", "Loại giảng viên", "Đơn vị" }
                , new int[] { 90, 150, 100, 100, 100, 100 });
            AppGridView.AlignHeader(gridViewGiangVien, new string[] { "MaQuanLy", "HoTen", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewGiangVien, new string[] { "MaQuanLy", "HoTen", "MaDonVi" });
            AppGridView.RegisterControlField(gridViewGiangVien, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewGiangVien, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewGiangVien, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
            AppGridView.RegisterControlField(gridViewGiangVien, "MaDonVi", repositoryItemGridLookUpEditDonVi);
            //gridViewGiangVien.Columns["MaDonVi"].GroupIndex = 0;
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

            #region DonVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDonVi, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDonVi, new string[] { "TenBoMon" }, new string[] { "Đơn vị" });
            repositoryItemGridLookUpEditDonVi.ValueMember = "MaBoMon";
            repositoryItemGridLookUpEditDonVi.DisplayMember = "TenBoMon";
            repositoryItemGridLookUpEditDonVi.NullText = string.Empty;
            #endregion
            
            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();
            bindingSourceGiangVien.DataSource = DataServices.GiangVien.GetAll();
            bindingSourceDonVi.DataSource = DataServices.ViewKhoaBoMon.GetAll();
            gridViewGiangVien.ExpandAllGroups();
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewGiangVien.FocusedRowHandle = -1;
            string XMLData = "<Root>";
            TList<GiangVien> list = bindingSourceGiangVien.DataSource as TList<GiangVien>;
            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingSourceGiangVien.EndEdit();
                foreach (GiangVien gv in list)
                {
                    if (gv.HasDataChanged())
                    {
                        XMLData += "<GV Ma = \"" + gv.MaGiangVien.ToString()
                                            + "\" Hh = \"" + gv.MaHocHam.ToString()
                                            + "\" Hv = \"" + gv.MaHocVi.ToString()
                                            + "\" Lgv = \"" + gv.MaLoaiGiangVien.ToString()
                                            + "\" />";
                    }
                }
                XMLData += "</Root>";

                int kq = 0;
                DataServices.GiangVien.CapNhatThongTin(XMLData, ref kq);
                if (kq == 0)
                    XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }
    }
}