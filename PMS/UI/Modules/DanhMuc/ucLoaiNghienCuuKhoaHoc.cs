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
using DevExpress.XtraGrid.Views.Grid;
using PMS.Core;
using PMS.Entities.Validation;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucLoaiNghienCuuKhoaHoc : DevExpress.XtraEditors.XtraUserControl
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
        public ucLoaiNghienCuuKhoaHoc()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucLoaiNghienCuuKhoaHoc_Load(object sender, EventArgs e)
        {
            #region Init GridView LoaiNghienCuuKhoaHoc
            switch (_maTruong)
            { 
                //case "ACT":
                //    InitGridAct();
                //    break;
                //case "CDGTVT":
                //    InitGridCDGTVT();
                //    break;
                //case "IUH":
                //    InitGridIUH();
                //    break;
                //case "LAW":
                //    InitGridIUH();
                //    break;
                case "VHU":
                    InitGridVHU();
                    break;
                case "DLU":
                    InitGridDLU();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion

            InitData();
        }
        #endregion

        #region InitData
        private void InitData()
        {
            bindingSourceLoaiNghienCuuKhoaHoc.DataSource = DataServices.LoaiNghienCuuKhoaHoc.GetAll();
        }
        #endregion

        #region InitGrid
        //Đại học Văn Hiến
        private void InitGridVHU()
        {
            AppGridView.InitGridView(gridView1, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridView1, new string[] { "MaLoaiNckh", "TenLoaiNckh", "GhiChu" },
                new string[] { "Mã loại nghiên cứu khoa học", "Tên loại nghiên cứu khoa học", "Ghi chú" },
                new int[] { 200, 300, 400 });
            AppGridView.ShowEditor(gridView1, NewItemRowPosition.Top);
        }

        void InitGridDLU()
        {
            AppGridView.InitGridView(gridView1, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridView1, new string[] { "MaLoaiNckh", "TenLoaiNckh", "ChuTriDeTaiHuong", "ThanhVienHuong", "GhiChu" },
                new string[] { "Mã loại nghiên cứu khoa học", "Tên loại nghiên cứu khoa học", "(%) Chủ trì, chủ biên được hưởng", "(%) Các thành viên được hưởng", "Ghi chú" },
                new int[] { 100, 300, 100, 100, 400 });
            AppGridView.ShowEditor(gridView1, NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridView1, new string[] { "MaLoaiNckh", "TenLoaiNckh", "ChuTriDeTaiHuong", "ThanhVienHuong", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            PMS.Common.Globals.WordWrapHeader(gridView1, 40);
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridView1, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridView1, new string[] { "MaLoaiNckh", "TenLoaiNckh", "GhiChu" },
                new string[] { "Mã loại nghiên cứu khoa học", "Tên loại nghiên cứu khoa học", "Ghi chú" },
                new int[] { 200, 300, 400 });
            AppGridView.ShowEditor(gridView1, NewItemRowPosition.Top);
         }
        #endregion

        #region Event Button
        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoaiNghienCuuKhoaHoc obj = bindingSourceLoaiNghienCuuKhoaHoc.Current as LoaiNghienCuuKhoaHoc;
            if (obj != null)
            {
                if (obj.IsNew)
                    bindingSourceLoaiNghienCuuKhoaHoc.Remove(obj);
                else
                    obj.CancelChanges();
                gridView1.RefreshData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.FocusedRowHandle = -1;
            TList<LoaiNghienCuuKhoaHoc> list = bindingSourceLoaiNghienCuuKhoaHoc.DataSource as TList<LoaiNghienCuuKhoaHoc>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceLoaiNghienCuuKhoaHoc.EndEdit();
                            DataServices.LoaiNghienCuuKhoaHoc.Save(list);
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridView1);
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
                    gridControl1.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
        #endregion

        #region Event Grid

        private void gridView1_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridView1, e);
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridView1, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            LoaiNghienCuuKhoaHoc obj = target as LoaiNghienCuuKhoaHoc;
            if (obj != null)
            {
                if (((TList<LoaiNghienCuuKhoaHoc>)bindingSourceLoaiNghienCuuKhoaHoc.DataSource).FindAll(p => p.MaLoaiNckh == obj.MaLoaiNckh).Count > 1)
                {
                    e.Description = string.Format("Mã loại {0} hiện tại đã có.", obj.MaLoaiNckh);
                    return false;
                }
            }
            return true;
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            LoaiNghienCuuKhoaHoc obj = e.Row as LoaiNghienCuuKhoaHoc;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaLoaiNghienCuuKhoaHoc");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            LoaiNghienCuuKhoaHoc obj = gridView1.GetRow(e.RowHandle) as LoaiNghienCuuKhoaHoc;
        }

        #endregion
    }
}
