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

public partial class NhomMonHocEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "NhomMonHocEdit.aspx?{0}", NhomMonHocDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "NhomMonHocEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "NhomMonHoc.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaNhomMon");
	}
	protected void GridViewPhanNhomMonHoc1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewPhanNhomMonHoc1.SelectedDataKey.Values[0]);
		Response.Redirect("PhanNhomMonHocEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewKcqPhanNhomMonHoc2_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewKcqPhanNhomMonHoc2.SelectedDataKey.Values[0]);
		Response.Redirect("KcqPhanNhomMonHocEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewDonGia3_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewDonGia3.SelectedDataKey.Values[0]);
		Response.Redirect("DonGiaEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewSdhPhanNhomMonHoc4_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewSdhPhanNhomMonHoc4.SelectedDataKey.Values[0]);
		Response.Redirect("SdhPhanNhomMonHocEdit.aspx?" + urlParams, true);		
	}	
}


