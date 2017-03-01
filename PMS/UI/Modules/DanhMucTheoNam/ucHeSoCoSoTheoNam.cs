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
using DevExpress.XtraGrid.Columns;
using PMS.UI.Forms.NghiepVu;
using System.Data;
using System.Collections.Generic;

namespace PMS.UI.Modules.DanhMucTheoNam
{
    public partial class ucHeSoCoSoTheoNam : XtraUserControl
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

                barButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem2.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                barButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        VList<ViewCoSo> _listCoSo;
        #endregion
        public ucHeSoCoSoTheoNam()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucHeSoCoSoTheoNam_Load(object sender, EventArgs e)
        {
            #region Init Gridview
            switch (_maTruong)
            {
                case "VHU":
                    InitGridVHU();
                    break;
                case "HBU":
                    InitGridVHU();
                    break;
                case "LAW":
                    InitGridLAW();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion
            
            #region CoSo
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditCoSo, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditCoSo, new string[] { "MaCoSo", "TenCoSo" }, new string[] { "Mã cơ sở", "Tên cơ sở" });
            repositoryItemGridLookUpEditCoSo.DisplayMember = "TenCoSo";
            repositoryItemGridLookUpEditCoSo.ValueMember = "MaCoSo";
            repositoryItemGridLookUpEditCoSo.NullText = string.Empty;
            #endregion

            #region BacDaoTao
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditBacDaoTao, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditBacDaoTao, new string[] { "MaBacDaoTao", "TenBacDaoTao" }, new string[] { "Mã bậc đào tạo", "Tên bậc đào tạo" });
            repositoryItemGridLookUpEditBacDaoTao.DisplayMember = "TenBacDaoTao";
            repositoryItemGridLookUpEditBacDaoTao.ValueMember = "MaBacDaoTao";
            repositoryItemGridLookUpEditBacDaoTao.NullText = string.Empty;
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

            #region Init Datasource
            InitData();
            //PMS.Common.Globals.LoadLayout(Tag as AppModule, new object[] { gridViewCoSo, barManager1, layoutControl1 });
            #endregion
        }

        #region Init GridView
        void InitGridVHU()
        {
            #region Init GridView HeSoCoSo
            AppGridView.InitGridView(gridViewCoSo, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewCoSo, new string[] { "ThuTu", "MaQuanLy", "MaCoSo", "HeSo", "NgayBdApDung", "NgayKtApDung" },
                new string[] { "STT", "Mã cơ sở", "Tên cơ sở", "Hệ số", "Ngày BD áp dụng", "Ngày KT áp dụng" },
                new int[] { 70, 100, 350, 100, 150, 150 });
            AppGridView.ShowEditor(gridViewCoSo, NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewCoSo, "MaCoSo", repositoryItemGridLookUpEditCoSo);
            AppGridView.HideField(gridViewCoSo, new string[] { "NgayBdApDung", "NgayKtApDung" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
            #endregion
        }

        void InitGridLAW()
        {
            #region Init GridView HeSoCoSo
            AppGridView.InitGridView(gridViewCoSo, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewCoSo, new string[] { "MaCoSo", "HeSo", "GhiChu" },
                new string[] { "Tên cơ sở", "Hệ số", "Ghi chú" },
                new int[] { 250, 80, 200 });
            AppGridView.ShowEditor(gridViewCoSo, NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewCoSo, "MaCoSo", repositoryItemGridLookUpEditCoSo);
            AppGridView.AlignHeader(gridViewCoSo, new string[] { "MaCoSo", "HeSo", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            #endregion
        }

        void InitRemaining()
        {
            #region Init GridView HeSoCoSo
            AppGridView.InitGridView(gridViewCoSo, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewCoSo, new string[] { "MaQuanLy", "MaCoSo", "ThoiGianHoc", "HeSo", "NgayBdApDung", "NgayKtApDung" },
                new string[] { "Bậc đào tạo", "Tên cơ sở", "Thời gian học", "Hệ số", "Ngày BD áp dụng", "Ngày KT áp dụng" },
                new int[] { 100, 350, 120, 100, 150, 150 });
            AppGridView.ShowEditor(gridViewCoSo, NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewCoSo, "MaCoSo", repositoryItemGridLookUpEditCoSo);
            AppGridView.RegisterControlField(gridViewCoSo, "MaQuanLy", repositoryItemGridLookUpEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewCoSo, "ThoiGianHoc", repositoryItemCheckedComboBoxEditThoiGianHoc);
            if (_maTruong != "LAW")
                AppGridView.HideField(gridViewCoSo, new string[] { "NgayBdApDung", "NgayKtApDung" });
            #endregion
        }
        #endregion

        void InitData()
        {
            #region BuoiHoc
            repositoryItemCheckedComboBoxEditThoiGianHoc.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditThoiGianHoc.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditThoiGianHoc.Items.Clear();

            DataTable table = new DataTable();
            table.Columns.Add("MaBuoiHoc", typeof(string));
            table.Columns.Add("TenBuoiHoc", typeof(string));
            table.Rows.Add("1", "Buổi học bình thường");
            table.Rows.Add("2", "Ngoài giờ");

            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            foreach (DataRow dr in table.Rows)
                list.Add(new CheckedListBoxItem(dr["MaBuoiHoc"].ToString(), dr["TenBuoiHoc"].ToString(), CheckState.Unchecked, true));
            repositoryItemCheckedComboBoxEditThoiGianHoc.Items.AddRange(list.ToArray());
            repositoryItemCheckedComboBoxEditThoiGianHoc.SeparatorChar = ';';
            #endregion
            bindingSourceBacDaoTao.DataSource = DataServices.ViewBacDaoTao.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            _listCoSo = DataServices.ViewCoSo.GetAll();
            bindingSourceCoSo.DataSource = _listCoSo;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoCoSo.DataSource = DataServices.HeSoCoSo.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void gridViewHeSoCoSo_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewCoSo, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewCoSo.FocusedRowHandle = -1;
            TList<HeSoCoSo> list = bindingSourceHeSoCoSo.DataSource as TList<HeSoCoSo>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (HeSoCoSo hs in list)
                            {
                                hs.NamHoc = cboNamHoc.EditValue.ToString();
                                hs.HocKy = cboHocKy.EditValue.ToString();
                            }
                            bindingSourceHeSoCoSo.EndEdit();
                            DataServices.HeSoCoSo.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewCoSo, barManager1, layoutControl1 });
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

        private void gridViewHeSoCoSo_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewCoSo, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            HeSoCoSo obj = target as HeSoCoSo;
            if (obj != null)
            {
                if (((TList<HeSoCoSo>)bindingSourceHeSoCoSo.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy & p.MaCoSo == obj.MaCoSo & p.ThoiGianHoc == obj.ThoiGianHoc).Count > 1)
                {
                    e.Description = string.Format("Mã cơ sở {0} hiện đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewHeSoCoSo_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            HeSoCoSo obj = e.Row as HeSoCoSo;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaQuanLy, MaCoSo, ThoiGianHoc");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewCoSo);
        }

        private void gridViewCoSo_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlCoSo.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoCoSo.DataSource = DataServices.HeSoCoSo.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoCoSo.DataSource = DataServices.HeSoCoSo.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void gridViewCoSo_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaCoSo")
            {
                HeSoCoSo h = gridViewCoSo.GetRow(e.RowHandle) as HeSoCoSo;
                string _maCoSo = _listCoSo.Find(p=>p.MaCoSo == h.MaCoSo).MaCoSo;

                gridViewCoSo.SetRowCellValue(e.RowHandle, "", _maCoSo);
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepHeSoCoSo"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepHeSoCoSo"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();

        }
    }
}