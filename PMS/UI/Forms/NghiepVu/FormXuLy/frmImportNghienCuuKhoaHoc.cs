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

namespace PMS.UI.Forms.NghiepVu.FormXuLy
{
    public partial class frmImportNghienCuuKhoaHoc : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        DataTable dt = new DataTable();
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion
        public frmImportNghienCuuKhoaHoc()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmImportNghienCuuKhoaHoc_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewImport, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewImport, new string[] { "NamHoc", "HocKy", "MaQuanLy", "HoTen", "SoTietThucHien" },
                new string[] { "Năm học", "Học kỳ", "Mã giảng viên", "Họ và tên", "Số tiết NCKH" }
                , new int[] { 80, 80, 80, 150, 150 });
            AppGridView.AlignHeader(gridViewImport, new string[] { "NamHoc", "HocKy", "MaQuanLy", "HoTen", "SoTietThucHien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewImport);

            if (_maTruong == "BUH")
                AppGridView.HideField(gridViewImport, new string[] { "HocKy" });
            #endregion

            #region datatable
            dt.Columns.Add(new DataColumn("NamHoc"));
            dt.Columns["NamHoc"].Caption = "Năm học";
            dt.Columns.Add(new DataColumn("HocKy"));
            dt.Columns["HocKy"].Caption = "Học kỳ";
            dt.Columns.Add(new DataColumn("MaQuanLy"));
            dt.Columns["MaQuanLy"].Caption = "Mã giảng viên";
            dt.Columns.Add(new DataColumn("HoTen"));
            dt.Columns["HoTen"].Caption = "Họ và tên";
            dt.Columns.Add(new DataColumn("SoTietThucHien"));
            dt.Columns["SoTietThucHien"].Caption = "Số tiết NCKH";
            #endregion

            bindingSourceImport.DataSource = dt;
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

                        bindingSourceImport.DataSource = dt;
                        gridViewImport.OptionsView.RowAutoHeight = true;
                        wait.Close();
                    }
                }

                Cursor.Current = Cursors.Default;
            }
        }

        private void btnXuatFileCauTruc_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls", FileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CauTrucImportNghienCuuKhoaHoc.xls" })
            {
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlImport.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            int result = 0;
            string strXML = "<Root>";
            for (int i = 0; i < gridViewImport.DataRowCount; i++)
            {
                DataRow dr = gridViewImport.GetDataRow(i);

                if (dr["MaQuanLy"].ToString() != "" && dr["SoTietThucHien"].ToString() != "" || dr["NamHoc"].ToString() != "" || dr["HocKy"].ToString() != "")
                {
                    strXML += "<Input M=\"" + System.Security.SecurityElement.Escape(dr["MaQuanLy"].ToString().Trim())//MaGiangVien
                                + "\" S=\"" + PMS.Common.Globals.IsNull(System.Security.SecurityElement.Escape(dr["SoTietThucHien"].ToString().Trim()).Replace(",", ""), "decimal").ToString()
                                + "\" N=\"" + System.Security.SecurityElement.Escape(dr["NamHoc"].ToString().Trim())
                                + "\" H=\"" + System.Security.SecurityElement.Escape(dr["HocKy"].ToString().Trim())
                                + "\"/>";
                }
                else
                {
                    XtraMessageBox.Show(string.Format("Dòng dữ liệu {0} - {1} - {2} - {3} - {4} không thể import do thiếu thông tin. \n Thông tin tối thiểu cần có bao gồm: mã giảng viên, số tiết thực hiện NCKH, năm học, học kỳ.", dr["NamHoc"].ToString(), dr["HocKy"].ToString(), dr["MaQuanLy"].ToString(), dr["HoTen"].ToString(), dr["SoTietThucHien"].ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            strXML += "</Root>";
            if (strXML == "<Root></Root>")
            {
                XtraMessageBox.Show("Danh sách rỗng, kiểm tra lại file excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataServices.NghienCuuKhoaHoc.Import(strXML, ref result);
            if (result == 0)
            {
                XtraMessageBox.Show("Import thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
                XtraMessageBox.Show("Thao tác thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Cursor.Current = Cursors.Default;
        }
    }
}