#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.VLopHocPhanKhongPhanCongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(VLopHocPhanKhongPhanCongDataSourceDesigner))]
	public class VLopHocPhanKhongPhanCongDataSource : ReadOnlyDataSource<VLopHocPhanKhongPhanCong>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VLopHocPhanKhongPhanCongDataSource class.
		/// </summary>
		public VLopHocPhanKhongPhanCongDataSource() : base(new VLopHocPhanKhongPhanCongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the VLopHocPhanKhongPhanCongDataSourceView used by the VLopHocPhanKhongPhanCongDataSource.
		/// </summary>
		protected VLopHocPhanKhongPhanCongDataSourceView VLopHocPhanKhongPhanCongView
		{
			get { return ( View as VLopHocPhanKhongPhanCongDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the VLopHocPhanKhongPhanCongDataSourceView class that is to be
		/// used by the VLopHocPhanKhongPhanCongDataSource.
		/// </summary>
		/// <returns>An instance of the VLopHocPhanKhongPhanCongDataSourceView class.</returns>
		protected override BaseDataSourceView<VLopHocPhanKhongPhanCong, Object> GetNewDataSourceView()
		{
			return new VLopHocPhanKhongPhanCongDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the VLopHocPhanKhongPhanCongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class VLopHocPhanKhongPhanCongDataSourceView : ReadOnlyDataSourceView<VLopHocPhanKhongPhanCong>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VLopHocPhanKhongPhanCongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the VLopHocPhanKhongPhanCongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public VLopHocPhanKhongPhanCongDataSourceView(VLopHocPhanKhongPhanCongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal VLopHocPhanKhongPhanCongDataSource VLopHocPhanKhongPhanCongOwner
		{
			get { return Owner as VLopHocPhanKhongPhanCongDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal VLopHocPhanKhongPhanCongService VLopHocPhanKhongPhanCongProvider
		{
			get { return Provider as VLopHocPhanKhongPhanCongService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region VLopHocPhanKhongPhanCongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the VLopHocPhanKhongPhanCongDataSource class.
	/// </summary>
	public class VLopHocPhanKhongPhanCongDataSourceDesigner : ReadOnlyDataSourceDesigner<VLopHocPhanKhongPhanCong>
	{
	}

	#endregion VLopHocPhanKhongPhanCongDataSourceDesigner

	#region VLopHocPhanKhongPhanCongFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VLopHocPhanKhongPhanCong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VLopHocPhanKhongPhanCongFilter : SqlFilter<VLopHocPhanKhongPhanCongColumn>
	{
	}

	#endregion VLopHocPhanKhongPhanCongFilter

	#region VLopHocPhanKhongPhanCongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VLopHocPhanKhongPhanCong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VLopHocPhanKhongPhanCongExpressionBuilder : SqlExpressionBuilder<VLopHocPhanKhongPhanCongColumn>
	{
	}
	
	#endregion VLopHocPhanKhongPhanCongExpressionBuilder		
}

