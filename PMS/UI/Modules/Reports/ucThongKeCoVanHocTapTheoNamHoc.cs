using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using PMS.BLL;
using PMS.UI.Forms.BaoCao;

namespace PMS.UI.Modules.Reports
{
    public partial class ucThongKeCoVanHocTapTheoNamHoc : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variable
        string groupname = UserInfo.GroupName;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        #endregion
        public ucThongKeCoVanHocTapTheoNamHoc()
        {
            InitializeComponent();
        }

        private void ucThongKeCoVanHocTapTheoNamHoc_Load(object sender, EventArgs e)
        {
            #region Init GridView
            AppGridView.InitGridView(gridViewCoVanHocTap, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, true, true);
            AppGridView.ShowField(gridViewCoVanHocTap, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "MaLop", "NgayTao", "NgayKetThuc", "SoTiet", "NoiDungDanhGia", "GhiChu" }
                , new string[] { "Khoa - Bộ môn", "Mã giảng viên", "Họ tên", "Học hàm", "Học vị", "Loại giảng viên", "Lớp", "Ngày phân công", "Ngày kết thúc", "Số tiết", "Đánh giá hoàn thành", "Ghi chú" }
                , new int[] { 100, 80, 140, 90, 90, 90, 80, 100, 100, 70, 120, 200 });
            AppGridView.AlignHeader(gridViewCoVanHocTap, new string[] { "TenDonVi", "MaQuanLy", "HoTen", "TenHocHam", "TenHocVi", "TenLoaiGiangVien", "MaLop", "NgayTao", "NgayKetThuc", "SoTiet", "NoiDungDanhGia", "GhiChu" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewCoVanHocTap, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            InitData();
        }
        #region InitData
        void InitData()
        {
            #region Init Khoa-DonVi
            cboKhoa.Properties.SelectAllItemCaption = "Tất cả";
            cboKhoa.Properties.TextEditStyle = TextEditStyles.Standard;
            cboKhoa.Properties.Items.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = new VList<ViewKhoaBoMon>();
            _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();
            if (groupname != "Administrator" && groupname != "20")//Trường UEL
            {
                _vListKhoaBoMon = _vListKhoaBoMon.FindAll(p => p.MaBoMon == groupname) as VList<ViewKhoaBoMon>;
            }

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                _list.Add(new CheckedListBoxItem(v.MaBoMon, v.TenBoMon, CheckState.Unchecked, true));
            }
            cboKhoa.Properties.Items.AddRange(_list.ToArray());
            cboKhoa.Properties.SeparatorChar = ';';
            cboKhoa.CheckAll();
            #endregion

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            if (cboNamHoc.EditValue != null && cboKhoa.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.CoVanHocTap.GetByNamHocKhoaBoMon(cboNamHoc.EditValue.ToString(), cboKhoa.EditValue.ToString());
                tb.Load(reader);
                bindingSourceCVHT.DataSource = tb;
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewCoVanHocTap.FocusedRowHandle = -1;
            bindingSourceCVHT.EndEdit();
            DataTable data = bindingSourceCVHT.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;
            
            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewCoVanHocTap, bindingSourceCVHT);

            bool _fullControl = false;
            if (cboKhoa.EditValue.ToString().Contains(";"))
                _fullControl = true;

            if (vListBaoCao != null && vListBaoCao.Rows.Count > 0)
            {
                using (frmBaoCao frm = new frmBaoCao())
                {
                    frm.InCoVanHocTapTheoNamHocKhoa(PMS.Common.Globals._cauhinh.TenTruong, cboNamHoc.EditValue.ToString(), UserInfo.FullName, _fullControl, cboKhoa.Text, vListBaoCao);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    if (sf.FileName != "")
                    {
                        gridControlCoVanHocTap.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboNamHoc.EditValue != null && cboKhoa.EditValue != null)
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.CoVanHocTap.GetByNamHocKhoaBoMon(cboNamHoc.EditValue.ToString(), cboKhoa.EditValue.ToString());
                tb.Load(reader);
                bindingSourceCVHT.DataSource = tb;
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
