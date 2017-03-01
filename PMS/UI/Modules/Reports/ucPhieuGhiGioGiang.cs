using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.BLL;
using DevExpress.XtraEditors.Controls;
using DevExpress.Common.DataForm;
using PMS.UI.Forms.BaoCao;
using PMS.Services;

namespace PMS.UI.Modules.Reports
{
    public partial class ucPhieuGhiGioGiang : XtraUserControl
    {
        #region Variable
        string groupname = UserInfo.GroupName;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        private bool user = false;
        #endregion

        #region Event Form
        public ucPhieuGhiGioGiang()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
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

        private void ucPhieuGhiGioGiang_Load(object sender, EventArgs e)
        {
            #region InitGridView 
            AppGridView.InitGridView(gridViewLopHocPhan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewLopHocPhan, new string[] { "MaLopHocPhan", "TenHocPhan", "MaLop", "Tuan", "NgayDay", "HoTenGiangVien", "SoTinChi", "SiSo", "KhoaQuanLyHocPhan"}
                    , new string[] { "Mã lớp học phần", "Tên học phần", "Mã lớp", "Tuần", "Ngày dạy", "Giảng viên", "Số tín chỉ", "Sĩ số", "Khoa quản lý học phần" }
                    , new int[] { 100, 200, 120, 60, 80, 120, 60, 50, 150 });
            AppGridView.AlignHeader(gridViewLopHocPhan, new string[] { "MaLopHocPhan", "TenHocPhan", "MaLop", "Tuan", "NgayDay", "HoTenGiangVien", "SoTinChi", "SiSo", "KhoaQuanLyHocPhan" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewLopHocPhan);
            AppGridView.SummaryField(gridViewLopHocPhan, "MaLopHocPhan", "{0} lớp", DevExpress.Data.SummaryItemType.Count);
            //gridViewDanhSachGiangVien.Columns["Khoa"].GroupIndex = 0;
            AppGridView.FixedField(gridViewLopHocPhan, new string[] { "MaLopHocPhan", "TenHocPhan", "MaLop" }, DevExpress.XtraGrid.Columns.FixedStyle.Left);
            #endregion
            
            #region Năm học
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Học kỳ
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Init mã LHP
            AppGridLookupEdit.InitGridLookUp(cboMaLopHocPhan, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboMaLopHocPhan, new string[] { "MaLopHocPhan","TenMonHoc","MaLop", "TenLoaiHocPhan" }, new string[] { "Lớp học phần","Môn học","Lớp SV", "Loại học phần" }, new int[] {100, 200, 80, 80});
            AppGridLookupEdit.InitPopupFormSize(cboMaLopHocPhan, 470, 500);
            cboMaLopHocPhan.Properties.ValueMember = "MaLopHocPhan";
            cboMaLopHocPhan.Properties.DisplayMember = "MaLopHocPhan";
            cboMaLopHocPhan.Properties.NullText = string.Empty;
            #endregion

            InitData();
        }
        #endregion

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if(cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            if(cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceLopHocPhan.DataSource = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
            gridViewLopHocPhan.ExpandAllGroups();
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress. XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "(*.xls)|*.xls";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    gridControlLopHocPhan.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewLopHocPhan.FocusedRowHandle = -1;
            bindingSourceLopHocPhan.EndEdit();
            AppType objLoaiBaoCao = bindingSourceLopHocPhan.Current as AppType;
            DataTable data = bindingSourcePhieuGhiGioGiang.DataSource as DataTable;

            if (data == null)
                return;
            DataTable vListBaoCao = data;

            vListBaoCao = Common.XuLyGiaoDien.LayDuLieuIn(gridViewLopHocPhan, bindingSourceLopHocPhan);

            string khoa = "";
            if (_maTruong == "UTE")
            {
                khoa = groupname;
            }
            else
            {
                VList<ViewKhoa> _vKhoa = DataServices.ViewKhoa.GetAll();
                try
                {
                    khoa = _vKhoa.Find(p => p.MaKhoa == groupname).TenKhoa;
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
                    DataTable dtSub = new DataTable();
                    IDataReader idr = DataServices.KhoiLuongGiangDayChiTiet.GetGiangVienSoTiet(cboMaLopHocPhan.EditValue.ToString());
                    dtSub.Load(idr);
                    frm.InPhieuGhiGioGiang(vListBaoCao,dtSub);
                    frm.ShowDialog();
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (cboMaLopHocPhan.EditValue.ToString() != "")
            {
                DataTable tb = new DataTable();
                IDataReader reader = DataServices.KhoiLuongGiangDayChiTiet.GetThongTinChiTiet(cboMaLopHocPhan.EditValue.ToString());
                tb.Load(reader);
                bindingSourcePhieuGhiGioGiang.DataSource = tb;
            }
            gridViewLopHocPhan.ExpandAllGroups();
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceLopHocPhan.DataSource = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }
    }
}
