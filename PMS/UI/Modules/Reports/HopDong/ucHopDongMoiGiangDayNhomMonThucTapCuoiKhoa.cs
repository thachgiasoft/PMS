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
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Modules.Reports
{
    public partial class ucHopDongMoiGiangDayNhomMonThucTapCuoiKhoa : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
       
    
        
        DateTime _ngayIn;

        string _maTruong;
        private string groupname = UserInfo.GroupName;
        private bool user = false;
        bool flag = false;
        #endregion

        public ucHopDongMoiGiangDayNhomMonThucTapCuoiKhoa()
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

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void ucHopDongMoiGiangDayNhomMonThucTapCuoiKhoa_Load(object sender, EventArgs e)
        {
            #region InitGridview
            AppGridView.InitGridView(gridViewHopDongMoiGiangVien, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewHopDongMoiGiangVien, new string[] { "Chon", "MaGiangVien", "HoTen", "NamHoc", "HocKy", "MaLopHocPhan", "MaMonHoc", "TenMonHoc", "MaLopSinhVien", "MaKhoaHoc", "SiSo", "SoTinChi", "NgayBatDauGiangDay", "NgayKetThucGiangDay", "SoTiet", "MaLoaiHocPhan", "TenLoaiHocPhan", "KhoaDonVi" }
                , new string[] { "Chọn", "Mã giảng viên", "Tên giảng viên", "Năm học", "Học kỳ", "Mã lớp học phần", "Mã môn học", "Tên môn học", "Mã lớp sinh viên", "Mã khóa học", "Sĩ số", "Số tín chỉ", "Ngày bắt đầu giảng dạy", "Ngày kết thúc giảng dạy", "Số tiết", "Mã loại học phần", "Tên loại học phần", "Khoa - Đơn vị" }
                , new int[] { 60, 80, 130, 100, 100, 110, 110, 150, 110, 100, 60, 60, 90, 90, 60, 50, 90, 120 });
            AppGridView.AlignHeader(gridViewHopDongMoiGiangVien, new string[] { "Chon", "MaGiangVien", "HoTen", "NamHoc", "HocKy", "MaLopHocPhan", "MaMonHoc", "TenMonHoc", "MaLopSinhVien", "MaKhoaHoc", "SiSo", "SoTinChi", "NgayBatDauGiangDay", "NgayKetThucGiangDay", "SoTiet", "MaLoaiHocPhan", "TenLoaiHocPhan", "KhoaDonVi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewHopDongMoiGiangVien, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.ReadOnlyColumn(gridViewHopDongMoiGiangVien, new string[] { "MaGiangVien", "HoTen", "NamHoc", "HocKy", "MaLopHocPhan", "MaMonHoc", "TenMonHoc", "MaLopSinhVien", "MaKhoaHoc", "SiSo", "SoTinChi", "NgayBatDauGiangDay", "NgayKetThucGiangDay", "SoTiet", "MaLoaiHocPhan", "TenLoaiHocPhan", "KhoaDonVi" });

            #endregion

            #region Năm học
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Học kỳ
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Khoa - Đơn vị
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã đơn vị", "Tên đơn vị" });
            cboKhoaDonVi.Properties.ValueMember = "MaBoMon";
            cboKhoaDonVi.Properties.DisplayMember = "TenBoMon";
            cboKhoaDonVi.Properties.NullText = string.Empty;
            #endregion

            #region Bac dao tao
            AppGridLookupEdit.InitGridLookUp(cboBacDaoTao, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboBacDaoTao, new string[] { "MaBacDaoTao", "TenBacDaoTao" }, new string[] { "Mã bậc đào tạo", "Tên bậc đào tạo" });
            cboBacDaoTao.Properties.ValueMember = "MaBacDaoTao";
            cboBacDaoTao.Properties.DisplayMember = "TenBacDaoTao";
            cboBacDaoTao.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }

        void InitData()
        {
            Cursor.Current = Cursors.WaitCursor;

            cboBacDaoTao.DataBindings.Clear();
            bindingSourceBacDaoTao.DataSource = DataServices.ViewBacDaoTao.GetAll();
            cboBacDaoTao.DataBindings.Add("EditValue", bindingSourceBacDaoTao, "MaBacDaoTao", true, DataSourceUpdateMode.OnPropertyChanged);

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            VList<ViewKhoaBoMon> vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            if (user == true)
            {
                vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(groupname);

            }
            else
            {
                vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            }

            cboKhoaDonVi.DataBindings.Clear();
            bindingSourceKhoaDonVi.DataSource = vListKhoaBoMon;

            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);

            gridViewHopDongMoiGiangVien.ExpandAllGroups();

            Cursor.Current = Cursors.Default;


        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            cboMaGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboMaGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboMaGiangVien.Properties.Items.Clear();
            if (cboKhoaDonVi.EditValue != null)
            {
                VList<ViewGiangVien> _tLisGiangVien = DataServices.ViewGiangVien.GetByMaDonVi(cboKhoaDonVi.EditValue.ToString());

                List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();

                foreach (ViewGiangVien l in _tLisGiangVien)
                    list.Add(new CheckedListBoxItem(l.MaQuanLy, string.Format("{0} - {1}", l.MaQuanLy, l.HoTen), CheckState.Unchecked, true));
                cboMaGiangVien.Properties.Items.AddRange(list.ToArray());
                cboMaGiangVien.Properties.SeparatorChar = ';';
                cboMaGiangVien.CheckAll();
            }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboKhoaDonVi.EditValue != null && cboMaGiangVien.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.GiangVien.HopDongMoiGiangDayNhomMonThucTapCuoiKhoa(cboBacDaoTao.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), cboMaGiangVien.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                tbl.Load(reader);
                DataColumn chon = new DataColumn("Chon", typeof(Boolean));
                tbl.Columns.Add(chon);
                bindingSourceHopDongGiangDay.DataSource = tbl;
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewHopDongMoiGiangVien.FocusedRowHandle = -1;
            bindingSourceHopDongGiangDay.EndEdit();
            DataTable data = bindingSourceHopDongGiangDay.DataSource as DataTable;

            if (data == null)
                return;
             DataTable vListBaoCao;
            try
            {
                vListBaoCao = data.Select("Chon = 1").CopyToDataTable();
                
                foreach (DataRow r in vListBaoCao.Rows)
                {
                    decimal tongCong = 0;
                    foreach (DataRow v in vListBaoCao.Rows)
                        if (r["MaGiangVien"].ToString() == v["MaGiangVien"].ToString())
                            tongCong += (decimal)v["ThanhTien"];
                    r["ThanhTienTongCong"] = tongCong;
                }
            }
            catch 
            {
                XtraMessageBox.Show("Vui lòng chọn môn muốn in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                _ngayIn = frmChon.NgayIn;
            }

            //if (vListBaoCao == null)
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewHopDongMoiGiangVien, bindingSourceHopDongGiangDay);

            string sort = "";
            if (vListBaoCao != null)
            {
                if (vListBaoCao.Rows.Count != 0)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn c in gridViewHopDongMoiGiangVien.SortedColumns)
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

            //string filter = gridViewHopDongMoiGiangVien.ActiveFilterString;
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
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewHopDongMoiGiangVien, bindingSourceHopDongGiangDay);


            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    for (int i = 0; i < vListBaoCao.Rows.Count; i++)
                    {
                        frm.InHopDongMoiGiangDayNhomMonThucTapCuoiKhoa("", "", "", "", "", "", "", "", "", "", "", "", "", cboMaGiangVien.EditValue.ToString(), "", 0, "", 0
                        , PMS.Common.Globals._cauhinh.TenTruong, "", PMS.Common.Globals._cauhinh.ChucVuDaiDienHopDongThinhGiang, PMS.Common.Globals._cauhinh.ChucVuDaiDienHopDongThinhGiang02
                        , PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.DiaChiDaiDien, PMS.Common.Globals._cauhinh.DienThoaiDaiDien, PMS.Common.Globals._cauhinh.FaxDaiDien, _ngayIn, vListBaoCao);
                    }
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            DataTable tb = bindingSourceHopDongGiangDay.DataSource as DataTable;
            if (checkEditChonTatCa.CheckState == CheckState.Checked)
            {
                foreach (DataRow r in tb.Rows)
                {
                    r["Chon"] = 1;
                }
            }
            else
            {
                foreach (DataRow r in tb.Rows)
                {
                    r["Chon"] = 0;
                }
            }
            bindingSourceHopDongGiangDay.DataSource = tb;
        }

        
    }
}
