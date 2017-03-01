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
using PMS.Entities;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmImportCoVanHocTap : DevExpress.XtraEditors.XtraForm
    {
        #region Var
        DataTable dt = new DataTable();
        TList<CauHinhChung> cauHinh = DataServices.CauHinhChung.GetAll();
        string _coVanTheoNam;
        #endregion
        public frmImportCoVanHocTap()
        {
            InitializeComponent();
            _coVanTheoNam = cauHinh.Find(p => p.TenCauHinh == "Cố vấn học tập phân theo năm học").GiaTri;
        }

        private void frmImportCoVanHocTap_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewImportCVHT, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewImportCVHT, new string[] { "MaQuanLy", "NamHoc", "HocKy", "MaKhoaHoc", "MaLop", "Nhom", "NgayTao", "SoTiet", "SoTien" }, 
                    new string[] { "Mã giảng viên", "Năm học", "Học kỳ", "Khóa học", "Mã lớp", "Nhóm", "Ngày phân công", "Số tiết", "Số tiền" });
            AppGridView.AlignHeader(gridViewImportCVHT, new string[] { "MaQuanLy", "NamHoc", "HocKy", "MaKhoaHoc", "MaLop", "Nhom", "NgayTao", "SoTiet", "SoTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewImportCVHT);
            #endregion

            #region datatable
            dt.Columns.Add(new DataColumn("MaQuanLy"));
            dt.Columns["MaQuanLy"].Caption = "Mã giảng viên";
            dt.Columns.Add(new DataColumn("NamHoc"));
            dt.Columns["NamHoc"].Caption = "Năm học";
            dt.Columns.Add(new DataColumn("HocKy"));
            dt.Columns["HocKy"].Caption = "Học kỳ";
            dt.Columns.Add(new DataColumn("MaKhoaHoc"));
            dt.Columns["MaKhoaHoc"].Caption = "Khóa học";
            dt.Columns.Add(new DataColumn("MaLop"));
            dt.Columns["MaLop"].Caption = "Mã lớp";
            dt.Columns.Add(new DataColumn("Nhom"));
            dt.Columns["Nhom"].Caption = "Nhóm";
            dt.Columns.Add(new DataColumn("NgayTao"));
            dt.Columns["NgayTao"].Caption = "Ngày phân công";
            dt.Columns.Add(new DataColumn("SoTiet"));
            dt.Columns["SoTiet"].Caption = "Số tiết";
            dt.Columns.Add(new DataColumn("SoTien"));
            dt.Columns["SoTien"].Caption = "Số tiền";
            #endregion

            bindingSourceImpCVHT.DataSource = dt;
            gridViewImportCVHT.BestFitColumns();
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

                        bindingSourceImpCVHT.DataSource = dt;
                        gridViewImportCVHT.OptionsView.RowAutoHeight = true;
                        wait.Close();
                    }
                }

                Cursor.Current = Cursors.Default;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
          
                Cursor.Current = Cursors.WaitCursor;
                if (KiemTraCoVanHocTap() == 0)
                    return;
                int result = 0;
                string strXML = "<Root>";
                for (int i = 0; i < gridViewImportCVHT.DataRowCount; i++)
                {
                    DataRow dr = gridViewImportCVHT.GetDataRow(i);
                    if (dr["MaQuanLy"].ToString() != "" && dr["MaLop"].ToString() != "" && dr["NamHoc"].ToString() != "" && (dr["HocKy"].ToString() != "" || _coVanTheoNam == "True"))
                    {
                        strXML += "<CoVanHocTap MaQuanLy = \"" + dr["MaQuanLy"].ToString().Trim()
                                    + "\" NamHoc = \"" + dr["NamHoc"].ToString().Trim()
                                    + "\" HocKy = \"" + dr["HocKy"].ToString().Trim()
                                    + "\" MaKhoaHoc = \"" + dr["MaKhoaHoc"].ToString().Trim()
                                    + "\" MaLop = \"" + dr["MaLop"].ToString().Trim()
                                    + "\" Nhom = \"" + PMS.Common.Globals.IsNull(dr["Nhom"].ToString().Trim(), "int").ToString()
                                    + "\" NgayTao = \"" + dr["NgayTao"].ToString().Trim()
                                    + "\" SoTiet = \"" + dr["SoTiet"].ToString().Trim()
                                    + "\" SoTien = \"" + dr["SoTien"].ToString().Trim()
                                    + "\"/>";
                    }
                }
                strXML += "</Root>";
                if (strXML == "<Root></Root>")
                {
                    XtraMessageBox.Show("Danh sách cố vấn học tập rỗng, kiểm tra lại file excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DataServices.CoVanHocTap.Import(strXML, ref result);
                if (result == 0)
                    XtraMessageBox.Show("Import thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("Thao tác thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Cursor.Current = Cursors.Default;
           
            
        }

        private int KiemTraCoVanHocTap()
        {
            try
            {
                for (int i = 0; i < gridViewImportCVHT.DataRowCount; i++)
                {
                    DataRow dr = gridViewImportCVHT.GetDataRow(i);
                    TList<GiangVien> gv = DataServices.GiangVien.GetByMaQuanLy(dr["MaQuanLy"].ToString());
                    TList<CoVanHocTap> listCoVan = DataServices.CoVanHocTap.GetAll();
                    if (listCoVan.Find(p => p.MaGiangVien == gv[0].MaGiangVien && p.NamHoc == dr["NamHoc"].ToString() && p.HocKy == dr["HocKy"].ToString() && p.MaLop == dr["MaLop"].ToString()) != null)
                    {
                        string s = dr["MaQuanLy"].ToString() + " - " + gv[0].HoTen + " - " + dr["NamHoc"].ToString() + " - " + dr["HocKy"].ToString() + " - " + dr["MaLop"].ToString();
                        XtraMessageBox.Show(string.Format("Dòng dữ liệu {0} đã có Trong hệ thống. Dòng dữ liệu bị xóa khỏi danh sách import.", s), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dt.Rows.Remove(dr);
                        return 0;
                    }
                }
            }
            catch 
            {  }
            return 1;
        }

        private void btnXuatFileCauTruc_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog file = new SaveFileDialog())
            {
                file.Filter = "(*.xls)|*.xls";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (file.FileName != "")
                    {
                        gridControlImport.ExportToXls(file.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Bạn chưa nhập tên file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}