
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
	/// An component type implementation of the 'KcqUte_KhoiLuongGiangDay' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class KcqUteKhoiLuongGiangDayService : PMS.Services.KcqUteKhoiLuongGiangDayServiceBase
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongGiangDayService class.
		/// </summary>
		public KcqUteKhoiLuongGiangDayService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
