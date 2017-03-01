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

public partial class KhoiLuongKhacEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "KhoiLuongKhacEdit.aspx?{0}", KhoiLuongKhacDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "KhoiLuongKhacEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "KhoiLuongKhac.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaKhoiLuong");
	}
	protected void GridViewChiTietKhoiLuong1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaChiTiet={0}", GridViewChiTietKhoiLuong1.SelectedDataKey.Values[0]);
		Response.Redirect("ChiTietKhoiLuongEdit.aspx?" + urlParams, true);		
	}	
}


