	

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
	/// An component type implementation of the 'LopHocPhan_BacDaoTao' table.
	/// </summary>
	/// <remarks>
	/// All custom implementations should be done here.
	/// </remarks>
	[CLSCompliant(true)]
	public partial class LopHocPhanBacDaoTaoService : PMS.Services.LopHocPhanBacDaoTaoServiceBase
	{
		#region Constructors
		/// <summary>
		/// Initializes a new instance of the LopHocPhanBacDaoTaoService class.
		/// </summary>
		public LopHocPhanBacDaoTaoService() : base()
		{
		}
		#endregion Constructors
		
	}//End Class

} // end namespace
