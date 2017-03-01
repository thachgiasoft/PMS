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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucQuyDinhTienCanTren : DevExpress.XtraEditors.XtraUserControl
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
        TList<LoaiNhanVien> _loaiNhanVien = DataServices.LoaiNhanVien.GetAll();
        string _maTruong, _cauHinhHeSoTheoNam;
        int _maLoaiNhanVienQL, _maLoaiNhanVienGD;
        VList<ViewHocKy> _listHocKy;
        #endregion

        public ucQuyDinhTienCanTren()
        {
            InitializeComponent();
            try
            {
                _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
                _maLoaiNhanVienQL = _loaiNhanVien.Find(p => p.MaQuanLy == "CBQL").MaLoaiNhanVien;
                _maLoaiNhanVienGD = _loaiNhanVien.Find(p => p.MaQuanLy == "CBGD").MaLoaiNhanVien;
                _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
            }
            catch
            {
                XtraMessageBox.Show("Lỗi khi khởi tạo các giá trị!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ucQuyDinhTienCanTrenTheoNam_Load(object sender, EventArgs e)
        {
            #region InitGridView
            switch (_maTruong)
            {
                default:    //UTE
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

            #region HocHam
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocHam, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocHam, new string[] { "MaHocHam", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" }, new int[] { 80, 120 });
            repositoryItemGridLookUpEditHocHam.DisplayMember = "TenHocHam";
            repositoryItemGridLookUpEditHocHam.ValueMember = "MaHocHam";
            repositoryItemGridLookUpEditHocHam.NullText = string.Empty;
            #endregion

            #region HocVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocVi, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocVi, new string[] { "MaHocVi", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" }, new int[] { 80, 120 });
            repositoryItemGridLookUpEditHocVi.DisplayMember = "TenHocVi";
            repositoryItemGridLookUpEditHocVi.ValueMember = "MaHocVi";
            repositoryItemGridLookUpEditHocVi.NullText = string.Empty;
            #endregion

            #region LoaiNhanVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLoaiNhanVien, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLoaiNhanVien, new string[] { "MaLoaiNhanVien", "TenLoaiNhanVien" }, new string[] { "Mã loại", "Tên loại" }, new int[] { 80, 120 });
            repositoryItemGridLookUpEditLoaiNhanVien.DisplayMember = "TenLoaiNhanVien";
            repositoryItemGridLookUpEditLoaiNhanVien.ValueMember = "MaLoaiNhanVien";
            repositoryItemGridLookUpEditLoaiNhanVien.NullText = string.Empty;
            #endregion

            #region LoaiGiangVien
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditLoaiGiangVien, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditLoaiGiangVien, new string[] { "MaLoaiGiangVien", "TenLoaiGiangVien" }, new string[] { "Mã loại", "Tên loại" }, new int[] { 80, 120 });
            repositoryItemGridLookUpEditLoaiGiangVien.DisplayMember = "TenLoaiGiangVien";
            repositoryItemGridLookUpEditLoaiGiangVien.ValueMember = "MaLoaiGiangVien";
            repositoryItemGridLookUpEditLoaiGiangVien.NullText = string.Empty;
            #endregion

            InitData();
        }

        #region Init GridView
        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewQuyDinhTienCanTren, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewQuyDinhTienCanTren, new string[] { "Id", "Stt", "MaHocHam", "MaHocVi", "MaLoaiNhanVien", "MaLoaiGiangVien", "TienCanTren" },
                        new string[] { "ID", "STT", "Học hàm", "Học vị", "Loại nhân viên", "Loại giảng viên", "Tiền cận trên" },
                        new int[] { 50, 40, 120, 120, 120, 120, 100 });
            AppGridView.ShowEditor(gridViewQuyDinhTienCanTren, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewQuyDinhTienCanTren, new string[] { "Id", "Stt", "MaHocHam", "MaHocVi", "MaLoaiNhanVien", "MaLoaiGiangVien", "TienCanTren" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewQuyDinhTienCanTren, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewQuyDinhTienCanTren, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewQuyDinhTienCanTren, "MaLoaiNhanVien", repositoryItemGridLookUpEditLoaiNhanVien);
            AppGridView.RegisterControlField(gridViewQuyDinhTienCanTren, "MaLoaiGiangVien", repositoryItemGridLookUpEditLoaiGiangVien);
            AppGridView.FormatDataField(gridViewQuyDinhTienCanTren, "TienCanTren", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.HideField(gridViewQuyDinhTienCanTren, new string[] { "Id" });
            
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }
        #endregion

        #region InitData
        private void InitData()
        {
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            
            if (cboNamHoc.EditValue != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
                if (cboHocKy.EditValue != null || _cauHinhHeSoTheoNam.ToLower() == "true")
                {
                    bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
                    bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();
                    bindingSourceLoaiNhanVien.DataSource = DataServices.LoaiNhanVien.GetAll();
                    bindingSourceLoaiGiangVien.DataSource = DataServices.LoaiGiangVien.GetAll();
                    bindingSourceQuyDinhTienCanTren.DataSource = DataServices.QuyDinhTienCanTren.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
                }
            }
        }
        #endregion

        private void btnLamtuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewQuyDinhTienCanTren);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewQuyDinhTienCanTren.FocusedRowHandle = -1;
            TList<QuyDinhTienCanTren> list = bindingSourceQuyDinhTienCanTren.DataSource as TList<QuyDinhTienCanTren>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (QuyDinhTienCanTren qd in list)
                            {
                                qd.NamHoc = cboNamHoc.EditValue.ToString();
                                if (_cauHinhHeSoTheoNam.ToLower() == "true")
                                    qd.HocKy = "";
                                else
                                    qd.HocKy = cboHocKy.EditValue.ToString();
                            }
                            bindingSourceQuyDinhTienCanTren.EndEdit();
                            DataServices.QuyDinhTienCanTren.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            XtraMessageBox.Show(string.Format("Có {0} dòng chứa dữ liệu không hợp lệ.", list.InvalidItems.Count), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gridViewQuyDinhTienCanTren_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewQuyDinhTienCanTren, e);
        }

        private void gridViewQuyDinhTienCanTren_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewQuyDinhTienCanTren, e);
        }

        private void gridViewQuyDinhTienCanTren_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (SaveFileDialog sf = new SaveFileDialog { Filter = "(*.xls)|*.xls" })
                {
                    sf.ShowDialog();
                    if (sf.FileName != "")
                    {
                        gridControlQuyDinhTienCanTren.ExportToXls(sf.FileName);
                        XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            { }
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && (cboHocKy.EditValue != null || _cauHinhHeSoTheoNam.ToLower() == "true"))
            {
                bindingSourceQuyDinhTienCanTren.DataSource = DataServices.QuyDinhTienCanTren.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && (cboHocKy.EditValue != null || _cauHinhHeSoTheoNam.ToLower() == "true"))
            {
                bindingSourceQuyDinhTienCanTren.DataSource = DataServices.QuyDinhTienCanTren.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void gridViewQuyDinhTienCanTren_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaQuanLy" || col.FieldName == "MaBacDaoTao" || col.FieldName == "MaNhomMonHoc" || col.FieldName == "TuKhoan" || col.FieldName == "DenKhoan" || col.FieldName == "HeSo" || col.FieldName == "NgayBdApDung" || col.FieldName == "NgayKtApDung")
            {
                gridViewQuyDinhTienCanTren.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString());
                gridViewQuyDinhTienCanTren.SetRowCellValue(e.RowHandle, "NguoiCapNhat", Libraries.Entities.UserInfo.UserName);
            }
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (PMS.UI.Forms.NghiepVu.frmSaoChepNamHoc frm = new PMS.UI.Forms.NghiepVu.frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepTienCanTren"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (PMS.UI.Forms.NghiepVu.frmSaoChepNamHocHocKy frm = new PMS.UI.Forms.NghiepVu.frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepTienCanTren"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }

        private bool RuleCheckDuplicate(object target, PMS.Entities.Validation.ValidationRuleArgs e)
        {
            QuyDinhTienCanTren obj = target as QuyDinhTienCanTren;
            if (obj != null)
            {
                if (((TList<QuyDinhTienCanTren>)bindingSourceQuyDinhTienCanTren.DataSource).FindAll(p => p.MaHocHam == obj.MaHocHam && p.MaHocVi == obj.MaHocVi && p.MaLoaiNhanVien == obj.MaLoaiNhanVien && p.MaLoaiGiangVien == obj.MaLoaiGiangVien).Count > 1)
                {
                    e.Description = string.Format("Dòng dữ liệu hiện tại đã có!");
                    return false;
                }
                else if (obj.MaLoaiNhanVien == _maLoaiNhanVienGD && obj.MaLoaiGiangVien == null)
                {
                    e.Description = string.Format("Đã chọn cán bộ giảng dạy thì phải chọn loại giảng viên!");
                    return false;
                }
            }
            return true;
        } 

        private void gridViewQuyDinhTienCanTren_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            QuyDinhTienCanTren obj = e.Row as QuyDinhTienCanTren;
            if (obj != null)
            {
                obj.AddValidationRuleHandler(RuleCheckDuplicate, "MaQuanLy");
                if (obj.IsValid)
                {
                    if (obj.MaLoaiNhanVien == _maLoaiNhanVienQL) obj.MaLoaiGiangVien = null;
                    e.Valid = true;
                }
                else
                {
                    XtraMessageBox.Show(obj.Error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Valid = false;
                }
            }
        }

        private void gridViewQuyDinhTienCanTren_InvalidRowException_1(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
    }
}
