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

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucNhomMonHoc : UserControl
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
        string _maTruong;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion

        public ucNhomMonHoc()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucNhomMonHoc_Load(object sender, EventArgs e)
        {
            #region InitGridView
            switch (_maTruong)
            {
                case "LAW":
                    InitGridLAW();
                    break;
                case "DLU":
                    InitGridDLU();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion

            #region NhomThucHanh
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomThucHanh, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomThucHanh, new string[] { "TenNhomThucHanh" }, new string[] { "Nhóm thực hành" });
            repositoryItemGridLookUpEditNhomThucHanh.DisplayMember = "TenNhomThucHanh";
            repositoryItemGridLookUpEditNhomThucHanh.ValueMember = "MaNhomThucHanh";
            repositoryItemGridLookUpEditNhomThucHanh.NullText = string.Empty;
            repositoryItemGridLookUpEditNhomThucHanh.BestFitMode = BestFitMode.BestFit;
            #endregion

            InitData();
        }

        #region InitGrid
        void InitGridLAW()
        {
            AppGridView.InitGridView(gridViewNhomMonHoc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewNhomMonHoc, new string[] { "MaQuanLy", "TenNhomMon", "MucThanhToan" },
                        new string[] { "Mã nhóm môn", "Tên nhóm môn", "Mức thanh toán (%)" },
                        new int[] { 100, 500, 100 });
            AppGridView.ShowEditor(gridViewNhomMonHoc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewNhomMonHoc, new string[] { "MaQuanLy", "TenNhomMon", "MucThanhToan" }, DevExpress.Utils.HorzAlignment.Center);
        }

        void InitGridDLU()
        {
            AppGridView.InitGridView(gridViewNhomMonHoc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewNhomMonHoc, new string[] { "MaQuanLy", "TenNhomMon", "SiSoNhomThucHanh", "HeSoQuyDoiThSangLt", "MucThanhToan" },
                        new string[] { "Mã nhóm môn", "Tên nhóm môn", "Si số nhóm thực hành", "HS quy đổi TH sang LT", "Thực hành chuyên nghiệp" },
                        new int[] { 100, 400, 120, 130, 150 });
            AppGridView.ShowEditor(gridViewNhomMonHoc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewNhomMonHoc, new string[] { "MaQuanLy", "TenNhomMon", "SiSoNhomThucHanh", "HeSoQuyDoiThSangLt", "MucThanhToan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewNhomMonHoc, "MucThanhToan", repositoryItemGridLookUpEditNhomThucHanh);
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewNhomMonHoc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewNhomMonHoc, new string[] { "MaQuanLy", "TenNhomMon" },
                        new string[] { "Mã nhóm môn", "Tên nhóm môn" },
                        new int[] { 100, 500 });
            AppGridView.ShowEditor(gridViewNhomMonHoc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewNhomMonHoc, new string[] { "MaQuanLy", "TenNhomMon" }, DevExpress.Utils.HorzAlignment.Center);
        }
        #endregion

        #region InitData
        private void InitData()
        {
            InitNhomThucHanh();
            bindingSourceNhomMonHoc.DataSource = DataServices.NhomMonHoc.GetAll();
        }

        void InitNhomThucHanh()
        {
            DataTable tb = new DataTable();
            DataColumn col1 = new DataColumn("MaNhomThucHanh", typeof(decimal));
            DataColumn col2 = new DataColumn("TenNhomThucHanh", typeof(string));

            tb.Columns.Add(col1);
            tb.Columns.Add(col2);

            DataRow r1 = tb.NewRow();
            r1["MaNhomThucHanh"] = 1;
            r1["TenNhomThucHanh"] = "Thực hành đại cương";
            DataRow r2 = tb.NewRow();
            r2["MaNhomThucHanh"] = 2;
            r2["TenNhomThucHanh"] = "Thực hành chuyên nghiệp";
            tb.Rows.Add(r1);
            tb.Rows.Add(r2);

            bindingSourceNhomThucHanh.DataSource = tb;
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
            AppGridView.DeleteSelectedRows(gridViewNhomMonHoc);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewNhomMonHoc.FocusedRowHandle = -1;
            TList<NhomMonHoc> list = bindingSourceNhomMonHoc.DataSource as TList<NhomMonHoc>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceNhomMonHoc.EndEdit();
                            DataServices.NhomMonHoc.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewNhomMonHoc, barManager1, layoutControl1 });
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

        private void gridViewNhomMonHoc_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewNhomMonHoc, e);
        }

        private void gridViewNhomMonHoc_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewNhomMonHoc, e);
        }

        private void gridViewNhomMonHoc_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            NhomMonHoc obj = e.Row as NhomMonHoc;
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
            NhomMonHoc obj = target as NhomMonHoc;
            if (obj != null)
            {
                if (((TList<NhomMonHoc>)bindingSourceNhomMonHoc.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã quy đổi {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewNhomMonHoc_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridViewNhomMonHoc_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    sf.ShowDialog();
                    if (sf.FileName != "")
                    {
                        gridControlNhomMonHoc.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }
    }
}
