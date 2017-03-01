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
using PMS.Services;
using PMS.Entities;
using PMS.Entities.Validation;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;
using PMS.UI.Forms.NghiepVu.ChucNangCon;
using System.Data.SqlClient;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucQuyDinhCacHeSoKhac_VHU : DevExpress.XtraEditors.XtraUserControl
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

        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        public ucQuyDinhCacHeSoKhac_VHU()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p=>p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucQuyDinhCacHeSoKhac_VHU_Load(object sender, EventArgs e)
        {
            #region Init Gridview
            switch (_maTruong)
            {
               case "VHU":
                    InitGridVHU();
                    break;
               case "HBU":
                    InitGridVHU();  //theo VHU
                    break;
               case "DLU":
                    InitGridDLU();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion

            #region MaLoaiKhoiLuong
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditMaLoaiKhoiLuong, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditMaLoaiKhoiLuong, new string[] { "MaLoaiKhoiLuong", "TenLoaiKhoiLuong" }, new string[] { "Mã loại khối lượng", "Tên loại khối lượng" });
            repositoryItemGridLookUpEditMaLoaiKhoiLuong.DisplayMember = "TenLoaiKhoiLuong";
            repositoryItemGridLookUpEditMaLoaiKhoiLuong.ValueMember = "MaLoaiKhoiLuong";
            repositoryItemGridLookUpEditMaLoaiKhoiLuong.NullText = string.Empty;
            repositoryItemGridLookUpEditMaLoaiKhoiLuong.BestFitMode = BestFitMode.BestFit;
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

            #region DonVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditDonViTinh, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditDonViTinh, new string[] { "MaQuanLy", "TenDonVi" }, new string[] { "Mã đơn vị", "Tên đơn vị" });
            repositoryItemGridLookUpEditDonViTinh.DisplayMember = "TenDonVi";
            repositoryItemGridLookUpEditDonViTinh.ValueMember = "MaDonVi";
            repositoryItemGridLookUpEditDonViTinh.NullText = string.Empty;
            repositoryItemGridLookUpEditDonViTinh.BestFitMode = BestFitMode.BestFit;
            #endregion

            #region NhomMomHoc
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNhomMonHoc, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNhomMonHoc, new string[] { "MaQuanLy", "TenNhomMon" }, new string[] { "Mã nhóm môn học", "Tên nhóm môn học" });
            repositoryItemGridLookUpEditNhomMonHoc.DisplayMember = "TenNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.ValueMember = "MaNhomMon";
            repositoryItemGridLookUpEditNhomMonHoc.NullText = string.Empty;
            repositoryItemGridLookUpEditNhomMonHoc.BestFitMode = BestFitMode.BestFit;
            #endregion

            #region Bậc đào tạo
            repositoryItemCheckedComboBoxEditBacDaoTao.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.Clear();
            repositoryItemCheckedComboBoxEditBacDaoTao.SeparatorChar = ';';
            repositoryItemCheckedComboBoxEditBacDaoTao.TextEditStyle = TextEditStyles.Standard;
            VList<ViewBacDaoTao> _TlistBac = DataServices.ViewBacDaoTao.GetAll();
            List<CheckedListBoxItem> listBac = new List<CheckedListBoxItem>();
            foreach (ViewBacDaoTao v in _TlistBac)
            {
                listBac.Add(new CheckedListBoxItem(v.MaBacDaoTao, v.TenBacDaoTao, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditBacDaoTao.Items.AddRange(listBac.ToArray());
            #endregion

            #region Loại hình đào tạo
            repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.Items.Clear();
            repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.SeparatorChar = ';';
            repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.TextEditStyle = TextEditStyles.Standard;
            VList<ViewLoaiHinhDaoTao> _TlistLoaiHinh = DataServices.ViewLoaiHinhDaoTao.GetAll();
            List<CheckedListBoxItem> listLoaiHinh = new List<CheckedListBoxItem>();
            foreach (ViewLoaiHinhDaoTao v in _TlistLoaiHinh)
            {
                listLoaiHinh.Add(new CheckedListBoxItem(v.MaLoaiHinh, v.TenLoaiHinh, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditLoaiHinhDaoTao.Items.AddRange(listLoaiHinh.ToArray());
            #endregion

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                cboHocKy.EditValue = "";
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }

            InitData();
        }


        void InitGridVHU()
        {
            #region Init GridView QuyDoiGioChuan
            AppGridView.InitGridView(gridViewHeSo, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSo, new string[] { "ThuTu", "MaLoaiKhoiLuong", "MaQuanLy", "TenQuyDoi", "SoLuong", "MaDonVi", "HeSo", "GhiChu", "CongDon", "NgayCapNhat", "NguoiCapNhat" },
                new string[] { "STT", "Loại khối lượng", "Mã quy đổi", "Tên quy đổi", "Số lượng", "Đơn vị", "Hệ số", "Ghi Chú", "Nhập khối lượng khác", "Ngày cập nhật", "Người cập nhật" },
                new int[] { 70, 120, 90, 300, 80, 80, 80, 200, 120, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSo, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSo, new string[] { "ThuTu", "MaLoaiKhoiLuong", "MaQuanLy", "TenQuyDoi", "SoLuong", "MaDonVi", "HeSo", "GhiChu", "CongDon", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSo, "MaLoaiKhoiLuong", repositoryItemGridLookUpEditMaLoaiKhoiLuong);
            AppGridView.RegisterControlField(gridViewHeSo, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.RegisterControlField(gridViewHeSo, "MaDonVi", repositoryItemGridLookUpEditDonViTinh);
            AppGridView.HideField(gridViewHeSo, new string[] { "NgayCapNhat", "NguoiCapNhat", "CongDon" });
            #endregion
        }

        void InitGridDLU()
        {
            #region Init GridView QuyDoiGioChuan
            AppGridView.InitGridView(gridViewHeSo, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSo, new string[] { "ThuTu", "MaLoaiKhoiLuong", "MaQuanLy", "TenQuyDoi", "SoLuong", "MaDonVi", "HeSo", "MaBacDaoTao", "MaLoaiHinh", "CoSuDungHeSoChucDanh", "KhoaNhapLieu", "NhomMonHoc", "NgayCapNhat", "NguoiCapNhat" },
                new string[] { "STT", "Loại khối lượng", "Mã quy đổi", "Tên quy đổi", "Số lượng", "Đơn vị", "Hệ số", "Bậc đào tạo", "Loại hình đào tạo", "Có HS chức danh", "Khoa nhập", "Nhóm môn học", "Ngày cập nhật", "Người cập nhật" },
                new int[] { 50, 120, 70, 280, 60, 60, 60, 90, 110, 100, 80, 100, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSo, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSo, new string[] { "ThuTu", "MaLoaiKhoiLuong", "MaQuanLy", "TenQuyDoi", "SoLuong", "MaDonVi", "HeSo", "MaBacDaoTao", "MaLoaiHinh", "CoSuDungHeSoChucDanh", "KhoaNhapLieu", "NhomMonHoc", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSo, "MaLoaiKhoiLuong", repositoryItemGridLookUpEditMaLoaiKhoiLuong);
            AppGridView.RegisterControlField(gridViewHeSo, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.RegisterControlField(gridViewHeSo, "MaDonVi", repositoryItemGridLookUpEditDonViTinh);
            AppGridView.RegisterControlField(gridViewHeSo, "MaBacDaoTao", repositoryItemCheckedComboBoxEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewHeSo, "MaLoaiHinh", repositoryItemCheckedComboBoxEditLoaiHinhDaoTao);
            AppGridView.RegisterControlField(gridViewHeSo, "CoSuDungHeSoChucDanh", repositoryItemButtonEditHeSoChucDanh);
            AppGridView.RegisterControlField(gridViewHeSo, "NhomMonHoc", repositoryItemGridLookUpEditNhomMonHoc);
            AppGridView.HideField(gridViewHeSo, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion
        }

        void InitRemaining()
        {
            #region Init GridView QuyDoiGioChuan
            AppGridView.InitGridView(gridViewHeSo, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSo, new string[] { "ThuTu", "MaQuanLy", "TenQuyDoi", "MaDonVi", "HeSo", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                new string[] { "STT", "Mã quy đổi", "Tên quy đổi", "Đơn vị", "Hệ số", "Ghi Chú", "Ngày cập nhật", "Người cập nhật" },
                new int[] { 70, 90, 300, 80, 80, 250, 99, 99 });
            AppGridView.ShowEditor(gridViewHeSo, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewHeSo, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.RegisterControlField(gridViewHeSo, "MaDonVi", repositoryItemGridLookUpEditDonViTinh);
            AppGridView.HideField(gridViewHeSo, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            #endregion
        }

        void InitData()
        {
            bindingSourceNhomMonHoc.DataSource = DataServices.NhomMonHoc.GetAll();
            bindingSourceMaLoaiKhoiLuong.DataSource = DataServices.LoaiKhoiLuong.GetAll();
            bindingSourceDonVi.DataSource = DataServices.DonViTinh.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSo.DataSource = DataServices.QuyDoiGioChuan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSo);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSo.FocusedRowHandle = -1;
            TList<QuyDoiGioChuan> list = bindingSourceHeSo.DataSource as TList<QuyDoiGioChuan>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHeSo.EndEdit();
                            foreach (QuyDoiGioChuan q in list)
                            {
                                q.NamHoc = cboNamHoc.EditValue.ToString();
                                q.HocKy = cboHocKy.EditValue.ToString();
                            }
                            DataServices.QuyDoiGioChuan.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch(SqlException ex)
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        sf.FileName = "Quy đổi giờ chuẩn";
                        if (sf.FileName != "")
                        {
                            gridControlHeSo.ExportToXls(sf.FileName);
                            XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ucQuyDinhCacHeSoKhac_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSo, e);
        }

        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            QuyDoiGioChuan obj = target as QuyDoiGioChuan;
            if (obj != null)
            {
                if (((TList<QuyDoiGioChuan>)bindingSourceHeSo.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewHeSo_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            QuyDoiGioChuan obj = e.Row as QuyDoiGioChuan;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaQuanLy");
                if (obj.IsValid)
                    e.Valid = true;
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void gridViewHeSo_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaQuanLy" || col.FieldName == "TenQuyDoi" || col.FieldName == "MaDonVi" || col.FieldName == "HeSo")
            {
                gridViewHeSo.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewHeSo.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSo.DataSource = DataServices.QuyDoiGioChuan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSo.DataSource = DataServices.QuyDoiGioChuan.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepQuyDinhCacHeSoKhac_VHU"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepQuyDinhCacHeSoKhac_VHU"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }

        private void gridViewHeSo_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.FieldName == "CoSuDungHeSoChucDanh")
            {
                
                QuyDoiGioChuan qd = gridViewHeSo.GetRow(e.RowHandle) as QuyDoiGioChuan;
                if (qd == null || qd.MaQuyDoi == 0)
                {
                    XtraMessageBox.Show("Vui lòng lưu trước khi thêm hệ số chức danh - chuyên môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (frmHeSoChucDanhKhoiLuongKhac frm = new frmHeSoChucDanhKhoiLuongKhac(qd.MaQuyDoi, qd.TenQuyDoi))
                    {
                        frm.ShowDialog();
                    }
                }
            }
        }

    }
}
