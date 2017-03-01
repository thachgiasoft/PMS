using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using PMS.Entities;
using PMS.Services;
using PMS.Services;

namespace PMS.UserReports
{
    public partial class rptBangKeKhaiThanhToanTienGiang : DevExpress.XtraReports.UI.XtraReport
    {
        int sttBacDaoTao = 1, sttNCTC = 1, sttLop = 1, sttTongCong = 0;
        TList<GiangVienTamUng> ListTamUng = new TList<GiangVienTamUng>();
        float _tongio = 0, _dinhMucNCKH, _thucHienNCKH, _soTienDaTamUng = 0;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        public rptBangKeKhaiThanhToanTienGiang()
        {
            InitializeComponent();
        }
        public void InitData(string truong, string namHoc, string hoTenGV, string donVi, string chucDanh, string soTietNghiaVu, string donGiaTieuChuan, float dinhMucNCKH, float thucHienNCKH, float heSoVuotDinhMuc, DataTable dt, TList<GiangVienTamUng> listTamUng)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namHoc;
            pHoTen.Value = hoTenGV;
            pDonVi.Value = donVi;
            pChucDanh.Value = chucDanh;
            pSoTietNghiaVu.Value = soTietNghiaVu;
            pHeSoVuotDinhMuc.Value = heSoVuotDinhMuc;
            pDonGiaTieuChuan.Value = donGiaTieuChuan;
            bindingSourceData.DataSource = dt;
            this.ListTamUng = listTamUng;
            this._dinhMucNCKH = dinhMucNCKH;
            this._thucHienNCKH = thucHienNCKH;
            TongGioDay();
            SoTienDaTamUng();
        }

        #region Function
        string Char(string Num, bool upper)
        {
            string[] Nm = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26" };
            string[] Ch = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int index = Array.IndexOf(Nm, Num);
            if (index < 0) return "";
            string reVal = "";
            reVal = Ch[index];
            if (upper) return reVal.ToUpper();
            else return reVal.ToLower();
        }

        string Roman(int Num, bool upper)
        {
            string ch = "";
            if (Num > 10000) return "";
            int tam = Num / 1000;
            for (int i = 0; i < tam; i++)
                ch += "M";
            Num = Num % 1000;

            tam = Num / 100;
            for (int i = 0; i < tam; i++)
                ch += "C";
            Num = Num % 100;

            tam = Num / 10;
            for (int i = 0; i < tam; i++)
                ch += "X";
            Num = Num % 10;

            for (int i = 0; i < Num; i++)
                ch += "I";

            ch = ch.Replace("CCCCCCCCC", "CM");
            ch = ch.Replace("XXXXXXXXX", "XC");
            ch = ch.Replace("IIIIIIIII", "IX");
            ch = ch.Replace("CCCCC", "D");
            ch = ch.Replace("XXXXX", "L");
            ch = ch.Replace("IIIII", "V");
            ch = ch.Replace("CCCC", "CD");
            ch = ch.Replace("XXXX", "XL");
            ch = ch.Replace("IIII", "IV");
            if (upper == true) ch = ch.ToUpper();
            else ch = ch.ToLower();
            return ch;
        }
        #endregion

        private void xrTableCell3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrTableCell3.Text = sttLop.ToString();
            sttLop++;
            sttTongCong++;
        }

        private void xrTableCell29_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            sttLop = 1;
            xrTableCell29.Text = Char(sttNCTC.ToString(), true) + ".";
            sttNCTC++;
        }

        private void xrTableCell43_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            sttNCTC = 1;
            xrTableCell43.Text = Roman(sttBacDaoTao, true) + ".";
            sttBacDaoTao++;
            sttTongCong = 0;
        }

        private void xrTableCell60_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrTableCell60.Text = "Cộng (" + xrTableCell29.Text.Split('.').GetValue(0).ToString() + "): " + xrTableCell3.Text + " lớp."; 
        }

        private void xrTableCell72_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xrTableCell72.Text = "Cộng (" + xrTableCell43.Text.Split('.').GetValue(0).ToString() + "): " + sttTongCong.ToString() + " lớp."; 
        }

        private void rptBangKeKhaiThanhToanTienGiang_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ListTamUng.Sort("NamHoc, HocKy, NgayTamUng");
            foreach (GiangVienTamUng tamUng in ListTamUng)
            {
                XRTableRow row = new XRTableRow();
                XRTableCell cell1 = new XRTableCell();
                cell1.WidthF = xrTableCell115.WidthF;
                cell1.Text = "- Nhận " + tamUng.HocKy + " năm học " + tamUng.NamHoc;
                XRTableCell cell2 = new XRTableCell();
                cell2.WidthF = xrTableCell116.WidthF;
                cell2.TextAlignment = xrTableCell116.TextAlignment;
                cell2.Text = ((float)(tamUng.SoTien)).ToString("n0");
                XRTableCell cell3 = new XRTableCell();
                cell3.WidthF = xrTableCell117.WidthF;
                cell3.TextAlignment = xrTableCell117.TextAlignment;
                cell3.Text = ((DateTime)tamUng.NgayTamUng).ToShortDateString();
                row.Cells.AddRange(new XRTableCell[] { cell1, cell2, cell3 });
                xrTable9.Rows.Add(row);
            }
        }

        private void ReportFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            float _tongGioDay, _soTietNghiaVu, _soTietNghiaVuTheoQuyDinh, _donGiaTieuChuan;
            _tongGioDay = _tongio;
            _soTietNghiaVu = float.Parse(pSoTietNghiaVu.Value.ToString());
            _donGiaTieuChuan = float.Parse(pDonGiaTieuChuan.Value.ToString());
            xrTableCell74.Text = _tongio.ToString();

            //So tiet nghia vu theo quy dinh
            if (_tongGioDay > _soTietNghiaVu)
                _soTietNghiaVuTheoQuyDinh = _soTietNghiaVu;
            else
                _soTietNghiaVuTheoQuyDinh = _tongGioDay;
            xrTableCell100.Text = _soTietNghiaVuTheoQuyDinh.ToString();
            xrTableCell101.Text = _donGiaTieuChuan.ToString("n0");//don gia
            xrTableCell102.Text = (_soTietNghiaVuTheoQuyDinh * _donGiaTieuChuan).ToString("n0");//thanh tien

            //So tiet can phai chuyen doi thanh so tiet NCKH
            float _soTietChuyenDoiNCKH = 0;
            float _soTietNghiaVuConDu = _tongGioDay - _soTietNghiaVu;
            if (_thucHienNCKH >= _dinhMucNCKH)
            {
                _soTietChuyenDoiNCKH = 0;
            }
            else
            {
                if (_soTietNghiaVuConDu <= _dinhMucNCKH - _thucHienNCKH)
                {
                    _soTietChuyenDoiNCKH = _soTietNghiaVuConDu;
                }
                else
                    _soTietChuyenDoiNCKH = _dinhMucNCKH - _thucHienNCKH;
            }
            xrTableCell104.Text = _soTietChuyenDoiNCKH.ToString();
            xrTableCell105.Text = _donGiaTieuChuan.ToString("n0");
            xrTableCell106.Text = (_soTietChuyenDoiNCKH * _donGiaTieuChuan).ToString("n0");

            //So tiet giang vuot dinh muc
            float _heSoVuotDinhMuc = float.Parse(pHeSoVuotDinhMuc.Value.ToString());
            float _soTietGiangVuotDinhMuc;
            _soTietGiangVuotDinhMuc = (float)Math.Round((_tongGioDay - _soTietNghiaVuTheoQuyDinh - _soTietChuyenDoiNCKH), 2, MidpointRounding.AwayFromZero);
            xrTableCell108.Text = _soTietGiangVuotDinhMuc.ToString();
            xrTableCell109.Text = (Math.Round(_donGiaTieuChuan * _heSoVuotDinhMuc, 2, MidpointRounding.AwayFromZero)).ToString("n0");
            xrTableCell110.Text = (_soTietGiangVuotDinhMuc * float.Parse(xrTableCell109.Text)).ToString("n0");

            xrTableCell114.Text = (float.Parse(xrTableCell102.Text) + float.Parse(xrTableCell106.Text) + float.Parse(xrTableCell110.Text)).ToString("n0");

            //So tien da tam ung
            float _soTienDuocThanhToan = float.Parse(xrTableCell114.Text) - _soTienDaTamUng;
            xrLabel22.Text = _soTienDuocThanhToan.ToString("n0");
            if (_soTienDuocThanhToan != null && _soTienDuocThanhToan > 0)
                xrLabel24.Text = PMS.Common.Globals.DocTien((decimal)_soTienDuocThanhToan).Trim() + ".";

            if (ListTamUng.Count == 0)
            {
                xrLabel20.Visible = false;
                xrTable9.Visible = false;
            }
        }

        void TongGioDay()
        {
            DataTable dt = bindingSourceData.DataSource as DataTable;
            foreach (DataRow drow in dt.Rows)
            {
                _tongio += float.Parse(IsNull(drow["SoTietQuyDoi"].ToString()));
            }
        }

        void SoTienDaTamUng()
        {
            foreach (GiangVienTamUng gv in ListTamUng)
            {
                _soTienDaTamUng += (float)gv.SoTien;
            }
        }

        private void xrLabel27_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            string _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri.ToString();
            if (_maTruong == "MTU")
                xrLabel27.Text = "TP Vĩnh Long, ngày";
        }

        string IsNull(string s)
        {
            if (s == "")
                s = "0";
            return s;
        }
    }
}
