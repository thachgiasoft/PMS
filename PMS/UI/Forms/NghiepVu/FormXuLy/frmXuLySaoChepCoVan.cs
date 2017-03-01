using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Common.Grid;
using DevExpress.XtraEditors.Controls;
using PMS.Entities;
using PMS.Services;
using PMS.BLL;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmXuLySaoChepCoVan : DevExpress.XtraEditors.XtraForm
    {
        TList<CauHinhChung> cauHinh = DataServices.CauHinhChung.GetAll();
        string _coVanTheoNam;
        public frmXuLySaoChepCoVan()
        {
            InitializeComponent();
            _coVanTheoNam = cauHinh.Find(p => p.TenCauHinh == "Cố vấn học tập phân theo năm học").GiaTri;
            if (_coVanTheoNam == "True")
            {
                layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
        }
        private void frmXuLySaoChepCoVan_Load(object sender, EventArgs e)
        {

            #region Nam hoc
            AppGridLookupEdit.InitGridLookUp(cboNamHocGoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHocGoc, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHocGoc.Properties.ValueMember = "NamHoc";
            cboNamHocGoc.Properties.DisplayMember = "NamHoc";
            cboNamHocGoc.Properties.NullText = string.Empty;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKyGoc, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKyGoc, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKyGoc.Properties.ValueMember = "MaHocKy";
            cboHocKyGoc.Properties.DisplayMember = "TenHocKy";
            cboHocKyGoc.Properties.NullText = string.Empty;
            #endregion

            #region Nam hoc sao chep
            AppGridLookupEdit.InitGridLookUp(cboNamHocSaoChep, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboNamHocSaoChep, new string[] { "NamHoc" }, new string[] { "Năm học" });
            cboNamHocSaoChep.Properties.ValueMember = "NamHoc";
            cboNamHocSaoChep.Properties.DisplayMember = "NamHoc";
            cboNamHocSaoChep.Properties.NullText = string.Empty;
            #endregion

            #region Hoc ky
            AppGridLookupEdit.InitGridLookUp(cboHocKySaoChep, true, TextEditStyles.Standard);
            AppGridLookupEdit.ShowField(cboHocKySaoChep, new string[] { "MaHocKy", "TenHocKy" }, new string[] { "Mã học kỳ", "Học kỳ" });
            cboHocKySaoChep.Properties.ValueMember = "MaHocKy";
            cboHocKySaoChep.Properties.DisplayMember = "TenHocKy";
            cboHocKySaoChep.Properties.NullText = string.Empty;
            #endregion

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            cboNamHocGoc.DataBindings.Add("EditValue", bindingSourceNamHoc, "NamHoc", true, DataSourceUpdateMode.OnPropertyChanged);

            bindingSourceNamSaoChep.DataSource = ((VList<ViewNamHoc>)bindingSourceNamHoc.DataSource).Copy();
            cboNamHocSaoChep.DataBindings.Add("EditValue", bindingSourceNamSaoChep, "NamHoc", true, DataSourceUpdateMode.OnPropertyChanged);

            ViewNamHoc objNamHoc = bindingSourceNamHoc.Current as ViewNamHoc;
            if (objNamHoc != null)
            {
                bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(objNamHoc.NamHoc);
                cboHocKyGoc.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);

                bindingSourceHocKySaoChep.DataSource = ((VList<ViewHocKy>)bindingSourceHocKy.DataSource).Copy();
                cboHocKySaoChep.DataBindings.Add("EditValue", bindingSourceHocKySaoChep, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
            }

            bindingSourceKhoaHoc.DataSource = DataServices.ViewKhoaHoc.GetAll();
            chkKhoaHoc.Properties.ValueMember = "MaKhoaHoc";
            chkKhoaHoc.Properties.DisplayMember = "MaKhoaHoc";
            chkKhoaHoc.Properties.NullText = string.Empty;
            chkKhoaHoc.Properties.SelectAllItemCaption = "Tất cả";
        }

        public string GetMaKhoaHoc()
        {
            string s = string.Empty;
            foreach (CheckedListBoxItem item in chkKhoaHoc.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                    s += item.Value.ToString() + ",";
            }
            return s;
        }

        private void cboNamHocGoc_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                ViewNamHoc objNamHoc = cboNamHocGoc.Properties.GetRowByKeyValue(e.Value) as ViewNamHoc;
                if (objNamHoc != null)
                {
                    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(objNamHoc.NamHoc);
                    cboHocKyGoc.DataBindings.Clear();
                    cboHocKyGoc.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
        }

        private void cboNamHocSaoChep_CloseUp(object sender, CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                ViewNamHoc objNamHoc = cboNamHocSaoChep.Properties.GetRowByKeyValue(e.Value) as ViewNamHoc;
                if (objNamHoc != null)
                {
                    bindingSourceHocKySaoChep.DataSource = DataServices.ViewHocKy.GetByNamHoc(objNamHoc.NamHoc);
                    cboHocKySaoChep.DataBindings.Clear();
                    cboHocKySaoChep.DataBindings.Add("EditValue", bindingSourceHocKySaoChep, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            ViewHocKy objHocKy = bindingSourceHocKy.Current as ViewHocKy;
            if (objHocKy == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboHocKyGoc.Focus();
                return;
            }
            ViewHocKy objHocKySaoChep = bindingSourceHocKySaoChep.Current as ViewHocKy;
            if (objHocKySaoChep == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn năm học - học kỳ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboHocKySaoChep.Focus();
                return;
            }
            string s = string.Format("Bạn đã hoàn tất sao chép cố vấn học tập cho năm học {0} học kỳ {1}.", objHocKySaoChep.NamHoc, objHocKySaoChep.MaHocKy);
            string v = string.Format("Bạn có muốn sao chép cố vấn học tập cho năm {0} học kỳ {1} không ?", objHocKySaoChep.NamHoc, objHocKySaoChep.MaHocKy);
            if (_coVanTheoNam == "True")
            {
                s = string.Format("Bạn đã hoàn tất sao chép cố vấn học tập cho năm học {0}.", objHocKySaoChep.NamHoc);
                v = string.Format("Bạn có muốn sao chép cố vấn học tập cho năm {0} không ?", objHocKySaoChep.NamHoc);
            }
            if (XtraMessageBox.Show(v, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    foreach (CoVanHocTap obj in DataServices.CoVanHocTap.GetByNamHocHocKyMaKhoaHoc(objHocKy.NamHoc, objHocKy.MaHocKy, GetMaKhoaHoc()))
                    {

                        DataServices.CoVanHocTap.InsertUpdate(obj.MaGiangVien, objHocKySaoChep.NamHoc, objHocKySaoChep.MaHocKy, obj.MaLop, obj.MaKhoaHoc, DateTime.Now.Date, obj.SoTiet, obj.SoTien, chkSaoChep.Checked, UserInfo.UserName);
                    }
                  
                    XtraMessageBox.Show(s, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Cursor.Current = Cursors.Default;
            }
        }
    }
}