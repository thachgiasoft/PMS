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

public partial class KcqKhoiLuongThucTapCuoiKhoaEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "KcqKhoiLuongThucTapCuoiKhoaEdit.aspx?{0}", KcqKhoiLuongThucTapCuoiKhoaDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "KcqKhoiLuongThucTapCuoiKhoaEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "KcqKhoiLuongThucTapCuoiKhoa.aspx");
		FormUtil.SetDefaultMode(FormView1, "Id");
	}
}


