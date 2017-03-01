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

public partial class KcqNhomKhoiLuongEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "KcqNhomKhoiLuongEdit.aspx?{0}", KcqNhomKhoiLuongDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "KcqNhomKhoiLuongEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "KcqNhomKhoiLuong.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaNhom");
	}
	protected void GridViewKcqLoaiKhoiLuong1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaLoaiKhoiLuong={0}", GridViewKcqLoaiKhoiLuong1.SelectedDataKey.Values[0]);
		Response.Redirect("KcqLoaiKhoiLuongEdit.aspx?" + urlParams, true);		
	}	
}


