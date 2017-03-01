using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptLietKeKhoiLuongGiangDayGiangVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptLietKeKhoiLuongGiangDayGiangVien()
        {
            InitializeComponent();
        }

        public void InitData(string namhoc, string hocky, string truong, string magiangvien, string hoten, string madonvi, string tendonvi, string hocham, string hocvi, string gioitinh, string thoihanphanhoi, decimal tongtietquydoi, decimal tietgiangday, decimal tietDAMHLA, decimal tietnghiavu, decimal dongiatinh, decimal sotietthieu, decimal tienthieutiet, decimal sotienthuclanh, string nguoilapbieu, DataTable db)
        {
            pNamHoc.Value = namhoc;
            pHocKy.Value = hocky;
            pTruong.Value = truong.ToUpper();
            pNguoiLapBieu.Value = nguoilapbieu;
            pHoTen.Value = String.Format("{0} ({1}) - {2} - {3}", hoten, magiangvien, hocham, hocvi);
            pDonVi.Value = String.Format("Bộ môn/Trung tâm: {0} ({1})", tendonvi, madonvi);
            if (gioitinh == "Nam")
            {
                pText1.Value = String.Format("Kính gửi Quý Thầy {0} bảng tính KLGD {1}/{2}", hoten, hocky, namhoc);
                pText2.Value = String.Format("Đề nghị Quý Thầy kiểm tra và phản hồi về PĐT đến hết ngày {0}", thoihanphanhoi);
            }
            else
            {
                pText1.Value = String.Format("Kính gửi Quý Cô {0} bảng tính KLGD {1}/{2}", hoten, hocky, namhoc);
                pText2.Value = String.Format("Đề nghị Quý Cô kiểm tra và phản hồi về PĐT đến hết ngày {0}", thoihanphanhoi);
            }
            pText3.Value = "Sau thời hạn trên PĐT sẽ chuyển dữ liệu sang P.KHTC để chi trả KLGD";

            pTongTietQuyDoi.Value = tongtietquydoi;
            pTietGiangDay.Value = tietgiangday;
            pTietDAMHLA.Value = tietDAMHLA;
            pTietNghiaVu.Value = tietnghiavu;
            pDonGiaTinh.Value = dongiatinh.ToString("n0");
            pSoTietThieu.Value = sotietthieu;
            pTienThieuTiet.Value = tienthieutiet.ToString("n0");
            pSoTienThucLanh.Value = sotienthuclanh.ToString("n0");

            bindingSourceThongKe.DataSource = db;
        }
    }
}
