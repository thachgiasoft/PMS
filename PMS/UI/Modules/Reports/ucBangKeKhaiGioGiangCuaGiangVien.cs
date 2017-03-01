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
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.BaoCao;
using PMS.Services;

namespace PMS.UI.Modules.Reports
{
    public partial class ucBangKeKhaiGioGiangCuaGiangVien : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        string _hoTen = "", _tenDonVi = "", _tenHocHam = "", _tenHocVi = "", _maSoThue = "", _soTaiKhoan = "", _chiNhanhNganHang = "", _chucVu = "";
        bool _giangVienTrongTruong = false;
        #endregion
        public ucBangKeKhaiGioGiangCuaGiangVien()
        {
            InitializeComponent();
            TList<CauHinh> cauHinh = DataServices.CauHinh.GetAll();
            if (cauHinh != null)
            {
                foreach (CauHinh ch in cauHinh)
                {
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
                }
            }
            layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void ucBangKeKhaiGioGiangCuaGiangVien_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "MaMonHoc", "TenMonHoc", "MaLop", "NamThu", "SiSo", "TietThucDay", "TenCoSo" }
                                                       , new string[] { "STT", "Mã môn học", "Tên môn học", "Lớp", "Năm thứ", "Số sinh viên", "Tiết thực dạy", "Cơ sở" }
                                                       , new int[] { 60, 90, 150, 90, 80, 80, 80, 100 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "MaMonHoc", "TenMonHoc", "MaLop", "NamThu", "SiSo", "TietThucDay", "TenCoSo" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion
            #region _lanChot
            AppGridLookupEdit.InitGridLookUp(cboLanChot, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLanChot, new string[] { "LanChot" }, new string[] { "Lần chốt" });
            cboLanChot.Properties.ValueMember = "LanChot";
            cboLanChot.Properties.DisplayMember = "LanChot";
            cboLanChot.Properties.NullText = string.Empty;
            #endregion
            #region Khoa-DonVi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaKhoa", "TenKhoa" }, new string[] { "Mã khoa", "Tên khoa" });
            cboKhoaDonVi.Properties.ValueMember = "MaKhoa";
            cboKhoaDonVi.Properties.DisplayMember = "TenKhoa";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion
            #region GiangVien
            AppGridLookupEdit.InitGridLookUp(cboGiangVien, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboGiangVien, new string[] { "MaQuanLy", "HoTen", "TenLoaiGiangVien" }, new string[] { "Mã giảng viên", "Họ tên", "Loại giảng viên" });
            cboGiangVien.Properties.ValueMember = "MaGiangVien";
            cboGiangVien.Properties.DisplayMember = "HoTen";
            cboGiangVien.Properties.NullText = string.Empty;
            #endregion
            InitData();
                
        }
        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            cboKhoaDonVi.DataBindings.Clear();
            bindingSourceKhoaDonVi.DataSource = DataServices.ViewKhoa.GetAll();
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaKhoa", true, DataSourceUpdateMode.OnPropertyChanged);
            cboGiangVien.DataBindings.Clear();
            if (cboKhoaDonVi.EditValue != null)
                bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
            cboGiangVien.DataBindings.Add("EditValue", bindingSourceGiangVien, "MaGiangVien", true, DataSourceUpdateMode.OnPropertyChanged);
            if (cboNamHoc.EditValue != null && cboGiangVien.EditValue != null && cboHocKy.EditValue != null && cboLanChot.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.GetByMaGiangVienNamHocHocKyLanChot((int)cboGiangVien.EditValue, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                dt.Load(reader);
                bindingSourceThongKe.DataSource = dt;
                DataServices.GiangVien.GetThongTinByNamHocHocKy((int)cboGiangVien.EditValue, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref _hoTen, ref _tenDonVi,ref _tenHocVi, ref _tenHocHam, ref _maSoThue, ref _soTaiKhoan, ref _chiNhanhNganHang, ref _chucVu, ref _giangVienTrongTruong);
            }
        }

        void InitLanChot()
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                cboLanChot.DataBindings.Clear();
                DataServices.KetQuaThanhToanThuLao.GetSoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref lanchot);
                DataTable tblLanChot = new DataTable();
                tblLanChot.Columns.Add("LanChot");
                if (lanchot > 0)
                {
                    for (int i = lanchot; i >= 1; i--)
                    {
                        tblLanChot.Rows.Add(new string[] { i.ToString() });
                    }
                }
                bindingSourceLanChot.DataSource = tblLanChot;
                cboLanChot.DataBindings.Add("EditValue", bindingSourceLanChot, "LanChot", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }
        #endregion

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            cboGiangVien.DataBindings.Clear();
            if (cboKhoaDonVi.EditValue != null)
                bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());
            cboGiangVien.DataBindings.Add("EditValue", bindingSourceGiangVien, "MaGiangVien", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            InitLanChot();
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboGiangVien.EditValue != null && cboHocKy.EditValue != null && cboLanChot.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.GetByMaGiangVienNamHocHocKyLanChot((int)cboGiangVien.EditValue, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                dt.Load(reader);
                bindingSourceThongKe.DataSource = dt;
                DataServices.GiangVien.GetThongTinByNamHocHocKy((int)cboGiangVien.EditValue, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref _hoTen, ref _tenDonVi, ref _tenHocVi, ref _tenHocHam, ref _maSoThue, ref _soTaiKhoan, ref _chiNhanhNganHang, ref _chucVu, ref _giangVienTrongTruong);
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongKe);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewThongKe.SortedColumns)
                    {
                        switch (c.SortOrder)
                        {
                            case DevExpress.Data.ColumnSortOrder.Ascending:
                                sort += string.Format("{0} ASC, ", c.FieldName);
                                break;
                            case DevExpress.Data.ColumnSortOrder.Descending:
                                sort += string.Format("{0} DESC, ", c.FieldName);
                                break;
                        }
                    }
                }
                if (sort != "")
                    sort = sort.Substring(0, sort.Length - 2);
            }

            //string filter = gridViewThongKe.ActiveFilterString;
            //if (filter.Contains(".0000m"))
            //    filter = filter.Replace(".0000m", "");
            //if (filter.Contains(".000m"))
            //    filter = filter.Replace(".000m", "");
            //if (filter.Contains(".00m"))
            //    filter = filter.Replace(".00m", "");
            //if (filter.Contains(".0m"))
            //    filter = filter.Replace(".0m", "");
            //if (filter.Contains(".m"))
            //    filter = filter.Replace(".m", "");

            //string filter = gridViewHopDongMoiGiangVien.ActiveFilterString;
            //vListBaoCao = dv.ToTable();
            //if (vListBaoCao == null)
            //    return;
//            int dem = vListBaoCao.Rows.Count;


            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InBangKeKhaiGioGiangCuaGiangVien(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                        , _tenDonVi, _hoTen, _tenDonVi, _tenHocHam, _tenHocVi, _maSoThue, _soTaiKhoan, _chiNhanhNganHang, _chucVu, _giangVienTrongTruong, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
