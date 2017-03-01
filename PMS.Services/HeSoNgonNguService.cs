	

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
	/// An component type implementation of the 'HeSoNgonNgu' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class HeSoNgonNguService : PMS.Services.HeSoNgonNguServiceBase
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the HeSoNgonNguService class.
		/// </summary>
		public HeSoNgonNguService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
