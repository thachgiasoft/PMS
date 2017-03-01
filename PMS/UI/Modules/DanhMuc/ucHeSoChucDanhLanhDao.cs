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
using DevExpress.XtraGrid.Views.Grid;
using PMS.Services;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoChucDanhLanhDao : DevExpress.XtraEditors.XtraUserControl
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
        public ucHeSoChucDanhLanhDao()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucHeSoChucDanhLanhDao_Load(object sender, EventArgs e)
        {
            #region Init gridview
            switch (_maTruong)
            { 
                case "BUH":
                    InitGridBUH();
                    break;
                default:
                    InitGridRemaining();
                    break;
            }
            #endregion
            
            InitData();
        }

        #region InitData
        private void InitData()
        {
            bindingSourceHeSoChucDanhLanhDao.DataSource = DataServices.ChucVu.GetAll();
        }

        void InitGridBUH()
        {
            AppGridView.InitGridView(gridViewHeSoChucDanhLanhDao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoChucDanhLanhDao, new string[] { "ThuTu", "MaQuanLy", "TenChucVu", "DinhMucToiThieu", "CongDonKiemNhiem", "NgayBdApDung", "NgayKtApDung" },
                        new string[] { "STT", "Mã chức vụ", "Tên chức vụ", "Định mức tối thiểu (%)", "Chức vụ thuộc phòng ban", "Ngày BD áp dụng", "Ngày KT áp dụng" },
                        new int[] { 70, 70, 300, 150, 150, 150, 150 });
            AppGridView.AlignHeader(gridViewHeSoChucDanhLanhDao, new string[] { "ThuTu", "MaQuanLy", "TenChucVu", "DinhMucToiThieu", "CongDonKiemNhiem", "NgayBdApDung", "NgayKtApDung" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ShowEditor(gridViewHeSoChucDanhLanhDao, NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewHeSoChucDanhLanhDao, "DinhMucToiThieu", repositoryItemSpinEditDinhMucToiThieu);
            AppGridView.HideField(gridViewHeSoChucDanhLanhDao, new string[] { "NgayBdApDung", "NgayKtApDung" });
        }

        void InitGridRemaining()
        {
            AppGridView.InitGridView(gridViewHeSoChucDanhLanhDao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoChucDanhLanhDao, new string[] { "ThuTu", "MaQuanLy", "TenChucVu", "DinhMucToiThieu", "CongDonKiemNhiem", "NgayBdApDung", "NgayKtApDung" },
                        new string[] { "STT", "Mã chức vụ", "Tên chức vụ", "Định mức tối thiểu (%)", "Cộng dồn", "Ngày BD áp dụng", "Ngày KT áp dụng" },
                        new int[] { 70, 70, 300, 150, 100, 150, 150 });
            AppGridView.AlignHeader(gridViewHeSoChucDanhLanhDao, new string[] { "ThuTu", "MaQuanLy", "TenChucVu", "DinhMucToiThieu", "CongDonKiemNhiem", "NgayBdApDung", "NgayKtApDung" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ShowEditor(gridViewHeSoChucDanhLanhDao, NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewHeSoChucDanhLanhDao, "DinhMucToiThieu", repositoryItemSpinEditDinhMucToiThieu);
            if (_maTruong != "LAW")
                AppGridView.HideField(gridViewHeSoChucDanhLanhDao, new string[] { "NgayBdApDung", "NgayKtApDung" });
            if (_maTruong != "UTE")
                AppGridView.HideField(gridViewHeSoChucDanhLanhDao, new string[] { "CongDonKiemNhiem" });
            if (_maTruong == "USSH")
                gridViewHeSoChucDanhLanhDao.Columns["DinhMucToiThieu"].Caption = "Phần trăm miễn giảm";
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
            AppGridView.DeleteSelectedRows(gridViewHeSoChucDanhLanhDao);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoChucDanhLanhDao.FocusedRowHandle = -1;
            TList<ChucVu> list = bindingSourceHeSoChucDanhLanhDao.DataSource as TList<ChucVu>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHeSoChucDanhLanhDao.EndEdit();
                            DataServices.ChucVu.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewHeSoChucDanhLanhDao, barManager1, layoutControl1 });

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

        private void gridViewHeSoChucDanhLanhDao_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoChucDanhLanhDao, e);
        }

        private void gridViewHeSoChucDanhLanhDao_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHeSoChucDanhLanhDao, e);
        }

        private void gridViewHeSoChucDanhLanhDao_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
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

            try
            {
                if (obj.DinhMucToiThieu > 100)
                {
                    XtraMessageBox.Show("Định mức không được lớn hơn 100.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                    return;
                }
               
            }
            catch
            { }
                
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            ChucVu obj = target as ChucVu;
            if (obj != null)
            {
                if (((TList<ChucVu>)bindingSourceHeSoChucDanhLanhDao.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã quy đổi {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }

             
            }
            return true;
        }

        private void gridViewHeSoChucDanhLanhDao_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlHeSoChucDanhLanhDao.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}
