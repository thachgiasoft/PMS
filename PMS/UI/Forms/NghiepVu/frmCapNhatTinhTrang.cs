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
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmCapNhatTinhTrang : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion
        #region Variable
        TList<LoaiGiangVien> _listLoaiGiangVien;
        VList<ViewKhoa> _listKhoa;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion
        #region Event Form
        public frmCapNhatTinhTrang()
        {
            InitializeComponent();
        }

        private void frmCapNhatTinhTrang_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewGiangVien, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewGiangVien, new string[] { "TenDonVi", "MaQuanLy", "Ho", "Ten", "TenLoaiGiangVien", "MaTinhTrang", "NgayCapNhat", "NguoiCapNhat", "MaGiangVien" }
                , new string[] { "Khoa - đơn vị", "Mã giảng viên", "Họ", "Tên", "Loại giảng viên", "Tình trạng", "Ngày cập nhật", "Người cập nhật", "Mã giảng viên" }
                , new int[] { 99, 90, 140, 70, 180, 180, 99, 99, 99 });
            AppGridView.AlignHeader(gridViewGiangVien, new string[] { "TenDonVi", "MaQuanLy", "Ho", "Ten", "TenLoaiGiangVien", "MaTinhTrang", "NgayCapNhat", "NguoiCapNhat", "MaGiangVien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewGiangVien, new string[] { "NgayCapNhat", "NguoiCapNhat", "MaGiangVien" });
            AppGridView.RegisterControlField(gridViewGiangVien, "MaTinhTrang", repositoryItemGridLookUpEditTinhTrang);
            gridViewGiangVien.Columns["TenDonVi"].GroupIndex = 0;
            #endregion

            #region TinhTrang
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditTinhTrang, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditTinhTrang, new string[] { "MaQuanLy", "TenTinhTrang" }, new string[] { "Mã tình trạng", "Tên tình trạng" }, new int[] { 100, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditTinhTrang, 300, 400);
            repositoryItemGridLookUpEditTinhTrang.ValueMember = "MaTinhTrang";
            repositoryItemGridLookUpEditTinhTrang.DisplayMember = "TenTinhTrang";
            repositoryItemGridLookUpEditTinhTrang.NullText = string.Empty;
            #endregion
            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region _khoaDonVi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã Khoa - Đơn vị", "Tên Khoa - Đơn vị" });
            cboKhoaDonVi.Properties.ValueMember = "MaKhoa";
            cboKhoaDonVi.Properties.DisplayMember = "TenKhoa";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion

            #region LoaiGiangVien
            AppGridLookupEdit.InitGridLookUp(cboLoaiGiangVien, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiGiangVien, new string[] { "MaQuanLy", "TenLoaiGiangVien" }, new string[] { "Mã loại giảng viên", "Tên loại giảng viên" });
            cboLoaiGiangVien.Properties.ValueMember = "MaLoaiGiangVien";
            cboLoaiGiangVien.Properties.DisplayMember = "TenLoaiGiangVien";
            cboLoaiGiangVien.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion
        #region InitData
        void InitData()
        {
            bindingSourceTinhTrang.DataSource = DataServices.TinhTrang.GetAll();

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            cboLoaiGiangVien.DataBindings.Clear();
            _listLoaiGiangVien = new TList<LoaiGiangVien>();
            _listLoaiGiangVien = DataServices.LoaiGiangVien.GetAll();
            _listLoaiGiangVien.Add(new LoaiGiangVien { MaLoaiGiangVien = -1, TenLoaiGiangVien = "[Tất cả]", MaQuanLy = "-1", ThuTu = 0 });
            _listLoaiGiangVien.Sort("ThuTu");
            bindingSourceLoaiGiangVien.DataSource = _listLoaiGiangVien;
            cboLoaiGiangVien.DataBindings.Add("EditValue", bindingSourceLoaiGiangVien, "MaLoaiGiangVien", true, DataSourceUpdateMode.OnPropertyChanged);

            cboKhoaDonVi.DataBindings.Clear();
            _listKhoa = new VList<ViewKhoa>();
            _listKhoa = DataServices.ViewKhoa.GetAll();
            _listKhoa.Add(new ViewKhoa { MaKhoa = "-1", TenKhoa = "[Tất cả]", ThuTu = -1 });
            _listKhoa.Sort("ThuTu");
            bindingSourceKhoaDonVi.DataSource = _listKhoa;
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);

            LoadDataSource();
        }

        void LoadDataSource()
        {
            try
            {
                if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboLoaiGiangVien.EditValue != null && cboKhoaDonVi.EditValue != null)
                {
                    DataTable tbl = new DataTable();
                    IDataReader reader = DataServices.TinhTrangTheoNamHoc.GetByNamHocHocKyDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), int.Parse(cboLoaiGiangVien.EditValue.ToString()));
                    tbl.Load(reader);

                    tbl.Columns["MaTinhTrang"].ReadOnly = false;

                    bindingSourceGiangVien.DataSource = tbl;
                    gridViewGiangVien.ExpandAllGroups();
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

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewGiangVien.FocusedRowHandle = -1;
            DataTable tb = bindingSourceGiangVien.DataSource as DataTable;

            if (tb != null)
            {
                string XMLData = "<Root>";
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bindingSourceGiangVien.EndEdit();
                        foreach (DataRow gv in tb.Rows)
                        {
                            if (gv.RowState == DataRowState.Modified)
                            {
                                XMLData += "<Input M = \"" + gv["MaGiangVien"]
                                                    + "\" T = \"" + gv["MaTinhTrang"]
                                                    + "\" D = \"" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
                                                    + "\" U = \"" + UserInfo.UserName
                                                    + "\" />";
                            }
                        }
                        XMLData += "</Root>";

                        int kq = 0;
                        DataServices.TinhTrangTheoNamHoc.Luu(XMLData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    { XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                LoadDataSource();
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            LoadDataSource();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void cboLoaiGiangVien_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataSource();
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepTinhTrang"))
            {
                frm.ShowDialog();
            }
            LoadDataSource();
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
                        gridControlGiangVien.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }
    }
}