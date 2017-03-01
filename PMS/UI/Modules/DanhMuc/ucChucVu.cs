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
using System.IO;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucChucVu : XtraUserControl
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

        TList<CauHinhChung> _listCauHinh = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        public ucChucVu()
        {
            InitializeComponent();
            _maTruong = _listCauHinh.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucChucVu_Load(object sender, EventArgs e)
        {
            #region Init GridView ChucVu
            switch (_maTruong)
            { 
                case "CDGTVT":
                    InitGridCDGTVT();
                    break;
                case "VHU":
                    InitGridVHU();
                    break;
                case "LAW":
                    InitGridVHU();
                    break;
                case "IUH":
                    InitGridIUH();
                    break;
                case "HBU":
                    InitGridVHU();
                    break;
                case "DLU":
                    InitGridVHU();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            
            #endregion

            #region Init DataSource
            bindingSourceChucVu.DataSource = DataServices.ChucVu.GetAll();
            #endregion
        }

        #region InitGridView
        void InitGridCDGTVT()
        {
            AppGridView.InitGridView(gridViewChucVu, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewChucVu, new string[] { "ThuTu", "MaQuanLy", "TenChucVu", "CongDonKiemNhiem" },
                new string[] { "STT", "Mã chức vụ", "Tên chức vụ", "Kiêm nhiệm" },
                new int[] { 70, 100, 400, 90 });
            AppGridView.ShowEditor(gridViewChucVu, NewItemRowPosition.Top);
        }

        //VHU - LAW giống nhau
        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewChucVu, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewChucVu, new string[] { "ThuTu", "MaQuanLy", "TenChucVu" },
                new string[] { "STT", "Mã chức vụ", "Tên chức vụ" },
                new int[] { 70, 100, 400 });
            AppGridView.ShowEditor(gridViewChucVu, NewItemRowPosition.Top);
        }

        void InitGridIUH()
        {
            AppGridView.InitGridView(gridViewChucVu, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewChucVu, new string[] { "ThuTu", "MaQuanLy", "TenChucVu", "CongDonKiemNhiem" },
                new string[] { "STT", "Mã chức vụ", "Tên chức vụ", "Có định mức coi thi" },
                new int[] { 70, 100, 400, 150 });
            AppGridView.ShowEditor(gridViewChucVu, NewItemRowPosition.Top);
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewChucVu, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewChucVu, new string[] { "ThuTu", "MaQuanLy", "TenChucVu", "SoTiet", "PhanTramGio", "NguongTiet" },
                new string[] { "STT", "Mã chức vụ", "Tên chức vụ", "Số tiết định mức", "% Giờ", "Ngưỡng tiết" },
                new int[] { 70, 100, 400, 120, 70, 90 });
            AppGridView.RegisterControlField(gridViewChucVu, "SoTiet", repositoryItemSpinEditSoGio);
            AppGridView.RegisterControlField(gridViewChucVu, "PhanTramGio", repositoryItemSpinEditPhanTramGio);
            AppGridView.RegisterControlField(gridViewChucVu, "NguongTiet", repositoryItemSpinEditNguongTiet);
            AppGridView.ShowEditor(gridViewChucVu, NewItemRowPosition.Top);
            if (_maTruong == "UEL" || _maTruong == "IUH" || _maTruong == "CDGTVT")
                AppGridView.HideField(gridViewChucVu, new string[] { "SoTiet", "PhanTramGio", "NguongTiet" });
            if (_maTruong == "CTIM")
                AppGridView.HideField(gridViewChucVu, new string[] { "SoTiet", "NguongTiet" });
        }
        #endregion

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ChucVu obj = gridViewChucVu.GetFocusedRow() as ChucVu;
            if (obj != null)
            {
                if (obj.EntityState == EntityState.Changed)
                    obj.CancelChanges();
                else
                    RestoreDeletedItems();
            }
            else
                RestoreDeletedItems();            
            gridViewChucVu.RefreshData();
        }

        private void RestoreDeletedItems()
        {
            TList<ChucVu> list = bindingSourceChucVu.DataSource as TList<ChucVu>;
            if (list != null)
            {
                if (list.DeletedItems.Count > 0)
                {
                    foreach (ChucVu c in list.DeletedItems)
                    {
                        c.EntityState = EntityState.Changed;
                        list.Add(c);
                        list.DeletedItems.Remove(c);
                        break;
                    }
                }
            }
        }

        private void gridViewChucVu_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewChucVu, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewChucVu.FocusedRowHandle = -1;
            TList<ChucVu> list = bindingSourceChucVu.DataSource as TList<ChucVu>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceChucVu.EndEdit();
                            DataServices.ChucVu.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewChucVu, barManager1, layoutControl1 });
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
            bindingSourceChucVu.DataSource = DataServices.ChucVu.GetAll();
            Cursor.Current = Cursors.Default;
        }

        private void gridViewChucVu_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewChucVu, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            ChucVu obj = target as ChucVu;
            if (obj != null)
            {
                if (((TList<ChucVu>)bindingSourceChucVu.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã chức vụ {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewChucVu_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            ChucVu obj = e.Row as ChucVu;
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

        private void gridViewChucVu_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewChucVu);
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
                    gridControlChucVu.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}