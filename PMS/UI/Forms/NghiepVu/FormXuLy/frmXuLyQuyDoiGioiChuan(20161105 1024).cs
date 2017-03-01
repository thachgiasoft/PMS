using System;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using PMS.Services;
using PMS.Entities;
using PMS.Services;
using System.Globalization;
using System.Threading;
using System.Data;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmXuLyQuyDoiGioiChuan : XtraForm
    {
        #region Variable
        private DataParameter _inputParameter;
        bool QuyDoiBoSung = false;
        string MaTruong, MaDonVi, XmlData;
        int QuyDoiTheoGiangVienLopHocPhan;
        DateTime TuNgay, DenNgay;
        TList<GiangVien> _listGiangVien = DataServices.GiangVien.GetAll();
        TList<CauHinhChung> _listCauHinhChung = DataServices.CauHinhChung.GetAll();
        NumberFormatInfo num = new NumberFormatInfo();
        /// <summary>
        /// Input param
        /// </summary>
        public struct DataParameter
        {
            public string NamHoc;
            public string HocKy;
        }
        int DotThanhToan;
        bool QuyDoiTamUng = false;
        #endregion

        #region Event Form
        public frmXuLyQuyDoiGioiChuan(string _namHoc, string _hocKy)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
        }

        //Bo sung quy doi tiet thuc day
        public frmXuLyQuyDoiGioiChuan(string _namHoc, string _hocKy, bool _boSung)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            QuyDoiBoSung = _boSung;
        }

        public frmXuLyQuyDoiGioiChuan(string _namHoc, string _hocKy, string _maTruong)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            MaTruong = _maTruong;
        }


        public frmXuLyQuyDoiGioiChuan(string _namHoc, string _hocKy, int _dotThanhToan, string _maTruong)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            MaTruong = _maTruong;
            DotThanhToan = _dotThanhToan;
        }


        public frmXuLyQuyDoiGioiChuan(string _namHoc, string _hocKy, string _maTruong, string _maDonVi)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            MaTruong = _maTruong;
            MaDonVi = _maDonVi;
        }

        public frmXuLyQuyDoiGioiChuan(string _namHoc, string _hocKy, string _maTruong, string _xmlData, int _quyDoiTheoGVLHP)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            MaTruong = _maTruong;
            XmlData = _xmlData;
            QuyDoiTheoGiangVienLopHocPhan = _quyDoiTheoGVLHP;
        }

        public frmXuLyQuyDoiGioiChuan(DateTime _tuNgay, DateTime _denNgay, string _maTruong)
        {
            InitializeComponent();
            TuNgay = _tuNgay;
            DenNgay = _denNgay;
            MaTruong = _maTruong;
        }

        public frmXuLyQuyDoiGioiChuan(string _namHoc, string _hocKy, string _maTruong, bool _tamUng)
        {
            InitializeComponent();
            _inputParameter.NamHoc = _namHoc;
            _inputParameter.HocKy = _hocKy;
            QuyDoiTamUng = _tamUng;
            MaTruong = _maTruong;
        }

        private void frmXuLyTinhThanhToanGioGiang_Load(object sender, EventArgs e)
        {
            progressBar.Properties.Minimum = 0;
            progressBar.Position = 0;
            //Do worker
            backgroundWorker.RunWorkerAsync(_inputParameter);
        }

        #endregion

        #region backgroundWorker
        /// <summary>
        /// DoWork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            //Init
            int index = 1;
            string NamHoc = ((DataParameter)e.Argument).NamHoc;
            string HocKy = ((DataParameter)e.Argument).HocKy;

            if (MaTruong == "TCB")
            {
                //Xu ly TCB
                QuyDoiTCB(index);
            }
            else if (MaTruong == "USSH")
            {
                QuyDoiUSSH(index, NamHoc, HocKy);
            }
            else if (MaTruong == "ACT")
            {
                if (QuyDoiTheoGiangVienLopHocPhan == 1)//Quy đổi theo cách chọn từng dòng
                {
                    QuyDoiACTTheoXML(index, NamHoc, HocKy, XmlData);
                }
                else
                {
                    if (MaDonVi != "" && MaDonVi != null)//Quy đổi theo từng khoa
                        QuyDoiACTTheoDonVi(index, NamHoc, HocKy, MaDonVi);
                    else//Quy đổi toàn trường
                        QuyDoiACT(index, NamHoc, HocKy);
                }
            }
            else if (MaTruong == "UEL")
                QuyDoiUEL(index, NamHoc, HocKy);
            else if (MaTruong == "CTIM")
                QuyDoiCTIM(index, NamHoc, HocKy);
            else if (MaTruong == "IUH")
            {
                if (QuyDoiTheoGiangVienLopHocPhan == 1)
                    QuyDoiIUHTheoTungLHP(index, XmlData, NamHoc, HocKy);
                else
                    QuyDoiIUH(index, NamHoc, HocKy);
            }
            else if (MaTruong == "LAW")
            {
                if (QuyDoiTamUng)
                    QuyDoiTamUngLAW(index, NamHoc, HocKy);
                else
                    if (QuyDoiTheoGiangVienLopHocPhan == 1) 
                        QuyDoiLAWTheoTungLHP(index, XmlData, NamHoc, HocKy);
                    else
                    QuyDoiLAW(index, NamHoc, HocKy);
            }
            else if (MaTruong == "BUH")
                QuyDoiBUH(index, NamHoc, HocKy);
            else if (MaTruong == "VHU")
                QuyDoiVHU(index, NamHoc, HocKy);
            else if (MaTruong == "CDGTVT")
                QuyDoiCDGTVT(index, NamHoc, HocKy);
            else if (MaTruong == "HBU")
                QuyDoiHBU(index, NamHoc, HocKy);
            else if (MaTruong == "DLU")
                QuyDoiDLU(index, NamHoc, HocKy);

            //string _danhSachTruong = "TCB;USSH;ACT;UEL;CTIM;IUH;LAW;BUH;VHU;CDGTVT;HBU;DLU";
            else //(_danhSachTruong.Contains(MaTruong) == false)
                QuyDoiCacTruongConLai(index, NamHoc, HocKy);
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Position = e.ProgressPercentage;
            lblTenHoiDong.Text = e.UserState.ToString();
            progressBar.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            XtraMessageBox.Show("Đã hoàn tất quy đổi khối lượng giảng dạy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        #endregion

        #region Cac ham bo tro
        #region IsNull
        object IsNull(object O)
        {
            if (O == null)
                O = 0;
            return O;
        }
        #endregion

        decimal ConvertDecimal(string s)
        {
            decimal result = 0;
            try
            {
                if (s.Contains("/"))
                    result = decimal.Parse(s.Split('/')[0].ToString()) / decimal.Parse(s.Split('/')[1].ToString());
                else
                    result = decimal.Parse(s);
            }
            catch
            {
                result = 0;
            }
           
            return result;
        }
        #endregion

        #region QuyDoiTCB
        void QuyDoiTCB(int index)
        {
            try
            {
                TList<TienCongTacPhi> _tienCongTacPhi = DataServices.TienCongTacPhi.GetAll();
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
                //delete tu ngay den ngay
                listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNgay(TuNgay, DenNgay);
                DataServices.TcbKetQuaQuyDoi.DeleteByNgay(TuNgay, DenNgay);
                int process = listKhoiLuong.Count;

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

                        TcbKetQuaQuyDoi klQuyDoi = new TcbKetQuaQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan.ToString();
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = (int)klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaCoSo = klGiangDay.MaPhongHoc;

                        klQuyDoi.HeSoLopDong = DataServices.HeSoLopDong.GetBySiSo((int)klGiangDay.SoLuong)[0].HeSo;

                        klQuyDoi.DonGia = DataServices.DonGiaTcb.GetByMaGiangVienQuanLyNgayDay(klGiangDay.MaGiangVien, (DateTime)klGiangDay.NgayDay)[0].DonGia;

                        klQuyDoi.ThanhTien = klQuyDoi.HeSoLopDong * klQuyDoi.DonGia * klQuyDoi.SoTiet;
                        try
                        {
                            klQuyDoi.CongTacPhi = _tienCongTacPhi.Find(p => p.MaCoSo == klQuyDoi.MaCoSo).SoTien;
                        }
                        catch
                        {
                            klQuyDoi.CongTacPhi = 0;
                            //Kiểm tra cơ sở, nếu chưa có trong bảng tiền công tác phí thì catch
                        }
                        if (klQuyDoi.CongTacPhi == 0)
                        {
                            //GiangVien gv = new GiangVien();
                            //gv = DataServices.GiangVien.GetByMaQuanLy(klQuyDoi.MaGiangVien)[0];
                            int? _maLoaiGiangVien = _listGiangVien.Find(p => p.MaQuanLy == klQuyDoi.MaGiangVien).MaLoaiGiangVien;
                            if (_maLoaiGiangVien == 17)
                            {
                                klQuyDoi.CongTacPhi = 50000;
                            }
                        }

                        double heSoNgoaiGioVaHe = 1;

                        DataServices.CauHinhChung.GetHeSoHe((DateTime)klQuyDoi.NgayDay, (int)klQuyDoi.TietBatDau, ref heSoNgoaiGioVaHe);

                        klQuyDoi.TienGiangNgoaiGio = (decimal)heSoNgoaiGioVaHe * klQuyDoi.ThanhTien - klQuyDoi.ThanhTien;
                        klQuyDoi.TongThanhTien = klQuyDoi.CongTacPhi + klQuyDoi.ThanhTien + klQuyDoi.TienGiangNgoaiGio;

                        DataServices.TcbKetQuaQuyDoi.Insert(klQuyDoi);
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QuyDoiUSSH
        void QuyDoiUSSH(int index, string NamHoc, string HocKy)
        {
            try
            {
                decimal _heSoQuyDoiThucHanhLyThuyet = decimal.Parse(_listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết").GiaTri);
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
                if (QuyDoiBoSung == false)
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKy(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(NamHoc, HocKy);
                }
                else
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyBoSung(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteKhoiLuongBoSungByNamHocHocKy(NamHoc, HocKy);
                }
                int process = listKhoiLuong.Count;

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;
                        try
                        {
                            klQuyDoi.HeSoLopDong = (DataServices.HeSoLopDong.GetBySiSo(int.Parse(klQuyDoi.SoLuong.ToString())) as TList<HeSoLopDong>)[0].HeSo;
                        }
                        catch
                        {
                            klQuyDoi.HeSoLopDong = 0;
                        }
                        try
                        {
                            klQuyDoi.HeSoCoSo = (DataServices.HeSoCoSo.GetByMaPhongHocNgayDay(klQuyDoi.MaPhongHoc, DateTime.Parse(klQuyDoi.NgayDay.ToString())) as TList<HeSoCoSo>)[0].HeSo;//lấy theo mã phòng học
                        }
                        catch
                        {
                            klQuyDoi.HeSoCoSo = 1;
                        }

                        if (klQuyDoi.MaLoaiHocPhan == 2)
                            klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = _heSoQuyDoiThucHanhLyThuyet;
                        else
                            klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = 1;
                        klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet * (1 + (klQuyDoi.HeSoLopDong - 1) + (klQuyDoi.HeSoCoSo - 1));

                        DataServices.KhoiLuongQuyDoi.Insert(klQuyDoi);
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QuyDoiACT
        void QuyDoiACT(int index, string NamHoc, string HocKy)
        {
            try
            {

                decimal _heSoQuyDoiThucHanhLyThuyet = decimal.Parse(_listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết").GiaTri);
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
                if (QuyDoiBoSung == false)
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKy(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(NamHoc, HocKy);
                }
                else
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyBoSung(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteKhoiLuongBoSungByNamHocHocKy(NamHoc, HocKy);
                }
                int process = listKhoiLuong.Count;

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        //klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;
                        string Thu = klGiangDay.NgayDay.Value.DayOfWeek.ToString("d");

                        double _heSoNgoaiGio = 1;
                        DataServices.HeSoNgay.GetByThuTietBatDau(Thu, (int)klGiangDay.TietBatDau, ref _heSoNgoaiGio);
                        klQuyDoi.HeSoNgoaiGio = (decimal?)_heSoNgoaiGio;



                        TList<PhanNhomMonHoc> p = DataServices.PhanNhomMonHoc.GetByNamHocHocKyMaMonHoc(klGiangDay.NamHoc, klGiangDay.HocKy, klGiangDay.MaMonHoc);
                        if (p.Count > 0)
                            klQuyDoi.MaNhomMonHoc = p[0].MaNhomMonHoc.ToString();
                        else
                            klQuyDoi.MaNhomMonHoc = "8";//8 là nhóm chung - bt
                        try
                        {
                            klQuyDoi.HeSoLopDong = (DataServices.HeSoLopDong.GetBySiSoBacDaoTaoNhomMonHoc(int.Parse(klQuyDoi.SoLuong.ToString()), klQuyDoi.MaBacDaoTao, klQuyDoi.MaNhomMonHoc) as TList<HeSoLopDong>)[0].HeSo;
                        }
                        catch
                        {
                            klQuyDoi.HeSoLopDong = 0;
                        }
                        try
                        {
                            klQuyDoi.HeSoCoSo = (DataServices.HeSoCoSo.GetByMaPhongHocNgayDay(klQuyDoi.MaPhongHoc, DateTime.Parse(klQuyDoi.NgayDay.ToString())) as TList<HeSoCoSo>)[0].HeSo;//lấy theo mã phòng học
                        }
                        catch
                        {
                            klQuyDoi.HeSoCoSo = 1;
                        }

                        if (klQuyDoi.MaLoaiHocPhan == 2)
                            klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = _heSoQuyDoiThucHanhLyThuyet;
                        else
                            klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = 1;
                        klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet * (1 + (klQuyDoi.HeSoLopDong - 1) + (klQuyDoi.HeSoCoSo - 1) + (klQuyDoi.HeSoNgoaiGio - 1));

                        DataServices.KhoiLuongQuyDoi.Insert(klQuyDoi);
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QuyDoiACTTheoDonVi
        void QuyDoiACTTheoDonVi(int index, string NamHoc, string HocKy, string MaDonVi)
        {
            try
            {

                decimal _heSoQuyDoiThucHanhLyThuyet = decimal.Parse(_listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết").GiaTri);
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
                if (QuyDoiBoSung == false)
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyMaDonVi(NamHoc, HocKy, MaDonVi);
                    DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKyMaDonVi(NamHoc, HocKy, MaDonVi);
                }
                else
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyBoSung(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteKhoiLuongBoSungByNamHocHocKy(NamHoc, HocKy);
                }
                int process = listKhoiLuong.Count;

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        //klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;
                        string Thu = klGiangDay.NgayDay.Value.DayOfWeek.ToString("d");

                        double _heSoNgoaiGio = 1;
                        DataServices.HeSoNgay.GetByThuTietBatDau(Thu, (int)klGiangDay.TietBatDau, ref _heSoNgoaiGio);
                        klQuyDoi.HeSoNgoaiGio = (decimal?)_heSoNgoaiGio;



                        TList<PhanNhomMonHoc> p = DataServices.PhanNhomMonHoc.GetByNamHocHocKyMaMonHoc(klGiangDay.NamHoc, klGiangDay.HocKy, klGiangDay.MaMonHoc);
                        if (p.Count > 0)
                            klQuyDoi.MaNhomMonHoc = p[0].MaNhomMonHoc.ToString();
                        else
                            klQuyDoi.MaNhomMonHoc = "8";//8 là nhóm chung - bt
                        try
                        {
                            klQuyDoi.HeSoLopDong = (DataServices.HeSoLopDong.GetBySiSoBacDaoTaoNhomMonHoc(int.Parse(klQuyDoi.SoLuong.ToString()), klQuyDoi.MaBacDaoTao, klQuyDoi.MaNhomMonHoc) as TList<HeSoLopDong>)[0].HeSo;
                        }
                        catch
                        {
                            klQuyDoi.HeSoLopDong = 0;
                        }
                        try
                        {
                            klQuyDoi.HeSoCoSo = (DataServices.HeSoCoSo.GetByMaPhongHocNgayDay(klQuyDoi.MaPhongHoc, DateTime.Parse(klQuyDoi.NgayDay.ToString())) as TList<HeSoCoSo>)[0].HeSo;//lấy theo mã phòng học
                        }
                        catch
                        {
                            klQuyDoi.HeSoCoSo = 1;
                        }

                        if (klQuyDoi.MaLoaiHocPhan == 2)
                            klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = _heSoQuyDoiThucHanhLyThuyet;
                        else
                            klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = 1;
                        klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet * (1 + (klQuyDoi.HeSoLopDong - 1) + (klQuyDoi.HeSoCoSo - 1) + (klQuyDoi.HeSoNgoaiGio - 1));

                        DataServices.KhoiLuongQuyDoi.Insert(klQuyDoi);
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QuyDoiACT Theo nhung dong duoc chon
        void QuyDoiACTTheoXML(int index, string NamHoc, string HocKy, string _xmlData)
        {
            try
            {
                decimal _heSoQuyDoiThucHanhLyThuyet = decimal.Parse(_listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết").GiaTri);
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();

                listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByXmlData(_xmlData, NamHoc, HocKy);
                DataServices.KhoiLuongQuyDoi.DeleteByXmlData(_xmlData);

                int process = listKhoiLuong.Count;

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        //klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;
                        string Thu = klGiangDay.NgayDay.Value.DayOfWeek.ToString("d");

                        double _heSoNgoaiGio = 1;
                        DataServices.HeSoNgay.GetByThuTietBatDau(Thu, (int)klGiangDay.TietBatDau, ref _heSoNgoaiGio);
                        klQuyDoi.HeSoNgoaiGio = (decimal?)_heSoNgoaiGio;



                        TList<PhanNhomMonHoc> p = DataServices.PhanNhomMonHoc.GetByNamHocHocKyMaMonHoc(klGiangDay.NamHoc, klGiangDay.HocKy, klGiangDay.MaMonHoc);
                        if (p.Count > 0)
                            klQuyDoi.MaNhomMonHoc = p[0].MaNhomMonHoc.ToString();
                        else
                            klQuyDoi.MaNhomMonHoc = "8";//8 là nhóm chung - bt
                        try
                        {
                            klQuyDoi.HeSoLopDong = (DataServices.HeSoLopDong.GetBySiSoBacDaoTaoNhomMonHoc(int.Parse(klQuyDoi.SoLuong.ToString()), klQuyDoi.MaBacDaoTao, klQuyDoi.MaNhomMonHoc) as TList<HeSoLopDong>)[0].HeSo;
                        }
                        catch
                        {
                            klQuyDoi.HeSoLopDong = 0;
                        }
                        try
                        {
                            klQuyDoi.HeSoCoSo = (DataServices.HeSoCoSo.GetByMaPhongHocNgayDay(klQuyDoi.MaPhongHoc, DateTime.Parse(klQuyDoi.NgayDay.ToString())) as TList<HeSoCoSo>)[0].HeSo;//lấy theo mã phòng học
                        }
                        catch
                        {
                            klQuyDoi.HeSoCoSo = 1;
                        }

                        if (klQuyDoi.MaLoaiHocPhan == 2)
                            klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = _heSoQuyDoiThucHanhLyThuyet;
                        else
                            klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = 1;
                        klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet * (1 + (klQuyDoi.HeSoLopDong - 1) + (klQuyDoi.HeSoCoSo - 1) + (klQuyDoi.HeSoNgoaiGio - 1));

                        DataServices.KhoiLuongQuyDoi.Insert(klQuyDoi);
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QuyDoiUEL
        void QuyDoiUEL(int index, string NamHoc, string HocKy)
        {
            try
            {
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
                if (QuyDoiBoSung == false)
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKy(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(NamHoc, HocKy);
                }
                else
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyBoSung(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteKhoiLuongBoSungByNamHocHocKy(NamHoc, HocKy);
                }
                int process = listKhoiLuong.Count;

                num = Thread.CurrentThread.CurrentUICulture.NumberFormat;

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));
                      
                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;

                        int _maNhomMonHoc = 0;
                        TList<PhanNhomMonHoc> _listNhomMonHoc = DataServices.PhanNhomMonHoc.GetByNamHocHocKyMaMonHoc(klQuyDoi.NamHoc, klQuyDoi.HocKy, klGiangDay.MaMonHoc);
                        if (_listNhomMonHoc.Count > 0)
                            _maNhomMonHoc = _listNhomMonHoc[0].MaNhomMonHoc;
                        klQuyDoi.MaNhomMonHoc = _maNhomMonHoc.ToString();
                        
                        //if (_maNhomMonHoc == 10)//Nếu nhóm môn học ngoại ngữ: 
                        //    klQuyDoi.NgonNguGiangDay = "TIENGANH";
                        //else
                        //    klQuyDoi.NgonNguGiangDay = "TIENGVIET";
                        if (DataServices.LopHocPhanGiangBangTiengNuocNgoai.GetByMaLopHocPhan(klGiangDay.MaLopHocPhan) != null)
                            klQuyDoi.NgonNguGiangDay = "TIENGANH";
                        else
                            klQuyDoi.NgonNguGiangDay = "TIENGVIET";
                        double _heSoLopDong = 0, _hesoChucDanhChuyenMon = 0, _heSoDiaDiemVaNgoaiGio = 0;

                        DataServices.HeSoChucDanhChuyenMon.GetByMaGiangVienNgayDayNamHocHocKy(klGiangDay.MaGiangVien, (DateTime)klGiangDay.NgayDay, klQuyDoi.NamHoc, klQuyDoi.HocKy, ref _hesoChucDanhChuyenMon);
                        klQuyDoi.HeSoChucDanhChuyenMon = (decimal)_hesoChucDanhChuyenMon;

                        string Thu = klGiangDay.NgayDay.Value.DayOfWeek.ToString("d");
                        DataServices.HeSoCoSo.GetByNamHocHocKyMaBacDaoTaoPhongThuTietBatDau(klQuyDoi.NamHoc, klQuyDoi.HocKy, klGiangDay.MaBacDaoTao, klGiangDay.MaPhongHoc, Thu, (int)klGiangDay.TietBatDau, ref _heSoDiaDiemVaNgoaiGio);
                        klQuyDoi.HeSoCoSo = (decimal)_heSoDiaDiemVaNgoaiGio;

                        DataServices.HeSoLopDong.GetByNamHocHocKyBacDaoTaoNhomMonHocSiSo(klQuyDoi.NamHoc, klQuyDoi.HocKy, klQuyDoi.MaBacDaoTao, klQuyDoi.MaNhomMonHoc, (int)klQuyDoi.SoLuong, ref _heSoLopDong);
                        klQuyDoi.HeSoLopDong = (decimal)_heSoLopDong;

                        if (klGiangDay.MaLop.Contains("C"))
                        {
                            klQuyDoi.LoaiLop = "CLC";
                            if (num.NumberDecimalSeparator == ".")
                            {
                                klQuyDoi.HeSoClcCntn = decimal.Parse(_listCauHinhChung.Find(p => p.TenCauHinh == "Mức nhân hệ số lớp CLC").GiaTri);
                            }
                            if (num.NumberDecimalSeparator == ",")
                            {
                                string s = _listCauHinhChung.Find(p => p.TenCauHinh == "Mức nhân hệ số lớp CLC").GiaTri.Replace(".", ",");
                                klQuyDoi.HeSoClcCntn = decimal.Parse(s);
                            }
                        }
                        if (klGiangDay.MaLop.Contains("T"))
                        {
                            klQuyDoi.LoaiLop = "CNTN";
                            if (num.NumberDecimalSeparator == ".")
                            {
                                klQuyDoi.HeSoClcCntn = decimal.Parse(_listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số cử nhân tài năng").GiaTri);
                            }
                            if (num.NumberDecimalSeparator == ",")
                            {
                                string s = _listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số cử nhân tài năng").GiaTri.Replace(".", ",");
                                klQuyDoi.HeSoClcCntn = decimal.Parse(s);
                            }
                        }
                        if (klGiangDay.MaBacDaoTao != "DH")//Hệ số CNTN-CLC chỉ áp dụng đối với đại học chính quy
                            klQuyDoi.HeSoClcCntn = 0;

                        if (klQuyDoi.HeSoClcCntn == null)
                            klQuyDoi.HeSoClcCntn = 0;

                        klQuyDoi.HeSoThinhGiangMonChuyenNganh = 0; //Phân biệt môn chuyên ngành và môn thường để tính hệ số...và dựa vào loại GV
                        if (klGiangDay.MaLoaiGiangVien == 11)//11 là gv thỉnh giảng
                        {
                            if(klGiangDay.LopHocPhanChuyenNganh == true)
                            //int _kiemTraLHPChuyenNganh = 0;
                            //DataServices.LopHocPhanChuyenNganh.KiemTra(klGiangDay.MaLopHocPhan, ref _kiemTraLHPChuyenNganh);
                            //if (_kiemTraLHPChuyenNganh == 1)
                            {
                                if (num.NumberDecimalSeparator == ".")
                                {
                                    klQuyDoi.HeSoThinhGiangMonChuyenNganh = decimal.Parse(_listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số thỉnh giảng môn chuyên ngành").GiaTri);
                                }
                                if (num.NumberDecimalSeparator == ",")
                                {
                                    string s = _listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số thỉnh giảng môn chuyên ngành").GiaTri.Replace(".", ",");
                                    klQuyDoi.HeSoThinhGiangMonChuyenNganh = decimal.Parse(s);
                                }
                            }
                        }

                        if (_maNhomMonHoc == 11)//Nhóm thực hành tin học
                        {
                            klQuyDoi.HeSoChucDanhChuyenMon = 0;
                            klQuyDoi.HeSoCoSo = 0;
                            klQuyDoi.HeSoLopDong = 0;
                            klQuyDoi.HeSoClcCntn = 0;
                            klQuyDoi.HeSoThinhGiangMonChuyenNganh = 0;
                            klQuyDoi.TietQuyDoi = (decimal?)(((double)klQuyDoi.SoTiet) * (double)0.5 * Math.Round(((double)klQuyDoi.SoLuong / 50) + 0.5, 2, MidpointRounding.AwayFromZero));
                        }
                        else
                            klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * (klQuyDoi.HeSoChucDanhChuyenMon + klQuyDoi.HeSoCoSo + klQuyDoi.HeSoLopDong + klQuyDoi.HeSoClcCntn + klQuyDoi.HeSoThinhGiangMonChuyenNganh);
                        DataServices.KhoiLuongQuyDoi.Insert(klQuyDoi);
                    }
                }

                DataServices.KhoiLuongQuyDoi.TinhLaiGioTroGiangClc(NamHoc, HocKy);//Tính lại số tiết quy đổi cho trợ giảng lớp CLC
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QuyDoiCTIM
        //void QuyDoiCTIM(int index, string _namHoc, string _hocKy)
        //{
        //    try
        //    {
        //        //bool _kiemTraNhomThucTapCuoiKhoa = false;
        //        //string _maLHP = "", _maGV = "";
        //        TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
        //        if (QuyDoiBoSung == false)
        //        {
        //            listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKy(_namHoc, _hocKy);
        //            DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(_namHoc, _hocKy);
        //        }
        //        else
        //        {
        //            listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyBoSung(_namHoc, _hocKy);
        //            DataServices.KhoiLuongQuyDoi.DeleteKhoiLuongBoSungByNamHocHocKy(_namHoc, _hocKy);
        //        }
        //        int process = listKhoiLuong.Count;

        //        num = Thread.CurrentThread.CurrentUICulture.NumberFormat;

        //        foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
        //        {
        //            if (!backgroundWorker.CancellationPending)
        //            {
        //                backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

        //                KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
        //                klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
        //                klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
        //                klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
        //                klQuyDoi._namHoc = klGiangDay._namHoc;
        //                klQuyDoi._hocKy = klGiangDay._hocKy;
        //                klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
        //                klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
        //                klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
        //                klQuyDoi.SoLuong = klGiangDay.SoLuong;
        //                klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
        //                klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
        //                klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
        //                klQuyDoi.MaLop = klGiangDay.MaLop;
        //                klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
        //                klQuyDoi.SoTiet = klGiangDay.SoTiet;
        //                klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
        //                klQuyDoi.NgayDay = klGiangDay.NgayDay;
        //                klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
        //                klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
        //                klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
        //                //klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
        //                klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;

        //                string _maNhomMonHoc = "";
        //                DataServices.PhanNhomMonHoc.GetNhomMonHocByMaMonHocNamHocHocKy(klGiangDay.MaMonHoc, klGiangDay._namHoc, klGiangDay._hocKy, ref _maNhomMonHoc);
        //                klQuyDoi.MaNhomMonHoc = _maNhomMonHoc;

        //                double _hesoChucDanhChuyenMon = 0, _hesoLopDong = 0;
        //                DataServices.HeSoChucDanhChuyenMon.GetByMaGiangVienNgayDayNamHocHocKy(klGiangDay.MaGiangVien, (DateTime)klGiangDay.NgayDay, klQuyDoi._namHoc, klQuyDoi._hocKy, ref _hesoChucDanhChuyenMon);

        //                klQuyDoi.HeSoChucDanhChuyenMon = (decimal)_hesoChucDanhChuyenMon;

        //                DataServices.HeSoLopDong.GetByBacDaoTaoLoaiHocPhanSiSoNhomMonHoc(klGiangDay.MaBacDaoTao, (int)klGiangDay.MaLoaiHocPhan, (int)klGiangDay.SoLuong, klQuyDoi.MaNhomMonHoc, ref _hesoLopDong);
        //                klQuyDoi.HeSoLopDong = (decimal)_hesoLopDong;

        //                decimal _heSoThinhGiang = 0, _heSoThucHanh = 0;
        //                if (klGiangDay.MaLoaiGiangVien != 1)//Nếu không phải là giảng viên cơ hữu
        //                {
        //                    string _heSo = _listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số thỉnh giảng môn chuyên ngành").GiaTri;
        //                    if (num.NumberDecimalSeparator == ".")
        //                    {
        //                        _heSoThinhGiang = decimal.Parse(_heSo);
        //                        klQuyDoi.HeSoThinhGiangMonChuyenNganh = _heSoThinhGiang;
        //                    }
        //                    if (num.NumberDecimalSeparator == ",")
        //                    {
        //                        string s = _heSo.Replace(".", ",");
        //                        _heSoThinhGiang = decimal.Parse(s);
        //                        klQuyDoi.HeSoThinhGiangMonChuyenNganh = _heSoThinhGiang;
        //                    }
        //                    //string _heSo = _listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số thỉnh giảng môn chuyên ngành").GiaTri;
        //                    //_heSoThinhGiang = decimal.Parse(_heSo);
        //                    //klQuyDoi.HeSoThinhGiangMonChuyenNganh = _heSoThinhGiang;
        //                }
        //                else
        //                    _heSoThinhGiang = 1;
        //                if (klGiangDay.MaLoaiHocPhan == 2)
        //                {
        //                    string _heso = _listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết").GiaTri;
        //                    if (num.NumberDecimalSeparator == ".")
        //                    {
        //                        _heSoThucHanh = decimal.Parse(_heso);
        //                        klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = _heSoThucHanh;
        //                    }
        //                    if (num.NumberDecimalSeparator == ",")
        //                    {
        //                        string s = _heso.Replace(".", ",");
        //                        _heSoThucHanh = decimal.Parse(s);
        //                        klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = _heSoThucHanh;
        //                    }
        //                    klQuyDoi.HeSoThinhGiangMonChuyenNganh = null;
        //                    _heSoThinhGiang = 1;

        //                    //Nếu là môn GDTC thì vẫn tính hệ số thỉnh giảng
        //                    if (klGiangDay.MaNhomMonHoc == "PC" && klGiangDay.MaLoaiGiangVien != 1)
        //                    {
        //                        string _heSo = _listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số thỉnh giảng môn chuyên ngành").GiaTri;
        //                        if (num.NumberDecimalSeparator == ".")
        //                        {
        //                            _heSoThinhGiang = decimal.Parse(_heSo);
        //                            klQuyDoi.HeSoThinhGiangMonChuyenNganh = _heSoThinhGiang;
        //                        }
        //                        if (num.NumberDecimalSeparator == ",")
        //                        {
        //                            string s = _heSo.Replace(".", ",");
        //                            _heSoThinhGiang = decimal.Parse(s);
        //                            klQuyDoi.HeSoThinhGiangMonChuyenNganh = _heSoThinhGiang;
        //                        }
        //                        klQuyDoi.HeSoChucDanhChuyenMon = 1;
        //                    }

        //                }
        //                else
        //                    _heSoThucHanh = 1;

        //                double _heSoTroCapByKhoa = 1;
        //                DataServices.HeSoTroCapTheoKhoa.GetByMaGiangVien(klGiangDay.MaGiangVien, ref _heSoTroCapByKhoa);
        //                klQuyDoi.HeSoTroCap = (decimal)_heSoTroCapByKhoa;

        //                if (klQuyDoi.MaNhomMonHoc == "TTCK")//Nhóm môn thực tập cuối khoá
        //                {
        //                    klQuyDoi.HeSoChucDanhChuyenMon = 1;
        //                    klQuyDoi.HeSoLopDong = 1;
        //                    klQuyDoi.HeSoThinhGiangMonChuyenNganh = 1;
        //                    klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = 1;
        //                    klQuyDoi.HeSoTroCap = 1;

        //                    string _tietQuyChuanHuongDanTTCK = _listCauHinhChung.Find(p => p.TenCauHinh == "Số tiết chuẩn hướng dẫn thực tập cuối khoá").GiaTri;
        //                    decimal _SoTietQuyChuanHuongDanTTCK = 1;
        //                    if (num.NumberDecimalSeparator == ".")
        //                    {
        //                        _SoTietQuyChuanHuongDanTTCK = decimal.Parse(_tietQuyChuanHuongDanTTCK);
        //                    }
        //                    if (num.NumberDecimalSeparator == ",")
        //                    {
        //                        string s = _tietQuyChuanHuongDanTTCK.Replace(".", ",");
        //                        _SoTietQuyChuanHuongDanTTCK = decimal.Parse(s);
        //                    }


        //                    //Kiểm tra trường hợp nhóm môn thực tập có nhiều dòng trong TKB thì chỉ quy đổi 1 dòng, các dòng còn lại = 0
        //                    //if ((_maLHP != klQuyDoi.MaLopHocPhan || _maGV != klQuyDoi.MaGiangVien) || (_maLHP == "" && _maGV == ""))
        //                    klQuyDoi.TietQuyDoi = klQuyDoi.SoLuong * _SoTietQuyChuanHuongDanTTCK;
        //                    //else 
        //                    //    klQuyDoi.TietQuyDoi = 0;

        //                    //_maLHP = klQuyDoi.MaLopHocPhan;
        //                    //_maGV = klQuyDoi.MaGiangVien;
        //                }

        //                else
        //                {
        //                    klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet *
        //                        (1 + (klQuyDoi.HeSoChucDanhChuyenMon - 1) + (klQuyDoi.HeSoLopDong - 1) + (_heSoThinhGiang - 1))
        //                        * _heSoThucHanh * (decimal)_heSoTroCapByKhoa;
        //                }

        //                DataServices.KhoiLuongQuyDoi.Insert(klQuyDoi);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        backgroundWorker.CancelAsync();
        //        XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        void QuyDoiCTIM(int index, string NamHoc, string HocKy)
        {
            try
            {
                //bool _kiemTraNhomThucTapCuoiKhoa = false;
                //string _maLHP = "", _maGV = "";
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
                if (QuyDoiBoSung == false)
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKy(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(NamHoc, HocKy);
                }
                else
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyBoSung(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteKhoiLuongBoSungByNamHocHocKy(NamHoc, HocKy);
                }
                int process = listKhoiLuong.Count;

                num = Thread.CurrentThread.CurrentUICulture.NumberFormat;

                string xmlData = "";
                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        //klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;

                        DataTable tblHeSo = new DataTable();
                        IDataReader reader = DataServices.GiangVien.GetHeSoQuyDoiTietChuanCtim(klGiangDay.MaGiangVien, klGiangDay.NamHoc, klGiangDay.HocKy
                            , klGiangDay.MaMonHoc, (int)klGiangDay.SoLuong, (int)klGiangDay.TietBatDau, (DateTime)klGiangDay.NgayDay, klGiangDay.MaPhongHoc
                            , klGiangDay.MaLopHocPhan, klGiangDay.MaBacDaoTao, klGiangDay.MaLoaiHocPhan);
                        tblHeSo.Load(reader);


                        klQuyDoi.MaNhomMonHoc = tblHeSo.Rows[0]["NhomMonHoc"].ToString();

                        klQuyDoi.HeSoChucDanhChuyenMon = decimal.Parse(tblHeSo.Rows[0]["HeSoChucDanhChuyenMon"].ToString());

                        klQuyDoi.HeSoLopDong = decimal.Parse(tblHeSo.Rows[0]["HeSoLopDong"].ToString());

                        decimal _heSoThinhGiang = 0, _heSoThucHanh = 0;
                        if (klGiangDay.MaLoaiGiangVien != 1)//Nếu không phải là giảng viên cơ hữu
                        {
                            string _heSo = _listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số thỉnh giảng môn chuyên ngành").GiaTri;
                            if (num.NumberDecimalSeparator == ".")
                            {
                                _heSoThinhGiang = decimal.Parse(_heSo);
                                klQuyDoi.HeSoThinhGiangMonChuyenNganh = _heSoThinhGiang;
                            }
                            if (num.NumberDecimalSeparator == ",")
                            {
                                string s = _heSo.Replace(".", ",");
                                _heSoThinhGiang = decimal.Parse(s);
                                klQuyDoi.HeSoThinhGiangMonChuyenNganh = _heSoThinhGiang;
                            }
                            //string _heSo = _listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số thỉnh giảng môn chuyên ngành").GiaTri;
                            //_heSoThinhGiang = decimal.Parse(_heSo);
                            //klQuyDoi.HeSoThinhGiangMonChuyenNganh = _heSoThinhGiang;
                        }
                        else
                            _heSoThinhGiang = 1;
                        if (klGiangDay.MaLoaiHocPhan == 2)
                        {
                            string _heso = _listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết").GiaTri;
                            if (num.NumberDecimalSeparator == ".")
                            {
                                _heSoThucHanh = decimal.Parse(_heso);
                                klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = _heSoThucHanh;
                            }
                            if (num.NumberDecimalSeparator == ",")
                            {
                                string s = _heso.Replace(".", ",");
                                _heSoThucHanh = decimal.Parse(s);
                                klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = _heSoThucHanh;
                            }
                            klQuyDoi.HeSoThinhGiangMonChuyenNganh = null;
                            _heSoThinhGiang = 1;

                            //Nếu là môn GDTC thì vẫn tính hệ số thỉnh giảng
                            if (klGiangDay.MaNhomMonHoc == "PC" && klGiangDay.MaLoaiGiangVien != 1)
                            {
                                string _heSo = _listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số thỉnh giảng môn chuyên ngành").GiaTri;
                                if (num.NumberDecimalSeparator == ".")
                                {
                                    _heSoThinhGiang = decimal.Parse(_heSo);
                                    klQuyDoi.HeSoThinhGiangMonChuyenNganh = _heSoThinhGiang;
                                }
                                if (num.NumberDecimalSeparator == ",")
                                {
                                    string s = _heSo.Replace(".", ",");
                                    _heSoThinhGiang = decimal.Parse(s);
                                    klQuyDoi.HeSoThinhGiangMonChuyenNganh = _heSoThinhGiang;
                                }
                                klQuyDoi.HeSoChucDanhChuyenMon = 1;
                            }

                        }
                        else
                            _heSoThucHanh = 1;

                        decimal _heSoTroCapByKhoa = decimal.Parse(tblHeSo.Rows[0]["HeSoTroCap"].ToString());
                        klQuyDoi.HeSoTroCap = _heSoTroCapByKhoa;

                        //double _heSoTroCapByKhoa = 1;
                        //DataServices.HeSoTroCapTheoKhoa.GetByMaGiangVien(klGiangDay.MaGiangVien, ref _heSoTroCapByKhoa);
                        //klQuyDoi.HeSoTroCap = (decimal)_heSoTroCapByKhoa;

                        if (klQuyDoi.MaNhomMonHoc == "TTCK")//Nhóm môn thực tập cuối khoá
                        {
                            klQuyDoi.HeSoChucDanhChuyenMon = 1;
                            klQuyDoi.HeSoLopDong = 1;
                            klQuyDoi.HeSoThinhGiangMonChuyenNganh = 1;
                            klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = 1;
                            klQuyDoi.HeSoTroCap = 1;

                            string _tietQuyChuanHuongDanTTCK = _listCauHinhChung.Find(p => p.TenCauHinh == "Số tiết chuẩn hướng dẫn thực tập cuối khoá").GiaTri;
                            decimal _SoTietQuyChuanHuongDanTTCK = 1;
                            if (num.NumberDecimalSeparator == ".")
                            {
                                _SoTietQuyChuanHuongDanTTCK = decimal.Parse(_tietQuyChuanHuongDanTTCK);
                            }
                            if (num.NumberDecimalSeparator == ",")
                            {
                                string s = _tietQuyChuanHuongDanTTCK.Replace(".", ",");
                                _SoTietQuyChuanHuongDanTTCK = decimal.Parse(s);
                            }


                            //Kiểm tra trường hợp nhóm môn thực tập có nhiều dòng trong TKB thì chỉ quy đổi 1 dòng, các dòng còn lại = 0
                            //if ((_maLHP != klQuyDoi.MaLopHocPhan || _maGV != klQuyDoi.MaGiangVien) || (_maLHP == "" && _maGV == ""))
                            klQuyDoi.TietQuyDoi = klQuyDoi.SoLuong * _SoTietQuyChuanHuongDanTTCK;
                            //else 
                            //    klQuyDoi.TietQuyDoi = 0;

                            //_maLHP = klQuyDoi.MaLopHocPhan;
                            //_maGV = klQuyDoi.MaGiangVien;
                        }

                        else
                        {
                            klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet *
                                (1 + (klQuyDoi.HeSoChucDanhChuyenMon - 1) + (klQuyDoi.HeSoLopDong - 1) + (_heSoThinhGiang - 1))
                                * _heSoThucHanh * (decimal)_heSoTroCapByKhoa;
                        }
                        
                        //DataServices.KhoiLuongQuyDoi.Insert(klQuyDoi);
                        xmlData += "<Input _00MKL=\"" + klQuyDoi.MaKhoiLuongGiangDay
                                   + "\" _01MGV=\"" + klQuyDoi.MaGiangVien
                                   + "\" _02MLHP=\"" + klQuyDoi.MaLopHocPhan
                                   + "\" _03NH=\"" + klQuyDoi.NamHoc
                                   + "\" _04HK=\"" + klQuyDoi.HocKy
                                   + "\" _05MMH=\"" + klQuyDoi.MaMonHoc
                                   + "\" _06TMH=\"" + klQuyDoi.TenMonHoc
                                   + "\" _07STC=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTinChi, "decimal")
                                   + "\" _08SL=\"" + klQuyDoi.SoLuong
                                   + "\" _09MLOHP=\"" + klQuyDoi.MaLoaiHocPhan
                                   + "\" _10LOHP=\"" + klQuyDoi.LoaiHocPhan
                                   + "\" _11MBH=\"" + klQuyDoi.MaBuoiHoc
                                   + "\" _12ML=\"" + klQuyDoi.MaLop
                                   + "\" _13TBD=\"" + klQuyDoi.TietBatDau
                                   + "\" _14ST=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTiet, "decimal")
                                   + "\" _15TT=\"" + klQuyDoi.TinhTrang
                                   + "\" _16ND=\"" + ((DateTime)klQuyDoi.NgayDay).ToString("yyyy/MM/dd")
                                   + "\" _17MBDT=\"" + klQuyDoi.MaBacDaoTao
                                   + "\" _18MHK=\"" + klQuyDoi.MaKhoaHoc
                                   + "\" _19MK=\"" + klQuyDoi.MaKhoa
                                   + "\" _20MNMH=\"" + klQuyDoi.MaNhomMonHoc
                                   + "\" _21MPH=\"" + klQuyDoi.MaPhongHoc
                                   + "\" _22HSCD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoChucDanhChuyenMon, "decimal")
                                   + "\" _23HSLD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoLopDong, "decimal")
                                   + "\" _24HSTG=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoThinhGiangMonChuyenNganh, "decimal")
                                   + "\" _25HSTH=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet, "decimal")
                                   + "\" _26HSTC=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoTroCap, "decimal")
                                   + "\" _27TQD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.TietQuyDoi, "decimal")
                                   + "\" />";

                    }

                }
                xmlData = "<Root>" + xmlData + "</Root>";

                int kq = 0;
                DataServices.KhoiLuongQuyDoi.LuuQuyDoiCtim(xmlData, NamHoc, HocKy, ref kq);
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QuyDoiIUH
        void QuyDoiIUH(int index, string NamHoc, string HocKy)
        {
            try
            {

                decimal _heSoQuyDoiThucHanhLyThuyet = ConvertDecimal(_listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết").GiaTri);

                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
                if (QuyDoiBoSung == false)
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKy(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(NamHoc, HocKy);
                }
                else
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyBoSung(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteKhoiLuongBoSungByNamHocHocKy(NamHoc, HocKy);
                }
                int process = listKhoiLuong.Count;

                num = Thread.CurrentThread.CurrentUICulture.NumberFormat;

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;

                        int _maNhomMonHoc = 0;
                        TList<PhanNhomMonHoc> _listNhomMonHoc = DataServices.PhanNhomMonHoc.GetByNamHocHocKyMaMonHoc(klQuyDoi.NamHoc, klQuyDoi.HocKy, klGiangDay.MaMonHoc);
                        if (_listNhomMonHoc.Count > 0)
                            _maNhomMonHoc = _listNhomMonHoc[0].MaNhomMonHoc;
                        else _maNhomMonHoc = 6;//Nếu ko có trong bảng phân nhóm môn học thì coi như là môn bình thường
                        klQuyDoi.MaNhomMonHoc = _maNhomMonHoc.ToString();
                        if(DataServices.LopHocPhanGiangBangTiengNuocNgoai.GetByMaLopHocPhan(klGiangDay.MaLopHocPhan) != null)
                            klQuyDoi.NgonNguGiangDay = "TIENGANH";
                        else
                            klQuyDoi.NgonNguGiangDay = "TIENGVIET";
                     
                        double _heSoLopDong = 0, _hesoChucDanhChuyenMon = 0, _heSoDiaDiemVaNgoaiGio = 0, _heSoNgonNgu = 0;

                        DataServices.HeSoNgonNgu.GetByMaNgonNguNamHocHocKy(klQuyDoi.NgonNguGiangDay, klQuyDoi.NamHoc, klQuyDoi.HocKy, ref _heSoNgonNgu);
                        klQuyDoi.HeSoNgonNgu = (decimal?)_heSoNgonNgu;

                        DataServices.HeSoLopDong.GetByNamHocHocKyBacDaoTaoNhomMonHocLoaiKhoiLuongSiSo(klQuyDoi.NamHoc, klQuyDoi.HocKy, klQuyDoi.MaBacDaoTao, klQuyDoi.MaNhomMonHoc, (int)klQuyDoi.MaLoaiHocPhan, (int)klQuyDoi.SoLuong, ref _heSoLopDong);

                        klQuyDoi.HeSoLopDong = (decimal)_heSoLopDong;
                        if (klQuyDoi.MaLoaiHocPhan == 2)
                            klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = _heSoQuyDoiThucHanhLyThuyet;
                        else
                            klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = 1;


                        klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet * klQuyDoi.HeSoLopDong * klQuyDoi.HeSoNgonNgu;
                        DataServices.KhoiLuongQuyDoi.Insert(klQuyDoi);
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void QuyDoiIUHTheoTungLHP(int index, string _xmlData, string NamHoc, string HocKy)
        {
            try
            {

                decimal _heSoQuyDoiThucHanhLyThuyet = ConvertDecimal(_listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết").GiaTri);
                decimal _heSoQuyDoiNhomMonGDTC = ConvertDecimal(_listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi nhóm môn GDTC").GiaTri);

                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();

                listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByXmlData(_xmlData, NamHoc, HocKy);
                DataServices.KhoiLuongQuyDoi.DeleteByXmlData(_xmlData);
                
                int process = listKhoiLuong.Count;

                num = Thread.CurrentThread.CurrentUICulture.NumberFormat;

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;

                        int _maNhomMonHoc = 0;
                        TList<PhanNhomMonHoc> _listNhomMonHoc = DataServices.PhanNhomMonHoc.GetByNamHocHocKyMaMonHoc(klQuyDoi.NamHoc, klQuyDoi.HocKy, klGiangDay.MaMonHoc);
                        if (_listNhomMonHoc.Count > 0)
                            _maNhomMonHoc = _listNhomMonHoc[0].MaNhomMonHoc;
                        else _maNhomMonHoc = 6;//Nếu ko có trong bảng phân nhóm môn học thì coi như là môn bình thường
                        klQuyDoi.MaNhomMonHoc = _maNhomMonHoc.ToString();
                        if (DataServices.LopHocPhanGiangBangTiengNuocNgoai.GetByMaLopHocPhan(klGiangDay.MaLopHocPhan) != null)
                            klQuyDoi.NgonNguGiangDay = "TIENGANH";
                        else
                            klQuyDoi.NgonNguGiangDay = "TIENGVIET";

                        double _heSoLopDong = 0, _heSoNgonNgu = 0;

                        DataServices.HeSoNgonNgu.GetByMaNgonNguNamHocHocKy(klQuyDoi.NgonNguGiangDay, klQuyDoi.NamHoc, klQuyDoi.HocKy, ref _heSoNgonNgu);
                        klQuyDoi.HeSoNgonNgu = (decimal?)_heSoNgonNgu;

                        DataServices.HeSoLopDong.GetByNamHocHocKyBacDaoTaoNhomMonHocLoaiKhoiLuongSiSo(klQuyDoi.NamHoc, klQuyDoi.HocKy, klQuyDoi.MaBacDaoTao, klQuyDoi.MaNhomMonHoc, (int)klQuyDoi.MaLoaiHocPhan, (int)klQuyDoi.SoLuong, ref _heSoLopDong);

                        klQuyDoi.HeSoLopDong = (decimal)_heSoLopDong;
                        if (klQuyDoi.MaLoaiHocPhan == 2)
                        {
                            if (_maNhomMonHoc == 7)//Nhóm môn GDTC
                                klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = _heSoQuyDoiNhomMonGDTC;
                            else
                                klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = _heSoQuyDoiThucHanhLyThuyet;
                        }
                        else
                            klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = 1;


                        klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet * klQuyDoi.HeSoLopDong * klQuyDoi.HeSoNgonNgu;
                        DataServices.KhoiLuongQuyDoi.Insert(klQuyDoi);
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QuyDoiLAW
        void QuyDoiLAW(int index, string NamHoc, string HocKy)
        {
            try
            {
                string xmlData = "";
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
                if (QuyDoiBoSung == false)
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKy(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(NamHoc, HocKy);
                }
                else
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyBoSung(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteKhoiLuongBoSungByNamHocHocKy(NamHoc, HocKy);
                }
                int process = listKhoiLuong.Count;

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;

                        DataTable _heSoQuyDoi = new DataTable();
                        IDataReader reader = DataServices.GiangVien.GetHeSoQuyDoiTietChuanLaw(klGiangDay.MaGiangVien, NamHoc, HocKy, klGiangDay.MaMonHoc, (int)klGiangDay.SoLuong, (int)klGiangDay.TietBatDau, (DateTime)klGiangDay.NgayDay, klGiangDay.MaPhongHoc, klGiangDay.MaLopHocPhan, klGiangDay.MaLoaiHocPhan.ToString(), klGiangDay.MaBacDaoTao, klGiangDay.MaKhoa, (int)klGiangDay.MaHocHam, (int)klGiangDay.MaHocVi, (bool)klGiangDay.DaoTaoTinChi);
                        _heSoQuyDoi.Load(reader);

                        DataRow _rowHeSo = _heSoQuyDoi.Rows[0];

                        klQuyDoi.HeSoCongViec = decimal.Parse(_rowHeSo["HeSoCongViec"].ToString());
                        klQuyDoi.HeSoBacDaoTao = decimal.Parse(_rowHeSo["HeSoBacDaoTao"].ToString());
                        klQuyDoi.HeSoNgonNgu = decimal.Parse(_rowHeSo["HeSoNgonNgu"].ToString());
                        klQuyDoi.HeSoChucDanhChuyenMon = decimal.Parse(_rowHeSo["HeSoChucDanhChuyenMon"].ToString());
                        klQuyDoi.HeSoLopDong = decimal.Parse(_rowHeSo["HeSoLopDong"].ToString());
                        klQuyDoi.HeSoCoSo = decimal.Parse(_rowHeSo["HeSoCoSo"].ToString());
                        klQuyDoi.HeSoNienCheTinChi = decimal.Parse(_rowHeSo["HeSoNienCheTinChi"].ToString());
                        klQuyDoi.MaNhomMonHoc = _rowHeSo["MaNhomMonHoc"].ToString();
                        klQuyDoi.NgonNguGiangDay = _rowHeSo["NgonNguGiangDay"].ToString();
                        klQuyDoi.LoaiLop = _rowHeSo["LoaiLop"].ToString();
                        klQuyDoi.MucThanhToan = decimal.Parse(_rowHeSo["MucThanhToan"].ToString());
                        klQuyDoi.HeSoTroCap = decimal.Parse(_rowHeSo["HeSoCaoHocTinhThem"].ToString());//Gắn hệ số cao học tính thêm vào cột HeSoTroCap

                        //Số tiết thực tế quy đổi: (đào tạo theo niên chế = 1, đào tạo theo tín chỉ = 50/45, sau đại học = 1) nhân với số tiết thực tế.
                        //if (klGiangDay.DaoTaoTinChi == true)
                        //    klQuyDoi.SoTietThucTeQuyDoi = klQuyDoi.SoTiet * (decimal)1.1111;
                        //else 
                        //    klQuyDoi.SoTietThucTeQuyDoi = klQuyDoi.SoTiet;
                        klQuyDoi.SoTietThucTeQuyDoi = klQuyDoi.SoTiet * klQuyDoi.HeSoNienCheTinChi * klQuyDoi.HeSoTroCap;

                        klQuyDoi.TietQuyDoi = klQuyDoi.SoTietThucTeQuyDoi * klQuyDoi.HeSoCongViec *
                            (1 + (klQuyDoi.HeSoBacDaoTao - 1) + (klQuyDoi.HeSoNgonNgu - 1) + (klQuyDoi.HeSoChucDanhChuyenMon - 1) + (klQuyDoi.HeSoLopDong - 1) + (klQuyDoi.HeSoCoSo - 1))
                                 * (klQuyDoi.MucThanhToan / 100);

                        xmlData += "<Input _01MKL=\"" + klQuyDoi.MaKhoiLuongGiangDay
                                + "\" _02MGV=\"" + klQuyDoi.MaGiangVien
                                + "\" _03MLHP=\"" + klQuyDoi.MaLopHocPhan
                                + "\" _04NH=\"" + klQuyDoi.NamHoc
                                + "\" _05HK=\"" + klQuyDoi.HocKy
                                + "\" _06MMH=\"" + klQuyDoi.MaMonHoc
                                + "\" _07TMH=\"" + System.Security.SecurityElement.Escape(klQuyDoi.TenMonHoc)
                                + "\" _08STC=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTinChi, "decimal")
                                + "\" _09SL=\"" + klQuyDoi.SoLuong
                                + "\" _10MLHP=\"" + klQuyDoi.MaLoaiHocPhan
                                + "\" _11LHP=\"" + klQuyDoi.LoaiHocPhan
                                + "\" _12MBH=\"" + klQuyDoi.MaBuoiHoc
                                + "\" _13ML=\"" + System.Security.SecurityElement.Escape(klQuyDoi.MaLop)
                                + "\" _14TBD=\"" + klQuyDoi.TietBatDau
                                + "\" _15ST=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTiet, "decimal")
                                + "\" _16TT=\"" + klQuyDoi.TinhTrang
                                + "\" _17ND=\"" + ((DateTime)klQuyDoi.NgayDay).ToString("yyyy/MM/dd")
                                + "\" _18MBDT=\"" + klQuyDoi.MaBacDaoTao
                                + "\" _19MKH=\"" + klQuyDoi.MaKhoaHoc
                                + "\" _20MK=\"" + klQuyDoi.MaKhoa
                                + "\" _21MNMH=\"" + klQuyDoi.MaNhomMonHoc
                                + "\" _22MPH=\"" + klQuyDoi.MaPhongHoc
                                + "\" _23HSCV=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCongViec, "decimal")
                                + "\" _24HSBDT=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoBacDaoTao, "decimal")
                                + "\" _25HSNN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNgonNgu, "decimal")
                                + "\" _26HSCDCM=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoChucDanhChuyenMon, "decimal")
                                + "\" _27HSLD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoLopDong, "decimal")
                                + "\" _28HSCS=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCoSo, "decimal")
                                + "\" _29STTTQD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTietThucTeQuyDoi, "decimal")
                                + "\" _30TQD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.TietQuyDoi, "decimal")
                                + "\" _31HSQDTHSLT=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet
                                + "\" _32HSNG=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoNgoaiGio
                                + "\" _33LL=\"" + klQuyDoi.LoaiLop
                                + "\" _34HSCLCCNTN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoClcCntn
                                + "\" _35HSTGMCN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoThinhGiangMonChuyenNganh
                                + "\" _36NNGD=\"" + klQuyDoi.NgonNguGiangDay
                                + "\" _37HSTCGD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoTroCapGiangDay
                                + "\" _38HSTC=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoTroCap, "decimal")//klQuyDoi.HeSoTroCap
                                + "\" _39HSL=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoLuong
                                + "\" _40HSMM=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoMonMoi
                                + "\" _41HSNCTC=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNienCheTinChi, "decimal")
                                + "\" _42GC=\"" + string.Empty//klQuyDoi.GhiChu
                                + "\" _43MTT=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.MucThanhToan, "decimal") 
                                + "\" />";
                    }
                }

                xmlData = "<Root>" + xmlData + "</Root>";
                int kq = 0;
                DataServices.KhoiLuongQuyDoi.LuuQuyDoiAll(xmlData, NamHoc, HocKy, ref kq);
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QuyDoiTamUngLAW
        void QuyDoiTamUngLAW(int index, string NamHoc, string HocKy)
        {
            try
            {
                string xmlData = "";
                TList<KhoiLuongTamUng> listKhoiLuong = new TList<KhoiLuongTamUng>();

                listKhoiLuong = DataServices.KhoiLuongTamUng.GetListByNamHocHocKy(NamHoc, HocKy);
                
                int process = listKhoiLuong.Count;

                foreach (KhoiLuongTamUng klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaQuanLyGv, klGiangDay.TenMonHoc));

                        QuyDoiKhoiLuongTamUng klQuyDoi = new QuyDoiKhoiLuongTamUng();
                        klQuyDoi.MaKhoiLuongTamUng = klGiangDay.MaKhoiLuong;
                        
                        DataTable _heSoQuyDoi = new DataTable();
                        IDataReader reader = DataServices.GiangVien.GetHeSoQuyDoiTietChuanLaw(klGiangDay.MaQuanLyGv, NamHoc, HocKy, klGiangDay.MaMonHoc, (int)klGiangDay.SoLuong, (int)klGiangDay.TietBatDau, (DateTime)klGiangDay.NgayDay, klGiangDay.MaPhongHoc, klGiangDay.MaLopHocPhan, klGiangDay.MaLoaiHocPhan.ToString(), klGiangDay.MaBacDaoTao, klGiangDay.MaKhoa, (int)klGiangDay.MaHocHam, (int)klGiangDay.MaHocVi, (bool)klGiangDay.DaoTaoTinChi);
                        _heSoQuyDoi.Load(reader);

                        DataRow _rowHeSo = _heSoQuyDoi.Rows[0];

                        klQuyDoi.HeSoCongViec = decimal.Parse(_rowHeSo["HeSoCongViec"].ToString());
                        klQuyDoi.HeSoBacDaoTao = decimal.Parse(_rowHeSo["HeSoBacDaoTao"].ToString());
                        klQuyDoi.HeSoNgonNgu = decimal.Parse(_rowHeSo["HeSoNgonNgu"].ToString());
                        klQuyDoi.HeSoChucDanhChuyenMon = decimal.Parse(_rowHeSo["HeSoChucDanhChuyenMon"].ToString());
                        klQuyDoi.HeSoLopDong = decimal.Parse(_rowHeSo["HeSoLopDong"].ToString());
                        klQuyDoi.HeSoCoSo = decimal.Parse(_rowHeSo["HeSoCoSo"].ToString());
                        klQuyDoi.HeSoNienCheTinChi = decimal.Parse(_rowHeSo["HeSoNienCheTinChi"].ToString());
                        klQuyDoi.MucThanhToan = decimal.Parse(_rowHeSo["MucThanhToan"].ToString());
                        klQuyDoi.HeSoTroCap = decimal.Parse(_rowHeSo["HeSoCaoHocTinhThem"].ToString());//Gắn hệ số cao học tính thêm vào cột HeSoTroCap
                        
                        klQuyDoi.SoTietThucTeQuyDoi = klGiangDay.SoTiet * klQuyDoi.HeSoNienCheTinChi;

                        klQuyDoi.TietQuyDoi = klQuyDoi.SoTietThucTeQuyDoi * klQuyDoi.HeSoCongViec *
                            (1 + (klQuyDoi.HeSoBacDaoTao - 1) + (klQuyDoi.HeSoNgonNgu - 1) + (klQuyDoi.HeSoChucDanhChuyenMon - 1) + (klQuyDoi.HeSoLopDong - 1) + (klQuyDoi.HeSoCoSo - 1))
                                * (klQuyDoi.MucThanhToan / 100);

                        xmlData += "<Input _01MKLTU=\"" + klQuyDoi.MaKhoiLuongTamUng
                                + "\" _02HSCV=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCongViec, "decimal")
                                + "\" _03HSBDT=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoBacDaoTao, "decimal")
                                + "\" _04HSNN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNgonNgu, "decimal")
                                + "\" _05HSCDCM=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoChucDanhChuyenMon, "decimal")
                                + "\" _06HSLD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoLopDong, "decimal")
                                + "\" _07HSCS=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCoSo, "decimal")
                                + "\" _08STTTQD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTietThucTeQuyDoi, "decimal")
                                + "\" _09TQD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.TietQuyDoi, "decimal")
                                + "\" _10HSQDTHSLT=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet
                                + "\" _11HSNG=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoNgoaiGio
                                + "\" _12LL=\"" + klQuyDoi.LoaiLop
                                + "\" _13HSCLCCNTN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoClcCntn
                                + "\" _14HSTGMCN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoThinhGiangMonChuyenNganh
                                + "\" _15HSTC=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoTroCap, "decimal")//klQuyDoi.HeSoTroCap
                                + "\" _16HSL=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoLuong
                                + "\" _17HSMM=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoMonMoi
                                + "\" _18HSNCTC=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNienCheTinChi, "decimal")
                                + "\" _19GC=\"" + string.Empty//klQuyDoi.GhiChu
                                + "\" _20Chot=\"" + 0
                                + "\" _21MTT=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.MucThanhToan, "decimal")
                                + "\" />";
                    }
                }

                xmlData = "<Root>" + xmlData + "</Root>";
                int kq = 0;
                DataServices.QuyDoiKhoiLuongTamUng.Luu(xmlData, NamHoc, HocKy, ref kq);
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QuyDoiLAWTheoTungLHP
        void QuyDoiLAWTheoTungLHP(int index, string _xmlData, string NamHoc, string HocKy)
        {
            try
            {
                string xmlData = "";
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();

                listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByXmlData(_xmlData, NamHoc, HocKy);    //Chỗ này xử lý quá nặng!

                int process = listKhoiLuong.Count;

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;

                        DataTable _heSoQuyDoi = new DataTable();
                        IDataReader reader = DataServices.GiangVien.GetHeSoQuyDoiTietChuanLaw(klGiangDay.MaGiangVien, NamHoc, HocKy, klGiangDay.MaMonHoc, (int)klGiangDay.SoLuong, (int)klGiangDay.TietBatDau, (DateTime)klGiangDay.NgayDay, klGiangDay.MaPhongHoc, klGiangDay.MaLopHocPhan, klGiangDay.MaLoaiHocPhan.ToString(), klGiangDay.MaBacDaoTao, klGiangDay.MaKhoa, (int)klGiangDay.MaHocHam, (int)klGiangDay.MaHocVi, (bool)klGiangDay.DaoTaoTinChi);
                        _heSoQuyDoi.Load(reader);

                        DataRow _rowHeSo = _heSoQuyDoi.Rows[0];

                        klQuyDoi.HeSoCongViec = decimal.Parse(_rowHeSo["HeSoCongViec"].ToString());
                        klQuyDoi.HeSoBacDaoTao = decimal.Parse(_rowHeSo["HeSoBacDaoTao"].ToString());
                        klQuyDoi.HeSoNgonNgu = decimal.Parse(_rowHeSo["HeSoNgonNgu"].ToString());
                        klQuyDoi.HeSoChucDanhChuyenMon = decimal.Parse(_rowHeSo["HeSoChucDanhChuyenMon"].ToString());
                        klQuyDoi.HeSoLopDong = decimal.Parse(_rowHeSo["HeSoLopDong"].ToString());
                        klQuyDoi.HeSoCoSo = decimal.Parse(_rowHeSo["HeSoCoSo"].ToString());
                        klQuyDoi.HeSoNienCheTinChi = decimal.Parse(_rowHeSo["HeSoNienCheTinChi"].ToString());
                        klQuyDoi.MaNhomMonHoc = _rowHeSo["MaNhomMonHoc"].ToString();
                        klQuyDoi.NgonNguGiangDay = _rowHeSo["NgonNguGiangDay"].ToString();
                        klQuyDoi.LoaiLop = _rowHeSo["LoaiLop"].ToString();
                        klQuyDoi.MucThanhToan = decimal.Parse(_rowHeSo["MucThanhToan"].ToString());
                        klQuyDoi.HeSoTroCap = decimal.Parse(_rowHeSo["HeSoCaoHocTinhThem"].ToString());//Gắn hệ số cao học tính thêm vào cột HeSoTroCap

                        //Số tiết thực tế quy đổi: (đào tạo theo niên chế = 1, đào tạo theo tín chỉ = 50/45, sau đại học = 1) nhân với số tiết thực tế.
                        //if (klGiangDay.DaoTaoTinChi == true)
                        //    klQuyDoi.SoTietThucTeQuyDoi = klQuyDoi.SoTiet * (decimal)1.1111;
                        //else 
                        //    klQuyDoi.SoTietThucTeQuyDoi = klQuyDoi.SoTiet;
                        klQuyDoi.SoTietThucTeQuyDoi = klQuyDoi.SoTiet * klQuyDoi.HeSoNienCheTinChi * klQuyDoi.HeSoTroCap;

                        klQuyDoi.TietQuyDoi = klQuyDoi.SoTietThucTeQuyDoi * klQuyDoi.HeSoCongViec *
                            (1 + (klQuyDoi.HeSoBacDaoTao - 1) + (klQuyDoi.HeSoNgonNgu - 1) + (klQuyDoi.HeSoChucDanhChuyenMon - 1) + (klQuyDoi.HeSoLopDong - 1) + (klQuyDoi.HeSoCoSo - 1))
                                 * (klQuyDoi.MucThanhToan / 100);

                        xmlData += "<Input _01MKL=\"" + klQuyDoi.MaKhoiLuongGiangDay
                                + "\" _02MGV=\"" + klQuyDoi.MaGiangVien
                                + "\" _03MLHP=\"" + klQuyDoi.MaLopHocPhan
                                + "\" _04NH=\"" + klQuyDoi.NamHoc
                                + "\" _05HK=\"" + klQuyDoi.HocKy
                                + "\" _06MMH=\"" + klQuyDoi.MaMonHoc
                                + "\" _07TMH=\"" + System.Security.SecurityElement.Escape(klQuyDoi.TenMonHoc)
                                + "\" _08STC=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTinChi, "decimal")
                                + "\" _09SL=\"" + klQuyDoi.SoLuong
                                + "\" _10MLHP=\"" + klQuyDoi.MaLoaiHocPhan
                                + "\" _11LHP=\"" + klQuyDoi.LoaiHocPhan
                                + "\" _12MBH=\"" + klQuyDoi.MaBuoiHoc
                                + "\" _13ML=\"" + System.Security.SecurityElement.Escape(klQuyDoi.MaLop)
                                + "\" _14TBD=\"" + klQuyDoi.TietBatDau
                                + "\" _15ST=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTiet, "decimal")
                                + "\" _16TT=\"" + klQuyDoi.TinhTrang
                                + "\" _17ND=\"" + ((DateTime)klQuyDoi.NgayDay).ToString("yyyy/MM/dd")
                                + "\" _18MBDT=\"" + klQuyDoi.MaBacDaoTao
                                + "\" _19MKH=\"" + klQuyDoi.MaKhoaHoc
                                + "\" _20MK=\"" + klQuyDoi.MaKhoa
                                + "\" _21MNMH=\"" + klQuyDoi.MaNhomMonHoc
                                + "\" _22MPH=\"" + klQuyDoi.MaPhongHoc
                                + "\" _23HSCV=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCongViec, "decimal")
                                + "\" _24HSBDT=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoBacDaoTao, "decimal")
                                + "\" _25HSNN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNgonNgu, "decimal")
                                + "\" _26HSCDCM=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoChucDanhChuyenMon, "decimal")
                                + "\" _27HSLD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoLopDong, "decimal")
                                + "\" _28HSCS=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCoSo, "decimal")
                                + "\" _29STTTQD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTietThucTeQuyDoi, "decimal")
                                + "\" _30TQD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.TietQuyDoi, "decimal")
                                + "\" _31HSQDTHSLT=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet
                                + "\" _32HSNG=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoNgoaiGio
                                + "\" _33LL=\"" + klQuyDoi.LoaiLop
                                + "\" _34HSCLCCNTN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoClcCntn
                                + "\" _35HSTGMCN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoThinhGiangMonChuyenNganh
                                + "\" _36NNGD=\"" + klQuyDoi.NgonNguGiangDay
                                + "\" _37HSTCGD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoTroCapGiangDay
                                + "\" _38HSTC=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoTroCap, "decimal")//klQuyDoi.HeSoTroCap
                                + "\" _39HSL=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoLuong
                                + "\" _40HSMM=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoMonMoi
                                + "\" _41HSNCTC=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNienCheTinChi, "decimal")
                                + "\" _42GC=\"" + string.Empty//klQuyDoi.GhiChu
                                + "\" _43MTT=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.MucThanhToan, "decimal")
                                + "\" />";
                    }
                }

                xmlData = "<Root>" + xmlData + "</Root>";
                int kq = 0;
                DataServices.KhoiLuongQuyDoi.LuuQuyDoiAll(xmlData, NamHoc, HocKy, ref kq);
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QuyDoiBUH
        //void QuyDoiBUH(int index, string _namHoc, string _hocKy)
        //{
        //    try
        //    {
        //        TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
        //        if (QuyDoiBoSung == false)
        //        {
        //            listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKy(_namHoc, _hocKy);
        //            DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(_namHoc, _hocKy);
        //        }
        //        else
        //        {
        //            listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyBoSung(_namHoc, _hocKy);
        //            DataServices.KhoiLuongQuyDoi.DeleteKhoiLuongBoSungByNamHocHocKy(_namHoc, _hocKy);
        //        }
        //        int process = listKhoiLuong.Count;

        //        foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
        //        {
        //            if (!backgroundWorker.CancellationPending)
        //            {
        //                backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

        //                KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
        //                klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
        //                klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
        //                klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
        //                klQuyDoi._namHoc = klGiangDay._namHoc;
        //                klQuyDoi._hocKy = klGiangDay._hocKy;
        //                klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
        //                klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
        //                klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
        //                klQuyDoi.SoLuong = klGiangDay.SoLuong;
        //                klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
        //                klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
        //                klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
        //                klQuyDoi.MaLop = klGiangDay.MaLop;
        //                klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
        //                klQuyDoi.SoTiet = klGiangDay.SoTiet;
        //                klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
        //                klQuyDoi.NgayDay = klGiangDay.NgayDay;
        //                klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
        //                klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
        //                klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
        //                klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
        //                klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;

        //                double _heSoLuong = 0, _hesoChucDanhChuyenMon = 0, _heSoNgoaiGio = 0, _heSoMonGiangMoi = 0;
        //                DataServices.HeSoLuong.GetByNamHocHocKyMaGiangVienQuanLy(klQuyDoi.MaGiangVien, _namHoc, _hocKy, ref _heSoLuong);
        //                klQuyDoi.HeSoLuong = (decimal?)_heSoLuong;


        //                //TList<NhomMonHoc> _listNhomMonHoc=DataServices.NhomMonHoc.GetAll();
        //                //TList<PhanNhomMonHoc> _listPhanNhomMonHoc = DataServices.PhanNhomMonHoc.GetByNamHocHocKy(klQuyDoi._namHoc,"");


        //                double _heSoLopDongGDTC = -1;
        //                DataServices.HeSoNhomThucHanh.GetByMaMonHocSiSoNamHoc(klGiangDay.MaMonHoc, (int)klGiangDay.SoLuong, _namHoc, ref _heSoLopDongGDTC);

        //                klQuyDoi.HeSoLopDong = (DataServices.HeSoLopDong.GetBySiSo((int)klQuyDoi.SoLuong) as TList<HeSoLopDong>)[0].HeSo;

        //                DataServices.HeSoThoiGianGiangDay.GetByTietBatDauNgayDayHocKy((int)klGiangDay.TietBatDau, (DateTime)klGiangDay.NgayDay, _hocKy, ref _heSoNgoaiGio);
        //                klQuyDoi.HeSoNgoaiGio = (decimal?)_heSoNgoaiGio;

        //                DataServices.HeSoChucDanhChuyenMon.GetByMaGiangVienNgayDayNamHocHocKy(klGiangDay.MaGiangVien, (DateTime)klGiangDay.NgayDay, _namHoc, _hocKy, ref _hesoChucDanhChuyenMon);
        //                klQuyDoi.HeSoChucDanhChuyenMon = (decimal)_hesoChucDanhChuyenMon;

        //                klQuyDoi.HeSoCoSo = (DataServices.HeSoCoSo.GetByMaPhongHocNgayDay(klQuyDoi.MaPhongHoc, DateTime.Parse(klQuyDoi.NgayDay.ToString())) as TList<HeSoCoSo>)[0].HeSo;//lấy theo mả phòng học

        //                DataServices.MonGiangMoi.GetByMaLopHocPhan(klGiangDay.MaLopHocPhan, ref _heSoMonGiangMoi);
        //                klQuyDoi.HeSoMonMoi = (decimal?)_heSoMonGiangMoi;

        //                LopHocPhanGiangBangTiengNuocNgoai dataServicesLopHocPhanGiangBangTiengNuocNgoaiGetByMaLopHocPhan = DataServices.LopHocPhanGiangBangTiengNuocNgoai.GetByMaLopHocPhan(klGiangDay.MaLopHocPhan);
        //                if (dataServicesLopHocPhanGiangBangTiengNuocNgoaiGetByMaLopHocPhan != null)
        //                {
        //                    klQuyDoi.NgonNguGiangDay = "TIENGANH";
        //                }
        //                else
        //                {
        //                    klQuyDoi.NgonNguGiangDay = "TIENGVIET";
        //                }

        //                if (klQuyDoi.MaLopHocPhan.Contains("CLC") || klQuyDoi.MaLopHocPhan.Contains("GE"))
        //                {
        //                    klQuyDoi.LoaiLop = "CLC";
        //                }

        //                if (klQuyDoi.NgonNguGiangDay == "TIENGANH")//Mon chuyen nganh giang bang tieng anh
        //                {
        //                    klQuyDoi.TietQuyDoi = (klQuyDoi.SoTiet * (klQuyDoi.HeSoLopDong + klQuyDoi.HeSoLuong + klQuyDoi.HeSoChucDanhChuyenMon + klQuyDoi.HeSoNgoaiGio + klQuyDoi.HeSoCoSo + klQuyDoi.HeSoMonMoi + 1)) + klQuyDoi.SoTiet;
        //                }
        //                else
        //                {
        //                    if (klQuyDoi.MaLopHocPhan.Contains("CLC") || klQuyDoi.MaLopHocPhan.Contains("GE") || klQuyDoi.LoaiLop == "CLC")//Lop CLC
        //                    {
        //                        klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet;
        //                    }
        //                    else
        //                        klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * (klQuyDoi.HeSoLopDong + klQuyDoi.HeSoLuong + klQuyDoi.HeSoChucDanhChuyenMon + klQuyDoi.HeSoNgoaiGio + klQuyDoi.HeSoCoSo + klQuyDoi.HeSoMonMoi + 1);
        //                }

        //                if (_heSoLopDongGDTC != -1)//Lop GDTC
        //                {
        //                    klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * (decimal?)_heSoLopDongGDTC * (klQuyDoi.HeSoLopDong + klQuyDoi.HeSoLuong + klQuyDoi.HeSoChucDanhChuyenMon + klQuyDoi.HeSoNgoaiGio + klQuyDoi.HeSoCoSo + klQuyDoi.HeSoMonMoi + 1);
        //                }

        //                DataServices.KhoiLuongQuyDoi.Insert(klQuyDoi);

        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        backgroundWorker.CancelAsync();
        //        XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        void QuyDoiBUH(int index, string NamHoc, string HocKy)
        {
            try
            {
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
                if (QuyDoiBoSung == false)
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKy(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(NamHoc, HocKy);
                }
                else
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyBoSung(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteKhoiLuongBoSungByNamHocHocKy(NamHoc, HocKy);
                }
                int process = listKhoiLuong.Count;

                string xmlData = "";

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;

                        double _heSoLuong = 0, _hesoChucDanhChuyenMon = 0, _heSoNgoaiGio = 0, _heSoMonGiangMoi = 0;

                        DataTable tbHeSoQuyDoiTietChuan = new DataTable();
                        IDataReader reader = DataServices.GiangVien.GetHeSoQuyDoiTietChuan(klQuyDoi.MaGiangVien, NamHoc, HocKy, klQuyDoi.MaMonHoc, (int)klQuyDoi.SoLuong, (int)klQuyDoi.TietBatDau, (DateTime)klQuyDoi.NgayDay, klQuyDoi.MaPhongHoc, klQuyDoi.MaLopHocPhan);
                        tbHeSoQuyDoiTietChuan.Load(reader);

                        DataRow rowHeSo = tbHeSoQuyDoiTietChuan.Rows[0];

                        klQuyDoi.HeSoLuong = decimal.Parse(rowHeSo["HeSoLuong"].ToString());

                        //double _heSoLopDongGDTC chính là HeSoCongViec
                        klQuyDoi.HeSoCongViec = decimal.Parse(rowHeSo["HeSoLopDongGdtc"].ToString());

                        klQuyDoi.HeSoLopDong = decimal.Parse(rowHeSo["HeSoLopDong"].ToString());

                        klQuyDoi.HeSoNgoaiGio = decimal.Parse(rowHeSo["HeSoNgoaiGio"].ToString());

                        klQuyDoi.HeSoChucDanhChuyenMon = decimal.Parse(rowHeSo["HeSoChucDanhChuyenMon"].ToString());

                        klQuyDoi.HeSoCoSo = decimal.Parse(rowHeSo["HeSoCoSo"].ToString());

                        klQuyDoi.HeSoMonMoi = decimal.Parse(rowHeSo["HeSoMonGiangMoi"].ToString());

                        klQuyDoi.NgonNguGiangDay = rowHeSo["NgonNguGiangDay"].ToString();

                        klQuyDoi.LoaiLop = rowHeSo["LoaiLop"].ToString();
                        
                        if (klQuyDoi.NgonNguGiangDay == "TIENGANH") //Mon chuyen nganh giang bang tieng anh.
                        {
                            klQuyDoi.TietQuyDoi = (klQuyDoi.SoTiet * (klQuyDoi.HeSoLopDong + klQuyDoi.HeSoLuong + klQuyDoi.HeSoChucDanhChuyenMon + klQuyDoi.HeSoNgoaiGio + klQuyDoi.HeSoCoSo + klQuyDoi.HeSoMonMoi + 1)) + klQuyDoi.SoTiet;
                        }
                        else
                        {
                            if (klQuyDoi.LoaiLop == "CLC")//Lop CLC
                            {
                                klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet;
                            }
                            else
                                klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * (klQuyDoi.HeSoLopDong + klQuyDoi.HeSoLuong + klQuyDoi.HeSoChucDanhChuyenMon + klQuyDoi.HeSoNgoaiGio + klQuyDoi.HeSoCoSo + klQuyDoi.HeSoMonMoi + 1);
                        }

                        if (klQuyDoi.HeSoCongViec != -1)    //Lop GDTC
                        {
                            klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * klQuyDoi.HeSoCongViec * (klQuyDoi.HeSoLopDong + klQuyDoi.HeSoLuong + klQuyDoi.HeSoChucDanhChuyenMon + klQuyDoi.HeSoNgoaiGio + klQuyDoi.HeSoCoSo + klQuyDoi.HeSoMonMoi + 1);
                        }

                        xmlData += "<Input _00MKL=\"" + klQuyDoi.MaKhoiLuongGiangDay
                                    + "\" _01MGV=\"" + klQuyDoi.MaGiangVien
                                    + "\" _02MLHP=\"" + klQuyDoi.MaLopHocPhan
                                    + "\" _03NH=\"" + klQuyDoi.NamHoc
                                    + "\" _04HK=\"" + klQuyDoi.HocKy
                                    + "\" _05MMH=\"" + klQuyDoi.MaMonHoc
                                    + "\" _06TMH=\"" + System.Security.SecurityElement.Escape(klQuyDoi.TenMonHoc)
                                    + "\" _07STC=\"" + klQuyDoi.SoTinChi
                                    + "\" _08SL=\"" + klQuyDoi.SoLuong
                                    + "\" _09MLOHP=\"" + klQuyDoi.MaLoaiHocPhan
                                    + "\" _10LOHP=\"" + klQuyDoi.LoaiHocPhan
                                    + "\" _11MBH=\"" + klQuyDoi.MaBuoiHoc
                                    + "\" _12ML=\"" + System.Security.SecurityElement.Escape(klQuyDoi.MaLop)
                                    + "\" _13TBD=\"" + klQuyDoi.TietBatDau
                                    + "\" _14ST=\"" + klQuyDoi.SoTiet
                                    + "\" _15TT=\"" + klQuyDoi.TinhTrang
                                    + "\" _16ND=\"" + ((DateTime)klQuyDoi.NgayDay).ToString("dd/MM/yyyy")
                                    + "\" _17MBDT=\"" + klQuyDoi.MaBacDaoTao
                                    + "\" _18MHK=\"" + klQuyDoi.MaKhoaHoc
                                    + "\" _19MK=\"" + klQuyDoi.MaKhoa
                                    + "\" _20MNMH=\"" + klQuyDoi.MaNhomMonHoc
                                    + "\" _21MPH=\"" + klQuyDoi.MaPhongHoc
                                    + "\" _22HSL=\"" + klQuyDoi.HeSoLuong
                                    + "\" _23HSLD=\"" + klQuyDoi.HeSoLopDong
                                    + "\" _24HSNG=\"" + klQuyDoi.HeSoNgoaiGio
                                    + "\" _25HSCD=\"" + klQuyDoi.HeSoChucDanhChuyenMon
                                    + "\" _26HSCS=\"" + klQuyDoi.HeSoCoSo
                                    + "\" _27HSMM=\"" + klQuyDoi.HeSoMonMoi
                                    + "\" _28NNGD=\"" + klQuyDoi.NgonNguGiangDay
                                    + "\" _29LL=\"" + klQuyDoi.LoaiLop
                                    + "\" _30TQD=\"" + klQuyDoi.TietQuyDoi
                                    + "\" />";
                    }
                }

                xmlData = "<Root>" + xmlData + "</Root>";

                int kq = 0;
                DataServices.KhoiLuongQuyDoi.LuuQuyDoi(xmlData, NamHoc, HocKy, ref kq);
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QuyDoiVHU
        void QuyDoiVHU(int index, string NamHoc, string HocKy)
        {
            try
            {
                string xmlData = "";
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
                if (QuyDoiBoSung == false)
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKy(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(NamHoc, HocKy);
                }
                else
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyBoSung(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteKhoiLuongBoSungByNamHocHocKy(NamHoc, HocKy);
                }
                int process = listKhoiLuong.Count;

                num = Thread.CurrentThread.CurrentUICulture.NumberFormat;

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;

                       //Cách tính quy chế cũ
                       // int _maNhomMonHoc = 0;
                       // TList<PhanNhomMonHoc> _listNhomMonHoc = DataServices.PhanNhomMonHoc.GetByNamHocHocKyMaMonHoc(klQuyDoi._namHoc, klQuyDoi._hocKy, klGiangDay.MaMonHoc);
                       // if (_listNhomMonHoc.Count > 0)
                       //     _maNhomMonHoc = _listNhomMonHoc[0].MaNhomMonHoc;
                       // else
                       //     _maNhomMonHoc = 1;//Nhóm chuyên môn
                       // klQuyDoi.MaNhomMonHoc = _maNhomMonHoc.ToString();

                       // double _heSoLopDong = 0, _heSoNienCheTinChi = 0, _heSoGiangTiengNuocNgoai = 0
                       //         , _heSoGiangDayNgoaiGio = 0, _heSoQuyDoiThucHanh = 0;

                       //// DataServices.HeSoCongViec.GetHeSoNienCheTinChi((bool)klGiangDay.DaoTaoTinChi, ref _heSoNienCheTinChi);
                       // DataServices.HeSoCongViec.GetHeSoNienCheTinChiByNamHocHocKy(klQuyDoi._namHoc,klQuyDoi._hocKy,(bool)klGiangDay.DaoTaoTinChi, ref _heSoNienCheTinChi);
                       // klQuyDoi.HeSoNienCheTinChi = (decimal?)_heSoNienCheTinChi;

                       // if(DataServices.LopHocPhanGiangBangTiengNuocNgoai.GetByMaLopHocPhan(klGiangDay.MaLopHocPhan) != null)
                       //     klQuyDoi.NgonNguGiangDay = "TIENGANH";
                       // else
                       //     klQuyDoi.NgonNguGiangDay = "TIENGVIET";
                       // //DataServices.HeSoCongViec.GetHeSoNgonNguGiangDay(klQuyDoi.NgonNguGiangDay, ref _heSoGiangTiengNuocNgoai);
                       // DataServices.HeSoCongViec.GetHeSoNgonNguGiangDayByNamHocHocKy(klQuyDoi._namHoc, klQuyDoi._hocKy,klQuyDoi.NgonNguGiangDay, ref _heSoGiangTiengNuocNgoai);
                       // klQuyDoi.HeSoNgonNgu = (decimal?)_heSoGiangTiengNuocNgoai;

                       // string Thu = klGiangDay.NgayDay.Value.DayOfWeek.ToString("d");
                       // //DataServices.HeSoCongViec.GetHeSoGiangDayNgoaiGio(Thu, (int)klGiangDay.TietBatDau, ref _heSoGiangDayNgoaiGio);
                       // DataServices.HeSoCongViec.GetHeSoGiangDayNgoaiGioByNamHocHocKy(klQuyDoi._namHoc, klQuyDoi._hocKy,Thu, (int)klGiangDay.TietBatDau, ref _heSoGiangDayNgoaiGio);
                       // klQuyDoi.HeSoNgoaiGio = (decimal)_heSoGiangDayNgoaiGio;
                       // //TList<HeSoCoSo> _listHeSoCoSo = DataServices.HeSoCoSo.GetByMaPhongHocNgayDay(klGiangDay.MaPhongHoc, (DateTime)klGiangDay.NgayDay);
                       // TList<HeSoCoSo> _listHeSoCoSo = DataServices.HeSoCoSo.GetByMaPhongHocNgayDayByNamHocHocKy(klQuyDoi._namHoc, klQuyDoi._hocKy,klGiangDay.MaPhongHoc, (DateTime)klGiangDay.NgayDay);
                       // if (_listHeSoCoSo.Count > 0)
                       //     klQuyDoi.HeSoCoSo = _listHeSoCoSo[0].HeSo;
                       // else
                       //     klQuyDoi.HeSoCoSo = 1;

                       // string _loaiKhoiLuong="";
                       // DataServices.HeSoLopDong.GetLoaiKhoiLuong(klQuyDoi.MaLopHocPhan, klQuyDoi.MaBacDaoTao, klQuyDoi.MaKhoaHoc,(int)klQuyDoi.TietBatDau,(DateTime)klQuyDoi.NgayDay, klQuyDoi.MaPhongHoc, ref _loaiKhoiLuong);
                       // //DataServices.HeSoLopDong.GetByNhomMonHocLoaiKhoiLuongSiSo(klQuyDoi.MaNhomMonHoc, _loaiKhoiLuong, (int)klQuyDoi.SoLuong, ref _heSoLopDong);
                       // DataServices.HeSoLopDong.GetByNhomMonHocLoaiKhoiLuongSiSoByNamHocHocKy(klQuyDoi._namHoc, klQuyDoi._hocKy,klQuyDoi.MaNhomMonHoc, _loaiKhoiLuong, (int)klQuyDoi.SoLuong, ref _heSoLopDong);
                       // klQuyDoi.HeSoLopDong = (decimal?)_heSoLopDong;

                       // decimal _heSoQuyDoiThucHanhRaTietChuan = 0;

                       // if (klGiangDay.MaLoaiHocPhan == 2)
                       // {
                       //     if (num.NumberDecimalSeparator == ".")
                       //     {
                       //         _heSoQuyDoiThucHanhRaTietChuan = decimal.Parse(_listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết").GiaTri);
                       //     }
                       //     if (num.NumberDecimalSeparator == ",")
                       //     {
                       //         string s = _listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết").GiaTri.Replace(".", ",");
                       //         _heSoQuyDoiThucHanhRaTietChuan = decimal.Parse(s);
                       //     }

                       //     //DataServices.HeSoNhomThucHanh.GetBySiSo((int)klGiangDay.SoLuong, ref _heSoQuyDoiThucHanh);
                       //     DataServices.HeSoNhomThucHanh.GetBySiSoByNamHocHocKy(klQuyDoi._namHoc, klQuyDoi._hocKy,(int)klGiangDay.SoLuong, ref _heSoQuyDoiThucHanh);

                       //     klQuyDoi.HeSoNienCheTinChi = null;
                       //     klQuyDoi.HeSoNgonNgu = null;
                       //     klQuyDoi.HeSoNgoaiGio = null;
                       //     klQuyDoi.HeSoCoSo = null;
                       //     klQuyDoi.HeSoLopDong = (decimal?)_heSoQuyDoiThucHanh;
                       //     klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = (decimal?)_heSoQuyDoiThucHanhRaTietChuan;
                       //     klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * klQuyDoi.HeSoLopDong * klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet;
                       // }
                       // else
                       // {
                       //     klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * (1 + (klQuyDoi.HeSoNienCheTinChi - 1) + (klQuyDoi.HeSoNgonNgu - 1) + (klQuyDoi.HeSoNgoaiGio - 1)
                       //                                                 + (klQuyDoi.HeSoCoSo - 1) + (klQuyDoi.HeSoLopDong - 1));
                       // }
                       // DataServices.KhoiLuongQuyDoi.Insert(klQuyDoi);

                        string Thu;
                        try
                        {
                            Thu = klGiangDay.NgayDay.Value.DayOfWeek.ToString("d");
                        }
                        catch
                        { Thu = "1"; }//Nếu không có ngày dạy (dữ liệu import) thì coi như là ngày thường

                        if (Thu == "0") Thu = "7";//Chủ nhật trên form = 0, dưới sql = 7
                        DataTable _heSoQuyDoi = new DataTable();
                        IDataReader reader = DataServices.GiangVien.GetHeSoQuyDoiTietChuanChung(NamHoc, HocKy, klQuyDoi.MaBacDaoTao, klQuyDoi.MaLopHocPhan
                            , klQuyDoi.MaMonHoc, (int)klQuyDoi.SoLuong, klQuyDoi.MaLop, klQuyDoi.MaLoaiHocPhan.ToString(), (DateTime)klQuyDoi.NgayDay
                            , (int)klQuyDoi.TietBatDau, Thu
                            , (int)klGiangDay.MaHocHam
                            , (int)klGiangDay.MaHocVi
                            , klQuyDoi.MaPhongHoc, klQuyDoi.MaKhoa
                            , (bool)klGiangDay.DaoTaoTinChi
                            , (int)klGiangDay.MaLoaiGiangVien);
                        _heSoQuyDoi.Load(reader);

                        DataRow _rowHeSo = _heSoQuyDoi.Rows[0];

                        klQuyDoi.HeSoLopDong = decimal.Parse(_rowHeSo["HeSoLopDong"].ToString());
                        klQuyDoi.HeSoBacDaoTao = decimal.Parse(_rowHeSo["HeSoBacDaoTao"].ToString());
                        klQuyDoi.NgonNguGiangDay = _rowHeSo["NgonNguGiangDay"].ToString();
                        klQuyDoi.HeSoNgonNgu = decimal.Parse(_rowHeSo["HeSoNgonNgu"].ToString());
                        klQuyDoi.HeSoClcCntn = decimal.Parse(_rowHeSo["HeSoClcCntn"].ToString());
                        klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = decimal.Parse(_rowHeSo["HeSoQuyDoiThucHanhSangLyThuyet"].ToString());
                        klQuyDoi.HeSoNgoaiGio = decimal.Parse(_rowHeSo["HeSoNgoaiGio"].ToString());
                        klQuyDoi.HeSoChucDanhChuyenMon = decimal.Parse(_rowHeSo["HeSoChucDanhChuyenMon"].ToString());
                        klQuyDoi.HeSoCoSo = decimal.Parse(_rowHeSo["HeSoCoSo"].ToString());

                        klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * klQuyDoi.HeSoLopDong * klQuyDoi.HeSoBacDaoTao * klQuyDoi.HeSoNgonNgu
                            * klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet * klQuyDoi.HeSoNgoaiGio * klQuyDoi.HeSoCoSo
                            * klQuyDoi.HeSoClcCntn;

                        xmlData += "<Input _01MKL=\"" + klQuyDoi.MaKhoiLuongGiangDay
                                + "\" _02MGV=\"" + klQuyDoi.MaGiangVien
                                + "\" _03MLHP=\"" + klQuyDoi.MaLopHocPhan
                                + "\" _04NH=\"" + klQuyDoi.NamHoc
                                + "\" _05HK=\"" + klQuyDoi.HocKy
                                + "\" _06MMH=\"" + klQuyDoi.MaMonHoc
                                + "\" _07TMH=\"" + System.Security.SecurityElement.Escape(klQuyDoi.TenMonHoc)
                                + "\" _08STC=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTinChi, "decimal")
                                + "\" _09SL=\"" + klQuyDoi.SoLuong
                                + "\" _10MLHP=\"" + klQuyDoi.MaLoaiHocPhan
                                + "\" _11LHP=\"" + klQuyDoi.LoaiHocPhan
                                + "\" _12MBH=\"" + klQuyDoi.MaBuoiHoc
                                + "\" _13ML=\"" + System.Security.SecurityElement.Escape(klQuyDoi.MaLop)
                                + "\" _14TBD=\"" + klQuyDoi.TietBatDau
                                + "\" _15ST=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTiet, "decimal")
                                + "\" _16TT=\"" + klQuyDoi.TinhTrang
                                + "\" _17ND=\"" + ((DateTime)klQuyDoi.NgayDay).ToString("yyyy/MM/dd")
                                + "\" _18MBDT=\"" + klQuyDoi.MaBacDaoTao
                                + "\" _19MKH=\"" + klQuyDoi.MaKhoaHoc
                                + "\" _20MK=\"" + klQuyDoi.MaKhoa
                                + "\" _21MNMH=\"" + klQuyDoi.MaNhomMonHoc
                                + "\" _22MPH=\"" + klQuyDoi.MaPhongHoc
                                + "\" _23HSCV=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCongViec, "decimal")
                                + "\" _24HSBDT=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoBacDaoTao, "decimal")
                                + "\" _25HSNN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNgonNgu, "decimal")
                                + "\" _26HSCDCM=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoChucDanhChuyenMon, "decimal")
                                + "\" _27HSLD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoLopDong, "decimal")
                                + "\" _28HSCS=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCoSo, "decimal")
                                + "\" _29STTTQD=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTietThucTeQuyDoi, "decimal")
                                + "\" _30TQD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.TietQuyDoi, "decimal")
                                + "\" _31HSQDTHSLT=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet, "decimal")//klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet
                                + "\" _32HSNG=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNgoaiGio, "decimal")//klQuyDoi.HeSoNgoaiGio
                                + "\" _33LL=\"" + ""//klQuyDoi.LoaiLop
                                + "\" _34HSCLCCNTN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoClcCntn, "decimal")//klQuyDoi.HeSoClcCntn
                                + "\" _35HSTGMCN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoThinhGiangMonChuyenNganh
                                + "\" _36NNGD=\"" + klQuyDoi.NgonNguGiangDay
                                + "\" _37HSTCGD=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoTroCapGiangDay
                                + "\" _38HSTC=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoTroCap, "decimal")//klQuyDoi.HeSoTroCap
                                + "\" _39HSL=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoLuong
                                + "\" _40HSMM=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoMonMoi
                                + "\" _41HSNCTC=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNienCheTinChi, "decimal")
                                + "\" _42GC=\"" + string.Empty//klQuyDoi.GhiChu
                                + "\" _43MTT=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.MucThanhToan, "decimal")
                                + "\" />";
                    }
                }

                xmlData = "<Root>" + xmlData + "</Root>";
                int kq = 0;
                DataServices.KhoiLuongQuyDoi.LuuQuyDoiAll(xmlData, NamHoc, HocKy, ref kq);
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QuyDoiCDGTVT
        void QuyDoiCDGTVT(int index, string NamHoc, string HocKy)
        {
            try
            {
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
                if (QuyDoiBoSung == false)
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKy(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(NamHoc, HocKy);
                }
                else
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyBoSung(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteKhoiLuongBoSungByNamHocHocKy(NamHoc, HocKy);
                }
                int process = listKhoiLuong.Count;

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;

                        double _heSoBacDaoTao = 0, _heSoLopDong = 0, _heSoMonThucTap = 0, _heSoCVHT = 0;
                        DataServices.HeSoBacDaoTao.GetByMaBacNamHocHocKy(klGiangDay.MaBacDaoTao, klGiangDay.NamHoc, klGiangDay.HocKy, ref _heSoBacDaoTao);
                        klQuyDoi.HeSoBacDaoTao = (decimal)_heSoBacDaoTao;

                        int _maNhomMonHoc = 0;
                        TList<PhanNhomMonHoc> _listNhomMonHoc = DataServices.PhanNhomMonHoc.GetByNamHocHocKyMaMonHoc(klQuyDoi.NamHoc, klQuyDoi.HocKy, klGiangDay.MaMonHoc);
                        if (_listNhomMonHoc.Count > 0)
                            _maNhomMonHoc = _listNhomMonHoc[0].MaNhomMonHoc;
                        else
                            _maNhomMonHoc = 9;//Nhóm môn học bình thường
                        klQuyDoi.MaNhomMonHoc = _maNhomMonHoc.ToString();

                        DataServices.HeSoLopDong.GetByNamHocHocKyBacDaoTaoNhomMonHocSiSo(klGiangDay.NamHoc, klGiangDay.HocKy, klGiangDay.MaBacDaoTao, klQuyDoi.MaNhomMonHoc, (int)klGiangDay.SoLuong, ref _heSoLopDong);
                        klQuyDoi.HeSoLopDong = (decimal)_heSoLopDong;

                        if (_maNhomMonHoc == 12)//Nhóm môn thực tập
                        {
                            if (num.NumberDecimalSeparator == ".")
                            {
                                _heSoMonThucTap = double.Parse(_listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết").GiaTri);
                            }
                            if (num.NumberDecimalSeparator == ",")
                            {
                                string s = _listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết").GiaTri.Replace(".", ",");
                                _heSoMonThucTap = double.Parse(s);
                            }
                        }
                        else
                            _heSoMonThucTap = 1;

                        klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = (decimal)_heSoMonThucTap;

                        if (klGiangDay.MaLichHoc == -2)//Những dòng CVHT
                        {
                            DataServices.HeSoCoVanHocTap.GetByNamHocHocKySiSo(klQuyDoi.NamHoc, klQuyDoi.HocKy, (int)klQuyDoi.SoLuong, ref _heSoCVHT);
                            if (klGiangDay.MaChucVu == 76)//Nếu là GVCN thì ko tính hệ số CVHT
                                _heSoCVHT = 1;
                            klQuyDoi.TietQuyDoi = klGiangDay.SoTiet * (decimal)_heSoCVHT;
                        }
                        else
                        {
                            if (klGiangDay.MaLichHoc == -3)//Những dòng NCKH
                            { klQuyDoi.TietQuyDoi = klGiangDay.SoTiet; }
                            else
                            {
                                klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * (decimal)_heSoBacDaoTao * (decimal)_heSoLopDong * (decimal)_heSoMonThucTap;
                                _heSoCVHT = 1;
                            }
                        }

                        klQuyDoi.HeSoTroCap = (decimal)_heSoCVHT;

                        DataServices.KhoiLuongQuyDoi.Insert(klQuyDoi);
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QuyDoiHBU
        void QuyDoiHBU(int index, string NamHoc, string HocKy)
        {
            try
            {
                string xmlData = "";
               
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
                if (QuyDoiBoSung == false)
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKy(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(NamHoc, HocKy);
                }
                else
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyBoSung(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteKhoiLuongBoSungByNamHocHocKy(NamHoc, HocKy);
                }
                int process = listKhoiLuong.Count;

                num = Thread.CurrentThread.CurrentUICulture.NumberFormat;

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;

                        string Thu;
                        try
                        {
                            Thu = klGiangDay.NgayDay.Value.DayOfWeek.ToString("d");
                        }
                        catch
                        { Thu = "1"; }  //Nếu không có ngày dạy (dữ liệu import) thì coi như là ngày thường

                        DataTable _heSoQuyDoi = new DataTable();
                        IDataReader reader = DataServices.GiangVien.GetHeSoQuyDoiTietChuanChung(NamHoc, HocKy, klQuyDoi.MaBacDaoTao, klQuyDoi.MaLopHocPhan
                            , klQuyDoi.MaMonHoc, (int)klQuyDoi.SoLuong, klQuyDoi.MaLop, klQuyDoi.MaLoaiHocPhan.ToString(), (DateTime)klQuyDoi.NgayDay
                            , (int)klQuyDoi.TietBatDau
                            , Thu
                            , (int)klGiangDay.MaHocHam
                            , (int)klGiangDay.MaHocVi
                            , klQuyDoi.MaPhongHoc
                            , klQuyDoi.MaKhoa
                            , (bool)klGiangDay.DaoTaoTinChi
                            , (int)klGiangDay.MaLoaiGiangVien);
                        _heSoQuyDoi.Load(reader);

                        DataRow _rowHeSo = _heSoQuyDoi.Rows[0];

                        klQuyDoi.HeSoLopDong = decimal.Parse(_rowHeSo["HeSoLopDong"].ToString());
                        klQuyDoi.HeSoBacDaoTao = decimal.Parse(_rowHeSo["HeSoBacDaoTao"].ToString());
                        klQuyDoi.NgonNguGiangDay = _rowHeSo["NgonNguGiangDay"].ToString();
                        klQuyDoi.HeSoNgonNgu = decimal.Parse(_rowHeSo["HeSoNgonNgu"].ToString());
                        //klQuyDoi.HeSoClcCntn = decimal.Parse(_rowHeSo["HeSoClcCntn"].ToString());
                        klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = decimal.Parse(_rowHeSo["HeSoQuyDoiThucHanhSangLyThuyet"].ToString());
                        klQuyDoi.HeSoNgoaiGio = decimal.Parse(_rowHeSo["HeSoNgoaiGio"].ToString());
                        klQuyDoi.HeSoChucDanhChuyenMon = decimal.Parse(_rowHeSo["HeSoChucDanhChuyenMon"].ToString());
                        //klQuyDoi.HeSoCoSo = decimal.Parse(_rowHeSo["HeSoCoSo"].ToString());
                        klQuyDoi.HeSoKhoiNganh = decimal.Parse(_rowHeSo["HeSoKhoiNganh"].ToString()); //Hệ số khối ngành đang gán "cứng" bằng 0!

                        if (klQuyDoi.LoaiHocPhan.Equals("TH")) //Hướng dẫn thực hành theo khối ngành GiC = số tiết theo TKB * 0.5  * (sĩ số / số lượng từng khối ngành)
                        {
                            int siSoKhoiNganh = int.Parse(_rowHeSo["SiSoNhomThucHanh"].ToString());
                            klQuyDoi.TietQuyDoi = klQuyDoi.SoTiet * klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet * (klQuyDoi.SoLuong * (decimal)(1.0) / siSoKhoiNganh);
                        }
                        else
                        {
                            klQuyDoi.TietQuyDoi = (1 + klQuyDoi.HeSoLopDong + klQuyDoi.HeSoBacDaoTao + klQuyDoi.HeSoNgonNgu
                            + klQuyDoi.HeSoNgoaiGio + klQuyDoi.HeSoChucDanhChuyenMon + klQuyDoi.HeSoKhoiNganh) * klQuyDoi.SoTiet; //Hệ số khối ngành đang gán "cứng" bằng 0.
                        }
                        
                        xmlData += "<Input _01MKL=\"" + klQuyDoi.MaKhoiLuongGiangDay
                                + "\" _02MGV=\"" + klQuyDoi.MaGiangVien
                                + "\" _03MLHP=\"" + klQuyDoi.MaLopHocPhan
                                + "\" _04NH=\"" + klQuyDoi.NamHoc
                                + "\" _05HK=\"" + klQuyDoi.HocKy
                                + "\" _06MMH=\"" + klQuyDoi.MaMonHoc
                                + "\" _07TMH=\"" + System.Security.SecurityElement.Escape(klQuyDoi.TenMonHoc)
                                + "\" _08STC=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTinChi, "decimal")
                                + "\" _09SL=\"" + klQuyDoi.SoLuong
                                + "\" _10MLHP=\"" + klQuyDoi.MaLoaiHocPhan
                                + "\" _11LHP=\"" + klQuyDoi.LoaiHocPhan
                                + "\" _12MBH=\"" + klQuyDoi.MaBuoiHoc
                                + "\" _13ML=\"" + System.Security.SecurityElement.Escape(klQuyDoi.MaLop)
                                + "\" _14TBD=\"" + klQuyDoi.TietBatDau
                                + "\" _15ST=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTiet, "decimal")
                                + "\" _16TT=\"" + klQuyDoi.TinhTrang
                                + "\" _17ND=\"" + ((DateTime)klQuyDoi.NgayDay).ToString("yyyy/MM/dd")
                                + "\" _18MBDT=\"" + klQuyDoi.MaBacDaoTao
                                + "\" _19MKH=\"" + klQuyDoi.MaKhoaHoc
                                + "\" _20MK=\"" + klQuyDoi.MaKhoa
                                + "\" _21MNMH=\"" + klQuyDoi.MaNhomMonHoc
                                + "\" _22MPH=\"" + klQuyDoi.MaPhongHoc
                                + "\" _23HSCV=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCongViec, "decimal")
                                + "\" _24HSBDT=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoBacDaoTao, "decimal")
                                + "\" _25HSNN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNgonNgu, "decimal")
                                + "\" _26HSCDCM=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoChucDanhChuyenMon, "decimal")
                                + "\" _27HSLD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoLopDong, "decimal")
                                + "\" _28HSCS=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCoSo, "decimal")
                                + "\" _29STTTQD=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTietThucTeQuyDoi, "decimal")
                                + "\" _30TQD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.TietQuyDoi, "decimal")
                                + "\" _31HSQDTHSLT=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet, "decimal")//klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet
                                + "\" _32HSNG=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNgoaiGio, "decimal")//klQuyDoi.HeSoNgoaiGio
                                + "\" _33LL=\"" + ""//klQuyDoi.LoaiLop
                                + "\" _34HSCLCCNTN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoClcCntn, "decimal")//klQuyDoi.HeSoClcCntn
                                + "\" _35HSTGMCN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoThinhGiangMonChuyenNganh
                                + "\" _36NNGD=\"" + klQuyDoi.NgonNguGiangDay
                                + "\" _37HSTCGD=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoTroCapGiangDay
                                + "\" _38HSTC=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoTroCap, "decimal")//klQuyDoi.HeSoTroCap
                                + "\" _39HSL=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoLuong
                                + "\" _40HSMM=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoMonMoi
                                + "\" _41HSNCTC=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNienCheTinChi, "decimal")
                                + "\" _42HSKN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoKhoiNganh, "decimal")
                                + "\" _43GC=\"" + string.Empty//klQuyDoi.GhiChu
                                + "\" _44MTT=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.MucThanhToan, "decimal")
                                + "\" />";
                    }
                }

                xmlData = "<Root>" + xmlData + "</Root>";
                int kq = 0;
                DataServices.KhoiLuongQuyDoi.LuuQuyDoiAll(xmlData, NamHoc, HocKy, ref kq);
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QuyDoiDLU
        void QuyDoiDLU(int index, string NamHoc, string HocKy)
        {
            try
            {
                string xmlData = ""; 

                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();

                listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyCauHinhChotGio(NamHoc, HocKy, DotThanhToan);
                //DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKyCauHinhChotGio(_namHoc, _hocKy, _dotThanhToan);

                int process = listKhoiLuong.Count;

                num = Thread.CurrentThread.CurrentUICulture.NumberFormat;

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;
                         
                        string Thu;
                        try
                        {
                            Thu = klGiangDay.NgayDay.Value.DayOfWeek.ToString("d");
                        }
                        catch
                        { Thu = "1"; }  //Nếu không có ngày dạy (dữ liệu import) thì coi như là ngày thường

                        DataTable _heSoQuyDoi = new DataTable();
                        IDataReader reader = DataServices.GiangVien.GetHeSoQuyDoiTietChuanChung(NamHoc, HocKy, klQuyDoi.MaBacDaoTao, klQuyDoi.MaLopHocPhan
                            , klQuyDoi.MaMonHoc, (int)klQuyDoi.SoLuong, klQuyDoi.MaLop, klQuyDoi.MaLoaiHocPhan.ToString(), (DateTime)klQuyDoi.NgayDay
                            , (int)klQuyDoi.TietBatDau
                            , Thu
                            , (int)klGiangDay.MaHocHam
                            , (int)klGiangDay.MaHocVi
                            , klQuyDoi.MaPhongHoc
                            , klQuyDoi.MaKhoa
                            , (bool)klGiangDay.DaoTaoTinChi
                            , (int)klGiangDay.MaLoaiGiangVien);
                        _heSoQuyDoi.Load(reader);

                        DataRow _rowHeSo = _heSoQuyDoi.Rows[0];

                        klQuyDoi.HeSoLopDong = decimal.Parse(_rowHeSo["HeSoLopDong"].ToString());
                        klQuyDoi.HeSoBacDaoTao = decimal.Parse(_rowHeSo["HeSoBacDaoTao"].ToString());
                        //klQuyDoi.NgonNguGiangDay = _rowHeSo["NgonNguGiangDay"].ToString();
                        //klQuyDoi.HeSoNgonNgu = decimal.Parse(_rowHeSo["HeSoNgonNgu"].ToString());
                        //klQuyDoi.HeSoClcCntn = decimal.Parse(_rowHeSo["HeSoClcCntn"].ToString());
                        klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet = decimal.Parse(_rowHeSo["HeSoQuyDoiThucHanhSangLyThuyet"].ToString());
                        //klQuyDoi.HeSoNgoaiGio = decimal.Parse(_rowHeSo["HeSoNgoaiGio"].ToString());
                        //klQuyDoi.HeSoCoSo = decimal.Parse(_rowHeSo["HeSoCoSo"].ToString());

                        if (klGiangDay.MaLoaiHocPhan == 1)//Lý thuyết
                        {
                            klQuyDoi.HeSoChucDanhChuyenMon = decimal.Parse(_rowHeSo["HeSoChucDanhChuyenMon"].ToString());
                            klQuyDoi.TietQuyDoi = (klQuyDoi.HeSoLopDong + klQuyDoi.HeSoBacDaoTao
                                     + klQuyDoi.HeSoChucDanhChuyenMon) * klQuyDoi.SoTiet;
                        }
                        else //if (klQuyDoi.MaGiangVien.Equals("011.208.00005")) //<< test //Thực hành
                        {
                            int _siSoNhomThucHanh = int.Parse(_rowHeSo["SiSoNhomThucHanh"].ToString());
                            if (_siSoNhomThucHanh == 0)
                            {
                                if(klQuyDoi.NamHoc.Equals("2015-2016") && klQuyDoi.LoaiHocPhan.Equals("TH") ) {
                                    _siSoNhomThucHanh = (int)klQuyDoi.SoLuong;
                                } else {
                                    continue;
                                    //backgroundWorker.CancelAsync();
                                    //XtraMessageBox.Show("Môn học {" + klQuyDoi.MaMonHoc + "}-{" + klQuyDoi.TenMonHoc + "} chưa được phân vào nhóm thực hành.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    //return;
                                }
                            }
                            klQuyDoi.HeSoChucDanhChuyenMon = decimal.Parse(_rowHeSo["HeSoChucDanhThucHanh"].ToString());
                            decimal _soNhomThucHanh = Math.Round(((decimal)klQuyDoi.SoLuong / _siSoNhomThucHanh), 0, MidpointRounding.AwayFromZero);
                            //Nếu số sinh viên trong lớp nhỏ hơn 50% thì coi như là 1 nhóm
                            if (klQuyDoi.SoLuong > 0 && _soNhomThucHanh == 0) _soNhomThucHanh = 1;
                            //klQuyDoi.TietQuyDoi = (klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet + klQuyDoi.HeSoChucDanhChuyenMon) 
                            //                    * _soNhomThucHanh * klQuyDoi.SoTiet;
                            klQuyDoi.TietQuyDoi = (klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet * ((decimal)klQuyDoi.SoLuong / _siSoNhomThucHanh) * klQuyDoi.SoTiet)
                                   * (1 + klQuyDoi.HeSoChucDanhChuyenMon); //DLU
                            //klQuyDoi.TietQuyDoi = (1 + (klQuyDoi.HeSoBacDaoTao - 1) + (klQuyDoi.HeSoLopDong - 1)); //QNU
                        }

                        xmlData += "<Input _01MKL=\"" + klQuyDoi.MaKhoiLuongGiangDay
                                + "\" _02MGV=\"" + klQuyDoi.MaGiangVien
                                + "\" _03MLHP=\"" + klQuyDoi.MaLopHocPhan
                                + "\" _04NH=\"" + klQuyDoi.NamHoc
                                + "\" _05HK=\"" + klQuyDoi.HocKy
                                + "\" _06MMH=\"" + klQuyDoi.MaMonHoc
                                + "\" _07TMH=\"" + System.Security.SecurityElement.Escape(klQuyDoi.TenMonHoc)
                                + "\" _08STC=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTinChi, "decimal")
                                + "\" _09SL=\"" + klQuyDoi.SoLuong
                                + "\" _10MLHP=\"" + klQuyDoi.MaLoaiHocPhan
                                + "\" _11LHP=\"" + klQuyDoi.LoaiHocPhan
                                + "\" _12MBH=\"" + klQuyDoi.MaBuoiHoc
                                + "\" _13ML=\"" + System.Security.SecurityElement.Escape(klQuyDoi.MaLop)
                                + "\" _14TBD=\"" + klQuyDoi.TietBatDau
                                + "\" _15ST=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTiet, "decimal")
                                + "\" _16TT=\"" + klQuyDoi.TinhTrang
                                + "\" _17ND=\"" + ((DateTime)klQuyDoi.NgayDay).ToString("yyyy/MM/dd")
                                + "\" _18MBDT=\"" + klQuyDoi.MaBacDaoTao
                                + "\" _19MKH=\"" + klQuyDoi.MaKhoaHoc
                                + "\" _20MK=\"" + klQuyDoi.MaKhoa
                                + "\" _21MNMH=\"" + klQuyDoi.MaNhomMonHoc
                                + "\" _22MPH=\"" + klQuyDoi.MaPhongHoc
                                + "\" _23HSCV=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCongViec, "decimal")
                                + "\" _24HSBDT=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoBacDaoTao, "decimal")
                                + "\" _25HSNN=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNgonNgu, "decimal")
                                + "\" _26HSCDCM=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoChucDanhChuyenMon, "decimal")
                                + "\" _27HSLD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoLopDong, "decimal")
                                + "\" _28HSCS=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoCoSo, "decimal")
                                + "\" _29STTTQD=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.SoTietThucTeQuyDoi, "decimal")
                                + "\" _30TQD=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.TietQuyDoi, "decimal")
                                + "\" _31HSQDTHSLT=\"" + PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet, "decimal")//klQuyDoi.HeSoQuyDoiThucHanhSangLyThuyet
                                + "\" _32HSNG=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNgoaiGio, "decimal")//klQuyDoi.HeSoNgoaiGio
                                + "\" _33LL=\"" + ""//klQuyDoi.LoaiLop
                                + "\" _34HSCLCCNTN=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoClcCntn, "decimal")//klQuyDoi.HeSoClcCntn
                                + "\" _35HSTGMCN=\"" + PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoThinhGiangMonChuyenNganh
                                + "\" _36NNGD=\"" + ""//klQuyDoi.NgonNguGiangDay
                                + "\" _37HSTCGD=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoTroCapGiangDay
                                + "\" _38HSTC=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoTroCap, "decimal")//klQuyDoi.HeSoTroCap
                                + "\" _39HSL=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoLuong
                                + "\" _40HSMM=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(0, "decimal")//klQuyDoi.HeSoMonMoi
                                + "\" _41HSNCTC=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoNienCheTinChi, "decimal")
                                + "\" _42HSKN=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.HeSoKhoiNganh, "decimal")
                                + "\" _43GC=\"" + string.Empty//klQuyDoi.GhiChu
                                + "\" _44MTT=\"" + 0//PMS.Common.Globals.ReplaceDotEnviroment(klQuyDoi.MucThanhToan, "decimal")
                                + "\" />";
                    }
                }

                xmlData = "<Root>" + xmlData + "</Root>";
                int kq = 0;
                DataServices.KhoiLuongQuyDoi.LuuQuyDoiTheoDotAll(xmlData, NamHoc, HocKy, DotThanhToan, ref kq);
                
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region QuyDoiCacTruongConLai
        void QuyDoiCacTruongConLai(int index, string NamHoc, string HocKy)
        {
            try
            {
                TList<KhoiLuongGiangDayChiTiet> listKhoiLuong = new TList<KhoiLuongGiangDayChiTiet>();
                if (QuyDoiBoSung == false)
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKy(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(NamHoc, HocKy);
                }
                else
                {
                    listKhoiLuong = DataServices.KhoiLuongGiangDayChiTiet.GetByNamHocHocKyBoSung(NamHoc, HocKy);
                    DataServices.KhoiLuongQuyDoi.DeleteKhoiLuongBoSungByNamHocHocKy(NamHoc, HocKy);
                }
                int process = listKhoiLuong.Count;

                foreach (KhoiLuongGiangDayChiTiet klGiangDay in listKhoiLuong)
                {
                    if (!backgroundWorker.CancellationPending)
                    {
                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("GV: {0}.\t MH: {1}", klGiangDay.MaGiangVien, klGiangDay.TenMonHoc));

                        KhoiLuongQuyDoi klQuyDoi = new KhoiLuongQuyDoi();
                        klQuyDoi.MaKhoiLuongGiangDay = klGiangDay.MaKhoiLuong;
                        klQuyDoi.MaGiangVien = klGiangDay.MaGiangVien;
                        klQuyDoi.MaLopHocPhan = klGiangDay.MaLopHocPhan;
                        klQuyDoi.NamHoc = klGiangDay.NamHoc;
                        klQuyDoi.HocKy = klGiangDay.HocKy;
                        klQuyDoi.MaMonHoc = klGiangDay.MaMonHoc;
                        klQuyDoi.TenMonHoc = klGiangDay.TenMonHoc;
                        klQuyDoi.SoTinChi = klGiangDay.SoTinChi;
                        klQuyDoi.SoLuong = klGiangDay.SoLuong;
                        klQuyDoi.MaLoaiHocPhan = klGiangDay.MaLoaiHocPhan;
                        klQuyDoi.LoaiHocPhan = klGiangDay.LoaiHocPhan;
                        klQuyDoi.MaBuoiHoc = klGiangDay.MaBuoiHoc;
                        klQuyDoi.MaLop = klGiangDay.MaLop;
                        klQuyDoi.TietBatDau = klGiangDay.TietBatDau;
                        klQuyDoi.SoTiet = klGiangDay.SoTiet;
                        klQuyDoi.TinhTrang = klGiangDay.TinhTrang;
                        klQuyDoi.NgayDay = klGiangDay.NgayDay;
                        klQuyDoi.MaBacDaoTao = klGiangDay.MaBacDaoTao;
                        klQuyDoi.MaKhoaHoc = klGiangDay.MaKhoaHoc;
                        klQuyDoi.MaKhoa = klGiangDay.MaKhoa;
                        klQuyDoi.MaNhomMonHoc = klGiangDay.MaNhomMonHoc;
                        klQuyDoi.MaPhongHoc = klGiangDay.MaPhongHoc;
                        klQuyDoi.HeSoCongViec = (DataServices.HeSoCongViec.GetByLoaiHocPhanNgayDay(klQuyDoi.MaLoaiHocPhan.ToString(), DateTime.Parse(klQuyDoi.NgayDay.ToString())) as TList<HeSoCongViec>)[0].HeSo;
                        klQuyDoi.HeSoBacDaoTao = (DataServices.HeSoBacDaoTao.GetByBacDaoTaoKhoaNgayDay(klQuyDoi.MaBacDaoTao, klQuyDoi.MaKhoa, DateTime.Parse(klQuyDoi.NgayDay.ToString())) as TList<HeSoBacDaoTao>)[0].HeSo;
                        klQuyDoi.HeSoNgonNgu = (DataServices.HeSoNgonNgu.GetByMaLopHocPhanNgayDay(klQuyDoi.MaLopHocPhan, DateTime.Parse(klQuyDoi.NgayDay.ToString())) as TList<HeSoNgonNgu>)[0].HeSo;
                        try
                        {
                            klQuyDoi.HeSoChucDanhChuyenMon = (DataServices.HeSoChucDanhTietNghiaVu.GetByMaGiangVienNgayDay(klQuyDoi.MaGiangVien, DateTime.Parse(klQuyDoi.NgayDay.ToString()), NamHoc, HocKy) as TList<HeSoChucDanhTietNghiaVu>)[0].HeSo;
                        }
                        catch
                        {
                            XtraMessageBox.Show(string.Format("Kiểm tra lại học hàm học vị của giảng viên {0}", klQuyDoi.MaGiangVien), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        klQuyDoi.HeSoLopDong = (DataServices.HeSoLopDong.GetBySiSoNhomMonHocLoaiHocPhanBacDaoTaoNgayDay(klQuyDoi.MaBacDaoTao, int.Parse(klQuyDoi.SoLuong.ToString()), klQuyDoi.MaNhomMonHoc, klQuyDoi.LoaiHocPhan, DateTime.Parse(klQuyDoi.NgayDay.ToString())) as TList<HeSoLopDong>)[0].HeSo;//nhóm môn tin học- nếu ko có thì bắt nhập
                        klQuyDoi.HeSoCoSo = (DataServices.HeSoCoSo.GetByMaPhongHocNgayDay(klQuyDoi.MaPhongHoc, DateTime.Parse(klQuyDoi.NgayDay.ToString())) as TList<HeSoCoSo>)[0].HeSo;//lấy theo mả phòng học
                        //Số tiết thực tế quy đổi: (đào tạo theo niên chế = 1, đào tạo theo tín chỉ = 50/45, sau đại học = 1) nhân với số tiết thực tế.
                        int _heSoNienCheTinChi = 0;
                        DataServices.KhoiLuongGiangDayChiTiet.GetHeSoNienCheTinChi(klQuyDoi.MaLopHocPhan, ref _heSoNienCheTinChi);
                        if (_heSoNienCheTinChi == 1)
                            klQuyDoi.SoTietThucTeQuyDoi = klQuyDoi.SoTiet * (decimal?)1.11;
                        else klQuyDoi.SoTietThucTeQuyDoi = klQuyDoi.SoTiet;
                        klQuyDoi.TietQuyDoi = klQuyDoi.SoTietThucTeQuyDoi * klQuyDoi.HeSoCongViec *
                            (1 + (klQuyDoi.HeSoBacDaoTao - 1) + (klQuyDoi.HeSoNgonNgu - 1) + (klQuyDoi.HeSoChucDanhChuyenMon - 1) + (klQuyDoi.HeSoLopDong - 1) + (klQuyDoi.HeSoCoSo - 1));

                        DataServices.KhoiLuongQuyDoi.Insert(klQuyDoi);
                    }
                }
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}