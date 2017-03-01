using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using DevExpress.XtraEditors.Controls;
using PMS.Services;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeChiTietGiangDayGiangVienTheoKhoa : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DataTable _data = new DataTable();
        #endregion
        public ucThongKeChiTietGiangDayGiangVienTheoKhoa()
        {
            InitializeComponent();

            TList<CauHinh> listCauHinh = DataServices.CauHinh.GetAll();
            if (listCauHinh != null)
            {
                foreach (CauHinh ch in listCauHinh)
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
            }

        }

        private void ucThongKeChiTietGiangDayGiangVienTheoKhoa_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "TenMonHoc", "MaLop", "HocKy", "SoTinChi", "LoaiHocPhan", "SoTiet", "SoTietThucTeQuyDoi", "HeSoCongViec", "HeSoBacDaoTao", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoLopDong", "HeSoCoSo", "TietQuyDoi" }
                , new string[] { "Mã giảng viên", "Họ", "Tên", "Tên môn học", "Mã lớp", "Học kỳ", "STC", "Loại HP", "STTT", "STTTQD", "Kq", "Kb", "Kn", "Kc", "Kd", "Kv", "Tiết quy đổi" }
                    , new int[] { 80, 110, 60, 150, 90, 50, 80, 80, 70, 70, 60, 60, 60, 60, 60, 60, 100 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "Ho", "Ten", "HocKy", "TenMonHoc", "MaLop", "SoTinChi", "LoaiHocPhan", "SoTiet", "SoTietThucTeQuyDoi", "HeSoCongViec", "HeSoBacDaoTao", "HeSoLopDong", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoCoSo", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewThongKe, new string[] { "HocKy", "SoTinChi", "LoaiHocPhan", "SoTiet", "SoTietThucTeQuyDoi", "HeSoCongViec", "HeSoBacDaoTao", "HeSoLopDong", "HeSoNgonNgu", "HeSoChucDanhChuyenMon", "HeSoCoSo", "TietQuyDoi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.FormatDataField(gridViewThongKe, "SoTinChi", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThongKe, "SoTiet", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThongKe, "SoTietThucTeQuyDoi", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThongKe, "TietQuyDoi", "{0}", DevExpress.Data.SummaryItemType.Sum);
            //gridViewThongKe.Columns["_hocKy"].GroupIndex = 0;
            #endregion

            #region cboNamHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            #endregion

            #region Khoa-DonVi
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaKhoa", "TenKhoa", "MaBoMon", "TenBoMon" }, new string[] { "Mã khoa", "Tên khoa", "Mã bộ môn", "Tên bộ môn" });
            cboKhoaDonVi.Properties.DisplayMember = "TenBoMon";
            cboKhoaDonVi.Properties.ValueMember = "MaBoMon";
            #endregion

            #region Ghi chú
            lblGhiChu.Text = "Ghi chú: ";
            lblGhiChu.Text += "\n\t- STTT: số tiết dạy thực tế.\t\t\t    - STTTQD: số tiết thực tế quy đổi (nhân hệ số 1.11)";
            lblGhiChu.Text += "\n\t- Kq: hệ số công việc.\t\t\t\t\t     - Kb: hệ số bậc đào tạo.";
            lblGhiChu.Text += "\n\t- Kn: hệ số ngôn ngữ giảng dạy.\t\t- Kc: hệ số chức danh chuyên môn.";
            lblGhiChu.Text += "\n\t- Kd: hệ số lớp đông.\t\t\t\t\t      - Kv: hệ số cơ sở (Khu vực).";
            #endregion
            InitData();
        }

        #region InitData
        void InitHocKy()
        {
            #region cboHocKy
            try
            {
                VList<ViewHocKy> _listHocKy = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                cboHocKy.Properties.SelectAllItemCaption = "Tất cả";
                cboHocKy.Properties.SeparatorChar = ';';
                cboHocKy.Properties.TextEditStyle = TextEditStyles.Standard;
                cboHocKy.Properties.Items.Clear();

                List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
                for (int i = 0; i < _listHocKy.Count; i++)
                {
                    list.Add(new CheckedListBoxItem(_listHocKy[i].MaHocKy
                        , String.Format("{0} - {1}", _listHocKy[i].MaHocKy, _listHocKy[i].TenHocKy)
                        , CheckState.Unchecked, true));
                }
                cboHocKy.Properties.Items.AddRange(list.ToArray());
                cboHocKy.CheckAll();
            }
            catch { }
            #endregion
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            bindingSourceKhoaDonVi.DataSource = DataServices.ViewKhoaBoMon.GetAll();
            cboKhoaDonVi.DataBindings.Clear();
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);
            if (cboNamHoc.EditValue != null)
            {
                InitHocKy();
                try
                {
                    IDataReader reader = DataServices.KhoiLuongQuyDoi.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                    _data.Load(reader);
                    bindingSourceThongKe.DataSource = _data;
                    gridViewThongKe.ExpandAllGroups();
                }
                catch  { }
            }
        }
        #endregion

        #region Event Button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void cboLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue == null || cboHocKy.EditValue.ToString() == "" || cboKhoaDonVi.EditValue == null)
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin: năm học, học kỳ, khoa - đơn vị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                IDataReader reader = DataServices.KhoiLuongQuyDoi.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                DataTable data = new DataTable();
                data.Load(reader);
                bindingSourceThongKe.DataSource = data;
                gridViewThongKe.ExpandAllGroups();
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataTable data = bindingSourceThongKe.DataSource as DataTable;
            string _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            using (PMS.UI.Forms.BaoCao.frmBaoCao frm = new Forms.BaoCao.frmBaoCao())
            {
                if (PMS.Common.Globals._cauhinh != null)
                {
                    frm.InThongKeChiTietGiangDayGiangVienTheoKhoa(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.Text, PMS.Common.Globals._cauhinh.TenTruong, _maTruong, data);
                    frm.ShowDialog();
                }
                else
                {
                    XtraMessageBox.Show("Chưa cấu hình tên trường và các thông tin phòng ban liên quan", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
            }

            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                InitHocKy();
        }
    }
}
