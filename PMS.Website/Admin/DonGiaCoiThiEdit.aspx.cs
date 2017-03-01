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

public partial class DonGiaCoiThiEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "DonGiaCoiThiEdit.aspx?{0}", DonGiaCoiThiDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "DonGiaCoiThiEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "DonGiaCoiThi.aspx");
		FormUtil.SetDefaultMode(FormView1, "Id");
	}
}


