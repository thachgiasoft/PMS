using System;
using System.Windows.Forms;
using PMS.BLL;
using DevExpress.XtraBars;
using PMS.Services;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Common;

namespace PMS.UI.Forms.HeThong
{
    public partial class frmThongTin : DevExpress.XtraEditors.XtraForm
    {
        //public ViewNamHoc v;
        //public PMS.UI.Forms.NghiepVu.frmCoVanHocTap  frm;
        int i = 1;
        public frmThongTin()
        {
            InitializeComponent();
            //getHocKyCurrent();
           // v = bindingSourceNamHoc.Current as ViewNamHoc;;
            i = 5;
            //cbonamhoc.Properties.DisplayMember = "_namHoc";
            //cbonamhoc.Properties.ValueMember = "_namHoc";

            //cbonamhoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            //new DevExpress.XtraEditors.Controls.LookUpColumnInfo("_namHoc", "")});

            //cbhocky.Properties.DisplayMember = "MaHocKy";
            //cbhocky.Properties.ValueMember = "MaHocKy";

            //cbnamhoc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            //new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaHocKy", "")});

            bindingSourceNamHoc.DataSource = DataServices.ViewNamHoc.GetAll();
            getNamHocCurrent();
        }

        private void linkDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmDoiMatKhau frm = new frmDoiMatKhau()) { frm.ShowDialog(this); }
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            //Gắn tên đăng nhập để lưu log
            PMS.Data.Utility.userID = UserInfo.UserName;

            lblHoTen.Text = UserInfo.FullName;
            lblNhomQuyen.Text = UserInfo.GroupName;
            lblUser.Text = UserInfo.UserName;
            lblThoiGian.Text = DateTime.Now.ToString();
            frmMain.Instance.ItemDangXuat.Caption = UserInfo.UserName;
            if (UserInfo.LoginType == UserTypes.None)
                frmMain.Instance.DangXuat.Width = 35 + UserInfo.UserName.Length;
            else
                frmMain.Instance.DangXuat.Width = 80;
            frmMain.Instance.DangXuat.Hint = UserInfo.UserName;
            frmMain.Instance.DangXuat.Visibility = BarItemVisibility.Always;


            
            ////PMS.UI.Forms.NghiepVu.frmCoVanHocTap frm = new PMS.UI.Forms.NghiepVu.frmCoVanHocTap ();
            //frm.frmtt = this;
            //cbnamhoc.DataBindings.Clear();
            //cbnamhoc.DataBindings.Add("EditValue", bindingSourceNamHoc, "_namHoc", true, DataSourceUpdateMode.OnPropertyChanged);

            //ViewNamHoc objNamHoc = bindingSourceNamHoc.Current as ViewNamHoc;
            //if (objNamHoc != null)
            //{
            //    bindingSourceHocKy.DataSource = DataServices.ViewHocKy.GetByNamHoc(objNamHoc._namHoc);
            //    cbhocky.DataBindings.Clear();
            //    cbhocky.DataBindings.Add("EditValue", bindingSourceHocKy, "MaHocKy", true, DataSourceUpdateMode.OnPropertyChanged);
            //}
            //getHocKyCurrent();
            //getNamHocCurrent();

            //Form activeChild = this.ParentForm.ActiveMdiChild;
            //if (activeChild != null)
            //{
            //    try
            //    {
            //        RichTextBox theBox = (RichTextBox)activeChild.ActiveControl;
            //        if (theBox != null)
            //        {
            //            // Create a new instance of the DataObject interface.
            //            IDataObject data = Clipboard.GetDataObject();
            //            // If the data is text, then set the text of the 
            //            // RichTextBox to the text in the clipboard.
            //            if (data.GetDataPresent(DataFormats.Text))
            //            {
            //                theBox.SelectedText = data.GetData(DataFormats.Text).ToString();
            //            }
            //        }
            //    }
            //    catch
            //    {
            //        MessageBox.Show("You need to select a RichTextBox.");
            //    }
            //}
            i = 4;
        }

        //private void cbnamhoc_EditValueChanged(object sender, EventArgs e)
        //{
        //    getHocKyCurrent();
        //}

        //private void cbHocKy_EditValueChanged(object sender, EventArgs e)
        //{
        //    getHocKyCurrent();
        //}

        public ViewNamHoc getNamHocCurrent()
        {
            //v = this.bindingSourceNamHoc.Current as ViewNamHoc;
            return this.bindingSourceNamHoc.Current as ViewNamHoc;
        }

        public int test()
        {
            return 10;
        }
        
    }
}