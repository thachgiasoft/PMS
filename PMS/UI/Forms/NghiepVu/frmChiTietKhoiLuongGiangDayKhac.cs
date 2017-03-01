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
using PMS.Entities.Validation;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmChiTietKhoiLuongGiangDayKhac : DevExpress.XtraEditors.XtraForm
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

        private KhoiLuongKhac _objKhoiLuong;

        public frmChiTietKhoiLuongGiangDayKhac()
        {
            InitializeComponent();
        }

        public frmChiTietKhoiLuongGiangDayKhac(KhoiLuongKhac objKhoiLuong)
        {
            InitializeComponent();
            _objKhoiLuong = objKhoiLuong;
            txtLop.Text = objKhoiLuong.MaLop;
        }

        public void Init(KhoiLuongKhac objKhoiLuong)
        {
            _objKhoiLuong = objKhoiLuong;
            txtLop.Text = objKhoiLuong.MaLop;
            TList<ChiTietKhoiLuong> listChiTietKhoiLuong = DataServices.ChiTietKhoiLuong.GetByMaKhoiLuong(_objKhoiLuong.MaKhoiLuong);
            VList<ViewSinhVienLop> vListSinhVienLop = bindingSourceChiTietKhoiLuong.DataSource as VList<ViewSinhVienLop>;
            foreach (ViewSinhVienLop v in vListSinhVienLop)
            {
                ChiTietKhoiLuong objChiTiet = listChiTietKhoiLuong.Find(p => p.MaSinhVien == v.MaSinhVien);
                if (objChiTiet != null)
                    v.Chon = true;
                else
                    v.Chon = false;
            }
            gridLookUpEdit1View.RefreshData();
            gridViewChiTietKhoiLuong.Columns["MaLop"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo(string.Format("[MaLop] like '%{0}%'", txtLop.Text));
        }

        private void frmChiTietKhoiLuongGiangDayKhac_Load(object sender, EventArgs e)
        {
            #region Khoi luong giang day khac
            AppGridView.InitGridView(gridViewChiTietKhoiLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewChiTietKhoiLuong, new string[] { "MaLop", "MaSinhVien", "HoTen", "NgaySinh", "Chon" },
                new string[] { "Mã lớp", "Mã SV", "Họ tên", "Ngày sinh", "Chọn" },
                new int[] { 100, 100, 180, 80, 60 });
            AppGridView.UnSortField(gridViewChiTietKhoiLuong, new string[] { "Chon" });
            AppGridView.AlignHeader(gridViewChiTietKhoiLuong, new string[] { "Chon" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.MergeCell(gridViewChiTietKhoiLuong, new string[] { "MaSinhVien", "HoTen", "NgaySinh", "Chon" });
            AppGridView.ReadOnlyColumn(gridViewChiTietKhoiLuong, new string[] { "MaLop", "MaSinhVien", "HoTen", "NgaySinh" });
            AppGridView.SummaryField(gridViewChiTietKhoiLuong, "HoTen", "Tổng = {0}", DevExpress.Data.SummaryItemType.Count);
            #endregion

            #region Khoa
            AppGridLookupEdit.InitGridLookUp(cboKhoa, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.InitPopupFormSize(cboKhoa, 450, 300);
            AppGridLookupEdit.ShowField(cboKhoa, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" }, new int[] { 100, 300 });
            cboKhoa.Properties.DisplayMember = "TenKhoa";
            cboKhoa.Properties.ValueMember = "MaKhoa";
            cboKhoa.Properties.NullText = "[Chọn khoa]";
            #endregion

            #region Init DataSource
            VList<ViewKhoa> vListKhoa = DataServices.ViewKhoa.GetAll();
            vListKhoa.Insert(0, new ViewKhoa() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]" });
            bindingSourceKhoa.DataSource = vListKhoa;
            cboKhoa.DataBindings.Add("EditValue", bindingSourceKhoa, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);

            ViewKhoa objKhoa = bindingSourceKhoa.Current as ViewKhoa;
            if (objKhoa != null)
                bindingSourceChiTietKhoiLuong.DataSource = DataServices.ViewSinhVienLop.GetByMaKhoa(objKhoa.MaKhoa);

            TList<ChiTietKhoiLuong> listChiTietKhoiLuong = DataServices.ChiTietKhoiLuong.GetByMaKhoiLuong(_objKhoiLuong.MaKhoiLuong);
            VList<ViewSinhVienLop> vListSinhVienLop = bindingSourceChiTietKhoiLuong.DataSource as VList<ViewSinhVienLop>;
            foreach (ViewSinhVienLop v in vListSinhVienLop)
            {
                ChiTietKhoiLuong objChiTiet = listChiTietKhoiLuong.Find(p => p.MaSinhVien == v.MaSinhVien);
                if (objChiTiet != null)
                    v.Chon = true;
                else
                    v.Chon = false;
            }
            gridLookUpEdit1View.RefreshData();
            gridViewChiTietKhoiLuong.Columns["MaLop"].FilterInfo = new DevExpress.XtraGrid.Columns.ColumnFilterInfo(string.Format("[MaLop] like '%{0}%'", txtLop.Text));
            #endregion
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewChiTietKhoiLuong.FocusedRowHandle = -1;
            VList<ViewSinhVienLop> vListSinhVienLop = bindingSourceChiTietKhoiLuong.DataSource as VList<ViewSinhVienLop>;
            if (vListSinhVienLop != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        TList<ChiTietKhoiLuong> listChiTietKhoiLuong = DataServices.ChiTietKhoiLuong.GetByMaKhoiLuong(_objKhoiLuong.MaKhoiLuong);
                        foreach (ViewSinhVienLop v in vListSinhVienLop)
                        {
                            ChiTietKhoiLuong objChiTiet = listChiTietKhoiLuong.Find(p => p.MaSinhVien == v.MaSinhVien);
                            if (v.Chon)
                            {
                                if (objChiTiet != null)
                                    objChiTiet.NgayTao = DateTime.Now.Date;
                                else
                                {
                                    objChiTiet = new ChiTietKhoiLuong() { MaKhoiLuong = _objKhoiLuong.MaKhoiLuong, MaSinhVien = v.MaSinhVien, NgayTao = DateTime.Now.Date };
                                    listChiTietKhoiLuong.Add(objChiTiet);
                                }
                            }
                            else
                            {
                                if (objChiTiet != null)
                                    listChiTietKhoiLuong.Remove(objChiTiet);
                            }
                        }
                        //Luu du lieu
                        if (listChiTietKhoiLuong.IsValid)
                        {
                            DataServices.ChiTietKhoiLuong.Save(listChiTietKhoiLuong);
                            _objKhoiLuong.SoLuong = listChiTietKhoiLuong.Count - listChiTietKhoiLuong.DeletedItems.Count;
                            DataServices.KhoiLuongKhac.Update(_objKhoiLuong);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", listChiTietKhoiLuong.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void cboKhoa_CloseUp(object sender, CloseUpEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.Value != null)
            {
                ViewKhoa objKhoa = cboKhoa.Properties.GetRowByKeyValue(e.Value) as ViewKhoa;
                if (objKhoa != null)
                    bindingSourceChiTietKhoiLuong.DataSource = DataServices.ViewSinhVienLop.GetByMaKhoa(objKhoa.MaKhoa);

                TList<ChiTietKhoiLuong> listChiTietKhoiLuong = DataServices.ChiTietKhoiLuong.GetByMaKhoiLuong(_objKhoiLuong.MaKhoiLuong);
                VList<ViewSinhVienLop> vListSinhVienLop = bindingSourceChiTietKhoiLuong.DataSource as VList<ViewSinhVienLop>;
                foreach (ViewSinhVienLop v in vListSinhVienLop)
                {
                    ChiTietKhoiLuong objChiTiet = listChiTietKhoiLuong.Find(p => p.MaSinhVien == v.MaSinhVien);
                    if (objChiTiet != null)
                        v.Chon = true;
                    else
                        v.Chon = false;
                }
                gridLookUpEdit1View.RefreshData();
            }
            Cursor.Current = Cursors.Default;
        }
    }
}