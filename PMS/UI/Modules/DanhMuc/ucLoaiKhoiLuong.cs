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
    public partial class ucLoaiKhoiLuong : XtraUserControl
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
        public ucLoaiKhoiLuong()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucLoaiKhoiLuong_Load(object sender, EventArgs e)
        {
            #region Init GridView LoaiKhoiLuong
            switch (_maTruong)
            { 
                case "ACT":
                    InitGridAct();
                    break;
                case "CDGTVT":
                    InitGridCDGTVT();
                    break;
                case "IUH":
                    InitGridIUH();
                    break;
                case "LAW":
                    InitGridIUH();
                    break;
                case "VHU":
                    InitGridVHU();
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

            #region RepositoryItemGridLookUpEdit Nhom khoi luong
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomKhoiLuong, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomKhoiLuong, new string[] { "MaQuanLy", "TenNhom" }, new string[] { "Mã nhóm", "Tên nhóm" });
            repositoryItemGridLookUpEditNhomKhoiLuong.ValueMember = "MaNhom";
            repositoryItemGridLookUpEditNhomKhoiLuong.DisplayMember = "TenNhom";
            repositoryItemGridLookUpEditNhomKhoiLuong.NullText = string.Empty;
            #endregion

            #region Init Datasource
            bindingSourceLoaiKhoiLuong.DataSource = DataServices.LoaiKhoiLuong.GetAll();
            bindingSourceNhomKhoiLuong.DataSource = DataServices.NhomKhoiLuong.GetAll();
            //PMS.Common.Globals.LoadLayout(Tag as AppModule, new object[] { gridViewLoaiKhoiLuong, barManager1, layoutControl1 });
            #endregion
        }
        #endregion

        #region InitData

        #endregion

        #region InitGrid
        void InitGridAct()
        {
            AppGridView.InitGridView(gridViewLoaiKhoiLuong, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewLoaiKhoiLuong, new string[] { "MaLoaiKhoiLuong", "TenLoaiKhoiLuong", "NghiaVu" },
                new string[] { "Mã loại khối lượng", "Tên loại khối lượng", "Tính vào khối lượng khác" },
                new int[] { 150, 400, 200 });
            AppGridView.ShowEditor(gridViewLoaiKhoiLuong, NewItemRowPosition.Top);
        }

        void InitGridCDGTVT()
        {
            AppGridView.InitGridView(gridViewLoaiKhoiLuong, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewLoaiKhoiLuong, new string[] { "MaLoaiKhoiLuong", "TenLoaiKhoiLuong", "HeSo" },
                new string[] { "Mã loại khối lượng", "Tên loại khối lượng", "Hệ số" },
                new int[] { 120, 250, 80 });
            AppGridView.RegisterControlField(gridViewLoaiKhoiLuong, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.ShowEditor(gridViewLoaiKhoiLuong, NewItemRowPosition.Top);
        }

        //IUH - LAW giống nhau
        void InitGridIUH()
        {
            AppGridView.InitGridView(gridViewLoaiKhoiLuong, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewLoaiKhoiLuong, new string[] { "MaLoaiKhoiLuong", "TenLoaiKhoiLuong" },
                new string[] { "Mã loại khối lượng", "Tên loại khối lượng" },
                new int[] { 120, 250 });
            AppGridView.ShowEditor(gridViewLoaiKhoiLuong, NewItemRowPosition.Top);
        }

        //Đại học Văn Hiến
        private void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewLoaiKhoiLuong, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewLoaiKhoiLuong, new string[] { "MaLoaiKhoiLuong", "TenLoaiKhoiLuong", "NghiaVu" },
                new string[] { "Mã loại khối lượng", "Tên loại khối lượng", "Nghĩa vụ" },
                new int[] { 110, 300, 70 });
            AppGridView.ShowEditor(gridViewLoaiKhoiLuong, NewItemRowPosition.Top);
            AppGridView.HideField(gridViewLoaiKhoiLuong, new string[] { "NghiaVu" });
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewLoaiKhoiLuong, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewLoaiKhoiLuong, new string[] { "MaNhom", "MaLoaiKhoiLuong", "TenLoaiKhoiLuong", "HeSo", "NghiaVu" },
                new string[] { "Nhóm", "Mã loại", "Tên loại", "Hệ số", "Nghĩa vụ" },
                new int[] { 120, 100, 200, 80, 80 });
            AppGridView.RegisterControlField(gridViewLoaiKhoiLuong, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.RegisterControlField(gridViewLoaiKhoiLuong, "MaNhom", repositoryItemGridLookUpEditNhomKhoiLuong);
            AppGridView.UnSortField(gridViewLoaiKhoiLuong, new string[] { "NghiaVu" });
            AppGridView.ShowEditor(gridViewLoaiKhoiLuong, NewItemRowPosition.Top);
            if (_maTruong == "USSH")
                AppGridView.HideField(gridViewLoaiKhoiLuong, new string[] { "MaNhom", "HeSo", "NghiaVu" });
            if (_maTruong == "UTE")
                AppGridView.HideField(gridViewLoaiKhoiLuong, new string[] { "MaNhom", "NghiaVu" });
        }
        #endregion

        #region Event Button
        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoaiKhoiLuong obj = bindingSourceLoaiKhoiLuong.Current as LoaiKhoiLuong;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceLoaiKhoiLuong.Remove(obj);
                else
                    obj.CancelChanges();
                gridViewLoaiKhoiLuong.RefreshData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewLoaiKhoiLuong.FocusedRowHandle = -1;
            TList<LoaiKhoiLuong> list = bindingSourceLoaiKhoiLuong.DataSource as TList<LoaiKhoiLuong>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceLoaiKhoiLuong.EndEdit();
                            DataServices.LoaiKhoiLuong.Save(list);
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
            bindingSourceLoaiKhoiLuong.DataSource = DataServices.LoaiKhoiLuong.GetAll();
            bindingSourceNhomKhoiLuong.DataSource = DataServices.NhomKhoiLuong.GetAll();
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

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            LoaiKhoiLuong obj = target as LoaiKhoiLuong;
            if (obj != null)
            {
                if (((TList<LoaiKhoiLuong>)bindingSourceLoaiKhoiLuong.DataSource).FindAll(p => p.MaLoaiKhoiLuong == obj.MaLoaiKhoiLuong).Count > 1)
                {
                    e.Description = string.Format("Mã loại {0} hiện tại đã có.", obj.MaLoaiKhoiLuong);
                    return false;
                }
            }
            return true;
        }

        private void gridViewLoaiKhoiLuong_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            LoaiKhoiLuong obj = e.Row as LoaiKhoiLuong;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaLoaiKhoiLuong");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void gridViewLoaiKhoiLuong_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridViewLoaiKhoiLuong_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            LoaiKhoiLuong obj = gridViewLoaiKhoiLuong.GetRow(e.RowHandle) as LoaiKhoiLuong;
            if (obj != null)
                obj.NghiaVu = false;
        }

        #endregion
    }
}