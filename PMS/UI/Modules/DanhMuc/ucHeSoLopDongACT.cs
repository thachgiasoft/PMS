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

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoLopDongACT : DevExpress.XtraEditors.XtraUserControl
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
        public ucHeSoLopDongACT()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucHeSoLopDongACT_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewHeSoLopDong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoLopDong, new string[] { "MaQuanLy", "MaBacDaoTao", "MaNhomMonHoc", "TuKhoan", "DenKhoan", "HeSo" },
                        new string[] { "Mã HSLD", "Bậc đào tạo", "Nhóm môn học", "Từ khoản", "Đến khoản", "Hệ số" },
                        new int[] { 80, 150, 150, 90, 90, 80, 150, 150 });
            AppGridView.ShowEditor(gridViewHeSoLopDong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoLopDong, new string[] { "MaQuanLy", "MaBacDaoTao", "MaNhomMonHoc", "TuKhoan", "DenKhoan", "HeSo" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaBacDaoTao", repositoryItemCheckedComboBoxEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaNhomMonHoc", repositoryItemCheckedComboBoxEditNhomMonHoc);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "TuKhoan", repositoryItemSpinEditTuKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "DenKhoan", repositoryItemSpinEditDenKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "HeSo", repositoryItemSpinEditHeSo);
            #endregion

            #region Init LoaiKhoiLuong
            AppGridLookupEdit.InitGridLookUp(cboLoaiKhoiLuong, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiKhoiLuong, new string[] { "MaLoaiKhoiLuong", "TenLoaiKhoiLuong" }, new string[] { "Mã loại khối lượng", "Tên loại khối lượng" });
            cboLoaiKhoiLuong.Properties.DisplayMember = "TenLoaiKhoiLuong";
            cboLoaiKhoiLuong.Properties.ValueMember = "MaLoaiKhoiLuong";
            cboLoaiKhoiLuong.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }
        #region InitData
        private void InitData()
        {

            #region Init BacDaoTao
            repositoryItemCheckedComboBoxEditBacDaoTao.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditBacDaoTao.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.Clear();

            VList<ViewBacDaoTao> _vListBacDaoTao = new VList<ViewBacDaoTao>();
            _vListBacDaoTao = DataServices.ViewBacDaoTao.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewBacDaoTao v in _vListBacDaoTao)
            {
                _list.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.TenBacDaoTao, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.AddRange(_list.ToArray());
            repositoryItemCheckedComboBoxEditBacDaoTao.SeparatorChar = ';';
            #endregion
            #region Init NhomMonHoc
            repositoryItemCheckedComboBoxEditNhomMonHoc.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditNhomMonHoc.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditNhomMonHoc.Items.Clear();

            TList<NhomMonHoc> _vListNhomMonHoc = new TList<NhomMonHoc>();
            _vListNhomMonHoc = DataServices.NhomMonHoc.GetAll();

            List<CheckedListBoxItem> _list2 = new List<CheckedListBoxItem>();
            foreach (NhomMonHoc v in _vListNhomMonHoc)
            {
                _list2.Add(new CheckedListBoxItem(v.MaNhomMon, v.TenNhomMon, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditNhomMonHoc.Items.AddRange(_list2.ToArray());
            repositoryItemCheckedComboBoxEditNhomMonHoc.SeparatorChar = ';';
            #endregion
            cboLoaiKhoiLuong.DataBindings.Clear();
            bindingSourceLoaiKhoiLuong.DataSource = DataServices.LoaiKhoiLuong.GetAll();
            cboLoaiKhoiLuong.DataBindings.Add("EditValue", bindingSourceLoaiKhoiLuong, "MaLoaiKhoiLuong", true, DataSourceUpdateMode.OnPropertyChanged);

            if (cboLoaiKhoiLuong.EditValue != null)
                bindingSourceHeSoLopDong.DataSource = DataServices.HeSoLopDong.GetByMaLoaiKhoiLuong(cboLoaiKhoiLuong.EditValue.ToString());
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
                            foreach (HeSoLopDong h in list)
                            {
                                h.MaLoaiKhoiLuong = cboLoaiKhoiLuong.EditValue.ToString();
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

        private void cboLoaiKhoiLuong_EditValueChanged(object sender, EventArgs e)
        {
            if (cboLoaiKhoiLuong.EditValue != null)
                bindingSourceHeSoLopDong.DataSource = DataServices.HeSoLopDong.GetByMaLoaiKhoiLuong(cboLoaiKhoiLuong.EditValue.ToString());
        }

        private void gridViewHeSoLopDong_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoLopDong, e);
        }
    }
}
