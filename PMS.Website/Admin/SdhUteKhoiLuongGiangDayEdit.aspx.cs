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

public partial class SdhUteKhoiLuongGiangDayEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "SdhUteKhoiLuongGiangDayEdit.aspx?{0}", SdhUteKhoiLuongGiangDayDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "SdhUteKhoiLuongGiangDayEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "SdhUteKhoiLuongGiangDay.aspx");
		FormUtil.SetDefaultMode(FormView1, "Id");
	}
	protected void GridViewSdhUteKhoiLuongQuyDoi1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewSdhUteKhoiLuongQuyDoi1.SelectedDataKey.Values[0]);
		Response.Redirect("SdhUteKhoiLuongQuyDoiEdit.aspx?" + urlParams, true);		
	}	
}


