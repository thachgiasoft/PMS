using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PMS.UI.Modules.DanhMuc;

namespace PMS.UI.Forms.NghiepVu
{
    public partial class frmMonGiangBangTiengNuocNgoai : Form
    {
        public frmMonGiangBangTiengNuocNgoai()
        {
            InitializeComponent();

            this.Controls.Add(new ucMonHocGiangBangTiengNuocNgoai());
        }
    }
}
