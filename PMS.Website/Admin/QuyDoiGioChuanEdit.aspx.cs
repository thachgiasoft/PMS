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

public partial class QuyDoiGioChuanEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "QuyDoiGioChuanEdit.aspx?{0}", QuyDoiGioChuanDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "QuyDoiGioChuanEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "QuyDoiGioChuan.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaQuyDoi");
	}
	protected void GridViewKhoiLuongCacCongViecKhac1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}&MaLoaiCongViec={1}", GridViewKhoiLuongCacCongViecKhac1.SelectedDataKey.Values[0], GridViewKhoiLuongCacCongViecKhac1.SelectedDataKey.Values[1]);
		Response.Redirect("KhoiLuongCacCongViecKhacEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewKhoanQuyDoi2_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaKhoan={0}", GridViewKhoanQuyDoi2.SelectedDataKey.Values[0]);
		Response.Redirect("KhoanQuyDoiEdit.aspx?" + urlParams, true);		
	}	
}


