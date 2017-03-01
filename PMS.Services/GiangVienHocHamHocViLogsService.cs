	

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
	/// An component type implementation of the 'GiangVien_HocHamHocVi_Logs' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class GiangVienHocHamHocViLogsService : PMS.Services.GiangVienHocHamHocViLogsServiceBase
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the GiangVienHocHamHocViLogsService class.
		/// </summary>
		public GiangVienHocHamHocViLogsService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
