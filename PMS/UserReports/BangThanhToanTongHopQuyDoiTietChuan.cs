using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using PMS.Entities;
using PMS.Services;

namespace ReportManager.Reports
{
    public partial class BangThanhToanTongHopQuyDoiTietChuan : DevExpress.XtraReports.UI.XtraReport
    {
        DateTime _NgayIn;
        public BangThanhToanTongHopQuyDoiTietChuan()
        {
            InitializeComponent();
        }

        public void InitData(string namhoc, string hocky, string tentruong, string khoadonvi, string tengiangvien, string trinhdo, string masothue
            , float tietnghiavugiangday, float tietnghiavucongtackhac, string namhoctruoc, string hockytruoc, float tongtietgiangday
            , float tongtietcongtackhac, float dongiagiangday, float dongiacongtackhac, float hesothamnien, float nogiogiangkytruoc, float nogiokhackytruoc
            , int maloaigiangvien, DateTime ngayIn, DataTable tbNhiemVuGiangDay, DataTable tblNCKH, DataTable tblCongTacKhac)
        {

            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky.ToUpper();
            pTruong.Value = tentruong.ToUpper();
            pKhoa.Value = khoadonvi.ToUpper();
            pHoTen.Value = tengiangvien;
            pTrinhDo.Value = trinhdo;
            pMaSoThue.Value = masothue;
            _NgayIn = ngayIn;

            lblNgayIn.Text = "Tp.HCM, ngày " + _NgayIn.ToString("dd") + " tháng " + _NgayIn.ToString("MM") + " năm " + _NgayIn.ToString("yyyy");

            sub1_NhiemVuGiangDay1.InitData(tbNhiemVuGiangDay);

            sub2_NhiemVuNghienCuuKhoaHoc1.InitData(tblNCKH);

            sub3_CongTacKhac1.InitData(tblCongTacKhac);

            float _tietVuotGiangDay, _tietVuotCongTacKhac, _congTietGiangDay, _congTietCongTacKhac, _tongVuotMuc
                , _tongChiPhi, _thueTNCN, _tienthucNhan;
            _congTietGiangDay = tongtietgiangday + nogiogiangkytruoc;
            _congTietCongTacKhac = tongtietcongtackhac + nogiokhackytruoc;
            _tietVuotGiangDay = tongtietgiangday + nogiogiangkytruoc - tietnghiavugiangday;
            _tietVuotCongTacKhac = tongtietcongtackhac + nogiokhackytruoc - tietnghiavucongtackhac;

            if (_tietVuotCongTacKhac < 0)//Nếu tiết vượt mức công tác khác nhỏ hơn 0: tiết thanh toán = vượt mức giờ giảng - vượt mức công tác khác; tổng chi phí = tiết thanh toán x đơn giá giảng dạy
            {
                _tongVuotMuc = _tietVuotGiangDay + _tietVuotCongTacKhac;
                _tongChiPhi = _tongVuotMuc * dongiagiangday * hesothamnien;
            }
            else//ngược lại: tổng chi phí = vượt mức giờ giảng x đơn giá giảng dạy + (vượt mức khác / 2) * đơn giá khác
            {
                ////Nếu thỉnh giảng nhỏ hơn 0 thì ko chia đôi số tiết khác
                //if (maloaigiangvien == 17)
                //{
                //    _tongVuotMuc = _tietVuotGiangDay + _tietVuotCongTacKhac;
                //    _tongChiPhi = (_tietVuotGiangDay * dongiagiangday + _tietVuotCongTacKhac * dongiacongtackhac) * hesothamnien;
                //}
                //else
                //{
                //    _tongVuotMuc = _tietVuotGiangDay + (_tietVuotCongTacKhac / 2);
                //    _tongChiPhi = (_tietVuotGiangDay * dongiagiangday + (_tietVuotCongTacKhac / 2) * dongiacongtackhac) * hesothamnien;
                //}

                //Tất cả giảng viên đề không chia đôi tiết công tác khác
                _tongVuotMuc = _tietVuotGiangDay + _tietVuotCongTacKhac;
                _tongChiPhi = _tietVuotGiangDay * dongiagiangday * hesothamnien + _tietVuotCongTacKhac * dongiacongtackhac;
            }

            float _dinhMucDongThue = 0;
            TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
            _dinhMucDongThue = float.Parse(_cauHinhChung.Find(p => p.TenCauHinh == "Định mức đóng thuế giảng viên thỉnh giảng").GiaTri);

            if (_tongChiPhi >= _dinhMucDongThue)
            {
                bool kiemtraMaSoThue;
                try
                {
                    if(masothue.Trim().Length <= 0)
                        kiemtraMaSoThue = false;
                    else
                        kiemtraMaSoThue = true;
                }
                catch
                {
                      kiemtraMaSoThue = false;  
                }
                if (kiemtraMaSoThue == false)//Nếu gv ko có mã số thuế thì tính thuế 20%, ngược lại 10%
                {
                    _thueTNCN = _tongChiPhi * (float)0.2;
                    xrTableCell1.Text = "2. Thuế và thu nhập cá nhân (20%):";
                }
                else
                {
                    _thueTNCN = _tongChiPhi * (float)0.1;
                    xrTableCell1.Text = "2. Thuế và thu nhập cá nhân (10%):";
                }
            }
            else
            {
                _thueTNCN = 0;
            }
            _tienthucNhan = _tongChiPhi - _thueTNCN;

            xrTableCellTietNghaiVu.Text = tietnghiavugiangday.ToString();
            xrTableCellTietNghiaVuKhac.Text = tietnghiavucongtackhac.ToString();
            xrTableCellHocKyTruoc.Text = String.Format("{0}({1})", hockytruoc.ToUpper(), namhoctruoc);
            xrTableCellHocKyNay.Text = String.Format("{0}({1})", hocky.ToUpper(), namhoc);
            xrTableCellNoGioGiangKyTruoc.Text = nogiogiangkytruoc.ToString("n2");
            xrTableCellNoGioKhacKyTruoc.Text = nogiokhackytruoc.ToString("n2");
            xrTableCellTongTietGiangDay.Text = tongtietgiangday.ToString("n2");
            xrTableCellTongTietKhac.Text = tongtietcongtackhac.ToString("n2");
            xrTableCellCongGiangDay.Text = _congTietGiangDay.ToString("n2");//(tongtietgiangday + nogiogiangkytruoc).ToString("n2");
            xrTableCellCongKhac.Text = _congTietCongTacKhac.ToString("n2");// (tongtietcongtackhac + nogiokhackytruoc).ToString("n2");
            xrTableCellVuotMucGiangDay.Text = _tietVuotGiangDay.ToString("n2");//(tongtietgiangday + nogiogiangkytruoc - tietnghiavugiangday).ToString("n2");
            xrTableCellVuotMucKhac.Text = _tietVuotCongTacKhac.ToString("n2");//(tongtietcongtackhac + nogiokhackytruoc - tietnghiavucongtackhac).ToString("n2");
            xrTableCellTong.Text = _tongVuotMuc.ToString("n2");//((tongtietgiangday + nogiogiangkytruoc - tietnghiavugiangday) + (tongtietcongtackhac + nogiokhackytruoc - tietnghiavucongtackhac)).ToString("n2");

         

            xrTableCellTongChiPhi.Text = _tongChiPhi.ToString("n0");
            xrTableCellDonGiaGiangDay.Text = dongiagiangday.ToString("n0");
            xrTableCellDonGiaKhac.Text = dongiacongtackhac.ToString("n0");
            xrTableCellHeSoThamNien.Text = hesothamnien.ToString("n2");

            xrTableCellTongChiPhi.Text = _tongChiPhi.ToString("n0");
            xrTableCellThue.Text = _thueTNCN.ToString("n0");
            xrTableCellThucNhan.Text = _tienthucNhan.ToString("n0");

            xrLabelTienBangChu.Text = "Bằng chữ: " + PMS.Common.Globals.DocTien((decimal)_tienthucNhan) + ".";
        }
    }
}
