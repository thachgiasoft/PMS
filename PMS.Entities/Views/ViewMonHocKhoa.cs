#region Using directives

using System;
using System.ComponentModel;

#endregion

namespace PMS.Entities
{	
	///<summary>
	/// An object representation of the 'View_MonHoc_Khoa' view. [No description found in the database]	
	///</summary>
	/// <remarks>
	/// This file is generated once and will never be overwritten.
	/// </remarks>	
	[Serializable]
	[CLSCompliant(true)]
	public partial class ViewMonHocKhoa : ViewMonHocKhoaBase
	{
		#region Constructors

		///<summary>
		/// Creates a new <see cref="ViewMonHocKhoa"/> instance.
		///</summary>
		public ViewMonHocKhoa():base(){}	
		
		#endregion

        /// <summary>
        /// Gets the NgayCap property.
        /// </summary>
        [DescriptionAttribute(@""), System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
        [DataObjectField(false, false, true)]
        public DateTime? NgayPhanCong { get; set; }

        /// <summary>
        /// Gets the Chon property.
        /// </summary>
        [DescriptionAttribute(@""), System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
        [DataObjectField(false, false, true)]
        public bool Chon { get; set; }
	}
}
