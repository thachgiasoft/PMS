using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;
using DevExpress.XtraEditors;
using PMS.Core;
using PMS.Entities.Validation;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoCongViec : DevExpress.XtraEditors.XtraUserControl
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
        string _maTruong, _cauHinhHeSoTheoNam;
        TList<LoaiKhoiLuong> _listCongViec = new TList<LoaiKhoiLuong>();
        #endregion
        public ucHeSoCongViec()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucHeSoCongViec_Load(object sender, EventArgs e)
        {
            #region InitGridView
            switch (_maTruong)
            { 
                case "VHU":
                    InitGridVHU();
                    break;
                case "LAW":
                    InitGridLAW();
                    break;
                default:
                    InitDefault();
                    break;
            }
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

            #region CongViec
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditCongViec, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditCongViec, new string[] { "MaLoaiKhoiLuong", "TenLoaiKhoiLuong" }, new string[] { "Mã công việc", "Tên công việc" }, new int[] { 100, 300 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditCongViec, 400, 650);
            repositoryItemGridLookUpEditCongViec.ValueMember = "MaLoaiKhoiLuong";
            repositoryItemGridLookUpEditCongViec.DisplayMember = "MaLoaiKhoiLuong";
            repositoryItemGridLookUpEditCongViec.NullText = string.Empty;
            #endregion

           InitData();
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            _listCongViec = DataServices.LoaiKhoiLuong.GetAll();
            bindingSourceCongViec.DataSource = _listCongViec;

            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoCongViec.DataSource = DataServices.HeSoCongViec.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        #region InitGrid
        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewHeSoCongViec, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoCongViec, new string[] { "MaQuanLy", "TenCongViec", "HeSo" },
                        new string[] { "Mã công việc", "Tên công việc", "Hệ số" },
                        new int[] { 100, 200, 100 });
            AppGridView.ShowEditor(gridViewHeSoCongViec, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoCongViec, new string[] { "MaQuanLy", "TenCongViec", "HeSo" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSoCongViec, "HeSo", repositoryItemSpinEditHeSo);
           
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        
        }

        void InitGridLAW()
        {
            AppGridView.InitGridView(gridViewHeSoCongViec, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoCongViec, new string[] { "MaQuanLy", "TenCongViec", "HeSo" },
                        new string[] { "Mã công việc", "Tên công việc", "Hệ số" },
                        new int[] { 100, 300, 100 });
            AppGridView.ShowEditor(gridViewHeSoCongViec, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoCongViec, new string[] { "MaQuanLy", "TenCongViec", "HeSo" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSoCongViec, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.RegisterControlField(gridViewHeSoCongViec, "MaQuanLy", repositoryItemGridLookUpEditCongViec);

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitDefault()
        {
            AppGridView.InitGridView(gridViewHeSoCongViec, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoCongViec, new string[] { "MaQuanLy", "TenCongViec", "HeSo", "NgayBdApDung", "NgayKtApDung" },
                        new string[] { "Mã công việc", "Tên công việc", "Hệ số", "Ngày BD áp dụng", "Ngày KT áp dụng" },
                        new int[] { 100, 200, 100, 150, 150 });
            AppGridView.ShowEditor(gridViewHeSoCongViec, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoCongViec, new string[] { "MaQuanLy", "TenCongViec", "HeSo", "NgayBdApDung", "NgayKtApDung" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSoCongViec, "HeSo", repositoryItemSpinEditHeSo);
            if (_maTruong != "LAW")
                AppGridView.HideField(gridViewHeSoCongViec, new string[] { "NgayBdApDung", "NgayKtApDung" });
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceHeSoCongViec.DataSource = DataServices.HeSoCongViec.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoCongViec);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoCongViec.FocusedRowHandle = -1;
            TList<HeSoCongViec> list = bindingSourceHeSoCongViec.DataSource as TList<HeSoCongViec>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (HeSoCongViec d in list)
                            {
                                d.NamHoc = cboNamHoc.EditValue.ToString();
                                d.HocKy = cboHocKy.EditValue.ToString();
                            }
                            bindingSourceHeSoCongViec.EndEdit();
                            DataServices.HeSoCongViec.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewHeSoCongViec, barManager1, layoutControl1 });
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

        private void gridViewHeSoCongViec_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoCongViec, e);
        }

        private void gridViewHeSoCongViec_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHeSoCongViec, e);
        }

        private void gridViewHeSoCongViec_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            HeSoCongViec obj = e.Row as HeSoCongViec;
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

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            HeSoCongViec obj = target as HeSoCongViec;
            if (obj != null)
            {
                if (((TList<HeSoCongViec>)bindingSourceHeSoCongViec.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã quy đổi {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewHeSoCongViec_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoCongViec.DataSource = DataServices.HeSoCongViec.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoCongViec.DataSource = DataServices.HeSoCongViec.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepHeSoCongViec"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepHeSoCongViec"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }

        private void gridViewHeSoCongViec_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "MaQuanLy")
                {
                    HeSoCongViec h = gridViewHeSoCongViec.GetRow(e.RowHandle) as HeSoCongViec;
                    string _tenCongViec = _listCongViec.Find(p => p.MaLoaiKhoiLuong == h.MaQuanLy).TenLoaiKhoiLuong;
                    gridViewHeSoCongViec.SetRowCellValue(e.RowHandle, "TenCongViec", _tenCongViec);
                }
            }
            catch
            { }
        }
    }
}
