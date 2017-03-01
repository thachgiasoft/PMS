using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Common.Grid;
using PMS.Services;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using DevExpress.XtraEditors;
using PMS.Core;
using PMS.Entities.Validation;
using PMS.Services;
using DevExpress.XtraGrid.Columns;
using PMS.BLL;
using PMS.UI.Forms.NghiepVu;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucHeSoBacDaoTaoTheoNam : DevExpress.XtraEditors.XtraUserControl
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
        VList<ViewBacDaoTao> _listBacDaoTao = new VList<ViewBacDaoTao>();
        #endregion

        public ucHeSoBacDaoTaoTheoNam()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucHeSoBacDaoTaoTheoNam_Load(object sender, EventArgs e)
        {
            #region InitGridview
            switch (_maTruong)
            { 
                case "LAW":
                    InitGridLAW();
                    break;
                case "HBU":
                    InitGridHBU();
                    break;
                default:
                    InitRemaining();
                    break;
            }

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
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

            #region BacDaoTao
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditBacDaoTao, 300, 500);
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditBacDaoTao, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditBacDaoTao, new string[] { "MaBacDaoTao", "TenBacDaoTao" }, new string[] { "Mã bậc đào tạo", "Tên bậc đào tạo" }, new int[] { 100, 200 });
            repositoryItemGridLookUpEditBacDaoTao.DisplayMember = "MaBacDaoTao";
            repositoryItemGridLookUpEditBacDaoTao.ValueMember = "MaBacDaoTao";
            repositoryItemGridLookUpEditBacDaoTao.NullText = string.Empty;
            #endregion

            #region LoaiLop
           
            #endregion

            InitData();
        }

        #region InitGrid
        void InitGridLAW()
        {
            AppGridView.InitGridView(gridViewHeSoBacDaoTao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoBacDaoTao, new string[] { "Stt", "MaQuanLy", "TenBacDaoTao", "LoaiLop", "HeSo" },
                        new string[] { "STT", "Mã bậc đào tạo", "Tên bậc đào tạo", "Loại lớp", "Hệ số" },
                        new int[] { 70, 90, 200, 180, 100 });
            AppGridView.AlignHeader(gridViewHeSoBacDaoTao, new string[] { "Stt", "MaQuanLy", "TenBacDaoTao", "LoaiLop", "HeSo" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ShowEditor(gridViewHeSoBacDaoTao, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewHeSoBacDaoTao, "MaQuanLy", repositoryItemGridLookUpEditBacDaoTao);
            AppGridView.RegisterControlField(gridViewHeSoBacDaoTao, "LoaiLop", repositoryItemCheckedComboBoxEditLoaiLop);
            AppGridView.ReadOnlyColumn(gridViewHeSoBacDaoTao, new string[] { "TenBacDaoTao" });
        }


        void InitGridHBU()
        {
            AppGridView.InitGridView(gridViewHeSoBacDaoTao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoBacDaoTao, new string[] { "Stt", "MaQuanLy", "TenBacDaoTao", "HeSo", "TinhVaoGioChuan", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "STT", "Mã bậc đào tạo", "Tên bậc đào tạo", "Hệ số", "Tính vào giờ chuẩn", "Ngày cập nhật", "Người cập nhật" },
                        new int[] { 50, 100, 150, 200, 150, 100, 100 });
            AppGridView.AlignHeader(gridViewHeSoBacDaoTao, new string[] { "Stt", "MaQuanLy", "TenBacDaoTao", "HeSo", "TinhVaoGioChuan", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ShowEditor(gridViewHeSoBacDaoTao, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewHeSoBacDaoTao, "MaQuanLy", repositoryItemGridLookUpEditBacDaoTao);
            AppGridView.ReadOnlyColumn(gridViewHeSoBacDaoTao, new string[] { "TenBacDaoTao" });
            AppGridView.HideField(gridViewHeSoBacDaoTao, new string[] { "NgayCapNhat", "NguoiCapNhat" });
            AppGridView.SummaryField(gridViewHeSoBacDaoTao, "TinhVaoGioChuan", "n0", DevExpress.Data.SummaryItemType.Count);
        }

        void InitRemaining() 
        {
            AppGridView.InitGridView(gridViewHeSoBacDaoTao, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowField(gridViewHeSoBacDaoTao, new string[] { "Stt", "MaQuanLy", "TenBacDaoTao", "HeSo", "NgayCapNhat", "NguoiCapNhat" },
                        new string[] { "STT", "Mã bậc đào tạo", "Tên bậc đào tạo", "Hệ số", "Ngày cập nhật", "Người cập nhật" },
                        new int[] { 50, 100, 150, 200, 100, 100 });
            AppGridView.AlignHeader(gridViewHeSoBacDaoTao, new string[] { "Stt", "MaQuanLy", "TenBacDaoTao", "HeSo", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.ShowEditor(gridViewHeSoBacDaoTao, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.RegisterControlField(gridViewHeSoBacDaoTao, "MaQuanLy", repositoryItemGridLookUpEditBacDaoTao);
            AppGridView.ReadOnlyColumn(gridViewHeSoBacDaoTao, new string[] { "TenBacDaoTao" });
            AppGridView.HideField(gridViewHeSoBacDaoTao, new string[] { "NgayCapNhat", "NguoiCapNhat" });
        }
        #endregion

        #region InitData
        private void InitData()
        {
            _listBacDaoTao = DataServices.ViewBacDaoTao.GetAll();
            bindingSourceBacDaoTao.DataSource = _listBacDaoTao;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();

            InitLoaiLop();

            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && (cboHocKy.EditValue != null || _cauHinhHeSoTheoNam.ToLower() == "true"))
            {
                bindingSourceHeSoBacDaoTao.DataSource = DataServices.HeSoBacDaoTao.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        void InitLoaiLop()
        {
            repositoryItemCheckedComboBoxEditLoaiLop.SelectAllItemCaption = "Tất cả";
            repositoryItemCheckedComboBoxEditLoaiLop.TextEditStyle = TextEditStyles.Standard;
            repositoryItemCheckedComboBoxEditLoaiLop.Items.Clear();

            TList<LoaiLop> _vListLoaiLop = new TList<LoaiLop>();
            _vListLoaiLop = DataServices.LoaiLop.GetAll();

            List<CheckedListBoxItem> _list = new List<CheckedListBoxItem>();
            foreach (LoaiLop v in _vListLoaiLop)
            {
                _list.Add(new CheckedListBoxItem(v.Id, v.TenLoaiLop, CheckState.Unchecked, true));
            }
            repositoryItemCheckedComboBoxEditLoaiLop.Items.AddRange(_list.ToArray());
            repositoryItemCheckedComboBoxEditLoaiLop.SeparatorChar = ';';
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
            AppGridView.DeleteSelectedRows(gridViewHeSoBacDaoTao);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridViewHeSoBacDaoTao.FocusedRowHandle = -1;
            TList<HeSoBacDaoTao> list = bindingSourceHeSoBacDaoTao.DataSource as TList<HeSoBacDaoTao>;
            if (list != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (HeSoBacDaoTao h in list)
                            {
                                h.NamHoc = cboNamHoc.EditValue.ToString();
                                if (_cauHinhHeSoTheoNam.ToLower() == "true")
                                    h.HocKy = "";
                                else
                                    h.HocKy = cboHocKy.EditValue.ToString();
                            }
                            bindingSourceHeSoBacDaoTao.EndEdit();
                            DataServices.HeSoBacDaoTao.Save(list);
                            
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

        private void gridViewHeSoBacDaoTao_KeyUp(object sender, KeyEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewHeSoBacDaoTao, e);
        }

        private void gridViewHeSoBacDaoTao_KeyDown(object sender, KeyEventArgs e)
        {
            AppGridView.CopyCell(gridViewHeSoBacDaoTao, e);
        }

        private void gridViewHeSoBacDaoTao_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gridViewHeSoBacDaoTao_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                GridColumn col = e.Column;
                if (col.FieldName == "MaQuanLy")
                {
                    HeSoBacDaoTao h = gridViewHeSoBacDaoTao.GetRow(e.RowHandle) as HeSoBacDaoTao;
                    string _tenBacDaoTao = _listBacDaoTao.Find(p => p.MaBacDaoTao == h.MaQuanLy).TenBacDaoTao;
                    gridViewHeSoBacDaoTao.SetRowCellValue(e.RowHandle, "TenBacDaoTao", _tenBacDaoTao);
                }

                if (col.FieldName == "Stt" || col.FieldName == "MaQuanLy" || col.FieldName == "HeSo")
                {
                    gridViewHeSoBacDaoTao.SetRowCellValue(e.RowHandle, "NgayCapNhat", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    gridViewHeSoBacDaoTao.SetRowCellValue(e.RowHandle, "NguoiCapNhat", UserInfo.UserName);
                }
            }
            catch 
            { }
        }

        private void cboNamHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && (cboHocKy.EditValue != null || _cauHinhHeSoTheoNam.ToLower() == "true"))
            {
                bindingSourceHeSoBacDaoTao.DataSource = DataServices.HeSoBacDaoTao.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && (cboHocKy.EditValue != null || _cauHinhHeSoTheoNam.ToLower() == "true"))
            {
                bindingSourceHeSoBacDaoTao.DataSource = DataServices.HeSoBacDaoTao.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            }
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepHeSoBacDaoTao"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepHeSoBacDaoTao"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }
    }
}
