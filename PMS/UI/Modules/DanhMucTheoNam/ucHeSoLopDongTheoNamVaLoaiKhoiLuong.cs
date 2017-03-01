using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities;
using DevExpress.XtraEditors;
using PMS.Core;
using PMS.Entities.Validation;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucHeSoLopDongTheoNamVaLoaiKhoiLuong : DevExpress.XtraEditors.XtraUserControl
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

                btnSapChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSapChep.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSapChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        VList<ViewHocKy> _listHocKy;
        #endregion
        public ucHeSoLopDongTheoNamVaLoaiKhoiLuong()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucHeSoLopDongTheoNamVaLoaiKhoiLuong_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewHeSoLopDong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoLopDong, new string[] { "MaQuanLy", "MaBacDaoTao", "MaNhomMonHoc", "HocKyApDung", "TuKhoan", "DenKhoan", "HeSo", "NgayBdApDung", "NgayKtApDung", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "Mã HSLD", "Bậc đào tạo", "Nhóm môn học", "Học kỳ áp dụng", "Từ khoản", "Đến khoản", "Hệ số", "Ngày BD áp dụng", "Ngày KT áp dụng", "ngày cập nhật", "Người cập nhật" },
                        new int[] { 80, 150, 150, 120, 90, 90, 80, 150, 150, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSoLopDong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoLopDong, new string[] { "MaQuanLy", "MaBacDaoTao", "MaNhomMonHoc", "HocKyApDung", "TuKhoan", "DenKhoan", "HeSo", "NgayBdApDung", "NgayKtApDung" }, DevExpress.Utils.HorzAlignment.Center);
            
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaNhomMonHoc", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "TuKhoan", repositoryItemSpinEditTuKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "DenKhoan", repositoryItemSpinEditDenKhoan);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "HocKyApDung", repositoryItemCheckedComboBoxEditHocKyApDung);
            //AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaBacDaoTao", repositoryItemGridLookUpEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaBacDaoTao", repositoryItemCheckedComboBoxEditBacDaoTao);
            AppGridView.HideField(gridViewHeSoLopDong, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            if (_maTruong != "LAW")
                AppGridView.HideField(gridViewHeSoLopDong, new string[] { "NgayBdApDung", "NgayKtApDung" });
            if (_maTruong == "TCB" || _maTruong == "USSH")
                AppGridView.HideField(gridViewHeSoLopDong, new string[] { "MaQuanLy", "MaBacDaoTao", "MaNhomMonHoc", "NgayBdApDung", "NgayKtApDung" });
            #endregion
            #region BacDaoTao
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditBacDaoTao, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditBacDaoTao, new string[] { "TenBacDaoTao" }, new string[] { "Tên bậc đào tạo" });
            repositoryItemGridLookUpEditBacDaoTao.DisplayMember = "TenBacDaoTao";
            repositoryItemGridLookUpEditBacDaoTao.ValueMember = "MaBacDaoTao";
            repositoryItemGridLookUpEditBacDaoTao.NullText = string.Empty;
            #endregion
            #region NhomMonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomMonHoc, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomMonHoc, new string[] { "MaQuanLy", "TenNhomMon" }, new string[] { "Mã nhóm môn học", "Tên nhóm môn học" });
            repositoryItemGridLookUpEditNhomMonHoc.DisplayMember = "TenNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.ValueMember = "MaNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.NullText = string.Empty;
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

            #region LoaiKhoiLuong
            AppGridLookupEdit.InitGridLookUp(cboLoaiKhoiLuong, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiKhoiLuong, new string[] { "MaLoaiKhoiLuong", "TenLoaiKhoiLuong" }, new string[] { "Mã loại khối lượng", "Tên loại khối lượng" });
            cboLoaiKhoiLuong.Properties.ValueMember = "MaLoaiKhoiLuong";
            cboLoaiKhoiLuong.Properties.DisplayMember = "TenLoaiKhoiLuong";
            cboLoaiKhoiLuong.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitData
        private void InitData()
        {
          
            bindingSourceNhomMonHoc.DataSource = DataServices.NhomMonHoc.GetAll();
            //bindingSourceBacDaoTao.DataSource = DataServices.ViewBacDaoTao.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            #region BacDaoTao
            VList<ViewBacDaoTao> _listBacDaoTao = DataServices.ViewBacDaoTao.GetAll();
            repositoryItemCheckedComboBoxEditBacDaoTao.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditBacDaoTao.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.Clear();
            List<CheckedListBoxItem> listBac = new List<CheckedListBoxItem>();
            foreach (ViewBacDaoTao v in _listBacDaoTao)
                listBac.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.TenBacDaoTao, CheckState.Unchecked, true));
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.AddRange(listBac.ToArray());
            repositoryItemCheckedComboBoxEditBacDaoTao.SeparatorChar = ';';
            #endregion
            if (cboNamHoc.EditValue != null)
            {
                _listHocKy = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                bindingSourceHocKy.DataSource = _listHocKy;
                #region HocKyApDung
                repositoryItemCheckedComboBoxEditHocKyApDung.SelectAllItemCaption = "Tất cả";
                repositoryItemCheckedComboBoxEditHocKyApDung.TextEditStyle = TextEditStyles.Standard;
                repositoryItemCheckedComboBoxEditHocKyApDung.Items.Clear();

                List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
                foreach (ViewHocKy dr in _listHocKy)
                    list.Add(new CheckedListBoxItem(dr.MaHocKy, dr.TenHocKy, CheckState.Unchecked, true));
                repositoryItemCheckedComboBoxEditHocKyApDung.Items.AddRange(list.ToArray());
                repositoryItemCheckedComboBoxEditHocKyApDung.SeparatorChar = ';';
                #endregion
            }

            #region LoaiKhoiLuong
            cboLoaiKhoiLuong.DataBindings.Clear();
            bindingSourceLoaiKhoiLuong.DataSource = DataServices.LoaiKhoiLuong.GetAll();
            cboLoaiKhoiLuong.DataBindings.Add("EditValue", bindingSourceLoaiKhoiLuong, "MaLoaiKhoiLuong", true, DataSourceUpdateMode.OnPropertyChanged);
            #endregion

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboLoaiKhoiLuong.EditValue != null)
                bindingSourceHeSoLopDong.DataSource = DataServices.HeSoLopDong.GetByNamHocHocKyLoaiKhoiLuong(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString());
        }
        #endregion

        private void btnLamtuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                            foreach (HeSoLopDong hs in list)
                            {
                                hs.NamHoc = cboNamHoc.EditValue.ToString();
                                hs.HocKy = cboHocKy.EditValue.ToString();
                                hs.MaLoaiKhoiLuong = cboLoaiKhoiLuong.EditValue.ToString();
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

        private void gridViewHeSoLopDong_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoLopDong, e);
        }

        private void gridViewHeSoLopDong_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHeSoLopDong, e);
        }

        private void gridViewHeSoLopDong_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //HeSoLopDong obj = e.Row as HeSoLopDong;
            //if (obj != null)
            //{
            //    obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaQuanLy");
            //    if (obj.IsValid)
            //        e.Valid = true;
            //    else
            //    {
            //        XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        e.Valid = false;
            //    }
            //}
        }

        //private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        //{
        //    HeSoLopDong obj = target as HeSoLopDong;
        //    if (obj != null)
        //    {
        //        if (((TList<HeSoLopDong>)bindingSourceHeSoLopDong.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
        //        {
        //            e.Description = string.Format("Mã quy đổi {0} hiện tại đã có.", obj.MaQuanLy);
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        private void gridViewHeSoLopDong_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlHeSoLopDong.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboLoaiKhoiLuong.EditValue != null)
                bindingSourceHeSoLopDong.DataSource = DataServices.HeSoLopDong.GetByNamHocHocKyLoaiKhoiLuong(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboLoaiKhoiLuong.EditValue != null)
                bindingSourceHeSoLopDong.DataSource = DataServices.HeSoLopDong.GetByNamHocHocKyLoaiKhoiLuong(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboLoaiKhoiLuong.EditValue.ToString());
        }

        private void gridViewHeSoLopDong_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaQuanLy" || col.FieldName == "MaBacDaoTao" || col.FieldName == "MaNhomMonHoc" || col.FieldName == "TuKhoan" || col.FieldName == "DenKhoan" || col.FieldName == "HeSo" || col.FieldName == "NgayBdApDung" || col.FieldName == "NgayKtApDung")
            {
                gridViewHeSoLopDong.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewHeSoLopDong.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void btnSapChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepHeSoLopDongTheoLoaiKhoiLuong", cboLoaiKhoiLuong.EditValue.ToString()))
            {
                frm.ShowDialog();
            }
            InitData();
        }
    }
}
