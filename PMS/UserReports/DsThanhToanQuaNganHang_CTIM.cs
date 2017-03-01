using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace PMS.UserReports
{
    public partial class DsThanhToanQuaNganHang_CTIM : DevExpress.XtraReports.UI.XtraReport
    {
        public DsThanhToanQuaNganHang_CTIM()
        {
            InitializeComponent();
        }

        public void InitData(string tenTruong, string namHoc, string hocKy, string banGiamHieu, string chucvubangiamhieu, string nguoiKeToan
            , string chucvuKHTC, string chucvuketoan, string nguoiLapBieu, DataTable vList, DateTime ngayIn)
        {
            pTruong.Value = tenTruong;
            pNamHoc_HocKy.Value = hocKy + " - Năm học " + namHoc;
            pBanGiamHieu.Value = banGiamHieu;
            pChucVuBanGiamHieu.Value = chucvubangiamhieu;
            pChucVuKeToan.Value = chucvuketoan;
            pNguoiKeToan.Value = nguoiKeToan;
            pChucVuKHTC.Value = chucvuKHTC;
            pNguoiLapBieu.Value = nguoiLapBieu;
            this.DataSource = vList;
            pNgayIn.Value = String.Format("Ngày {0:dd} tháng {0:MM} năm {0:yyyy}", ngayIn);
        }
    }
}
