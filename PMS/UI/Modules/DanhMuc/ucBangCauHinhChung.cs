using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using PMS.Services;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucBangCauHinhChung : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Bien
        TList<CauHinhChung> listCauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion

        public ucBangCauHinhChung()
        {
            InitializeComponent();
            _maTruong = listCauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri.ToString();
          
            #region Visible Control
            switch (_maTruong)
            { 
                case "CTIM":
                    layoutControlItem24.Text = "Hệ số thỉnh giảng:";
                    layoutControlItem20.Text = "Hệ số thực hành:";
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem22.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem25.Text = "Định mức đóng thuế của giảng viên thỉnh giảng:";
                    layoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem28.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem30.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem31.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem32.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem33.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem34.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem35.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem36.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem37.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem39.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem40.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem42.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem43.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem44.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem45.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem46.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem47.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem48.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem49.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem51.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem53.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                break;

                case "UEL":
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem20.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem23.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem28.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem31.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem32.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem33.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem34.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem35.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem36.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem39.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem40.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem41.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem42.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem43.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem44.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem45.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem46.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem47.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem48.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem49.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem51.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem53.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                break;

                case "LAW":
                     layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem20.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem22.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem23.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem28.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem30.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem31.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem32.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem33.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem34.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem35.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem36.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem37.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem39.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem40.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem41.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem42.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem43.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem44.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem45.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem51.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem53.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                break;

                case "IUH":
                    layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem22.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem23.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem28.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem30.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem31.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem33.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem34.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem35.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem36.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem37.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem38.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem39.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem40.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem41.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem43.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem44.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem45.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem46.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem47.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem48.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem49.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem51.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem53.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                break;
                case "BUH":
                    layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem20.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem23.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem25.Text = "Định mức đóng thuế của giảng viên:";
                    layoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem30.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem31.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem32.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem33.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem34.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem35.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem36.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem37.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem39.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem40.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem41.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem42.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem44.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem45.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem46.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem47.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem48.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem49.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem51.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem53.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                break;
                case "ACT":
                    layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem20.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem23.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem25.Text = "Định mức đóng thuế của giảng viên: ";
                    layoutControlItem28.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem30.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem32.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem33.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem34.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem35.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem36.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem37.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem39.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem40.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem41.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem42.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem43.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem44.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem45.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem46.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem47.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem48.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem49.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem51.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem53.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;

                case "CDGTVT":
                    layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem20.Text = "Hệ số quy đổi nhóm môn thực tập: ";
                    layoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem23.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem28.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem30.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem31.Text = "Đơn giá vượt giờ:";
                    layoutControlItem32.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem37.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem39.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem40.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem41.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem42.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem43.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem44.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem45.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem46.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem47.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem48.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem49.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem51.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem53.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;

                case "USSH":
                    layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem23.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem28.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem30.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem31.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem32.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem33.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem34.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem35.Text = "Khung giới hạn vượt giờ ngoài chuẩn: ";
                    layoutControlItem36.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem37.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem39.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem40.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem41.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem42.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem43.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem44.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem45.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem46.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem47.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem48.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem49.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem51.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem53.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;

                case "VHU":
                    layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem20.Text = "Hệ số hướng dẫn bài tập, thực hành, thí nghiệm";
                    layoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem23.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem25.Text = "Định mức đóng thuế của giảng viên: ";
                    layoutControlItem28.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem30.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem31.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem32.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem33.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem34.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem35.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem36.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem37.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem38.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem39.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem40.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem41.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem42.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem43.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem44.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem45.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem46.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem47.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem48.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem49.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem51.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem53.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;

                case "UTE":
                    layoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem23.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem28.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem39.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem22.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem32.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem33.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem34.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem35.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem36.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem37.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem38.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem41.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem42.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem43.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem46.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem47.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem48.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem49.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem51.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem53.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;

                case "UFM":
                    layoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem23.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem28.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem39.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem22.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem32.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem33.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem34.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem35.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem36.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem37.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem38.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem41.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem42.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem43.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem44.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem45.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem46.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem47.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem48.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem49.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem51.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem53.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;

                case "HBU":
                    layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem20.Text = "Hệ số hướng dẫn thực hành";
                    layoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem23.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem25.Text = "Định mức đóng thuế của giảng viên: ";
                    layoutControlItem28.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem30.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem31.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem32.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem33.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem34.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem35.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem36.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem37.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem38.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem39.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem40.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem41.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem42.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem43.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem44.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem45.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem46.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem47.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem48.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem49.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem53.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;

                case "DLU":
                    layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem13.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem14.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem16.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem18.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem19.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem20.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem21.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem22.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem23.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem24.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem25.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem25.Text = "Định mức đóng thuế của giảng viên: ";
                    layoutControlItem28.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem27.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem26.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem29.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem30.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem31.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem32.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem33.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem34.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem35.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem36.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem37.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem38.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem39.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    //layoutControlItem40.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem41.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem42.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem43.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem44.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem45.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem46.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem47.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem48.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem49.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem51.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;
                default:
                    layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem15.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem12.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem51.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    
                    break;
            }
            #endregion

            if (UserInfo.User.ResetPassWordGv != true)
            {
                btnResetPassword.Enabled = false;
            }
        }

        private void ucBangCauHinhChung_Load(object sender, EventArgs e)
        {
            #region AppRepositoryItemGridLookUpEdit năm học hiện tại
            AppGridLookupEdit.InitGridLookUp(cboNamHocHienTai, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHocHienTai, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHocHienTai.Properties.ValueMember = "NamHoc";
            cboNamHocHienTai.Properties.DisplayMember = "NamHoc";
            cboNamHocHienTai.Properties.NullText = "[Chọn năm học]";
            #endregion

            #region AppRepositoryItemGridLookUpEdit học kỳ hiện tại
            AppGridLookupEdit.InitGridLookUp(cboHocKyHienTai, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKyHienTai, new string[] { "MaHocKy" }, new string[] { "Học kỳ" });
            cboHocKyHienTai.Properties.ValueMember = "MaHocKy";
            cboHocKyHienTai.Properties.DisplayMember = "MaHocKy";
            cboHocKyHienTai.Properties.NullText = "[Chọn học kỳ]";
            #endregion

            #region AppRepositoryItemGridLookUpEdit đợt hiện tại
            AppGridLookupEdit.InitGridLookUp(cboDotHienTai, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboDotHienTai, new string[] { "TenQuanLy" }, new string[] { "Tên đợt" });
            cboDotHienTai.Properties.ValueMember = "MaCauHinhChotGio";
            cboDotHienTai.Properties.DisplayMember = "TenQuanLy";
            cboDotHienTai.Properties.NullText = "[Chọn đợt]";
            #endregion

            LoadCauHinh();
        }

        #region LoadCauHinh
        private void LoadCauHinh()
        {
            listCauHinhChung = DataServices.CauHinhChung.GetAll();
            CauHinhChung cauHinh;
            try
            {
                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Tên trường");
                if (cauHinh != null)
                    txtTenTruong.EditValue = cauHinh.GiaTri;

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Đơn giá tiết chuẩn");
                if(cauHinh != null)
                    spinEditDonGiaTieuChuan.EditValue = int.Parse(cauHinh.GiaTri);

                SetNamHoc();
                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại");
                if (cauHinh != null)
                    bindingSourceNamHocHienTai.Position = bindingSourceNamHocHienTai.Find("NamHoc", cauHinh.GiaTri);

                ViewNamHoc namHoc = bindingSourceNamHocHienTai.Current as ViewNamHoc;
                if (namHoc != null)
                {
                    SetHocKy(namHoc.NamHoc);
                    cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại");
                    if (cauHinh != null)
                        bindingSourceHocKyHienTai.Position = bindingSourceHocKyHienTai.Find("MaHocKy", cauHinh.GiaTri);
                }

                bindingSourceDotHienTai.DataSource = DataServices.CauHinhChotGio.GetByNamHocHocKy(cboNamHocHienTai.EditValue.ToString(), cboHocKyHienTai.EditValue.ToString());
                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Đợt thanh toán hiện tại");
                if (cauHinh != null)
                    cboDotHienTai.EditValue = cauHinh.GiaTri;

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số vượt định mức");
                if (cauHinh != null)
                    spinEditHeSoVuotDinhMuc.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số sinh viên vượt trên 20% nhóm môn thực hành");
                if (cauHinh != null)
                    spinEditVuotMucNhomMonThucHanh.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Mức nhân hệ số môn GDTC lớp CLC");
                if (cauHinh != null)
                    spinEditGDTCCLC.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Mức nhân hệ số lớp CLC");
                if (cauHinh != null)
                    spinEditLopCLC.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Mức nhân hệ số đơn giá ngày chủ nhật");
                if (cauHinh != null)
                    spinEditDonGiaChuNhat.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Phần trăm vượt hệ số lớp đông môn thực hành");
                if (cauHinh != null)
                    spinEditPhanTramVuot.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số giảng dạy ngoài giờ và lớp học trong hè");
                if (cauHinh != null)
                    spinEditHeSoNgoaiGioVaHe.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Định mức giờ chuẩn giảng viên trong hợp đồng");
                if (cauHinh != null)
                    spinEditDinhMucGioChuanGiangVienHopDong.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Định mức giờ chuẩn GV HĐ trách nhiệm với trường");
                if (cauHinh != null)
                    spinEditDinhMucGioChuanGVHDVoiTruong.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết");
                if (cauHinh != null)
                    spinEditHeSoQuyDoiTHSangLT.EditValue = cauHinh.GiaTri;

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số cử nhân tài năng");
                if (cauHinh != null)
                    spinEditHeSoCuNhanTaiNang.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Cố vấn học tập phân theo năm học");
                if (cauHinh != null)
                    checkEditPhanCongCVHTTheoNam.EditValue = bool.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số thỉnh giảng môn chuyên ngành");
                if (cauHinh != null)
                    spinEditHeSoThinhGiangMonChuyenNganh.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Định mức đóng thuế giảng viên thỉnh giảng");
                if (cauHinh != null)
                    spinEditDinhMucDongThue.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Tiết đồ án tính vào giờ nghĩa vụ");
                if (cauHinh != null)
                    checkEditNghiaVuDoAn.EditValue = bool.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Số tiết thanh toán môn Tin học đại cương");
                if (cauHinh != null)
                    spinEditSoTietThanhToanMonTinHocDaiCuong.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Tính khối lượng giảng dạy theo thanh tra");
                if (cauHinh != null)
                    checkEditTinhKLGDTheoThanhTra.EditValue = bool.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số môn mới");
                if (cauHinh != null)
                    spinEditHeSoMonGiangMoi.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Phần trăm đóng thuế của giảng viên HDDH");
                if (cauHinh != null)
                    spinEditPhanTramDongThue.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Thời gian giới hạn thanh tra chấm giảng");
                if (cauHinh != null)
                    spinEditThoiGianGioiHanThanhTraChamGiang.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Đơn giá công tác khác");
                if (cauHinh != null)
                    spinEditDonGiaCongTacKhac.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Số tiết coi thi tiêu chuẩn");
                if (cauHinh != null)
                    spinEditSoTietCoiThiTieuChuan.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Số tuần thực tập hệ Cao Đẳng");
                if (cauHinh != null)
                    spinEditSoTuanThucTapCaoDang.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Số tuần thực tập hệ TCCN");
                if (cauHinh != null)
                    spinEditSoTuanThucTapTCCN.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Khung giới hạn vượt giờ giảng viên kiêm nhiệm");
                if (cauHinh != null)
                    spinEditGioiHanVuotGioGVKiemNhiem.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Khung giới hạn vượt giờ giảng viên chuyên trách");
                if (cauHinh != null)
                    spinEditGioiHanVuotGioGVChuyenTrach.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Phần trăm đơn giá trợ giảng");
                if (cauHinh != null)
                    spinEditPhanTramDonGiaTroGiang.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số địa điểm môn học có số tín chỉ từ 4 ");
                if (cauHinh != null)
                    spinEditHeSoDiaDiem.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Số tiết chuẩn hướng dẫn thực tập cuối khoá");
                if (cauHinh != null)
                    spinEditSoTietChuanHuongDanThucTapCuoiKhoa.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi nhóm môn GDTC");
                if (cauHinh != null)
                    spinEditHeSoQuyDoiNhomMonGDTC.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Đơn giá phụ cấp nhóm môn GDTC");
                if (cauHinh != null)
                    spinEditDonGiaPhuCapGDTC.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số nhân tiền xe địa điểm giảng dạy trên 60 tiết");
                if (cauHinh != null)
                    spinEditHeSoNhanDiaDiemTren60.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Đơn giá chấm bài sau đại học");
                if (cauHinh != null)
                    spinEditDonGiaChamBaiSDH.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Mức thanh toán tạm ứng");
                if (cauHinh != null)
                    spinEditMucThanhToanTamUngCoHuu.EditValue = float.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số cao học tính thêm theo văn bản");
                if (cauHinh != null)
                    textEditHeSoTinhThem.EditValue = cauHinh.GiaTri;

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Tính tạm ứng của lớp tự chọn theo sĩ số tối thiểu");
                if (cauHinh != null)
                    checkEditTamUngTuChon.EditValue = bool.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Tính tạm ứng cao học theo sĩ số kỳ trước");
                if (cauHinh != null)
                    checkEditTamUngCaoHoc.EditValue = bool.Parse(cauHinh.GiaTri);

                cauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Tính khối lượng khác vào giờ chuẩn");
                if (cauHinh != null)
                    checkEditTinhKhoiLuongKhacVaoGioChuan.EditValue = bool.Parse(cauHinh.GiaTri);

            }
            catch
            {
                XtraMessageBox.Show("Lỗi lấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region SetNamHoc, _hocKy
        private void SetNamHoc()
        {
            cboNamHocHienTai.DataBindings.Clear();
            bindingSourceNamHocHienTai.DataSource = DataServices.ViewNamHoc.GetAll();
            cboNamHocHienTai.DataBindings.Add("EditValue", bindingSourceNamHocHienTai, "NamHoc", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetHocKy(string namHoc)
        {
            cboHocKyHienTai.DataBindings.Clear();
            bindingSourceHocKyHienTai.DataSource = DataServices.ViewHocKy.GetByNamHoc(namHoc);
            cboHocKyHienTai.DataBindings.Add("EditValue", bindingSourceHocKyHienTai, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion

        private void btnLocDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadCauHinh();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenTruong.Focus();
            CauHinhChung objCauHinh;
            try
            {
                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Tên trường");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != txtTenTruong.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = txtTenTruong.Text;
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Đơn giá tiết chuẩn");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditDonGiaTieuChuan.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditDonGiaTieuChuan.Text;
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != cboNamHocHienTai.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = cboNamHocHienTai.Text;
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != cboHocKyHienTai.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = cboHocKyHienTai.Text;
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số vượt định mức");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditHeSoVuotDinhMuc.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditHeSoVuotDinhMuc.Text;
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số sinh viên vượt trên 20% nhóm môn thực hành");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditVuotMucNhomMonThucHanh.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditVuotMucNhomMonThucHanh.Text;
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Mức nhân hệ số môn GDTC lớp CLC");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditGDTCCLC.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditGDTCCLC.Text;
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Mức nhân hệ số lớp CLC");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditLopCLC.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditLopCLC.Text;
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Mức nhân hệ số đơn giá ngày chủ nhật");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditDonGiaChuNhat.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditDonGiaChuNhat.Text;
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Phần trăm vượt hệ số lớp đông môn thực hành");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditPhanTramVuot.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditPhanTramVuot.Text;
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số giảng dạy ngoài giờ và lớp học trong hè");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditHeSoNgoaiGioVaHe.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditHeSoNgoaiGioVaHe.Text;
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Định mức giờ chuẩn giảng viên trong hợp đồng");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditDinhMucGioChuanGiangVienHopDong.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditDinhMucGioChuanGiangVienHopDong.Text;
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Định mức giờ chuẩn GV HĐ trách nhiệm với trường");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditDinhMucGioChuanGVHDVoiTruong.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditDinhMucGioChuanGVHDVoiTruong.Text;
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditHeSoQuyDoiTHSangLT.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditHeSoQuyDoiTHSangLT.Text;
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số cử nhân tài năng");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditHeSoCuNhanTaiNang.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditHeSoCuNhanTaiNang.Text;
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Cố vấn học tập phân theo năm học");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != checkEditPhanCongCVHTTheoNam.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = checkEditPhanCongCVHTTheoNam.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số thỉnh giảng môn chuyên ngành");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditHeSoThinhGiangMonChuyenNganh.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditHeSoThinhGiangMonChuyenNganh.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Định mức đóng thuế giảng viên thỉnh giảng");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditDinhMucDongThue.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditDinhMucDongThue.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Tiết đồ án tính vào giờ nghĩa vụ");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != checkEditNghiaVuDoAn.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = checkEditNghiaVuDoAn.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Số tiết thanh toán môn Tin học đại cương");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditSoTietThanhToanMonTinHocDaiCuong.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditSoTietThanhToanMonTinHocDaiCuong.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Tính khối lượng giảng dạy theo thanh tra");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != checkEditTinhKLGDTheoThanhTra.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = checkEditTinhKLGDTheoThanhTra.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số môn mới");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditHeSoMonGiangMoi.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditHeSoMonGiangMoi.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Phần trăm đóng thuế của giảng viên HDDH");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditPhanTramDongThue.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditPhanTramDongThue.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Thời gian giới hạn thanh tra chấm giảng");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditThoiGianGioiHanThanhTraChamGiang.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditThoiGianGioiHanThanhTraChamGiang.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Đơn giá công tác khác");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditDonGiaCongTacKhac.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditDonGiaCongTacKhac.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Số tiết coi thi tiêu chuẩn");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditSoTietCoiThiTieuChuan.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditSoTietCoiThiTieuChuan.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Số tuần thực tập hệ Cao Đẳng");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditSoTuanThucTapCaoDang.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditSoTuanThucTapCaoDang.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Số tuần thực tập hệ TCCN");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditSoTuanThucTapTCCN.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditSoTuanThucTapTCCN.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Khung giới hạn vượt giờ giảng viên kiêm nhiệm");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditGioiHanVuotGioGVKiemNhiem.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditGioiHanVuotGioGVKiemNhiem.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Khung giới hạn vượt giờ giảng viên chuyên trách");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditGioiHanVuotGioGVChuyenTrach.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditGioiHanVuotGioGVChuyenTrach.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Phần trăm đơn giá trợ giảng");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditPhanTramDonGiaTroGiang.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditPhanTramDonGiaTroGiang.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số địa điểm môn học có số tín chỉ từ 4 ");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditHeSoDiaDiem.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditHeSoDiaDiem.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Số tiết chuẩn hướng dẫn thực tập cuối khoá");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditSoTietChuanHuongDanThucTapCuoiKhoa.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditSoTietChuanHuongDanThucTapCuoiKhoa.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi nhóm môn GDTC");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditHeSoQuyDoiNhomMonGDTC.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditHeSoQuyDoiNhomMonGDTC.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Đơn giá phụ cấp nhóm môn GDTC");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditDonGiaPhuCapGDTC.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditDonGiaPhuCapGDTC.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số nhân tiền xe địa điểm giảng dạy trên 60 tiết");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditHeSoNhanDiaDiemTren60.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditHeSoNhanDiaDiemTren60.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Đơn giá chấm bài sau đại học");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditDonGiaChamBaiSDH.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditDonGiaChamBaiSDH.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Mức thanh toán tạm ứng");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != spinEditMucThanhToanTamUngCoHuu.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = spinEditMucThanhToanTamUngCoHuu.EditValue.ToString();
                }


                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số cao học tính thêm theo văn bản");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != textEditHeSoTinhThem.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = textEditHeSoTinhThem.Text;
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Tính tạm ứng của lớp tự chọn theo sĩ số tối thiểu");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != checkEditTamUngTuChon.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = checkEditTamUngTuChon.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Tính tạm ứng cao học theo sĩ số kỳ trước");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != checkEditTamUngCaoHoc.EditValue.ToString())
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.GiaTri = checkEditTamUngCaoHoc.EditValue.ToString();
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Tính khối lượng khác vào giờ chuẩn");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != checkEditTinhKhoiLuongKhacVaoGioChuan.EditValue.ToString())
                    {
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                        objCauHinh.GiaTri = checkEditTinhKhoiLuongKhacVaoGioChuan.EditValue.ToString();
                    }
                }

                objCauHinh = listCauHinhChung.Find(p => p.TenCauHinh == "Đợt thanh toán hiện tại");
                if (objCauHinh != null)
                {
                    if (objCauHinh.GiaTri != cboDotHienTai.EditValue.ToString())
                    {
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                        objCauHinh.GiaTri = cboDotHienTai.EditValue.ToString();
                    }
                }
            }
            catch 
            {
                XtraMessageBox.Show("Lỗi cập nhật dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (listCauHinhChung != null)
                {
                    try
                    {
                        DataServices.CauHinhChung.Save(listCauHinhChung);
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xãy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    XtraMessageBox.Show("Đã xãy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridLookUpEditNamHocHienTai_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ViewNamHoc vNamHoc = bindingSourceNamHocHienTai.Current as ViewNamHoc;
            if (vNamHoc != null)
            {
                cboHocKyHienTai.DataBindings.Clear();
                bindingSourceHocKyHienTai.DataSource = DataServices.ViewHocKy.GetByNamHoc(vNamHoc.NamHoc);
                cboHocKyHienTai.DataBindings.Add("EditValue", bindingSourceHocKyHienTai, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn cập nhật toàn bộ mật khẩu cho giảng viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                TList<GiangVien> _listGiangVien = DataServices.GiangVien.GetAll();
                foreach (GiangVien obj in _listGiangVien)
                {
                    if (obj != null)
                    {
                        obj.MatKhau = EncodeMD5(obj.MaQuanLy, obj.MaQuanLy);
                        //DataServices.GiangVien.UpdatePassWord(obj.MaGiangVien, obj.MatKhau);
                    }
                }
                Cursor.Current = Cursors.Default;
                XtraMessageBox.Show("Cập nhật mật khẩu cho toàn bộ giảng viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region EncodeMD5(string userName, string password)
        public string EncodeMD5(string userName, string password)
        {
            string result = string.Empty;
            try
            {
                result = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile("UisStaffID=" + userName.ToUpper() + ";UisPassword=" + password, "MD5");
                if (_maTruong == "BUH")
                    result = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5");
            }
            catch
            {
                result = string.Empty;
            }
            return result;
        }
        #endregion

        #region btnDongBo_Click
        private void btnDongBo_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn muốn đồng bộ dữ liệu giảng viên từ hệ thống Nhân sự HRM?\nQuá trình đồng bộ có thể mất một vài phút...", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    DataServices.GiangVien.DongBoDuLieuHRM();
                    Cursor.Current = Cursors.Default;
                    XtraMessageBox.Show("Đồng bộ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình đồng bộ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}
