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
using PMS.UI.Forms.NghiepVu.FormXuLy;

namespace PMS.UI.Modules.Reports
{
    public partial class ucBangThanhToanTongHop_ACT : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        string _maTruong, _hoTenGiangVien, _trinhDo, _maSoThue, _khoaDonVi
                , _namHocTruoc, _hocKyTruoc;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        DateTime _ngayIn;
        float _soTietNghiaVu, _soTietKhacNghiaVu, _tongTietGiangDay, _tongTietCongTacKhac, _donGiaGiangDay, _donGiaCongTacKhac, _heSoThamNien
                , _noGioGiangKyTruoc, _noGioKhacKyTruoc;
        int _maLoaiGiangVien;
        #endregion
        public ucBangThanhToanTongHop_ACT()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucBangThanhToanTongHop_ACT_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewThongKe, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewThongKe, new string[] { "Stt", "HocKy", "MaMonHoc", "TenMonHoc", "MaLop", "SiSo", "TietThucDay", "TietQuyDoi", "Loai" }
                    , new string[] { "STT", "Học kỳ", "Mã môn học", "Tên môn học", "Lớp", "Sĩ số", "Tổng số tiết", "Số tiết quy chuẩn", "Phân loại" }
                    , new int[] { 40, 50, 90, 200, 100, 70, 90, 100, 99 });
            AppGridView.ReadOnlyColumn(gridViewThongKe);
            AppGridView.AlignHeader(gridViewThongKe, new string[] { "Stt", "HocKy", "MaMonHoc", "TenMonHoc", "MaLop", "SiSo", "TietThucDay", "TietQuyDoi", "Loai" }, DevExpress.Utils.HorzAlignment.Center);
            gridViewThongKe.Columns["Loai"].GroupIndex = 0;
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

            #region GiangVien
            AppGridLookupEdit.InitGridLookUp(cboGiangVien, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboGiangVien, new string[] { "MaQuanLy", "HoTen" }, new string[] { "Mã giảng viên", "Họ tên" });
            cboGiangVien.Properties.ValueMember = "MaGiangVien";
            cboGiangVien.Properties.DisplayMember = "HoTen";
            cboGiangVien.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboDonVi.EditValue != null)
            {
                cboGiangVien.DataBindings.Clear();
                bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetByMaDonVi(cboDonVi.EditValue.ToString());
                cboGiangVien.DataBindings.Add("EditValue", bindingSourceGiangVien, "MaGiangVien", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            //if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboGiangVien.EditValue != null)
            //{
            //    DataTable dt = new DataTable();
            //    IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeTongHopAct(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboGiangVien.EditValue.ToString()));
            //    dt.Load(reader);
            //    bindingSourceThongKe.DataSource = dt;
            //}
            gridViewThongKe.ExpandAllGroups();
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
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboGiangVien.EditValue != null)
            {
                DataTable dt = new DataTable();
                IDataReader reader = DataServices.KetQuaThanhToanThuLao.ThongKeTongHop_Act(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboGiangVien.EditValue.ToString()));
                dt.Load(reader);
                bindingSourceThongKe.DataSource = dt;
                gridViewThongKe.ExpandAllGroups();
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region Chọn ngày in
            using (frmChonNgay frmChon = new frmChonNgay())
            {
                frmChon.ShowDialog();
                _ngayIn = frmChon.NgayIn;
            }
            Cursor.Current = Cursors.WaitCursor;
            #endregion

            #region Lấy thông tin giảng viên
            DataTable tblThongTin = new DataTable();
            IDataReader rd = DataServices.KetQuaThanhToanThuLao.GetThongTinGiangVienTheoNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboGiangVien.EditValue.ToString()));
            tblThongTin.Load(rd);

            _hoTenGiangVien = tblThongTin.Rows[0]["HoTen"].ToString();
            _trinhDo = tblThongTin.Rows[0]["TenHocVi"].ToString();
            _maSoThue = tblThongTin.Rows[0]["MaSoThue"].ToString();
            _khoaDonVi = tblThongTin.Rows[0]["TenKhoa"].ToString();
            _soTietNghiaVu = float.Parse(tblThongTin.Rows[0]["TietNghiaVuGiangDay"].ToString());
            _soTietKhacNghiaVu = float.Parse(tblThongTin.Rows[0]["TietNghiaVuCongTacKhac"].ToString());
            _namHocTruoc = tblThongTin.Rows[0]["NamHocTruoc"].ToString();
            _hocKyTruoc = tblThongTin.Rows[0]["HocKyTruoc"].ToString();
            _tongTietGiangDay = float.Parse(tblThongTin.Rows[0]["SoTietGiangDay"].ToString());
            _tongTietCongTacKhac = float.Parse(tblThongTin.Rows[0]["SoTietCongTacKhac"].ToString());
            _donGiaGiangDay = float.Parse(tblThongTin.Rows[0]["DonGia"].ToString());
            _donGiaCongTacKhac = float.Parse(tblThongTin.Rows[0]["DonGiaCongTacKhac"].ToString());
            _heSoThamNien = float.Parse(tblThongTin.Rows[0]["HeSoThamNien"].ToString());
            _noGioGiangKyTruoc = float.Parse(tblThongTin.Rows[0]["SoTietGiangDayNoKyTruoc"].ToString());
            _noGioKhacKyTruoc = float.Parse(tblThongTin.Rows[0]["SoTietKhacNoKyTruoc"].ToString());
            _maLoaiGiangVien = int.Parse(tblThongTin.Rows[0]["MaLoaiGiangVien"].ToString());
            #endregion

            #region Lấy thông tin in report
            //Nhiệm vụ giảng dạy
            DataTable tblNhiemVuGiangDay = new DataTable();
            IDataReader rdNhiemVuGD = DataServices.KetQuaThanhToanThuLao.GetNhiemVuGiangDay(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboGiangVien.EditValue.ToString()));
            tblNhiemVuGiangDay.Load(rdNhiemVuGD);
            //Nhiệm vụ NCKH
            DataTable tblNhiemVuNCKH = new DataTable();
            IDataReader rdNCKH = DataServices.KetQuaThanhToanThuLao.GetNhiemVuNghienCuuKhoaHoc(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboGiangVien.EditValue.ToString()));
            tblNhiemVuNCKH.Load(rdNCKH);
            //Công tác khác
            DataTable tblCongTacKhac = new DataTable();
            IDataReader rdCTK = DataServices.KetQuaThanhToanThuLao.GetCongTacKhac(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), int.Parse(cboGiangVien.EditValue.ToString()));
            tblCongTacKhac.Load(rdCTK);
            #endregion

            if (tblThongTin != null)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeTongHopThanhToanGioGiangACT(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), PMS.Common.Globals._cauhinh.TenTruong, _khoaDonVi, _hoTenGiangVien, _trinhDo, _maSoThue
                        , _soTietNghiaVu, _soTietKhacNghiaVu, _namHocTruoc, _hocKyTruoc, _tongTietGiangDay, _tongTietCongTacKhac, _donGiaGiangDay, _donGiaCongTacKhac, _heSoThamNien, _noGioGiangKyTruoc, _noGioKhacKyTruoc, _maLoaiGiangVien
                        , _ngayIn, tblNhiemVuGiangDay, tblNhiemVuNCKH, tblCongTacKhac);
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
                    sf.ShowDialog();
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

        private void cboDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if (cboDonVi.EditValue != null)
            {
                cboGiangVien.DataBindings.Clear();
                bindingSourceGiangVien.DataSource = DataServices.ViewGiangVien.GetByMaDonVi(cboDonVi.EditValue.ToString());
                cboGiangVien.DataBindings.Add("EditValue", bindingSourceGiangVien, "MaGiangVien", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }


    }
}
