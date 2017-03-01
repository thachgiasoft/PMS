using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.Utils;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu.FormXuLy
{
    public partial class frmImportKhoiLuongGiangDay : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        public frmImportKhoiLuongGiangDay()
        {
            InitializeComponent();
        }

        private void frmImportKhoiLuongGiangDay_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewImport, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewImport, new string[] { "MaGiangVien", "MaLopHocPhan", "NamHoc", "HocKy", "MaMonHoc", "GhiChu", "Nhom", "SoLuong", "LoaiHocPhan", "MaLop", "MaBuoiHoc", "SoTiet", "MaBacDaoTao", "MaNhomMonHoc", "MaCoSo", "LopHocPhanChuyenNganh" }
                    , new string[] { "Mã giảng viên", "Mã lớp học phần", "Năm học", "Học kỳ", "Mã môn học", "Tên môn học", "Nhóm", "Sĩ số", "Mã loại học phần", "Lớp", "Mã buổi học", "Số tiết", "Mã bậc đào tạo", "Mã nhóm môn học", "Mã cơ sở", "LHP chuyên ngành" }
                    , new int[] { 90, 110, 80, 80, 90, 200, 80, 70, 90, 70, 80, 80, 80, 90, 90,110 });
            AppGridView.AlignHeader(gridViewImport, new string[] { "MaGiangVien", "MaLopHocPhan", "NamHoc", "HocKy", "MaMonHoc", "GhiChu", "Nhom", "SoLuong", "LoaiHocPhan", "MaLop", "MaBuoiHoc", "SoTiet", "MaBacDaoTao", "MaNhomMonHoc", "MaCoSo", "LopHocPhanChuyenNganh" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewImport);
            AppGridView.SummaryField(gridViewImport, "MaGiangVien", "{0}", DevExpress.Data.SummaryItemType.Count);
            #endregion
            #region datatable
            dt.Columns.Add(new DataColumn("MaGiangVien"));
            dt.Columns["MaGiangVien"].Caption = "Mã giảng viên";
            dt.Columns.Add(new DataColumn("MaLopHocPhan"));
            dt.Columns["MaLopHocPhan"].Caption = "Mã lớp học phần";
            dt.Columns.Add(new DataColumn("NamHoc"));
            dt.Columns["NamHoc"].Caption = "Năm học";
            dt.Columns.Add(new DataColumn("HocKy"));
            dt.Columns["HocKy"].Caption = "Học kỳ";
            dt.Columns.Add(new DataColumn("MaMonHoc"));
            dt.Columns["MaMonHoc"].Caption = "Mã môn học";
            dt.Columns.Add(new DataColumn("GhiChu"));
            dt.Columns["GhiChu"].Caption = "Tên môn học";
            dt.Columns.Add(new DataColumn("TenMonHoc"));
            dt.Columns["TenMonHoc"].Caption = "Tên môn học";
            dt.Columns.Add(new DataColumn("Nhom"));
            dt.Columns["Nhom"].Caption = "Nhóm";
            dt.Columns.Add(new DataColumn("SoLuong"));
            dt.Columns["SoLuong"].Caption = "Sĩ số";
            dt.Columns.Add(new DataColumn("LoaiHocPhan"));
            dt.Columns["LoaiHocPhan"].Caption = "Mã loại học phần";
            dt.Columns.Add(new DataColumn("MaLop"));
            dt.Columns["MaLop"].Caption = "Lớp";
            dt.Columns.Add(new DataColumn("MaBuoiHoc"));
            dt.Columns["MaBuoiHoc"].Caption = "Mã buổi học";
            dt.Columns.Add(new DataColumn("SoTiet"));
            dt.Columns["SoTiet"].Caption = "Số tiết";
            dt.Columns.Add(new DataColumn("MaBacDaoTao"));
            dt.Columns["MaBacDaoTao"].Caption = "Mã bậc đào tạo";
            dt.Columns.Add(new DataColumn("MaNhomMonHoc"));
            dt.Columns["MaNhomMonHoc"].Caption = "Mã nhóm môn học";
            dt.Columns.Add(new DataColumn("MaCoSo"));
            dt.Columns["MaCoSo"].Caption = "Mã cơ sở";
            dt.Columns.Add(new DataColumn("LopHocPhanChuyenNganh"));
            dt.Columns["LopHocPhanChuyenNganh"].Caption = "LHP chuyên ngành";
            #endregion

            bindingSourceImport.DataSource = dt;
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog { Filter = "Excel Workbook (*.xls)|*.xls", Multiselect = false, ValidateNames = true };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                btnChonFile.Text = dialog.FileName;
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
                        btnChonFile.Text = string.Empty;
                    }
                    finally
                    {

                        bindingSourceImport.DataSource = dt;
                        gridViewImport.OptionsView.RowAutoHeight = true;
                        wait.Close();
                    }
                }

                Cursor.Current = Cursors.Default;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (txtDotImport.Text == "" || txtDotImport.Text == null)
            {
                XtraMessageBox.Show("Nhập tên đợt import.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDotImport.Focus();
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            int result = 0;
            string strXML = "<Root>";
            
                for (int i = 0; i < gridViewImport.DataRowCount; i++)
                {
                    DataRow dr = gridViewImport.GetDataRow(i);
                    if (dr["MaGiangVien"].ToString() != "" || dr["NamHoc"].ToString() != "" || dr["HocKy"].ToString() != "" || dr["MaMonHoc"].ToString() != "" || dr["SoLuong"].ToString() != "" || dr["SoTiet"].ToString() != "")
                    {
                        int _a; decimal _b;
                        int _soLuong = int.TryParse(dr["SoLuong"].ToString(), out _a) ? _a : 0;
                        decimal _soTiet = decimal.TryParse(dr["SoTiet"].ToString(), out _b) ? _b : 0;
                        
                        strXML += String.Format("<Input M=\"{0}\" LP=\"{1}\" N=\"{2}\" H=\"{3}\" MH=\"{4}\" G=\"{5}\" NO=\"{6}\" S=\"{7}\" L=\"{8}\" ML=\"{9}\" MB=\"{10}\" ST=\"{11}\" B=\"{12}\" MN=\"{13}\" CS=\"{14}\" CN=\"{15}\" />"
                            , System.Security.SecurityElement.Escape(dr["MaGiangVien"].ToString().Trim())
                            , System.Security.SecurityElement.Escape(dr["MaLopHocPhan"].ToString().Trim())
                            , System.Security.SecurityElement.Escape(dr["NamHoc"].ToString().Trim())
                            , System.Security.SecurityElement.Escape(dr["HocKy"].ToString().Trim())
                            , System.Security.SecurityElement.Escape(dr["MaMonHoc"].ToString().Trim())
                            , System.Security.SecurityElement.Escape(dr["GhiChu"].ToString().Trim())
                            , System.Security.SecurityElement.Escape(dr["Nhom"].ToString().Trim())
                            , _soLuong
                            , System.Security.SecurityElement.Escape(dr["LoaiHocPhan"].ToString().Trim())
                            , System.Security.SecurityElement.Escape(dr["MaLop"].ToString().Trim())
                            , System.Security.SecurityElement.Escape(dr["MaBuoiHoc"].ToString().Trim())
                            , _soTiet
                            , System.Security.SecurityElement.Escape(dr["MaBacDaoTao"].ToString().Trim())
                            , System.Security.SecurityElement.Escape(dr["MaNhomMonHoc"].ToString().Trim())
                            , System.Security.SecurityElement.Escape(dr["MaCoSo"].ToString().Trim())
                            , System.Security.SecurityElement.Escape(dr["LopHocPhanChuyenNganh"].ToString().Trim()));
                    }
                }
                strXML += "</Root>";
                if (strXML == "<Root></Root>")
                {
                    XtraMessageBox.Show("Danh sách rỗng, kiểm tra lại file excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DataServices.KhoiLuongGiangDayChiTiet.Import(strXML, txtDotImport.Text, ref result);
                if (result == 0)
                {
                    XtraMessageBox.Show("Import thành công. Thoát giao diện import.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                    XtraMessageBox.Show("Import thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnXuatCauTruc_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "(*.xls)|*.xls";
            sf.FileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CauTrucImportKhoiLuongGiangDay.xls";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                if (sf.FileName != "")
                {
                    gridControlImport.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}