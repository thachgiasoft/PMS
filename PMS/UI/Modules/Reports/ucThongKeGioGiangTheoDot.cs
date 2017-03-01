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
    public partial class ucThongKeGioGiangTheoDot : DevExpress.XtraEditors.XtraUserControl
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
        public ucThongKeGioGiangTheoDot()
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

        private void ucThongKeGioGiangTheoDot_Load(object sender, EventArgs e)
        {
            #region Init GirdView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "TenDonVi", "MaQuanLy", "Ho", "Ten", "ThucDayLt", "Thdc", "Thcn", "Nn", "LyThuyetSuPham", "ThcnSuPham", "TongTietQuyDoi", "KhoiLuongCongThem", "TongGio" }
                    , new string[] { "STT", "Đơn vị", "Mã giảng viên", "Họ", "Tên", "LT tổng hợp", "TH ĐC tổng hợp", "TH CN tổng hợp", "NN", "LT Sư phạm", "TH CN Sư phạm", "Số giờ quy đổi", "Số giờ quy đổi KL", "Tổng giờ quy đổi" }
                    , new int[] { 50, 99, 90, 125, 65, 70, 70, 70, 70, 70, 70, 80, 80, 80 });
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "TenDonVi", "MaQuanLy", "Ho", "Ten", "ThucDayLt", "Thdc", "Thcn", "Nn", "LyThuyetSuPham", "ThcnSuPham", "TongTietQuyDoi", "KhoiLuongCongThem", "TongGio" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewThongKe, "MaQuanLy", "{0} giảng viên", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewThongKe, new string[] { "ThucDayLt", "Thdc", "Thcn", "Nn", "LyThuyetSuPham", "ThcnSuPham", "TongTietQuyDoi", "KhoiLuongCongThem", "TongGio" }, "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewThongKe, new string[] { "ThucDayLt", "Thdc", "Thcn", "Nn", "LyThuyetSuPham", "ThcnSuPham", "TongTietQuyDoi", "KhoiLuongCongThem", "TongGio" }, DevExpress.Utils.FormatType.Custom, "n2");
            gridViewThongKe.Columns["TenDonVi"].GroupIndex = 0;
            AppGridView.FixedField(gridViewThongKe, new string[] { "Stt", "MaQuanLy", "Ho", "Ten" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            PMS.Common.Globals.WordWrapHeader(gridViewThongKe, 40); 
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

            #region Init Khoa-DonVi
            cboDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cboDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cboDonVi.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (_groupName == v.MaBoMon)
                {
                    userRole = true;
                    break;
                }
                else
                    userRole = false;

            }

            if (userRole)
            {
                _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);

            }

            _vListKhoaBoMon.Sort("MaKhoa");
            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (v.MaKhoa == v.MaBoMon)
                    _list.Add(new CheckedListBoxItem(v.MaKhoa, v.MaKhoa + " - " + v.TenKhoa, CheckState.Unchecked, true));
            }

            cboDonVi.Properties.Items.AddRange(_list.ToArray());
            cboDonVi.Properties.SeparatorChar = ';';
            cboDonVi.CheckAll();
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
            _list = new List<CheckedListBoxItem>();
            //MessageBox.Show(UserInfo.GroupID + " - " + UserInfo.GroupName);
            foreach (ViewBacDaoTaoLoaiHinh v in _vListBacDaoTaoLoaiHinh)
            {
                if(UserInfo.GroupName.Equals("DT"))
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
        void InitDotThanhToan()
        {
            //if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            //{
                //#region _dotThanhToan
                //cboDotThanhToan.Properties.SelectAllItemCaption = "Tất cả";
                //cboDotThanhToan.Properties.TextEditStyle = TextEditStyles.Standard;
                //cboDotThanhToan.Properties.Items.Clear();
                //_listDotThanhToan = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                //List<CheckedListBoxItem> _listDot = new List<CheckedListBoxItem>();
                //foreach (CauHinhChotGio v in _listDotThanhToan)
                //{
                //    _listDot.Add(new CheckedListBoxItem(v.MaCauHinhChotGio, v.MaQuanLy + " - " + v.TenQuanLy, CheckState.Unchecked, true));
                //}
                //cboDotThanhToan.Properties.Items.AddRange(_listDot.ToArray());
                //cboDotThanhToan.Properties.SeparatorChar = ';';
                //cboDotThanhToan.CheckAll();
                //#endregion
            //}

            #region _dotThanhToan
            AppGridLookupEdit.InitGridLookUp(cboDotThanhToan, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDotThanhToan, new string[] { "MaQuanLy", "TenQuanLy" }, new string[] { "Mã đợt", "Tên đợt" });
            cboDotThanhToan.Properties.ValueMember = "MaCauHinhChotGio";
            cboDotThanhToan.Properties.DisplayMember = "TenQuanLy";
            cboDotThanhToan.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Đợt thanh toán hiện tại").GiaTri;
            cboDotThanhToan.Properties.NullText = string.Empty;
            #endregion

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceDotThanhToan.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());

            InitDotThanhToan();

            //LoadDataSource();
        }

        void LoadDataSource()
        {
            if (cboNamHoc.EditValue != null && cboDonVi.EditValue != null && cboDotThanhToan.EditValue != null && cboDonVi.EditValue != null && cboLoaiGiangVien.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeGioGiangTheoDot(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboDonVi.EditValue.ToString(), cboDotThanhToan.EditValue.ToString(), cboLoaiGiangVien.EditValue.ToString(), cboLoaiHinhDaoTao.EditValue.ToString());
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
                    frm.ThongKeGioGiangTheoDot(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), cboHocKy.Text, cboDotThanhToan.Text
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

        #region Event Cbo
        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            InitDotThanhToan();
            Cursor.Current = Cursors.Default;

        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitDotThanhToan();
            Cursor.Current = Cursors.Default;

        }
        #endregion
    }
}
