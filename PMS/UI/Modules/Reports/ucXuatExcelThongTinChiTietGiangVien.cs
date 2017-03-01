using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.UI.Modules.Reports;
using PMS.Entities;
using ExcelLibrary;
using DevExpress.Common.DataForm;
using PMS.UI.Forms.BaoCao;
using PMS.BLL;
using PMS.Services;
using DevExpress.XtraGrid;
using DevExpress.Common.Grid;

namespace PMS.UI.Modules.Reports
{
    public partial class ucXuatExcelThongTinChiTietGiangVien : DevExpress.XtraEditors.XtraUserControl
    {
        private DataSet dsGiangVien;
        string groupname = UserInfo.GroupName;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        private bool user = false;
        //private ucThongKeThongTinChiTietGiangVien;
        DataTable tbgv = new DataTable();
        DataTable tbField = new DataTable();
        DataTable table = new DataTable();
        int countClickbtn = 0;
        string[] fieldName, capTion;

        public ucXuatExcelThongTinChiTietGiangVien()
        {
            InitializeComponent();
        }

        private void frmXuatExcelThongTinChiTietGiangVien_Load(object sender, EventArgs e)
        {
            InitGrid();
            //AppGridView.HideField(gridViewXuatExcel, new string[] { "Field" });
            //gridViewXuatExcel.Columns[0].Visible = false;
        }

        public void InitGrid()
        {
            
            tbField.Columns.Add("Field", typeof(string));
            tbField.Columns["Field"].Caption = "Tên cột hệ thống";
   
            tbField.Columns.Add("CapTion", typeof(string));
            tbField.Columns["CapTion"].Caption = "Tên cột";
            tbField.Columns.Add("Check", typeof(bool));
            tbField.Columns["Check"].Caption = "Chọn";
            tbField.Rows.Add(new Object[] { "MaQuanLy", "Mã giảng viên", null });      
            tbField.Rows.Add(new Object[] { "Ho", "Họ",null });
            tbField.Rows.Add(new Object[] { "Ten","Tên",null });
            tbField.Rows.Add(new Object[] { "Khoa","Đơn vị trực thuộc",null });
            tbField.Rows.Add(new Object[] { "DonViGiangDay", "Đơn vị giảng dạy", null });
            tbField.Rows.Add(new Object[] { "MaHocHam", "Mã học hàm",null });
            tbField.Rows.Add(new Object[] { "TenHocHam","Học hàm",null });
            tbField.Rows.Add(new Object[] { "MaHocVi","Mã học vị",null });
            tbField.Rows.Add(new Object[] { "TenHocVi","Học vị",null });
            tbField.Rows.Add(new Object[] { "TenLoaiGiangVien","Loại giảng viên",null });
            tbField.Rows.Add(new Object[] { "GioiTinh","Giới tính",null });
            tbField.Rows.Add(new Object[] { "NgaySinh","Ngày sinh",null });
            tbField.Rows.Add(new Object[] { "NoiSinh", "Nơi sinh",null });
            tbField.Rows.Add(new Object[] { "Cmnd", "CMND",null });
            tbField.Rows.Add(new Object[] { "NgayCap","Ngày cấp",null });
            tbField.Rows.Add(new Object[] { "NoiCap","Nơi cấp",null });
            tbField.Rows.Add(new Object[] { "TenDanToc", "Dân tộc",null });
            tbField.Rows.Add(new Object[] { "TenTonGiao","Tôn giáo",null });
            tbField.Rows.Add(new Object[] { "DoanDang","Đoàn đảng",null });
            tbField.Rows.Add(new Object[] { "NgayVaoDoanDang","Ngày vào đoàn đảng",null });
            tbField.Rows.Add(new Object[] { "DiaChi","Địa chỉ",null });
            tbField.Rows.Add(new Object[] { "ThuongTru", "Thường trú",null });
            tbField.Rows.Add(new Object[] { "Email","E-mail",null });
            tbField.Rows.Add(new Object[] { "DienThoai","Điện thoại",null });
            tbField.Rows.Add(new Object[] { "SoDiDong","Số di động",null });
            tbField.Rows.Add(new Object[] { "NoiLamViec", "Nơi làm việc",null });
            tbField.Rows.Add(new Object[] { "NgayKyHopDong", "Ngày ký hợp đồng",null });
            tbField.Rows.Add(new Object[] { "NgayKetThucHopDong", "Ngày kết thúc hợp đồng",null });
            tbField.Rows.Add(new Object[] { "TenChucVu", "Chức vụ", null });
            tbField.Rows.Add(new Object[] { "TenTinhTrang", "Tình trạng",null });
            tbField.Rows.Add(new Object[] { "SoTaiKhoan", "Số tài khoản",null });
            tbField.Rows.Add(new Object[] { "TenNganHang", "Tên ngân hàng",null });
            tbField.Rows.Add(new Object[] { "MaSoThue", "Mã số thuế",null });
            tbField.Rows.Add(new Object[] { "ChiNhanh", "Chi nhánh ngân hàng",null });
            tbField.Rows.Add(new Object[] { "SoSoBaoHiem", "Số sổ bảo hiểm",null });
            tbField.Rows.Add(new Object[] { "ThoiGianBatDau", "Thời gian bắt đầu",null });
            tbField.Rows.Add(new Object[] { "BacLuong", "Bậc lương",null });
            tbField.Rows.Add(new Object[] { "NgayHuongLuong",  "Ngày hưởng lương",null });
            tbField.Rows.Add(new Object[] { "NamLamViec", "Năm làm việc",null });
            tbField.Rows.Add(new Object[] { "ChuyenNganh", "Chuyên ngành",null });
            tbField.Rows.Add(new Object[] { "Ngach", "Ngạch",null });
            tbField.Rows.Add(new Object[] { "SoHieuCongChuc", "Số hiệu công chức",null });
            tbField.Rows.Add(new Object[] { "NoiCapBang", "Nơi cấp bằng",null });
            tbField.Rows.Add(new Object[] { "KhoaTaiKhoan", "Khóa tài khoản",null });
            tbField.Rows.Add(new Object[] { "TenLoaiNhanVien", "Loại nhân viên",null });
            tbField.Rows.Add(new Object[] { "TenNgach" , "Ngạch công chức",null });
            tbField.Rows.Add(new Object[] { "TenTrinhDoChinhTri", "Trình độ chính trị",null });
            tbField.Rows.Add(new Object[] { "TenTrinhDoSuPham", "Trình độ sư phạm",null });
            tbField.Rows.Add(new Object[] { "TenTrinhDoNgoaiNgu", "Trình độ ngoại ngữ",null });
            tbField.Rows.Add(new Object[] { "TenTrinhDoTinHoc", "Trình độ tin học",null });
            tbField.Rows.Add(new Object[] { "TenTrinhDoQuanLyNhaNuoc", "Trình độ quản lý nhà nước",null });
            tbField.Rows.Add(new Object[] { "NgayCapNhat", "Ngày cập nhật",null });
            tbField.Rows.Add(new Object[] { "NguoiCapNhat", "Người cập nhật",null });
            tbField.Columns[0].ColumnMapping = MappingType.Hidden;
            bindingSourceXuatExcel.DataSource = tbField;
             
        }

        


        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                gridViewXuatExcel.FocusedRowHandle = 0;
                fieldName = new string[tbField.Select("Check = 'True'").Length];
                capTion = new string[tbField.Select("Check = 'True'").Length];
                int i = 0;


                for (int j = 0; j < tbField.Rows.Count; j++)
                {
                    if (tbField.Rows[j]["Check"].ToString() == "True")
                    {
                        if (i >= fieldName.Length)
                        {
                            Array.Resize(ref fieldName, fieldName.Length + 1);
                            Array.Resize(ref capTion, capTion.Length + 1);
                        }
                        capTion[i] = tbField.Rows[j]["CapTion"].ToString();
                        fieldName[i] = tbField.Rows[j]["Field"].ToString();
                        if (i < fieldName.Length)
                            i++;

                    }
                }


                if (i >= 1)
                {

                    using (ucThongKeThongTinChiTietGiangVien frm = new ucThongKeThongTinChiTietGiangVien(fieldName, capTion))
                    {
                        frm.ShowDialog();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Chưa chọn cột để lấy dữ liệu.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                //fieldName = new string[tbField.Select("Check = 'True'").Length + 1];
                //capTion = new string[tbField.Select("Check = 'True'").Length + 1];
            }

           
        }



        private void checkEditChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
             if (checkEditChonTatCa.EditValue.ToString() == "True")
            {
                for (int k = 0; k < gridViewXuatExcel.DataRowCount; k++)
                {
                    gridViewXuatExcel.SetRowCellValue(k, "Check", "True");
                }      
             }

             if (checkEditChonTatCa.EditValue.ToString() == "False")
             {
                 for (int k = 0; k < gridViewXuatExcel.DataRowCount;k++)
                 {
                     gridViewXuatExcel.SetRowCellValue(k, "Check", "False");
                 }      
             }
        }
    }
}