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
using PMS.UI.Forms.NghiepVu.FormXuLy;
using PMS.BLL;

namespace PMS.UI.Modules.Reports
{
    public partial class ucBangKeThanhToanTienChamBaiCTIM : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        int lanchot = 0;
        DateTime _ngayIn;
        VList<ViewKhoa> _vListKhoaBoMon;
        string groupname = UserInfo.GroupName;
        string _maTruong;
        #endregion
        public ucBangKeThanhToanTienChamBaiCTIM()
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
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucBangKeThanhToanTienChamBaiCTIM_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTen", "MonThi", "Stc", "TenHinhThucThi", "LopSinhVien", "SoBai", "HeSoCham", "DonGiaChuan", "ThanhTien", "ThueThuNhap", "ThucLinh" }
                    , new string[] { "STT", "Mã giảng viên", "Họ tên", "Môn thi", "Số tín chỉ", "Hình thức thi", "Lớp khoá", "Số bài chấm", "Hệ số chấm bài", "Đơn giá chuẩn", "Thành tiền", "Thuế TNCN (%)", "Số tiền còn lĩnh" }
                    , new int[] { 50, 90, 140, 140, 50, 100, 90, 70, 70, 70, 100, 100, 100 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "HoTen", "MonThi", "Stc", "TenHinhThucThi", "LopSinhVien", "SoBai", "HeSoCham", "DonGiaChuan", "ThanhTien", "ThueThuNhap", "ThucLinh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.FormatDataField(gridViewThongKe, "DonGiaChuan", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThanhTien", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThueThuNhap", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewThongKe, "ThucLinh", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
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


            #region Bac dao tao
            AppGridLookupEdit.InitGridLookUp(cboBacDaoTao, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboBacDaoTao, new string[] { "MaBacDaoTao", "TenBacDaoTao" }, new string[] { "Mã bậc đào tạo", "Tên bậc đào tạo" });
            cboBacDaoTao.Properties.ValueMember = "MaBacDaoTao";
            cboBacDaoTao.Properties.DisplayMember = "TenBacDaoTao";
            cboBacDaoTao.Properties.NullText = string.Empty;
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

            #region Loai giang vien
            AppGridLookupEdit.InitGridLookUp(cboLoaiGiangVien, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLoaiGiangVien, new string[] { "MaQuanLy", "TenLoaiGiangVien" }, new string[] { "Mã loại giảng viên", "Tên loại giảng viên" });
            cboLoaiGiangVien.Properties.ValueMember = "MaLoaiGiangVien";
            cboLoaiGiangVien.Properties.DisplayMember = "TenLoaiGiangVien";
            cboLoaiGiangVien.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }
        #region InitData()
        void InitData()
        {
            cboBacDaoTao.DataBindings.Clear();
            bindingSourceBacDaoTao.DataSource = DataServices.ViewBacDaoTao.GetAll();
            cboBacDaoTao.DataBindings.Add("EditValue", bindingSourceBacDaoTao, "MaBacDaoTao", true, DataSourceUpdateMode.OnPropertyChanged);
            InitKhoaHoc();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            cboLoaiGiangVien.DataBindings.Clear();
            bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.LayLoaiGiangVienThongKe();
            cboLoaiGiangVien.DataBindings.Add("EditValue", bindingSourceLoaiGiangVien, "MaLoaiGiangVien", true, DataSourceUpdateMode.OnPropertyChanged);

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboBacDaoTao.EditValue != null && cboKhoaHoc.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.ThuLaoChamBai.BangKeThanhToanTienChamBaiCtim(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaHoc.EditValue.ToString(), cboBacDaoTao.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), int.Parse(cboLoaiGiangVien.EditValue.ToString()));
                dt.Load(reader);
                bindingSourceThongKe.DataSource = dt;

                if (cboLoaiGiangVien.EditValue.ToString() != "3") // 3 là thỉnh giảng
                {
                    gridViewThongKe.Columns["ThueThuNhap"].Visible = false;
                    gridViewThongKe.Columns["ThucLinh"].Visible = false;
                }
                else
                {
                    gridViewThongKe.Columns["ThueThuNhap"].Visible = true;
                    gridViewThongKe.Columns["ThucLinh"].Visible = true;
                }
            }
        }

        void InitKhoaHoc()
        {
            if (cboBacDaoTao.EditValue != null)
            {
                cboKhoaHoc.Properties.SelectAllItemCaption = "Tất cả";
                cboKhoaHoc.Properties.TextEditStyle = TextEditStyles.Standard;
                cboKhoaHoc.Properties.Items.Clear();

                VList<ViewKhoaHocBacHe> _vListKHBH = new VList<ViewKhoaHocBacHe>();
                _vListKHBH = DataServices.ViewKhoaHocBacHe.GetByMaBacDaoTao(cboBacDaoTao.EditValue.ToString());
                List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
                foreach (ViewKhoaHocBacHe v in _vListKHBH)
                {
                    _list.Add(new CheckedListBoxItem(v.MaKhoaHoc, v.TenKhoaHoc, CheckState.Unchecked, true));
                }
                _list.Add(new CheckedListBoxItem("-1", "Lớp học phần chưa gắn khoá học", CheckState.Unchecked, true));
                cboKhoaHoc.Properties.Items.AddRange(_list.ToArray());
                cboKhoaHoc.Properties.SeparatorChar = ';';
                cboKhoaHoc.CheckAll();
            }
        }

        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboLoaiGiangVien.EditValue != null && cboBacDaoTao.EditValue != null && cboKhoaHoc.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.ThuLaoChamBai.BangKeThanhToanTienChamBaiCtim(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaHoc.EditValue.ToString(), cboBacDaoTao.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString(), int.Parse(cboLoaiGiangVien.EditValue.ToString()));
                dt.Load(reader);
                bindingSourceThongKe.DataSource = dt;

                if (cboLoaiGiangVien.EditValue.ToString() != "3") // 3 là thỉnh giảng
                {
                    gridViewThongKe.Columns["ThueThuNhap"].Visible = false;
                    gridViewThongKe.Columns["ThucLinh"].Visible = false;
                }
                else
                {
                    gridViewThongKe.Columns["ThueThuNhap"].Visible = true;
                    gridViewThongKe.Columns["ThucLinh"].Visible = true;
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                if (frmChon.NgayIn.ToString("dd/MM/yyyy") == "01/01/0001")
                    return;
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

            vListBaoCao.AcceptChanges();
          
            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    if (cboLoaiGiangVien.EditValue.ToString() == "3")//GV thỉnh giảng
                    {
                        frm.InThongKeThanhToanTienChamBaiGVThinhGiang(cboNamHoc.EditValue.ToString(), cboHocKy.Text, cboKhoaDonVi.Text
                            , PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.KeToan, PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.NguoiLapbieu
                            , cboKhoaHoc.Text, cboBacDaoTao.Text, _ngayIn
                            , vListBaoCao);
                        frm.ShowDialog();
                    }
                    else
                    {
                        frm.InThongKeThanhToanTienChamBaiCBKGHDDH(cboNamHoc.EditValue.ToString(), cboHocKy.Text, cboKhoaDonVi.Text
                            , PMS.Common.Globals._cauhinh.PhongDaoTao, PMS.Common.Globals._cauhinh.KeToan, PMS.Common.Globals._cauhinh.BanGiamHieu, PMS.Common.Globals._cauhinh.NguoiLapbieu
                            , cboKhoaHoc.Text, cboBacDaoTao.Text, cboLoaiGiangVien.Text, _ngayIn
                            , vListBaoCao);
                        frm.ShowDialog();
                    }
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

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
        }

        private void cboBacDaoTao_EditValueChanged(object sender, EventArgs e)
        {
            InitKhoaHoc();
        }
    }
}
