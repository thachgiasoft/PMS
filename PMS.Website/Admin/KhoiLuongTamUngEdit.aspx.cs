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

public partial class KhoiLuongTamUngEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "KhoiLuongTamUngEdit.aspx?{0}", KhoiLuongTamUngDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "KhoiLuongTamUngEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "KhoiLuongTamUng.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaKhoiLuong");
	}
	protected void GridViewQuyDoiKhoiLuongTamUng1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewQuyDoiKhoiLuongTamUng1.SelectedDataKey.Values[0]);
		Response.Redirect("QuyDoiKhoiLuongTamUngEdit.aspx?" + urlParams, true);		
	}	
}


