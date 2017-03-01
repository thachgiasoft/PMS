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

public partial class NhomKhoiLuongEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "NhomKhoiLuongEdit.aspx?{0}", NhomKhoiLuongDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "NhomKhoiLuongEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "NhomKhoiLuong.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaNhom");
	}
	protected void GridViewLoaiKhoiLuong1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaLoaiKhoiLuong={0}", GridViewLoaiKhoiLuong1.SelectedDataKey.Values[0]);
		Response.Redirect("LoaiKhoiLuongEdit.aspx?" + urlParams, true);		
	}	
}


