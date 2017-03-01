using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities;
using PMS.BLL;
using PMS.Entities.Validation;
using DevExpress.XtraGrid.Columns;
using PMS.Services;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucDonGiaChatLuongCao : DevExpress.XtraEditors.XtraUserControl
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

        public ucDonGiaChatLuongCao()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucDonGiaChatLuongCao_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewDonGiaClc, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDonGiaClc, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDonGiaClc, new string[] {"PhanLoaiGiangVien","NhomMonHoc","MaHocVi","DonGia","GhiChu","NgayCapNhat","NguoiCapNhat" }
                        , new string[] { "Phân loại giảng viên", "Nhóm môn học", "Học vị", "Đơn giá", "Ghi chú", "Ngày cập nhật", "Người cập nhật" }
                        , new int[] { 200, 150, 120, 100, 130, 100, 100 });
            AppGridView.AlignHeader(gridViewDonGiaClc, new string[] { "PhanLoaiGiangVien", "NhomMonHoc", "MaHocVi", "DonGia", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewDonGiaClc, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewDonGiaClc, "NhomMonHoc", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.RegisterControlField(gridViewDonGiaClc, "PhanLoaiGiangVien", repositoryItemGridLookUpEditPhanLoaiGiangVien);
            AppGridView.FormatDataField(gridViewDonGiaClc, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewDonGiaClc, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion


            #region HocVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocVi, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocVi, new string[] { "MaQuanLy", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" }, new int[] { 100, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditHocVi, 300, 400);
            repositoryItemGridLookUpEditHocVi.ValueMember = "MaHocVi";
            repositoryItemGridLookUpEditHocVi.DisplayMember = "TenHocVi";
            repositoryItemGridLookUpEditHocVi.NullText = string.Empty;
            #endregion

            #region NhomMonHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomMonHoc, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomMonHoc, new string[] { "MaQuanLy", "TenNhomMon" }, new string[] { "Mã nhóm môn", "Tên nhóm môn" }, new int[] { 100, 200 });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditNhomMonHoc, 300, 400);
            repositoryItemGridLookUpEditNhomMonHoc.ValueMember = "MaNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.DisplayMember = "TenNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.NullText = string.Empty;
            #endregion

            InitData();
        }

        void InitPhanLoaiGiangVien()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(new DataColumn("PhanLoai"));
            tbl.Columns["PhanLoai"].Caption = "Phân loại";
            tbl.Columns.Add(new DataColumn("TenPhanLoai"));
            tbl.Columns["TenPhanLoai"].Caption = "Tên phân loại";

            DataRow r1 = tbl.NewRow();
            r1["PhanLoai"] = 1;
            r1["TenPhanLoai"] = "GV trong nước";

            DataRow r2 = tbl.NewRow();
            r2["PhanLoai"] = 2;
            r2["TenPhanLoai"] = "GV nước ngoài";

            tbl.Rows.Add(r1);
            tbl.Rows.Add(r2);


            bindingSourcePhanLoaiGiangVien.DataSource = tbl;

            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditPhanLoaiGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditPhanLoaiGiangVien, 300, 400);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditPhanLoaiGiangVien, new string[] { "PhanLoai", "TenPhanLoai" }, new string[] { "Mã phân loại", "Phân loại" }, new int[] { 90, 210 });
            repositoryItemGridLookUpEditPhanLoaiGiangVien.DisplayMember = "TenPhanLoai";
            repositoryItemGridLookUpEditPhanLoaiGiangVien.ValueMember = "PhanLoai";
            repositoryItemGridLookUpEditPhanLoaiGiangVien.NullText = string.Empty;

        }

        void InitData()
        {
            InitPhanLoaiGiangVien();
            bindingSourceNhomMonHoc.DataSource = DataServices.NhomMonHoc.GetAll();
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();
            bindingSourceDonGiaClc.DataSource = DataServices.DonGiaChatLuongCao.GetAll();
        
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGiaClc);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewDonGiaClc.FocusedRowHandle = -1;
            TList<DonGiaChatLuongCao> list = bindingSourceDonGiaClc.DataSource as TList<DonGiaChatLuongCao>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceDonGiaClc.EndEdit();
                            DataServices.DonGiaChatLuongCao.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlDonGiaClc.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void gridViewDonGiaClc_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridViewDonGiaClc_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDonGiaClc, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            DonGiaChatLuongCao obj = target as DonGiaChatLuongCao;
            if (obj != null)
            {
                
                if (_maTruong == "BUH")
                {
                    if (((TList<DonGiaChatLuongCao>)bindingSourceDonGiaClc.DataSource).FindAll(p => p.PhanLoaiGiangVien == obj.PhanLoaiGiangVien & p.NhomMonHoc == obj.NhomMonHoc & p.MaHocVi == obj.MaHocVi).Count > 1)
                    {
                        e.Description = "Đơn giá hiện tại đã có.";
                        return false;
                    }

                   
                }
               
            }
            return true;
        }

        private void gridViewDonGiaClc_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            DonGiaChatLuongCao obj = e.Row as DonGiaChatLuongCao;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "PhanLoaiGiangVien, NhomMonHoc, MaHocVi");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }
    }
}
