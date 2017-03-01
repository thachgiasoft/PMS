#region Using directives

using System;
using System.ComponentModel;

#endregion

namespace PMS.Entities
{	
	///<summary>
	/// An object representation of the 'View_Lop' view. [No description found in the database]	
	///</summary>
	/// <remarks>
	/// This file is generated once and will never be overwritten.
	/// </remarks>	
	[Serializable]
	[CLSCompliant(true)]
	public partial class ViewLop : ViewLopBase
	{
		#region Constructors

		///<summary>
		/// Creates a new <see cref="ViewLop"/> instance.
		///</summary>
		public ViewLop():base(){}	
		
		#endregion

        /// <summary>
        /// Gets the NgayCap property.
        /// </summary>
        [DescriptionAttribute(@""), System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
        [DataObjectField(false, false, true)]
        public DateTime? NgayTao { get; set; }

        /// <summary>
        /// Gets the Chon property.
        /// </summary>
        [DescriptionAttribute(@""), System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
        [DataObjectField(false, false, true)]
        public bool Chon { get; set; }

        /// <summary>
        /// Gets the SoTiet property.
        /// </summary>
        [DescriptionAttribute(@""), System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
        [DataObjectField(false, false, true)]
        public int? SoTiet { get; set; }

        /// <summary>
        /// Gets the SoTien property.
        /// </summary>
        [DescriptionAttribute(@""), System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
        [DataObjectField(false, false, true)]
        public decimal? SoTien { get; set; }

        /// <summary>
        /// Gets the Chon property.
        /// </summary>
        [DescriptionAttribute(@""), System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
        [DataObjectField(false, false, true)]
        public bool? SaoChep { get; set; }
	}
}
