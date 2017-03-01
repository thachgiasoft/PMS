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
    public partial class frmImportNoKyTruoc : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        DataTable dt = new DataTable();
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion
        public frmImportNoKyTruoc()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void frmImportNoKyTruoc_Load(object sender, EventArgs e)
        {
            #region InitGridView
            switch (_maTruong)
            { 
                case "VHU":
                    InitGridVHU();
                    break;
                default:
                    InitRemaining();
                    break;
            }
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
            dt.Columns.Add(new DataColumn("SoTietNoKyTruoc"));
            dt.Columns["SoTietNoKyTruoc"].Caption = "Số tiết nợ kỳ trước";
            dt.Columns.Add(new DataColumn("TietNoKhac"));
            dt.Columns["TietNoKhac"].Caption = "Số tiết nợ khác";
            dt.Columns.Add(new DataColumn("TietNoNckh"));
            dt.Columns["TietNoNckh"].Caption = "Số tiết nợ NCKH";
            #endregion

            bindingSourceImport.DataSource = dt;
        }
        #region Init Grid
        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewImport, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewImport, new string[] { "NamHoc", "HocKy", "MaQuanLy", "HoTen", "SoTietNoKyTruoc", "TietNoNckh", "TietNoKhac" },
                new string[] { "Năm học", "Học kỳ", "Mã giảng viên", "Họ và tên", "Tiết nợ/bảo lưu giảng dạy", "Tiết nợ/bảo lưu NCKH", "Tiết nợ/bảo lưu tham gia quản lý" }
                , new int[] { 80, 80, 80, 150, 100, 100, 150 });
            AppGridView.AlignHeader(gridViewImport, new string[] { "NamHoc", "HocKy", "MaQuanLy", "HoTen", "SoTietNoKyTruoc", "TietNoNckh", "TietNoKhac" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewImport);
            PMS.Common.Globals.WordWrapHeader(gridViewImport, 45);
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewImport, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewImport, new string[] { "NamHoc", "HocKy", "MaQuanLy", "HoTen", "SoTietNoKyTruoc" },
                new string[] { "Năm học", "Học kỳ", "Mã giảng viên", "Họ và tên", "Số tiết nợ kỳ trước" }
                , new int[] { 80, 80, 80, 150, 150 });
            AppGridView.AlignHeader(gridViewImport, new string[] { "NamHoc", "HocKy", "MaQuanLy", "HoTen", "SoTietNoKyTruoc" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewImport);
        }

        #endregion
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
            using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls", FileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\CauTrucImportTietNoKyTruoc.xls" })
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

                if (dr["MaQuanLy"].ToString() != "" && dr["NamHoc"].ToString() != "")
                {
                    strXML += "<Input M=\"" + System.Security.SecurityElement.Escape(dr["MaQuanLy"].ToString().Trim())//MaGiangVien
                                + "\" S=\"" + PMS.Common.Globals.IsNull(System.Security.SecurityElement.Escape(dr["SoTietNoKyTruoc"].ToString().Trim()).Replace(",", ""), "decimal")
                                + "\" N=\"" + System.Security.SecurityElement.Escape(dr["NamHoc"].ToString().Trim())
                                + "\" H=\"" + System.Security.SecurityElement.Escape(dr["HocKy"].ToString().Trim())
                                + "\" T=\"" + PMS.Common.Globals.IsNull(System.Security.SecurityElement.Escape(dr["TietNoKhac"].ToString().Trim()).Replace(",", ""), "decimal")
                                + "\" K=\"" + PMS.Common.Globals.IsNull(System.Security.SecurityElement.Escape(dr["TietNoNckh"].ToString().Trim()).Replace(",", ""), "decimal")
                                + "\"/>";
                }
            }
            strXML += "</Root>";
            if (strXML == "<Root></Root>")
            {
                XtraMessageBox.Show("Danh sách rỗng, kiểm tra lại file excel.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataServices.TietNoKyTruoc.Import(strXML, ref result);
            if (result == 0)
                XtraMessageBox.Show("Import thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                XtraMessageBox.Show("Thao tác thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Cursor.Current = Cursors.Default;
        }
    }
}