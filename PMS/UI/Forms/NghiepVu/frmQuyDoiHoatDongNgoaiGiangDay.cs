using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmQuyDoiHoatDongNgoaiGiangDay : DevExpress.XtraEditors.XtraForm
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnQuyDoi.Enabled = false;
            }
            else
            {
                btnQuyDoi.Enabled = true;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _groupName = UserInfo.GroupName;
        bool _userRole;
        #endregion
        public frmQuyDoiHoatDongNgoaiGiangDay()
        {
            InitializeComponent();
        }

        private void frmQuyDoiHoatDongNgoaiGiangDay_Load(object sender, EventArgs e)
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewQuyDoiHDNgoaiGiangDay, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false);
            AppGridView.ShowField(gridViewQuyDoiHDNgoaiGiangDay, new string[] { "HocKy", "MaQuanLy", "Ho", "Ten", "TenHoatDong", "MaLop", "SoLuong", "MucQuyDoi", "DonGia", "SoTietQuyDoi", "SoTien" }
                        , new string[] { "Học kỳ", "Mã giảng viên", "Họ", "Tên", "Hoạt động ngoài giảng dạy", "Lớp học phần", "Số lượng", "Mức quy đổi", "Đơn giá", "Số tiết quy đổi", "Số tiền" }
                        , new int[] { 80, 90, 130, 70, 350, 120, 90, 100, 90, 120, 100 });
            AppGridView.AlignHeader(gridViewQuyDoiHDNgoaiGiangDay, new string[] { "HocKy", "MaQuanLy", "Ho", "Ten", "TenHoatDong", "SoLuong", "MucQuyDoi", "DonGia", "SoTietQuyDoi", "SoTien" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.SummaryField(gridViewQuyDoiHDNgoaiGiangDay, "MaQuanLy", "{0}", DevExpress.Data.SummaryItemType.Count);
            AppGridView.SummaryField(gridViewQuyDoiHDNgoaiGiangDay, "SoLuong", "{0:n0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewQuyDoiHDNgoaiGiangDay, "SoTietQuyDoi", "{0:n2}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.SummaryField(gridViewQuyDoiHDNgoaiGiangDay, "SoTien", "{0:n0}", DevExpress.Data.SummaryItemType.Sum);
            AppGridView.FormatDataField(gridViewQuyDoiHDNgoaiGiangDay, "SoLuong", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewQuyDoiHDNgoaiGiangDay, "DonGia", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.FormatDataField(gridViewQuyDoiHDNgoaiGiangDay, "SoTien", DevExpress.Utils.FormatType.Custom, "n0");
            gridViewQuyDoiHDNgoaiGiangDay.Columns["HocKy"].GroupIndex = 0;
            AppGridView.ReadOnlyColumn(gridViewQuyDoiHDNgoaiGiangDay);
            #endregion

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region Khoa bộ môn
            AppGridLookupEdit.InitGridLookUp(cboKhoaDonVi, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboKhoaDonVi, new string[] { "MaBoMon", "TenBoMon" }, new string[] { "Mã bộ môn", "Tên bộ môn" });
            cboKhoaDonVi.Properties.DisplayMember = "TenBoMon";
            cboKhoaDonVi.Properties.ValueMember = "MaBoMon";
            cboKhoaDonVi.Properties.NullText = string.Empty;

            #endregion

            InitData();
        }

        #region InitData
        void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
            {
                InitHocKy();
            }

            cboKhoaDonVi.DataBindings.Clear();

            VList<ViewKhoaBoMon> _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetAll();

            foreach (ViewKhoaBoMon v in _vListKhoaBoMon)
            {
                if (_groupName == v.MaBoMon)
                {
                    _userRole = true;
                    break;
                }
                else
                {
                    _userRole = false;
                }
            }


            if (_userRole)
            {
                _vListKhoaBoMon = DataServices.ViewKhoaBoMon.GetByMaBoMon(_groupName);
            }
            else
            {
                _vListKhoaBoMon.Add(new ViewKhoaBoMon() { ThuTu = 0, MaBoMon = "-1", TenBoMon = "[Tất cả]" });
            }

            bindingSourceKhoaDonVi.DataSource = _vListKhoaBoMon;

            //bindingSourceKhoaDonVi.DataSource = DataServices.ViewKhoaBoMon.GetAll();
            cboKhoaDonVi.DataBindings.Add("EditValue", bindingSourceKhoaDonVi, "MaBoMon", true, DataSourceUpdateMode.OnPropertyChanged);

            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null && cboKhoaDonVi.EditValue != null)
            {
                bindingSourceQuyDoiHDNgoaiGiangDay.DataSource = DataServices.ViewQuyDoiHoatDongNgoaiGiangDay.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                gridViewQuyDoiHDNgoaiGiangDay.ExpandAllGroups();
            }
        }

        void InitHocKy()
        {
            #region _hocKy
            VList<ViewHocKy> listHocKy = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            cboHocKy.Properties.SelectAllItemCaption = "Tất cả";
            cboHocKy.Properties.TextEditStyle = TextEditStyles.Standard;
            cboHocKy.Properties.Items.Clear();

            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            for (int i = 0; i < listHocKy.Count; i++)
            {
                list.Add(new CheckedListBoxItem(listHocKy[i].MaHocKy,
                            String.Format("{0} - {1}", listHocKy[i].MaHocKy, listHocKy[i].TenHocKy),
                            CheckState.Unchecked, true));
            }
            cboHocKy.Properties.Items.AddRange(list.ToArray());
            cboHocKy.Properties.SeparatorChar = ';';
            //cboHocKy.CheckAll();
            #endregion
        }
        #endregion

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.WaitCursor;
        }

        private void btnQuyDoi_Click(object sender, EventArgs e)
        {
            if (cboHocKy.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn học kỳ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboHocKy.Focus();
                return;
            }
            if (XtraMessageBox.Show("Thực hiện quy đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DataServices.QuyDoiHoatDongNgoaiGiangDay.QuyDoiTheoNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                    XtraMessageBox.Show("Thực hiện quy đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình quy đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            bindingSourceQuyDoiHDNgoaiGiangDay.DataSource = DataServices.ViewQuyDoiHoatDongNgoaiGiangDay.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
            gridViewQuyDoiHDNgoaiGiangDay.ExpandAllGroups();
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            InitHocKy();
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceQuyDoiHDNgoaiGiangDay.DataSource = DataServices.ViewQuyDoiHoatDongNgoaiGiangDay.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                gridViewQuyDoiHDNgoaiGiangDay.ExpandAllGroups();
            }
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlQuyDoi.ExportToXls(sf.FileName);
                            Common.XuLyGiaoDien.ThongBao("Xuất file thành công.",MessageBoxIcon.Information, true);
                        }
                }
            }
            catch (Exception ex)
            {
                Common.XuLyGiaoDien.ThongBaoLoi(ex, true);
            }
        }

        private void cboKhoaDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
            {
                bindingSourceQuyDoiHDNgoaiGiangDay.DataSource = DataServices.ViewQuyDoiHoatDongNgoaiGiangDay.GetByNamHocHocKyMaDonVi(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), cboKhoaDonVi.EditValue.ToString());
                gridViewQuyDoiHDNgoaiGiangDay.ExpandAllGroups();
            }
        }
    }
}