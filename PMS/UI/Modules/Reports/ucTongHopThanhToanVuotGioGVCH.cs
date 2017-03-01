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
using PMS.BLL;
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Modules.Reports
{
    public partial class ucTongHopThanhToanVuotGioGVCH : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        VList<ViewKhoa> _vListKhoaBoMon;
        string groupname = UserInfo.GroupName;
        string _maTruong;
        #endregion
        public ucTongHopThanhToanVuotGioGVCH()
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
            _maTruong = _cauHinhChung.Find(i => i.TenCauHinh == "Mã trường").GiaTri;

        }

        private void ucTongHopThanhToanVuotGioGVCH_Load(object sender, EventArgs e)
        {
            
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "ChucDanh", "BangKeDinhKem", "ThanhTien", "Thue", "ThucLinh" }
                    , new string[] { "Mã giảng viên", "Họ tên", "Chức danh", "Bảng kê đính kèm", "Số tiền thanh toán", "Thuế TNCN (10%)", "Số tiền còn lĩnh" }
                    , new int[] { 90, 140, 140, 110, 110, 100, 110 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "MaQuanLy", "HoTen", "ChucDanh", "BangKeDinhKem", "ThanhTien", "Thue", "ThucLinh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.FormatDataField(gridViewThongKe, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "Thue", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThucLinh", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);

            if (_maTruong == "CTIM")
            {
                gridViewThongKe.Columns["Thue"].Visible = false;
                gridViewThongKe.Columns["ThucLinh"].Visible = false;
            }

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Bac dao tao
            AppGridLookupEdit.InitGridLookUp(cbobacDaoTao, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cbobacDaoTao, new string[] { "MaBacDaoTao", "TenBacDaoTao" }, new string[] { "Mã bậc đào tạo", "Tên bậc đào tạo" });
            cbobacDaoTao.Properties.ValueMember = "MaBacDaoTao";
            cbobacDaoTao.Properties.DisplayMember = "TenBacDaoTao";
            cbobacDaoTao.Properties.NullText = string.Empty;
            #endregion

            #region Init Khoa-DonVi
            cboKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoaDonVi.Properties.Items.Clear();

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
            cboKhoaDonVi.Properties.Items.AddRange(_list.ToArray());
            cboKhoaDonVi.Properties.SeparatorChar = ';';
            cboKhoaDonVi.CheckAll();
            #endregion
            InitData();
        }

        void InitData()
        {
            cbobacDaoTao.DataBindings.Clear();
            bindingSourceBacDaoTao.DataSource = DataServices.ViewBacDaoTao.GetAll();
            cbobacDaoTao.DataBindings.Add("EditValue", bindingSourceBacDaoTao, "MaBacDaoTao", true, DataSourceUpdateMode.OnPropertyChanged);
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null && cbobacDaoTao.EditValue != null && cboKhoaDonVi.EditValue!=null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.TongHopThanhToanThuLaoVuotGioGiangVienCoHuu(cboNamHoc.EditValue.ToString(), cbobacDaoTao.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;
            }
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
            if (cboNamHoc.EditValue != null && cbobacDaoTao.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.TongHopThanhToanThuLaoVuotGioGiangVienCoHuu(cboNamHoc.EditValue.ToString(), cbobacDaoTao.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                tb.Load(reader);
                bindingSourceThongKe.DataSource = tb;
            }
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
            //    return;
//            int dem = vListBaoCao.Rows.Count;


            vListBaoCao.AcceptChanges();

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeTongHopThanhToanVuotGioGVCH(UserInfo.GroupName, cboNamHoc.EditValue.ToString(), cbobacDaoTao.Text, cboKhoaDonVi.Text
                        , PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.KeToan
                        , PMS.Common.Globals._cauhinh.PhongDaoTao, UserInfo.FullName, PMS.Common.Globals._cauhinh.ChucVuBanGiamHieu
                        , PMS.Common.Globals._cauhinh.ChucVuKeToan, PMS.Common.Globals._cauhinh.ChucVuDaoTao
                        , _ngayIn, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
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
