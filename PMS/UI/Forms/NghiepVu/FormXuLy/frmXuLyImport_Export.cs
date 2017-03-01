using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using PMS.Entities;

namespace PMS.UI.Forms.NghiepVu
{

    public partial class frmXuLyImport_Export : DevExpress.XtraEditors.XtraForm
    {
        private bool hocham;
        private bool hocvi;
        private bool tinhtrang;
        private bool loaigv;
        private bool giangvien;
        private DataSet ds;

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        } 

        public frmXuLyImport_Export()
        {
            InitializeComponent();
        }
        public frmXuLyImport_Export(DataSet ds,bool hocham,bool hocvi,bool loaigv,bool tinhtrang,bool giangvien)
        {
            InitializeComponent();
            this.ds= new DataSet();
            this.ds = ds;
            this.hocham = hocham;
            this.hocvi = hocvi;
            this.loaigv = loaigv;
            this.tinhtrang = tinhtrang;
            this.giangvien = giangvien;
        }

        private void frmXuLyImport_Export_Load(object sender, EventArgs e)
        {

            progressBar.Properties.Minimum = 0;
            progressBar.Position = 0;

            //Do worker
            backgroundWorker.RunWorkerAsync();
        }


        private void backgroundWorker_DoWork_1(object sender, DoWorkEventArgs e)
        {

            //#region Import hoc ham
            //if (hocham)
            //{
            //    DataTable b = ds.Tables["hocham$"];
            //    if (b != null)
            //    {
            //        StringBuilder oxmldata = new StringBuilder("<Root>");
            //        for (int i = 0; i < b.Rows.Count; i++)
            //        {
            //            if (string.IsNullOrEmpty(b.Rows[i]["MaHocHam"].ToString()) != true)
            //            {
            //                oxmldata.Append("<HocHam MaQuanLy=\"");

            //                oxmldata.Append(b.Rows[i]["MaHocHam"].ToString());
            //                oxmldata.Append("\" TenHocHam=\"");
            //                oxmldata.Append(b.Rows[i]["TenHocHam"].ToString());

            //                oxmldata.Append("\"></HocHam>");
            //            }
            //        }
            //        oxmldata.Append("</Root>");
            //        DataServices.HocHam.ImportExcel(oxmldata.ToString());
                    
            //    }
            //    else
            //    {
            //        XtraMessageBox.Show("File Excel chưa có sheet Học Hàm.\n Dữ liệu không thể import được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //}
            //#endregion
            //#region Import hoc vi
            //if (hocvi)
            //{
            //    DataTable b = ds.Tables["hocvi$"];
            //    if (b != null)
            //    {
            //        StringBuilder oxmldata = new StringBuilder("<Root>");
            //        for (int i = 0; i < b.Rows.Count; i++)
            //        {
            //            if (string.IsNullOrEmpty(b.Rows[i]["MaHocVi"].ToString()) != true)
            //            {
            //                oxmldata.Append("<HocVi MaQuanLy=\"");

            //                oxmldata.Append(b.Rows[i]["MaHocVi"].ToString());
            //                oxmldata.Append("\" TenHocVi=\"");
            //                oxmldata.Append(b.Rows[i]["TenHocVi"].ToString());

            //                oxmldata.Append("\"></HocVi>");
            //            }
            //        }
            //        oxmldata.Append("</Root>");
            //        DataServices.HocVi.ImportExcel(oxmldata.ToString());
            //    }
            //    else
            //    {
            //        XtraMessageBox.Show("File Excel chưa có sheet Học Vị.\n Dữ liệu không thể import được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //}
            //#endregion
            //#region Import _loai giang vien
            //if (loaigv)
            //{
            //    DataTable b = ds.Tables["loaigiangvien$"];
            //    if (b != null)
            //    {
            //        StringBuilder oxmldata = new StringBuilder("<Root>");
            //        for (int i = 0; i < b.Rows.Count; i++)
            //        {
            //            if (string.IsNullOrEmpty(b.Rows[i]["MaLoaiGiangVien"].ToString()) != true)
            //            {
            //                oxmldata.Append("<LoaiGiangVien MaQuanLy=\"");

            //                oxmldata.Append(b.Rows[i]["MaLoaiGiangVien"].ToString());
            //                oxmldata.Append("\" TenLoaiGiangVien=\"");
            //                oxmldata.Append(b.Rows[i]["TenLoaiGiangVien"].ToString());

            //                oxmldata.Append("\"></LoaiGiangVien>");
            //            }
            //        }
            //        oxmldata.Append("</Root>");
            //        DataServices.LoaiGiangVien.ImportExcel(oxmldata.ToString());
            //    }
            //    else
            //    {
            //        XtraMessageBox.Show("File Excel chưa có sheet Loại Giảng Viên.\n Dữ liệu không thể import được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //}
            //#endregion
            //#region Import tinh trang giang day
            //if (tinhtrang)
            //{
            //    DataTable b = ds.Tables["tinhtrang$"];
            //    if (b != null)
            //    {
            //        StringBuilder oxmldata = new StringBuilder("<Root>");
            //        for (int i = 0; i < b.Rows.Count; i++)
            //        {
            //            if (string.IsNullOrEmpty(b.Rows[i]["MaTinhTrang"].ToString()) != true)
            //            {
            //                oxmldata.Append("<TinhTrang MaQuanLy=\"");

            //                oxmldata.Append(b.Rows[i]["MaTinhTrang"].ToString());
            //                oxmldata.Append("\" TenTinhTrang=\"");
            //                oxmldata.Append(b.Rows[i]["TenTinhTrang"].ToString());

            //                oxmldata.Append("\"></TinhTrang>");
            //            }
            //        }
            //        oxmldata.Append("</Root>");
            //        DataServices.TinhTrang.ImportExcel(oxmldata.ToString());
            //    }
            //    else
            //    {
            //        XtraMessageBox.Show("File Excel chưa có sheet Tình Trạng.\n Dữ liệu không thể import được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //}
            //#endregion
            //#region Import giang vien
            //if (giangvien)
            //{
                 
            //    StringBuilder oxmldata = new StringBuilder("<Root>");
            //    try
            //    {
            //        try
            //        {
            //            //table giang vien
            //            int index = 1;
            //            DataTable b = ds.Tables["giangvien$"];
            //            int process = b.Rows.Count;
            //            if (!backgroundWorker.CancellationPending)
            //            {
                            
            //                if (b != null)
            //                {
            //                    int emptyRows = 0;
            //                    for (int i = 0; i < b.Rows.Count; i++)
            //                    {
            //                        backgroundWorker.ReportProgress(index++ * 100 / process, String.Format("Mã số {0}", i));
            //                        emptyRows = i;
                                    
            //                        if (string.IsNullOrEmpty(b.Rows[i]["MaQuanLy"].ToString()) != true)
            //                        {

            //                            oxmldata.Append("<GiangVien MaQuanLy=\"");
            //                            oxmldata.Append(b.Rows[i]["MaQuanLy"].ToString());
            //                            oxmldata.Append("\" Ho=\"");
            //                            oxmldata.Append(b.Rows[i]["Ho"].ToString());
            //                            oxmldata.Append("\" TenDem=\"");
            //                            oxmldata.Append(b.Rows[i]["TenDem"].ToString());
            //                            oxmldata.Append("\" Ten=\"");
            //                            oxmldata.Append(b.Rows[i]["Ten"].ToString());

            //                            oxmldata.Append("\" NgaySinh=\"");
            //                            oxmldata.Append(b.Rows[i]["NgaySinh"].ToString());
            //                            oxmldata.Append("\" GioiTinh=\"");
            //                            oxmldata.Append(b.Rows[i]["GioiTinh"].ToString());
            //                            oxmldata.Append("\" NoiSinh=\"");
            //                            oxmldata.Append(b.Rows[i]["NoiSinh"].ToString());
            //                            oxmldata.Append("\" Cmnd=\"");
            //                            oxmldata.Append(b.Rows[i]["Cmnd"].ToString());
            //                            oxmldata.Append("\" NgayCap=\"");
            //                            oxmldata.Append(b.Rows[i]["NgayCap"].ToString());
            //                            oxmldata.Append("\" NoiCap=\"");
            //                            oxmldata.Append(b.Rows[i]["NoiCap"].ToString());
            //                            oxmldata.Append("\" DoanDang=\"");
            //                            oxmldata.Append(b.Rows[i]["DoanDang"].ToString());
            //                            oxmldata.Append("\" NgayVaoDoanDang=\"");
            //                            oxmldata.Append(b.Rows[i]["NgayVaoDoanDang"].ToString());
            //                            oxmldata.Append("\" NgayKyHopDong=\"");
            //                            oxmldata.Append(b.Rows[i]["NgayKyHopDong"].ToString());
            //                            oxmldata.Append("\" NgayKetThucHopDong=\"");
            //                            oxmldata.Append(b.Rows[i]["NgayKetThucHopDong"].ToString());
            //                            oxmldata.Append("\" DiaChi=\"");
            //                            oxmldata.Append(b.Rows[i]["DiaChi"].ToString());

            //                            oxmldata.Append("\" ThuongTru=\"");
            //                            oxmldata.Append(b.Rows[i]["ThuongTru"].ToString());
            //                            oxmldata.Append("\" NoiLamviec=\"");
            //                            oxmldata.Append(b.Rows[i]["NoiLamviec"].ToString());
            //                            oxmldata.Append("\" Email=\"");
            //                            oxmldata.Append(b.Rows[i]["Email"].ToString());
            //                            oxmldata.Append("\" DienThoai=\"");
            //                            oxmldata.Append(b.Rows[i]["DienThoai"].ToString());
            //                            oxmldata.Append("\" SoDiDong=\"");
            //                            oxmldata.Append(b.Rows[i]["SoDiDong"].ToString());
            //                            oxmldata.Append("\" SoTaiKhoan=\"");
            //                            oxmldata.Append(b.Rows[i]["SoTaiKhoan"].ToString());
            //                            oxmldata.Append("\" TenNganHang=\"");
            //                            oxmldata.Append(b.Rows[i]["TenNganHang"].ToString());
            //                            oxmldata.Append("\" MaSoThue=\"");
            //                            oxmldata.Append(b.Rows[i]["MaSoThue"].ToString());
            //                            oxmldata.Append("\" ChiNhanh=\"");
            //                            oxmldata.Append(b.Rows[i]["ChiNhanh"].ToString());
            //                            oxmldata.Append("\" SoSoBaoHiem=\"");
            //                            oxmldata.Append(b.Rows[i]["SoSoBaoHiem"].ToString());
            //                            oxmldata.Append("\" ThoiGianBatDau=\"");
            //                            oxmldata.Append(b.Rows[i]["ThoiGianBatDau"].ToString());

            //                            oxmldata.Append("\" BacLuong=\"");
            //                            oxmldata.Append(b.Rows[i]["BacLuong"].ToString());
            //                            oxmldata.Append("\" NgayHuongLuong=\"");
            //                            oxmldata.Append(b.Rows[i]["NgayHuongLuong"].ToString());
            //                            oxmldata.Append("\" NamLamViec=\"");
            //                            oxmldata.Append(b.Rows[i]["NamLamViec"].ToString());
            //                            //oxmldata.Append("\" ChuyenNganh=\"");
            //                            //oxmldata.Append(b.Rows[i]["ChuyenNganh"].ToString());
            //                            oxmldata.Append("\" MaHeSoThuLao=\"");
            //                            oxmldata.Append(b.Rows[i]["MaHeSoThuLao"].ToString());
            //                            oxmldata.Append("\" MaDanToc=\"");
            //                            oxmldata.Append(b.Rows[i]["MaDanToc"].ToString());
            //                            oxmldata.Append("\" MaTonGiao=\"");
            //                            oxmldata.Append(b.Rows[i]["MaTonGiao"].ToString());
            //                            oxmldata.Append("\" MaDonVi=\"");
            //                            oxmldata.Append(b.Rows[i]["MaDonVi"].ToString());
            //                            oxmldata.Append("\" MaHocHam=\"");
            //                            oxmldata.Append(b.Rows[i]["MaHocHam"].ToString());
            //                            oxmldata.Append("\" MaHocVi=\"");
            //                            oxmldata.Append(b.Rows[i]["MaHocVi"].ToString());
            //                            oxmldata.Append("\" MaLoaiGiangVien=\"");
            //                            oxmldata.Append(b.Rows[i]["MaLoaiGiangVien"].ToString());
            //                            oxmldata.Append("\" MaTinhTrang=\"");
            //                            oxmldata.Append(b.Rows[i]["MaTinhTrang"].ToString());
            //                            oxmldata.Append("\" MatKhau=\"");
            //                            oxmldata.Append(b.Rows[i]["MatKhau"].ToString());



            //                            oxmldata.Append("\"></GiangVien>");
            //                            //oxmldata.Append("</Root>");
            //                            //DataServices.GiangVien.ImportExcel(oxmldata.ToString(), b.Rows[i]["MaQuanLy"].ToString());
            //                            //oxmldata.Length = 0;
            //                            //oxmldata.Append("<Root>");

            //                        }
                                
            //                        else
            //                        {
            //                            //if (i != b.Rows.Count - 1)
            //                            //{
            //                            //    emptyRows = emptyRows + 2;
            //                            //    XtraMessageBox.Show("Dòng số [" + emptyRows + "] trong file bị trống.\n Vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                            //    return;
            //                            //}
            //                        }
                                   
            //                    }
            //                    oxmldata.Append("</Root>");
            //                    DataServices.GiangVien.ImportExcel(oxmldata.ToString(), "");
                               
            //                }
            //                else
            //                {
            //                    XtraMessageBox.Show("File Excel chưa có sheet Giảng viên.\n Dữ liệu không thể import được.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    return;
            //                }
            //            }
            //        }
            //        catch (ArgumentOutOfRangeException ex)
            //        {
            //            XtraMessageBox.Show(ex.Message, "Exception ArgumentOutOfRangeException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        finally
            //        {
            //            oxmldata.Length = 0;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        XtraMessageBox.Show("Lỗi Import dữ liệu từ Excel. Vui lòng Liên hệ người phụ trách \n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    Cursor.Current = Cursors.Default;

        //    #endregion
        //    }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            XtraMessageBox.Show("Bạn đã import dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Position = e.ProgressPercentage;
            progressBar.Update();
        }

    }
}