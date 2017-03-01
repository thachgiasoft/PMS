#region Using directives

using System;
using System.ComponentModel;

#endregion

namespace PMS.Entities
{
    ///<summary>
    /// An object representation of the 'ChucVu' table. [No description found the database]	
    ///</summary>
    /// <remarks>
    /// This file is generated once and will never be overwritten.
    /// </remarks>	
    [Serializable]
    [CLSCompliant(true)]
    public partial class ChucVu : ChucVuBase
    {
        #region Constructors

        ///<summary>
        /// Creates a new <see cref="ChucVu"/> instance.
        ///</summary>
        public ChucVu() : base() { }

        #endregion

        /// <summary>
        /// Gets the NgayHieuLuc property.
        /// </summary>
        [DescriptionAttribute(@""), System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
        [DataObjectField(false, false, true)]
        public string NgayHieuLuc { get; set; }


        /// <summary>
        /// Gets the NgayHetHieuLuc property.
        /// </summary>
        [DescriptionAttribute(@""), System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
        [DataObjectField(false, false, true)]
        public string NgayHetHieuLuc { get; set; }

        /// <summary>
        /// Gets the Chon property.
        /// </summary>
        [DescriptionAttribute(@""), System.ComponentModel.Bindable(System.ComponentModel.BindableSupport.Yes)]
        [DataObjectField(false, false, true)]
        public bool Chon { get; set; }     
    }
}