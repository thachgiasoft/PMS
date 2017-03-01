using System;
using DevExpress.XtraEditors;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UserDesigner;
using XtraReportsDemos;
using PMS.Entities;
using PMS.Services;
using PMS.UserReports;
using DevExpress.XtraReports.Parameters;
using System.Data;
using ReportManager.Reports;
using ReportManager.GV;
using PMS.UserReports.KhongChinhQuy;
using PMS.UserReports.ReportThanhTra;
using PMS.UserReports.SauDaiHoc;
using PMS.UserReports.NCKH;

namespace PMS.UI.Forms.BaoCao
{
    public partial class frmBaoCao : XtraForm
    {
        private XtraReport XReport;
        private ReportTemplate objReport;

        public frmBaoCao()
        {
            InitializeComponent();
        }

        #region In thống kê thực tập cuối khóa
        public void InThongkeKhoiLuongThucTapCuoiKhoa(string truong, string namHoc, string hocKy, string nguoiLapBieu, DateTime ngayIn, System.Data.DataTable tb)
        {
            Text = "Bảng thống kê thực tập cuối khóa";
            rptThongKeKhoiLuongThucTapCuoiKhoa report = new rptThongKeKhoiLuongThucTapCuoiKhoa();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, hocKy, nguoiLapBieu, ngayIn, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bảng kê thanh toán tiền giảng theo năm học
        public void InBangKeThanhToanTienGiangNamHoc(string truong, string namHoc, string hocKy, string hieuTruong, string nguoiKeKhai, DateTime _ngayIn, DataTable tb, DataTable tamUng)
        {
            Text = "Bảng kê thanh toán tiền giảng theo năm học";
            rptBangKeThanhToanTienGiangNamHoc_Law report = new rptBangKeThanhToanTienGiangNamHoc_Law();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, hocKy, hieuTruong, nguoiKeKhai, _ngayIn, tb, tamUng);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bảng kê thanh toán tạm ứng 
        public void InBangKeThanhToanTamUng(string truong, string namHoc, string hocKy, string hieuTruong, string nguoiKeKhai, DateTime _ngayIn, DataTable tb)
        {
            Text = "Bảng thống kê giảng viên giảng dạy theo năm, hệ, ngành thực tế";
            BangKeThangToanTienGiangHK_NH report = new BangKeThangToanTienGiangHK_NH();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, hocKy, hieuTruong, nguoiKeKhai, _ngayIn, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê giảng viên giảng dạy theo năm, hệ, ngành thực tế
        public void InThongKeGiangVienGiangTheoNamHeNganhThucTe(string truong, DateTime ngay, DateTime ngayIn, DataTable tb)
        {
            Text = "Bảng thống kê giảng viên giảng dạy theo năm, hệ, ngành thực tế";
            ThongKeGVThamGiaGDThucTe report = new ThongKeGVThamGiaGDThucTe();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, ngay, ngayIn, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê giảng viên giảng dạy theo năm, hệ, ngành
        public void InThongKeGiangVienGiangTheoNamHeNganh(string truong, DateTime ngay, DateTime ngayIn, DataTable tb)
        {
            Text = "Bảng thống kê giảng viên giảng dạy theo năm, hệ, ngành";
            ThongKeGVThamGiaGD report = new ThongKeGVThamGiaGD();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, ngay, ngayIn, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bảng thống kê thanh toán tiền giảng mới (21-10-2015)
        public void InThongKeThanhToanTienGiangTheoHocKy_BUH2(string truong, string hieuTruong, string namhoc, string hocky, string dot, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng thống kê thanh toán tiền giảng";
            BangThanhToanTienGiangVuotGioTheoHK_NH report = new BangThanhToanTienGiangVuotGioTheoHK_NH();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, hieuTruong, namhoc, hocky, dot, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bảng kê vượt giờ giảng CLC BUH
        public void InBangKeVuotGioGiangCLC(string truong, string namhoc, string hocky, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê danh sách thanh toán thù lao bổ sung";
            rptBangKeVuotGioCLC report = new rptBangKeVuotGioCLC();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namhoc, hocky, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In danh sách giảng viên được sử dụng trợ giảng
        public void InDanhSachGiangVienDuocSuDungTroGiang(string truong, string namhoc, string hocky, DataTable tb)
        {
            Text = "Thống kê danh sách thanh toán thù lao bổ sung";
            rptDanhSachGiangVienDuocSuDungTroGiang report = new rptDanhSachGiangVienDuocSuDungTroGiang();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namhoc, hocky, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bảng thanh toán giờ vượt chuẩn các hoạt động của giảng viên cơ hữu các khoa
        public void InThongKeTongHopVHU(string truong, string namHoc, string nguoiLapBieu, string banGiamHieu, string keToan, DateTime ngayIn, DataTable tb)
        {
            Text = "Thống kê danh sách thanh toán thù lao bổ sung";
            BangThanhToanVuotGioChuanCuaGVCH report = new BangThanhToanVuotGioChuanCuaGVCH();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, nguoiLapBieu, banGiamHieu, keToan, ngayIn, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê danh sách thanh toán thù lao bổ sung
        public void InDanhSachThanhToanThuLaoBoSung(string tenTruong, string namHoc, string hocKy, string loaiGiangVien, string banGiamHieu, string nguoiKeToan,
            string phongToChucCanBo, string phongDaoTao, string nguoiLapBieu, DataTable vList, DateTime ngayIn)
        {
            Text = "Thống kê danh sách thanh toán thù lao bổ sung";
            DsThanhToanThuLaoBoSung report = new DsThanhToanThuLaoBoSung();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, loaiGiangVien, banGiamHieu, nguoiKeToan, phongToChucCanBo, phongDaoTao, nguoiLapBieu, vList, ngayIn);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê chi tiết số tiết coi thi của giảng viên IUH
        public void InThongKeCongViecKhongPhuHop(string _truong, string _tuNgay, string _denNgay, DateTime _ngayIn, string _nguoiLapBieu, DataTable tb)
        {
            Text = "Thống kê chi tiết số tiết coi thi của giảng viên";
            ThongKeCongViecKhongPhuHopCuaGV report = new ThongKeCongViecKhongPhuHopCuaGV();
            XReport = report;
            OpenLayout(report);
            report.InitData(_truong, _tuNgay, _denNgay, _ngayIn, _nguoiLapBieu, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê khối lượng giảng dạy theo bộ môn
        public void InThongKeKhoiLuongGiangDayTheoBoMon(string truong, string namhoc, string hocky, DateTime ngayin, DataTable tbl)
        {
            Text = "Thống kê tổng số tiết thực giảng của từng giảng viên";
            rptThongKeKhoiLuongGiangDayTheoBoMon report = new rptThongKeKhoiLuongGiangDayTheoBoMon();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namhoc, hocky, ngayin, tbl);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê tổng số tiết thực giảng của từng giảng viên IUH
        public void InThongKeTongSoTietThucGiangCuaTungGiangVienTheoNgay(string _truong, string _namHoc, string _hocKy, string _nguoiLapBieu, DateTime _ngayIn, DataTable tb)
        {
            Text = "Thống kê tổng số tiết thực giảng của từng giảng viên";
            ThongKeTongSoTietThucGiangCuaTungGiangVienTheoNgay report = new ThongKeTongSoTietThucGiangCuaTungGiangVienTheoNgay();
            XReport = report;
            OpenLayout(report);
            report.InitData(_truong, _namHoc, _hocKy, _nguoiLapBieu, _ngayIn, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền giảng chi tiết GV thỉnh giảng sau đại học
        public void InThongKeThanhToanThuLaoChiTietGVThinhGiang_SDH(string truong, string namHoc, string hocKy, string loaiGiangVien, string khoa, string nganh, string nguoiLapBieu, string phongDaoTao, string banGiamHieu, DateTime _ngayIn, DataTable data)
        {
            Text = "Tổng hợp thanh toán thù lao";
            rptThanhToanTienGiangDay_ThinhGiang_SDH report = new rptThanhToanTienGiangDay_ThinhGiang_SDH();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, hocKy, loaiGiangVien, khoa, nganh, nguoiLapBieu, phongDaoTao, banGiamHieu, _ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền giảng chi tiết GV cơ hữu sau đại học
        public void InThongKeThanhToanThuLaoChiTietGVCoHuu_SDH(string truong, string namHoc, string hocKy, string loaiGiangVien, string khoa, string nganh, string nguoiLapBieu, string phongDaoTao, string banGiamHieu, DateTime _ngayIn, DataTable data)
        {
            Text = "Tổng hợp thanh toán thù lao";
            rptThanhToanTienGiangDay_CoHuu_SDH report = new rptThanhToanTienGiangDay_CoHuu_SDH();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, hocKy, loaiGiangVien, khoa, nganh, nguoiLapBieu, phongDaoTao, banGiamHieu, _ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In TOng hop thanh toan thu lao theo khoa
        public void InTongHopThanhToanThuLaoTheoKhoa_SDH(string truong, string namHoc, string hocKy, string loaiGiangVien, string lanChot, string nguoiLapBieu, string phongDaoTao, DateTime _ngayIn, DataTable data)
        {
            Text = "Tổng hợp thanh toán thù lao";
            rptTongHopThanhToanThuLao_SDH report = new rptTongHopThanhToanThuLao_SDH();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, hocKy, loaiGiangVien, lanChot, nguoiLapBieu, phongDaoTao, _ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In TOng hop thanh toan thu lao theo khoa mau 2
        public void InTongHopThanhToanThuLaoTheoKhoaMau2_SDH(string truong, string namHoc, string hocKy, string loaiGiangVien, string lanChot, string nguoiLapBieu, string phongDaoTao, DateTime _ngayIn, DataTable data)
        {
            Text = "Tổng hợp thanh toán thù lao";
            rpnTongHopThanhToanThuLaoMau2_SDH report = new rpnTongHopThanhToanThuLaoMau2_SDH();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, hocKy, loaiGiangVien, lanChot, nguoiLapBieu, phongDaoTao, _ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền ra đề giáo viên CBKG, HDDH CTIM
        public void InThongKeThanhToanTienRaDeCBKGHDDH(string namhoc, string hocky, string khoabomon, string phongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, string loaigiangvien, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền ra đề CBKG, HDDH";
            BangKeThanhToanTienRaDeThiCuaGVHopDongDaiHan report = new BangKeThanhToanTienRaDeThiCuaGVHopDongDaiHan();
            XReport = report;
            OpenLayout(report);
            report.InitData(namhoc, hocky, khoabomon, phongdaotao, phongketoan, hieutruong, nguoilapbieu, khoahoc, bacdaotao, loaigiangvien, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền ra đề giáo viên thỉnh giảng CTIM
        public void InThongKeThanhToanTienRaDeGVThinhGiang(string namhoc, string hocky, string khoabomon, string phongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền ra đề giáo viên thỉnh giảng";
            BangKeThanhToanTienRaDeThiCuaGVThinhGiang report = new BangKeThanhToanTienRaDeThiCuaGVThinhGiang();
            XReport = report;
            OpenLayout(report);
            report.InitData(namhoc, hocky, khoabomon, phongdaotao, phongketoan, hieutruong, nguoilapbieu, khoahoc, bacdaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền chấm bài CBKG, HDDH CTIM
        public void InThongKeThanhToanTienChamBaiCBKGHDDH(string namhoc, string hocky, string khoabomon, string phongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, string loaigiangvien, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền chấm bài CBKG HDDH";
            BangKeThanhToanTienChamBaiCuaCBKiemGiang report = new BangKeThanhToanTienChamBaiCuaCBKiemGiang();
            XReport = report;
            OpenLayout(report);
            report.InitData(namhoc, hocky, khoabomon, phongdaotao, phongketoan, hieutruong, nguoilapbieu, khoahoc, bacdaotao, loaigiangvien, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion


        #region In thống kê thanh toán tiền chấm bài giáo viên thỉnh giảng CTIM
        public void InThongKeThanhToanTienChamBaiGVThinhGiang(string namhoc, string hocky, string khoabomon, string phongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền chấm bài giáo viên thỉnh giảng";
            BangKeThanhToanTienChamBaiCuaGVThinhGiang report = new BangKeThanhToanTienChamBaiCuaGVThinhGiang();
            XReport = report;
            OpenLayout(report);
            report.InitData(namhoc, hocky, khoabomon, phongdaotao, phongketoan, hieutruong, nguoilapbieu, khoahoc, bacdaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        
        #region In thống kê giờ thực giảng đã quy đổi IUH
        public void InThongKeGioThucGiangDaQuyDoi(string _truong, string _tuNgay, string _denNgay, string _nguoiLapBieu, string _loaiGiangVien, string _hieuTruong, string _keToan, DateTime _ngayIn, DataTable tb)
        {
            Text = "Thống kê giờ thực giảng đã quy đổi";
            ThongKeGioThucGiangDaQuyDoi report = new ThongKeGioThucGiangDaQuyDoi();
            XReport = report;
            OpenLayout(report);
            report.InitData(_truong, _tuNgay, _denNgay, _nguoiLapBieu, _loaiGiangVien, _hieuTruong, _keToan, _ngayIn, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê tổng số tiết coi thi của giảng viên theo khoa IUH
        public void InThongKeTongSoTietCoiThiTheoKhoa(string _truong, string _tuNgay, string _denNgay, string _nguoiLapBieu, DateTime _ngayIn, DataTable tb)
        {
            Text = "Thống kê tổng số tiết coi thi của giảng viên theo khoa";
            ThongKeTongSoTietCoiThiCuaGVTheoKhoa report = new ThongKeTongSoTietCoiThiCuaGVTheoKhoa();
            XReport = report;
            OpenLayout(report);
            report.InitData(_truong, _tuNgay, _denNgay, _nguoiLapBieu, _ngayIn, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê chi tiết số tiết coi thi của giảng viên IUH
        public void InThongKeThanhTraCoiThiChiTietTheoNgay(string _truong, string _tuNgay, string _denNgay, string _nguoiLapBieu, DateTime _ngayIn, DataTable tb)
        {
            Text = "Thống kê chi tiết số tiết coi thi của giảng viên";
            ThongKeChiTietSoTietCoiThiCuaGV report = new ThongKeChiTietSoTietCoiThiCuaGV();
            XReport = report;
            OpenLayout(report);
            report.InitData(_truong, _tuNgay, _denNgay, _nguoiLapBieu, _ngayIn, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê tổng số tiết thực giảng của giảng viên theo khoa IUH
        public void InThongKeTongHopTheoHocKyMaDonVi(string _truong, string _namHoc, string _hocKy, string _nguoiLapBieu, DateTime _ngayIn, DataTable tb)
        {
            Text = "Thống kê tổng số tiết thực giảng của giảng viên theo khoa";
            ThongKeTongSoTietThucGiangCuaGVTheoKhoa report = new ThongKeTongSoTietThucGiangCuaGVTheoKhoa();
            XReport = report;
            OpenLayout(report);
            report.InitData(_truong, _namHoc, _hocKy, _nguoiLapBieu, _ngayIn, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê tổng số tiết thực giảng của từng giảng viên IUH
        public void InThongKeTongSoTietThucGiangCuaTungGiangVien(string _truong, string _namHoc, string _hocKy, string _nguoiLapBieu, DateTime _ngayIn, DataTable tb)
        {
            Text = "Thống kê tổng số tiết thực giảng của từng giảng viên";
            ThongKeTongSoTietThucGiangCuaTungGiangVien report = new ThongKeTongSoTietThucGiangCuaTungGiangVien();
            XReport = report;
            OpenLayout(report);
            report.InitData(_truong, _namHoc, _hocKy, _nguoiLapBieu, _ngayIn, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê chi tiết số tiết thực giảng của từng giảng viên IUH
        public void InThongKeChiTietThucGiangTungGiangVien(string _truong, string _tuNgay, string _denNgay, string _nguoiLapBieu, DateTime _ngayIn, DataTable tb)
        {
            Text = "Thống kê chi tiết số tiết thực giảng của từng giảng viên";
            ThongKeChiTietSoTietThucGiangCuaTungGiangVien report = new ThongKeChiTietSoTietThucGiangCuaTungGiangVien();
            XReport = report;
            OpenLayout(report);
            report.InitData(_truong, _tuNgay, _denNgay, _nguoiLapBieu, _ngayIn, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In kiểm tra giờ coi thi IUH
        public void InKiemTraGioCoiThi(string _truong, string _tuNgay, string _denNgay, string _dayNha, DateTime _ngayIn, DataTable tb)
        {
            Text = "Kiểm tra giờ coi thi";
            KiemTraGioCoiThi report = new KiemTraGioCoiThi();
            XReport = report;
            OpenLayout(report);
            report.InitData(_truong, _tuNgay, _denNgay, _dayNha, _ngayIn, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In kiểm tra giờ thực giảng IUH
        public void InKiemTraGioThucGiang(string truong, string tungay, string denngay, string daynha, DateTime ngayin, DataTable tb)
        {
            Text = "Thanh tra theo ngày";
            KiemTraGioThucGiang report = new KiemTraGioThucGiang();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, tungay, denngay, daynha, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region Thống kê thanh toán tiền phụ cấp GDTC
        public void InThongKeThanhToanTienPhuCapGDTC(string truong, string namhoc, string hocky, string nguoilapbieu, string kiemsoat, DateTime ngayin, DataTable tb)
        {
            Text = "Chi tiết khối lượng giảng dạy của giảng viên thỉnh giảng";
            rptThanhToanPhuCapGDTC report = new rptThanhToanPhuCapGDTC();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namhoc, hocky, nguoilapbieu, kiemsoat, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion  

        #region Thống kê giảng viên thiếu tiết
        public void InThongKeGiangVienThieuTiet(string tenTruong, string namHoc, string hocKy, string phongToChucCanBo, string phongDaoTao, string nguoiLapBieu, DataTable data)
        {
            Text = "Chi tiết khối lượng giảng dạy của giảng viên thỉnh giảng";
            rptThongKeGiangVienThieuTiet report = new rptThongKeGiangVienThieuTiet();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, phongToChucCanBo, phongDaoTao, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion  

        #region In ket qua thanh toan thu lao toan truong UTE
        public void InDanhSachThanhToanThuLaoToanTruong(string tenTruong, string namHoc, string hocKy, string phongToChucCanBo, string phongDaoTao, string nguoiLapBieu, DataTable data)
        {
            Text = "Chi tiết khối lượng giảng dạy của giảng viên thỉnh giảng";
            rptDanhSachThanhToanThuLaoToanTruong report = new rptDanhSachThanhToanThuLaoToanTruong();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, phongToChucCanBo, phongDaoTao, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion  

        #region In hợp đồng mới giảng môn học IUH
        public void InHopDongMoiGiangMonHocIUH(ViewDanhSachHopDongThinhGiang _objHopDong, DateTime _ngayIn, string _nguoiDaiDien, string _tenChucVu, GiangVien _objGiangVien, string _coSo, string _diaChiCoSo, string _tenLop)
        {
            Text = "Chi tiết khối lượng giảng dạy của giảng viên thỉnh giảng";
            HopDongMoiGiangMonHocReport report = new HopDongMoiGiangMonHocReport();
            XReport = report;
            OpenLayout(report);
            report.InitData(_objHopDong, _ngayIn, _nguoiDaiDien, _tenChucVu, _objGiangVien, _coSo, _diaChiCoSo, _tenLop);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion  

        #region In danh sách chi tiền cán bộ cơ hữu vượt giờ
        public void InDanhSachChiTienCanBoCoHuuVuotGio(string tenTruong, string namHoc, string hocKy, string phongToChucCanBo, string phongDaoTao, string nguoiLapBieu, DataTable data)
        {
            Text = "Chi tiết khối lượng giảng dạy của giảng viên thỉnh giảng";
            rptDanhSachChiTienCanBoCoHuuVuotGio report = new rptDanhSachChiTienCanBoCoHuuVuotGio();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, phongToChucCanBo, phongDaoTao, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion  

        #region In thống kê thanh toán tiền giảng TTTN giảng viên hợp đồng dài hạn CTIM
        public void InThongKeThanhToanTienGiangTTTNGiangVienHopDongDaiHan(string tentruong, string namhoc, string hocky, string khoabomon, string truongphongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền giảng lý thuyết giảng viên thỉnh giảng";
            rptThanhToanGiangDayTTTNGiangVienHopDongDaiHanCTIM report = new rptThanhToanGiangDayTTTNGiangVienHopDongDaiHanCTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, khoabomon, truongphongdaotao, phongketoan, hieutruong, nguoilapbieu, khoahoc, bacdaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê tổng hợp giờ giảng cơ hữu BUH
        public void InThongKeTongHopGioGiangCoHuuBUH(string tentruong, string namhoc, string hocky, string nguoilapbieu, string truongnguoiKeToan, string hieutruong, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê tong hop gio giang";
            rptThongKeTongHopGioGiangCoHuuBUH report = new rptThongKeTongHopGioGiangCoHuuBUH();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, nguoilapbieu, truongnguoiKeToan, hieutruong, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê chi tiết gio giang co huu BUH
        public void InThongKeChiTietGioGiangCoHuuBUH(string matruong, string tentruong, string namhoc, string hocky, string bacdaotao, string nguoilapbieu, string truongphongdaotao, DateTime ngayin, string loaigiangvien, DataTable tb)
        {
            Text = "Thống kê chi tiết gio giang co huu";
            rptThongKeChiTietKLGDCoHuuBUH report = new rptThongKeChiTietKLGDCoHuuBUH();
            XReport = report;
            OpenLayout(report);
            report.InitData(matruong, tentruong, namhoc, hocky, bacdaotao, nguoilapbieu, truongphongdaotao, ngayin, loaigiangvien, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bảng kê giờ giảng BUH
        public void InBangKeGioGiangBUH(string namhoc, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng tổng hợp thù lao";
            rptBangKeGioGiang_BUH report = new rptBangKeGioGiang_BUH();
            XReport = report;
            OpenLayout(report);
            report.InitData(namhoc, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bảng thống kê số tiết nghĩa vụ của giảng viên UEL
        public void InThongKeSoTietNghiaVuGiangVien_UEL(string truong)
        {
            Text = "Bảng thống kê thanh toán tiền giảng";
            rptInGioChuanNghiaVu_UEL report = new rptInGioChuanNghiaVu_UEL();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion


        #region In bảng thống kê thanh toán tiền giảng
        public void InThongKeThanhToanTienGiangTheoHocKy_BUH(string hieuTruong, string namhoc, string hocky, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng thống kê thanh toán tiền giảng";
            rptThongKeThanhToanTienGiangTheoHocKy_BUH report = new rptThongKeThanhToanTienGiangTheoHocKy_BUH();
            XReport = report;
            OpenLayout(report);
            report.InitData(hieuTruong, namhoc, hocky, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion


        #region In Hợp đồng mời giảng dạy nhóm môn học thực tập cuối khoá
        public void InHopDongMoiGiangDayNhomMonThucTapCuoiKhoa(string diachi, string dienthoai, string dongia, string donvicongtac, string hochamhocvi, string masothunhap, string noicapcmnd, string nganhanggv, string ngaybdgiangday, string ngaycapcmndgv, string ngayktgiangday, string socmndgv, string sotaikhoangv, string tengv, string tentruongkhoa
            , decimal tonggiatrihd, string tonggiatrihdbangchu, int tongtietthucday, string truong, string chucvutruongkhoa, string chucvudaidienbenA, string chucvu02daidienbenA, string nguoidaidienbenA, string diachidaidienbenA, string dienthoaidaidienbenA, string faxdaidienbenA, DateTime ngayin, DataTable tb)
        {
            Text = "Hợp đồng mời giảng dạy nhóm môn học thực tập cuối khoá";
            rptHopDongMoiGiangDayNhomMonThucTapCuoiKhoa report = new rptHopDongMoiGiangDayNhomMonThucTapCuoiKhoa();
            XReport = report;
            OpenLayout(report);
            report.InitData(diachi, dienthoai, dongia, donvicongtac, hochamhocvi, masothunhap, noicapcmnd, nganhanggv, ngaybdgiangday, ngaycapcmndgv, ngayktgiangday, socmndgv, sotaikhoangv, tengv, tentruongkhoa, tonggiatrihd, tonggiatrihdbangchu, tongtietthucday, truong, chucvutruongkhoa, chucvudaidienbenA, chucvu02daidienbenA, nguoidaidienbenA, diachidaidienbenA, dienthoaidaidienbenA, faxdaidienbenA, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê cán bộ nhân viên theo ngày
        public void InThongKeCanBoNhanVienTheoNgay(string namhoc, string ngaynhanbaocao, string _maTruong, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng thống kê cán bộ nhân viên theo ngày";
            rptThongKeCanBoNhanVienTheoNgay report = new rptThongKeCanBoNhanVienTheoNgay();
            XReport = report;
            OpenLayout(report);
            report.InitData(namhoc, ngaynhanbaocao, _maTruong, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê danh sách giảng viên cơ hữu
        public void InThongKeDanhSachGiangVienCoHuu(string tentruong, string namhoc, string ngaynhanbaocao, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng thống kê cán bộ nhân viên theo ngày";
            rptThongKeDanhSachGiangVienCoHuu report = new rptThongKeDanhSachGiangVienCoHuu();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, ngaynhanbaocao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê số lượng giảng viên cơ hữu theo khoa bộ môn
        public void InThongKeSoLuongGiangVienCoHuuTheoKhoaBoMon(string tentruong, string namhoc, string ngaynhanbaocao, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng thống kê cán bộ nhân viên theo ngày";
            rptThongKeSoLuongGiangVienCoHuuTheoKhoaBoMon report = new rptThongKeSoLuongGiangVienCoHuuTheoKhoaBoMon();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, ngaynhanbaocao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê số lượng giảng viên theo khoa bộ môn
        public void InThongKeSoLuongGiangVienTheoKhoaBoMon(string namhoc, string ngaynhanbaocao, string _maTruong, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng thống kê cán bộ nhân viên theo ngày";
            rptThongKeSoLuongGiangVienTheoKhoaBoMon report = new rptThongKeSoLuongGiangVienTheoKhoaBoMon();
            XReport = report;
            OpenLayout(report);
            report.InitData(namhoc, ngaynhanbaocao, _maTruong, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In dự toán kinh phí giang dạy VHU
        public void InDuToanKinhPhiGiangDay(string tentruong, string namhoc, string hocky, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng dự toán kinh phí giảng dạy";
            rptDuToanKinhPhiGiangDay_Vhu report = new rptDuToanKinhPhiGiangDay_Vhu();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thanh toán vượt giờ định mức giảng viên cơ hữu
        public void InThanhToanVuotGioDinhMucGiangVienCoHuu(string tentruong, string namhoc, string phongdaotao, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng thanh toán giờ vượt định mức của giảng viên";
            rptThanhToanVuotGioDinhMucGiangVienCoHuu report = new rptThanhToanVuotGioDinhMucGiangVienCoHuu();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, phongdaotao, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Bang thanh toan thù lao giảng dạy theo khoa
        public void InBangThanhToanThuLaoGiangDayTheoKhoa(string tentruong, string tenkhoa, string namhoc, string hocky, string phongdaotao, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng thanh toán thù lao giảng dạy theo khoa";
            rptBangThanhToanThuLaoGiangDayTheoKhoa report = new rptBangThanhToanThuLaoGiangDayTheoKhoa();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, tenkhoa, namhoc, hocky, phongdaotao, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Bang thanh toan giờ vượt định mức của giảng viên
        public void InBangThanhToanGioVuotDinhMucCuaGiangVien(string tentruong, string namhoc, string hocky, string phongdaotao, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng thanh toán giờ vượt định mức của giảng viên";
            rptBangThanhToanGioVuotDinhMucCuaGiangVien report = new rptBangThanhToanGioVuotDinhMucCuaGiangVien();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, phongdaotao, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thanh toán thù lao giảng dạy đợt 2
        public void InThanhToanThuLaoDot2(string truong, string namhoc, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Thanh toán thù lao giảng dạy đợt 2";
            rptThanhToanThuLaoDot2 report = new rptThanhToanThuLaoDot2();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namhoc, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thanh toán tạm ứng đợt 1
        public void InThanhToanTamUngDot1(string truong, string namhoc, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Thanh toán tạm ứng đợt 1";
            rptThanhToanTamUngDot1 report = new rptThanhToanTamUngDot1();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namhoc, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In tổng hợp khối lượng giảng dạy theo năm
        public void InTongHopKhoiLuongGiangDayTheoNam(string truong, string namHoc, string hocKy, string loaiGiangVien, string lanChot, string nguoiLapBieu, string phongDaoTao, DataTable data)
        {
            Text = "Tổng hợp khối lượng giảng dạy theo năm";
            rptThongKeTongHopKhoiLuongGD_Kcq report = new rptThongKeTongHopKhoiLuongGD_Kcq();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, hocKy, loaiGiangVien, lanChot, nguoiLapBieu, phongDaoTao, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê dự trù cả năm theo giảng viên trước thời khoá biểu
        public void InThongKeDuTruCaNamCuaGiangVienTruocTKB(string tentruong, string namhoc, string hieutruong, string phongdaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng kê dự trù cả năm theo giảng viên trước thời khoá biểu";
            rptThongKeDuTruCaNamTheoGiangVien report = new rptThongKeDuTruCaNamTheoGiangVien();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hieutruong, phongdaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Hợp đồng mời giảng dạy
        public void InHopDongMoiGiangDay(string diachi, string dienthoai, string dongia, string donvicongtac, string hochamhocvi, string masothunhap, string noicapcmnd, string nganhanggv, string ngaybdgiangday, string ngaycapcmndgv, string ngayktgiangday, string socmndgv, string sotaikhoangv, string tengv, string tentruongkhoa, decimal tonggiatrihd, string tonggiatrihdbangchu, int tongtietthucday, string truong, string chucvutruongkhoa, string daidienbenA, string chucvudaidienbenA, string chucvu02daidienbenA, string diachidaidienbenA, string dienthoaidaidienbenA, string faxdaidienbenA, DateTime ngayin, DataTable tb)
        {
            Text = "Hợp đồng mời giảng dạy";
            rptHopDongMoiGiangDay report = new rptHopDongMoiGiangDay();
            XReport = report;
            OpenLayout(report);
            report.InitData(diachi, dienthoai, dongia, donvicongtac, hochamhocvi, masothunhap, noicapcmnd, nganhanggv, ngaybdgiangday, ngaycapcmndgv, ngayktgiangday, socmndgv, sotaikhoangv, tengv, tentruongkhoa, tonggiatrihd, tonggiatrihdbangchu, tongtietthucday, truong, chucvutruongkhoa, daidienbenA, chucvudaidienbenA, chucvu02daidienbenA, diachidaidienbenA, dienthoaidaidienbenA, faxdaidienbenA, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Hợp đồng mời giảng dạy CTIM
        public void InHopDongMoiGiangDay_CTIM(string diachi, string dienthoai, string dongia, string donvicongtac, string hochamhocvi, string masothunhap, string noicapcmnd, string nganhanggv, string ngaybdgiangday, string ngaycapcmndgv, string ngayktgiangday, string socmndgv, string sotaikhoangv, string tengv, string tentruongkhoa, decimal tonggiatrihd, string tonggiatrihdbangchu, int tongtietthucday, string truong, string chucvutruongkhoa, string daidienbenA, string chucvudaidienbenA, string chucvu02daidienbenA, string diachidaidienbenA, string dienthoaidaidienbenA, string faxdaidienbenA, DateTime ngayin, DataTable tb)
        {
            Text = "Hợp đồng mời giảng dạy";
            rptHopDongMoiGiangDay_CTIM report = new rptHopDongMoiGiangDay_CTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(diachi, dienthoai, dongia, donvicongtac, hochamhocvi, masothunhap, noicapcmnd, nganhanggv, ngaybdgiangday, ngaycapcmndgv, ngayktgiangday, socmndgv, sotaikhoangv, tengv, tentruongkhoa, tonggiatrihd, tonggiatrihdbangchu, tongtietthucday, truong, chucvutruongkhoa, daidienbenA, chucvudaidienbenA, chucvu02daidienbenA, diachidaidienbenA, dienthoaidaidienbenA, faxdaidienbenA, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Hợp đồng mời giảng dạy CTIM
        public void InThanhLyHopDongMoiGiangDay_CTIM(string diachi, string dienthoai, string dongia, string donvicongtac, string hochamhocvi, string masothunhap, string noicapcmnd, string nganhanggv, string ngaybdgiangday, string ngaycapcmndgv, string ngayktgiangday, string socmndgv, string sotaikhoangv, string tengv, string tentruongkhoa, decimal tonggiatrihd, string tonggiatrihdbangchu, int tongtietthucday, string truong, string chucvutruongkhoa, string daidienbenA, string chucvudaidienbenA, string chucvu02daidienbenA, string diachidaidienbenA, string dienthoaidaidienbenA, string faxdaidienbenA, DateTime ngayin, DataTable tb)
        {
            Text = "Hợp đồng mời giảng dạy";
            rptThanhLyHopDongGiangDay_CTIM report = new rptThanhLyHopDongGiangDay_CTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(diachi, dienthoai, dongia, donvicongtac, hochamhocvi, masothunhap, noicapcmnd, nganhanggv, ngaybdgiangday, ngaycapcmndgv, ngayktgiangday, socmndgv, sotaikhoangv, tengv, tentruongkhoa, tonggiatrihd, tonggiatrihdbangchu, tongtietthucday, truong, chucvutruongkhoa, daidienbenA, chucvudaidienbenA, chucvu02daidienbenA, diachidaidienbenA, dienthoaidaidienbenA, faxdaidienbenA, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Hợp đồng mời giảng dạy VHU
        public void InHopDongMoiGiangDay_VHU(DataTable tb)
        {
            Text = "Hợp đồng mời giảng dạy";
            rptHopDongMoiGiangDay_VHU report = new rptHopDongMoiGiangDay_VHU();
            XReport = report;
            OpenLayout(report);
            report.InitData(tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bang chi tien co van - Không chính quy
        public void InBangChiTienCoVan_Kcq(string truong, string nguoiKeToan, string nguoilapbang, string tPDaoTao, string tuade, DataTable vList)
        {
            Text = "Bảng chi tiền cố vấn";
            BangChiTienCoVanHocTapReport_Kcq report = new BangChiTienCoVanHocTapReport_Kcq();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, nguoiKeToan, nguoilapbang, tPDaoTao, tuade, vList);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bang tong hop chi tien co van - Không chính quy
        public void InBangTongHopChiTienCoVan_Kcq(string truong, string keToan, string namHocHocKy, string maTruong, VList<ViewTongHopChiTienCoVan> vList)
        {
            Text = "Bảng tổng hợp chi tiền cố vấn";
            BangTongHopChiTienCoVanHocTapReport_Kcq report = new BangTongHopChiTienCoVanHocTapReport_Kcq();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, keToan, namHocHocKy, maTruong, vList);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In co van hoc tap them nam hoc - khoa - Không chính quy
        public void InCoVanHocTapTheoNamHocKhoaDonVi_Kcq(string truong, string namHoc, string donVi, int tongSoCoVan, int tongSoSinhVien, string nguoiLapBieu, DataTable data)
        {
            Text = "Cố vấn học tập theo nam học và Khoa";
            rptCoVanHocTapTheoNamHocKhoaDonVi_Kcq report = new rptCoVanHocTapTheoNamHocKhoaDonVi_Kcq();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, donVi, tongSoCoVan, tongSoSinhVien, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thong ke danh sach lop sinh vien da co va chua co CVHT - Không chính quy
        public void InDanhSachLopCoVanHocTapTheoHocKy_Kcq(string truong, string namHoc, string hocKy, string donVi, string nguoiLapBieu, DataTable data)
        {
            Text = "Danh sách lớp sinh viên - cố vấn học tập";
            rptLopSinhVienCoVanHocTapTheoNamHoc_Kcq report = new rptLopSinhVienCoVanHocTapTheoNamHoc_Kcq();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, hocKy, donVi, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thanh toan thu la theo khoa - Không chính quy
        public void InThanhToanThuLaoTheoKhoa_Kcq(string truong, string khoa, string loaiGiangVien, string namHoc, string hocKy, string nguoiLapBieu, TList<UteThanhToanThuLao> data)
        {
            Text = "Thanh toán thù lao theo khoa";
            rptThanhToanThuLaoTheoKhoaUTE_Kcq report = new rptThanhToanThuLaoTheoKhoaUTE_Kcq();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, khoa, loaiGiangVien, namHoc, hocKy, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thanh toan thu lao khoiluong khac - Không chính quy
        public void InThanhToanThuLaoKhoiLuongKhac_Kcq(string truong, string khoa, string loaiGiangVien, string namHoc, string hocKy, string nguoiLapBieu, DataTable data)
        {
            Text = "Thanh toán thù lao khối lượng khác";
            rptThanhToanThuLaoKhoiLuongKhac_Kcq report = new rptThanhToanThuLaoKhoiLuongKhac_Kcq();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, khoa, loaiGiangVien, namHoc, hocKy, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In danh sach thong tin giang vien - Không chính quy
        public void InDanhSachGiangVien_Kcq(string maTruong, string truong, string khoa, string nguoiLapBieu, DataTable data)
        {
            Text = "Danh sách thông tin giảng viên";
            rptDanhSachGiangVien_Kcq report = new rptDanhSachGiangVien_Kcq();
            //Sub1_NhiemVuGiangDay report = new Sub1_NhiemVuGiangDay();
            XReport = report;
            OpenLayout(report);
            report.InitData(maTruong, truong, khoa, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bảng thanh toán giờ giảng đợt 4
        public void BangThanhToanGioGiangDot4(string tenTruong, string namHoc, string hocKy, string tenDot, string phongDaoTao, string nguoiLapBieu, DateTime ngayIn, DataTable data)
        {
            Text = "Bảng thanh toán giờ giảng đợt 4";
            rptBangThanhToanGioGiangDot4 report = new rptBangThanhToanGioGiangDot4();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, tenDot, phongDaoTao, nguoiLapBieu, ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion 

        #region In bảng thống kê giờ chuẩn DLU
        public void BangThongKeGioChuanDLU(string tenTruong, string namHoc, string hocKy, string tenDot, string phongDaoTao, string nguoiLapBieu, DateTime ngayIn, DataTable data)
        {
            Text = "Bảng thống kê giờ chuẩn";
            rptBangThongKeVuotGioGiangDLU report = new rptBangThongKeVuotGioGiangDLU();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, tenDot, phongDaoTao, nguoiLapBieu, ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In lịch sử nghiên cứu khoa học của giảng viên
        public void InLichSuNCKHCuaGiangVien(string tentruong, string tungay, string denngay, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Lịch sử nghiên cứu khoa học của giảng viên";
            rptLichSuNghienCuuKhoaHocCuaTungGiangVien report = new rptLichSuNghienCuuKhoaHocCuaTungGiangVien();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, tungay, denngay, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thực hiện NCKH của giảng viên
        public void InThongKeThucHienNCKH(string tentruong, string namhoc, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng thống kê thực hiện NCKH của giảng viên";
            rptThongKeThucHienNCKH report = new rptThongKeThucHienNCKH();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Trích xuất thông tin giảng viên theo chuyên môn trình độ
        public void InTrichXuatThongTinGiangVienTheoChuyenMonTrinhDo(string tentruong, string namhoc, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Trích xuất thông tin giảng viên theo chuyên môn trình độ";
            rptTrichXuatThongTinGiangVienTheoChuyenMonTrinhDo report = new rptTrichXuatThongTinGiangVienTheoChuyenMonTrinhDo();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion


        #region Thống kê chi tiết dự trù giờ giảng khi đã có LHP nhưng chưa có TKB
        public void InThongKeChiTietDuTruGioGiangKhiDaCoLHPNhungChuaCoTKB(string tentruong, string tenkhoa, string namhoc, string hocky, string hieutruong, string phongdaotao, string truongkhoa, DateTime ngayin, DataTable dt)
        {
            Text = "Bảng thống kê chi tiết dự trù giờ giảng khi đã có lớp học phần nhưng chưa có thời khóa biểu";
            rptThongKeChiTietDuTruKhiDaCoLHPNhungChuaCoTKB report = new rptThongKeChiTietDuTruKhiDaCoLHPNhungChuaCoTKB();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, tenkhoa, namhoc, hocky, hieutruong, phongdaotao, truongkhoa, ngayin, dt);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In dự trù giờ giảng khi đã có LHP nhưng chưa có TKB
        public void InThongKeDuTruTruocGioGiangKhiDaCoLHPNhungChuaCoTKB(string truong, string namhoc, string nguoiLapBieu, DateTime ngayin, DataTable dt)
        {
            Text = "In thống kê dự trù giờ giảng khi đã có lớp học phần nhưng chưa có thời khóa biểu";
            rptThongKeDuTruKhiDaCoLHPNhungChuaCoTKB rpt = new rptThongKeDuTruKhiDaCoLHPNhungChuaCoTKB();
            XReport = rpt;
            OpenLayout(rpt);
            rpt.InitData(truong, namhoc, nguoiLapBieu, ngayin, dt);
            printControl.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
        #endregion

        #region Dự trù giờ giảng khi đã có LHP nhưng chưa có TKB
        public void InDuTruGioGiangKhiDaCoLHPNhungChuaCoTKB(string truong, string namhoc, string hocky, string nguoiLapbieu, DateTime ngayin, DataTable dt)
        {
            Text = "In dự trù giò giảng chi tiết khi đã có lớp học phần nhưng chưa có thời khóa biểu";
            rptDuTruKhiDaCoLHPNhungChuaCoTKB rpt = new rptDuTruKhiDaCoLHPNhungChuaCoTKB();
            XReport = rpt;
            OpenLayout(rpt);
            rpt.InitData(truong, namhoc, hocky, nguoiLapbieu, ngayin, dt);
            printControl.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
        #endregion

        #region In thống kê thanh tra theo giảng viên
        public void InThongKeThanhTraTheoGiangVien(string truong, string tungay, string denngay, string nguoiLapBieu, DataTable data)
        {
            Text = "Thống kê thanh tra theo giảng viên";
            rptThongKeThanhTraTheoGiangVien report = new rptThongKeThanhTraTheoGiangVien();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, tungay, denngay, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Thống kê tổng hợp giờ giảng theo khoa CDGTVT
        public void InThongKeTongHopGioGiangTheoKhoa_CDGTVT(string tentruong, string namhoc, string hieutruong, string phongdaotao, string loaigiangvien, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng thống kê chi tiết giờ giảng trước TKB";
            rptThongKeTongHopGioGiangTheoKhoa_CDGTVT report = new rptThongKeTongHopGioGiangTheoKhoa_CDGTVT();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc , hieutruong, phongdaotao, loaigiangvien, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region Thống kê chi tiết dự trù giờ giảng trước TKB
        public void InThongKeChiTietDuTruGioGiangTruocTKB(string tentruong, string tenKhoa, string namhoc, string hocky, string hieutruong, string phongdaotao, string truongkhoa, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng thống kê chi tiết giờ giảng trước TKB";
            rptThongKeChiTietDuTruGioGiangTruocTKB report = new rptThongKeChiTietDuTruGioGiangTruocTKB();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, tenKhoa, namhoc, hocky, hieutruong, phongdaotao, truongkhoa, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion


        #region In thống kê chi tiết KLGD CDGTVT mẫu 2
        public void InThongKeChiTietKhoiLuongGiangDayCDGTVTMau2(string tentruong, string tenKhoa, string namhoc, string hocky, string hieutruong, string phongdaotao, string truongkhoa, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng thống kê chi tiết giờ giảng";
            rptThongKeChiTiet_Mau2_CDGTVT report = new rptThongKeChiTiet_Mau2_CDGTVT();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, tenKhoa, namhoc, hocky, hieutruong, phongdaotao, truongkhoa, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In dự trù giờ giảng trước LHP
        public void InThongKeDuTruTruocGioGiangTruocLHP(string truong, string namhoc, string nguoiLapBieu, DateTime ngayin, DataTable dt)
        {
            Text = "In thống kê dự trù giờ giảng trước lớp học phần";
            rptThongKeDuTruGioGiangTruocLHP rpt = new rptThongKeDuTruGioGiangTruocLHP();
            XReport = rpt;
            OpenLayout(rpt);
            rpt.InitData(truong, namhoc, nguoiLapBieu, ngayin, dt);
            printControl.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
        #endregion

        #region Dự trù giờ giảng chi tiết trước khi có lớp học phần
        public void InDuTruGioGiangChiTietTruocKhiCoLopHocPhan(string truong, string namhoc, string hocky, string nguoiLapbieu, DateTime ngayin, DataTable dt)
        {
            Text = "In dự trù giò giảng chi tiết trước khi có lớp học phần";
            rptDuTruGioGiangChiTietTruocKhiCoLopHocPhan rpt = new rptDuTruGioGiangChiTietTruocKhiCoLopHocPhan();
            XReport = rpt;
            OpenLayout(rpt);
            rpt.InitData(truong, namhoc, hocky, nguoiLapbieu, ngayin, dt);
            printControl.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
        #endregion

        #region In theo dõi CVHT
        public void InTheoDoiCVHT(string truong, string namhoc, string hocky, string nguoiLapBieu, DateTime ngayin, DataTable dt)
        {
            Text = "In theo dõi CVHT";
            rptTHeoDoiCoVanHocTap rpt = new rptTHeoDoiCoVanHocTap();
            XReport = rpt;
            OpenLayout(rpt);
            rpt.InitData(truong, namhoc, hocky, nguoiLapBieu, ngayin, dt);
            printControl.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
        #endregion

        #region In dự trù giờ giảng theo khoa trước có TKB
        public void InThongKeDuTruGioGiangTruocTKBTheoNam(string truong, string namhoc, string nguoiLapBieu, DateTime ngayin, DataTable dt)
        {
            Text = "In dự trù giờ giảng theo khoa trước có TKB";
            rptThongKeDuTruTruocTKBTheoNam rpt = new rptThongKeDuTruTruocTKBTheoNam();
            XReport = rpt;
            OpenLayout(rpt);
            rpt.InitData(truong, namhoc, nguoiLapBieu, ngayin, dt);
            printControl.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
        #endregion


        #region In dự trù giờ giảng chi tiết trước có TKB
        public void InDuTruGioGiangChiTietTruocTKB(string truong, string namhoc, string hocky, string nguoiLapBieu, DateTime ngayin, DataTable dt)
        {
            Text = "In dự trù giờ giảng chi tiết trước có TKB";
            rptDuTruGioGiangChiTietTruocTKB rpt = new rptDuTruGioGiangChiTietTruocTKB();
            XReport = rpt;
            OpenLayout(rpt);
            rpt.InitData(truong, namhoc, hocky, nguoiLapBieu, ngayin, dt);
            printControl.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
        #endregion

        #region In thống kê hợp đồng theo thời gian
        public void InThongKeHDTheoThoiGian(string truong, string khoa, string nguoiLapBieu, DataTable dt)
        {
            Text = "In thống kê hợp đồng theo thời gian";
            rptThongKeHDTheoThoiGian rpt = new rptThongKeHDTheoThoiGian();
            XReport = rpt;
            OpenLayout(rpt);
            rpt.InitData(truong, khoa, nguoiLapBieu, dt);
            printControl.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
        #endregion

        #region
        public void InThongKeMocTangLuong(string tentruong, string tenkhoa, string nguoilapbieu, DataTable tb)
        {
            Text = "Bảng thống kê mốc tăng lương của giảng viên";
            rptThongKeMocTangLuong report = new rptThongKeMocTangLuong();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, tenkhoa, nguoilapbieu, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }

        #endregion

        #region In thống kê tiền lương dạy thêm giờ CDGTVT
        public void InThongKeTienLuongDayThemGioCDGTVT(string tentruong, string tenKhoa, string namhoc, string hieutruong, string phongdaotao, string truongkhoa, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng kê tiền lương dạy thêm giờ";
            rptThongKeTienLuongDayThemGio_CDGTVT report = new rptThongKeTienLuongDayThemGio_CDGTVT();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, tenKhoa, namhoc, hieutruong, phongdaotao, truongkhoa, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion


        #region In thống kê chi tiết KLGD CDGTVT
        public void InThongKeChiTietKhoiLuongGiangDayCDGTVT(string tentruong, string tenKhoa, string namhoc, string hocky, string hieutruong, string phongdaotao, string truongkhoa, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng thống kê chi tiết giờ giảng";
            rptThongKeChiTiet_CDGTVT report = new rptThongKeChiTiet_CDGTVT();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, tenKhoa, namhoc, hocky, hieutruong, phongdaotao, truongkhoa, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê giờ giảng theo lớp
        public void InThongKeGioGiangTheoLopAct(string tentruong, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "In thống kê giờ giảng theo lớp";
            rptThongKeGioGiangTheoLop_ACT report = new rptThongKeGioGiangTheoLop_ACT();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê chi tiền thù lao giảng dạy CDGTVT
        public void InThongKeChiTienThuLaoGiangDayCDGTVT(string tentruong, string tenKhoa, string namhoc, string hocky, string hieutruong, string phongdaotao, string truongkhoa, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng kê chi tiền thù lao giảng dạy";
            rptThongKeChiTienThuLaoGiangDay_CDGTVT report = new rptThongKeChiTienThuLaoGiangDay_CDGTVT();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, tenKhoa, namhoc, hocky, hieutruong, phongdaotao, truongkhoa, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê hồ sơ giảng viên
        public void InThongKeHoSoGiangVien(string tentruong, string tenKhoa, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng kê thanh toán tiền hoàn thành công tác giáo viên chủ nhiệm";
            rptTHongKeHoSoGiangVien report = new rptTHongKeHoSoGiangVien();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, tenKhoa, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }

        #endregion

        #region In thống kê tổng hợp giờ giảng tất cả các khoa CDGTVT
        public void InThongKeTongHopGioGiang_TatCaKhoa_CDGTVT(string tentruong, string namhoc, string hieutruong, string phongdaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng kê tổng hợp giờ giảng tất cả các khoa CDGTVT";
            rptTongHopThanhToanThuLao_TatCaKhoa_CDGTVT report = new rptTongHopThanhToanThuLao_TatCaKhoa_CDGTVT();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hieutruong, phongdaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê tổng hợp giờ giảng CDGTVT
        public void InThongKeTongHopGioGianCDGTVT(string tentruong, string tenKhoa, string namhoc, string hieutruong, string phongdaotao, string truongkhoa, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng kê thanh toán tiền hoàn thành công tác giáo viên chủ nhiệm";
            rptTongHopThanhToanThuLao_CDGTVT report = new rptTongHopThanhToanThuLao_CDGTVT();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, tenKhoa, namhoc, hieutruong, phongdaotao, truongkhoa, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In báo cáo thống kê tổ chức bộ máy, chất lượng cán bộ, công chức các cơ quan
        public void InBaoCaoThongKeToChucBoMay(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "In báo cáo thống kê tổ chức bộ máy, chất lượng cán bộ, công chức các cơ quan";
            ThongKe report = new ThongKe();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In báo cáo thống kê trình độ chuyên môn và thâm niên giảng dạy
        public void InBaoCaoThongKeTrinhDoChuyenMonVaThamNienGiangDay(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "In báo cáo thống kê trình độ chuyên môn và thâm niên giảng dạy";
            TKTrinhDoChuyenMonVaThamNienGD report = new TKTrinhDoChuyenMonVaThamNienGD();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In báo cáo thống kê đội ngũ cán bộ quản lý, nhân viên nghiệp vụ
        public void InBaoCaoThongKeDoiNguCanBoQuanLyNhanVienNghiepVu(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "In báo cáo thống kê đội ngũ cán bộ quản lý, nhân viên nghiệp vụ";
            TKDoiNguCanBoQuanLy_NVNghiepVu report = new TKDoiNguCanBoQuanLy_NVNghiepVu();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In báo cáo thống kê đội ngũ cán bộ quản lý, nhân viên nghiệp vụ của các trường chuyên nghiệp
        public void InBaoCaoThongKeDoiNguCanBoQuanLyNhanVienNghiepVuCacTruongChuyenNghiep(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "In báo cáo thống kê đội ngũ cán bộ quản lý, nhân viên nghiệp vụ của các trường chuyên nghiệp";
            TKDoiNguCanBoQuanLy_NVNghiepVuCuaCacTruongChuyenNghiep report = new TKDoiNguCanBoQuanLy_NVNghiepVuCuaCacTruongChuyenNghiep();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion


        #region In báo cáo thống kê trình độ nghiệp vụ sư phạm, tin học, ngoại ngữ, chính trị
        public void InBaoCaoThongKeTrinhDoNghiepVuSuPhamTinHocNgoaiNguChinhTri(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "Báo cáo thống kê trình độ nghiệp vụ sư phạm, tin học, ngoại ngữ, chính trị";
            TKTrinhDoNVSP_TH_NN_CT report = new TKTrinhDoNVSP_TH_NN_CT();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In báo cáo thống kê trình độ nghiệp vụ sư phạm, tin học, ngoại ngữ
        public void InBaoCaoThongKeTrinhDoNghiepVuSuPhamTInHocNgoaiNgu(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "Báo cáo thống kê trình độ nghiệp vụ sư phạm, tin học, ngoại ngữ";
            TKTrinhDoNVSP_TH_NN report = new TKTrinhDoNVSP_TH_NN();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In báo cáo thống kê đội ngũ giảng viên, giáo viên dạy nghề
        public void InBaoCaoTHongKeDoiNguGiangVienGiaoVienDayNghe(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "Báo cáo thống kê đội ngũ giảng viên, giáo viên dạy nghề";
            BCTKDoiNguGVDayNghe report = new BCTKDoiNguGVDayNghe();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In báo cáo chất lượng cán bộ, công chức
        public void InBaoCaoChatLuongCanBoCongChuc(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "Báo cáo chất lượng cán bộ, công chức";
            BCChatLuongCanBo_CongChuc report = new BCChatLuongCanBo_CongChuc();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê đội ngũ cán bộ quản lý trong cơ sở dạy nghề
        public void InThongKeDoiNguCanBoQuanLyTrongCoSoDayNghe(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "Thống kê đội ngũ cán bộ quản lý trong cơ sở dạy nghề";
            TKDoiNguCanBoQLTrongCSDayNghe report = new TKDoiNguCanBoQLTrongCSDayNghe();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion


        #region In báo cáo số lượng, chất lượng, cơ cấu đội ngũ viên chức
        public void InBaoCaoSoLuongChatLuongCoCauDoiNguVienChuc(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "Báo cáo số lượng, chất lượng, cơ cấu đội ngũ viên chức";
            BCSLCL_CoCauDoiNguVienChuc report = new BCSLCL_CoCauDoiNguVienChuc();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion


        #region In báo cáo chất lượng cán bộ
        public void InBaoCaoChatLuongCanBo(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "Báo cáo chất lượng cán bộ";
            BCChatLuongCanBo report = new BCChatLuongCanBo();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In báo cáo danh sách giảng viên giảng dạy chính quy
        public void InDanhSachGiangVienGiangDayChinhQuy(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "Báo cáo danh sách giảng viên giảng dạy chính quy";
            DSGiangVienChinh report = new DSGiangVienChinh();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion


        #region In báo cáo thống kê kết quả đào tạo, bồi dưỡng nâng cao
        public void InBaoCaoThongKeKetQuaDaoTaoTaoBoiDuong(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "Báo cáo thống kê kết quả đào tạo, bồi dưỡng nâng cao";
            BCThongKeKQDT_BoiDuongNangCaoCLNguonNhanLuc report = new BCThongKeKQDT_BoiDuongNangCaoCLNguonNhanLuc();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        public void InBaoCaoDynamid(string reportname,string fileName,DataTable dt)
        {

            Text = reportname;
            XtraReport report = new XtraReport();
            report.LoadLayout(fileName);

            XReport = report;
            OpenLayout(report);
            //report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();

        }

        #region In báo cáo số lượng và chất lượng viên chức
        public void InBaoCaoSoLuongVaChatLuongVienChuc(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "Báo cáo số lượng và chất lượng viên chức";
            BCSoLuongVaChatLuongVienChuc report = new BCSoLuongVaChatLuongVienChuc();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In báo cáo trình độ chuyên môn nghiệp vụ
        public void InBaoCaoTrinhDoChuyenMonNghiepVu(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "Báo cáo trình độ chuyên môn nghiệp vụ";
            BCTrinhDoChuyenMonNghiepVu report = new BCTrinhDoChuyenMonNghiepVu();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In danh sách cán bộ giảng viên
        public void InDanhSachCanBoGiangVien(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "Hồ sơ giảng viên";
            DanhSachCBGV report = new DanhSachCBGV();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In hồ sơ giảng viên
        public void InHoSoGiangVien(string tentruong, DateTime ngayin, string nam, DataTable tb)
        {
            Text = "Hồ sơ giảng viên";
            HoSoGiangVien report = new HoSoGiangVien();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, ngayin, nam, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Danh sách cán bộ giảng viên
        public void InDanhSachCanBoGiangVien(string tentruong, string namhoc, string hocky, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Danh sách cán bộ giảng viên";
            DanhSachCBGV report = new DanhSachCBGV();
            XReport = report;
            OpenLayout(report);
            //report.InitData(tentruong, namhoc, hocky, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Tổng hợp IUH
        public void InThongKeTongHopTahnhToanIUH(string tentruong,  string namhoc, string hocky, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng tổng hợp thù lao";
            rptTongHopThuLaoIUH report = new rptTongHopThuLaoIUH();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bảng kê thanh toán tiền CVHT CTIM
        public void InThongKeThanhToanTienCVHT_CTIM(string tentruong, string bacdaotao, string namhoc, string hocky, string khoahoc, string hieutruong, string phongtaivu, string phongCTHSSV, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Bảng kê thanh toán tiền hoàn thành công tác giáo viên chủ nhiệm";
            rptBangKeThanhToanTienCoVanHocTap_CTIM report = new rptBangKeThanhToanTienCoVanHocTap_CTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, bacdaotao, namhoc, hocky, khoahoc, hieutruong, phongtaivu, phongCTHSSV, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê tổng hợp thanh toán giờ giảng ACT
        public void InThongKeTongHopThanhToanGioGiangACT(string namhoc, string hocky, string tentruong, string khoadonvi, string tengiangvien, string trinhdo, string masothue
            , float tietnghiavugiangday, float tietnghiavucongtackhac, string namhoctruoc, string hockytruoc, float tongtietgiangday
            , float tongtietcongtackhac, float dongiagiangday, float dongiacongtackhac, float hesothamnien, float nogiogiangkytruoc, float nogiokhackytruoc, int maloaigiangvien
            , DateTime ngayIn, DataTable tb, DataTable tblNCKH, DataTable tblCongTacKhac)
        {
            Text = "In thống kê tổng hợp thanh toán giờ giảng ACT";
            BangThanhToanTongHopQuyDoiTietChuan report = new BangThanhToanTongHopQuyDoiTietChuan();
            XReport = report;
            OpenLayout(report);
            report.InitData(namhoc, hocky, tentruong, khoadonvi, tengiangvien, trinhdo, masothue
                , tietnghiavugiangday, tietnghiavucongtackhac, namhoctruoc, hockytruoc, tongtietgiangday
                , tongtietcongtackhac, dongiagiangday, dongiacongtackhac, hesothamnien, nogiogiangkytruoc, nogiokhackytruoc, maloaigiangvien
                , ngayIn, tb, tblNCKH, tblCongTacKhac);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion
        
        #region In thống kê tổng hợp thanh toán vượt giờ GVCH
        public void InThongKeTongHopThanhToanVuotGioGVCH(string donvilap, string namhoc, string bacdaotao, string khoadonvi, string hieutruong, string ketoan, string daotao, string nguoilap, string chucvubangiamhieu, string chucvuketoan, string chucvudaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê tổng hợp thanh toán vượt giờ GVCH";
            rptTongHopThanhToanVuotGioGVCH report = new rptTongHopThanhToanVuotGioGVCH();
            XReport = report;
            OpenLayout(report);
            report.InitData(donvilap, namhoc, bacdaotao, khoadonvi, hieutruong, ketoan, daotao, nguoilap, chucvubangiamhieu, chucvuketoan, chucvudaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê nhận xét hoàn thành giờ giảng GVCH
        public void InThongKeNhanXetDanhGiaVuotGio(string khoadonvi, string namhoc, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê nhận xét hoàn thành giờ giảng GVCH";
            rptThongKeNhanXetDanhGiaVuotGioGVCH report = new rptThongKeNhanXetDanhGiaVuotGioGVCH();
            XReport = report;
            OpenLayout(report);
            report.InitData(khoadonvi, namhoc, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền giảng thực hành môn GDTC giảng viên CBKG CTIM
        public void InThongKeThanhToanTienGiangGDTCCBKGHDDH(string tentruong, string namhoc, string hocky, string khoabomon, string truongphongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, string chucvubangiamhieu, string chucvuketoan, string chucvudaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền giảng thực hành môn GDTC giảng viên kiêm giảng và HĐDH";
            rptThanhToanGiangDayGDTCCanBoKiemGiangHddhCTIM report = new rptThanhToanGiangDayGDTCCanBoKiemGiangHddhCTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, khoabomon, truongphongdaotao, phongketoan, hieutruong, nguoilapbieu, khoahoc, bacdaotao, chucvubangiamhieu, chucvuketoan, chucvudaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền giảng thực hành môn GDTC giảng viên HDDH CTIM
        public void InThongKeThanhToanTienGiangGDTCHDDH(string tentruong, string namhoc, string hocky, string khoabomon, string truongphongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, string chucvubangiamhieu, string chucvuketoan, string chucvudaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền giảng thực hành môn GDTC giảng viên HĐDH";
            rptThanhToanGiangDayGDTCHopDongDaiHanCTIM report = new rptThanhToanGiangDayGDTCHopDongDaiHanCTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, khoabomon, truongphongdaotao, phongketoan, hieutruong, nguoilapbieu, khoahoc, bacdaotao, chucvubangiamhieu, chucvuketoan, chucvudaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền giảng thực hành môn GDTC giảng viên thỉnh giảng CTIM
        public void InThongKeThanhToanTienGiangThucHanhGDTCGiangVienThinhGiang(string tentruong, string namhoc, string hocky, string khoabomon, string truongphongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, string chucvubangiamhieu, string chucvuketoan, string chucvudaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền giảng thực hành môn GDTC giảng viên thỉnh giảng";
            rptThanhToanGiangDayGDTCGiangVienThinhGiangCTIM report = new rptThanhToanGiangDayGDTCGiangVienThinhGiangCTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, khoabomon, truongphongdaotao, phongketoan, hieutruong, nguoilapbieu, khoahoc, bacdaotao, chucvubangiamhieu, chucvuketoan, chucvudaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In chi tiền cố vấn học tập
        public void InChiTienCoVanHocTapCTIM(string truong, string namhoc, string hocky, string khoadonvi, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán thù lao chấm bài";
            rptChiTienCoVanHocTapCTIM report = new rptChiTienCoVanHocTapCTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namhoc, hocky, khoadonvi, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán thù lao chấm bài
        public void InThongKeThanhToanThuLaoChamBai(string truong, string matruong, string namhoc, string hocky, string loaigiangvien, string hieutruong, string nguoiKeToan, string phongkhaothi, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán thù lao chấm bài";
            rptThanhToanThuLaoChamBai report = new rptThanhToanThuLaoChamBai();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, matruong, namhoc, hocky, loaigiangvien, hieutruong, nguoiKeToan, phongkhaothi, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thẩm định luận văn thạc sỹ
        public void InThongKeThamDinhLuanVanThacSy(string tentruong, string namHoc, string hocKy, string nguoilapbieu, string tpSDH, DateTime ngayIn, DataTable tb)
        {
            Text = "Thống kê thẩm định luận văn thạc sỹ";
            rptThanhToanThuLaoThamDinhLuanVanThacSy report = new rptThanhToanThuLaoThamDinhLuanVanThacSy();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namHoc, hocKy, nguoilapbieu, tpSDH, ngayIn, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê xét duyệt luận văn cao học
        public void InThongKeXetDuyetLuanVanCaoHoc(string tentruong, string namHoc, string hocKy, string hieuTruong, string nguoiLapBieu, DateTime ngayIn, DataTable tb)
        {
            Text = "Thống kê xét duyệt luận văn cao học";
            rptThongKeXetDuyetDeCuongLuanVanCaoHoc report = new rptThongKeXetDuyetDeCuongLuanVanCaoHoc();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namHoc, hocKy, hieuTruong, nguoiLapBieu, ngayIn, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thù lao hướng dẫn cuối khoá
        public void InThongKeThuLaoHuongDanCuoiKhoa(string matruong, string tentruong, string namHoc, string hocKy, string loaiGiangVien, string hieuTruong, string nguoiLapBieu, DateTime ngayIn, DataTable tb)
        {
            Text = "Thống kê thù lao hướng dẫn cuối khoá";
            rptThongKeThuLaoHuongDanCuoiKhoa report = new rptThongKeThuLaoHuongDanCuoiKhoa();
            XReport = report;
            OpenLayout(report);
            report.InitData(matruong, tentruong, namHoc, hocKy, loaiGiangVien, hieuTruong, nguoiLapBieu, ngayIn, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền giảng vượt giờ cửa giảng viên cơ hữu
        public void InThongKeThanhToanTienGiangVuotGioGiangVienCoHuu(string namhoc, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền giảng thực vượt giờ cửa giảng viên cơ hữu";
            rptThanhToanThuLaoVuotGioGiangVienCoHuu report = new rptThanhToanThuLaoVuotGioGiangVienCoHuu();
            XReport = report;
            OpenLayout(report);
            report.InitData(namhoc, nguoilapbieu, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền giảng thực hành CBKG CTIM
        public void InThongKeThanhToanTienGiangThucHanhCBKGHDDH(string tentruong, string namhoc, string hocky, string khoabomon, string truongphongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, string chucvubangiamhieu, string chucvuketoan, string chucvudaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền giảng thực hành CBKG HDDH";
            rptThanhToanGiangDayThucHanhCanBoKiemGiangHddhCTIM report = new rptThanhToanGiangDayThucHanhCanBoKiemGiangHddhCTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, khoabomon, truongphongdaotao, phongketoan, hieutruong, nguoilapbieu, khoahoc, bacdaotao, chucvubangiamhieu, chucvuketoan, chucvudaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền giảng thực hành HĐDH CTIM
        public void InThongKeThanhToanTienGiangThucHanhHDDH(string tentruong, string namhoc, string hocky, string khoabomon, string truongphongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, string chucvubangiamhieu, string chucvuketoan, string chucvudaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền giảng thực hành HĐDH";
            rptThanhToanGiangDayThucHanhHopDongDaiHanCTIM report = new rptThanhToanGiangDayThucHanhHopDongDaiHanCTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, khoabomon, truongphongdaotao, phongketoan, hieutruong, nguoilapbieu, khoahoc, bacdaotao, chucvubangiamhieu, chucvuketoan, chucvudaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền giảng lý thuyết CBKG CTIM
        public void InThongKeThanhToanTienGiangLyThuyetCBKGHDDH(string tentruong, string namhoc, string hocky, string khoabomon, string truongphongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, string chucvubangiamhieu, string chucvuketoan, string chucvudaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền giảng lý thuyết CBKG HDDH";
            rptThanhToanGiangDayLyThuyetCanBoKiemGiangHddhCTIM report = new rptThanhToanGiangDayLyThuyetCanBoKiemGiangHddhCTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, khoabomon, truongphongdaotao, phongketoan, hieutruong, nguoilapbieu, khoahoc, bacdaotao, chucvubangiamhieu, chucvuketoan, chucvudaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền TTTN CBKG CTIM
        public void InThongKeThanhToanTienTTTNCBKGHDDH(string tentruong, string namhoc, string hocky, string khoabomon, string truongphongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền giảng lý thuyết CBKG HDDH";
            rptThanhToanGiangDayTTTNCanBoKiemGiangHddhCTIM report = new rptThanhToanGiangDayTTTNCanBoKiemGiangHddhCTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, khoabomon, truongphongdaotao, phongketoan, hieutruong, nguoilapbieu, khoahoc, bacdaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền giảng lý thuyết HDDH CTIM
        public void InThongKeThanhToanTienGiangLyThuyetHDDH(string tentruong, string namhoc, string hocky, string khoabomon, string truongphongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, string chucvubangiamhieu, string chucvuketoan, string chucvudaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền giảng lý thuyết HDDH";
            rptThanhToanGiangDayLyThuyetHopDongDaiHanCTIM report = new rptThanhToanGiangDayLyThuyetHopDongDaiHanCTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, khoabomon, truongphongdaotao, phongketoan, hieutruong, nguoilapbieu, khoahoc, bacdaotao, chucvubangiamhieu, chucvuketoan, chucvudaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền giảng thực hành giảng viên thỉnh giảng CTIM
        public void InThongKeThanhToanTienGiangThucHanhGiangVienThinhGiang(string tentruong, string namhoc, string hocky, string khoabomon, string truongphongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, string chucvubangiamhieu, string chucvuketoan, string chucvudaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền giảng thực hành giảng viên thỉnh giảng";
            rptThanhToanGiangDayThucHanhGiangVienThinhGiangCTIM report = new rptThanhToanGiangDayThucHanhGiangVienThinhGiangCTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, khoabomon, truongphongdaotao, phongketoan, hieutruong, nguoilapbieu, khoahoc, bacdaotao, chucvubangiamhieu, chucvuketoan, chucvudaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền giảng lý thuyết giảng viên thỉnh giảng CTIM
        public void InThongKeThanhToanTienGiangLyThuyetGiangVienThinhGiang(string tentruong, string namhoc, string hocky, string khoabomon, string truongphongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, string chucdanhbangiamhieu, string chucvuketoan, string chucvudaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền giảng lý thuyết giảng viên thỉnh giảng";
            rptThanhToanGiangDayLyThuyetGiangVienThinhGiangCTIM report = new rptThanhToanGiangDayLyThuyetGiangVienThinhGiangCTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, khoabomon, truongphongdaotao, phongketoan, hieutruong, nguoilapbieu, khoahoc, bacdaotao, chucdanhbangiamhieu, chucvuketoan, chucvudaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê thanh toán tiền giảng TTTN giảng viên thỉnh giảng CTIM
        public void InThongKeThanhToanTienGiangTTTNGiangVienThinhGiang(string tentruong, string namhoc, string hocky, string khoabomon, string truongphongdaotao, string phongketoan, string hieutruong, string nguoilapbieu, string khoahoc, string bacdaotao, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê thanh toán tiền giảng lý thuyết giảng viên thỉnh giảng";
            rptThanhToanGiangDayTTTNGiangVienThinhGiangCTIM report = new rptThanhToanGiangDayTTTNGiangVienThinhGiangCTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, khoabomon, truongphongdaotao, phongketoan, hieutruong, nguoilapbieu, khoahoc, bacdaotao, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê chi tiết gio giang thinh giang UEL
        public void InThongKeChiTietGioGiangThinhGiangUEL(string tentruong, string namhoc, string hocky, string nguoilapbieu, string truongphongdaotao, DateTime ngayin, string loaigiangvien, DataTable tb)
        {
            Text = "Thống kê chi tiết gio giang thinh giang";
            rptThongKeChiTietKLGDThinhGiangUEL report = new rptThongKeChiTietKLGDThinhGiangUEL();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, nguoilapbieu, truongphongdaotao, ngayin, loaigiangvien, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê chi tiết gio giang co huu UEL
        public void InThongKeChiTietGioGiangCoHuuUEL(string matruong, string tentruong, string namhoc, string hocky, string bacdaotao, string nguoilapbieu, string truongphongdaotao, DateTime ngayin, string loaigiangvien, DataTable tb)
        {
            Text = "Thống kê chi tiết gio giang co huu";
            rptThongKeChiTietKLGDCoHuuUEL report = new rptThongKeChiTietKLGDCoHuuUEL();
            XReport = report;
            OpenLayout(report);
            report.InitData(matruong, tentruong, namhoc, hocky, bacdaotao, nguoilapbieu, truongphongdaotao, ngayin, loaigiangvien, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê chi tiết gio giang IUH
        public void InThongKeChiTietGioGiangIUH(string tentruong, string namhoc, string hocky, string nguoilapbieu, string truongphongdaotao, DateTime ngayin, string loaigiangvien, DataTable tb)
        {
            Text = "Thống kê chi tiết giờ giảng IUH";
            rptThongKeChiTietGioGiangIUH report = new rptThongKeChiTietGioGiangIUH();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, nguoilapbieu, truongphongdaotao, ngayin, loaigiangvien, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê tong hop gio giang thinh giang UEL
        public void InThongKeTongHopGioGiangThinhGiangUEL(string tentruong, string namhoc, string hocky, string nguoilapbieu, string truongnguoiKeToan, string hieutruong, DateTime ngayin, string loaigiangvien, DataTable tb)
        {
            Text = "Thống kê tong hop gio giang thinh giang";
            rptThongKeTongHopGioGiangThinhGiangUEL report = new rptThongKeTongHopGioGiangThinhGiangUEL();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, nguoilapbieu, truongnguoiKeToan, hieutruong, ngayin, loaigiangvien, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê tong hop gio giang thinh giang BUH
        public void InThongKeTongHopGioGiangThinhGiangBUH(string tentruong, string namhoc, string hocky, string nguoilapbieu, string truongnguoiKeToan, string hieutruong, DateTime ngayin, string loaigiangvien, DataTable tb)
        {
            Text = "Thống kê tong hop gio giang thinh giang";
            rptThongKeTongHopGioGiangThinhGiangBUH report = new rptThongKeTongHopGioGiangThinhGiangBUH();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, nguoilapbieu, truongnguoiKeToan, hieutruong, ngayin, loaigiangvien, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê tong hop gio giang UEL
        public void InThongKeTongHopGioGiangUEL(string tentruong, string namhoc, string hocky, string loaigiangvien, string nguoilapbieu, string truongnguoiKeToan, string hieutruong, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê tong hop gio giang";
            rptThongKeTongHopGioGiangUEL report = new rptThongKeTongHopGioGiangUEL();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, loaigiangvien, nguoilapbieu, truongnguoiKeToan, hieutruong, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê danh sách cố vấn học tập
        public void InCoVanHocTapTheoNamHocKhoa(string truong, string namhoc, string nguoiLapBieu, bool fullcontrol, string tenkhoa, DataTable data)
        {
            Text = "Thống kê danh sách cố vấn học tập";
            rptThongKeCoVanHocTapTheoNamHocKhoaBoMon report = new rptThongKeCoVanHocTapTheoNamHocKhoaBoMon();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namhoc, nguoiLapBieu, fullcontrol, tenkhoa, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê danh sach thanh tra theo ngày
        public void InThongKeThanhTraTheoNgay(string truong, string tungay, string denngay, string nguoiLapBieu, DataTable data)
        {
            Text = "Thống kê thanh tra theo ngày";
            rptThongKeThanhTraTheoNgay report = new rptThongKeThanhTraTheoNgay();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, tungay, denngay, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê so sánh tiến độ TKB và thanh tra ghi nhận theo ngày
        public void InThongKeThanhTraSoSanhTienDo(string truong, string tungay, string denngay, string nguoiLapBieu, DataTable data)
        {
            Text = "Thống kê so sánh tiến độ TKB và thanh tra ghi nhận theo ngày";
            rptThongKeThanhTraSoSanhTienDo report = new rptThongKeThanhTraSoSanhTienDo();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, tungay, denngay, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In danh sach thanh tra theo ngày
        public void InThanhTraTheoNgay(string truong, string tungay, string denngay, string nguoiLapBieu, DataTable data)
        {
            Text = "Thanh tra theo ngày";
            rptThanhTraTheoNgay report = new rptThanhTraTheoNgay();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, tungay, denngay, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In danh sach thanh tra coi thi theo ngày
        public void InThanhTraCoiThiTheoNgay(string truong, string tungay, string denngay, string nguoiLapBieu, DataTable data)
        {
            Text = "Thanh tra coi thi theo ngày";
            rptThanhTraCoiThi report = new rptThanhTraCoiThi();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, tungay, denngay, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In phieu kiem tra hang ngay
        public void InPhieuKiemTraHangNgay(string tentruong)
        {
            Text = "In phiếu kiểm tra hằng ngày";
            MauThanhTraTheoDoiGiangDay report = new MauThanhTraTheoDoiGiangDay();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thanh tra giang day
        public void InBangThanhTraTinhHinhGiangDay(string tenTruong, string nguoiLapBieu, string tungay, string denngay, VList<ViewThanhTraGiangDay> tlist)
        {
            Text = "In Tổng hợp tình hình giảng dạy của CBGV-NV";
            BangThanhTraGiangDay report = new BangThanhTraGiangDay();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, nguoiLapBieu, tungay, denngay, tlist);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Bang Thanh Tra Giang Day Theo Thang
        public void InBangThanhTraGiangDayTheoThang(string truong, string khoa, string thang, VList<ViewThanhTraGiangDay> list)
        {
            Text = "In bảng thanh tra giảng dạy trong tháng";
            BangThanhTraGiangDayTheoThang report = new BangThanhTraGiangDayTheoThang();
            XReport = report;
            report.InitData(truong, khoa, thang, list);
            OpenLayout(report);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Bang ke khai gio giang cua giang vien
        public void InBangKeKhaiGioGiangCuaGiangVien(string tentruong, string namhoc, string hocky, string tenkhoa, string hoten, string tendonvi, string hocham, string hocvi, string masothue, string sotaikhoan, string chinhanh, string chucvu, bool giangvientrongtruong, DataTable data)
        {
            Text = "Bảng kê khai giờ giảng";
            rptBangKeKhaiGioGiangCuaGiangVien report = new rptBangKeKhaiGioGiangCuaGiangVien();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, tenkhoa, hoten, tendonvi, hocham, hocvi, masothue, sotaikhoan, chinhanh, chucvu, giangvientrongtruong, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion  

        #region In Bang thanh toan thu lao thinh giang theo khoa
        public void InBangThanhToanThuLaoThinhGiangTheoKhoa(string tenTruong, string namHoc, string hocKy, string tenkhoa, string phongDaoTao, string nguoiLapBieu, DataTable data)
        {
            Text = "Bảng thanh toán thù lao giáo viên thỉnh giảng theo khoa";
            rptBangThanhToanThuLaoThinhGiangTheoKhoa report = new rptBangThanhToanThuLaoThinhGiangTheoKhoa();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, tenkhoa, phongDaoTao, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion  

        #region In Bang thanh toan thu lao theo khoa
        public void InBangThanhToanThuLaoTheoKhoa(string tenTruong, string namHoc, string hocKy, string tenkhoa, string phongDaoTao, string nguoiLapBieu, DataTable data)
        {
            Text = "Bảng thanh toán thù lao theo khoa";
            rptBangThanhToanThuLaoTheoKhoa report = new rptBangThanhToanThuLaoTheoKhoa();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, tenkhoa, phongDaoTao, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion  

        #region In ket qua thanh toan thu lao theo thang - giang vien thinh giang
        public void InDanhSachThanhToanThuLaoTheoKhoa(string tenTruong, string namHoc, string hocKy, string phongToChucCanBo, string phongDaoTao, string nguoiLapBieu, DataTable data)
        {
            Text = "Chi tiết khối lượng giảng dạy của giảng viên thỉnh giảng";
            rptDanhSachThanhToanThuLaoTheoKhoa report = new rptDanhSachThanhToanThuLaoTheoKhoa();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, phongToChucCanBo, phongDaoTao, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion 

        #region In ket qua thanh toan thu lao theo thang - giang vien thinh giang
        public void InDanhSachThanhToanThuLaoTheoKhoa_HBU(string tenTruong, string namHoc, string hocKy, string phongToChucCanBo, string phongDaoTao, string nguoiLapBieu, DataTable data)
        {
            Text = "Kết quả thanh toán thù lao";
            rptDanhSachThanhToanThuLaoTheoKhoa_HBU report = new rptDanhSachThanhToanThuLaoTheoKhoa_HBU();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, phongToChucCanBo, phongDaoTao, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion 

        #region In ket qua thanh toan thu lao theo thang - giang vien thinh giang
        public void InDanhSachThanhToanThuLaoTheoNam_HBU(string tenTruong, string namHoc, string hocKy, string phongToChucCanBo, string phongDaoTao, string nguoiLapBieu, DataTable data)
        {
            Text = "Kết quả thanh toán thù lao";
            rptDanhSachThanhToanThuLaoTheoNam_HBU report = new rptDanhSachThanhToanThuLaoTheoNam_HBU();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, phongToChucCanBo, phongDaoTao, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In ket qua tong hop gio giang theo khoa
        public void InBangTongHopGioGiangTheoKhoa_HBU(string tenTruong, string namHoc, string hocKy, string phongDaoTao, string nguoiLapBieu, DateTime ngayIn, DataTable data)
        {
            Text = "Kết quả thanh toán thù lao";
            rptBangTongHopGioGiangToanTruong_HBU report = new rptBangTongHopGioGiangToanTruong_HBU();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, phongDaoTao, nguoiLapBieu, ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In ket qua thanh toan thu lao theo thang - giang vien thinh giang
        public void InDanhSachThanhToanThuLaoTheoBoMon(string tenTruong, string namHoc, string hocKy, string phongToChucCanBo, string phongDaoTao, string nguoiLapBieu, DataTable data)
        {
            Text = "Chi tiết khối lượng giảng dạy của giảng viên thỉnh giảng";
            rptDanhSachThanhToanThuLaoTheoBoMon report = new rptDanhSachThanhToanThuLaoTheoBoMon();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, phongToChucCanBo, phongDaoTao, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion
        
        public void InDanhSachThanhToanThuLaoTapSuTheoBoMon(string tenTruong, string namHoc, string hocKy, string phongToChucCanBo, string phongDaoTao, string nguoiLapBieu, DataTable data)
        {
            Text = "Chi tiết khối lượng giảng dạy của giảng viên thỉnh giảng";
            rptDanhSachThanhToanThuLaoTapSuTheoBoMon report = new rptDanhSachThanhToanThuLaoTapSuTheoBoMon();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, phongToChucCanBo, phongDaoTao, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }

        #region In ket qua thanh toan thu lao theo thang - giang vien thinh giang
        public void InKetQuaThanhToanThuLaoCuaGiangVienThinhGiangTheoThang(string phongDaoTao, string nguoiLapBieu, DataTable data)
        {
            Text = "Chi tiết khối lượng giảng dạy của giảng viên thỉnh giảng";
            rptThanhToanThuLaoCuaGiangVienThinhGiangTheoThang report = new rptThanhToanThuLaoCuaGiangVienThinhGiangTheoThang();
            XReport = report;
            OpenLayout(report);
            report.InitData(phongDaoTao, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In ket qua thanh toan thu lao theo thang - giang vien
        public void InKetQuaThanhToanThuLaoCuaGiangVienTheoThang(string phongDaoTao, string nguoiLapBieu, DataTable data)
        {
            Text = "Chi tiết khối lượng giảng dạy của giảng viên";
            rptThanhToanThuLaoCuaGiangVienTheoThang report = new rptThanhToanThuLaoCuaGiangVienTheoThang();
            XReport = report;
            OpenLayout(report);
            report.InitData(phongDaoTao, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Chi tiet khoi luong giang day
        public void InChiTietKhoiLuongGiangDay(string namhoc, string hocky, string truong, string maGiangVien, string hoTen, string madonvi, string tenDonVi, string hocham, string hocVi, string gioitinh, string thoihanphanhoi, decimal tongtietquydoi, decimal tietgiangday, decimal tietDAMHLA, decimal tietnghiavu, decimal dongiatinh, decimal sotietthieu, decimal tienthieutiet, decimal sotienthuclanh, string nguoiLapBieu, DataTable data)
        {
            Text = "Chi tiết khối lượng giảng dạy của giảng viên";
            rptChiTietKhoiLuongGiangDay report = new rptChiTietKhoiLuongGiangDay();
            XReport = report;
            OpenLayout(report);
            report.InitData(namhoc, hocky, truong, maGiangVien, hoTen, madonvi, tenDonVi, hocham, hocVi, gioitinh, thoihanphanhoi, tongtietquydoi, tietgiangday, tietDAMHLA, tietnghiavu, dongiatinh, sotietthieu, tienthieutiet, sotienthuclanh, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Chi tiet khoi luong giang day HBU
        public void InChiTietKhoiLuongGiangDayHBU(string namhoc, string hocky, string truong, string maGiangVien, string hoTen, string madonvi, string tenDonVi, string hocham, string hocVi, string gioitinh, string thoihanphanhoi, decimal tongtietquydoi, decimal tietgiangday, decimal tietDAMHLA, decimal tietnghiavu, decimal dongiatinh, decimal sotietthieu, decimal tienthieutiet, decimal sotienthuclanh, string nguoiLapBieu, DataTable data)
        {
            Text = "Chi tiết khối lượng giảng dạy của giảng viên";
            rptChiTietKhoiLuongGiangDay_HBU report = new rptChiTietKhoiLuongGiangDay_HBU();
            XReport = report;
            OpenLayout(report);
            report.InitData(namhoc, hocky, truong, maGiangVien, hoTen, madonvi, tenDonVi, hocham, hocVi, gioitinh, thoihanphanhoi, tongtietquydoi, tietgiangday, tietDAMHLA, tietnghiavu, dongiatinh, sotietthieu, tienthieutiet, sotienthuclanh, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Chi tiet khoi luong giang day HBU
        public void InChiTietKhoiLuongGiangDayVHU(string namhoc, string hocky, string truong, string phongtochuccanbo, string phongdaotao, string nguoilapbieu, DataTable data)
        {
            Text = "Chi tiết khối lượng giảng dạy của giảng viên";
            rptChiTietKhoiLuongGiangDay_VHU report = new rptChiTietKhoiLuongGiangDay_VHU();
            XReport = report;
            OpenLayout(report);
            report.InitData(namhoc, hocky, truong, phongtochuccanbo, phongdaotao, nguoilapbieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In co van hoc tap them nam hoc - khoa
        public void InCoVanHocTapTheoNamHocKhoaDonVi(string truong, string namHoc, string donVi, int tongSoCoVan, int tongSoSinhVien, string nguoiLapBieu, DataTable data)
        {
            Text = "Cố vấn học tập theo nam học và Khoa";
            rptCoVanHocTapTheoNamHocKhoaDonVi report = new rptCoVanHocTapTheoNamHocKhoaDonVi();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, donVi, tongSoCoVan, tongSoSinhVien, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thong ke danh sach lop sinh vien da co va chua co CVHT
        public void InDanhSachLopCoVanHocTapTheoHocKy(string truong, string namHoc, string hocKy, string donVi, string nguoiLapBieu, DataTable data)
        {
            Text = "Danh sách lớp sinh viên - cố vấn học tập";
            rptLopSinhVienCoVanHocTapTheoNamHoc report = new rptLopSinhVienCoVanHocTapTheoNamHoc();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, hocKy, donVi, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In TOng hop thanh toan thu lao theo khoa
        public void InTongHopThanhToanThuLaoTheoKhoa(string truong, string namHoc, string hocKy, string loaiGiangVien, string lanChot, string nguoiLapBieu, string phongDaoTao, DataTable data)
        {
            Text = "Tổng hợp thanh toán thù lao";
            rptTongHopThanhToanThuLao report = new rptTongHopThanhToanThuLao();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, hocKy, loaiGiangVien, lanChot, nguoiLapBieu, phongDaoTao, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In TOng hop thanh toan thu lao theo khoa mau 2
        public void InTongHopThanhToanThuLaoTheoKhoaMau2(string truong, string namHoc, string hocKy, string loaiGiangVien, string lanChot, string nguoiLapBieu, string phongDaoTao, DataTable data)
        {
            Text = "Tổng hợp thanh toán thù lao";
            rpnTongHopThanhToanThuLaoMau2 report = new rpnTongHopThanhToanThuLaoMau2();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, hocKy, loaiGiangVien, lanChot, nguoiLapBieu, phongDaoTao, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In TOng hop thanh toan thu lao theo khoa mau 2 HBU
        public void InTongHopThanhToanThuLaoTheoKhoaMau2_HBU(string truong, string namHoc, string hocKy, string loaiGiangVien, string lanChot, string nguoiLapBieu, string phongDaoTao, DataTable data)
        {
            Text = "Tổng hợp thanh toán thù lao (mẫu 2)";
            rpnTongHopThanhToanThuLaoMau2_HBU report = new rpnTongHopThanhToanThuLaoMau2_HBU();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, hocKy, loaiGiangVien, lanChot, nguoiLapBieu, phongDaoTao, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thanh toan thu lao khoiluong khac
        public void InLietKeKhoiLuongGiangDay(string namhoc, string hocky, string truong, string maGiangVien, string hoTen, string madonvi, string tenDonVi, string hocham, string hocVi, string gioitinh, string thoihanphanhoi, decimal tongtietquydoi, decimal tietgiangday, decimal tietDAMHLA, decimal tietnghiavu, decimal dongiatinh, decimal sotietthieu, decimal tienthieutiet, decimal sotienthuclanh, string nguoiLapBieu, DataTable data)
        {
            Text = "Liệt kê khối lượng giảng dạy của giảng viên";
            rptLietKeKhoiLuongGiangDayGiangVien report = new rptLietKeKhoiLuongGiangDayGiangVien();
            XReport = report;
            OpenLayout(report);
            report.InitData(namhoc, hocky, truong, maGiangVien, hoTen, madonvi, tenDonVi, hocham, hocVi, gioitinh, thoihanphanhoi, tongtietquydoi, tietgiangday, tietDAMHLA, tietnghiavu, dongiatinh, sotietthieu, tienthieutiet, sotienthuclanh, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thanh toan thu lao khoiluong khac
        public void InThanhToanThuLaoKhoiLuongKhac(string truong, string khoa, string loaiGiangVien, string namHoc, string hocKy, string nguoiLapBieu, DataTable data)
        {
            Text = "Thanh toán thù lao khối lượng khác";
            rptThanhToanThuLaoKhoiLuongKhac report = new rptThanhToanThuLaoKhoiLuongKhac();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, khoa, loaiGiangVien, namHoc, hocKy, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thanh toan thu la theo khoa
        public void InThanhToanThuLaoTheoKhoa(string truong, string khoa, string loaiGiangVien, string namHoc, string hocKy, string nguoiLapBieu, TList<UteThanhToanThuLao> data)
        {
            Text = "Thanh toán thù lao theo khoa";
            rptThanhToanThuLaoTheoKhoaUTE report = new rptThanhToanThuLaoTheoKhoaUTE();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, khoa, loaiGiangVien, namHoc, hocKy, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In danh sach thong tin giang vien
        public void InDanhSachGiangVien(string maTruong, string truong, string khoa, string nguoiLapBieu, DataTable data)
        {
            Text = "Danh sách thông tin giảng viên";
            rptDanhSachGiangVien report = new rptDanhSachGiangVien();
            //Sub1_NhiemVuGiangDay report = new Sub1_NhiemVuGiangDay();
            XReport = report;
            OpenLayout(report);
            report.InitData(maTruong, truong, khoa, nguoiLapBieu, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In phiếu ghi giờ giảng
        public void InPhieuGhiGioGiang(DataTable data, DataTable subData)
        {
            Text = "Danh sách thông tin giảng viên";
            rptPhieuGhiGioGiang_QNU report = new rptPhieuGhiGioGiang_QNU();
            //Sub1_NhiemVuGiangDay report = new Sub1_NhiemVuGiangDay();
            XReport = report;
            OpenLayout(report);
            report.InitData(data, subData);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thong ke chi tiet giang day cua giang vien theo khoa
        public void InThongKeChiTietGiangDayGiangVienTheoKhoa(string namHoc, string hocKy, string maKhoaDonVi, string truong, string maTruong, DataTable data)
        {
            Text = "Thống kê chi tiết giảng dạy của giảng viên theo khoa";
            rptThongKeChiTietGiangDayGiangVienTheoKhoa report = new rptThongKeChiTietGiangDayGiangVienTheoKhoa();
            XReport = report;
            OpenLayout(report);
            report.InitData(namHoc, hocKy, maKhoaDonVi, truong, maTruong, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region Liet ke khoi luong giang day
        public void InBangLietKeKhoiLuongGiangDay(string truong, string nguoiLapBieu, string namHoc, string hocKy, string donVi, string tenGiangVien, string hocVi, double soTienNghiaVu, double soTienGiangDay, double soTienDAMH, double soTienThucLanh, string soTienBangChu, int tietnghiavu, VList<ViewChiTietKhoiLuong> vList)
        {
            Text = "Liệt kê khối lượng giảng dạy";
            LietKeKhoiLuongGiangDayReport report = new LietKeKhoiLuongGiangDayReport();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, nguoiLapBieu, namHoc, hocKy, donVi, tenGiangVien, hocVi, soTienNghiaVu, soTienGiangDay, soTienDAMH, soTienThucLanh, soTienBangChu, tietnghiavu, vList);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bang tong hop khoi luong giang day quy doi
        public void InBangTongHopKhoiLuongQuyDoi(string namHoc, string hocKy, string truong, string phongDaotao, VList<ViewTongHopQuyDoi> vList)
        {
            Text = "Tổng hợp khối lượng giảng dạy quy đổi";
            TongHopKhoiLuongGiangDayQuyDoiReport report = new TongHopKhoiLuongGiangDayQuyDoiReport();
            XReport = report;
            OpenLayout(report);
            report.InitData(namHoc, hocKy, truong, phongDaotao, vList);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion


        #region In bang chi tiet khoi luong thuc day
        public void InBangChiTietKhoiLuongThucDay(string truong, string phongDT, string namHoc, string hocKy, VList<ViewChiTietKhoiLuongThucDay> vList)
        {
            Text = "Chi tiết khối lượng giảng dạy quy đổi";
            ChiTietKhoiLuongThucDayReport report = new ChiTietKhoiLuongThucDayReport();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, phongDT, namHoc, hocKy, vList);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion


        #region In bang chi tiet khoi luong giang day quy doi
        public void InBangChiTietKhoiLuongQuyDoi(string truong, string phongDT, string namHoc, string hocKy, VList<ViewChiTietQuyDoi> vList)
        {
            Text = "Chi tiết khối lượng giảng dạy quy đổi";
            ChiTietKhoiLuongGiangDayQuyDoiReport report = new ChiTietKhoiLuongGiangDayQuyDoiReport();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, phongDT, namHoc, hocKy, vList);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bang chi tiet khoi luong giang day quy doi
        public void InBangTongHopKhoiLuongThucDay(string truong, string phongDT, string namHoc, string hocKy, VList<ViewKhoiLuongThucDay> vList)
        {
            Text = "Bảng tổng hợp khối lượng thực dạy";
            TongHopKhoiLuongGiangDayThucDayReport report = new TongHopKhoiLuongGiangDayThucDayReport();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, phongDT, namHoc, hocKy, vList);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bang danh sach thu lao giang day
        public void DanhSachThanhToanThuLaoGiangDay(string namHoc, string hocKy, string tenBoMon, string tenLoaiGiangVien, string tenTruong, string phongDaoTao, string phongTCCB, string nguoiKeToan, string banGiamHieu, string nguoiLapBieu, VList<ViewThanhToanThuLao> vList)
        {
            Text = "Danh sách thù lao giảng dạy";
            ThanhToanThuLaoGiangDayReport report = new ThanhToanThuLaoGiangDayReport();
            XReport = report;
            OpenLayout(report);
            report.InitData(namHoc, hocKy, tenBoMon, tenLoaiGiangVien, tenTruong, phongDaoTao, phongTCCB, nguoiKeToan, banGiamHieu, nguoiLapBieu, vList);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bang tong hop chi tien co van
        public void InBangTongHopChiTienCoVan(string truong, string keToan, string namHocHocKy, string maTruong, VList<ViewTongHopChiTienCoVan> vList)
        {
            Text = "Bảng tổng hợp chi tiền cố vấn";
            BangTongHopChiTienCoVanHocTapReport report = new BangTongHopChiTienCoVanHocTapReport();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, keToan, namHocHocKy, maTruong, vList);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bang chi tien co van
        public void InBangChiTienCoVan(string truong, string nguoiKeToan, string nguoilapbang, string tPDaoTao, string tuade, DataTable vList)
        {
            Text = "Bảng chi tiền cố vấn";
            BangChiTienCoVanHocTapReport report = new BangChiTienCoVanHocTapReport();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, nguoiKeToan, nguoilapbang, tPDaoTao, tuade, vList);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In chi tiet khoi luong quy doi
        //public void InBangChiTietKhoiLuongQuyDoi(string truong, string phongDT, string namHoc, string hocKy, VList<ViewChiTietQuyDoi> vList)
        //{
        //    Text = "Chi tiết khối lượng giảng dạy quy đổi";
        //    ChiTietKhoiLuongGiangDayQuyDoiReport report = new ChiTietKhoiLuongGiangDayQuyDoiReport();
        //    XReport = report;
        //    OpenLayout(report);
        //    report.InitData(truong, phongDT, namHoc, hocKy, vList);
        //    printControl.PrintingSystem = report.PrintingSystem;
        //    report.CreateDocument();
        //}
        #endregion

        #region In Phu Troi Nam Hoc
        //public void InPhuTroiNamHoc(string tuade, string tentruong, string namhoctruoc, VList<ViewPhuTroiNamHoc> vlist)
        //{
        //    Text = "In Tổng hợp khối lượng giảng dạy lớp cao đẳng.";
        //    BangPhuTroiGioDay report = new BangPhuTroiGioDay();
        //    XReport = report;
        //    OpenLayout(report);
        //    report.InitData(tuade, tentruong, namhoctruoc, vlist);
        //    printControl.PrintingSystem = report.PrintingSystem;
        //    report.CreateDocument();
        //}
        #endregion

        #region In Tong Hop Phu Troi Nam Hoc Chi Tiet Tung Thang
        //public void InTongHopPhuTroiTheoThang(VList<ViewPhuTroiGioDayTungThang> vlist, DataTable dt, string tentruong, string tuade, string hieutruong, string tpDaoTao)
        //{
        //    Text = "In Tổng hợp khối lượng giảng dạy lớp cao đẳng.";
        //    BangTongHopPhuTroiTheoThang report = new BangTongHopPhuTroiTheoThang();
        //    XReport = report;
        //    OpenLayout(report);
        //    report.InitData(vlist, dt,tentruong,tuade,hieutruong,tpDaoTao);
        //    printControl.PrintingSystem = report.PrintingSystem;
        //    report.CreateDocument();
        //}
        #endregion

        #region Thong ke chuc vu giang vien
        //public void InThongKeChucVuGiangvien(string tentruong,VList<ViewThongKeChucVu> vlist)
        //{
        //    Text = "In Tổng hợp khối lượng giảng dạy lớp cao đẳng.";
        //    ThongKeHoSoChucVuGiangVienReport report = new ThongKeHoSoChucVuGiangVienReport();
        //    XReport = report;
        //    OpenLayout(report);
        //    report.InitData(tentruong, vlist);
        //    printControl.PrintingSystem = report.PrintingSystem;
        //    report.CreateDocument();
        //}
        #endregion

        #region In chi tien gio day giang vien bien che
        //public void InChiTienGioDayGiangVienCD(string tennguoilap, string tentruong, string tuade,string daotao,string hieutruong, VList<ViewChiTienGioDayGiangVien> vlist)
        //{
        //    Text = "In Tổng hợp khối lượng giảng dạy lớp cao đẳng.";
        //    ChiTienGioDayGiangVienBC report = new ChiTienGioDayGiangVienBC();
        //    XReport = report;
        //    OpenLayout(report);
        //    report.InitData(tennguoilap, tentruong, tuade,daotao,hieutruong, vlist);
        //    printControl.PrintingSystem = report.PrintingSystem;
        //    report.CreateDocument();
        //}
        #endregion

        #region In chi tien gio day giang vien
        //public void InChiTienGioDayGiangVienTC(string tennguoilap, string tentruong, string tuade, string daotao,string hieutruong, VList<ViewChiTienGioDayGiangVien> vlist)
        //{
        //    Text = "In Tổng hợp khối lượng giảng dạy lớp trung cấp.";
        //    ChiTienGioDayGiangVien report = new ChiTienGioDayGiangVien();
        //    XReport = report;
        //    OpenLayout(report);
        //    report.InitData(tennguoilap, tentruong, tuade,daotao,hieutruong, vlist);
        //    printControl.PrintingSystem = report.PrintingSystem;
        //    report.CreateDocument();
        //}
        #endregion

        #region In danh sach giang vien
        public void InDanhSachGiangVien(string tentruong, VList<ViewThongTinChiTietGiangVien> vlist)
        {
            Text = "In cấp Account giảng viên";
            ReportDanhSachGiangVien report = new ReportDanhSachGiangVien();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, vlist);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In cap Account
        public void InCapAccount(string tentruong, VList<ViewThongTinGiangVien> vlist)
        {
            Text = "In cấp Account giảng viên";
            ReportInCapAccount report = new ReportInCapAccount();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, vlist);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In hop dong thinh giang
        //  public void InHopDongThinhGiang(string tentruong, ViewGiangVienLichGiang obj)
        //{
        //     //string tentruong, VList<ViewSinhVienLopHocPhan> vList
        //    Text = "Bảng hợp đồng thỉnh giảng";
        //    HopDongThinhGiangReport report = new HopDongThinhGiangReport();
        //    XReport = report;
        //    OpenLayout(report);
        //    report.InitData(tentruong,obj);
        //    printControl.PrintingSystem = report.PrintingSystem;
        //    report.CreateDocument();
        //}
        #endregion


        #region In bang chi tien co van
        //public void InBangChiTienCoVan(string truong, string nguoiKeToan, string nguoilapbang,string tPDaoTao,string tuade, VList<ViewChiTienCoVan> vList)
        //{
        //    Text = "Bảng chi tiền cố vấn";
        //    BangChiTienCoVanHocTapReport report = new BangChiTienCoVanHocTapReport();
        //    XReport = report;
        //    OpenLayout(report);
        //    report.InitData(truong, nguoiKeToan, nguoilapbang, tPDaoTao,tuade, vList);
        //    printControl.PrintingSystem = report.PrintingSystem;
        //    report.CreateDocument();
        //}
        #endregion


        #region In bang danh sach thu lao giang day
        //public void DanhSachThanhToanThuLaoGiangDay(string namHoc, string hocKy, string tenBoMon, string tenLoaiGiangVien, string tenTruong, string phongDaoTao, string phongTCCB, string nguoiKeToan, string banGiamHieu, string nguoiLapBieu, VList<ViewThanhToanThuLao> vList)
        //{
        //    Text = "Danh sách thù lao giảng dạy";
        //    ThanhToanThuLaoGiangDayReport report = new ThanhToanThuLaoGiangDayReport();
        //    XReport = report;
        //    OpenLayout(report);
        //    report.InitData(namHoc,  hocKy,  tenBoMon,  tenLoaiGiangVien,tenTruong, phongDaoTao, phongTCCB, nguoiKeToan, banGiamHieu, nguoiLapBieu,vList);
        //    printControl.PrintingSystem = report.PrintingSystem;
        //    report.CreateDocument();
        //}
        #endregion

        #region In bang tong hop khoi luong giang day quy doi
        //public void InBangTongHopKhoiLuongQuyDoi(string namHoc, string hocKy, string truong, string phongDaotao, VList<ViewTongHopQuyDoi> vList)
        //{
        //    Text = "Tổng hợp khối lượng giảng dạy quy đổi";
        //    TongHopKhoiLuongGiangDayQuyDoiReport report = new TongHopKhoiLuongGiangDayQuyDoiReport();
        //    XReport = report;
        //    OpenLayout(report);
        //    report.InitData( namHoc,hocKy, truong, phongDaotao,vList);
        //    printControl.PrintingSystem = report.PrintingSystem;
        //    report.CreateDocument();
        //}
        #endregion


        #region In bang thu moi giang
        //public void InThuMoiGiang(string tentruong,ViewGiangVienLichGiang obj)
        //{
        //    Text = "Thư mời giảng";
        //    ThuMoiGiangReport report = new ThuMoiGiangReport();
        //    XReport = report;
        //    OpenLayout(report);
        //    report.InitData(tentruong,obj);
        //    printControl.PrintingSystem = report.PrintingSystem;
        //    report.CreateDocument();
        //}
        #endregion

        #region Liet ke khoi luong giang day
        //public void InBangLietKeKhoiLuongGiangDay(string truong, string nguoiLapBieu, string namHoc, string hocKy, string donVi, string tenGiangVien, string hocVi, double soTienNghiaVu, double soTienGiangDay, double soTienDAMH, double soTienThucLanh, string soTienBangChu, VList<ViewChiTietKhoiLuong> vList)
        //{
        //    Text = "Liệt kê khối lượng giảng dạy";
        //    LietKeKhoiLuongGiangDayReport report = new LietKeKhoiLuongGiangDayReport();
        //    XReport = report;
        //    OpenLayout(report);
        //    report.InitData( truong,  nguoiLapBieu,namHoc, hocKy, donVi, tenGiangVien, hocVi,soTienNghiaVu,soTienGiangDay,soTienDAMH,soTienThucLanh,soTienBangChu, vList);
        //    printControl.PrintingSystem = report.PrintingSystem;
        //    report.CreateDocument();
        //}
        #endregion

        #region In bảng kê khai thanh toán tiền giảng của giảng viên
        public void InBangKeKhaiThanhToanTienGiang(string truong, string namHoc, string hoTenGV, string donVi, string chucDanh, string soTietNghiaVu, string donGiaTieuChuan, float dinhMucNCKH, float thucHienNCKH, float heSoVuotDinhMuc, DataTable dt, TList<GiangVienTamUng> listTamUng)
        {
            Text = "Liệt kê khối lượng giảng dạy";
            rptBangKeKhaiThanhToanTienGiang report = new rptBangKeKhaiThanhToanTienGiang();
            XReport = report;
            OpenLayout(report);
            report.InitData(truong, namHoc, hoTenGV, donVi, chucDanh, soTietNghiaVu, donGiaTieuChuan, dinhMucNCKH, thucHienNCKH, heSoVuotDinhMuc, dt, listTamUng);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region Bang ke thu lao BUH
        public void InThongKeChiTietGioGiangBUH(DataSet dsData, DataTable dt, DateTime date)
        {
            Text = "Chi tiết khối lượng giảng dạy của giảng viên ";
            rptBangKeVuotGioGiang report = new rptBangKeVuotGioGiang();
            XReport = report;
            OpenLayout(report);
            report.InitData(dsData, dt, date);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        public void InThongKeTongHopGioGiangBUH(string tentruong, string namhoc, string hocky, string nguoilapbieu, string truongnguoiKeToan, string hieutruong, DateTime ngayin, DataTable tb)
        {
            Text = "Thống kê tong hop gio giang";
            rptThongKeTongHopGioGiangBUH report = new rptThongKeTongHopGioGiangBUH();
            XReport = report;
            OpenLayout(report);
            report.InitData(tentruong, namhoc, hocky, nguoilapbieu, truongnguoiKeToan, hieutruong, ngayin, tb);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }

        #region In thống kê nghiên cứu khoa học
        public void ThongKeNghienCuuKhoaHoc(string tenTruong, string namHoc, string nguoiLapBieu, DateTime ngayIn, DataTable data)
        {
            Text = "Thống kê nghiên cứu khoa học";
            rptThongKeNghienCuuKhoaHoc report = new rptThongKeNghienCuuKhoaHoc();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, nguoiLapBieu, ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Bảng tổng hợp giờ giảng toàn trường theo năm
        public void ThongKeTongHopGioGiangToanTruongTheoNam(string tenTruong, string namHoc, string hocKy, string tenDot, string phongDaoTao, string nguoiLapBieu, DateTime ngayIn, DataTable data)
        {
            Text = "Bảng tổng hợp giờ giảng toàn trường theo năm";
            rptBangTongHopGioGiangToanTruongTheoNam report = new rptBangTongHopGioGiangToanTruongTheoNam();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, tenDot, phongDaoTao, nguoiLapBieu, ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In Bảng tổng hợp giờ giảng toàn trường
        public void ThongKeTongHopGioGiangToanTruong(string tenTruong, string namHoc, string hocKy, string tenDot, string phongDaoTao, string nguoiLapBieu, DateTime ngayIn, DataTable data)
        {
            Text = "Bảng tổng hợp giờ giảng toàn trường";
            rptBangTongHopGioGiangToanTruong report = new rptBangTongHopGioGiangToanTruong();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, tenDot, phongDaoTao, nguoiLapBieu, ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion 

        #region In thống kê giờ giảng theo đợt
        public void ThongKeGioGiangTheoDot(string tenTruong, string namHoc, string hocKy, string tenDot, string phongDaoTao, string nguoiLapBieu, DateTime ngayIn, DataTable data)
        {
            Text = "Thống kê giờ giảng học kỳ - năm học";
            ThongKeGioGiang_DLU report = new ThongKeGioGiang_DLU();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, tenDot, phongDaoTao, nguoiLapBieu, ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion 

        #region In thống kê chi tiết giờ giảng theo năm
        public void ThongKeChiTietGioGiangTheoNam(string tenTruong, string namHoc, string hocKy, string tenDot, string phongDaoTao, string nguoiLapBieu, DateTime ngayIn, DataTable data)
        {
            Text = "Thống kê chi tiết giờ giảng theo năm";
            rptThongKeChiTietGioGiangTheoNam report = new rptThongKeChiTietGioGiangTheoNam();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, tenDot, phongDaoTao, nguoiLapBieu, ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion 

        #region In bảng thống kê giờ coi thi, chấm bài, ra đề
        public void BangThongKeGioCoiThiChamBaiRaDe(string tenTruong, string namHoc, string hocKy, string loaigiangvien, string heDaoTao, string phongDaoTao, string nguoiLapBieu, DateTime ngayIn, DataTable data)
        {
            Text = "Bảng thống kê giờ coi thi, chấm bài, ra đề";
            rptBangThongKeGioCoiThiRaDeChamBai report = new rptBangThongKeGioCoiThiRaDeChamBai();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, loaigiangvien, heDaoTao, phongDaoTao, nguoiLapBieu, ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bảng thống kê giờ coi thi, chấm bài, ra đề theo đơn vị
        //Đơn vị trực thuộc của giảng viên:
        public void BangThongKeGioCoiThiChamBaiRaDeTheoKhoa(string tenTruong, string namHoc, string hocKy, string heDaoTao, string phongDaoTao, string nguoiLapBieu, DateTime ngayIn, DataTable data)
        {
            Text = "Bảng thống kê giờ coi thi, chấm bài, ra đề theo đơn vị trực thuộc";
            rptBangThongKeGioCoiThiRaDeChamBai_TheoKhoa report = new rptBangThongKeGioCoiThiRaDeChamBai_TheoKhoa();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, heDaoTao, phongDaoTao, nguoiLapBieu, ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        //Đơn vị tổ chức thi:
        public void BangThongKeGioCoiThiChamBaiRaDeTheoDonViToChuc(string tenTruong, string namHoc, string hocKy, string heDaoTao, string phongDaoTao, string nguoiLapBieu, DateTime ngayIn, DataTable data)
        {
            Text = "Bảng thống kê giờ coi thi, chấm bài, ra đề theo đơn vị trực thuộc";
            rptBangThongKeGioCoiThiRaDeChamBai_TheoKhoaNhap report = new rptBangThongKeGioCoiThiRaDeChamBai_TheoKhoaNhap();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, heDaoTao, phongDaoTao, nguoiLapBieu, ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In bảng thanh toán giờ giảng học kỳ
        public void BangThanhToanGioGiangHocKy(string tenTruong, string namHoc, string hocKy, string tenDot, string phongDaoTao, string nguoiLapBieu, DateTime ngayIn, DataTable data)
        {
            Text = "Bảng thanh toán giờ giảng học kỳ";
            rptBangThanhToanGioGiangHocKy report = new rptBangThanhToanGioGiangHocKy();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, tenDot, phongDaoTao, nguoiLapBieu, ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion 

        #region In bảng thanh toán giờ giảng cả năm
        public void BangThanhToanGioGiangCaNam(string tenTruong, string namHoc, string hocKy, string tenDot, string phongDaoTao, string nguoiLapBieu, DateTime ngayIn, DataTable data)
        {
            Text = "Bảng thanh toán giờ giảng cả năm";
            rptBangThanhToanGioGiangCaNam report = new rptBangThanhToanGioGiangCaNam();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, tenDot, phongDaoTao, nguoiLapBieu, ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion 

        #region In Bảng kê chi tiết giờ giảng theo đợt
        public void BangKeChiTietGioGioTheoDot(string tenTruong, string namHoc, string hocKy, string tenDot, string phongDaoTao, string nguoiLapBieu, DateTime ngayIn, DataTable data)
        {
            Text = "Bảng kê chi tiết giờ giảng";
            rptThongKeChiTietGioGiangTheoDot report = new rptThongKeChiTietGioGiangTheoDot();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, tenDot, phongDaoTao, nguoiLapBieu, ngayIn, data);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region In thống kê danh sách thanh toán qua ngân hàng
        public void InDanhSachThanhToanQuaNganHang(string tenTruong, string namHoc, string hocKy, string banGiamHieu, string chucvubangiamhieu, string nguoiKeToan
            , string chucvuKHTC, string chucvuketoan, string nguoiLapBieu, DataTable vList, DateTime ngayIn)
        {
            Text = "Thống kê danh sách thanh toán thù lao bổ sung";
            DsThanhToanQuaNganHang_CTIM report = new DsThanhToanQuaNganHang_CTIM();
            XReport = report;
            OpenLayout(report);
            report.InitData(tenTruong, namHoc, hocKy, banGiamHieu, chucvubangiamhieu, nguoiKeToan, chucvuKHTC, chucvuketoan, nguoiLapBieu, vList, ngayIn);
            printControl.PrintingSystem = report.PrintingSystem;
            report.CreateDocument();
        }
        #endregion

        #region Design
        /// <summary>
        /// OpenLayout report
        /// </summary>
        /// <param name="report"></param>
        private void OpenLayout(XtraReport report)
        {
            Type t = report.GetType();
            objReport = DataServices.ReportTemplate.GetByReportId(t.Name);
            if (objReport != null)
                if (objReport.DuLieu != null)
                    XReport.LoadLayout(new MemoryStream(objReport.DuLieu));
            //Hide panel parameter
            foreach (Parameter p in XReport.Parameters)
                p.Visible = false;
        }


        /// <summary>
        /// Get report path
        /// </summary>
        /// <param name="fReport"></param>
        /// <param name="ext"></param>
        /// <returns></returns>
        private static string GetReportPath(XtraReport fReport, string ext)
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string repName = fReport.Name;
            if (repName.Length == 0)
                repName = fReport.GetType().Name;
            string dirName = Path.GetDirectoryName(asm.Location);
            return Path.Combine(dirName, String.Format("{0}.{1}", repName, ext));
        }

        /// <summary>
        /// Show from design
        /// </summary>
        /// <param name="designForm"></param>
        /// <param name="parentForm"></param>
        private static void ShowDesignerForm(Form designForm, Form parentForm)
        {
            designForm.MinimumSize = parentForm.MinimumSize;
            if (parentForm.WindowState == FormWindowState.Normal)
                designForm.Bounds = parentForm.Bounds;
            designForm.WindowState = parentForm.WindowState;
            parentForm.Visible = false;
            designForm.ShowDialog();
            parentForm.Visible = true;
        }

        /// <summary>
        /// Desing report.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesignReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string saveFileName = GetReportPath(XReport, "sav");
                XReport.PrintingSystem.ExecCommand(PrintingSystemCommand.StopPageBuilding);
                XReport.SaveLayout(saveFileName);
                using (XtraReport newReport = XtraReport.FromFile(saveFileName, true))
                {
                    XRDesignFormExBase designForm = new CustomDesignForm();
                    designForm.OpenReport(newReport);
                    designForm.FileName = saveFileName;
                    ShowDesignerForm(designForm, FindForm());
                    if (designForm.FileName != saveFileName && File.Exists(designForm.FileName))
                        File.Copy(designForm.FileName, saveFileName, true);
                    designForm.OpenReport((XtraReport)null);
                    designForm.Dispose();
                }
                if (File.Exists(saveFileName))
                {
                    XReport.LoadLayout(saveFileName);
                    File.Delete(saveFileName);
                    XReport.CreateDocument(true);
                }
                File.Delete(saveFileName);
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Save layout report.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveLayout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Do you want to save the change ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (objReport != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            XReport.SaveLayout(ms);
                            objReport.DuLieu = ms.ToArray();
                            objReport.NgayTao = DateTime.Now.Date;
                            if (objReport.IsValid)
                            {
                                DataServices.ReportTemplate.Update(objReport);
                                XtraMessageBox.Show("This report has been saved successful.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            objReport = new ReportTemplate();
                            objReport.ReportId = XReport.Name;
                            objReport.NgayTao = DateTime.Now.Date;
                            XReport.SaveLayout(ms);
                            objReport.DuLieu = ms.ToArray();
                            if (objReport.IsValid)
                            {
                                DataServices.ReportTemplate.Insert(objReport);
                                XtraMessageBox.Show("This report has been saved successful.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Set default report design.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDefault_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (objReport != null)
                {
                    objReport.DuLieu = null;
                    objReport.NgayTao = DateTime.Now.Date;
                    if (objReport.IsValid)
                    {
                        DataServices.ReportTemplate.Update(objReport);
                        XtraMessageBox.Show("This report has been set default successful.", "Messages", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {

        }
    }
}
#endregion
