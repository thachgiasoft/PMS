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

public partial class UteKhoiLuongGiangDayEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "UteKhoiLuongGiangDayEdit.aspx?{0}", UteKhoiLuongGiangDayDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "UteKhoiLuongGiangDayEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "UteKhoiLuongGiangDay.aspx");
		FormUtil.SetDefaultMode(FormView1, "Id");
	}
	protected void GridViewUteKhoiLuongQuyDoi1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewUteKhoiLuongQuyDoi1.SelectedDataKey.Values[0]);
		Response.Redirect("UteKhoiLuongQuyDoiEdit.aspx?" + urlParams, true);		
	}	
}


