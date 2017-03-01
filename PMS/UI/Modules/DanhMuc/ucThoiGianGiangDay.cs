using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;
using PMS.Entities.Validation;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucThoiGianGiangDay : DevExpress.XtraEditors.XtraUserControl
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

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        public ucThoiGianGiangDay()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucThoiGianGiangDay_Load(object sender, EventArgs e)
        {
            #region Init GridView
            switch (_maTruong)
            { 
                case "CDGTVT":
                    InitGridCDGTVT();
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

            #region _namHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNamHoc, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            repositoryItemGridLookUpEditNamHoc.DisplayMember = "NamHoc";
            repositoryItemGridLookUpEditNamHoc.ValueMember = "NamHoc";
            repositoryItemGridLookUpEditNamHoc.NullText = string.Empty;
            #endregion
            #region _hocKy
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocKy, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            repositoryItemGridLookUpEditHocKy.DisplayMember = "TenHocKy";
            repositoryItemGridLookUpEditHocKy.ValueMember = "MaHocKy";
            repositoryItemGridLookUpEditHocKy.NullText = string.Empty;
            #endregion
            if (_maTruong != "ACT")
                lblGhiChu.Visible = false;

            InitData();
        }
        #region InitGridView
        void InitGridCDGTVT()
        {
            AppGridView.InitGridView(gridViewThoiGian, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewThoiGian, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewThoiGian, new string[] { "NamHoc", "HocKy", "NgayBatDau", "NgayKetThuc" }
                , new string[] { "Năm học", "Học kỳ", "Ngày bắt đầu", "Ngày kết thúc" }
                , new int[] { 150, 150, 150, 150 });
            AppGridView.AlignHeader(gridViewThoiGian, new string[] { "NamHoc", "HocKy", "NgayBatDau", "NgayKetThuc" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewThoiGian, "NamHoc", repositoryItemGridLookUpEditNamHoc);
            AppGridView.RegisterControlField(gridViewThoiGian, "NgayBatDau", repositoryItemDateEditNgayBD);
            AppGridView.RegisterControlField(gridViewThoiGian, "NgayKetThuc", repositoryItemDateEditNgayKT);
            AppGridView.HideField(gridViewThoiGian, new string[] { "HocKy" });
        }

        void InitGridVHU()
        {
            //Theo năm
            AppGridView.InitGridView(gridViewThoiGian, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewThoiGian, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewThoiGian, new string[] { "NamHoc", "HocKy", "NgayBatDau", "NgayKetThuc" }
                , new string[] { "Năm học", "Học kỳ", "Ngày bắt đầu", "Ngày kết thúc" }
                , new int[] { 150, 150, 150, 150 });
            AppGridView.AlignHeader(gridViewThoiGian, new string[] { "NamHoc", "HocKy", "NgayBatDau", "NgayKetThuc" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewThoiGian, "NamHoc", repositoryItemGridLookUpEditNamHoc);
            AppGridView.RegisterControlField(gridViewThoiGian, "HocKy", repositoryItemGridLookUpEditHocKy);
            AppGridView.RegisterControlField(gridViewThoiGian, "NgayBatDau", repositoryItemDateEditNgayBD);
            AppGridView.RegisterControlField(gridViewThoiGian, "NgayKetThuc", repositoryItemDateEditNgayKT);
            AppGridView.HideField(gridViewThoiGian, new string[] { "HocKy" });
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewThoiGian, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewThoiGian, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewThoiGian, new string[] { "NamHoc", "HocKy", "NgayBatDau", "NgayKetThuc" }
                , new string[] { "Năm học", "Học kỳ", "Ngày bắt đầu", "Ngày kết thúc" }
                , new int[] { 150, 150, 150, 150 });
            AppGridView.AlignHeader(gridViewThoiGian, new string[] { "NamHoc", "HocKy", "NgayBatDau", "NgayKetThuc" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewThoiGian, "NamHoc", repositoryItemGridLookUpEditNamHoc);
            AppGridView.RegisterControlField(gridViewThoiGian, "HocKy", repositoryItemGridLookUpEditHocKy);
            AppGridView.RegisterControlField(gridViewThoiGian, "NgayBatDau", repositoryItemDateEditNgayBD);
            AppGridView.RegisterControlField(gridViewThoiGian, "NgayKetThuc", repositoryItemDateEditNgayKT);
        }
        #endregion
        #region Init Data
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetAll();
            bindingSourceThoiGian.DataSource = DataServices.ThoiGianGiangDay.GetAll();
        }
        #endregion

        private void gridViewThoiGian_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "NamHoc")
            {
                int pos = e.RowHandle;
                object r = gridViewThoiGian.GetRow(pos);

                ThoiGianGiangDay dt = (ThoiGianGiangDay)r;
                //bindingSourceHocKy.Filter = "_namHoc = " + dt._namHoc;
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(dt.NamHoc);

                //Nếu các trường cấu hình hệ số theo năm
                if (_maTruong == "CDGTVT" || _maTruong == "VHU" || _maTruong == "HBU" || _maTruong == "DLU")
                {
                    gridViewThoiGian.SetRowCellValue(e.RowHandle, "HocKy", "TinhTheoNam");
                }
            }
        }
        #region Event Button
        private void btnLamToi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewThoiGian);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThoiGian.FocusedRowHandle = -1;
            TList<ThoiGianGiangDay> list = bindingSourceThoiGian.DataSource as TList<ThoiGianGiangDay>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        bindingSourceThoiGian.EndEdit();
                        DataServices.ThoiGianGiangDay.Save(list);
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void gridViewThoiGian_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewThoiGian, e);
        }

        private void gridViewThoiGian_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            ThoiGianGiangDay obj = target as ThoiGianGiangDay;
            if (obj != null)
            {
                if (((TList<ThoiGianGiangDay>)bindingSourceThoiGian.DataSource).FindAll(p => p.NamHoc == obj.NamHoc & p.HocKy == obj.HocKy).Count > 1)
                {
                    e.Description = string.Format("Năm học {0} - {1} hiện tại đã có.", obj.NamHoc, obj.HocKy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewThoiGian_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            ThoiGianGiangDay obj = e.Row as ThoiGianGiangDay;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "NamHoc, HocKy");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
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
                    gridControlThoiGian.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }
    }
}
