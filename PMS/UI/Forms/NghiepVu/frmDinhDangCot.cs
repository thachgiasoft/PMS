using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.Common.DataForm;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmDinhDangCot : DevExpress.XtraEditors.XtraForm
    {
        #region Var
        public DataTable dt = new DataTable();
        DataTable dtcolex = new DataTable();
        DataTable dtcol = new DataTable();
        DataTable dtcolData = new DataTable();
        public DataTable dtChon = new DataTable();

        DevExpress.Common.SQLHelper.Helper h;
        #endregion

        public frmDinhDangCot()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        public frmDinhDangCot(DataTable dtData, DataTable dtexcel, DevExpress.Common.SQLHelper.Helper h)
        {
            InitializeComponent();
            this.dtcolData = dtData;
            this.dtcolex = dtexcel;
            this.dtcol.PrimaryKey = new DataColumn[] { this.dtcol.Columns["Name"] };
            this.h = h;
        }

        private void frmDinhDangCot_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewDinhDangCot, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewDinhDangCot, new string[] { "Caption", "Name" },
                new string[] { "Tên cột hệ thống", "Tên cột file excel" },
                new int[] { 200, 200 });

            AppGridView.SummaryField(gridViewDinhDangCot, "Caption", "Tổng = {0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.RegisterControlField(gridViewDinhDangCot, "Name", repositoryItemGridLookUpEditcol);
            #endregion

            #region AppRepositoryItemGridLookUpEdit Sheet
            AppGridLookupEdit.InitGridLookUp(gridLookUpEditChonSheet, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(gridLookUpEditChonSheet, new string[] { "Name" }, new string[] { "Sheet" });
            gridLookUpEditChonSheet.Properties.ValueMember = "ID";
            gridLookUpEditChonSheet.Properties.DisplayMember = "Name";
            gridLookUpEditChonSheet.Properties.NullText = "[Chọn sheet]";
            #endregion

            #region AppRepositoryItemGridLookUpEditcol
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditcol, true, TextEditStyles.DisableTextEditor);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditcol, new string[] { "Name" }, new string[] { "Tên cột file excel" });
            repositoryItemGridLookUpEditcol.ValueMember = "Name";
            repositoryItemGridLookUpEditcol.DisplayMember = "Name";
            repositoryItemGridLookUpEditcol.NullText = string.Empty;
            #endregion

            InitData();

            AppType Sheet = bindingSourceSheet.Current as AppType;
            if (Sheet != null)
            {
                dtcol.Clear();
                this.dtcol.PrimaryKey = new DataColumn[] { this.dtcol.Columns["Name"] };
                DataTable table = h.FillDataTable(String.Format("select * from [{0}]", dtcolex.Rows[Sheet.ID]["TABLE_NAME"]));
                dtChon = table;
                foreach (DataColumn obj in table.Columns)
                {
                    DataRow dr = dtcol.NewRow();
                    dr["Name"] = obj.ColumnName;
                    dtcol.Rows.Add(dr);
                }
            }
            bindingSourcecol.DataSource = dtcol;
            dt = bindingSourceColunms.DataSource as DataTable;
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow drDataBase = dtcol.Rows.Find(dt.Rows[i]["Caption"].ToString());
                    if (drDataBase != null)
                        dt.Rows[i]["Name"] = drDataBase["Name"].ToString();
                }
                bindingSourceColunms.DataSource = dt;
            }
        }

        #region InitData
        private void InitData()
        {
            Cursor.Current = Cursors.WaitCursor;
            gridLookUpEditChonSheet.DataBindings.Clear();
            List<AppType> listTieuChi = new List<AppType>();
            for (int i = 0; i < dtcolex.Rows.Count; i++)
            {
                listTieuChi.Add(new AppType { ID = i, Name = dtcolex.Rows[i]["TABLE_NAME"].ToString() });
            }
            bindingSourceSheet.DataSource = listTieuChi;
            gridLookUpEditChonSheet.DataBindings.Add("EditValue", bindingSourceSheet, "ID", true, DataSourceUpdateMode.OnPropertyChanged);

            dt.Columns.Add(new DataColumn("colDataBase"));
            dt.Columns.Add(new DataColumn("Caption"));
            dt.Columns.Add(new DataColumn("Name"));
            dtcol.Columns.Add(new DataColumn("Name"));
            foreach (DataColumn obj in dtcolData.Columns)
            {
                if (obj.ColumnName == "Loi" || obj.ColumnName == "LyDo" || obj.ColumnName == "Import")
                    continue;
                DataRow dr = dt.NewRow();
                dr["colDataBase"] = obj.ColumnName;
                dr["Caption"] = obj.Caption;
                dr["Name"] = " ";
                dt.Rows.Add(dr);
            }
            AppType Sheet = bindingSourceSheet.Current as AppType;
            if (Sheet != null)
            {
                dtcol.Clear();
                DataTable table = h.FillDataTable(String.Format("select * from [{0}]", dtcolex.Rows[Sheet.ID]["TABLE_NAME"]));
                dtChon = table;
                foreach (DataColumn obj in table.Columns)
                {
                    DataRow dr = dtcol.NewRow();
                    dr["Name"] = obj.ColumnName;
                    dtcol.Rows.Add(dr);

                }
            }
            bindingSourcecol.DataSource = dtcol;
            bindingSourceColunms.DataSource = dt;
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void frmDinhDangCot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
                this.Close();
        }

        private void gridLookUpEditChonSheet_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            AppType Sheet = bindingSourceSheet.Current as AppType;
            if (Sheet != null)
            {
                dtcol.Clear();
                this.dtcol.PrimaryKey = new DataColumn[] { this.dtcol.Columns["Name"] };
                DataTable table = h.FillDataTable(String.Format("select * from [{0}]", dtcolex.Rows[Sheet.ID]["TABLE_NAME"]));
                dtChon = table;
                foreach (DataColumn obj in table.Columns)
                {
                    DataRow dr = dtcol.NewRow();
                    dr["Name"] = obj.ColumnName;
                    dtcol.Rows.Add(dr);
                }
            }
            bindingSourcecol.DataSource = dtcol;
            dt = bindingSourceColunms.DataSource as DataTable;
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow drDataBase = dtcol.Rows.Find(dt.Rows[i]["Caption"].ToString());
                    if (drDataBase != null)
                        dt.Rows[i]["Name"] = drDataBase["Name"].ToString();
                }
                bindingSourceColunms.DataSource = dt;
            }
            Cursor.Current = Cursors.Default;   
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}