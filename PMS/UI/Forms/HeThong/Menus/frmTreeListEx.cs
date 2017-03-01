using System;
using PMS.Core;

namespace PMS.UI.Forms.Menus
{
    public partial class frmTreeListEx : DevExpress.XtraEditors.XtraForm
    {
        public frmTreeListEx()
        {
            InitializeComponent();
        }

        private void treeList_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            AppSystem.TreeListModulesFocused(pContainer, e);
        }

        private void frmTreeListEx_Load(object sender, EventArgs e)
        {
            AppSystem.LoadModules(this, treeList, imageCollection);
            treeList.ExpandAll();
        }
    }
}