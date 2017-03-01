#region Imports...
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using PMS.Web.UI;
#endregion

public partial class SdhHeSoDiaDiemEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "SdhHeSoDiaDiemEdit.aspx?{0}", SdhHeSoDiaDiemDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "SdhHeSoDiaDiemEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "SdhHeSoDiaDiem.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaHeSo");
	}
}


