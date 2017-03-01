using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities;
using PMS.BLL;
using PMS.Entities.Validation;
using DevExpress.XtraGrid.Columns;
using PMS.Services;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucDonGia : DevExpress.XtraEditors.XtraUserControl
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

        public ucDonGia()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            if (_maTruong != "USSH")
            {
                layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }

        private void ucDonGia_Load(object sender, EventArgs e)
        {
            #region Init GridView
            switch(_maTruong)
            {
                case "BUH":
                    InitGridBUH();
                    break;
                case "ACT":
                    InitGridACT();
                    break;
                case "CTIM":
                    InitGridCTIM();
                    break;
                default:
                    
                        AppGridView.InitGridView(gridViewDonGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
                        AppGridView.ShowEditor(gridViewDonGia, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
                        AppGridView.ShowField(gridViewDonGia, new string[] { "MaQuanLy", "MaLoaiGiangVien", "MaHocHam", "MaHocVi", "DonGia", "DonGiaClc", "DonGiaTrongChuan", "DonGiaNgoaiChuan", "HeSoQuyDoiChatLuong", "NgayCapNhat", "NguoiCapNhat" }
                                    , new string[] { "Mã quản lý", "Loại giảng viên", "Học hàm", "Học vị", "Đơn giá", "Đơn giá CLC", "Đơn giá trong chuẩn", "Đơn giá ngoài chuẩn", "Hệ số quy đổi chất lượng", "NgayCapNhat", "NguoiCapNhat" }
                                    , new int[] { 100, 110, 100, 100, 120, 120, 120, 120, 160, 99, 99 });
                        AppGridView.AlignHeader(gridViewDonGia, new string[] { "MaQuanLy", "MaLoaiGiangVien", "MaHocHam", "MaHocVi", "DonGia", "DonGiaClc", "DonGiaTrongChuan", "DonGiaNgoaiChuan", "HeSoQuyDoiChatLuong", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

                        AppGridView.RegisterControlField(gridViewDonGia, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
                        AppGridView.RegisterControlField(gridViewDonGia, "MaHocHam", repositoryItemGridLookUpEditHocHam);
                        AppGridView.RegisterControlField(gridViewDonGia, "MaHocVi", repositoryItemGridLookUpEditHocVi);
                        AppGridView.RegisterControlField(gridViewDonGia, "DonGia", repositoryItemSpinEditDonGia);
                        AppGridView.RegisterControlField(gridViewDonGia, "DonGiaClc", repositoryItemSpinEditDonGiaClc);
                        AppGridView.RegisterControlField(gridViewDonGia, "DonGiaTrongChuan", repositoryItemSpinEditDonGiaTrongChuan);
                        AppGridView.RegisterControlField(gridViewDonGia, "DonGiaNgoaiChuan", repositoryItemSpinEditDonGiaNgoaiChuan);
                        AppGridView.FormatDataField(gridViewDonGia, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
                        AppGridView.FormatDataField(gridViewDonGia, "DonGiaClc", DevExpress.Utils.FormatType.Custom, "n0");
                        AppGridView.FormatDataField(gridViewDonGia, "DonGiaTrongChuan", DevExpress.Utils.FormatType.Custom, "n0");
                        AppGridView.FormatDataField(gridViewDonGia, "DonGiaNgoaiChuan", DevExpress.Utils.FormatType.Custom, "n0");
                        AppGridView.HideField(gridViewDonGia, new string[] { "NgayCapNhat", "NguoiCapNhat" });
                        if (_maTruong == "USSH")
                            AppGridView.HideField(gridViewDonGia, new string[] { "MaLoaiGiangVien", "DonGia", "DonGiaClc" });
                        else
                            AppGridView.HideField(gridViewDonGia, new string[] { "HeSoQuyDoiChatLuong", "DonGiaTrongChuan", "DonGiaNgoaiChuan" });
                break;
            }
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

            #region HinhThucDaoTao
            AppGridLookupEdit.InitGridLookUp(cboHinhThucDaoTao, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHinhThucDaoTao, new string[] { "MaHinhThucDaoTao", "TenHinhThucDaoTao" }, new string[] { "Mã hình thức đào tạo", "Tên hình thức đào tạo" });
            cboHinhThucDaoTao.Properties.ValueMember = "MaHinhThucDaoTao";
            cboHinhThucDaoTao.Properties.DisplayMember = "TenHinhThucDaoTao";
            cboHinhThucDaoTao.Properties.NullText = string.Empty;
            #endregion

            #region NgonNguGiangDay
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNgonNguGiangDay, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNgonNguGiangDay, new string[] { "MaNgonNgu", "TenNgonNgu" }, new string[] { "Mã ngôn ngữ", "Tên ngôn ngữ" }, new int[] { 150, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditNgonNguGiangDay, 350, 400);
            repositoryItemGridLookUpEditNgonNguGiangDay.ValueMember = "MaNgonNgu";
            repositoryItemGridLookUpEditNgonNguGiangDay.DisplayMember = "TenNgonNgu";
            repositoryItemGridLookUpEditNgonNguGiangDay.NullText = string.Empty;
            #endregion

            #region BacDaoTao
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditBacDaoTao, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditBacDaoTao, new string[] { "MaBacDaoTao", "TenBacDaoTao" }, new string[] { "Mã bậc đào tạo", "Tên bậc đào tạo" }, new int[] { 100, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditBacDaoTao, 300, 400);
            repositoryItemGridLookUpEditBacDaoTao.ValueMember = "MaBacDaoTao";
            repositoryItemGridLookUpEditBacDaoTao.DisplayMember = "TenBacDaoTao";
            repositoryItemGridLookUpEditBacDaoTao.NullText = string.Empty;
            #endregion

            //#region Check CBO Hoc Vi
            //repositoryItemCheckedComboBoxEditHocVi.SelectAllItemCaption = "";
            //repositoryItemCheckedComboBoxEditHocVi.Items.Clear();
            //repositoryItemCheckedComboBoxEditHocVi.SeparatorChar = ';';
            //repositoryItemCheckedComboBoxEditHocVi.TextEditStyle = TextEditStyles.Standard;
            //TList<HocVi> _Tlist = DataServices.HocVi.GetAll();
            //List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            //foreach (HocVi v in _Tlist)
            //{
            //    list.Add(new CheckedListBoxItem(v.MaHocVi, v.TenHocVi, CheckState.Unchecked, true));
            //}
            //repositoryItemCheckedComboBoxEditHocVi.Items.AddRange(list.ToArray());
            //#endregion


            InitData();
        }

        #region Init Grid
        #region InitGridCTIM
        void InitGridCTIM()
        {
            AppGridView.InitGridView(gridViewDonGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDonGia, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDonGia, new string[] {  "MaQuanLy", "BacDaoTao", "DonGia", "NgayCapNhat", "NguoiCapNhat" }
                , new string[] { "Mã quản lý", "Bậc đào tạo", "Đơn giá", "NgayCapNhat", "NguoiCapNhat" }
                        , new int[] { 100, 200, 140, 99, 99 });
            AppGridView.AlignHeader(gridViewDonGia, new string[] { "MaQuanLy", "BacDaoTao", "DonGia", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDonGia, "BacDaoTao", repositoryItemGridLookUpEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewDonGia, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.FormatDataField(gridViewDonGia, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewDonGia, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }
        #endregion
        #region Init Grid BUH
        void InitGridBUH()
        {
            AppGridView.InitGridView(gridViewDonGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDonGia, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDonGia, new string[] { "MaQuanLy", "BacDaoTao", "NgonNguGiangDay", "MaLoaiGiangVien", "DonGia",  "NgayCapNhat", "NguoiCapNhat" }
                        , new string[] { "Mã quản lý", "Bậc đào tạo", "Ngôn ngữ giảng dạy","Loại giảng viên", "Đơn giá", "NgayCapNhat", "NguoiCapNhat" }
                        , new int[] { 100, 110, 120,110, 100,99, 99 });
            AppGridView.AlignHeader(gridViewDonGia, new string[] { "MaQuanLy", "BacDaoTao", "NgonNguGiangDay", "MaLoaiGiangVien",  "DonGia",  "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDonGia, "DonGia", repositoryItemSpinEditDonGia);

            AppGridView.RegisterControlField(gridViewDonGia, "BacDaoTao", repositoryItemGridLookUpEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewDonGia, "NgonNguGiangDay", repositoryItemGridLookUpEditNgonNguGiangDay);
            AppGridView.RegisterControlField(gridViewDonGia, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);

            AppGridView.FormatDataField(gridViewDonGia, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");

            AppGridView.HideField(gridViewDonGia, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }
        #endregion

        #region Init Grid ACT
        void InitGridACT()
        {
            AppGridView.InitGridView(gridViewDonGia, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDonGia, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDonGia, new string[] { "MaQuanLy", "MaHocHam", "MaHocVi", "DonGia", "NgayCapNhat", "NguoiCapNhat" }
                        , new string[] { "Mã quản lý", "Học hàm", "Học vị", "Đơn giá", "NgayCapNhat", "NguoiCapNhat" }
                        , new int[] { 100, 110, 120, 100, 99, 99 });
            AppGridView.AlignHeader(gridViewDonGia, new string[] { "MaQuanLy", "MaHocHam", "MaHocVi", "DonGia", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewDonGia, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewDonGia, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewDonGia, "DonGia", repositoryItemSpinEditDonGia);
            AppGridView.FormatDataField(gridViewDonGia, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewDonGia, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }
        #endregion

        #endregion

        #region InitData
        void InitData()
        {
            try
            {
                bindingSourceBacDaoTao.DataSource = DataServices.ViewBacDaoTao.GetAll();
                bindingSourceNgonNguGiangDay.DataSource = DataServices.NgonNguGiangDay.GetAll();
                cboHinhThucDaoTao.DataBindings.Clear();
                bindingSourceHinhThucDaoTao.DataSource = DataServices.HinhThucDaoTao.GetAll();
                cboHinhThucDaoTao.DataBindings.Add("EditValue", bindingSourceHinhThucDaoTao, "MaHinhThucDaoTao", true, DataSourceUpdateMode.OnPropertyChanged);
                bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
                bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
                bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();
                if (_maTruong == "USSH")
                {
                    if (cboHinhThucDaoTao.EditValue != null)
                        bindingSourceDonGia.DataSource = DataServices.DonGia.GetByHinhThucDaoTao(int.Parse(cboHinhThucDaoTao.EditValue.ToString()));
                }
                else
                    bindingSourceDonGia.DataSource = DataServices.DonGia.GetAll();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGia);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewDonGia.FocusedRowHandle = -1;
            TList<DonGia> list = bindingSourceDonGia.DataSource as TList<DonGia>;
            if (list != null)
            {
                foreach (DonGia d in list)

                {
                    d.MaHinhThucDaoTao = PMS.Common.Globals.IsNull(cboHinhThucDaoTao.EditValue, "string").ToString();
                    //d.NgayCapNhat = DateTime.Now;
                    //d.NguoiCapNhat = UserInfo.UserName;
                }
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceDonGia.EndEdit();
                            DataServices.DonGia.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Event Grid
        private void gridViewDonGia_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGia, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            DonGia obj = target as DonGia;
            if (obj != null)
            {
                if (((TList<DonGia>)bindingSourceDonGia.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã đơn giá {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
                if (_maTruong == "BUH")
                {
                    if (((TList<DonGia>)bindingSourceDonGia.DataSource).FindAll(p => p.BacDaoTao == obj.BacDaoTao & p.NgonNguGiangDay == obj.NgonNguGiangDay & p.MaLoaiGiangVien == obj.MaLoaiGiangVien).Count > 1)
                    {
                        e.Description = "Đơn giá hiện tại đã có.";
                        return false;
                    }
                }
                else
                    if (((TList<DonGia>)bindingSourceDonGia.DataSource).FindAll(p => p.MaLoaiGiangVien == obj.MaLoaiGiangVien & p.MaHocHam == obj.MaHocHam & p.MaHocVi == obj.MaHocVi && p.BacDaoTao == obj.BacDaoTao).Count > 1)
                    {
                        e.Description = "Đơn giá hiện tại đã có.";
                        return false;
                    }
            }
            return true;
        }

        private void gridViewDonGia_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DonGia obj = e.Row as DonGia;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaQuanLy, MaLoaiGiangVien, MaHocHam, MaHocVi");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void gridViewDonGia_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
        #endregion

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlDonGia.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void gridViewDonGia_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaQuanLy" || col.FieldName == "MaLoaiGiangVien" || col.FieldName == "MaHocHam" || col.FieldName == "MaHocVi" || col.FieldName == "DonGia" || col.FieldName == "HeSoQuyDoiChatLuong")
            {
                int pos = e.RowHandle;
                gridViewDonGia.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewDonGia.SetRowCellValue(pos, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void cboHinhThucDaoTao_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (_maTruong == "USSH")
                {
                    if (cboHinhThucDaoTao.EditValue != null)
                        bindingSourceDonGia.DataSource = DataServices.DonGia.GetByHinhThucDaoTao(int.Parse(cboHinhThucDaoTao.EditValue.ToString()));
                }
                else
                    bindingSourceDonGia.DataSource = DataServices.DonGia.GetAll();
            }
            catch
            { }
        }
    }
}
