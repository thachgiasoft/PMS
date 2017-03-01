using System;
using DevExpress.XtraEditors;
using PMS.Core;

namespace PMS.UI.Forms.Menus
{
    public partial class frmNavigation : XtraForm
    {
        public frmNavigation()
        {
            InitializeComponent();
        }

        private void frmNavigation_Load(object sender, EventArgs e)
        {
            AppSystem sys = new AppSystem();
            sys.LoadModules(this, navBarControl, pContainer, SimageCollection);
            if (navBarControl.Groups.Count > 0)
            {
                if (navBarControl.Groups[0].ItemLinks.Count > 0)
                    navBarControl.Groups[0].ItemLinks[0].PerformClick();
            }
        }
    }
}