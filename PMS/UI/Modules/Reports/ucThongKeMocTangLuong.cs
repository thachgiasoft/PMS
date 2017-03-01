using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.BLL;
using PMS.Services;
using DevExpress.XtraEditors.Controls;
using DevExpress.Common.DataForm;
using PMS.UI.Forms.BaoCao;
using PMS.Services;
using System;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeMocTangLuong : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        string groupname = UserInfo.GroupName;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _matruong;
        private bool user = false;
        #endregion

        #region Event Form

        public ucThongKeMocTangLuong()
        {
            InitializeComponent();
            _matruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            TList<CauHinh> cauHinh = DataServices.CauHinh.GetAll();
            if (cauHinh != null)
            {
                foreach (CauHinh ch in cauHinh)
                {
                    if (ch.TrangThai == true)
                        PMS.Common.Globals._cauhinh = ch;
                }
            }
        }
        #endregion

        private void ucThongKeMocTangLuong_Load(object sender, EventArgs e)
        {
            #region InitGridview
            AppGridView.InitGridView(gridViewMocTangLuong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewMocTangLuong, new string[] { "MaGiangVien", "HoTen", "TenHocHam", "TenHocVi", "TenKhoa", "TenLoaiGiangVien", "MocTangLuong", "ThoiGianTangLuong", "GhiChu" },
                new string[] { "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Khoa - đơn vị", "Loại giảng viên", "Mốc tăng lương", "Thời gian tăng lương", "Ghi chú" },
                new int[] {130,150,80,80,150,100,80,80,80});
            AppGridView.ReadOnlyColumn(gridViewMocTangLuong);
            AppGridView.SummaryField(gridViewMocTangLuong, "HoTen", "Thổng cộng {0} GV.", DevExpress.Data.SummaryItemType.Count);

            #endregion
            InitData();
        }

        #region InitData
        void InitData()
        {
            dateEditNgay.DateTime = DateTime.Now;

        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;

        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlMocTangLuong.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }

        private void chbLocDuLieu_CheckedChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if(dateEditNgay.EditValue.ToString()!="")
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.GiangVien.GetByMaGiangVienMocTangLuong(dateEditNgay.DateTime);
                tb.Load(reader);
                bindingSourceMocTangLuong.DataSource = tb;
            }
            gridViewMocTangLuong.ExpandAllGroups();

            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewMocTangLuong.FocusedRowHandle = -1;
            bindingSourceMocTangLuong.EndEdit();
            AppType objLoaiBaoCao = bindingSourceMocTangLuong.Current as AppType;
            DataTable data = bindingSourceMocTangLuong.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewMocTangLuong, bindingSourceMocTangLuong);

            string khoa = "";
            if (_matruong == "UTE")
            {
                khoa = groupname;
            }
            else
            {
                VList<ViewKhoa> _vkhoa = DataServices.ViewKhoa.GetAll();
                    try
                {
                    khoa = _vkhoa.Find(p => p.MaKhoa == groupname).TenKhoa;
                }
                catch
                {
                    khoa = "";
                }
            }

            if (groupname == "Administrator" || groupname == "User")
                khoa = "";

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InThongKeMocTangLuong(PMS.Common.Globals._cauhinh.TenTruong, khoa, PMS.Common.Globals._cauhinh.NguoiLapbieu, vListBaoCao);
                    frm.ShowDialog();
                }
            }

            Cursor.Current = Cursors.Default;
   
        }

        private void dateEditNgay_EditValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
