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

namespace PMS.UI.Forms.NghiepVu.KhongChinhQuy
{
    public partial class frmXuLyDongBoDuLieu_Kcq : DevExpress.XtraEditors.XtraForm
    {
        private const int CP_NOCLOSE_BUTTON = 0x200;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams myCp = base.CreateParams;
        //        myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
        //        return myCp;
        //    }
        //} 
        private string namhoc;
        private string hocky;
        private string maTruong;
        private string maDonVi;
        DateTime TuNgay, DenNgay;
        int q;
        public frmXuLyDongBoDuLieu_Kcq()
        {
            InitializeComponent();
        }
        public frmXuLyDongBoDuLieu_Kcq(string namhoc,string hocky)
        {
            InitializeComponent();
            this.namhoc = namhoc;
            this.hocky = hocky;
            
        }

        public frmXuLyDongBoDuLieu_Kcq(string namhoc, string hocky, string _maTruong)
        {
            InitializeComponent();
            this.namhoc = namhoc;
            this.hocky = hocky;
            this.maTruong = _maTruong;
        }

        public frmXuLyDongBoDuLieu_Kcq(string namhoc, string hocky, string _maTruong, string _maDonVi)
        {
            InitializeComponent();
            this.namhoc = namhoc;
            this.hocky = hocky;
            this.maTruong = _maTruong;
            this.maDonVi = _maDonVi;
        }

        public frmXuLyDongBoDuLieu_Kcq(DateTime _tuNgay, DateTime _denNgay, string _maTruong)
        {
            InitializeComponent();
            TuNgay = _tuNgay;
            DenNgay = _denNgay;
            maTruong = _maTruong;
        }

        private void frmXuLyDongBoDuLieu_Load(object sender, EventArgs e)
        {

            progressBar.Properties.Minimum = 0;
            progressBar.Position = 0;
            marqueeProgressBarControl1.Text = "Đang xử lý...";
            
            //Do worker
            backgroundWorker.RunWorkerAsync();

           // button1_Click(sender, e); 
           
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (maTruong == "UTE" || maTruong == "UEH")
            {
                int kiemtra = 0;
                DataServices.KcqUteKhoiLuongGiangDay.KiemTraDongBo(namhoc, hocky, ref kiemtra);
                if (kiemtra == 1)
                    if (XtraMessageBox.Show(string.Format("Khối lượng giảng dạy của năm học {0} - {1} đã được đồng bộ. Đồng bộ lại sẽ xoá dữ liệu cũ. \nBạn có muốn đồng bộ hay không?", namhoc, hocky), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataServices.KcqUteKhoiLuongGiangDay.DongBo(namhoc, hocky);
                        q = 1;
                    }
                if(kiemtra == 2)
                {
                    if (XtraMessageBox.Show(string.Format("Khối lượng giảng dạy của năm học {0} - {1} đã được quy đổi. Đồng bộ lại sẽ xoá dữ liệu đã quy đổi. \nBạn có muốn đồng bộ hay không?", namhoc, hocky), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataServices.KcqUteKhoiLuongGiangDay.DongBo(namhoc, hocky);
                        q = 1;
                    }
                }
                if (kiemtra == 0)
                {
                    DataServices.KcqUteKhoiLuongGiangDay.DongBo(namhoc, hocky);
                    q = 1;
                }
            }
            else
            {
                if (maTruong == "TCB")
                {
                    DataServices.ViewKhoiLuongGiangDay.DongBoTheoNgay(TuNgay, DenNgay);
                    q = 1;
                }
                else//  maTruong == "USSH", "LAW", "ACT", "UEL", "CTIM", "BUH", "IUH", "CDGTVT"
                {
                    if (maDonVi != "" && maDonVi != null)
                    {
                        DataServices.ViewKhoiLuongGiangDay.DongBoTheoDonVi(namhoc, hocky, maDonVi);
                        DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKyMaDonVi(namhoc, hocky, maDonVi);
                    }
                    else
                    {

                        DataServices.ViewKhoiLuongGiangDay.DongBo(namhoc, hocky);
                        DataServices.KhoiLuongQuyDoi.DeleteByNamHocHocKy(namhoc, hocky);
                    }
                    q = 1;
                }
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
            if (q == 1)
                XtraMessageBox.Show("Đã hoàn tất việc đồng bộ dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}