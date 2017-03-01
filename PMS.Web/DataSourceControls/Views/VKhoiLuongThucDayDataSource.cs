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
	/// Represents the DataRepository.VKhoiLuongThucDayProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(VKhoiLuongThucDayDataSourceDesigner))]
	public class VKhoiLuongThucDayDataSource : ReadOnlyDataSource<VKhoiLuongThucDay>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VKhoiLuongThucDayDataSource class.
		/// </summary>
		public VKhoiLuongThucDayDataSource() : base(new VKhoiLuongThucDayService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the VKhoiLuongThucDayDataSourceView used by the VKhoiLuongThucDayDataSource.
		/// </summary>
		protected VKhoiLuongThucDayDataSourceView VKhoiLuongThucDayView
		{
			get { return ( View as VKhoiLuongThucDayDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the VKhoiLuongThucDayDataSourceView class that is to be
		/// used by the VKhoiLuongThucDayDataSource.
		/// </summary>
		/// <returns>An instance of the VKhoiLuongThucDayDataSourceView class.</returns>
		protected override BaseDataSourceView<VKhoiLuongThucDay, Object> GetNewDataSourceView()
		{
			return new VKhoiLuongThucDayDataSourceView(this, DefaultViewName);
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
	/// Supports the VKhoiLuongThucDayDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class VKhoiLuongThucDayDataSourceView : ReadOnlyDataSourceView<VKhoiLuongThucDay>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the VKhoiLuongThucDayDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the VKhoiLuongThucDayDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public VKhoiLuongThucDayDataSourceView(VKhoiLuongThucDayDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal VKhoiLuongThucDayDataSource VKhoiLuongThucDayOwner
		{
			get { return Owner as VKhoiLuongThucDayDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal VKhoiLuongThucDayService VKhoiLuongThucDayProvider
		{
			get { return Provider as VKhoiLuongThucDayService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region VKhoiLuongThucDayDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the VKhoiLuongThucDayDataSource class.
	/// </summary>
	public class VKhoiLuongThucDayDataSourceDesigner : ReadOnlyDataSourceDesigner<VKhoiLuongThucDay>
	{
	}

	#endregion VKhoiLuongThucDayDataSourceDesigner

	#region VKhoiLuongThucDayFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VKhoiLuongThucDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VKhoiLuongThucDayFilter : SqlFilter<VKhoiLuongThucDayColumn>
	{
	}

	#endregion VKhoiLuongThucDayFilter

	#region VKhoiLuongThucDayExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="VKhoiLuongThucDay"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class VKhoiLuongThucDayExpressionBuilder : SqlExpressionBuilder<VKhoiLuongThucDayColumn>
	{
	}
	
	#endregion VKhoiLuongThucDayExpressionBuilder		
}

