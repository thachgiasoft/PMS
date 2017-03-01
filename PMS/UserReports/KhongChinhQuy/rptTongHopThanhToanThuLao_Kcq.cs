using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;
using System.Data;

namespace PMS.UserReports.KhongChinhQuy
{
    public partial class rptTongHopThanhToanThuLao_Kcq : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTongHopThanhToanThuLao_Kcq()
        {
            InitializeComponent();
        }
        public void InitData(string truong, string namHoc, string hocKy, string loaiGiangVien, string lanChot, string nguoiLapBieu, string phongDaoTao, DataTable data)
        {
            pTruong.Value = truong.ToUpper();
            pNamHoc.Value = namHoc;
            pHocKy.Value = hocKy;
            pLoaiGiangVien.Value = loaiGiangVien.ToUpper();
            pLanChot.Value = lanChot;
            pNguoiLapBieu.Value = nguoiLapBieu;
            pPhongDaoTao.Value = phongDaoTao;
            bindingSourceBaoCao.DataSource = data;
        }
    }
}
