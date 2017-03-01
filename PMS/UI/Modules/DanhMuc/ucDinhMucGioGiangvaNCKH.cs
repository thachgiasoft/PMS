using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PMS.Services;
using DevExpress.Common.Grid;
using PMS.Entities;
using DevExpress.XtraEditors.Controls;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucDinhMucGioGiangvaNCKH : DevExpress.XtraEditors.XtraUserControl
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
        TList<CauHinhChung> _listCauHinhChung = DataServices.CauHinhChung.GetAll();
        string _maTruong;
        #endregion
        public ucDinhMucGioGiangvaNCKH()
        {
            InitializeComponent();
            _maTruong = _listCauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
        }

        private void ucDinhMucGioGiangvaNCKH_Load(object sender, EventArgs e)
        {
            #region Init Gridview
            switch (_maTruong)
            {
                case "VHU":
                    initGridVHU();
                    break;
                case "ACT":
                    InitACT();
                    break;
                case "UFM":
                    InitUFM();
                    break;
                default:
                    InitRemaining();
                    break;
            }
            #endregion

            #region HocHam
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocHam, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocHam, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" });
            repositoryItemGridLookUpEditHocHam.ValueMember = "MaHocHam";
            repositoryItemGridLookUpEditHocHam.DisplayMember = "TenHocHam";
            repositoryItemGridLookUpEditHocHam.NullText = string.Empty;
            #endregion

            #region HocVi
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocVi, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocVi, new string[] { "MaQuanLy", "TenHocVi" }, new string[] { "Mã học vị", "Tên học vị" });
            repositoryItemGridLookUpEditHocVi.DisplayMember = "TenHocVi";
            repositoryItemGridLookUpEditHocVi.ValueMember = "MaHocVi";
            repositoryItemGridLookUpEditHocVi.NullText = string.Empty;
            #endregion

            #region BacLuong
            repositoryItemCheckedComboBoxEditBacLuong.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditBacLuong.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditBacLuong.Items.Clear();
            TList<BacLuong> listBacLuong = DataServices.BacLuong.GetAll();
            List<CheckedListBoxItem> list = new List<CheckedListBoxItem>();
            foreach (BacLuong bl in listBacLuong)
                list.Add(new CheckedListBoxItem(bl.MaBacLuong, bl.TenBacLuong, CheckState.Unchecked, true));
            repositoryItemCheckedComboBoxEditBacLuong.Items.AddRange(list.ToArray());
            repositoryItemCheckedComboBoxEditBacLuong.SeparatorChar = ';';
            
            #endregion

            InitData();
        }
        #region InitGridView
        void initGridVHU()
        {
            AppGridView.InitGridView(gridViewDinhMucGioGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDinhMucGioGiang, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDinhMucGioGiang, new string[] { "Stt", "MaHocHam", "MaBacLuong", "DinhMucMonHoc", "DinhMucNckh", "DinhMucHoatDongChuyenMonKhac", "TongDinhMuc","NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "STT", "Học hàm", "Bậc lương", "Định mức giảng dạy", "Định mức NCKH", "Định mức các HĐ khác", "Tổng định mức", "Ngày cập nhật", "Người cập nhật" },
                                                           new int[] { 60, 120, 80, 120, 120, 150,150, 99, 99 });
            AppGridView.AlignHeader(gridViewDinhMucGioGiang, new string[] { "Stt", "MaHocHam", "MaBacLuong", "DinhMucMonHoc", "DinhMucNckh", "DinhMucHoatDongChuyenMonKhac", "TongDinhMuc", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            //AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucMonHoc", repositoryItemSpinEditDinhMucMonHoc);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucNckh", repositoryItemSpinEditDinhMucNCKH);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaBacLuong", repositoryItemCheckedComboBoxEditBacLuong);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucHoatDongChuyenMonKhac", repositoryItemSpinEditDinhMucHDKhac);
            AppGridView.HideField(gridViewDinhMucGioGiang, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }

        void InitACT()
        {
            AppGridView.InitGridView(gridViewDinhMucGioGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDinhMucGioGiang, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDinhMucGioGiang, new string[] { "Stt", "MaHocHam", "MaHocVi", "DinhMucMonHoc", "DinhMucMonGdtcQp", "DinhMucHoatDongChuyenMonKhac", "NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "STT", "Học hàm", "Học vị", "Định mức giảng dạy", "Định mức môn GDTC/QP", "Định mức các HĐ khác", "Ngày cập nhật", "Người cập nhật" },
                                                           new int[] { 60, 120, 120, 120, 150, 150, 99, 99 });
            AppGridView.AlignHeader(gridViewDinhMucGioGiang, new string[] { "Stt", "MaHocHam", "MaHocVi", "DinhMucMonHoc", "DinhMucMonGdtcQp", "DinhMucHoatDongChuyenMonKhac", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucMonHoc", repositoryItemSpinEditDinhMucMonHoc);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucMonGdtcQp", repositoryItemSpinEditDinhMucMonGDTCQP);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucHoatDongChuyenMonKhac", repositoryItemSpinEditDinhMucHDKhac);
            AppGridView.HideField(gridViewDinhMucGioGiang, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }

        void InitUFM()
        {
            AppGridView.InitGridView(gridViewDinhMucGioGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDinhMucGioGiang, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDinhMucGioGiang, new string[] { "Stt", "MaHocHam", "DinhMucMonHoc", "DinhMucMonGdtcQp", "DinhMucNckh", "NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "STT", "Học hàm", "Định mức giảng dạy", "Định mức môn GDTC/QP", "Định mức NCKH", "Ngày cập nhật", "Người cập nhật" },
                                                           new int[] { 60, 120, 120, 150, 120, 150, 99, 99 });
            AppGridView.AlignHeader(gridViewDinhMucGioGiang, new string[] { "Stt", "MaHocHam", "DinhMucMonHoc", "DinhMucMonGdtcQp", "DinhMucNckh", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucMonHoc", repositoryItemSpinEditDinhMucMonHoc);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucMonGdtcQp", repositoryItemSpinEditDinhMucMonGDTCQP);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucNckh", repositoryItemSpinEditDinhMucNCKH);
            AppGridView.HideField(gridViewDinhMucGioGiang, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewDinhMucGioGiang, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewDinhMucGioGiang, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewDinhMucGioGiang, new string[] { "Stt", "MaHocHam", "MaHocVi", "DinhMucMonHoc", "DinhMucMonGdtcQp", "DinhMucNckh", "NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "STT", "Học hàm", "Học vị", "Định mức giảng dạy", "Định mức môn GDTC/QP", "Định mức NCKH", "Ngày cập nhật", "Người cập nhật" },
                                                           new int[] { 60, 120, 120, 120, 150, 120, 150, 99, 99 });
            AppGridView.AlignHeader(gridViewDinhMucGioGiang, new string[] { "Stt", "MaHocHam", "MaHocVi", "DinhMucMonHoc", "DinhMucMonGdtcQp", "DinhMucNckh", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);

            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "MaHocVi", repositoryItemGridLookUpEditHocVi);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucMonHoc", repositoryItemSpinEditDinhMucMonHoc);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucMonGdtcQp", repositoryItemSpinEditDinhMucMonGDTCQP);
            AppGridView.RegisterControlField(gridViewDinhMucGioGiang, "DinhMucNckh", repositoryItemSpinEditDinhMucNCKH);
            AppGridView.HideField(gridViewDinhMucGioGiang, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }
        #endregion
        #region InitData
        void InitData()
        {
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            bindingSourceHocVi.DataSource = DataServices.HocVi.GetAll();
            bindingSourceDinhMucGioGiang.DataSource = DataServices.DinhMucGioChuan.GetAll();
        }
        #endregion

        #region Event button
        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDinhMucGioGiang);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewDinhMucGioGiang.FocusedRowHandle = -1;
            TList<DinhMucGioChuan> list = bindingSourceDinhMucGioGiang.DataSource as TList<DinhMucGioChuan>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            bindingSourceDinhMucGioGiang.EndEdit();
                            DataServices.DinhMucGioChuan.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            InitData();
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void gridViewDinhMucGioGiang_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewDinhMucGioGiang, e);
        }

        private void gridViewDinhMucGioGiang_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridColumn col = e.Column;
            if (col.FieldName == "MaHocHam" || col.FieldName == "MaHocVi" || col.FieldName == "MaBacLuong" || col.FieldName == "DinhMucMonHoc" || col.FieldName == "DinhMucMonGdtcQp" || col.FieldName == "DinhMucNckh" || col.FieldName == "DinhMucHoatDongChuyenMonKhac")
            {
                gridViewDinhMucGioGiang.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                gridViewDinhMucGioGiang.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
            }
        }
    }
}
