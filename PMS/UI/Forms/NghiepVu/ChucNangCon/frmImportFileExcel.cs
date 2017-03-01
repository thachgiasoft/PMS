using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu.ChucNangCon
{
    public partial class frmImportFileExcel : DevExpress.XtraEditors.XtraForm
    {
        SpreadsheetGear.IWorkbookSet _workbookSet = SpreadsheetGear.Factory.GetWorkbookSet();
        string _direct = string.Empty;

        public frmImportFileExcel()
        {
            InitializeComponent();
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofdFiles = new OpenFileDialog { Filter = "(*.xls)|*.xls|(*.xlsx)|*.xlsx" })
                {
                    if (ofdFiles.ShowDialog() == DialogResult.OK)
                    {
                        btnChonFile.Text = ofdFiles.FileName;
                        if (btnChonFile.Text == string.Empty)
                            return;
                        else
                        {
                            _workbookSet = SpreadsheetGear.Factory.GetWorkbookSet();
                            _direct = btnChonFile.Text.ToString().Trim();
                            _workbookSet.Workbooks.Open(_direct);
                            DataTable dt = new DataTable();
                            dt.Columns.Add("ID", typeof(int));
                            dt.Columns.Add("Name");
                            for (int i = 0; i < _workbookSet.Workbooks[0].Sheets.Count; i++)
                                dt.Rows.Add(i, _workbookSet.Workbooks[0].Sheets[i].Name);
                            bindingSourceSheet.DataSource = dt;
                        }
                    }
                }
            }
            catch { }
        }

        private void frmImportFileExcel_Load(object sender, EventArgs e)
        {
            #region Init Sheet
            AppGridLookupEdit.InitGridLookUp(cboSheet, false, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboSheet, new string[] { "Name" }, new string[] { "Tên sheet" });
            cboSheet.Properties.DisplayMember = "Name";
            cboSheet.Properties.ValueMember = "ID";
            cboSheet.Properties.NullText = string.Empty;
            #endregion

            #region Init Filename
            AppGridLookupEdit.InitGridLookUp(cboCauTrucImport, false, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboCauTrucImport, new string[] { "RowNum", "FileName" }, new string[] { "STT", "Tên file" }, new int[] { 60, 240 });
            AppGridLookupEdit.InitPopupFormSize(cboCauTrucImport, 300, 650);
            cboCauTrucImport.Properties.DisplayMember = "FileName";
            cboCauTrucImport.Properties.ValueMember = "Id";
            cboCauTrucImport.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            DataTable tblFileName = new DataTable();
            tblFileName.Columns.Add(new DataColumn("Id", typeof(string)));
            tblFileName.Columns.Add(new DataColumn("RowNum", typeof(int)));
            tblFileName.Columns.Add(new DataColumn("FileName", typeof(string)));

            tblFileName.Rows.Add("CauTrucImportGioChuanDinhMuc.xls", 1, "Import giờ chuẩn định mức");
            tblFileName.Rows.Add("CauTrucImportNCKH.xls", 2, "Import giờ chuẩn nghiên cứu khoa học thực hiện");
            tblFileName.Rows.Add("CauTrucImportGioChuanDaThucHien.xls", 3, "Import giờ chuẩn đã thực hiện");
            

            bindingSourceFileName.DataSource = tblFileName;
            bindingSourceFileName.Sort = "RowNum";
        }
        #endregion

        private void btnXemFile_Click(object sender, EventArgs e)
        {
            try
            {
                _workbookSet = SpreadsheetGear.Factory.GetWorkbookSet();
                _direct = btnChonFile.Text.ToString().Trim();
                _workbookSet.Workbooks.Open(_direct);
                SpreadsheetGear.Windows.Forms.WorkbookDesigner v3 = new SpreadsheetGear.Windows.Forms.WorkbookDesigner(_workbookSet);
                v3.Show();
            }
            catch
            {
                
                MessageBox.Show("Đường dẫn file không đúng.", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboCauTrucImport.EditValue != null)
                {
                    _workbookSet = SpreadsheetGear.Factory.GetWorkbookSet();
                    _direct = btnChonFile.Text.ToString().Trim();
                    _workbookSet.Workbooks.Open(_direct);
                    var file = _workbookSet.Workbooks[0];
                    int indexSheet = 0;
                    string xml = "<Root>";
                    int result = 0;
                    int indexStart = 0; // Hang bat dau 
                    int indexEnd = file.Worksheets[indexSheet].UsedRange.RowCount; // Hang ket thuc

                    #region Import giờ chuẩn định mức
                    if (cboCauTrucImport.EditValue.ToString() == "CauTrucImportGioChuanDinhMuc.xls")
                    {
                        indexStart = 6; // Hang bat dau 
                        for (int i = indexStart; i <= indexEnd; i++)
                        {
                            xml += String.Format("<Input N=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["A" + i.ToString()].Text.ToString().Trim() == string.Empty ? "" : file.Worksheets[indexSheet].Cells["A" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" H=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["B" + i.ToString()].Text.ToString().Trim() == string.Empty ? "" : file.Worksheets[indexSheet].Cells["B" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" M=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["C" + i.ToString()].Text.ToString().Trim() == string.Empty ? "" : file.Worksheets[indexSheet].Cells["C" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" GD=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["D" + i.ToString()].Text.ToString().Trim() == string.Empty ? "0" : file.Worksheets[indexSheet].Cells["D" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" NCKH=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["E" + i.ToString()].Text.ToString().Trim() == string.Empty ? "0" : file.Worksheets[indexSheet].Cells["E" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" K=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["F" + i.ToString()].Text.ToString().Trim() == string.Empty ? "0" : file.Worksheets[indexSheet].Cells["F" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" T=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["G" + i.ToString()].Text.ToString().Trim() == string.Empty ? "0" : file.Worksheets[indexSheet].Cells["G" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" G=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["H" + i.ToString()].Text.ToString().Trim() == string.Empty ? "" : file.Worksheets[indexSheet].Cells["H" + i.ToString()].Text.ToString().Trim())));
                            xml += "/>";
                        }

                        xml += "</Root>";
                        Cursor.Current = Cursors.WaitCursor;
                        DataServices.TietNghiaVu.Import(xml, ref result);
                        Cursor.Current = Cursors.Default;

                        if (result == 0)
                            //MessageBox.Show(String.Format("Import {0} (Tuyển Sinh) thành công.", _workbookSet.Workbooks[0].Sheets[indexSheet].Name), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            XtraMessageBox.Show("Import giờ chuẩn định mức thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            //MessageBox.Show(String.Format("Cập nhật {0} (Tuyển Sinh) thành công.", _workbookSet.Workbooks[0].Sheets[indexSheet].Name), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình import.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    #endregion

                    #region Import giờ chuẩn NCKH thực hiện
                    if (cboCauTrucImport.EditValue.ToString() == "CauTrucImportNCKH.xls")
                    {
                        indexStart = 6; // Hang bat dau 
                        for (int i = indexStart; i <= indexEnd; i++)
                        {
                            xml += String.Format("<Input N=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["A" + i.ToString()].Text.ToString().Trim() == string.Empty ? "" : file.Worksheets[indexSheet].Cells["A" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" H=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["B" + i.ToString()].Text.ToString().Trim() == string.Empty ? "" : file.Worksheets[indexSheet].Cells["B" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" M=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["C" + i.ToString()].Text.ToString().Trim() == string.Empty ? "" : file.Worksheets[indexSheet].Cells["C" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" T=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["D" + i.ToString()].Text.ToString().Trim() == string.Empty ? "0" : file.Worksheets[indexSheet].Cells["D" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" C=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["E" + i.ToString()].Text.ToString().Trim() == string.Empty ? "0" : file.Worksheets[indexSheet].Cells["E" + i.ToString()].Text.ToString().Trim())));
                            xml += "/>";
                        }

                        xml += "</Root>";
                        Cursor.Current = Cursors.WaitCursor;
                        DataServices.GiangVienNghienCuuKh.Import(xml, ref result);
                        Cursor.Current = Cursors.Default;

                        if (result == 0)
                            XtraMessageBox.Show("Import giờ chuẩn NCKH thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình import.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    #endregion

                    #region Import giờ chuẩn đã thực hiện
                    if (cboCauTrucImport.EditValue.ToString() == "CauTrucImportGioChuanDaThucHien.xls")
                    {
                        indexStart = 6; // Hang bat dau 
                        for (int i = indexStart; i <= indexEnd; i++)
                        {
                            xml += String.Format("<Input N=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["A" + i.ToString()].Text.ToString().Trim() == string.Empty ? "" : file.Worksheets[indexSheet].Cells["A" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" H=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["B" + i.ToString()].Text.ToString().Trim() == string.Empty ? "" : file.Worksheets[indexSheet].Cells["B" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" M=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["C" + i.ToString()].Text.ToString().Trim() == string.Empty ? "" : file.Worksheets[indexSheet].Cells["C" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" LT=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["D" + i.ToString()].Text.ToString().Trim() == string.Empty ? "0" : file.Worksheets[indexSheet].Cells["D" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" DA=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["E" + i.ToString()].Text.ToString().Trim() == string.Empty ? "0" : file.Worksheets[indexSheet].Cells["E" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" K=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["F" + i.ToString()].Text.ToString().Trim() == string.Empty ? "0" : file.Worksheets[indexSheet].Cells["F" + i.ToString()].Text.ToString().Trim())));
                            xml += String.Format(" G=\"{0}\"", System.Security.SecurityElement.Escape((file.Worksheets[indexSheet].Cells["G" + i.ToString()].Text.ToString().Trim() == string.Empty ? "" : file.Worksheets[indexSheet].Cells["G" + i.ToString()].Text.ToString().Trim())));
                            xml += "/>";
                        }

                        xml += "</Root>";

                        Cursor.Current = Cursors.WaitCursor;
                        DataServices.KhoiLuongCacCongViecKhac.Import(xml, ref result);
                        Cursor.Current = Cursors.Default;

                        if (result == 0)
                            XtraMessageBox.Show("Import giờ chuẩn đã thực hiện thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình import.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    #endregion
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn loại dữ liệu muốn import.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboCauTrucImport.Focus();
                }

                cboCauTrucImport.EditValue = null;
                btnChonFile.EditValue = null;
            }
            catch { }
        }

        private void btnXuatFileCauTruc_Click(object sender, EventArgs e)
        {
            if (cboCauTrucImport.EditValue != null)
            {
                using (SaveFileDialog chonFile = new SaveFileDialog { Filter = "(*.xls)|*.xls|(*.xlsx)|*.xlsx" })
                {
                    if (chonFile.ShowDialog() == DialogResult.OK)
                    {
                        string sourceFile = String.Format("{0}\\ExcelStructure\\{1}", Application.StartupPath, cboCauTrucImport.EditValue.ToString());

                        string destinationFile = chonFile.FileName;
                        if (destinationFile != "")
                        {
                            try
                            {
                                System.IO.File.Copy(sourceFile, destinationFile, true);
                                if (XtraMessageBox.Show("Xuất file cấu trúc thành công. Bạn có muốn mở file không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    System.Diagnostics.Process.Start(destinationFile);
                                }
                            }
                            catch
                            {
                                XtraMessageBox.Show("Có lỗi trong quá trình xuất file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn loại dữ liệu muốn xuất cấu trúc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCauTrucImport.Focus();
            }
        }
    }
}