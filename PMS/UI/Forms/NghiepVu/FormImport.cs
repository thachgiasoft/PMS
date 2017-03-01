using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class FormImport : XtraForm
    {
        DataSet dsImportExcel = new DataSet();

        public FormImport()
        {
            InitializeComponent();
        }

        private void FormImport_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Excel file (*.xlsx)|*.xlsx";
            if (f.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                dsImportExcel = PMS.Common.ExcelClass.ImportExcelXLS(f.FileName, true);
                bool hocham = false;
                bool hocvi = false;
                bool tinhtrang = false;
                bool loaigv = false;
                bool giangvien = false;

                if (checkEditHocHam.Checked){ hocham = true; }
                if (checkEditHocVi.Checked){ hocvi = true; }
                if (checkEditTinhTrang.Checked){ tinhtrang = true; }
                if (checkEditLoaiGiangVien.Checked){ loaigv = true; }
                if (checkEditGiangVien.Checked) { giangvien = true; }

                using (frmXuLyImport_Export frm = new frmXuLyImport_Export(dsImportExcel,hocham,hocvi,loaigv,tinhtrang,giangvien))
                {
                    frm.ShowDialog();
                }
            }
        }
    }
}
