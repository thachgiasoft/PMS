
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
	/// An component type implementation of the 'BangPhuTroiNamHoc' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class BangPhuTroiNamHocService : PMS.Services.BangPhuTroiNamHocServiceBase
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the BangPhuTroiNamHocService class.
		/// </summary>
		public BangPhuTroiNamHocService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
