using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using PMS.Entities;
using PMS.Core;
using PMS.Entities.Validation;
using DevExpress.XtraGrid.Views.Base;
using PMS.Services;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoChucDanhTietNghiaVu : DevExpress.XtraEditors.XtraUserControl
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
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                btnXoa.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhChung> _cauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion
        public ucHeSoChucDanhTietNghiaVu()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucHeSoChucDanhTietNghiaVu_Load(object sender, EventArgs e)
        {
            #region Init GridView QuyDoiGioChuan
            AppGridView.InitGridView(gridViewHeSoChucDanhTNV, true, true, GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoChucDanhTNV, new string[] { "Stt", "MaQuanLy", "MaHocHam", "MaHocVi", "GiangDaySauDaiHoc", "HeSo", "SoTietNghiaVu", "HeSoLuongTangThem", "NgayBdApDung", "NgayKtApDung", "SoTietNghiaVuMonGdtc" },
                new string[] { "STT", "Mã hệ số", "Học hàm", "Học vị", "Tham gia giảng dạy SDH", "Hệ số", "Số tiết nghĩa vụ/Năm", "Hệ số lương tăng thêm", "Ngày bắt đầu áp dụng", "Ngày kết thúc áp dụng", "Môn GDTC" },
                new int[] { 70, 70, 150, 150, 150, 80, 150, 150, 150, 150, 120 });
            AppGridView.ShowEditor(gridViewHeSoChucDanhTNV, NewItemRowPosition.Top);
            AppGridView.AlignHeader(gridViewHeSoChucDanhTNV, new string[] { "Stt", "MaQuanLy", "MaHocHam", "MaHocVi", "GiangDaySauDaiHoc", "HeSo", "SoTietNghiaVu", "HeSoLuongTangThem", "NgayBdApDung", "NgayKtApDung", "SoTietNghiaVuMonGdtc" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewHeSoChucDanhTNV, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewHeSoChucDanhTNV, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewHeSoChucDanhTNV, "HeSo", repositoryItemSpinEditHeSo);
            AppGridView.RegisterControlField(gridViewHeSoChucDanhTNV, "SoTietNghiaVu", repositoryItemSpinEditTietNghiaVu);
            AppGridView.RegisterControlField(gridViewHeSoChucDanhTNV, "HeSoLuongTangThem", repositoryItemSpinEditHeSoLuongTangThem);

            if (_maTruong != "LAW")
                AppGridView.HideField(gridViewHeSoChucDanhTNV, new string[] { "NgayBdApDung", "NgayKtApDung" });
            if (_maTruong == "UTE" || _maTruong == "USSH")
                AppGridView.HideField(gridViewHeSoChucDanhTNV, new string[] { "HeSo", "HeSoLuongTangThem" });
            if (_maTruong != "USSH")
                AppGridView.HideField(gridViewHeSoChucDanhTNV, new string[] { "GiangDaySauDaiHoc", "SoTietNghiaVuMonGdtc" });
            if (_maTruong == "UEL")
                AppGridView.HideField(gridViewHeSoChucDanhTNV, new string[] { "Stt", "HeSo", "HeSoLuongTangThem" });

            #endregion

            #region HocHam
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocHam, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocHam, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" });
            repositoryItemGridLookUpEditHocHam.DisplayMember = "TenHocHam";
            repositoryItemGridLookUpEditHocHam.ValueMember = "MaHocHam";
            repositoryItemGridLookUpEditHocHam.NullText = string.Empty;
            #endregion
            #region HocVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocVi, true, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocVi, new string[] { "MaQuanLy", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" });
            repositoryItemGridLookUpEditHocVi.DisplayMember = "TenHocVi";
            repositoryItemGridLookUpEditHocVi.ValueMember = "MaHocVi";
            repositoryItemGridLookUpEditHocVi.NullText = string.Empty;
            #endregion
            InitData();
        }
        #region InitData
        private void InitData()
        {
            #region Init Datasource
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();
            bindingSourceHeSoChucDanhTNV.DataSource = DataServices.HeSoChucDanhTietNghiaVu.GetAll();
            
            #endregion
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
            AppGridView.DeleteSelectedRows(gridViewHeSoChucDanhTNV);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoChucDanhTNV.FocusedRowHandle = -1;
            TList<HeSoChucDanhTietNghiaVu> list = bindingSourceHeSoChucDanhTNV.DataSource as TList<HeSoChucDanhTietNghiaVu>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceHeSoChucDanhTNV.EndEdit();
                            DataServices.HeSoChucDanhTietNghiaVu.Save(list);
                            PMS.Common.Globals.SaveLayout(Tag as AppModule, new object[] { gridViewHeSoChucDanhTNV, barManager1, layoutControl1 });
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


        private bool RuleCheckDuplicate(object target, ValidationRuleArgs e)
        {
            HeSoChucDanhTietNghiaVu obj = target as HeSoChucDanhTietNghiaVu;
            if (obj != null)
            {
                if (((TList<HeSoChucDanhTietNghiaVu>)bindingSourceHeSoChucDanhTNV.DataSource).FindAll(p => p.MaQuanLy == obj.MaQuanLy).Count > 1)
                {
                    e.Description = string.Format("Mã hệ số {0} hiện tại đã có.", obj.MaQuanLy);
                    return false;
                }
            }
            return true;
        }

        private void gridViewHeSoChucDanhTNV_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoChucDanhTNV, e);
        }

        private void gridViewHeSoChucDanhTNV_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHeSoChucDanhTNV, e);
        }

        private void gridViewHeSoChucDanhTNV_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            HeSoChucDanhTietNghiaVu obj = e.Row as HeSoChucDanhTietNghiaVu;
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

        private void gridViewHeSoChucDanhTNV_InvalidRowException(object sender, InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
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
                    gridControlHeSoChucDanhTNV.ExportToXls(sf.FileName);
                    XtraMessageBox.Show("Xuất file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            { }
        }

    }
}
