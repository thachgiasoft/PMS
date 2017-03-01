using System;
using PMS.Entities;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using PMS.Services;
using PMS.Core;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucKhongTinhKhoiLuong : XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        public ucKhongTinhKhoiLuong()
        {
            InitializeComponent();
        }

        private void ucKhongTinhKhoiLuong_Load(object sender, EventArgs e)
        {
            #region Init GridView ChucVu
            AppGridView.InitGridView(gridViewMonHoc, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewMonHoc, new string[] { "MaKhoa", "TenKhoa", "MaMonHoc", "TenMonHoc", "SoTinChi", "Chon" },
                new string[] { "Mã khoa", "Tên khoa", "Mã môn học", "Tên môn học", "Tín chỉ", "Chọn" },
                new int[] { 100, 230, 100, 250, 60, 60 });
            AppGridView.ReadOnlyColumn(gridViewMonHoc, new string[] { "MaKhoa", "TenKhoa", "MaMonHoc", "TenMonHoc", "SoTinChi" });
            AppGridView.AlignHeader(gridViewMonHoc, new string[] { "Chon" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewMonHoc, new string[] { "Chon" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewMonHoc, "MaKhoa", "Tổng = {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.MergeCell(gridViewMonHoc, new string[] { "MaMonHoc", "SoTinChi", "Chon" });

            #endregion

            #region Init Datasource
            bindingSourceKhongTinhKhoiLuong.DataSource = DataServices.ViewMonHocKhoa.GetAll();
            //Cap nhat trang thai cac mon hoc khong tinh khoi luong
            TList<MonKhongTinh> listMonKhongTinhKhoiLuong = DataServices.MonKhongTinh.GetAll();
            VList<ViewMonHocKhoa> vListMonHocKhoa = bindingSourceKhongTinhKhoiLuong.DataSource as VList<ViewMonHocKhoa>;
            if (vListMonHocKhoa != null)
            {
                foreach (ViewMonHocKhoa v in vListMonHocKhoa)
                {
                    MonKhongTinh obj = listMonKhongTinhKhoiLuong.Find(p => p.MaMonHoc == v.MaMonHoc);
                    if (obj != null)
                        v.Chon = true;
                    else
                        v.Chon = false;
                }
                gridViewMonHoc.RefreshData();
            }
            PMS.Common.Globals.LoadLayout(Tag as AppModule, new object[] { gridViewMonHoc, barManager1, layoutControl1 });
            #endregion
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewMonHoc.FocusedRowHandle = -1;
            VList<ViewMonHocKhoa> vListMonHocKhoa = bindingSourceKhongTinhKhoiLuong.DataSource as VList<ViewMonHocKhoa>;
            if (vListMonHocKhoa != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        TList<MonKhongTinh> listMonKhongTinh = DataServices.MonKhongTinh.GetAll();
                        foreach (ViewMonHocKhoa v in vListMonHocKhoa)
                        {
                            MonKhongTinh obj = listMonKhongTinh.Find(p => p.MaMonHoc == v.MaMonHoc);
                            if (v.Chon)
                            {
                                if (obj != null)
                                    obj.NgayTao = DateTime.Now.Date;
                                else
                                {
                                    obj = new MonKhongTinh() { MaMonHoc = v.MaMonHoc, NgayTao = DateTime.Now.Date };
                                    listMonKhongTinh.Add(obj);
                                }
                            }
                            else
                            {
                                if (obj != null)
                                    obj.MarkToDelete();
                            }
                        }
                        //Luu du lieu
                        if (listMonKhongTinh.IsValid)
                        {
                            DataServices.MonKhongTinh.Save(listMonKhongTinh);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewMonHoc, barManager1, layoutControl1 });
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", listMonKhongTinh.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            //Cap nhat trang thai cac mon hoc khong tinh khoi luong
            TList<MonKhongTinh> listMonKhongTinhKhoiLuong = DataServices.MonKhongTinh.GetAll();
            VList<ViewMonHocKhoa> vListMonHocKhoa = bindingSourceKhongTinhKhoiLuong.DataSource as VList<ViewMonHocKhoa>;
            if (vListMonHocKhoa != null)
            {
                foreach (ViewMonHocKhoa v in vListMonHocKhoa)
                {
                    MonKhongTinh obj = listMonKhongTinhKhoiLuong.Find(p => p.MaMonHoc == v.MaMonHoc);
                    if (obj != null)
                        v.Chon = true;
                    else
                        v.Chon = false;
                }
                gridViewMonHoc.RefreshData();
            }
            Cursor.Current = Cursors.Default;
        }
    }
}