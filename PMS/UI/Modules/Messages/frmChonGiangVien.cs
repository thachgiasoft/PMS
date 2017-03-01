using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Columns;
using System.Reflection;


namespace PMS.UI.Modules.Messages
{
    public partial class frmChonGiangVien : DevExpress.XtraEditors.XtraForm
    {
        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        static int count = 0;
        public  string dsnhan;
        public string dsnhan_magv;

        #endregion

       
        public frmChonGiangVien()
        {
            InitializeComponent();
        //    DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
        //    CheckboxColumn.TrueValue = true;
        //    CheckboxColumn.FalseValue = false;
        //    CheckboxColumn.Width = 100;
        //    gridViewChonGiangVien.Columns.Add(CheckboxColumn);

        }

        private void frmChonGiangVien_Load(object sender, EventArgs e)
        {
            #region Khoa - đon vị
            cbbKhoaDonVi.Properties.SelectAllItemCaption = "Tất cả";
            cbbKhoaDonVi.Properties.TextEditStyle = TextEditStyles.Standard;
            cbbKhoaDonVi.Properties.Items.Clear();
            VList<ViewKhoaBoMon> _tListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon l in _tListKhoaBoMon)
                list.Add(new CheckedListBoxItem(l.MaBoMon, string.Format("{0} - {1}", l.MaBoMon, l.TenBoMon), CheckState.Unchecked, true));
            cbbKhoaDonVi.Properties.Items.AddRange(list.ToArray());
            cbbKhoaDonVi.Properties.SeparatorChar=';';
            cbbKhoaDonVi.CheckAll();
            #endregion


            #region Loại giảng viên
            cbbLoaiGiangVien.Properties.SelectAllItemCaption = "Tất cả";
            cbbLoaiGiangVien.Properties.TextEditStyle = TextEditStyles.Standard;
            cbbLoaiGiangVien.Properties.Items.Clear();
            TList<LoaiGiangVien> _tListLoaiGiangVien = DataServices.LoaiGiangVien.GetAll();
            List<CheckedListBoxItem> listgv = new List<CheckedListBoxItem>();
            foreach (LoaiGiangVien l in _tListLoaiGiangVien)
                listgv.Add(new CheckedListBoxItem(l.MaLoaiGiangVien, string.Format("{0} - {1}", l.MaQuanLy, l.TenLoaiGiangVien), CheckState.Unchecked, true));
            cbbLoaiGiangVien.Properties.Items.AddRange(listgv.ToArray());
            cbbLoaiGiangVien.Properties.SeparatorChar = ';';
            cbbLoaiGiangVien.CheckAll();
            #endregion

            #region Init gridview
            AppGridView.InitGridView(gridViewChonGiangVien, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewChonGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi","Chon"}
                    , new string[] { "Mã giảng viên", "Tên giảng viên", "Khoa - đơn vị","Chọn"}
                    , new int[] { 100, 150, 200,50 });
            AppGridView.AlignHeader(gridViewChonGiangVien, new string[] { "MaQuanLy", "HoTen", "TenDonVi", "Chon" }, DevExpress.Utils.HorzAlignment.Center);
  

            #endregion
            InitData();
            
        }

    

        void InitData()
        {

            if (cbbKhoaDonVi.EditValue != null && cbbLoaiGiangVien.EditValue != null)
            {


                DataTable tbl = ToDataTable(DataServices.ViewGiangVien.GetByMaDonViMaLoaiGiangVien(cbbKhoaDonVi.EditValue.ToString(), cbbLoaiGiangVien.EditValue.ToString()));
                tbl.Columns.Add("Chon", typeof(Boolean));

                bindingSourceChonGiangVien.DataSource = tbl;
            }

        }

        public static DataTable ToDataTable<T>(IEnumerable<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        private void cbbKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void cbbLoaiGiangVien_EditValueChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            foreach (DataRow r in (bindingSourceChonGiangVien.DataSource as DataTable).Rows)
            {
                if ((r["Chon"]).ToString().ToLower() =="true")
                {
                    dsnhan += r["HoTen"].ToString() + " ; ";
                    dsnhan_magv += r["MaQuanLy"].ToString() + ";";
                }

            }
            this.Close();
        }

        private void cbbChonTatCa_Click(object sender, EventArgs e)
        {
            count++;

            if (count % 2 == 0)
            {
                cbbChonTatCa.Text = "Chọn tất cả";
                foreach (DataRow r in (bindingSourceChonGiangVien.DataSource as DataTable).Rows)
                {
                    r["Chon"] = 0;
                }
            }
            else
            {
                cbbChonTatCa.Text = "Bỏ chọn tất cả";
                foreach (DataRow r in (bindingSourceChonGiangVien.DataSource as DataTable).Rows)
                {
                    r["Chon"] = 1;
                }
            }

        }



    
    }
}