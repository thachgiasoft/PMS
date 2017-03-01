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
    public partial class ucDsThanhToanThuLaoBoSung : DevExpress.XtraEditors.XtraUserControl
    {
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        DateTime _ngayIn;

        public ucDsThanhToanThuLaoBoSung()
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
        private void ucDsThanhToanThuLaoBoSung_Load(object sender, EventArgs e)
        {

            #region Init GridView
            AppGridView.InitGridView(grvThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(grvThongKe, new string[] {"MaQuanLy", "MaGiangVien", "Ho", "Ten", "MaHocHam", "TenHocHam", "MaHocVi", "TenHocVi", "MaBoMon", "TenBoMon", "TietGioiHan", "TietNghiaVu", "TietQuiDoi", "DonGia", "TienDu", "LyDo" }
                    , new string[] { "Mã giảng viên", "Mã giảng viên", "Họ Lót", "Tên", "Mã học hầm", "Tên học hàm", "Mã học vị", "Tên học vị", "Mã khoa", "Tên khoa", "Tiết giới hạn", "Tiết nghĩa vụ", "Tiết qui đổi", "Đơn giá", "Thực lãnh", "Lý do" }
                    , new int[] { 60, 60, 100, 50, 50, 70, 50, 70, 50, 100, 50, 50, 50, 50, 80, 80 });
            AppGridView.AlignHeader(grvThongKe, new string[] { "MaGiangVien", "Ho", "Ten", "MaHocHam", "TenHocHam", "MaHocVi", "TenHocVi", "MaBoMon", "TenBoMon", "TietGioiHan", "TietNghiaVu", "TietQuiDoi", "DonGia", "TienDu", "LyDo" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(grvThongKe, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(grvThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(grvThongKe, "TienDu", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(grvThongKe, new string[] { "MaGiangVien" });
            AppGridView.ReadOnlyColumn(grvThongKe, new string[] {"MaQuanLy", "MaGiangVien", "Ho", "Ten", "MaHocHam", "TenHocHam", "MaHocVi", "TenHocVi", "MaBoMon", "TenBoMon", "TietGioiHan", "TietNghiaVu", "TietQuiDoi", "DonGia", "TienDu" });

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
            #region Init Khoa-DonVi
            cboBoMon.Properties.SelectAllItemCaption = "Tất cả";
            cboBoMon.Properties.TextEditStyle = TextEditStyles.Standard;
            cboBoMon.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _listLoaiKhoaBM = new VList<ViewKhoaBoMon>();
            _listLoaiKhoaBM = DataServices.ViewKhoaBoMon.GetAll();

            List<CheckedListBoxItem> _listKhoaBoMon = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _listLoaiKhoaBM)
            {
                _listKhoaBoMon.Add(new CheckedListBoxItem(v.MaBoMon.ToString(), v.TenBoMon, CheckState.Unchecked, true));
            }
            cboBoMon.Properties.Items.AddRange(_listKhoaBoMon.ToArray());
            cboBoMon.Properties.SeparatorChar = ';';
            cboBoMon.CheckAll();
            #endregion
            #region Init LoaiGiangVien

            AppGridLookupEdit.InitGridLookUp(cboLoaiGiangVien, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiGiangVien, new string[] { "MaLoaiGiangVien", "TenLoaiGiangVien" }, new string[] { "Mã loại giảng viên", "Tên loại giảng viên" });
            cboLoaiGiangVien.Properties.ValueMember = "MaLoaiGiangVien";
            cboLoaiGiangVien.Properties.DisplayMember = "TenLoaiGiangVien";
            cboLoaiGiangVien.Properties.NullText = string.Empty;
            #endregion
            InitData();
        }
        #endregion

        #region InitData()
        void InitData()
        {
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitLanChot();
            if (cboNamHoc.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.DsThanhToanThuLaoBoSung(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboBoMon.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                dt.Load(reader);
                bindingSourceThongKe.DataSource = dt;
            }
            grvThongKe.ExpandAllGroups();
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

        #region "btn_LocDuLieu_Click"
        private void btn_LocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboBoMon.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.DsThanhToanThuLaoBoSung(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboBoMon.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), int.Parse(cboLanChot.EditValue.ToString()));
                dt.Load(reader);
                dt.Columns["LyDo"].ReadOnly = false;
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
            DataTable vListBaoCao = data;
            
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(grvThongKe, bindingSourceThongKe);

            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InDanhSachThanhToanThuLaoBoSung(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(),
                        cboLoaiGiangVien.Text, PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.PhongKeHoachTaiChinh
                        , PMS.Common.Globals._cauhinh.PhongToChucCanBo, PMS.Common.Globals._cauhinh.PhongDaoTao, UserInfo.FullName, vListBaoCao, _ngayIn);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region "Luu"
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            grvThongKe.FocusedRowHandle = -1;
            DataTable dt = bindingSourceThongKe.DataSource as DataTable;
            if (dt != null)
            {
                string xmlData = "";
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr.RowState == DataRowState.Modified)
                    {
                        xmlData += "<Input MaGV=\"" + dr["MaGiangVien"].ToString()
                             + "\" GC=\"" + dr["LyDo"].ToString()
                             + "\" />";
                    }
                }
                xmlData = "<Root>" + xmlData + "</Root>";
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        int kq = 0;
                        bindingSourceThongKe.EndEdit();
                        DataServices.GhiChuThanhToanBoSung.Luu(xmlData, cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), ref kq);
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
            Cursor.Current = Cursors.Default;
        }
        #endregion
    }
}

