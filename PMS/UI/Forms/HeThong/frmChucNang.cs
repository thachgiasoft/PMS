using System;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.Common.Grid;
using PMS.Entities;
using PMS.Services;
using PMS.Core;

namespace PMS.UI.Forms.HeThong
{
    public partial class frmChucNang : XtraForm
    {
        public int ID { get; set; }
        public int Level { get; set; }

        public frmChucNang()
        {
            InitializeComponent();
        }

        private void frmChucNang_Load(object sender, EventArgs e)
        {
            #region Init PhanLoai
            repositoryItemComboBoxPhanLoai.Items.AddRange(new string[] { "Tab", "Group", "Item", "Module" });
            cboPhanLoai.EditValue = repositoryItemComboBoxPhanLoai.Items[0];
            #endregion

            #region Init Form
            AppRepositoryItemGridLookUpEdit.InitRepositoryItemGridLookUp(repositoryItemGridLookUpEditTenForm, true, DevExpress.XtraEditors.Controls.TextEditStyles.Standard);
            AppRepositoryItemGridLookUpEdit.ShowField(repositoryItemGridLookUpEditTenForm, new string[] { "ID", "Name" }, new string[] { "Mã form", "Tên form" });
            AppRepositoryItemGridLookUpEdit.InitPopupFormSize(repositoryItemGridLookUpEditTenForm, 650, 250);
            repositoryItemGridLookUpEditTenForm.ValueMember = "ID";
            repositoryItemGridLookUpEditTenForm.DisplayMember = "Name";
            repositoryItemGridLookUpEditTenForm.NullText = string.Empty;
            #endregion

            #region Init Datasource
            repositoryItemComboBoxLoai.Items.AddRange(new string[] { "Tab", "Group", "Item", "Module" });
            repositoryItemComboBoxKieuForm.Items.AddRange(new string[] { "Mdi", "Popup" });

            bindingSourceChucNang.DataSource = DataServices.ChucNang.GetAll();
            treeListChucNang.ExpandAll();
            repositoryItemGridLookUpEditTenForm.DataSource = AppSystem.GetForms();
            #endregion
        }

        private void treeListChucNang_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
            {
                ID = (int)e.Node.GetValue("Id");
                Level = e.Node.Level;
            }
        }

        private void treeListChucNang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                Delete();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Add chuc nang
            TList<ChucNang> listChucNang = bindingSourceChucNang.DataSource as TList<ChucNang>;
            if (listChucNang != null)
            {
                ChucNang objChucNang = new ChucNang();
                if (cboPhanLoai.EditValue == repositoryItemComboBoxPhanLoai.Items[0])
                    ID = -1;
                if (ID != -1)//Update remove level != 3
                    objChucNang.ParentId = ID;
                objChucNang.PhanLoai = cboPhanLoai.EditValue.ToString();
                objChucNang.TrangThai = true;
                objChucNang.ThuTu = 0;
                objChucNang.Menu = false;
                objChucNang.BeginGroup = false;
                objChucNang.RibbonStyle = false;
                if (cboPhanLoai.EditValue.ToString() == "Item")
                    objChucNang.KieuForm = "Mdi";
                objChucNang.Validate();
                if (objChucNang.IsValid)
                {
                    listChucNang.Add(objChucNang);
                    try
                    {
                        if (listChucNang.IsValid)
                            DataServices.ChucNang.Save(listChucNang);
                        treeListChucNang.RefreshDataSource();
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình thêm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Delete()
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa dòng này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                treeListChucNang.DeleteSelectedNodes();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Delete();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TList<ChucNang> listChucNang = bindingSourceChucNang.DataSource as TList<ChucNang>;
            if (listChucNang != null)
            {
                if (XtraMessageBox.Show("Bạn có muốn lưu các thay đổi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        DataServices.ChucNang.Save(listChucNang);
                        XtraMessageBox.Show("Bạn đã lưu các thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Đã xảy ra lỗi trong quá trình lưu các thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLamTuoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            bindingSourceChucNang.DataSource = DataServices.ChucNang.GetAll();
            treeListChucNang.ExpandAll();
            Cursor.Current = Cursors.Default;
        }
    }
}