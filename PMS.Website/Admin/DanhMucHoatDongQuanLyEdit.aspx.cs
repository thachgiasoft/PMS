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

public partial class DanhMucHoatDongQuanLyEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "DanhMucHoatDongQuanLyEdit.aspx?{0}", DanhMucHoatDongQuanLyDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "DanhMucHoatDongQuanLyEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "DanhMucHoatDongQuanLy.aspx");
		FormUtil.SetDefaultMode(FormView1, "Id");
	}
	protected void GridViewNoiDungCongViecQuanLy1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewNoiDungCongViecQuanLy1.SelectedDataKey.Values[0]);
		Response.Redirect("NoiDungCongViecQuanLyEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewGiangVienHoatDongQuanLy2_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewGiangVienHoatDongQuanLy2.SelectedDataKey.Values[0]);
		Response.Redirect("GiangVienHoatDongQuanLyEdit.aspx?" + urlParams, true);		
	}	
}


