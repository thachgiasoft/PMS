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
    public partial class ucTongHopGioGiangToanTruongTheoNam : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        DateTime _ngayIn;
        bool userRole;
        string _groupName = UserInfo.GroupName;
        TList<CauHinhChotGio> _listDotThanhToan;

        #endregion

        #region Event Grid
        public ucTongHopGioGiangToanTruongTheoNam()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;

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

        private void ucTongHopGioGiangToanTruongTheoNam_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "MaDonVi", "TenDonVi", "ThucDayLt", "Thdc", "Thcn", "Nn", "TietQuyDoiTongHop", "LyThuyetSuPham", "ThcnSuPham", "TietQuyDoiSuPham", "TongTietQuyDoi", "KhoiLuongCongThem", "TongGio" }
                    , new string[] { "Stt", "Mã Khoa", "Tên khoa", "LT tổng hợp", "TH ĐC tổng hợp", "TH CN tổng hợp", "NN", "QĐ tổng hợp", "LT Sư phạm", "TH CN Sư phạm", "QĐ sư phạm", "Số giờ quy đổi", "Số giờ quy đổi KL", "Tổng giờ quy đổi" }
                    , new int[] { 40, 70, 125, 60, 60, 60, 60, 70, 60, 60, 70, 70, 70, 70 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "MaDonVi", "TenDonVi", "ThucDayLt", "Thdc", "Thcn", "Nn", "TietQuyDoiTongHop", "LyThuyetSuPham", "ThcnSuPham", "TietQuyDoiSuPham", "TongTietQuyDoi", "KhoiLuongCongThem", "TongGio" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "TenDonVi", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.FormatDataField(gridViewThongKe, new string[] { "ThucDayLt", "Thdc", "Thcn", "Nn", "TietQuyDoiTongHop", "LyThuyetSuPham", "ThcnSuPham", "TietQuyDoiSuPham", "TongTietQuyDoi", "KhoiLuongCongThem", "TongGio" }, DevExpress.Utils.FormatType.Custom, "{0:n2}");
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 35);
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion
            
            #region Init LoaiGiangVien
            cboLoaiGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cboLoaiGiangVien.Properties.Items.Clear();

            TList<LoaiGiangVien> _listLoaiGv = new TList<LoaiGiangVien>();
            _listLoaiGv = DataServices.LoaiGiangVien.GetAll();

            List<CheckedListBoxItem> _listLGV = new List<CheckedListBoxItem>();
            foreach (LoaiGiangVien v in _listLoaiGv)
            {
                if (v.MaQuanLy.Equals("TG")) continue;
                _listLGV.Add(new CheckedListBoxItem(v.MaLoaiGiangVien.ToString(), v.TenLoaiGiangVien, CheckState.Unchecked, true));
            }
            cboLoaiGiangVien.Properties.Items.AddRange(_listLGV.ToArray());
            cboLoaiGiangVien.Properties.SeparatorChar = ';';
            cboLoaiGiangVien.CheckAll();
            #endregion

            #region LoaiHinhDaoTao
            cboLoaiHinhDaoTao.Properties.NullText = "Chưa chọn";
            cboLoaiHinhDaoTao.Properties.SelectAllItemCaption = "Tất cả";
            cboLoaiHinhDaoTao.Properties.TextEditStyle = TextEditStyles.Standard;
            VList<ViewBacDaoTaoLoaiHinh> _vListBacDaoTaoLoaiHinh = DataServices.ViewBacDaoTaoLoaiHinh.GetAll();
            _vListBacDaoTaoLoaiHinh.Sort("MaBacLoaiHinh");
            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewBacDaoTaoLoaiHinh v in _vListBacDaoTaoLoaiHinh)
            {
                if (UserInfo.GroupName.Equals("DT"))
                {
                    if ("CD - CQ; DH - CQ; DH - XT".Contains(v.MaBacLoaiHinh))
                    {
                        _list.Add(new CheckedListBoxItem(v.MaBacLoaiHinh, v.TenBacLoaiHinh, CheckState.Unchecked, true));
                    }
                }
                else if (UserInfo.GroupName.Equals("PDTTX"))
                {
                    if ("DH - TC".Contains(v.MaBacLoaiHinh))
                    {
                        _list.Add(new CheckedListBoxItem(v.MaBacLoaiHinh, v.TenBacLoaiHinh, CheckState.Unchecked, true));
                    }
                }
                else if (UserInfo.GroupName.Equals("SDH"))
                {
                    if ("CH - CQ".Contains(v.MaBacLoaiHinh))
                    {
                        _list.Add(new CheckedListBoxItem(v.MaBacLoaiHinh, v.TenBacLoaiHinh, CheckState.Unchecked, true));
                    }
                }
                else if (UserInfo.GroupName.Equals("Administrator"))
                {
                    _list.Add(new CheckedListBoxItem(v.MaBacLoaiHinh, v.TenBacLoaiHinh, CheckState.Unchecked, true));
                }
            }
            cboLoaiHinhDaoTao.Properties.Items.AddRange(_list.ToArray());
            cboLoaiHinhDaoTao.Properties.SeparatorChar = ';';
            cboLoaiHinhDaoTao.CheckAll();
            #endregion
            
            InitData();
        }
        #endregion

        #region InitData()
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.BangTongHopGioGiangToanTruongTheoNam(cboNamHoc.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString());
                dt.Load(reader);
                bindingSourceThongKe.DataSource = dt;
                gridViewThongKe.ExpandAllGroups();
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

            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewThongKe, bindingSourceThongKe);

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.ThongKeTongHopGioGiangToanTruongTheoNam(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), "", ""
                        , PMS.Common.Globals._cauhinh.PhongDaoTao, UserInfo.FullName, _ngayIn, vListBaoCao);
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

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoadDataSource();
            Cursor.Current = Cursors.Default;
        }
        #endregion
    }
}
