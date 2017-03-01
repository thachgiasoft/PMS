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
using PMS.Entities.Validation;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucDonGiaChamBai : DevExpress.XtraEditors.XtraUserControl
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

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        public ucDonGiaChamBai()
        {
            InitializeComponent();
        }

        private void ucDonGiaChamBai_Load(object sender, EventArgs e)
        {
            #region Init GridView QuyDoiGioChuan
            AppGridView.InitGridView(gridViewDonGiaChamBai, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewDonGiaChamBai, new string[] { "MaQuanLy", "TenDonGia", "BacDaoTao", "DonGia", "TietQuyChuan", "NgayCapNhat", "NguoiCapNhat" },
                new string[] { "Mã quản lý", "Tên đơn giá", "Bậc đào tạo", "Đơn giá (Đồng/ Bài)", "Quy đổi tiết chuẩn (Bài/ Tiết)", "Ngày cập nhật", "Người cập nhật" },
                new int[] { 90, 200, 150, 130, 170, 99, 99 });
            AppGridView.ShowEditor(gridViewDonGiaChamBai, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewDonGiaChamBai, "BacDaoTao", repositoryItemCheckedComboBoxEditBacDaoTao);
            AppGridView.FormatDataField(gridViewDonGiaChamBai, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewDonGiaChamBai, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region BacDaoTao
            repositoryItemCheckedComboBoxEditBacDaoTao.SelectAllItemCaption = "";
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.Clear();
            repositoryItemCheckedComboBoxEditBacDaoTao.SeparatorChar = ';';
            repositoryItemCheckedComboBoxEditBacDaoTao.TextEditStyle = TextEditStyles.Standard;
            VList<ViewBacDaoTao> _listBacDaoTao = DataServices.ViewBacDaoTao.GetAll();
            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            foreach (ViewBacDaoTao v in _listBacDaoTao)
            {
                list.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.TenBacDaoTao, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.AddRange(list.ToArray());
            #endregion

            InitData();
        }
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDonGiaChamBai.DataSource = DataServices.DonGiaChamBai.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGiaChamBai);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewDonGiaChamBai.FocusedRowHandle = -1;
            TList<DonGiaChamBai> list = bindingSourceDonGiaChamBai.DataSource as TList<DonGiaChamBai>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (DonGiaChamBai q in list)
                            {
                                q.NamHoc = cboNamHoc.EditValue.ToString();
                                q.HocKy = cboHocKy.EditValue.ToString();
                            }
                            bindingSourceDonGiaChamBai.EndEdit();
                            DataServices.DonGiaChamBai.Save(list);
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
                    {
                        if (sf.FileName != "")
                        {
                            gridControlDonGiaChambai.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch
            { }
        }

        private void gridViewDonGiaChamBai_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGiaChamBai, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            DonGiaChamBai obj = target as DonGiaChamBai;
            if (obj != null)
            {
                if (((TList<DonGiaChamBai>)bindingSourceDonGiaChamBai.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewDonGiaChamBai_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DonGiaChamBai obj = e.Row as DonGiaChamBai;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaQuanLy");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void gridViewDonGiaChamBai_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaQuanLy" || col.FieldName == "TenDonGia" || col.FieldName == "BacDaoTao" || col.FieldName == "DonGia" || col.FieldName == "TietQuyChuan")
            {
                gridViewDonGiaChamBai.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewDonGiaChamBai.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDonGiaChamBai.DataSource = DataServices.DonGiaChamBai.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceDonGiaChamBai.DataSource = DataServices.DonGiaChamBai.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepDonGiaChamBai"))
            {
                frm.ShowDialog();
            }
            InitData();
        }
    }
}
