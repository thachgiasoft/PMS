using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmXuLyDongBoDuLieu : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        private const int CP_NOCLOSE_BUTTON = 0x200;
        private string namhoc;
        private string hocky;
        private string maTruong;
        private string maDonVi;
        DateTime TuNgay, DenNgay;
        int q; string message;
        bool TamUng = false;
        int DotThanhToan;
        #endregion

        #region Event Form
        public frmXuLyDongBoDuLieu()
        {
            InitializeComponent();
        }
        public frmXuLyDongBoDuLieu(string namhoc,string hocky)
        {
            InitializeComponent();
            this.namhoc = namhoc;
            this.hocky = hocky;
            
        }

        public frmXuLyDongBoDuLieu(string namhoc, string hocky, string _maTruong)
        {
            InitializeComponent();
            this.namhoc = namhoc;
            this.hocky = hocky;
            this.maTruong = _maTruong;
        }

        public frmXuLyDongBoDuLieu(string namhoc, string hocky, int _dotThanhToan, string _maTruong)
        {
            InitializeComponent();
            this.namhoc = namhoc;
            this.hocky = hocky;
            DotThanhToan = _dotThanhToan;
            this.maTruong = _maTruong;
        }

        public frmXuLyDongBoDuLieu(string namhoc, string hocky, string _maTruong, string _maDonVi)
        {
            InitializeComponent();
            this.namhoc = namhoc;
            this.hocky = hocky;
            this.maTruong = _maTruong;
            this.maDonVi = _maDonVi;
        }

        public frmXuLyDongBoDuLieu(DateTime _tuNgay, DateTime _denNgay, string _maTruong)
        {
            InitializeComponent();
            TuNgay = _tuNgay;
            DenNgay = _denNgay;
            maTruong = _maTruong;
        }

        public frmXuLyDongBoDuLieu(string namhoc, string hocky, string _maTruong, bool _tamUng)
        {
            InitializeComponent();
            this.namhoc = namhoc;
            this.hocky = hocky;
            this.maTruong = _maTruong;
            TamUng = _tamUng;
        }

        private void frmXuLyDongBoDuLieu_Load(object sender, EventArgs e)
        {

            progressBar.Properties.Minimum = 0;
            progressBar.Position = 0;
            marqueeProgressBarControl1.Text = "Đang đồng bộ, xin vui lòng chờ trong ít phút...";
            
            //Do worker
            backgroundWorker.RunWorkerAsync();

           // button1_Click(sender, e); 
           
        }
        #endregion

        #region Event BackgroundWorker
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (maTruong)
            {
                case "UTE":
                    DongBoUTE();
                    break;
                case "UEH":
                    DongBoUEH();
                    break;
                case "TCB":
                    DongBoTCB();
                    break;
                case "LAW":
                    if (TamUng)
                        DongBoTamUng();
                    else 
                        DongBoCacTruongConLai();
                    break;
                case "DLU":
                    DongBoDLU();
                    break;
                default:
                    DongBoCacTruongConLai();
                    break;
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
            if (q == 1)
            {
                XtraMessageBox.Show("Đã hoàn tất việc đồng bộ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Quá trình đồng bộ dữ liệu thất bại.\n" + message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        #endregion

        #region Ham xu ly dong bo cac truong

        void DongBoUTE()
        {
            int kiemtra = 0;
            DataServices.UteKhoiLuongGiangDay.KiemTraDongBo(namhoc, hocky, ref kiemtra);
            if (kiemtra == 1)
                if (XtraMessageBox.Show(string.Format("Khối lượng giảng dạy của năm học {0} - {1} đã được đồng bộ. Đồng bộ lại sẽ xoá dữ liệu cũ. \nBạn có muốn đồng bộ hay không?", namhoc, hocky), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataServices.UteKhoiLuongGiangDay.DongBo(namhoc, hocky);
                    q = 1;
                }
            if (kiemtra == 2)
            {
                if (XtraMessageBox.Show(string.Format("Khối lượng giảng dạy của năm học {0} - {1} đã được quy đổi. Đồng bộ lại sẽ xoá dữ liệu đã quy đổi. \nBạn có muốn đồng bộ hay không?", namhoc, hocky), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataServices.UteKhoiLuongGiangDay.DongBo(namhoc, hocky);
                    q = 1;
                }
            }
            if (kiemtra == 0)
            {
                DataServices.UteKhoiLuongGiangDay.DongBo(namhoc, hocky);
                q = 1;
            }
        }

        void DongBoUEH()
        {
            int kiemtra = 0;
            DataServices.UteKhoiLuongGiangDay.KiemTraDongBo(namhoc, hocky, ref kiemtra);
            if (kiemtra == 1)
                if (XtraMessageBox.Show(string.Format("Khối lượng giảng dạy của năm học {0} - {1} đã được đồng bộ. Đồng bộ lại sẽ xoá dữ liệu cũ. \nBạn có muốn đồng bộ hay không?", namhoc, hocky), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataServices.UteKhoiLuongGiangDay.DongBo(namhoc, hocky);
                    q = 1;
                }
            if (kiemtra == 2)
            {
                if (XtraMessageBox.Show(string.Format("Khối lượng giảng dạy của năm học {0} - {1} đã được quy đổi. Đồng bộ lại sẽ xoá dữ liệu đã quy đổi. \nBạn có muốn đồng bộ hay không?", namhoc, hocky), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataServices.UteKhoiLuongGiangDay.DongBo(namhoc, hocky);
                    q = 1;
                }
            }
            if (kiemtra == 0)
            {
                DataServices.UteKhoiLuongGiangDay.DongBo(namhoc, hocky);
                q = 1;
            }
        }

        void DongBoTCB()
        {
            DataServices.ViewKhoiLuongGiangDay.DongBoTheoNgay(TuNgay, DenNgay);
            q = 1;
        }


        void DongBoDLU()    //Đồng bộ theo đợt
        {
            try
            {
                if (DotThanhToan != 0)
                {
                    DataServices.ViewKhoiLuongGiangDay.DongBoTheoDot(namhoc, hocky, DotThanhToan);
                }
                else
                {
                    DataServices.ViewKhoiLuongGiangDay.DongBo(namhoc, hocky);
                }
                q = 1;
            }
            catch (Exception ex)
            {
                message = ex.Message + "\n" + ex.StackTrace;
                q = 0;
            }
        }

        void DongBoCacTruongConLai()
        {
            try
            {
                if (maDonVi != "" && maDonVi != null)
                {
                    DataServices.ViewKhoiLuongGiangDay.DongBoTheoDonVi(namhoc, hocky, maDonVi);
                    //DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKyMaDonVi(namhoc, hocky, maDonVi);
                }
                else
                {
                    DataServices.ViewKhoiLuongGiangDay.DongBo(namhoc, hocky);
                    //DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(namhoc, hocky);
                }
                q = 1;
            }
            catch (Exception ex)
            {
               q = 0;
                message = ex.Message;
                throw;
            }
        }

        void DongBoTamUng()
        {
            try
            {
                DataServices.KhoiLuongTamUng.DongBo(namhoc, hocky);
                q = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                q = 0;
            }
            
        }

        #endregion
    }
}