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
	/// Represents the DataRepository.VTongHopKhoiLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(VTongHopKhoiLuongDataSourceDesigner))]
	public class VTongHopKhoiLuongDataSource : ReadOnlyDataSource<VTongHopKhoiLuong>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VTongHopKhoiLuongDataSource class.
		/// </summary>
		public VTongHopKhoiLuongDataSource() : base(new VTongHopKhoiLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the VTongHopKhoiLuongDataSourceView used by the VTongHopKhoiLuongDataSource.
		/// </summary>
		protected VTongHopKhoiLuongDataSourceView VTongHopKhoiLuongView
		{
			get { return ( View as VTongHopKhoiLuongDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the VTongHopKhoiLuongDataSourceView class that is to be
		/// used by the VTongHopKhoiLuongDataSource.
		/// </summary>
		/// <returns>An instance of the VTongHopKhoiLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<VTongHopKhoiLuong, Object> GetNewDataSourceView()
		{
			return new VTongHopKhoiLuongDataSourceView(this, DefaultViewName);
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
	/// Supports the VTongHopKhoiLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class VTongHopKhoiLuongDataSourceView : ReadOnlyDataSourceView<VTongHopKhoiLuong>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VTongHopKhoiLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the VTongHopKhoiLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public VTongHopKhoiLuongDataSourceView(VTongHopKhoiLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal VTongHopKhoiLuongDataSource VTongHopKhoiLuongOwner
		{
			get { return Owner as VTongHopKhoiLuongDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal VTongHopKhoiLuongService VTongHopKhoiLuongProvider
		{
			get { return Provider as VTongHopKhoiLuongService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region VTongHopKhoiLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the VTongHopKhoiLuongDataSource class.
	/// </summary>
	public class VTongHopKhoiLuongDataSourceDesigner : ReadOnlyDataSourceDesigner<VTongHopKhoiLuong>
	{
	}

	#endregion VTongHopKhoiLuongDataSourceDesigner

	#region VTongHopKhoiLuongFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VTongHopKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VTongHopKhoiLuongFilter : SqlFilter<VTongHopKhoiLuongColumn>
	{
	}

	#endregion VTongHopKhoiLuongFilter

	#region VTongHopKhoiLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VTongHopKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VTongHopKhoiLuongExpressionBuilder : SqlExpressionBuilder<VTongHopKhoiLuongColumn>
	{
	}
	
	#endregion VTongHopKhoiLuongExpressionBuilder		
}

