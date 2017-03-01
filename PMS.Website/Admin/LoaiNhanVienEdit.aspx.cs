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

public partial class LoaiNhanVienEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "LoaiNhanVienEdit.aspx?{0}", LoaiNhanVienDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "LoaiNhanVienEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "LoaiNhanVien.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaLoaiNhanVien");
	}
	protected void GridViewGiangVien1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaGiangVien={0}", GridViewGiangVien1.SelectedDataKey.Values[0]);
		Response.Redirect("GiangVienEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewQuyDinhTienCanTren2_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewQuyDinhTienCanTren2.SelectedDataKey.Values[0]);
		Response.Redirect("QuyDinhTienCanTrenEdit.aspx?" + urlParams, true);		
	}	
}


