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
    public partial class ucThuLaoGiangDayThucHanh : DevExpress.XtraEditors.XtraUserControl
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

        public ucThuLaoGiangDayThucHanh()
        {
            InitializeComponent();
            _maTruong = _cauHinhChung.Find(p => p.TenCauHinh == "Mã trường").GiaTri;
            _cauHinhHeSoTheoNam = _cauHinhChung.Find(p => p.TenCauHinh == "Cấu hình các hệ số tính giờ giảng theo năm").GiaTri;
        }

        private void ucThuLaoGiangDayThucHanh_Load(object sender, EventArgs e)
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
            
            //InitPhanLoaiLopHoc();
            //InitGhiChu();
            InitData();
        }

        void InitGridVHU()
        {
            AppGridView.InitGridView(gridViewThuLaoGiangDayThucHanh, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewThuLaoGiangDayThucHanh, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewThuLaoGiangDayThucHanh, new string[] { "Stt", "PhanLoaiLopHoc", "DinhMuc", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "STT", "Niên chế tín chỉ", "Định mức", "Ghi chú", "Ngày cập nhật", "Người cập nhật" },
                                                           new int[] { 60, 450, 80, 120, 120, 150 });
            AppGridView.AlignHeader(gridViewThuLaoGiangDayThucHanh, new string[] { "Stt", "PhanLoaiLopHoc", "DinhMuc", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.FormatDataField(gridViewThuLaoGiangDayThucHanh, "DinhMuc", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewThuLaoGiangDayThucHanh, "PhanLoaiLopHoc", repositoryItemGridLookUpEditNienCheTinChi);
            AppGridView.RegisterControlField(gridViewThuLaoGiangDayThucHanh, "GhiChu", repositoryItemGridLookUpEditGhiChu);
            AppGridView.HideField(gridViewThuLaoGiangDayThucHanh, new string[] { "NgayCapNhat", "NguoiCapNhat" });

            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                cboHocKy.EditValue = "";
            }

        }

        void InitRemaining()
        {
            AppGridView.InitGridView(gridViewThuLaoGiangDayThucHanh, true, true, DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect, false, false, "Nhấn vào đây để thêm dòng mới");
            AppGridView.ShowEditor(gridViewThuLaoGiangDayThucHanh, DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top);
            AppGridView.ShowField(gridViewThuLaoGiangDayThucHanh, new string[] { "Stt", "PhanLoaiLopHoc", "DinhMuc", "GhiChu", "NgayCapNhat", "NguoiCapNhat" },
                                                           new string[] { "STT", "Niên chế tín chỉ", "Định mức", "Ghi chú", "Ngày cập nhật", "Người cập nhật" },
                                                           new int[] { 60, 450, 80, 120, 120, 150 });
            AppGridView.AlignHeader(gridViewThuLaoGiangDayThucHanh, new string[] { "Stt", "PhanLoaiLopHoc", "DinhMuc", "GhiChu", "NgayCapNhat", "NguoiCapNhat" }, DevExpress.Utils.HorzAlignment.Center);
            AppGridView.FormatDataField(gridViewThuLaoGiangDayThucHanh, "DinhMuc", DevExpress.Utils.FormatType.Custom, "n0");
            AppGridView.RegisterControlField(gridViewThuLaoGiangDayThucHanh, "PhanLoaiLopHoc", repositoryItemGridLookUpEditNienCheTinChi);
            AppGridView.RegisterControlField(gridViewThuLaoGiangDayThucHanh, "GhiChu", repositoryItemGridLookUpEditGhiChu);
            AppGridView.HideField(gridViewThuLaoGiangDayThucHanh, new string[] { "NgayCapNhat", "NguoiCapNhat" });

        }


        void InitPhanLoaiLopHoc()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(new DataColumn("PhanLoaiLopHoc"));
            tbl.Columns["PhanLoaiLopHoc"].Caption = "Phân loại lớp học";


            DataRow r0 = tbl.NewRow();
            r0["PhanLoaiLopHoc"] = "Đào tạo theo niên chế ";

            DataRow r1 = tbl.NewRow();
            r1["PhanLoaiLopHoc"] = "Đào tạo theo tín chỉ";


            tbl.Rows.Add(r0);
            tbl.Rows.Add(r1);

            bindingSourceNienCheTinChi.DataSource = tbl;

            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditNienCheTinChi, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditNienCheTinChi, 200, 400);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditNienCheTinChi, new string[] { "PhanLoaiLopHoc" }, new string[] { "Niên chế tín chỉ" }, new int[] { 210 });
            repositoryItemGridLookUpEditNienCheTinChi.DisplayMember = "PhanLoaiLopHoc";
            repositoryItemGridLookUpEditNienCheTinChi.ValueMember = "PhanLoaiLopHoc";
            repositoryItemGridLookUpEditNienCheTinChi.NullText = "";

        }

        void InitGhiChu()
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add(new DataColumn("GhiChu"));
            tbl.Columns["GhiChu"].Caption = "Ghi chú";


            DataRow r0 = tbl.NewRow();
            r0["GhiChu"] = "Giảng chính";
          
            DataRow r1 = tbl.NewRow();
            r1["GhiChu"] = "Giảng phụ";
          

            tbl.Rows.Add(r0);
            tbl.Rows.Add(r1);
            
            bindingSourceGhiChu.DataSource = tbl;

            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditGhiChu, TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditGhiChu, 200, 400);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditGhiChu, new string[] { "GhiChu"}, new string[] { "Ghi Chú" }, new int[] { 210 });
            repositoryItemGridLookUpEditGhiChu.DisplayMember = "GhiChu";
            repositoryItemGridLookUpEditGhiChu.ValueMember = "GhiChu";
            repositoryItemGridLookUpEditGhiChu.NullText = "";

        }

        void InitData()
        {
            switch (_maTruong)
            {
                case "VHU":
                    {
                        InitPhanLoaiLopHoc();
                        InitGhiChu();
                    }
                    break;
                
            }
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            if (cboNamHoc.EditValue != null)
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(cboNamHoc.EditValue.ToString());
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceThuLaoGiangDayThucHanh.DataSource = DataServices.ThuLaoGiangDayThucHanh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
            Cursor.Current = Cursors.Default;
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InitData();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AppGridView.DeleteSelectedRows(gridViewThuLaoGiangDayThucHanh);
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            gridViewThuLaoGiangDayThucHanh.FocusedRowHandle = -1;
            TList<ThuLaoGiangDayThucHanh> list = bindingSourceThuLaoGiangDayThucHanh.DataSource as TList<ThuLaoGiangDayThucHanh>;
            if (list != null)
            {
                foreach(ThuLaoGiangDayThucHanh t in list)
                {
                    t.NgayCapNhat = DateTime.Now;
                    t.NguoiCapNhat = UserInfo.UserName;
                }
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (list.IsValid)
                        {
                            foreach (ThuLaoGiangDayThucHanh d in list)
                            {
                                d.NamHoc = cboNamHoc.EditValue.ToString();
                                d.HocKy = cboHocKy.EditValue.ToString();
                            }
                            bindingSourceThuLaoGiangDayThucHanh.EndEdit();
                            DataServices.ThuLaoGiangDayThucHanh.Save(list);
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
                bindingSourceThuLaoGiangDayThucHanh.DataSource = DataServices.ThuLaoGiangDayThucHanh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void cboHocKy_EditValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc.EditValue != null && cboHocKy.EditValue != null)
                bindingSourceThuLaoGiangDayThucHanh.DataSource = DataServices.ThuLaoGiangDayThucHanh.GetByNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString());
        }

        private void btnSaoChep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_cauHinhHeSoTheoNam.ToLower() == "true")
            {
                using (frmSaoChepNamHoc frm = new frmSaoChepNamHoc(cboNamHoc.EditValue.ToString(), "SaoChepThuLaoGiangDayThucHanh"))
                {
                    frm.ShowDialog();
                }
            }
            else
            {
                using (frmSaoChepNamHocHocKy frm = new frmSaoChepNamHocHocKy(cboNamHoc.EditValue.ToString(), cboHocKy.EditValue.ToString(), "SaoChepThuLaoGiangDayThucHanh"))
                {
                    frm.ShowDialog();
                }
            }
            InitData();
        }


    }
}
