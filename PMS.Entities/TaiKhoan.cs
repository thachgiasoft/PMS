#region Using directives

using System;
using System.ComponentModel;

#endregion

namespace PMS.Entities
{	
	///<summary>
	/// An object representation of the 'TaiKhoan' table. [No description found the database]	
	///</summary>
	/// <remarks>
	/// This file is generated once and will never be overwritten.
	/// </remarks>	
	[Serializable]
	[CLSCompliant(true)]
	public partial class TaiKhoan : TaiKhoanBase
	{		
		#region Constructors

		///<summary>
		/// Creates a new <see cref="TaiKhoan"/> instance.
		///</summary>
		public TaiKhoan():base(){}	
		
		#endregion

        /// <summary>
        /// Gets the Chon property.
        /// </summary>
        [DescriptionAttribute(@""), System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
        [DataObjectField(false, false, true)]
        public bool Chon { get; set; }	
	}
}
