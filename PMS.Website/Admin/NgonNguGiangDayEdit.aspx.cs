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

public partial class NgonNguGiangDayEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "NgonNguGiangDayEdit.aspx?{0}", NgonNguGiangDayDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "NgonNguGiangDayEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "NgonNguGiangDay.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaNgonNgu");
	}
	protected void GridViewDonGia1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewDonGia1.SelectedDataKey.Values[0]);
		Response.Redirect("DonGiaEdit.aspx?" + urlParams, true);		
	}	
}


