	

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
	/// An component type implementation of the 'TruongKhoa' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class TruongKhoaService : PMS.Services.TruongKhoaServiceBase
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the TruongKhoaService class.
		/// </summary>
		public TruongKhoaService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
