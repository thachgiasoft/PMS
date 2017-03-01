using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;

namespace PMS.UI.Forms.NghiepVu.ChucNangCon
{
    public partial class frmChonHeSoThucHanh : DevExpress.XtraEditors.XtraForm
    {

        public decimal _hesoquydoithuchanhsanglythuyet = 0;
        public frmChonHeSoThucHanh()
        {
            InitializeComponent();
        }

        private void frmChonHeSoThucHanh_Load(object sender, EventArgs e)
        {
            AppGridView.InitGridView(gridViewHeSoThucHanh, false, false, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewHeSoThucHanh, new string[] { "HeSo" }, new string[] { "Hệ số" }, new int[] { 100 });
            AppGridView.ReadOnlyColumn(gridViewHeSoThucHanh);
            AppGridView.AlignHeader(gridViewHeSoThucHanh, new string[] { "HeSo" }, DevExpress.Utils.HorzAlignment.Center);

            TList<CauHinhChung> _listCauHinhChung = DataServices.CauHinhChung.GetAll();
            string _heSoQuyDoiThucHanh = _listCauHinhChung.Find(p => p.TenCauHinh == "Hệ số quy đổi thực hành sang lý thuyết").GiaTri;

            

            DataTable tbDataSource = new DataTable();
            tbDataSource.Columns.Add(new DataColumn("HeSo", typeof(System.String)));
            DataRow row1 = tbDataSource.NewRow();
            row1["HeSo"] = "1";

            DataRow row2 = tbDataSource.NewRow();
            row2["HeSo"] = _heSoQuyDoiThucHanh;

            tbDataSource.Rows.Add(row1);
            tbDataSource.Rows.Add(row2);

            bindingSourceHeSoThucHanh.DataSource = tbDataSource;
        }

        private void gridControlHeSoThucHanh_DoubleClick(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hi = gridViewHeSoThucHanh.CalcHitInfo((sender as Control).PointToClient(Control.MousePosition));

            if (hi.RowHandle >= 0)
            {
                DataRow dr = gridViewHeSoThucHanh.GetDataRow(hi.RowHandle);

                _hesoquydoithuchanhsanglythuyet = ConvertDecimal(dr["HeSo"].ToString());

                this.Close();
            }
        }

        decimal ConvertDecimal(string s)
        {
            decimal result = 0;
            try
            {
                if (s.Contains("/"))
                    result = decimal.Parse(s.Split('/')[0].ToString()) / decimal.Parse(s.Split('/')[1].ToString());
                else
                    result = decimal.Parse(s);
            }
            catch
            {
                result = 0;
            }

            return result;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            DataRowView r = gridViewHeSoThucHanh.GetFocusedRow() as DataRowView;
            if (r != null)
            {
                _hesoquydoithuchanhsanglythuyet = ConvertDecimal(r["HeSo"].ToString());
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn hệ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}