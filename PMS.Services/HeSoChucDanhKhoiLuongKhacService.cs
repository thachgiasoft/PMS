
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
	/// An component type implementation of the 'HeSoChucDanhKhoiLuongKhac' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class HeSoChucDanhKhoiLuongKhacService : PMS.Services.HeSoChucDanhKhoiLuongKhacServiceBase
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the HeSoChucDanhKhoiLuongKhacService class.
		/// </summary>
		public HeSoChucDanhKhoiLuongKhacService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
