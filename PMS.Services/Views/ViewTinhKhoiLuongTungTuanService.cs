
#region Using Directives
using System;
using System.ComponentModel;
using System.Collections;
using System.Xml.Serialization;
using System.Data;

using PMS.Entities;
using PMS.Entities.Validation;

using PMS.Data;
using Microsoft.Practices.EnterpriseLibrary.Logging;

#endregion

namespace PMS.Services
{		
	
	///<summary>
	/// An component type implementation of the 'View_Tinh_KhoiLuong_TungTuan' table.
	///</summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class ViewTinhKhoiLuongTungTuanService : PMS.Services.ViewTinhKhoiLuongTungTuanServiceBase
	{
		/// <summary>
		/// Initializes a new instance of the ViewTinhKhoiLuongTungTuanService class.
		/// </summary>
		public ViewTinhKhoiLuongTungTuanService() : base()
		{
		}
		
	}//End Class


} // end namespace
