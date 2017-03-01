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
using PMS.Entities;
using PMS.Services;
using PMS.UI.Forms.BaoCao;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Modules.Reports
{
    public partial class ucDsThanhToanQuaNganHang_CTIM : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        DateTime _ngayIn;
        VList<ViewKhoa> _vListKhoaBoMon;
        string groupname = UserInfo.GroupName;
        string _maTruong;
        #endregion

        public ucDsThanhToanQuaNganHang_CTIM()
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
        }

        #region "Load"
        private void ucDsThanhToanQuaNganHang_CTIM_Load(object sender, EventArgs e)
        {

            #region Init GridView
            AppGridView.InitGridView(grvThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(grvThongKe, new string[] { "ChonIn", "Id", "MaQuanLy", "HoTen", "SoTaiKhoan", "TenNganHang", "ChiNhanh", "MalopHocPhan", "TenMonHoc", "TienTheoBangKe", "TienNguoiNhanChiu", "TienThucNhan", "ChiuTienChuyenKhoan", "GhiChu" }
                    , new string[] { "Chọn in", "Id", "Mã giảng viên", "Họ và tên", "Tài khoản", "Ngân hàng", "Chi nhánh", "Mã lớp học phần", "Tên môn học", "Tiền theo bảng kê", "Tiền người nhận chịu", "Tiền thực nhận", "Chịu tiền chuyển khoản", "Ghi chú" }
                    , new int[] { 50, 30, 60, 150, 100, 150, 150, 100, 120, 120, 120, 120, 100, 120 });
            AppGridView.AlignHeader(grvThongKe, new string[] { "ChonIn", "Id", "MaQuanLy", "HoTen", "SoTaiKhoan", "TenNganHang", "ChiNhanh", "MalopHocPhan", "TenMonHoc", "TienTheoBangKe", "TienNguoiNhanChiu", "TienThucNhan", "ChiuTienChuyenKhoan", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(grvThongKe, "SoTaiKhoan", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(grvThongKe, "TienTheoBangKe", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(grvThongKe, "TienNguoiNhanChiu", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(grvThongKe, "TienThucNhan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(grvThongKe, new string[] { "Id" });
            AppGridView.ReadOnlyColumn(grvThongKe, new string[] { "MaQuanLy", "HoTen", "SoTaiKhoan", "TenNganHang", "ChiNhanh", "MalopHocPhan", "TenMonHoc", "TienTheoBangKe", "TienNguoiNhanChiu", "TienThucNhan" });
            PMS.Common.Globals.WordWrapHeader(grvThongKe, 45);
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

            #region Bac dao tao
            AppGridLookupEdit.InitGridLookUp(cboBacDaoTao, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboBacDaoTao, new string[] { "MaBacDaoTao", "TenBacDaoTao" }, new string[] { "Mã bậc đào tạo", "Tên bậc đào tạo" });
            cboBacDaoTao.Properties.ValueMember = "MaBacDaoTao";
            cboBacDaoTao.Properties.DisplayMember = "TenBacDaoTao";
            cboBacDaoTao.Properties.NullText = string.Empty;
            #endregion

            #region Init Khoa-DonVi
            cboKhoaBoMon.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoaBoMon.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoaBoMon.Properties.Items.Clear();

            _vListKhoaBoMon = DataServices.ViewKhoa.GetAll();

            if (_maTruong == "CTIM")
            {
                VList<ViewKhoa> v = _vListKhoaBoMon.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoa>;
                if (v.Count > 0)
                {
                    _vListKhoaBoMon = _vListKhoaBoMon.FindAll(p => p.MaKhoa == groupname) as VList<ViewKhoa>;
                }
                else
                    _vListKhoaBoMon = DataServices.ViewKhoa.GetAll();
            }

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoa v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaKhoa, v.TenKhoa, CheckState.Unchecked, true));
            }
            cboKhoaBoMon.Properties.Items.AddRange(_list.ToArray());
            cboKhoaBoMon.Properties.SeparatorChar = ';';
            cboKhoaBoMon.CheckAll();
            #endregion

            InitData();
        }
        #endregion

        #region InitData()
        void InitData()
        {
            cboBacDaoTao.DataBindings.Clear();
            bindingSourceBacDaoTao.DataSource = DataServices.ViewBacDaoTao.GetAll();
            cboBacDaoTao.DataBindings.Add("EditValue", bindingSourceBacDaoTao, "MaBacDaoTao", true, DataSourceUpdateMode.OnPropertyChanged);

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            
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

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVienThanhToanQuaNganHang.GetByNamHocHocKyDonViBacDaoTaoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(),cboKhoaBoMon.EditValue.ToString(),cboBacDaoTao.EditValue.ToString(),int.Parse(cboLanChot.EditValue.ToString()));
                dt.Load(reader);
                foreach (DataColumn dc in dt.Columns)
                    dc.ReadOnly = false;
                bindingSourceThongKe.DataSource = dt;
            }
            grvThongKe.ExpandAllGroups();
        }
        #endregion

        #region "btn_LocDuLieu_Click"
        private void btn_LocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.GiangVienThanhToanQuaNganHang.GetByNamHocHocKyDonViBacDaoTaoLanChot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaBoMon.EditValue.ToString(), cboBacDaoTao.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                dt.Load(reader);
                foreach (DataColumn dc in dt.Columns)
                    dc.ReadOnly = false;
                bindingSourceThongKe.DataSource = dt;
            }
            grvThongKe.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region "btnIn_ItemClick"
        private void btnInTheoBoMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();

                if (frmChon.NgayIn.ToString("dd/MM/yyyy") == "01/01/0001")
                    return;
                _ngayIn = frmChon.NgayIn;
            }
            Cursor.Current = Cursors.WaitCursor;
            grvThongKe.FocusedRowHandle = -1;
            bindingSourceThongKe.EndEdit();
            DataTable data = bindingSourceThongKe.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data.Select("ChonIn = 1").CopyToDataTable();
            
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(grvThongKe, bindingSourceThongKe);

            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InDanhSachThanhToanQuaNganHang(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString()
                        , PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.ChucVuBanGiamHieu, PMS.Common.Globals._cauhinh.PhongKeHoachTaiChinh
                        , PMS.Common.Globals._cauhinh.ChucVuKeHoachTaiChinh, PMS.Common.Globals._cauhinh.ChucVuKeToan, UserInfo.FullName, vListBaoCao, _ngayIn);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region "Luu"
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (XtraMessageBox.Show("Bạn muốn lưu xác nhận thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //try
                //{
                grvThongKe.FocusedRowHandle = -1;
                DataTable tb = bindingSourceThongKe.DataSource as DataTable;
                if (tb != null || tb.Rows.Count > 0)
                {
                    string xmlData = "";
                    foreach (DataRow r in tb.Rows)
                    {
                        if (r.RowState == DataRowState.Modified)
                        {
                            xmlData += String.Format("<Input Id=\"{0}\" CTCK=\"{1}\" GC=\"{2}\" />", r["Id"], r["ChiuTienChuyenKhoan"], r["GhiChu"]);
                        }
                    }
                    xmlData = "<Root>" + xmlData + "</Root>";

                    int result = -1;

                    Cursor.Current = Cursors.WaitCursor;
                    DataServices.GiangVienThanhToanQuaNganHang.LuuThayDoi(xmlData, ref result);
                    Cursor.Current = Cursors.Default;

                    if (result == 0)
                    {
                        XtraMessageBox.Show("Lưu thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    btn_LocDuLieu.PerformClick();
                }
                //}
                //catch
                //{ }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitData();
        }
    }
}

