
using System;

namespace PMS.Entities
{
	/// <summary>
	/// An enum representation of the 'TinhTrang' table. [No description found in the database]
	/// </summary>
	/// <remark>this enumeration contains the items contained in the table TinhTrang</remark>
	[Serializable, Flags]
	public enum TinhTrangList
	{
		/// <summary> 
		/// Còn dạy
		/// </summary>
		[EnumTextValue(@"Còn dạy")]
		CD = 1, 

		/// <summary> 
		/// Tạm ngưng
		/// </summary>
		[EnumTextValue(@"Tạm ngưng")]
		TD = 2

	}
}
