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
	/// Represents the DataRepository.ViewLietKeKhoiLuongGiangDayChiTietUsshProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[CLSCompliant(true)]
	[Designer(typeof(ViewLietKeKhoiLuongGiangDayChiTietUsshDataSourceDesigner))]
	public class ViewLietKeKhoiLuongGiangDayChiTietUsshDataSource : ReadOnlyDataSource<ViewLietKeKhoiLuongGiangDayChiTietUssh>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshDataSource class.
		/// </summary>
		public ViewLietKeKhoiLuongGiangDayChiTietUsshDataSource() : base(new ViewLietKeKhoiLuongGiangDayChiTietUsshService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ViewLietKeKhoiLuongGiangDayChiTietUsshDataSourceView used by the ViewLietKeKhoiLuongGiangDayChiTietUsshDataSource.
		/// </summary>
		protected ViewLietKeKhoiLuongGiangDayChiTietUsshDataSourceView ViewLietKeKhoiLuongGiangDayChiTietUsshView
		{
			get { return ( View as ViewLietKeKhoiLuongGiangDayChiTietUsshDataSourceView ); }
		}
		
		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshDataSourceView class that is to be
		/// used by the ViewLietKeKhoiLuongGiangDayChiTietUsshDataSource.
		/// </summary>
		/// <returns>An instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshDataSourceView class.</returns>
		protected override BaseDataSourceView<ViewLietKeKhoiLuongGiangDayChiTietUssh, Object> GetNewDataSourceView()
		{
			return new ViewLietKeKhoiLuongGiangDayChiTietUsshDataSourceView(this, DefaultViewName);
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
	/// Supports the ViewLietKeKhoiLuongGiangDayChiTietUsshDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ViewLietKeKhoiLuongGiangDayChiTietUsshDataSourceView : ReadOnlyDataSourceView<ViewLietKeKhoiLuongGiangDayChiTietUssh>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ViewLietKeKhoiLuongGiangDayChiTietUsshDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ViewLietKeKhoiLuongGiangDayChiTietUsshDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ViewLietKeKhoiLuongGiangDayChiTietUsshDataSourceView(ViewLietKeKhoiLuongGiangDayChiTietUsshDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ViewLietKeKhoiLuongGiangDayChiTietUsshDataSource ViewLietKeKhoiLuongGiangDayChiTietUsshOwner
		{
			get { return Owner as ViewLietKeKhoiLuongGiangDayChiTietUsshDataSource; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ViewLietKeKhoiLuongGiangDayChiTietUsshService ViewLietKeKhoiLuongGiangDayChiTietUsshProvider
		{
			get { return Provider as ViewLietKeKhoiLuongGiangDayChiTietUsshService; }
		}

		#endregion Properties
		
		#region Methods
		
		#endregion Methods
	}

	#region ViewLietKeKhoiLuongGiangDayChiTietUsshDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ViewLietKeKhoiLuongGiangDayChiTietUsshDataSource class.
	/// </summary>
	public class ViewLietKeKhoiLuongGiangDayChiTietUsshDataSourceDesigner : ReadOnlyDataSourceDesigner<ViewLietKeKhoiLuongGiangDayChiTietUssh>
	{
	}

	#endregion ViewLietKeKhoiLuongGiangDayChiTietUsshDataSourceDesigner

	#region ViewLietKeKhoiLuongGiangDayChiTietUsshFilter

	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLietKeKhoiLuongGiangDayChiTietUssh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLietKeKhoiLuongGiangDayChiTietUsshFilter : SqlFilter<ViewLietKeKhoiLuongGiangDayChiTietUsshColumn>
	{
	}

	#endregion ViewLietKeKhoiLuongGiangDayChiTietUsshFilter

	#region ViewLietKeKhoiLuongGiangDayChiTietUsshExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ViewLietKeKhoiLuongGiangDayChiTietUssh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ViewLietKeKhoiLuongGiangDayChiTietUsshExpressionBuilder : SqlExpressionBuilder<ViewLietKeKhoiLuongGiangDayChiTietUsshColumn>
	{
	}
	
	#endregion ViewLietKeKhoiLuongGiangDayChiTietUsshExpressionBuilder		
}

