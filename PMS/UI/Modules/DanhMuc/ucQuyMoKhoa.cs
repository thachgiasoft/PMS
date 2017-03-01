using System;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities.Validation;
using PMS.Core;
using PMS.Services;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucQuyMoKhoa : XtraUserControl
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
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion

        #region Event Form
        public ucQuyMoKhoa()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucQuyMoKhoa_Load(object sender, EventArgs e)
        {
            #region Init GridView LoaiKhoiLuong
            AppGridView.InitGridView(gridViewLoaiKhoiLuong, true, true, GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewLoaiKhoiLuong, new string[] { "MaKhoa", "IdQuyMo", "GhiChu" },
                new string[] { "Tên khoa - Đơn vị", "Quy mô", "Ghi chú" },
                new int[] { 250, 350, 200 });
            AppGridView.RegisterControlField(gridViewLoaiKhoiLuong, "MaKhoa", repositoryItemGridLookUpEditKhoa);
            AppGridView.RegisterControlField(gridViewLoaiKhoiLuong, "IdQuyMo", repositoryItemGridLookUpEditQuyMo);
            AppGridView.ReadOnlyColumn(gridViewLoaiKhoiLuong, new string[] { "MaKhoa" });
            #endregion

            #region RepositoryItemGridLookUpEdit QuyMo
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditQuyMo, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditQuyMo, new string[] { "MaQuyMo", "TenQuyMo" }, new string[] { "Mã quy mô", "Tên quy mô" });
            repositoryItemGridLookUpEditQuyMo.ValueMember = "Id";
            repositoryItemGridLookUpEditQuyMo.DisplayMember = "TenQuyMo";
            repositoryItemGridLookUpEditQuyMo.NullText = string.Empty;
            repositoryItemGridLookUpEditQuyMo.BestFitMode = BestFitMode.BestFit;
            #endregion

            #region RepositoryItemGridLookUpEdit Khoa
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditKhoa, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditKhoa, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" });
            repositoryItemGridLookUpEditKhoa.ValueMember = "MaKhoa";
            repositoryItemGridLookUpEditKhoa.DisplayMember = "TenKhoa";
            repositoryItemGridLookUpEditKhoa.NullText = string.Empty;
            repositoryItemGridLookUpEditKhoa.BestFitMode = BestFitMode.BestFit;
            #endregion


            #region Init Datasource
            InitData();
            //PMS.Common.Globals.LoadLayout(Tag as AppModule, new object[] { gridViewLoaiKhoiLuong, barManager1, layoutControl1 });
            #endregion
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceQuyMoKhoa.DataSource = DataServices.QuyMoKhoa.GetQuyMoKhoa();
            bindingSourceDanhMucQuyMo.DataSource = DataServices.DanhMucQuyMo.GetAll();
            bindingSourceKhoa.DataSource = DataServices.ViewKhoa.GetAll();
        }
        #endregion

        #region Event Button
     
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewLoaiKhoiLuong.FocusedRowHandle = -1;
            TList<QuyMoKhoa> list = bindingSourceQuyMoKhoa.DataSource as TList<QuyMoKhoa>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceQuyMoKhoa.EndEdit();
                            DataServices.QuyMoKhoa.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewLoaiKhoiLuong, barManager1, layoutControl1 });
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

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewLoaiKhoiLuong);
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlLoaiKhoiLuong.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
        #endregion

        #region Event Grid

        private void gridViewLoaiKhoiLuong_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewLoaiKhoiLuong, e);
        }

        private void gridViewLoaiKhoiLuong_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewLoaiKhoiLuong, e);
        }
        #endregion
    }
}