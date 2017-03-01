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

namespace PMS.UI.Forms.NghiepVu.ChucNangCon
{
    public partial class frmChonDonGia : DevExpress.XtraEditors.XtraForm
    {
        string _NamHoc;
        public decimal? _donGia;
        public frmChonDonGia()
        {
            InitializeComponent();
        }

        public frmChonDonGia(string namHoc)
        {
            InitializeComponent();
            _NamHoc = namHoc;
        }

        private void frmChonDonGia_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewDonGia, false, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewDonGia, new string[] { "MaLoaiGiangVien", "MaHocHam", "MaHocVi", "DonGia" }
                        , new string[] { "Loại giảng viên", "Học hàm", "Học vị", "Đơn giá" }
                        , new int[] { 150, 150, 150, 150 });
            AppGridView.AlignHeader(gridViewDonGia, new string[] { "MaLoaiGiangVien", "MaHocHam", "MaHocVi", "DonGia" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDonGia, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
            AppGridView.RegisterControlField(gridViewDonGia, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewDonGia, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewDonGia, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.FormatDataField(gridViewDonGia, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewDonGia);
            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _NamHoc;
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
            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceDonGia.DataSource = DataServices.DonGia.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), "");
        }
        #endregion

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceDonGia.DataSource = DataServices.DonGia.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), "");
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DonGia d = gridViewDonGia.GetFocusedRow() as DonGia;
            if (d != null)
            {
                _donGia = d.DonGia;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn hệ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridControlDonGia_DoubleClick(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hi = gridViewDonGia.CalcHitInfo((sender as Control).PointToClient(Control.MousePosition));

            if (hi.RowHandle >= 0)
            {
                DonGia d = gridViewDonGia.GetRow(hi.RowHandle) as DonGia;
                _donGia = d.DonGia;

                this.Close();
            }
        }
    }
}