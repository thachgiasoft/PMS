using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using PMS.Entities;

namespace PMS.UserReports
{
    public partial class ThanhToanThuLaoGiangDayReport : DevExpress.XtraReports.UI.XtraReport
    {
        public ThanhToanThuLaoGiangDayReport()
        {
            InitializeComponent();
        }

        public void InitData(string namHoc, string hocKy, string tenBoMon, string tenLoaiGiangVien, string tenTruong, string phongDaoTao, string phongTCCB, string phongKHTC, string banGiamHieu, string nguoiLapBieu, VList<ViewThanhToanThuLao> vList)
        {
            pNamHoc.Value = namHoc;
            pHocKy.Value = hocKy;
            pTenBoMon.Value = tenBoMon;
            pTenLoaiGiangVien.Value = tenLoaiGiangVien;
            pTruong.Value = tenTruong;
            pPhongDaoTao.Value = phongDaoTao;
            pToChucCanBo.Value = phongTCCB;
            pKeHoachTaiChinh.Value = phongKHTC;
            pBanGiamHieu.Value = banGiamHieu;
            pNguoiLapBieu.Value = nguoiLapBieu;
            bindingSourceThuLaoGiangDay.DataSource = vList;
        }
    }
}