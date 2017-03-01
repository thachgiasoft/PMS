using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using PMS.BLL;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;
using PMS.UI.Forms.BaoCao;
using DevExpress.Common.Grid;

namespace PMS.UI.Modules.Reports
{
    public partial class ucTongHopThanhToanThuLaoTheoNam_HBU : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        #endregion

        public ucTongHopThanhToanThuLaoTheoNam_HBU()
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

            //DataTable temp = new DataTable();

            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongKe);

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InDanhSachThanhToanThuLaoTheoNam_HBU(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), ""
                        , PMS.Common.Globals._cauhinh.PhongToChucCanBo, PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.NguoiLapbieu
                        , vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void ucTongHopThanhToanThuLaoTheoNam_HBU_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "TenBoMon", "TenLoaiGiangVien", "TenHocHam", "TenHocVi", "TongTietNghiaVu", "TongTietMienGiam", "TongTietQuyDoi", "TongTietGiangDay", "TongTietNckh", "TongTietKhac", "TietVuot", "DonGia", "DonGiaClc", "TienVuot", "ThueTncn", "ThucLanh" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Tên đơn vị", "Loại giảng viên", "Tên học hàm", "Tên học vị", "Tổng tiết nghĩa vụ", "Tổng tiết miễn giảm", "Tổng tiết quy đổi", "Tổng tiết giảng dạy", "Tổng tiết NCKH", "Tổng tiết HĐ khác", "Tiết vượt", "Đơn giá đại trà", "Đơn giá CLC", "Tiền vượt", "Thuế TNCN", "Thực lãnh" }
                    , new int[] { 70, 150, 120, 120, 90, 90, 100, 100, 100, 100, 100, 100, 70, 70, 70, 100, 110, 110 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "TenBoMon", "TenLoaiGiangVien", "TenHocHam", "TenHocVi", "TongTietNghiaVu", "TongTietMienGiam", "TongTietQuyDoi", "TongTietGiangDay", "TongTietNckh", "TongTietKhac", "TietVuot", "DonGia", "DonGiaClc", "ThueTncn", "TienVuot", "ThucLanh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "DonGiaClc", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThueTncn", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "TienVuot", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThucLanh", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 45);
            AppGridView.FixedField(gridViewThongKe, new string[] { "MaQuanLy", "HoTen" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            
            #region Init Khoa-DonVi
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();

            VList<ViewKhoa> _vListKhoaBoMon = new VList<ViewKhoa>();
            _vListKhoaBoMon = DataServices.ViewKhoa.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoa v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaKhoa, v.TenKhoa, CheckState.Unchecked, true));
            }
            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
            #endregion

            InitData();
        }

        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            gridViewThongKe.ExpandAllGroups();
        }

        #endregion

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null)
            {
                try
                {
                    DataTable dt = new DataTable();
                    IDataReader reader = DataServices.KetQuaThanhToanThuLao.BangThanhToanGioGiangCoHuuCaNam(cboNamHoc.EditValue.ToString(), cboDonVi.EditValue.ToString(), "");
                    dt.Load(reader);
                    bindingSourceThongKe.DataSource = dt;
                }
                catch
                {  }
            }
            gridViewThongKe.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }
    }
}
