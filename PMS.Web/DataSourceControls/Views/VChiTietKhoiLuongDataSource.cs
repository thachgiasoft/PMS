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
	/// Represents the DataRepository.VChiTietKhoiLuongProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(VChiTietKhoiLuongDataSourceDesigner))]
	public class VChiTietKhoiLuongDataSource : ReadOnlyDataSource<VChiTietKhoiLuong>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VChiTietKhoiLuongDataSource class.
		/// </summary>
		public VChiTietKhoiLuongDataSource() : base(new VChiTietKhoiLuongService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the VChiTietKhoiLuongDataSourceView used by the VChiTietKhoiLuongDataSource.
		/// </summary>
		protected VChiTietKhoiLuongDataSourceView VChiTietKhoiLuongView
		{
			get { return ( View as VChiTietKhoiLuongDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the VChiTietKhoiLuongDataSourceView class that is to be
		/// used by the VChiTietKhoiLuongDataSource.
		/// </summary>
		/// <returns>An instance of the VChiTietKhoiLuongDataSourceView class.</returns>
		protected override BaseDataSourceView<VChiTietKhoiLuong, Object> GetNewDataSourceView()
		{
			return new VChiTietKhoiLuongDataSourceView(this, DefaultViewName);
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
	/// Supports the VChiTietKhoiLuongDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class VChiTietKhoiLuongDataSourceView : ReadOnlyDataSourceView<VChiTietKhoiLuong>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VChiTietKhoiLuongDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the VChiTietKhoiLuongDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public VChiTietKhoiLuongDataSourceView(VChiTietKhoiLuongDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal VChiTietKhoiLuongDataSource VChiTietKhoiLuongOwner
		{
			get { return Owner as VChiTietKhoiLuongDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal VChiTietKhoiLuongService VChiTietKhoiLuongProvider
		{
			get { return Provider as VChiTietKhoiLuongService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region VChiTietKhoiLuongDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the VChiTietKhoiLuongDataSource class.
	/// </summary>
	public class VChiTietKhoiLuongDataSourceDesigner : ReadOnlyDataSourceDesigner<VChiTietKhoiLuong>
	{
	}

	#endregion VChiTietKhoiLuongDataSourceDesigner

	#region VChiTietKhoiLuongFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VChiTietKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VChiTietKhoiLuongFilter : SqlFilter<VChiTietKhoiLuongColumn>
	{
	}

	#endregion VChiTietKhoiLuongFilter

	#region VChiTietKhoiLuongExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VChiTietKhoiLuong"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VChiTietKhoiLuongExpressionBuilder : SqlExpressionBuilder<VChiTietKhoiLuongColumn>
	{
	}
	
	#endregion VChiTietKhoiLuongExpressionBuilder		
}

