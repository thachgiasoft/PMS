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

public partial class ChucNangEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "ChucNangEdit.aspx?{0}", ChucNangDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "ChucNangEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "ChucNang.aspx");
		FormUtil.SetDefaultMode(FormView1, "Id");
	}
	protected void GridViewChucNang1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewChucNang1.SelectedDataKey.Values[0]);
		Response.Redirect("ChucNangEdit.aspx?" + urlParams, true);		
	}	
}


