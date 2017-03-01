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
    public partial class ucThongkeTongHop_CDGTVT : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;

        string _maTruong;
        private string groupname = UserInfo.GroupName;
        private bool user = false;
        bool flag = false;
        #endregion

        public ucThongkeTongHop_CDGTVT()
        {
            InitializeComponent();
        }

        private void ucThongkeTongHop_CDGTVT_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTen", "TenBoMon", "TongGioDay1", "GioKhac1", "SoGioGiamKhac1", "DinhMucGioChuan1", "GioVuot1", "TongGioDay2", "GioKhac2", "SoGioGiamKhac2", "DinhMucGioChuan2", "GioVuot2", "TongGioDay", "GioKhac", "SoGioGiamKhac", "DinhMucGioChuan", "GioVuot", "GhiChu" }
                    , new string[] { "STT", "Mã giảng viên", "Họ tên", "Tên Bộ Môn", "Tổng giờ dạy HK01", "Giờ thực hiện các nhiệm vụ khác HK01", "Giảm trừ giờ chuẩn các HĐ khác HK01", "Định mức giờ tiêu chuẩn HK01", "Giờ vượt HK01", "Tổng giờ dạy HK02", "Giờ thực hiện các nhiệm vụ khác HK02", "Giảm trừ giờ chuẩn các HĐ khác HK02", "Định mức giờ tiêu chuẩn HK02", "Giờ vượt HK02", "Tổng giờ dạy cả năm", "Giờ thực hiện các nhiệm vụ khác cả năm", "Giảm trừ giờ chuẩn các HĐ khác cả năm", "Định mức giờ tiêu chuẩn cả năm", "Giờ vượt cả năm", "Ghi chú" }
                    , new int[] { 60, 90, 170, 150, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 150 });
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTen", "TenBoMon", "TongGioDay1", "GioKhac1", "SoGioGiamKhac1", "DinhMucGioChuan1", "GioVuot1", "TongGioDay2", "GioKhac2", "SoGioGiamKhac2", "DinhMucGioChuan2", "GioVuot2", "TongGioDay", "GioKhac", "SoGioGiamKhac", "DinhMucGioChuan", "GioVuot", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.AlignField(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTen", "TenBoMon", "TongGioDay1", "GioKhac1", "SoGioGiamKhac1", "DinhMucGioChuan1", "GioVuot1", "TongGioDay2", "GioKhac2", "SoGioGiamKhac2", "DinhMucGioChuan2", "GioVuot2", "TongGioDay", "GioKhac", "SoGioGiamKhac", "DinhMucGioChuan", "GioVuot", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            gridViewThongKe.Columns["TenBoMon"].GroupIndex = 0;
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 50);

            gridViewThongKe.Columns["GioVuot1"].AppearanceCell.Font = new Font(gridViewThongKe.Columns[4].AppearanceCell.Font.FontFamily, gridViewThongKe.Columns[4].AppearanceCell.Font.Size, FontStyle.Bold);
            gridViewThongKe.Columns["GioVuot2"].AppearanceCell.Font = new Font(gridViewThongKe.Columns[4].AppearanceCell.Font.FontFamily, gridViewThongKe.Columns[4].AppearanceCell.Font.Size, FontStyle.Bold);
            gridViewThongKe.Columns["GioVuot"].AppearanceCell.Font = new Font(gridViewThongKe.Columns[4].AppearanceCell.Font.FontFamily, gridViewThongKe.Columns[4].AppearanceCell.Font.Size, FontStyle.Bold);

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Khoa-DonVi
            AppGridLookupEdit.InitGridLookUp(cboDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDonVi, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã đơn vị", "Tên đơn vị" });
            cboDonVi.Properties.ValueMember = "MaBoMon";
            cboDonVi.Properties.DisplayMember = "TenBoMon";
            cboDonVi.Properties.NullText = string.Empty;

            //VList<ViewKhoaBoMon> vKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            //foreach (ViewKhoaBoMon v in vKhoaBoMon)
            //{
            //    if (groupname == v.MaBoMon)
            //    { 
            //        user = true; break; 
            //    }
            //}
            #endregion

            #region LoaiGiangVien
            cboLoaiGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiGiangVien.Properties.Items.Clear();

            TList<LoaiGiangVien> _tListLoaiGiangVien = DataServices.LoaiGiangVien.GetAll();

            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();

            foreach (LoaiGiangVien l in _tListLoaiGiangVien)
                list.Add(new CheckedListBoxItem(l.MaLoaiGiangVien, string.Format("{0} - {1}", l.MaQuanLy, l.TenLoaiGiangVien), CheckState.Unchecked, true));
            cboLoaiGiangVien.Properties.Items.AddRange(list.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
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
            bindingSourceCloneDonVi.DataSource = vListKhoaBoMon.Copy();

            bindingSourceDonVi.DataSource = vListKhoaBoMon;
            cboDonVi.DataBindings.Clear();
            //bindingSourceDonVi.DataSource = DataServices.ViewKhoaBoMon.GetAll();
            cboDonVi.DataBindings.Add("EditValue", bindingSourceDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);
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
            ViewKhoaBoMon objDonVi = bindingSourceDonVi.Current as ViewKhoaBoMon;

            if (cboNamHoc.EditValue != null && objDonVi != null && cboLoaiGiangVien.EditValue != null)
            {
                DataTable tbl = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeTongHop_Cdgtvt(cboNamHoc.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), objDonVi.MaBoMon.ToString());
                tbl.Load(reader);
                bindingSourceThongKe.DataSource = tbl;
            }
            gridViewThongKe.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                _ngayIn = frmChon.NgayIn;
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
                    if (cboDonVi.EditValue.ToString() == "-1")
                    {
                        frm.InThongKeTongHopGioGiang_TatCaKhoa_CDGTVT(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString()
                              , PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.PhongDaoTao, _ngayIn, vListBaoCao);

                    }
                    else
                    {
                        frm.InThongKeTongHopGioGianCDGTVT(PMS.Common.Globals._cauhinh.TenTruong, cboDonVi.Text, cboNamHoc.EditValue.ToString()
                            , PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.PhongDaoTao, "", PMS.Common.Globals._cauhinh.NguoiLapbieu
                            , _ngayIn, vListBaoCao);
                    }


                    frm.ShowDialog();

                }
            }
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
                            gridControlThongKe.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
        }
    }
}
