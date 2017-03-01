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

public partial class ThuLaoRaDeThiVhuexEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "ThuLaoRaDeThiVhuexEdit.aspx?{0}", ThuLaoRaDeThiVhuexDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "ThuLaoRaDeThiVhuexEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "ThuLaoRaDeThiVhuex.aspx");
		FormUtil.SetDefaultMode(FormView1, "Id");
	}
}


