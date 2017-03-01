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
	/// Represents the DataRepository.VGiangVienChucVuProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(VGiangVienChucVuDataSourceDesigner))]
	public class VGiangVienChucVuDataSource : ReadOnlyDataSource<VGiangVienChucVu>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VGiangVienChucVuDataSource class.
		/// </summary>
		public VGiangVienChucVuDataSource() : base(new VGiangVienChucVuService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the VGiangVienChucVuDataSourceView used by the VGiangVienChucVuDataSource.
		/// </summary>
		protected VGiangVienChucVuDataSourceView VGiangVienChucVuView
		{
			get { return ( View as VGiangVienChucVuDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the VGiangVienChucVuDataSourceView class that is to be
		/// used by the VGiangVienChucVuDataSource.
		/// </summary>
		/// <returns>An instance of the VGiangVienChucVuDataSourceView class.</returns>
		protected override BaseDataSourceView<VGiangVienChucVu, Object> GetNewDataSourceView()
		{
			return new VGiangVienChucVuDataSourceView(this, DefaultViewName);
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
	/// Supports the VGiangVienChucVuDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class VGiangVienChucVuDataSourceView : ReadOnlyDataSourceView<VGiangVienChucVu>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VGiangVienChucVuDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the VGiangVienChucVuDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public VGiangVienChucVuDataSourceView(VGiangVienChucVuDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal VGiangVienChucVuDataSource VGiangVienChucVuOwner
		{
			get { return Owner as VGiangVienChucVuDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal VGiangVienChucVuService VGiangVienChucVuProvider
		{
			get { return Provider as VGiangVienChucVuService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region VGiangVienChucVuDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the VGiangVienChucVuDataSource class.
	/// </summary>
	public class VGiangVienChucVuDataSourceDesigner : ReadOnlyDataSourceDesigner<VGiangVienChucVu>
	{
	}

	#endregion VGiangVienChucVuDataSourceDesigner

	#region VGiangVienChucVuFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VGiangVienChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VGiangVienChucVuFilter : SqlFilter<VGiangVienChucVuColumn>
	{
	}

	#endregion VGiangVienChucVuFilter

	#region VGiangVienChucVuExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VGiangVienChucVu"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VGiangVienChucVuExpressionBuilder : SqlExpressionBuilder<VGiangVienChucVuColumn>
	{
	}
	
	#endregion VGiangVienChucVuExpressionBuilder		
}

