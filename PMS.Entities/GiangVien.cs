#region Using directives

using System;
using System.ComponentModel;

#endregion

namespace PMS.Entities
{	
	///<summary>
	/// An object representation of the 'GiangVien' table. [No description found the database]	
	///</summary>
	/// <remarks>
	/// This file is generated once and will never be overwritten.
	/// </remarks>	
	[Serializable]
	[CLSCompliant(true)]
	public partial class GiangVien : GiangVienBase
	{		
		#region Constructors

		///<summary>
		/// Creates a new <see cref="GiangVien"/> instance.
		///</summary>
		public GiangVien():base(){}	
		
		#endregion

        private string _hoTen = string.Empty;

        /// <summary>
        /// Gets the HoTen property.
        /// </summary>
        [DescriptionAttribute(@""), System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
        [DataObjectField(false, false, true)]
        public string HoTen
        {
            get
            {
                if (string.IsNullOrEmpty(TenDem))
                    return String.Format("{0} {1}", Ho, Ten);
                return String.Format("{0} {1} {2}", Ho, TenDem, Ten);
            }
            set
            {
                if (_hoTen == value)
                    return;
                _hoTen = value;
                Ho = Globals.GetLastName(_hoTen);
                TenDem = Globals.GetMiddleName(_hoTen);
                Ten = Globals.GetFirstName(_hoTen);
            }
        }
        
	}
}
