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

public partial class ChucVuEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "ChucVuEdit.aspx?{0}", ChucVuDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "ChucVuEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "ChucVu.aspx");
		FormUtil.SetDefaultMode(FormView1, "MaChucVu");
	}
	protected void GridViewDinhMucGioChuanToiThieuTheoChucVu1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewDinhMucGioChuanToiThieuTheoChucVu1.SelectedDataKey.Values[0]);
		Response.Redirect("DinhMucGioChuanToiThieuTheoChucVuEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewGiangVienChucVu2_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaQuanLy={0}&MaGiangVien={1}&MaChucVu={2}", GridViewGiangVienChucVu2.SelectedDataKey.Values[0], GridViewGiangVienChucVu2.SelectedDataKey.Values[1], GridViewGiangVienChucVu2.SelectedDataKey.Values[2]);
		Response.Redirect("GiangVienChucVuEdit.aspx?" + urlParams, true);		
	}	
}


