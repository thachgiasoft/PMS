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
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.UI.Forms.BaoCao;
using PMS.BLL;


namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeTongHopGioGiangTheoKhoa_CDGTVT : UserControl
    {
        #region Variable 
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayin;
        string _maTruong;
        private string groupname = UserInfo.GroupName;
        private bool user = false;
        bool flag = false;
        #endregion
        public ucThongKeTongHopGioGiangTheoKhoa_CDGTVT()
        {
            InitializeComponent();
        }

        private void ucThongKeTongHopGioGiangTheoKhoa_CDGTVT_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewThongKe, new string[] {"Stt", "TenBoMon", "SoLuongGiangvien","TongGioDay1", "GioKhac1", "SoGioGiamKhac1"
                    , "DinhMucGioChuan1", "GioVuot1", "TongGioDay2", "GioKhac2", "SoGioGiamKhac2", "DinhMucGioChuan2", "GioVuot2", "TongGioDay"
                    , "GioKhac", "SoGioGiamKhac", "DinhMucGioChuan", "GioVuot"}
                , new string[] {"STT","Tên bộ môn","Số lượng giảng viên","Tổng số giờ dạy HK01","Giờ thực hiện các nhiệm vụ khác HK01"
                    ,"Giảm trừ giờ chuẩn các HĐ khác HK01","Định mức giờ tiêu chuẩn HK01","Giờ vượt HK01","Tổng số giờ dạy HK02"
                    ,"Giờ thực hiện các nhiệm vụ khác HK02","Giảm trừ giờ chuẩn các HĐ khác HK02","Định mức giờ tiêu chuẩn HK02","Giờ vượt HK02"
                    ,"Tổng số giờ dạy cả năm","Giờ thực hiện các nhiệm vụ khác cả năm","Giảm trừ giờ chuẩn các HĐ khác cả năm","Định mức giờ tiêu chuẩn cả năm","Giờ vượt cả năm"}
                , new int[] { 60, 200, 60, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80 });
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.AlignHeader(gridViewThongKe, new string[] {"Stt", "TenBoMon", "SoLuongGiangvien","TongGioDay1", "GioKhac1", "SoGioGiamKhac1"
                    , "DinhMucGioChuan1", "GioVuot1", "TongGioDay2", "GioKhac2", "SoGioGiamKhac2", "DinhMucGioChuan2", "GioVuot2", "TongGioDay"
                    , "GioKhac", "SoGioGiamKhac", "DinhMucGioChuan", "GioVuot"}, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewThongKe, new string[] {"Stt", "SoLuongGiangvien","TongGioDay1", "GioKhac1", "SoGioGiamKhac1"
                    , "DinhMucGioChuan1", "GioVuot1", "TongGioDay2", "GioKhac2", "SoGioGiamKhac2", "DinhMucGioChuan2", "GioVuot2", "TongGioDay"
                    , "GioKhac", "SoGioGiamKhac", "DinhMucGioChuan", "GioVuot"}, DevExpress.Utils.HorzAlignment.Center);
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 50);
            AppGridView.SummaryField(gridViewThongKe, "TenBoMon", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThongKe, "GioVuot1", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThongKe, "GioVuot2", "{0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewThongKe, "GioVuot", "{0}", DevExpress.Data.SummaryItemType.Sum);

            gridViewThongKe.Columns["GioVuot1"].AppearanceCell.Font = new Font(gridViewThongKe.Columns[4].AppearanceCell.Font.FontFamily, gridViewThongKe.Columns[4].AppearanceCell.Font.Size, FontStyle.Bold);
            gridViewThongKe.Columns["GioVuot2"].AppearanceCell.Font = new Font(gridViewThongKe.Columns[4].AppearanceCell.Font.FontFamily, gridViewThongKe.Columns[4].AppearanceCell.Font.Size, FontStyle.Bold);
            gridViewThongKe.Columns["GioVuot"].AppearanceCell.Font = new Font(gridViewThongKe.Columns[4].AppearanceCell.Font.FontFamily, gridViewThongKe.Columns[4].AppearanceCell.Font.Size, FontStyle.Bold);

            #region Năm học
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            
            #endregion
            #region Khoa - Đơn vị
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã đơn vị", "Tên đơn vị" });
            cboKhoaDonVi.Properties.ValueMember = "MaBoMon";
            cboKhoaDonVi.Properties.DisplayMember = "TenBoMon";
            cboKhoaDonVi.Properties.NullText = string.Empty;

            #endregion
            #region Loại giảng viên
            AppGridLookupEdit.InitGridLookUp(cboLoaiGiangVien, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiGiangVien, new string[] { "MaQuanLy", "TenLoaiGiangVien" }, new string[] { "Mã loại giảng viên", "Tên loại giảng viên" });
            cboLoaiGiangVien.Properties.ValueMember = "MaLoaiGiangVien";
            cboLoaiGiangVien.Properties.DisplayMember = "TenLoaiGiangVien";
            cboLoaiGiangVien.Properties.NullText = string.Empty;

            #endregion

            InitData();

        }

        void InitData()
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            VList<ViewKhoaBoMon> vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            if (user == true)
            {
                vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(groupname);
            }
            else
            {
                vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
                vListKhoaBoMon.Insert(0, new ViewKhoaBoMon() { ThuTu = -1, MaKhoa = "-1", TenKhoa = "[Tất cả]", MaBoMon = "-1", TenBoMon = "[Tất cả]" });
            }
            bindingSourceCloneKhoaDonVi.DataSource = vListKhoaBoMon.Copy();
            bindingSourceKhoaDonVi.DataSource = vListKhoaBoMon;           
            cboKhoaDonVi.DataBindings.Clear();
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);

            cboLoaiGiangVien.DataBindings.Clear();
            TList<LoaiGiangVien> _listLGV = DataServices.LoaiGiangVien.GetAll();
            _listLGV.Insert(0, new LoaiGiangVien() { ThuTu = -1, MaLoaiGiangVien = -1, MaQuanLy = "-1", TenLoaiGiangVien = "[Tất cả]" });
            bindingSourceLoaiGiangVien.DataSource = _listLGV;
            cboLoaiGiangVien.DataBindings.Add("EditValue", bindingSourceLoaiGiangVien, "MaLoaiGiangVien", true, DataSourceUpdateMode.OnPropertyChanged);

            gridViewThongKe.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ViewKhoaBoMon objDonVi = bindingSourceKhoaDonVi.Current as ViewKhoaBoMon;

            if (cboNamHoc.EditValue != null && objDonVi != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeTongHopTheoKhoa_Cdgtvt(cboNamHoc.EditValue.ToString(), objDonVi.MaBoMon.ToString(), int.Parse(cboLoaiGiangVien.EditValue.ToString()));
                tbl.Load(reader);
                bindingSourceThongKe.DataSource = tbl;
            }
            gridViewThongKe.ExpandAllGroups();

            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControl1.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    
                }
            }
            catch
            { }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                _ngayin = frmChon.NgayIn;
            }
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
//                return;

vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongKe);


            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeTongHopGioGiangTheoKhoa_CDGTVT(PMS.Common.Globals._cauhinh.TenTruong,  cboNamHoc.EditValue.ToString()
                        , PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.PhongDaoTao, cboLoaiGiangVien.Text, _ngayin, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
