using System;
using DevExpress.XtraEditors;
using PMS.Core;

namespace PMS.UI.Forms.Menus
{
    public partial class frmList : XtraForm
    {
        public frmList()
        {
            InitializeComponent();
        }

        private void frmList_Load(object sender, EventArgs e)
        {
            AppSystem.LoadModules(this, treeListChucNang);
        }

        private void treeListChucNang_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            AppSystem.TreeListModulesFocused(pContainer, e);
        }
    }
}