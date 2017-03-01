using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.Utils;

namespace PMS.UI.Forms.NghiepVu.FormXuLy
{
    public partial class frmImportGiangDayChatLuongCao : DevExpress.XtraEditors.XtraForm
    {
        #region Var
        DataTable dt = new DataTable();
        #endregion
        public frmImportGiangDayChatLuongCao()
        {
            InitializeComponent();
        }

        private void frmImportGiangDayChatLuongCao_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewImport, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewImport, new string[] { "MaQuanLy", "NamHoc", "HocKy", "SoTiet" },
                    new string[] { "Mã giảng viên", "Năm học", "Học kỳ", "Số tiết" });
            AppGridView.AlignHeader(gridViewImport, new string[] { "MaQuanLy", "NamHoc", "HocKy", "SoTiet" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewImport);
            #endregion

            #region datatable
            dt.Columns.Add(new DataColumn("MaQuanLy"));
            dt.Columns["MaQuanLy"].Caption = "Mã giảng viên";
            dt.Columns.Add(new DataColumn("NamHoc"));
            dt.Columns["NamHoc"].Caption = "Năm học";
            dt.Columns.Add(new DataColumn("HocKy"));
            dt.Columns["HocKy"].Caption = "Học kỳ";
            dt.Columns.Add(new DataColumn("SoTiet"));
            dt.Columns["SoTiet"].Caption = "Số tiết";
            #endregion

            bindingSourceImport.DataSource = dt;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
           
            int result = 0;
            string strXML = "<Root>";
            for (int i = 0; i < gridViewImport.DataRowCount; i++)
            {
                DataRow dr = gridViewImport.GetDataRow(i);
                if (dr["MaQuanLy"].ToString() != "" && dr["SoTiet"].ToString() != "" && dr["NamHoc"].ToString() != "" && dr["HocKy"].ToString() != "")
                {
                    strXML += "<Input M = \"" + dr["MaQuanLy"].ToString().Trim()
                                + "\" N = \"" + dr["NamHoc"].ToString().Trim()
                                + "\" H = \"" + dr["HocKy"].ToString().Trim()
                                + "\" S = \"" + dr["SoTiet"].ToString().Trim()
                                + "\"/>";
                }
            }
            strXML += "</Root>";
            if (strXML == "<Root></Root>")
            {
                XtraMessageBox.Show("Danh sách cố vấn học tập rỗng, kiểm tra lại file excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataServices.GiangDayChatLuongCao.Import(strXML, ref result);
            if (result == 0)
            {
                XtraMessageBox.Show("Import thành công, thoát cửa sổ import.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
                XtraMessageBox.Show("Thao tác thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Cursor.Current = Cursors.Default;
        }

        private void btnXuatCauTruc_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlImport.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
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
    }
}