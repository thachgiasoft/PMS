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

public partial class KcqHeSoQuyDoiTinChiEdit : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{		
		FormUtil.RedirectAfterInsertUpdate(FormView1, "KcqHeSoQuyDoiTinChiEdit.aspx?{0}", KcqHeSoQuyDoiTinChiDataSource);
		FormUtil.RedirectAfterAddNew(FormView1, "KcqHeSoQuyDoiTinChiEdit.aspx");
		FormUtil.RedirectAfterCancel(FormView1, "KcqHeSoQuyDoiTinChi.aspx");
		FormUtil.SetDefaultMode(FormView1, "Id");
	}
}


