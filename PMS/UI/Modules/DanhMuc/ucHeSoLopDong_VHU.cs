using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Entities;
using PMS.Services;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.BLL;
using DevExpress.XtraGrid.Columns;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoLopDong_VHU : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;

                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnXoa.ShortCut = Shortcut.None;

                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnSaoChep.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        #endregion
        public ucHeSoLopDong_VHU()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucHeSoLopDong_VHU_Load(object sender, EventArgs e)
        {
            #region Init Gridview
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

            #region _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            cboNamHoc.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Năm học hiện tại").GiaTri;
            #endregion

            #region _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Tên học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "TenHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            cboHocKy.EditValue = _cauHinhChung.Find(p => p.TenCauHinh == "Học kỳ hiện tại").GiaTri;
            #endregion

            List<CheckedListBoxItem> _list;

            #region repository BacDaoTao
            repositoryItemCheckedComboBoxEditBacDaoTao.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditBacDaoTao.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.Clear();

            VList<ViewBacDaoTao> _vListBacDaoTao = new VList<ViewBacDaoTao>();
            _vListBacDaoTao = DataServices.ViewBacDaoTao.GetAll();

            _list = new List<CheckedListBoxItem>();
            foreach (ViewBacDaoTao v in _vListBacDaoTao)
            {
                _list.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.TenBacDaoTao, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.AddRange(_list.ToArray());
            repositoryItemCheckedComboBoxEditBacDaoTao.SeparatorChar = ';';
            #endregion

            #region repository Khoa đơn vị
            repositoryItemCheckedComboBoxEditDonVi.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditDonVi.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditDonVi.Items.Clear();

            VList<ViewKhoa> _vListKhoa = new VList<ViewKhoa>();
            _vListKhoa = DataServices.ViewKhoa.GetAll();

            _list = new List<CheckedListBoxItem>();
            foreach (ViewKhoa v in _vListKhoa)
            {
                _list.Add(new CheckedListBoxItem(v.MaKhoa, v.TenKhoa, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditDonVi.Items.AddRange(_list.ToArray());
            repositoryItemCheckedComboBoxEditDonVi.SeparatorChar = ';';
            #endregion

            #region repository Loại giảng viên
            repositoryItemCheckedComboBoxEditLoaiGiangVien.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditLoaiGiangVien.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditLoaiGiangVien.Items.Clear();

            TList<LoaiGiangVien> _vListLoaiGiangVien = new TList<LoaiGiangVien>();
            _vListLoaiGiangVien = DataServices.LoaiGiangVien.GetAll();

            _list = new List<CheckedListBoxItem>();
            foreach (LoaiGiangVien v in _vListLoaiGiangVien)
            {
                _list.Add(new CheckedListBoxItem(v.MaLoaiGiangVien, v.TenLoaiGiangVien, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditLoaiGiangVien.Items.AddRange(_list.ToArray());
            repositoryItemCheckedComboBoxEditLoaiGiangVien.SeparatorChar = ';';
            #endregion

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }

            InitData();
        }

        void InitGridVHU()
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewHeSoLopDong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoLopDong, new string[] { "Stt", "MaLoaiGiangVien", "MaDonVi", "MaBacDaoTao", "TuKhoan", "DenKhoan", "HeSo", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "STT", "Loại giảng viên", "Khoa - Đơn vị", "Bậc đào tạo", "Từ khoản", "Đến khoản", "Hệ số", "Ngày cập nhật", "Người cập nhật" },
                        new int[] { 50, 100, 200, 120, 90, 90, 80, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSoLopDong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoLopDong, new string[] { "Stt", "MaLoaiGiangVien", "MaDonVi", "MaBacDaoTao", "TuKhoan", "DenKhoan", "HeSo", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.FixedField(gridViewHeSoLopDong, new string[] { "Stt", "MaLoaiGiangVien", "MaDonVi", "MaBacDaoTao" }, FixedStyle.Left);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaBacDaoTao", repositoryItemCheckedComboBoxEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaLoaiGiangVien", repositoryItemCheckedComboBoxEditLoaiGiangVien);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaDonVi", repositoryItemCheckedComboBoxEditDonVi);
            AppGridView.HideField(gridViewHeSoLopDong, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion
        }

        void InitRemaining()
        {
            #region InitGridView
            AppGridView.InitGridView(gridViewHeSoLopDong, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoLopDong, new string[] { "Stt", "MaBacDaoTao", "TuKhoan", "DenKhoan", "HeSo", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "STT", "Bậc đào tạo", "Từ khoản", "Đến khoản", "Hệ số", "Ngày cập nhật", "Người cập nhật" },
                        new int[] { 50, 120, 90, 90, 80, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSoLopDong, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoLopDong, new string[] { "Stt", "MaBacDaoTao", "TuKhoan", "DenKhoan", "HeSo", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSoLopDong, "MaBacDaoTao", repositoryItemCheckedComboBoxEditBacDaoTao);
            AppGridView.HideField(gridViewHeSoLopDong, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion
        }

        #region InitData
        private void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoLopDong.DataSource = DataServices.HeSoLopDong.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoLopDong);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoLopDong.FocusedRowHandle = -1;
            TList<HeSoLopDong> list = bindingSourceHeSoLopDong.DataSource as TList<HeSoLopDong>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (HeSoLopDong d in list)
                            {
                                d.NamHoc = cboNamHoc.EditValue.ToString();
                                d.HocKy = cboHocKy.EditValue.ToString();
                            }
                            bindingSourceHeSoLopDong.EndEdit();
                            DataServices.HeSoLopDong.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    InitData();
                }
            }
        }

        private void gridViewHeSoLopDong_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoLopDong, e);
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                        if (sf.FileName != "")
                        {
                            gridControlHeSoLopDong.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void gridViewHeSoLopDong_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "Stt" || col.FieldName == "MaBacDaoTao" || col.FieldName == "TuKhoan" || col.FieldName == "DenKhoan" || col.FieldName == "HeSo")
            {
                gridViewHeSoLopDong.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewHeSoLopDong.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoLopDong.DataSource = DataServices.HeSoLopDong.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoLopDong.DataSource = DataServices.HeSoLopDong.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepHeSoLopDong"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepHeSoLopDong"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }
    }
}
