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
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;


namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoThanhToanGioChuanVuotMuc : DevExpress.XtraEditors.XtraUserControl
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

        public ucHeSoThanhToanGioChuanVuotMuc()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucHeSoThanhToanGioChuanVuotMuc_Load(object sender, EventArgs e)
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

            #region HocHam
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditHocHam, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditHocHam, new string[] { "MaQuanLy", "TenHocHam" }, new string[] { "Mã học hàm", "Tên học hàm" });
            repositoryItemGridLookUpEditHocHam.ValueMember = "MaHocHam";
            repositoryItemGridLookUpEditHocHam.DisplayMember = "TenHocHam";
            repositoryItemGridLookUpEditHocHam.NullText = string.Empty;
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

            //#region HocHam
            //repositoryItemCheckedComboBoxEditHocHam.SelectAllItemCaption = "Tất cả";
            //repositoryItemCheckedComboBoxEditHocHam.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            //repositoryItemCheckedComboBoxEditHocHam.Items.Clear();
            //TList<HocHam> listHocHam = DataServices.HocHam.GetAll();
            //List<CheckedListBoxItem> listHH = new List<CheckedListBoxItem>();
            //foreach (HocHam hh in listHocHam)
            //    listHH.Add(new CheckedListBoxItem(hh.MaHocHam, hh.TenHocHam, CheckState.Unchecked, true));
            //repositoryItemCheckedComboBoxEditHocHam.Items.AddRange(listHH.ToArray());
            //repositoryItemCheckedComboBoxEditHocHam.SeparatorChar = ';';
            //#endregion

            InitData();
        }


        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewHeSoThanhToan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewHeSoThanhToan, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewHeSoThanhToan, new string[] { "Stt", "MaHocHam", "MaBacLuong", "HeSoThanhToan", "NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "STT", "Học hàm", "Bậc lương", "Hệ số thanh toán", "Ngày cập nhật", "Người cập nhật" },
                                                           new int[] { 60, 120, 80, 120, 120, 150 });
            AppGridView.AlignHeader(gridViewHeSoThanhToan, new string[] { "Stt", "MaHocHam", "MaBacLuong", "HeSoThanhToan", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSoThanhToan, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewHeSoThanhToan, "MaBacLuong", repositoryItemCheckedComboBoxEditBacLuong);
            AppGridView.HideField(gridViewHeSoThanhToan, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }
        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewHeSoThanhToan, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewHeSoThanhToan, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewHeSoThanhToan, new string[] { "Stt", "MaHocHam", "MaBacLuong", "HeSoThanhToan", "NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "STT", "Học hàm", "Bậc lương", "Hệ số thanh toán", "Ngày cập nhật", "Người cập nhật" },
                                                           new int[] { 60, 120, 80, 120, 120, 150 });
            AppGridView.AlignHeader(gridViewHeSoThanhToan, new string[] { "Stt", "MaHocHam", "MaBacLuong", "HeSoThanhToan", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.RegisterControlField(gridViewHeSoThanhToan, "MaHocHam", repositoryItemGridLookUpEditHocHam);
            AppGridView.RegisterControlField(gridViewHeSoThanhToan, "MaBacLuong", repositoryItemCheckedComboBoxEditBacLuong);
            AppGridView.HideField(gridViewHeSoThanhToan, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }


        void InitData()
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceHocHam.DataSource = DataServices.HocHam.GetAll();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoThanhToan.DataSource = DataServices.HeSoThanhToanGioChuanVuotMuc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            InitData();
            Cursor.Current = Cursors.Default;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoThanhToan);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewHeSoThanhToan.FocusedRowHandle = -1;
            TList<HeSoThanhToanGioChuanVuotMuc> list = bindingSourceHeSoThanhToan.DataSource as TList<HeSoThanhToanGioChuanVuotMuc>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (HeSoThanhToanGioChuanVuotMuc d in list)
                            {
                                d.NamHoc = cboNamHoc.EditValue.ToString();
                                d.HocKy = cboHocKy.EditValue.ToString();
                            }
                            bindingSourceHeSoThanhToan.EndEdit();
                            DataServices.HeSoThanhToanGioChuanVuotMuc.Save(list);
                            XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoThanhToan.DataSource = DataServices.HeSoThanhToanGioChuanVuotMuc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceHeSoThanhToan.DataSource = DataServices.HeSoThanhToanGioChuanVuotMuc.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepHeSoThanhToanGioChuanVuotMuc"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepHeSoThanhToanGioChuanVuotMuc"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }
        
    }
}
