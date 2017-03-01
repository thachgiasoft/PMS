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
using PMS.Core;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoKhoiNganh : DevExpress.XtraEditors.XtraUserControl
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
                btnLuu.ShortCut = Shortcut.CtrlS;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.ShortCut = Shortcut.Del;
            }
        }
        #endregion

        #region Variable
        PMS.Entities.TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        #endregion

        public ucHeSoKhoiNganh()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucHeSoKhoiNganh_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewHeSoKhoiNganh, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoKhoiNganh, new string[] { "MaKhoiNganh", "TenKhoiNganh", "NhomKhoiNganh", "SiSo", "HeSoThucHanh", "HeSo", "GhiChu" },
                        new string[] { "Mã khối ngành", "Tên khối ngành", "Nhóm ngành", "Sĩ số nhóm TH", "Hệ số TH theo khối ngành", "Hệ số LT theo khối ngành", "Ghi chú" },
                        new int[] { 90, 150, 230, 80, 80, 80, 200 });
            AppGridView.ShowEditor(gridViewHeSoKhoiNganh, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoKhoiNganh, new string[] { "MaKhoiNganh", "TenKhoiNganh", "NhomKhoiNganh", "SiSo", "HeSoThucHanh", "HeSo", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            //AppGridView.RegisterControlField(gridViewHeSoKhoiNganh, "MaKhoiNganh", repositoryItemGridLookUpEditKhoiNganh);
            AppGridView.RegisterControlField(gridViewHeSoKhoiNganh, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.RegisterControlField(gridViewHeSoKhoiNganh, "NhomKhoiNganh", repositoryItemCheckedComboBoxEditNhomKhoiNganh);
            PMS.Common.Globals.WordWrapHeader(gridViewHeSoKhoiNganh, 45);
            #endregion

            #region NhomMonHoc
            //AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditKhoiNganh, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            //AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditKhoiNganh, new string[] { "MaKhoiNganh", "TenKhoiNganh" }, new string[] { "Mã khối ngành", "Tên khối ngành" }, new int[] { 100, 200 });
            //repositoryItemGridLookUpEditKhoiNganh.DisplayMember = "TenKhoiNganh";
            //repositoryItemGridLookUpEditKhoiNganh.ValueMember = "MaKhoiNganh";
            //repositoryItemGridLookUpEditKhoiNganh.NullText = string.Empty;
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

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
            InitData();
        }

        #region InitData
        private void InitData()
        {
            #region InitKhoiNganh
            DataTable dt = new DataTable();
            dt.Load(DataServices.HeSoKhoiNganh.GetAllKhoiNganh());
            bindingSourceKhoiNganh.DataSource = dt;

            repositoryItemCheckedComboBoxEditNhomKhoiNganh.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditNhomKhoiNganh.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditNhomKhoiNganh.Items.Clear();

            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();

            foreach (DataRow l in dt.Rows)
                list.Add(new CheckedListBoxItem(l["MaKhoiNganh"], string.Format("{0} - {1}", l["MaKhoiNganh"], l["TenKhoiNganh"]), CheckState.Unchecked, true));
            repositoryItemCheckedComboBoxEditNhomKhoiNganh.Items.AddRange(list.ToArray());
            repositoryItemCheckedComboBoxEditNhomKhoiNganh.SeparatorChar = ';';
            #endregion

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoKhoiNganh.DataSource = DataServices.HeSoKhoiNganh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
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
            AppGridView.DeleteSelectedRows(gridViewHeSoKhoiNganh);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoKhoiNganh.FocusedRowHandle = -1;
            TList<HeSoKhoiNganh> list = bindingSourceHeSoKhoiNganh.DataSource as TList<HeSoKhoiNganh>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (HeSoKhoiNganh h in list)
                            {
                                h.NamHoc = cboNamHoc.EditValue.ToString();
                                h.HocKy = cboHocKy.EditValue.ToString();
                            }
                            bindingSourceHeSoKhoiNganh.EndEdit();
                            DataServices.HeSoKhoiNganh.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewHeSoKhoiNganh, barManager1, layoutControl1 });
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
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlHeSoKhoiNganh.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewHeSoKhoiNganh_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "Stt" || col.FieldName == "MaQuanLy" || col.FieldName == "MaBacDaoTao" || col.FieldName == "MaNhomMonHoc" || col.FieldName == "TuKhoan" || col.FieldName == "DenKhoan" || col.FieldName == "HeSo" || col.FieldName == "NgayBdApDung" || col.FieldName == "NgayKtApDung")
            {
                gridViewHeSoKhoiNganh.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewHeSoKhoiNganh.SetRowCellValue(e.RowHandle, "NguoiCapNhat", PMS.BLL.UserInfo.UserName);
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoKhoiNganh.DataSource = DataServices.HeSoKhoiNganh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoKhoiNganh.DataSource = DataServices.HeSoKhoiNganh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepHeSoKhoiNganh"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepHeSoKhoiNganh"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }

        private void repositoryItemCheckedComboBoxEditNhomKhoiNganh_Popup(object sender, EventArgs e)
        {
            AppRepositoryItemCheckedComboBoxEdit.PopupSize(sender, 300, 500);
        }
    }
}
