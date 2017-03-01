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
using DevExpress.XtraEditors.Controls;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoQuyDoiGioChuan : DevExpress.XtraEditors.XtraUserControl
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

        #region Event Form
        public ucHeSoQuyDoiGioChuan()
        {
            InitializeComponent();
        }

        private void ucHeSoQuyDoiGioChuan_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewHeSoQuyDoi, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoQuyDoi, new string[] { "BacDaoTao", "NhomKhoiLuong", "LoaiHinhDaoTao", "HinhThucDaoTao", "MaHocHam", "MaHocVi", "NgonNguGiangDay", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }
                                                       , new string[] { "Bậc đào tạo", "Nhóm khối lượng", "Loại hình đào tạo", "Hình thức đào tạo", "Học hàm", "Học vị", "Ngôn ngữ giảng dạy", "Hệ số", "Ghi chú", "Ngày cập nhật", "Người cập nhật" }
                                                       , new int[] { 90, 100, 100, 110, 80, 80, 120, 80, 150, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSoQuyDoi, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoQuyDoi, new string[] { "BacDaoTao", "NhomKhoiLuong", "LoaiHinhDaoTao", "HinhThucDaoTao", "MaHocHam", "MaHocVi", "NgonNguGiangDay", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.HideField(gridViewHeSoQuyDoi, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.RegisterControlField(gridViewHeSoQuyDoi, "BacDaoTao", repositoryItemCheckedComboBoxEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewHeSoQuyDoi, "NhomKhoiLuong", repositoryItemGridLookUpEditNhomKhoiLuong);
            AppGridView.RegisterControlField(gridViewHeSoQuyDoi, "LoaiHinhDaoTao", repositoryItemCheckedComboBoxEditLoaiHinhDaoTao);
            AppGridView.RegisterControlField(gridViewHeSoQuyDoi, "HinhThucDaoTao", repositoryItemCheckedComboBoxEditHinhThucDaoTao);
            AppGridView.RegisterControlField(gridViewHeSoQuyDoi, "MaHocHam", repositoryItemCheckedComboBoxEditHocHam);
            AppGridView.RegisterControlField(gridViewHeSoQuyDoi, "MaHocVi", repositoryItemCheckedComboBoxEditHocVi);
            AppGridView.RegisterControlField(gridViewHeSoQuyDoi, "NgonNguGiangDay", repositoryItemCheckedComboBoxEditNgonNguGiangDay);
            #endregion

            InitData();
        }
        #endregion

        #region InitData()
        void InitData()
        {
            bindingSourceNhomKhoiLuong.DataSource = DataServices.NhomKhoiLuong.GetAll();

            bindingSourceHeSoQuyDoi.DataSource = DataServices.HeSoQuyDoiGioChuan.GetAll();

            InitBacDaoTao();

            InitLoaiHinhDaoTao();

            InitHinhThucDaoTao();

            InitNhomKhoiLuong();

            InitHocHam();

            InitHocVi();

            InitNgonNgu();
        }

        void InitBacDaoTao()
        {
            #region Init BacDaoTao
            repositoryItemCheckedComboBoxEditBacDaoTao.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditBacDaoTao.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.Clear();

            VList<ViewBacDaoTao> _vBacDaoTao = new VList<ViewBacDaoTao>();
            _vBacDaoTao = DataServices.ViewBacDaoTao.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewBacDaoTao v in _vBacDaoTao)
            {
                _list.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.TenBacDaoTao, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.AddRange(_list.ToArray());
            repositoryItemCheckedComboBoxEditBacDaoTao.SeparatorChar = ';';
            #endregion
        }

        void InitLoaiHinhDaoTao()
        {
            #region Init LoaiHinhDaoTao
            repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.Items.Clear();

            VList<ViewLoaiHinhDaoTao> _vLoaiHinhDaoTao = new VList<ViewLoaiHinhDaoTao>();
            _vLoaiHinhDaoTao = DataServices.ViewLoaiHinhDaoTao.GetAll();

            List<CheckedListBoxItem> _listLH = new List<CheckedListBoxItem>();
            foreach (ViewLoaiHinhDaoTao v in _vLoaiHinhDaoTao)
            {
                _listLH.Add(new CheckedListBoxItem(v.MaLoaiHinh, v.TenLoaiHinh, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.Items.AddRange(_listLH.ToArray());
            repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.SeparatorChar = ';';
            #endregion
        }

        void InitHinhThucDaoTao()
        {
            #region Init 
            repositoryItemCheckedComboBoxEditHinhThucDaoTao.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditHinhThucDaoTao.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditHinhThucDaoTao.Items.Clear();

            TList<HinhThucDaoTao> _vLoaiHinhDaoTao = new TList<HinhThucDaoTao>();
            _vLoaiHinhDaoTao = DataServices.HinhThucDaoTao.GetAll();

            List<CheckedListBoxItem> _listLH = new List<CheckedListBoxItem>();
            foreach (HinhThucDaoTao v in _vLoaiHinhDaoTao)
            {
                _listLH.Add(new CheckedListBoxItem(v.MaHinhThucDaoTao, v.TenHinhThucDaoTao, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditHinhThucDaoTao.Items.AddRange(_listLH.ToArray());
            repositoryItemCheckedComboBoxEditHinhThucDaoTao.SeparatorChar = ';';
            #endregion
        }


        void InitNhomKhoiLuong()
        {
            #region Init 
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomKhoiLuong, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomKhoiLuong, new string[] { "MaQuanLy", "TenNhom" }, new string[] { "Mã nhóm khối lượng", "Tên nhóm khối lượng" }, new int[] { 100, 300 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditNhomKhoiLuong, 400, 650);
            repositoryItemGridLookUpEditNhomKhoiLuong.DisplayMember = "TenNhom";
            repositoryItemGridLookUpEditNhomKhoiLuong.ValueMember = "MaNhom";
            repositoryItemGridLookUpEditNhomKhoiLuong.NullText = string.Empty;
            #endregion
        }

        void InitHocHam()
        {
            #region Init 
            repositoryItemCheckedComboBoxEditHocHam.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditHocHam.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditHocHam.Items.Clear();

            TList<HocHam> _vLoaiHinhDaoTao = new TList<HocHam>();
            _vLoaiHinhDaoTao = DataServices.HocHam.GetAll();

            List<CheckedListBoxItem> _listLH = new List<CheckedListBoxItem>();
            foreach (HocHam v in _vLoaiHinhDaoTao)
            {
                _listLH.Add(new CheckedListBoxItem(v.MaHocHam, v.TenHocHam, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditHocHam.Items.AddRange(_listLH.ToArray());
            repositoryItemCheckedComboBoxEditHocHam.SeparatorChar = ';';
            #endregion
        }

        void InitHocVi()
        {
            #region Init
            repositoryItemCheckedComboBoxEditHocVi.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditHocVi.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditHocVi.Items.Clear();

            TList<HocVi> _vLoaiHinhDaoTao = new TList<HocVi>();
            _vLoaiHinhDaoTao = DataServices.HocVi.GetAll();

            List<CheckedListBoxItem> _listLH = new List<CheckedListBoxItem>();
            foreach (HocVi v in _vLoaiHinhDaoTao)
            {
                _listLH.Add(new CheckedListBoxItem(v.MaHocVi, v.TenHocVi, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditHocVi.Items.AddRange(_listLH.ToArray());
            repositoryItemCheckedComboBoxEditHocVi.SeparatorChar = ';';
            #endregion
        }

        void InitNgonNgu()
        {
            #region Init
            repositoryItemCheckedComboBoxEditNgonNguGiangDay.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditNgonNguGiangDay.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditNgonNguGiangDay.Items.Clear();

            TList<NgonNguGiangDay> _vLoaiHinhDaoTao = new TList<NgonNguGiangDay>();
            _vLoaiHinhDaoTao = DataServices.NgonNguGiangDay.GetAll();

            List<CheckedListBoxItem> _listLH = new List<CheckedListBoxItem>();
            foreach (NgonNguGiangDay v in _vLoaiHinhDaoTao)
            {
                _listLH.Add(new CheckedListBoxItem(v.MaNgonNgu, v.TenNgonNgu, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditNgonNguGiangDay.Items.AddRange(_listLH.ToArray());
            repositoryItemCheckedComboBoxEditNgonNguGiangDay.SeparatorChar = ';';
            
            #endregion
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
            AppGridView.DeleteSelectedRows(gridViewHeSoQuyDoi);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoQuyDoi.FocusedRowHandle = -1;
            TList<HeSoQuyDoiGioChuan> list = bindingSourceHeSoQuyDoi.DataSource as TList<HeSoQuyDoiGioChuan>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHeSoQuyDoi.EndEdit();
                            DataServices.HeSoQuyDoiGioChuan.Save(list);
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

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlHeSoQuyDoi.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }

        private void gridViewHeSoQuyDoi_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            
            if (col.FieldName == "BacDaoTao" || col.FieldName == "NhomKhoiLuong" || col.FieldName == "LoaiHinhDaoTao" || col.FieldName == "HinhThucDaoTao" 
                || col.FieldName == "MaHocHam" || col.FieldName == "MaHocVi" || col.FieldName == "NgonNguGiangDay" || col.FieldName == "HeSo" || col.FieldName == "GhiChu")
            {
                gridViewHeSoQuyDoi.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewHeSoQuyDoi.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void gridViewHeSoQuyDoi_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoQuyDoi, e);
        }
    }
}
