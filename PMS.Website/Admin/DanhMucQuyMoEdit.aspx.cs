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

public partial class DanhMucQuyMoEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "DanhMucQuyMoEdit.aspx?{0}", DanhMucQuyMoDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "DanhMucQuyMoEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "DanhMucQuyMo.aspx");
		FormUtil.SetDefaultMode(FormView1, "Id");
	}
	protected void GridViewDinhMucGioChuanToiThieuTheoChucVu1_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("Id={0}", GridViewDinhMucGioChuanToiThieuTheoChucVu1.SelectedDataKey.Values[0]);
		Response.Redirect("DinhMucGioChuanToiThieuTheoChucVuEdit.aspx?" + urlParams, true);		
	}	
	protected void GridViewQuyMoKhoa2_SelectedIndexChanged(object sender, EventArgs e)
	{
		string urlParams = string.Format("MaKhoa={0}", GridViewQuyMoKhoa2.SelectedDataKey.Values[0]);
		Response.Redirect("QuyMoKhoaEdit.aspx?" + urlParams, true);		
	}	
}


