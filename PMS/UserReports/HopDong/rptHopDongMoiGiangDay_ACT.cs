using System;
using DevExpress.XtraReports.UI;
using System.Data;


namespace PMS.UserReports
{
    public partial class rptHopDongMoiGiangDay_ACT : XtraReport
    {
        string tienChu = "";

        public rptHopDongMoiGiangDay_ACT()
        {
            InitializeComponent();
        }

        public void InitData(string diachi, string dienthoai, string dongia, string donvicongtac,string hochamhocvi,string masothunhap,string noicapcmnd
            , string nganhanggv, string ngaybdgiangday, string ngaycapcmndgv, string ngayktgiangday,string socmndgv,string sotaikhoangv,string tengv
            , string tentruongkhoa, decimal tonggiatrihd, string tonggiatrihdbangchu, int tongtietthucday,string truong,string chucvutruongkhoa
            , string daidienbenA, string chucvudaidienbenA, string chucvu02daidienbenA, string diachidaidienbenA, string dienthoaidaidienbenA, string faxdaidienbenA,DataTable tb)
        {
            pDiaChiGV.Value = diachi;
            pDienThoaiGV.Value = dienthoai;
            pDonGia.Value = dongia;
            pDonViCongTacGV.Value = donvicongtac;
            pHocHamHocViGiangVien.Value = hochamhocvi;
            pMaSoThuNhapGV.Value = masothunhap;
            pNoiCapCMNDGV.Value = noicapcmnd;
            pNganHangGV.Value = nganhanggv;
            pNgayBDGiangDay.Value = ngaybdgiangday;
            pNgayCapCMNDGV.Value = ngaycapcmndgv;
            pNgayKTGiangDay.Value = ngayktgiangday;
            pSoCMNDGV.Value = socmndgv;
            pSoTaiKhoanGV.Value = sotaikhoangv;
            pTenGiangVien.Value = tengv;
            pTenTruongKhoa.Value = tentruongkhoa;
            pTongGiaTriHD.Value = tonggiatrihd;
            pTongGiaTriHDBangChu.Value = tonggiatrihdbangchu;
            pTongTietThucDay.Value = tongtietthucday;
            pTruong.Value = truong.ToUpper();
            pChucVuTruongKhoa.Value = chucvutruongkhoa;
            pDaiDienBenA.Value = daidienbenA;
            pChucVuDaiDienBenA.Value = chucvudaidienbenA;
            pChucVu02DaiDienBenA.Value = chucvu02daidienbenA;
            pDiaChiDaiDienBenA.Value = diachidaidienbenA;
            pDienThoaiDaiDienBenA.Value = dienthoaidaidienbenA;
            pFaxDaiDienBenA.Value = faxdaidienbenA;
            //xrLabelNgayHD.Text = String.Format("\tHôm nay, ngày {0:dd} tháng {1:MM} năm {2:yyyy} tại TP. Hồ Chí Minh, chúng tôi gồm có: ", ngayin, ngayin, ngayin);
            bindingSourceHDMoiGiangDay.DataSource = tb;
        }

        private void xrLabel66_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                //decimal tien = decimal.Parse(xrLabel66.Text);
                //tienChu = PMS.Common.Globals.DocTien(tien);
                pTongGiaTriHDBangChu.Value = tienChu.Trim();

                //lblTienChu.Text = tienChu.Trim() +  "), được tạm tính như sau:";

                DataTable data = bindingSourceHDMoiGiangDay.DataSource as DataTable;

                if (data == null)
                    return;
                DataTable vListBaoCao = data;
                //if (vListBaoCao == null)
                    return;
                string sort = "";
              
                string filter = "MaGiangVien = '" + lblMaGiangVien.Text + "'";

                //string filter = gridViewHopDongMoiGiangVien.ActiveFilterString;
                //vListBaoCao = dv.ToTable();
                //if (vListBaoCao == null)
                    return;

                vListBaoCao.AcceptChanges();
                //sub_rptHopDongMoiGiang2.InitData(vListBaoCao);
            }
            catch
            { }
        }

        private void lblKhoaBoMon_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }

        private void xrLabel44_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

    }
}
