using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.Common.Grid;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmImportGiangVien : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        DataTable dt = new DataTable();
        #endregion
        public frmImportGiangVien()
        {
            InitializeComponent();
        }

        private void frmImportGiangVien_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewGiangVienImport, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewGiangVienImport, new string[] { "MaQuanLy", "HoTen", "MaDonVi", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaTinhTrang", "MatKhau", "NgaySinh", "GioiTinh", "NoiSinh", "Cmnd", "NgayCap", "NoiCap", "Email", "DienThoai", "SoDiDong", "Ngach", "SoHieuCongChuc", "DoanDang", "NgayVaoDoanDang", "ngayKyHopDong", "NgayKetThucHopDong", "DiaChi", "ThuongTru", "NoiLamViec", "SoTaiKhoan", "TenNganHang", "MaSoThue", "ChiNhanh", "SoSoBaoHiem", "ThoiGianBatDau", "BacLuong", "NgayHuongLuong", "NamLamViec", "ChuyenNganh", "MaHeSoThuLao", "NoiCapBang" },
                new string[] { "Mã giảng viên", "Họ và tên", "Mã đơn vị", "Mã học hàm", "Mã học vị", "Mã loại giảng viên", "Mã tình trạng", "Mật khẩu", "Ngày sinh", "Giới tính", "Nơi sinh", "Cmnd", "Ngày cấp", "Nơi cấp", "Email", "Điện thoại", "Di động", "Ngạch", "Số hiệu công chức", "Đoàn (đảng)", "Ngày vào đoàn (đảng)", "Ngày ký hợp đồng", "Ngày kết thúc hợp đồng", "Địa chỉ tạm trú", "Địa chỉ thường trú", "Nơi làm việc", "Số tài khoản", "Tên ngân hàng", "Mã số thuế", "Chi nhánh", "Số sổ bảo hiểm", "Thời gian bắt đầu", "Bậc lương", "Ngày hưởng lương", "Năm làm việc", "Chuyên ngành", "Mã hệ số thù lao", "Nơi cấp bằng" }
                , new int[] { 90, 130, 80, 80, 80, 110, 100, 60, 70, 70, 70, 60, 70, 70, 60, 70, 70, 60, 100, 60, 100, 100, 110, 100, 100, 80, 80, 80, 80, 70, 90, 100, 70, 90, 90, 80, 110, 100 });
            AppGridView.AlignHeader(gridViewGiangVienImport, new string[] { "MaQuanLy", "HoTen", "MaDonVi", "MaHocHam", "MaHocVi", "MaLoaiGiangVien", "MaTinhTrang", "MatKhau", "NgaySinh", "GioiTinh", "NoiSinh", "Cmnd", "NgayCap", "NoiCap", "Email", "DienThoai", "SoDiDong", "Ngach", "SoHieuCongChuc", "DoanDang", "NgayVaoDoanDang", "ngayKyHopDong", "NgayKetThucHopDong", "DiaChi", "ThuongTru", "NoiLamViec", "SoTaiKhoan", "TenNganHang", "MaSoThue", "ChiNhanh", "SoSoBaoHiem", "ThoiGianBatDau", "BacLuong", "NgayHuongLuong", "NamLamViec", "ChuyenNganh", "MaHeSoThuLao", "NoiCapBang" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewGiangVienImport);
            #endregion

            #region datatable
            dt.Columns.Add(new DataColumn("MaQuanLy"));
            dt.Columns["MaQuanLy"].Caption = "Mã giảng viên";
            dt.Columns.Add(new DataColumn("HoTen"));
            dt.Columns["HoTen"].Caption = "Họ và tên";
            dt.Columns.Add(new DataColumn("MaDonVi"));
            dt.Columns["MaDonVi"].Caption = "Mã đơn vị";
            dt.Columns.Add(new DataColumn("MaHocHam"));
            dt.Columns["MaHocHam"].Caption = "Mã học hàm";
            dt.Columns.Add(new DataColumn("MaHocVi"));
            dt.Columns["MaHocVi"].Caption = "Mã học vị";
            dt.Columns.Add(new DataColumn("MaLoaiGiangVien"));
            dt.Columns["MaLoaiGiangVien"].Caption = "Mã loại giảng viên";
            dt.Columns.Add(new DataColumn("MaTinhTrang"));
            dt.Columns["MaTinhTrang"].Caption = "Mã tình trạng";
            dt.Columns.Add(new DataColumn("MatKhau"));
            dt.Columns["MatKhau"].Caption = "Mật khẩu";
            dt.Columns.Add(new DataColumn("NgaySinh"));
            dt.Columns["NgaySinh"].Caption = "Ngày sinh";
            dt.Columns.Add(new DataColumn("GioiTinh"));
            dt.Columns["GioiTinh"].Caption = "Giới tính";
            dt.Columns.Add(new DataColumn("NoiSinh"));
            dt.Columns["NoiSinh"].Caption = "Nơi sinh";
            dt.Columns.Add(new DataColumn("Cmnd"));
            dt.Columns["Cmnd"].Caption = "Cmnd";
            dt.Columns.Add(new DataColumn("NgayCap"));
            dt.Columns["NgayCap"].Caption = "Ngày cấp";
            dt.Columns.Add(new DataColumn("NoiCap"));
            dt.Columns["NoiCap"].Caption = "Nơi cấp";
            dt.Columns.Add(new DataColumn("Email"));
            dt.Columns["Email"].Caption = "Email";
            dt.Columns.Add(new DataColumn("DienThoai"));
            dt.Columns["DienThoai"].Caption = "Điện thoại";
            dt.Columns.Add(new DataColumn("SoDiDong"));
            dt.Columns["SoDiDong"].Caption = "Di động";
            dt.Columns.Add(new DataColumn("Ngach"));
            dt.Columns["Ngach"].Caption = "Ngạch";
            dt.Columns.Add(new DataColumn("SoHieuCongChuc"));
            dt.Columns["SoHieuCongChuc"].Caption = "Số hiệu công chức";
            dt.Columns.Add(new DataColumn("DoanDang"));
            dt.Columns["DoanDang"].Caption = "Đoàn (đảng)";
            dt.Columns.Add(new DataColumn("NgayVaoDoanDang"));
            dt.Columns["NgayVaoDoanDang"].Caption = "Ngày vào đoàn (đảng)";
            dt.Columns.Add(new DataColumn("ngayKyHopDong"));
            dt.Columns["ngayKyHopDong"].Caption = "Ngày ký hợp đồng";
            dt.Columns.Add(new DataColumn("NgayKetThucHopDong"));
            dt.Columns["NgayKetThucHopDong"].Caption = "Ngày kết thúc hợp đồng";
            dt.Columns.Add(new DataColumn("DiaChi"));
            dt.Columns["DiaChi"].Caption = "Địa chỉ tạm trú";
            dt.Columns.Add(new DataColumn("ThuongTru"));
            dt.Columns["ThuongTru"].Caption = "Địa chỉ thường trú";
            dt.Columns.Add(new DataColumn("NoiLamViec"));
            dt.Columns["NoiLamViec"].Caption = "Nơi làm việc";
            dt.Columns.Add(new DataColumn("SoTaiKhoan"));
            dt.Columns["SoTaiKhoan"].Caption = "Số tài khoản";
            dt.Columns.Add(new DataColumn("TenNganHang"));
            dt.Columns["TenNganHang"].Caption = "Tên ngân hàng";
            dt.Columns.Add(new DataColumn("MaSoThue"));
            dt.Columns["MaSoThue"].Caption = "Mã số thuế";
            dt.Columns.Add(new DataColumn("ChiNhanh"));
            dt.Columns["ChiNhanh"].Caption = "Chi nhánh";
            dt.Columns.Add(new DataColumn("SoSoBaoHiem"));
            dt.Columns["SoSoBaoHiem"].Caption = "Số sổ bảo hiểm";
            dt.Columns.Add(new DataColumn("ThoiGianBatDau"));
            dt.Columns["ThoiGianBatDau"].Caption = "Thời gian bắt đầu";
            dt.Columns.Add(new DataColumn("BacLuong"));
            dt.Columns["BacLuong"].Caption = "Bậc lương";
            dt.Columns.Add(new DataColumn("NgayHuongLuong"));
            dt.Columns["NgayHuongLuong"].Caption = "Ngày hưởng lương";
            dt.Columns.Add(new DataColumn("NamLamViec"));
            dt.Columns["NamLamViec"].Caption = "Năm làm việc";
            dt.Columns.Add(new DataColumn("ChuyenNganh"));
            dt.Columns["ChuyenNganh"].Caption = "Chuyên ngành";
            dt.Columns.Add(new DataColumn("MaHeSoThuLao"));
            dt.Columns["MaHeSoThuLao"].Caption = "Mã hệ số thù lao";
            dt.Columns.Add(new DataColumn("NoiCapBang"));
            dt.Columns["NoiCapBang"].Caption = "Nơi cấp bằng";
            #endregion

            bindingSourceGiangVienImport.DataSource = dt;
        }

        private void buttonEditChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog { Filter = "Excel Workbook (*.xls)|*.xls", Multiselect = false, ValidateNames = true };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                buttonEditChonFile.Text = dialog.FileName;
                DevExpress.Common.SQLHelper.Helper helper =
                    new DevExpress.Common.SQLHelper.Helper(String.Format("Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0};Extended Properties={1}Excel 8.0;Imex=2;HDR=yes{1}"
                        , dialog.FileName, Convert.ToChar(34)));
                DataTable data = helper.GetOleDbSchemaTable();
                if (data == null || data.Rows.Count < 1)
                    return;
                frmDinhDangCot frm = new frmDinhDangCot(dt, data, helper);
                frm.ShowDialog();
                DataTable dtcol = frm.dt;
                DataTable table = frm.dtChon;
                if (table == null)
                    return;
                using (WaitDialogForm wait = new WaitDialogForm("Loading data ..."))
                {
                    try
                    {
                        if (table != null)
                        {
                            dt.Rows.Clear();
                            foreach (DataRow dr in table.Rows)
                            {
                                DataRow drdulieu = dt.NewRow();
                                int i = 0;
                                foreach (DataRow drcol in dtcol.Rows)
                                {
                                    if (drcol["Name"].ToString() == " ")
                                        continue;
                                    if (!string.IsNullOrEmpty(drcol["Name"].ToString()))
                                    {
                                        drdulieu[drcol["colDataBase"].ToString()] = dr[drcol["Name"].ToString()].ToString() == string.Empty ? null : dr[drcol["Name"].ToString()].ToString();
                                        i = 1;
                                    }
                                }
                                if (i == 1)
                                {
                                    dt.Rows.Add(drdulieu);
                                }
                            }
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình import dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        buttonEditChonFile.Text = string.Empty;
                    }
                    finally
                    {

                        bindingSourceGiangVienImport.DataSource = dt;
                        gridViewGiangVienImport.OptionsView.RowAutoHeight = true;
                        wait.Close();
                    }
                }

                Cursor.Current = Cursors.Default;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int result = 0;
            string strXML = "<Root>";
            for (int i = 0; i < gridViewGiangVienImport.DataRowCount; i++)
            {
                DataRow dr = gridViewGiangVienImport.GetDataRow(i);
                if (dr["MaQuanLy"].ToString() != "" && dr["MaDonVi"].ToString() != "")
                {
                    strXML += "<GV M=\"" + dr["MaQuanLy"].ToString().Trim()//MaGiangVien
                                + "\" H=\"" + System.Security.SecurityElement.Escape(Common.Globals.GetLastName(dr["HoTen"].ToString().Trim()))//Ho
                                + "\" TD=\"" + System.Security.SecurityElement.Escape(Common.Globals.GetMiddleName(dr["HoTen"].ToString().Trim()))//TenDem
                                + "\" T=\"" + System.Security.SecurityElement.Escape(Common.Globals.GetFirstName(dr["HoTen"].ToString().Trim()))//Ten
                                + "\" DV=\"" + System.Security.SecurityElement.Escape(dr["MaDonVi"].ToString().Trim())//MaDonVi
                                + "\" HH=\"" + System.Security.SecurityElement.Escape(dr["MaHocHam"].ToString().Trim())//MaHocHam
                                + "\" HV=\"" + System.Security.SecurityElement.Escape(dr["MaHocVi"].ToString().Trim())//MaHocVi
                                + "\" L=\"" + System.Security.SecurityElement.Escape(dr["MaLoaiGiangVien"].ToString().Trim())//MaLoaiGiangVien
                                + "\" TT=\"" + System.Security.SecurityElement.Escape(dr["MaTinhTrang"].ToString().Trim())
                                + "\" MK=\"" + System.Security.SecurityElement.Escape(dr["MatKhau"].ToString().Trim())
                                + "\" NS=\"" + System.Security.SecurityElement.Escape(dr["NgaySinh"].ToString().Trim())
                                + "\" GT=\"" + System.Security.SecurityElement.Escape(dr["GioiTinh"].ToString().Trim())
                                + "\" NA=\"" + System.Security.SecurityElement.Escape(dr["NoiSinh"].ToString().Trim())
                                + "\" CM=\"" + System.Security.SecurityElement.Escape(dr["Cmnd"].ToString().Trim())
                                + "\" NC=\"" + System.Security.SecurityElement.Escape(dr["NgayCap"].ToString().Trim())
                                + "\" NO=\"" + System.Security.SecurityElement.Escape(dr["NoiCap"].ToString().Trim())
                                + "\" E=\"" + System.Security.SecurityElement.Escape(dr["Email"].ToString().Trim())
                                + "\" DT=\"" + System.Security.SecurityElement.Escape(dr["DienThoai"].ToString().Trim())
                                + "\" DD=\"" + System.Security.SecurityElement.Escape(dr["SoDiDong"].ToString().Trim())
                                + "\" N=\"" + System.Security.SecurityElement.Escape(dr["Ngach"].ToString().Trim())
                                + "\" S=\"" + System.Security.SecurityElement.Escape(dr["SoHieuCongChuc"].ToString().Trim())
                                + "\" DA=\"" + System.Security.SecurityElement.Escape(dr["DoanDang"].ToString().Trim())
                                + "\" ND=\"" + System.Security.SecurityElement.Escape(dr["NgayVaoDoanDang"].ToString().Trim())
                                + "\" NK=\"" + System.Security.SecurityElement.Escape(dr["ngayKyHopDong"].ToString().Trim())
                                + "\" NH=\"" + System.Security.SecurityElement.Escape(dr["NgayKetThucHopDong"].ToString().Trim())
                                + "\" DC=\"" + System.Security.SecurityElement.Escape(dr["DiaChi"].ToString().Trim())
                                + "\" TH=\"" + System.Security.SecurityElement.Escape(dr["ThuongTru"].ToString().Trim())
                                + "\" NL=\"" + System.Security.SecurityElement.Escape(dr["NoiLamViec"].ToString().Trim())
                                + "\" ST=\"" + System.Security.SecurityElement.Escape(dr["SoTaiKhoan"].ToString().Trim())
                                + "\" TN=\"" + System.Security.SecurityElement.Escape(dr["TenNganHang"].ToString().Trim())
                                + "\" MT=\"" + System.Security.SecurityElement.Escape(dr["MaSoThue"].ToString().Trim())
                                + "\" CN=\"" + System.Security.SecurityElement.Escape(dr["ChiNhanh"].ToString().Trim())
                                + "\" SS=\"" + System.Security.SecurityElement.Escape(dr["SoSoBaoHiem"].ToString().Trim())
                                + "\" TG=\"" + System.Security.SecurityElement.Escape(dr["ThoiGianBatDau"].ToString().Trim())
                                + "\" BL=\"" + System.Security.SecurityElement.Escape(dr["BacLuong"].ToString().Trim())
                                + "\" NG=\"" + System.Security.SecurityElement.Escape(dr["NgayHuongLuong"].ToString().Trim())
                                + "\" NV=\"" + System.Security.SecurityElement.Escape(dr["NamLamViec"].ToString().Trim())
                                + "\" CU=\"" + System.Security.SecurityElement.Escape(dr["ChuyenNganh"].ToString().Trim())
                                + "\" ML=\"" + System.Security.SecurityElement.Escape(dr["MaHeSoThuLao"].ToString().Trim())
                                + "\" NCB=\"" + System.Security.SecurityElement.Escape(dr["NoiCapBang"].ToString().Trim())
                                + "\"/>";
                }
            }
            strXML += "</Root>";
            if (strXML == "<Root></Root>")
            {
                XtraMessageBox.Show("Danh sách cố vấn học tập rỗng, kiểm tra lại file excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string _checkHocHam = "", _checkHocVi = "", _checkLoaiGv = "", _checkTinhTrang = "", _checkDonVi = "";

            DataServices.GiangVien.KiemTraGiangVienImport(strXML, ref _checkHocHam, ref _checkHocVi, ref _checkLoaiGv, ref _checkTinhTrang, ref _checkDonVi);

            if (_checkHocHam != "" || _checkHocVi != "" || _checkLoaiGv != "" || _checkTinhTrang != "" || _checkDonVi != "")
            {
                if (XtraMessageBox.Show(_checkHocHam + "\n" + _checkHocVi + "\n" + _checkLoaiGv + "\n" + _checkTinhTrang + "\n" + _checkDonVi + "\nBạn có muốn tiếp tục import?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DataServices.GiangVien.Import(strXML, ref result);
                }
                else return;
            }
            else
                DataServices.GiangVien.Import(strXML, ref result);
            if (result == 0)
                XtraMessageBox.Show("Import thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show("Thao tác thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Cursor.Current = Cursors.Default;
        }

        private void btnXuatFileCauTruc_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "(*.xls)|*.xls";
            sf.FileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CauTrucImportGiangVien.xls";
            sf.ShowDialog();
            if (sf.FileName != "")
            {
                gridControlGiangVienImport.ExportToXls(sf.FileName);
                XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}