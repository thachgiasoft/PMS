using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PMS.BLL;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Modules.Reports
{
    public partial class ucDanhSachSinhVienDongPhi : UserControl
    {
        #region Variable
        string groupname = UserInfo.GroupName;
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        private bool user = false;
        #endregion

        #region Event Form
        public ucDanhSachSinhVienDongPhi()
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

        private void ucDanhSachSinhVienDongPhi_Load(object sender, EventArgs e)
        {
            #region InitGridView 
            AppGridView.InitGridView(gridViewSinhVien, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, true);
            AppGridView.ShowField(gridViewSinhVien, new string[] { "MaSinhVien", "HoTenSinhVien", "NgaySinh", "MaLopHocPhan", "MaLopSinhVien", "MaGiangVien", "HoTenGiangVien", "TinhTrangPhi" }
                    , new string[] { "Mã sinh viên", "Họ tên sinh viên", "Ngày sinh", "Mã lớp học phần", "Mã lớp sinh viên", "Mã giảng viên", "Họ tên giảng viên", "Tình trạng phí" }
                    , new int[] { 90, 150, 80, 100, 120, 120, 250, 110 });
            AppGridView.AlignHeader(gridViewSinhVien, new string[] { "MaSinhVien", "HoTenSinhVien", "NgaySinh", "MaLopHocPhan", "MaLopSinhVien", "MaGiangVien", "HoTenGiangVien", "TinhTrangPhi" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ReadOnlyColumn(gridViewSinhVien);
            AppGridView.SummaryField(gridViewSinhVien, "TinhTrangPhi", "Tổng cộng: {0} SV.", DevExpress.Data.SummaryItemType.Count);
            #endregion

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Hoc Ky
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã hoc kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            #region Lop hoc phan
            AppGridLookupEdit.InitGridLookUp(cboLopHocPhan, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboLopHocPhan, new string[] { "MaLopHocPhan", "TenLopHocPhan", "TenMonHoc", "MaLop", "TenLop" }, new string[] { "Mã lớp HP", "Tên lớp HP", "Tên môn học", "Mã lớp SV", "Tên lớp SV" }, new int[] { 120, 100, 160, 120, 150 });
            AppGridLookupEdit.InitPopupFormSize(cboLopHocPhan, 600, 400);
            cboLopHocPhan.Properties.ValueMember = "MaLopHocPhan";
            cboLopHocPhan.Properties.DisplayMember = "MaLopHocPhan";
            cboLopHocPhan.Properties.NullText = "Chọn lớp học phần";
            #endregion

            InitData();
        }
        #endregion

        #region Init data
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceLopHocPhan.DataSource = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "(*.xls)|*.xls";
            sf.ShowDialog();
            if (sf.FileName != "")
            {
                gridControlSinhVien.ExportToXls(sf.FileName);
                XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLocDuLieu_Click(object sender, EventArgs e)
        {
            if (cboLopHocPhan.EditValue != null && cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                //IDataReader dr = DataServices.KhoiLuongGiangDayChiTiet.GetSinhVienByLopHocPhanNamHocHocKy(cboLopHocPhan.EditValue.ToString(), cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                //DataTable dt = new DataTable();
                //dt.Load(dr);
                //bindingSourceSinhVien.DataSource = dt;
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            }
            if (cboHocKy.EditValue != null)
            {
                bindingSourceLopHocPhan.DataSource = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceLopHocPhan.DataSource = DataServices.ViewLopHocPhan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }
    }
}
