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

public partial class KhoiLuongGiangDayChiTietEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "KhoiLuongGiangDayChiTietEdit.aspx?{0}", KhoiLuongGiangDayChiTietDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "KhoiLuongGiangDayChiTietEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "KhoiLuongGiangDayChiTiet.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaKhoiLuong");
	}
	protected void GridViewKhoiLuongQuyDoi1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaKhoiLuongQuyDoi={0}", GridViewKhoiLuongQuyDoi1.SelectedDataKey.Values[0]);
		Response.Redirect("KhoiLuongQuyDoiEdit.aspx?" + urlParams, true);		
	}	
}


