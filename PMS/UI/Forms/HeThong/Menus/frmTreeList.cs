using System;
using DevExpress.XtraEditors;
using PMS.Core;

namespace PMS.UI.Forms.Menus
{
    public partial class frmTreeList : XtraForm
    {
        public frmTreeList()
        {
            InitializeComponent();
        }

        private void frmTreeList_Load(object sender, EventArgs e)
        {
            AppSystem.LoadModules(this, treeListChucNang, simageCollection);
            treeListChucNang.ExpandAll();
        }

        private void treeListChucNang_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            AppSystem.TreeListModulesFocused(pContainer, e);
        }
    }
}