
#region Using directives
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using PMS.Web.UI;
#endregion

public partial class GiangVienTinhLuongThinhGiang : System.Web.UI.Page
{	
    protected void Page_Load(object sender, EventArgs e)
	{
		FormUtil.RedirectAfterUpdate(GridView1, "GiangVienTinhLuongThinhGiang.aspx?page={0}");
		FormUtil.SetPageIndex(GridView1, "page");
		FormUtil.SetDefaultButton((Button)GridViewSearchPanel1.FindControl("cmdSearch"));
    }

	protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaGiangVien={0}&NamHoc={1}&HocKy={2}&MaCauHinhChotGio={3}&MaMonHoc={4}&MaLopSinhVien={5}", GridView1.SelectedDataKey.Values[0], GridView1.SelectedDataKey.Values[1], GridView1.SelectedDataKey.Values[2], GridView1.SelectedDataKey.Values[3], GridView1.SelectedDataKey.Values[4], GridView1.SelectedDataKey.Values[5]);
		Response.Redirect("GiangVienTinhLuongThinhGiangEdit.aspx?" + urlParams, true);
	}
	
}


