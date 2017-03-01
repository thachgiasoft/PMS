
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
	/// <summary>
	/// An component type implementation of the 'KcqMonHocKhongTinhKhoiLuong' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class KcqMonHocKhongTinhKhoiLuongService : PMS.Services.KcqMonHocKhongTinhKhoiLuongServiceBase
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the KcqMonHocKhongTinhKhoiLuongService class.
		/// </summary>
		public KcqMonHocKhongTinhKhoiLuongService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
