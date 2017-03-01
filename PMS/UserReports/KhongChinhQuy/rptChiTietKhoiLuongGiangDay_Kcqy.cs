using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using PMS.Services;

namespace PMS.UserReports.KhongChinhQuy
{
    public partial class rptChiTietKhoiLuongGiangDay_Kcq : DevExpress.XtraReports.UI.XtraReport
    {
        decimal tietGiangDay, tienGiangDayLTTHKLK, tietDAMH, tienGiangDayDAMH, tietNghiaVu, soTietThieu, tienThieuTiet
                , donGia, donGiaClc, soTienThucLanh, soTietDaiTra, soTietClc, tietGioiHan, tietThucLanhClc, tietDuClc, tietThucLanhDaiTra
                , tietDuDaiTra, tienDu;
        public rptChiTietKhoiLuongGiangDay_Kcq()
        {
            InitializeComponent();
        }
        public void InitData(string namhoc, string hocky, string truong, string magiangvien, string hoten, string madonvi, string tendonvi, string hocham, string hocvi, string gioitinh, string thoihanphanhoi, decimal tongtietquydoi, decimal tietgiangday, decimal tietDAMHLA, decimal tietnghiavu, decimal dongiatinh, decimal sotietthieu, decimal tienthieutiet, decimal sotienthuclanh, string nguoilapbieu, DataTable db)
        {
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pTruong.Value = truong.ToUpper();
            pNguoiLapBieu.Value = nguoilapbieu;
            pHanPhanHoi.Value = thoihanphanhoi;

            bindingSourceThongKe.DataSource = db;
        }

        private void xrTableCell35_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //35: tietgiangday
            xrTableCell35.Text = tietGiangDay.ToString();
            xrTableCell37.Text = tietDAMH.ToString();
            if (soTietClc != 0)
                xrTableCell50.Text = string.Format("({0} tiết đại trà; {1} tiết CLC)", soTietDaiTra.ToString(), soTietClc.ToString());
            xrTableCell41.Text = donGia.ToString("n0");
            if (donGiaClc != 0)
                xrTableCell53.Text = string.Format("(Đơn giá CLC: {0})", donGiaClc.ToString("n0"));
            tietNghiaVu = decimal.Parse(IsNull(xrTableCell39.Text));
            tietGioiHan = decimal.Parse(IsNull(xrTableCell64.Text));
            //if (tietNghiaVu > soTietDaiTra)
            //{
            //    soTietThieu = tietNghiaVu - soTietDaiTra;
            //    tienThieuTiet = (tienGiangDayLTTHKLK + tienGiangDayDAMH) - (tietNghiaVu * donGia);
            //    if (tienThieuTiet < 0) tienThieuTiet = Math.Abs(tienThieuTiet); else tienThieuTiet = 0;
            //    //soTienThucLanh = (tienGiangDayDAMH + (soTietClc * donGiaClc)) - tienThieuTiet;
            //    soTienThucLanh = (tienGiangDayLTTHKLK + tienGiangDayDAMH) - (tietNghiaVu * donGia);
            //    if (soTienThucLanh < 0) soTienThucLanh = 0;
            //}
            //else
            //{
            //    soTietThieu = 0;
            //    tienThieuTiet = 0;
            //    soTienThucLanh = (tienGiangDayLTTHKLK + tienGiangDayDAMH) - (tietNghiaVu * donGia);
            //    if (soTienThucLanh < 0) soTienThucLanh = 0;
            //}
          
            if (soTietDaiTra + tietDAMH + soTietClc > tietGioiHan && tietGioiHan > 0 && soTietClc <= tietGioiHan)
            {
                tietThucLanhDaiTra = tietGioiHan - soTietClc;
                tietDuDaiTra = soTietDaiTra + tietDAMH + soTietClc - tietGioiHan;
            }
            else
            {
                tietThucLanhDaiTra = soTietDaiTra + tietDAMH;
                tietDuDaiTra = 0;
            }
            if (soTietClc > tietGioiHan && tietGioiHan > 0)
            {
                tietThucLanhClc = tietGioiHan;
                tietDuClc = soTietClc - tietGioiHan;
                tietThucLanhDaiTra = 0;
                tietDuDaiTra = soTietDaiTra + tietDAMH;
            }
            else
                tietThucLanhClc = soTietClc;

            if (soTietDaiTra + tietDAMH >= tietNghiaVu)
            {
                soTienThucLanh = tietThucLanhClc * donGiaClc + tietThucLanhDaiTra * donGia - tietNghiaVu * donGia;
                tienThieuTiet = 0;
            }
            else if (soTietDaiTra + tietDAMH < tietNghiaVu && tietThucLanhClc * donGiaClc + tietThucLanhDaiTra * donGia > tietNghiaVu * donGia)
            {
                soTienThucLanh = tietThucLanhClc * donGiaClc + tietThucLanhDaiTra * donGia - tietNghiaVu * donGia;
                tienThieuTiet = 0;
            }
            else
            {
                soTienThucLanh = 0;
                tienThieuTiet = tietNghiaVu * donGia - (tietThucLanhClc * donGiaClc + tietThucLanhDaiTra * donGia);
            }
            tienDu = tietDuClc * donGiaClc + tietDuDaiTra * donGia;
            if (donGia > 0)
                soTietThieu = tienThieuTiet / donGia;
            else soTietThieu = 0;
            xrTableCell43.Text = soTietThieu.ToString();//Số tiết thiếu
            xrTableCell45.Text = tienThieuTiet.ToString("n0");//Tiền thiếu tiết
            xrTableCell47.Text = soTienThucLanh.ToString("n0");//Thực lãnh
            xrTableCell67.Text = tienDu.ToString("n0");//Tiền vượt
            if (soTienThucLanh >= 0)
                xrTableCell62.Text = PMS.Common.Globals.DocTien(soTienThucLanh);
        }
        //Loai: LT, TH...
        private void xrTableCell21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (xrTableCell21.Text == "LT" || xrTableCell21.Text == "TH" || xrTableCell21.Text == "KLK" || xrTableCell21.Text == "TN")//Nếu là lớp LT, TH, KLK, TN:
            {
                tietGiangDay += decimal.Parse(IsNull(xrTableCell19.Text));//tổng số tiết----19: tietquydoi
                tienGiangDayLTTHKLK += decimal.Parse(IsNull(xrTableCell31.Text));//tổng số tiền---31: thanhtien

                if (xrTableCell48.Text == "True")//Nếu là lớp CLC:
                {
                    soTietClc += decimal.Parse(IsNull(xrTableCell19.Text));
                    if (xrTableCell61.Text == "23")
                        donGiaClc = 0;
                    else
                        donGiaClc = decimal.Parse(IsNull(xrTableCell29.Text));//29: dongia
                }
                else
                {
                    soTietDaiTra += decimal.Parse(IsNull(xrTableCell19.Text));
                    //donGia = decimal.Parse(IsNull(xrTableCell29.Text));

                }
            }
            else
            {
                tietDAMH += decimal.Parse(IsNull(xrTableCell19.Text));
                tienGiangDayDAMH += decimal.Parse(IsNull(xrTableCell31.Text));
            }
            if (xrTableCell61.Text == "23")
                donGia = 0;
            else
            {
                double kq = 0;
                DataServices.DonGia.GetByMaQuanLyNamHocHocKyLopClc(xrLabel8.Text, xrLabel12.Text, xrLabel13.Text, false, ref kq);
                donGia = (decimal)kq;
            }
        }

        private void GroupFooter1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
        string IsNull(string s)
        {
            if (s == "")
                return "0";
            else
                return s;
        }

        private void GroupHeader1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            tietGiangDay = 0;
            tienGiangDayLTTHKLK = 0;
            soTietDaiTra = 0;
            soTietClc = 0;
            tietDAMH = 0;
            soTienThucLanh = 0;
            tienGiangDayDAMH = 0;
            tietNghiaVu = 0;
            soTietThieu = 0;
            tienThieuTiet = 0;
            donGia = 0;
            donGiaClc = 0;
            tietGioiHan = 0;
            tietThucLanhClc = 0;
            tietDuClc = 0;
            tietThucLanhDaiTra = 0;
            tietDuDaiTra = 0;
            tienDu = 0;
            xrTableCell50.Text = "";
            xrTableCell53.Text = "";
            xrTableCell62.Text = "";
        }
    }
}
