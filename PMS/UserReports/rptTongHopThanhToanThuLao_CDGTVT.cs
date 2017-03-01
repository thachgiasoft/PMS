using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class rptTongHopThanhToanThuLao_CDGTVT : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTongHopThanhToanThuLao_CDGTVT()
        {
            InitializeComponent();
        }
        public void InitData(string tentruong, string tenKhoa, string namhoc, string hieutruong, string phongdaotao, string truongkhoa, string nguoilapbieu, DateTime ngayin, DataTable tb)
        {
            pTruong.Value = tentruong.ToUpper();
            pKhoa.Value = tenKhoa.ToUpper();
            pNamHoc.Value = namhoc;
            pHieuTruong.Value = hieutruong;
            pPhongDaoTao.Value = phongdaotao;
            pNguoiLapBieu.Value = nguoilapbieu;
            lblNgayIn.Text = "Tp. Hồ Chí Minh, ngày " + ngayin.ToString("dd") + " tháng " + ngayin.ToString("MM") + " năm " + ngayin.ToString("yyyy");
            bindingSource1.DataSource = tb;
        }
    }
}
