using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;

namespace PMS.UI.Modules.DanhMuc
{
    public partial class ucCauHinhPhanHoi : DevExpress.XtraEditors.XtraUserControl
    {
        #region Phân quyền cập nhật
        public void KhongDuocPhepCapNhat(string value)
        {
            if (value.ToLower() == "true")
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                btnLuu.ShortCut = Shortcut.None;
            }
            else
            {
                btnLuu.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }
        #endregion

        #region Variable
        TList<CauHinhGiangVienPhanHoi> listCauHinhPhanHoi;
        #endregion
        public ucCauHinhPhanHoi()
        {
            InitializeComponent();
        }

        private void ucCauHinhPhanHoi_Load(object sender, EventArgs e)
        {
            #region AppRepositoryItemGridLookUpEdit _namHoc
            AppGridLookupEdit.InitGridLookUp(cboNamHoc, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHoc.Properties.ValueMember = "NamHoc";
            cboNamHoc.Properties.DisplayMember = "NamHoc";
            cboNamHoc.Properties.NullText = string.Empty;
            #endregion

            #region AppRepositoryItemGridLookUpEdit _hocKy
            AppGridLookupEdit.InitGridLookUp(cboHocKy, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKy, new string[] { "MaHocKy" }, new string[] { "Học kỳ" });
            cboHocKy.Properties.ValueMember = "MaHocKy";
            cboHocKy.Properties.DisplayMember = "MaHocKy";
            cboHocKy.Properties.NullText = string.Empty;
            #endregion
            LoadCauHinh();
        }

        #region LoadCauHinh
        private void LoadCauHinh()
        {
            listCauHinhPhanHoi = DataServices.CauHinhGiangVienPhanHoi.GetAll();
            CauHinhGiangVienPhanHoi cauHinh;
            try
            {
                cauHinh = listCauHinhPhanHoi.Find(p => p.MaCauHinh == "GhiChu");
                if (cauHinh != null)
                    txtGhiChu.EditValue = cauHinh.NoiDung;

                cauHinh = listCauHinhPhanHoi.Find(p => p.MaCauHinh == "NgayBatDau");
                if (cauHinh != null)
                    dateEditNgayBatDau.EditValue = cauHinh.NoiDung;

                cauHinh = listCauHinhPhanHoi.Find(p => p.MaCauHinh == "NgayKetThuc");
                if (cauHinh != null)
                    dateEditNgayKetThuc.EditValue = cauHinh.NoiDung;

                SetNamHoc();

                cauHinh = listCauHinhPhanHoi.Find(p => p.MaCauHinh == "NamHoc");
                if (cauHinh != null)
                    bindingSourceNamHoc.Position = bindingSourceNamHoc.Find("NamHoc", cauHinh.NoiDung);

                ViewNamHoc namHoc = bindingSourceNamHoc.Current as ViewNamHoc;
                if (namHoc != null)
                {
                    SetHocKy(namHoc.NamHoc);
                    cauHinh = listCauHinhPhanHoi.Find(p => p.MaCauHinh == "HocKy");
                    if (cauHinh != null)
                        bindingSourceHocKy.Position = bindingSourceHocKy.Find("MaHocKy", cauHinh.NoiDung);
                }

                cauHinh = listCauHinhPhanHoi.Find(p => p.MaCauHinh == "ChoPhepPhanHoi");
                if (cauHinh != null)
                    ckPhanHoi.Checked = bool.Parse(cauHinh.NoiDung);
            }
            catch
            {
                XtraMessageBox.Show("Lỗi lấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        #region SetNamHoc, _hocKy
        private void SetNamHoc()
        {
            cboNamHoc.DataBindings.Clear();
            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            cboNamHoc.DataBindings.Add("EditValue", bindingSourceNamHoc, "NamHoc", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void SetHocKy(string namHoc)
        {
            if (cboNamHoc.EditValue != null)
            {
                cboHocKy.DataBindings.Clear();
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(namHoc);
                cboHocKy.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }
        #endregion

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadCauHinh();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CauHinhGiangVienPhanHoi objCauHinh;
            try
            {
                objCauHinh = listCauHinhPhanHoi.Find(p => p.MaCauHinh == "GhiChu");
                if (objCauHinh != null)
                {
                    if (objCauHinh.NoiDung != txtGhiChu.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.NoiDung = txtGhiChu.Text;
                }

                objCauHinh = listCauHinhPhanHoi.Find(p => p.MaCauHinh == "NgayBatDau");
                if (objCauHinh != null)
                {
                    if (objCauHinh.NoiDung != dateEditNgayBatDau.DateTime.ToString("dd/MM/yyyy"))
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.NoiDung = dateEditNgayBatDau.DateTime.ToString("dd/MM/yyyy");
                }

                objCauHinh = listCauHinhPhanHoi.Find(p => p.MaCauHinh == "NgayKetThuc");
                if (objCauHinh != null)
                {
                    if (objCauHinh.NoiDung != dateEditNgayKetThuc.DateTime.ToString("dd/MM/yyyy"))
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.NoiDung = dateEditNgayKetThuc.DateTime.ToString("dd/MM/yyyy");
                }

                objCauHinh = listCauHinhPhanHoi.Find(p => p.MaCauHinh == "NamHoc");
                if (objCauHinh != null)
                {
                    if (objCauHinh.NoiDung != cboNamHoc.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.NoiDung = cboNamHoc.Text;
                }

                objCauHinh = listCauHinhPhanHoi.Find(p => p.MaCauHinh == "HocKy");
                if (objCauHinh != null)
                {
                    if (objCauHinh.NoiDung != cboHocKy.Text)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.NoiDung = cboHocKy.Text;
                }

                objCauHinh = listCauHinhPhanHoi.Find(p => p.MaCauHinh == "ChoPhepPhanHoi");
                if (objCauHinh != null)
                {
                    if (bool.Parse(objCauHinh.NoiDung) != ckPhanHoi.Checked)
                        objCauHinh.NgayCapNhat = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    objCauHinh.NoiDung = ckPhanHoi.Checked.ToString();
                }
            }
            catch
            {
                XtraMessageBox.Show("Lỗi cập nhật dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (listCauHinhPhanHoi != null)
                {
                    try
                    {
                        DataServices.CauHinhGiangVienPhanHoi.Save(listCauHinhPhanHoi);
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xãy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    XtraMessageBox.Show("Đã xãy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
