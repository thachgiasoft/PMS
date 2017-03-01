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

public partial class DonViTinhEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "DonViTinhEdit.aspx?{0}", DonViTinhDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "DonViTinhEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "DonViTinh.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaDonVi");
	}
	protected void GridViewQuyDoiGioChuan1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaQuyDoi={0}", GridViewQuyDoiGioChuan1.SelectedDataKey.Values[0]);
		Response.Redirect("QuyDoiGioChuanEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewKcqQuyDoiGioChuan2_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaQuyDoi={0}", GridViewKcqQuyDoiGioChuan2.SelectedDataKey.Values[0]);
		Response.Redirect("KcqQuyDoiGioChuanEdit.aspx?" + urlParams, true);		
	}	
}


