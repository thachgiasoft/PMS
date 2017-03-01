using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.Services;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucQuanLyThoiGianLamViecCuaNhanVien : UserControl
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
        VList<ViewGiangVien> _listGiangVien;
        #endregion


        public ucQuanLyThoiGianLamViecCuaNhanVien()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Tên trường").GiaTri;
        }

        private void ucQuanLyThoiGianLamViecCuaNhanVien_Load(object sender, EventArgs e)
        {
            #region Init Gridview 
            AppGridView.InitGridView(gridViewThoiGianLamViecCuaNV, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewThoiGianLamViecCuaNV, new string[] { "MaGiangVien", "HoTen", "NoiDung", "TuNgay", "DenNgay", "NgayCapNhat", "NguoiCapNhat" }
                ,new string[] { "Mã giảng viên", "Họ tên", "Nội dung", "Từ ngày", "Đến ngày", "Ngày cập nhật", "Người cập nhật" }
                ,new int[] {90,150,600,100,100,100,120});
            AppGridView.ShowEditor(gridViewThoiGianLamViecCuaNV, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewThoiGianLamViecCuaNV, new string[] { "MaGiangVien", "HoTen", "NoiDung", "TuNgay", "DenNgay", "NgayCapNhat", "NguoiCapNhat" },DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewThoiGianLamViecCuaNV, "MaGiangVien", repositoryItemGridLookUpEditGiangVien);
            AppGridView.ReadOnlyColumn(gridViewThoiGianLamViecCuaNV, new string[] { "HoTen" });
            AppGridView.HideField(gridViewThoiGianLamViecCuaNV, new string[] {"NgayCapNhat","NguoiCapNhat" });

            #endregion

            #region GiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGiangVien, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGiangVien, 400, 600);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGiangVien,new string[] {"MaQuanLy","HoTen","TenDonVi"},new string[] {"Mã giảng viên","Họ tên","Khoa - đơn vị"},new int[] {100,150,150});
            repositoryItemGridLookUpEditGiangVien.DisplayMember = "MaQuanLy";
            repositoryItemGridLookUpEditGiangVien.ValueMember = "MaGiangVien";
            repositoryItemGridLookUpEditGiangVien.NullText = string.Empty;

            
            #endregion
            InitData();
        }

        void InitData()
        {
                _listGiangVien = DataServices.ViewGiangVien.GetAll();
                bindingSourceGiangVien.DataSource = _listGiangVien;
                bindingSourceThoiGianLamViecCuaNV.DataSource = DataServices.ViewThoiGianLamViecCuaNhanVien.GetAll();
        }

        private void gridViewThoiGianLamViecCuaNV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaGiangVien")
            {

                int pos = e.RowHandle;
                ViewThoiGianLamViecCuaNhanVien r = gridViewThoiGianLamViecCuaNV.GetRow(pos) as ViewThoiGianLamViecCuaNhanVien;
                string _hoten = _listGiangVien.Find(p => p.MaGiangVien == r.MaGiangVien).HoTen;
                gridViewThoiGianLamViecCuaNV.SetRowCellValue(pos, "HoTen", _hoten);


            }
            if (col.FieldName == "MaGiangVien" || col.FieldName == "NoiDung" || col.FieldName == "TuNgay" || col.FieldName == "DenNgay")
            {
                int pos = e.RowHandle;

                gridViewThoiGianLamViecCuaNV.SetRowCellValue(pos, "NgayCapNhat", DateTime.Now.ToString());
                gridViewThoiGianLamViecCuaNV.SetRowCellValue(pos, "NguoiCapNhat", UserInfo.UserName);

            }
           
        }

        private void gridViewThoiGianLamViecCuaNV_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewThoiGianLamViecCuaNV, e);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThoiGianLamViecCuaNV.FocusedRowHandle = -1;
            VList<ViewThoiGianLamViecCuaNhanVien> list = bindingSourceThoiGianLamViecCuaNV.DataSource as VList<ViewThoiGianLamViecCuaNhanVien>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string xmlData = "";
                        int kq = 0;
                        bindingSourceThoiGianLamViecCuaNV.EndEdit();

                        foreach (ViewThoiGianLamViecCuaNhanVien v in list)
                        {
                            if (v.TuNgay == null || v.DenNgay == null)
                            {
                                XtraMessageBox.Show("Bạn chưa nhập từ ngày - đến ngày", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                            }
                            else
                            {
                                if(v.MaGiangVien!=null && v.MaGiangVien!=0)
                                {
                                    xmlData += String.Format("<ThoiGianLamViecCuaNhanVien Id=\"{0}\" MaGiangVien = \"{1}\" NoiDung = \"{2}\" TuNgay = \"{3}\" DenNgay = \"{4}\" NgayCapNhat = \"{5}\" NguoiCapNhat = \"{6}\" />"
                                                  , v.Id, v.MaGiangVien, v.NoiDung, ((DateTime)v.TuNgay).ToShortDateString(), ((DateTime)v.DenNgay).ToShortDateString(), v.NgayCapNhat, v.NguoiCapNhat);
                                }
                                else 
                                {
                                    XtraMessageBox.Show("Bạn chưa nhập mã giảng viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                                }
                            }
                        }
                        xmlData = String.Format("<Root>{0}</Root>", xmlData);
                        DataServices.ThoiGianLamViecCuaNhanVien.Luu(xmlData, ref kq);
                        if (kq == 0)
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
    
            Cursor.Current= Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           Cursor.Current = Cursors.WaitCursor;
           InitData();
           Cursor.Current = Cursors.Default;
         }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewThoiGianLamViecCuaNV);
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                { 
                    if(sf.ShowDialog()==DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlThoiGianLamViecCuaNV.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                }
            
            }
            catch
            { }
        }
    }
}
